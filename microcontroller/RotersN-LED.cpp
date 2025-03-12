// written by others and NOT BY ME (Noah Roters)
#include "Arduino.h"
#include "RotersN-LED.h"

LED::LED(int pNr)   // Konstruktor
{
  pinNr = pNr;
  pinMode(pinNr, OUTPUT);
}
LED::~LED()   // Destruktor
{
  pinMode(pinNr, INPUT);
}

void LED::ein()
{
  setZustand(HIGH);
}
void LED::aus()
{
  setZustand(LOW);
}
void LED::setZustand(bool zustand)
{
  digitalWrite(pinNr, zustand);
}
bool LED::getZustand()
{
  return digitalRead(pinNr);
}