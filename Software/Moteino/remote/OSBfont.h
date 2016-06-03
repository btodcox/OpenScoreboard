/*
* font files are from "odometer" on the adafruit.com forum
* https://forums.adafruit.com/viewtopic.php?t=37293
*/
static prog_uint8_t fancyZero[] PROGMEM = {
  0x07, 0xE0, 0x1F, 0xF8, 0x3F, 0xFC, 0x3C, 0x3C,
  0x78, 0x1E, 0x78, 0x1E, 0x78, 0x1E, 0xF0, 0x0F,
  0xF0, 0x0F, 0xF0, 0x0F, 0xF0, 0x0F, 0xF0, 0x0F,
  0xF0, 0x0F, 0x78, 0x1E, 0x78, 0x1E, 0x78, 0x1E,
  0x3C, 0x3C, 0x3F, 0xFC, 0x1F, 0xF8, 0x07, 0xE0
};

static prog_uint8_t fancyOne[] PROGMEM = {
  0x01, 0xE0, 0x03, 0xE0, 0x07, 0xE0, 0x1F, 0xE0,
  0x1D, 0xE0, 0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0,
  0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0,
  0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0,
  0x01, 0xE0, 0x07, 0xF8, 0x07, 0xF8, 0x07, 0xF8
};

static prog_uint8_t fancyTwo[] PROGMEM = {
  0x0F, 0xF0, 0x3F, 0xF8, 0x7F, 0xFC, 0xFC, 0x3E,
  0xF8, 0x1F, 0xF0, 0x0F, 0xF0, 0x0F, 0x78, 0x0F,
  0x30, 0x1F, 0x00, 0x7E, 0x01, 0xFC, 0x07, 0xF0,
  0x1F, 0xC0, 0x3F, 0x00, 0x7C, 0x03, 0xF0, 0x0F,
  0xF7, 0xCF, 0xFF, 0xFF, 0xFF, 0xFE, 0xF0, 0xFE
};

static prog_uint8_t fancyThree[] PROGMEM = {
  0x3F, 0xF8, 0x7F, 0xFC, 0xFF, 0xFE, 0xF0, 0x1F,
  0xE0, 0x0F, 0x00, 0x0F, 0x00, 0x1F, 0x00, 0x3E,
  0x01, 0xFC, 0x01, 0xF8, 0x00, 0x3C, 0x00, 0x1E,
  0x00, 0x0F, 0x38, 0x0F, 0x70, 0x0F, 0xF0, 0x1F,
  0xF8, 0x3E, 0x7F, 0xFC, 0x3F, 0xF8, 0x0F, 0xF0
};

static prog_uint8_t fancyFour[] PROGMEM = {
  0x03, 0xC0, 0x03, 0xC0, 0x07, 0x80, 0x07, 0x80,
  0x0F, 0x00, 0x0F, 0x00, 0x1E, 0x00, 0x3C, 0x3C,
  0x7C, 0x3C, 0xF8, 0x3C, 0xF0, 0x3C, 0xFF, 0xFF,
  0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x3C, 0x00, 0x3C,
  0x00, 0x3C, 0x00, 0x3C, 0x00, 0x7E, 0x00, 0x7E
};

static prog_uint8_t fancyFive[] PROGMEM = {
  0x78, 0x00, 0x7F, 0xFF, 0x7F, 0xFF, 0x7F, 0xFF,
  0x78, 0x00, 0xF8, 0x00, 0xF1, 0xE0, 0xF7, 0xF8,
  0xFF, 0xFC, 0xFE, 0x3E, 0xF0, 0x1E, 0x00, 0x1F,
  0x00, 0x0F, 0x00, 0x0F, 0x38, 0x0F, 0x70, 0x1F,
  0xF0, 0x7E, 0xFF, 0xFC, 0x7F, 0xF8, 0x1F, 0xE0
};

static prog_uint8_t fancySix[] PROGMEM = {
  0x03, 0xF0, 0x0F, 0xE0, 0x1F, 0xC0, 0x3E, 0x00,
  0x3C, 0x00, 0x78, 0x00, 0x78, 0x00, 0xF1, 0xE0,
  0xF7, 0xF8, 0xFF, 0xFC, 0xFF, 0x3E, 0xFC, 0x1F,
  0xF8, 0x0F, 0xF0, 0x0F, 0xF0, 0x0F, 0xF8, 0x1F,
  0x7C, 0x3E, 0x3F, 0xFC, 0x1F, 0xF8, 0x0F, 0xF0 
};

static prog_uint8_t fancySeven[] PROGMEM = {
  0x70, 0x3F, 0x7F, 0xFF, 0xFF, 0xFF, 0xFF, 0xEF,
  0xF0, 0x0F, 0xF0, 0x1E, 0x00, 0x1E, 0x00, 0x3C,
  0x00, 0x3C, 0x00, 0x78, 0x00, 0xF0, 0x00, 0xF0,
  0x01, 0xE0, 0x01, 0xE0, 0x01, 0xE0, 0x03, 0xC0,
  0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0, 0x03, 0xC0
};

static prog_uint8_t fancyEight[] PROGMEM = {
  0x1F, 0xF8, 0x3F, 0xFC, 0x7F, 0xFE, 0x78, 0x1E,
  0xF0, 0x0F, 0xF0, 0x0F, 0xF8, 0x1F, 0x7E, 0x7E,
  0x3F, 0xFC, 0x0F, 0xF0, 0x3F, 0xFC, 0x7E, 0x7E,
  0xF8, 0x1F, 0xF0, 0x0F, 0xF0, 0x0F, 0xF8, 0x1F,
  0x7C, 0x3E, 0x3F, 0xFC, 0x1F, 0xF8, 0x0F, 0xF0
};

static prog_uint8_t fancyTest[] PROGMEM = {
  0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,
  0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03, 0x03,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
  0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10
};

static prog_uint8_t fancySpace[] PROGMEM = {
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
};