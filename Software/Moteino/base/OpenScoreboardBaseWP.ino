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
// This is the GATEWAY node, it does not need a custom Optiboot nor any external FLASH memory chip
// (ONLY the target node will need those)
// The sketch includes logic to receive the new sketch from the serial port (from a host computer) and 
// transmit it wirelessly to the target node
// The handshake protocol that receives the sketch from the serial port 
// is handled by the SPIFLash/WirelessHEX69 library, which also relies on the RFM12B library
// These libraries and custom 1k Optiboot bootloader for the target node are at: http://github.com/lowpowerlab

#include <RFM69.h>
#include <SPI.h>
#include <SPIFlash.h>
#include <WirelessHEX69.h>

#define NETWORKID          124  //what network this node is on
#define NODEID               16  //this node's ID, should be unique among nodes on this NETWORKID
//Match frequency to the hardware version of the radio on your Moteino (uncomment one):
//#define FREQUENCY   RF69_433MHZ
//#define FREQUENCY   RF69_868MHZ
#define FREQUENCY     RF69_915MHZ
#define ENCRYPTKEY "GatorsEncryptKey" //(16 bytes of your choice - keep the same on all encrypted nodes)
//#define IS_RFM69HW            //uncomment only for RFM69HW! Leave out if you have RFM69W!

#define LED         9
#define SERIAL_BAUD 115200
#define ACK_TIME    50  // # of ms to wait for an ack
#define TIMEOUT     3000

RFM69 radio;
char c = 0;
char input[64]; //serial input buffer
byte targetID=0;

void setup(){
  Serial.begin(SERIAL_BAUD);
  radio.initialize(FREQUENCY,NODEID,NETWORKID);
  radio.encrypt(ENCRYPTKEY); //OPTIONAL
#ifdef IS_RFM69HW
  radio.setHighPower(); //only for RFM69HW!
#endif
  Serial.println("Start wireless gateway...");
}

void loop(){
  byte inputLen = readSerialLine(input, 10, 64, 100); //readSerialLine(char* input, char endOfLineChar=10, byte maxLength=64, uint16_t timeout=1000);
  
  if (inputLen==4 && input[0]=='F' && input[1]=='L' && input[2]=='X' && input[3]=='?') {
    if (targetID==0)
      Serial.println("TO?");
    else
      CheckForSerialHEX((byte*)input, inputLen, radio, targetID, TIMEOUT, ACK_TIME, true);
  }
  else if (inputLen>3 && inputLen<=6 && input[0]=='T' && input[1]=='O' && input[2]==':')
  {
    byte newTarget=0;
    for (byte i = 3; i<inputLen; i++) //up to 3 characters for target ID
      if (input[i] >=48 && input[i]<=57)
        newTarget = newTarget*10+input[i]-48;
      else
      {
        newTarget=0;
        break;
      }
    if (newTarget>0)
    {
      targetID = newTarget;
      Serial.print("TO:");
      Serial.print(newTarget);
      Serial.println(":OK");
    }
    else
    {
      Serial.print(input);
      Serial.print(":INV");
    }
  }
  else if ( input[0]=='O' && input[1]=='S' && input[2]=='B' &&  input[3]==' ' ){ // check for OpenScoreboard packet
     int lane=atoi(input+4); //get lane number to see if lane info/event-heat info/or display clear
     switch(lane){
       case 0:   Serial.println("Event Heat update");
                 radio.send(lane,input,inputLen);
                 break;
       case 15:
                 Serial.println("Clear Display");
                 for (int ii=1; ii <= 8; ii++){
                   radio.send(ii, "OSB          ",13);
                 }
                 break;
       default:
                 Serial.println(input);
                 radio.send(lane, input, inputLen);
     }
  }
  else if (inputLen>0) { //just echo back
    Serial.print("SERIAL IN > ");Serial.println(input);
  }

  if (radio.receiveDone())
  {
    for (byte i = 0; i < radio.DATALEN; i++)
      Serial.print((char)radio.DATA[i]);
    
    if (radio.ACK_REQUESTED)
    {
      radio.sendACK();
      Serial.print(" - ACK sent");
    }
    
    Serial.println();
  }
  Blink(LED,5); //heartbeat
}

void Blink(byte PIN, int DELAY_MS)
{
  pinMode(PIN, OUTPUT);
  digitalWrite(PIN,HIGH);
  delay(DELAY_MS);
  digitalWrite(PIN,LOW);
}
