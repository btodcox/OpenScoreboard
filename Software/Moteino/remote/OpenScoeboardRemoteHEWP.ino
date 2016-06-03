
/*
 * OpenScoreboard is an Eagle Scout project by David Cox
 *
 *
 * portions of code are:
 * Copyright (c) 2013 by Felix Rusu <felix@lowpowerlab.com>
 *
 * Code by Felix Rusu is free software; you can redistribute it and/or modify
 * it under the terms of either the GNU General Public License version 2
 * or the GNU Lesser General Public License version 2.1, both as
 * published by the Free Software Foundation.
 * 
 *
 * additional code for a scoreboard is 
 * Copyright (c) 2014-15 by B Tod Cox & David Cox  
 *  all rights reserved.

// This sketch is an example of how wireless programming can be achieved with a Moteino
// that was loaded with a custom 1k Optiboot that is capable of loading a new sketch from
// an external SPI flash chip
// The sketch includes logic to receive the new sketch 'over-the-air' and store it in
// the FLASH chip, then restart the Moteino so the bootloader can continue the job of
// actually reflashing the internal flash memory from the external FLASH memory chip flash image
// The handshake protocol that receives the sketch wirelessly by means of the RFM69 radio
// is handled by the SPIFLash/WirelessHEX69 library, which also relies on the RFM69 library
// These libraries and custom 1k Optiboot bootloader are at: http://github.com/lowpowerlab

#include "HT1632n.h"
#include "Adafruit_GFX.h"
#include "OSBfont.h"
#include "glcdfontn.c"

#include <EEPROM.h>

#include <RFM69.h>
#include <SPI.h>
#include <SPIFlash.h>
#include <avr/wdt.h>
#include <WirelessHEX69.h>

//#define MYID        1       // node ID used for this unit
int my_id;  //no longer a define so that can read value from eeprom and have same program for all lanes
#define NETWORKID   124
//Match frequency to the hardware version of the radio on your Moteino (uncomment one):
//#define FREQUENCY   RF69_433MHZ
//#define FREQUENCY   RF69_868MHZ
#define FREQUENCY     RF69_915MHZ
#define IS_RFM69HW  //uncomment only for RFM69HW! Leave out if you have RFM69W!
#define SERIAL_BAUD 115200
#define ACK_TIME    50  // # of ms to wait for an ack
#define ENCRYPTKEY  "GatorsEncryptKey"
#define LED         9
#define BLINKPERIOD 200

RFM69 radio;
char input = 0;
long lastPeriod = -1;

/////////////////////////////////////////////////////////////////////////////
// flash(SPI_CS, MANUFACTURER_ID)
// SPI_CS          - CS pin attached to SPI flash chip (8 in case of Moteino)
// MANUFACTURER_ID - OPTIONAL, 0x1F44 for adesto(ex atmel) 4mbit flash
//                             0xEF30 for windbond 4mbit flash
//                             0xEF40 for windbond 16/64mbit flash
/////////////////////////////////////////////////////////////////////////////
SPIFlash flash(8, 0xEF30); //EF30 for windbond 4mbit flash

//Scoreboard stuff
/* pinout for reworked Scoreboard X2 */
#define DA   A2 //data pin
#define WR   A3 //write strobe
#define CS1  5  //chip selects
#define CS2  4
#define CS3  3
#define CS4  A4
#define CS5  A0
#define CS6  A1
#define CS7  7
#define CS8  6

#define NUM_DISP 8 // number of LED matrices present

// use this line for single matrix
//HT1632LEDMatrix matrix = HT1632LEDMatrix(DATA, WR, CS1, CS2);
// use this line for two matrices!
HT1632LEDMatrix matrix = HT1632LEDMatrix(DA, WR, CS1, CS2, CS3, CS4, CS5, CS6, CS7, CS8);
 

void setup(){
  my_id = EEPROM.read(0);  // node id is stored in EEPROM location 0
  pinMode(LED, OUTPUT);
  Serial.begin(SERIAL_BAUD);
  radio.initialize(FREQUENCY,my_id,NETWORKID);
  radio.encrypt(ENCRYPTKEY); //OPTIONAL
#ifdef IS_RFM69HW
  radio.setHighPower(); //only for RFM69HW!
#endif
  Serial.print("Start node...");

  if (flash.initialize())
    Serial.println("SPI Flash Init OK!");
  else
    Serial.println("SPI Flash Init FAIL!");
    
  matrix.begin(HT1632_COMMON_16NMOS); 
  matrix.clearScreen();
  delay(500*my_id);  //delay so that each panel cycles through all on state
  matrix.fillScreen();
  delay(500);
  matrix.clearScreen();
  matrix.setTextSize(1);
  matrix.setTextColor(1);
  matrix.setCursor(0,0); 
  matrix.print("X2 ");
  matrix.print(my_id);
  matrix.writeScreen();
  delay(2000);
  matrix.setBrightness(15);
  matrix.clearScreen();
}

void loop(){
  // This part is optional, useful for some debugging.
  // Handle serial input (to allow basic DEBUGGING of FLASH chip)
  // ie: display first 256 bytes in FLASH, erase chip, write bytes at first 10 positions, etc
  if (Serial.available() > 0) {
    input = Serial.read();
    if (input == 'd') //d=dump first page
    {
      Serial.println("Flash content:");
      int counter = 0;

      while(counter<=256){
        Serial.print(flash.readByte(counter++), HEX);
        Serial.print('.');
      }
      
      Serial.println();
    }
    else if (input == 'e')
    {
      Serial.print("Erasing Flash chip ... ");
      flash.chipErase();
      while(flash.busy());
      Serial.println("DONE");
    }
    else if (input == 'i')
    {
      Serial.print("DeviceID: ");
      Serial.println(flash.readDeviceId(), HEX);
    }
    else if (input == 'r')
    {
      Serial.print("Rebooting");
      resetUsingWatchdog(true);
    }
    else if (input == 'R')
    {
      Serial.print("RFM69 registers:");
      radio.readAllRegs();
    }
    else if (input >= 48 && input <= 57) //0-9
    {
      Serial.print("\nWriteByte("); Serial.print(input); Serial.print(")");
      flash.writeByte(input-48, millis()%2 ? 0xaa : 0xbb);
    }
  }
  
  // Check for existing RF data, potentially for a new sketch wireless upload
  // For this to work this check has to be done often enough to be
  // picked up when a GATEWAY is trying hard to reach this node for a new sketch wireless upload
  if (radio.receiveDone())
  {
    Serial.print("Got [");
    Serial.print(radio.SENDERID);
    Serial.print(':');
    Serial.print(radio.DATALEN);
    Serial.print("] > ");
    for (byte i = 0; i < radio.DATALEN; i++)
      Serial.print((char)radio.DATA[i]);
    Serial.println ();
    CheckForWirelessHEX(radio, flash, true);
    CheckForOSB();
    Serial.println();
  }
  
  ////////////////////////////////////////////////////////////////////////////////////////////
  // Real sketch code here, let's blink the onboard LED
  if ((int)(millis()/BLINKPERIOD) > lastPeriod)
  {
    lastPeriod++;
    digitalWrite(LED, lastPeriod%2);
  }
  ////////////////////////////////////////////////////////////////////////////////////////////
}

void CheckForOSB(){ //check for OpenScoreboard packet; if present, display it
    
  if ( radio.DATALEN >= 4 && radio.DATA[0]=='O' && radio.DATA[1]=='S' && radio.DATA[2]=='B' && radio.DATA[3]==' ' ){  
    Serial.println("OSB Packet");
    //reformat string for display
    radio.DATA[5]=radio.DATA[4];
    for (int digit = 0; digit <= 4; digit++){
      int dg = (digit-1)*24 + 2;
      switch(radio.DATA[(digit+5)]) {
        case '0': matrix.drawBitmapLeft(dg, 0, fancyZero,  16, 20, 0x1); break;
        case '1': matrix.drawBitmapLeft(dg, 0, fancyOne,   16, 20, 0x1); break;
        case '2': matrix.drawBitmapLeft(dg, 0, fancyTwo,   16, 20, 0x1); break;
        case '3': matrix.drawBitmapLeft(dg, 0, fancyThree, 16, 20, 0x1); break;
        case '4': matrix.drawBitmapLeft(dg, 0, fancyFour,  16, 20, 0x1); break;
        case '5': matrix.drawBitmapLeft(dg, 0, fancyFive,  16, 20, 0x1); break;
        case '6': matrix.drawBitmapLeft(dg, 0, fancySix,   16, 20, 0x1); break;
        case '7': matrix.drawBitmapLeft(dg, 0, fancySeven, 16, 20, 0x1); break;
        case '8': matrix.drawBitmapLeft(dg, 0, fancyEight, 16, 20, 0x1); break;
        // for 9, we use 6 upside down:
        case '9': matrix.drawBitmapRight(dg, 0,  fancySix,   16, 20, 0x1); break;
        case ' ': matrix.drawBitmapLeft(dg, 0, fancySpace, 16, 20, 0x1); break;
        // in case of a bad digit:

        default: matrix.clearScreen();
      }
    }
  }
  matrix.writeScreen();  //display contents of buffer on displays
}
