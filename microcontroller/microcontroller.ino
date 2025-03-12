// Würfeltest_V5 | Noah Roters | 12.03.2025
//Versionsänderungen: 
// +LED´s auf Remotesteuerung spiegeln
//
//
//big thanks to the GitHub Repo from robsoncouto for the songs 

#include "RotersN-LED.h"      // Einbindung der LED-Klasse
#include "RotersN-pitches.h"  // Definition von Tonhöhen (z.B. NOTE_C4)

class DiceGame {

private:
  //################- ANPASSBARE VARIABLEN -################

  //########- WÜRFELZEIT EIN/AUS / LÄNGE ANPASSEN -########

  int waitingTime = 5000;       // Länge der Wartezeit
  bool boolwaitingTime = true;  // Wartezeit nach Wurf aktiv?

  //########- WÜRFELZEIT EIN/AUS / LÄNGE ANPASSEN -########

  //########- SONG LÄNGE ANPASSEN -########

  // Durch auskommentieren (//) vor dem #define oder "NOT" nach dem define wird der part aktiviert
  // Ist #define DISABLE_PART_X aktiviert wird der entsprechende part übersprungen

#define NOT DISABLE_PART_1  //BEIPIEL HIER: Abschnitt 1 aktiviert
//#define DISABLE_PART_2 //BEIPIEL HIER: Abschnitt 2 aktiviert
//#define DISABLE_PART_3
#define DISABLE_PART_4
#define DISABLE_PART_5

  //########- SONG LÄNGE ANPASSEN -########

  //################- ANPASSBARE VARIABLEN -################

  // Pin-Definitionen
  int pinLED[7] = { 4, 5, 6, 7, 8, 9, 10 };  // Pins für die 7 LEDs
  LED* leds[7];                              // Array von LED-Objekten
  int buttonPin = 2;                         // Taster-Pin
  int switchPin = 12;                        // Schalter-Pin
  int buzzerPin = 11;                        // Buzzer-Pin
  LED* led13;                                // LED 13 für Ruhezustand und Wartezeit

  // Variablen zur Entprellung des Tasters
  bool buttonState = false;
  bool lastButtonState = HIGH;
  unsigned long debounceDelay = 50;  // Entprellzeit (ms)
  unsigned long lastDebounceTime = 0;

  // Zustandsvariablen
  bool diceDisplayed = false;               // Gibt an, ob der Würfel bereits angezeigt wird
  unsigned long lastBlinkTime = 0;          // Letztes Blinken der LEDs
  const unsigned long blinkInterval = 200;  // Blink-Intervall (ms)
  unsigned long waitStartTime = 0;
  int currentLed = 0;       // Aktuell aktive LED beim Blinken
  int predictedValue = -1;  // -1 bedeutet keine Vorhersage
  unsigned long lastLED13BlinkTime = 0;
  const unsigned long blinkInterval13 = 500;  // Blink Intervall LED13
  bool led13State = false;

  // Zusatzstaster für Melodie Ein/aus
  const int pc5Pin = A5;  // PC5 als Ausgang für zusätzlichen Schalter
  const int pc4Pin = A4;  // PC4 als Eingang ""


public:

  DiceGame() {
    led13 = new LED(13);
    pinMode(buttonPin, INPUT_PULLUP);  // Taster mit Pull-Up-Widerstand
    pinMode(switchPin, INPUT_PULLUP);  // Schalter mit Pull-Up-Widerstand
    pinMode(buzzerPin, OUTPUT);        // Buzzer als Ausgang
    pinMode(pc5Pin, OUTPUT);           // PC5 als Ausgang
    pinMode(pc4Pin, INPUT);            // PC4 als Eingang

    digitalWrite(pc5Pin, LOW);  // PC5 immer LOW -> Zusätzlicher  schalter

    // Initialisierung der LEDs
    for (int i = 0; i < 7; i++) {
      leds[i] = new LED(pinLED[i]);
    }

    // Initialisierung des Zufallszahlengenerators
    randomSeed(analogRead(A0));
    for (int i = 0; i < 100; i++) random();
  }

  // Würfelt Zahlen zwischen 1-6 oder aktiviert Vorhersage
  int getNumber() {
    int diceValue;
    if (predictedValue != -1) {
      // Verwende die Vorhersage, wenn eine existiert
      diceValue = predictedValue;
      predictedValue = -1;  // Setze die Vorhersage zurück
    } else {
      diceValue = random(1, 7);  // Normaler Zufallswurf
    }
    //Ergebnis an Serielle Schnittstelle senden
    Serial.print("result:");
    Serial.println(diceValue);
    return diceValue;
  }

  // LED-Zustand vom Pin abrufen
  bool istEin(int ledIndex) {
    if (ledIndex >= 0 && ledIndex < 7) {
      return digitalRead(pinLED[ledIndex]) == HIGH;
    }
    return false;
  }


  void loop() {
    int reading = digitalRead(buttonPin);

    // Entprellung des Tasters
    if (reading != lastButtonState) {
      lastDebounceTime = millis();
    }

    // Tastendruck lesen, wenn erlaubt Würfeln
    if ((millis() - lastDebounceTime) > debounceDelay) {
      if (reading == LOW && !buttonState) {
        buttonState = true;
        led13State = true;
        led13->ein();

        if (!diceDisplayed) {
          int diceValue = getNumber();
          showDice(diceValue);
          diceDisplayed = true;
        }
      } else if (reading == HIGH) {
        buttonState = false;
        diceDisplayed = false;
      }
    }

    // Serielle Steuerung zur Vorhersage
    if (Serial.available() > 0) {
      char command = Serial.read();

      // Vorhersagen
      if (command >= 'o' && command <= 't') {
        int predicted = command - 'o' + 1;  // Umwandlung von 'o' bis 't' in 1 bis 6
        predictedValue = predicted;
        Serial.print("Vorhersage gesetzt auf: ");
        Serial.println(predictedValue);
      }

      // Einzelne Ansteuerung
      if (command >= 'a' && command <= 'g') {
        int ledIndex = command - 'a';  // 97 = ASCII für a
        Serial.print("Empfangen: ");
        Serial.println(command);

        if (leds[ledIndex]->getZustand()) {
          leds[ledIndex]->aus();
          Serial.print("LED ");
          Serial.print(ledIndex);
          Serial.println(" AUS");
        } else {
          leds[ledIndex]->ein();
          Serial.print("LED ");
          Serial.print(ledIndex);
          Serial.println(" AN");
        }
      }

      if (command == 'h') {

        if (command == 'h') {
          Serial.println("Empfangen: h - Alle LEDs aus");

          for (int i = 0; i < 7; i++) {
            leds[i]->aus();
            delay(1);
          }
        }
      }



      // Würfeln
      if (command == 'w') {
        Serial.println("Empfangen: w");

        buttonState = !buttonState;

        if (buttonState) {
          Serial.println("Würfeln gestartet!");
          led13State = true;
          led13->ein();

          if (!diceDisplayed) {
            int diceValue = getNumber();
            showDice(diceValue);
            diceDisplayed = true;
          }
        }
      }
    }

    if (boolwaitingTime && millis() - waitStartTime >= 2000) {
      boolwaitingTime = false;
    }

    updateLED13();

    lastButtonState = reading;
  }

  // Gewürfelte Zahlen anzeigen
  void showDice(int value) {
    for (int i = 0; i < 7; i++) {
      leds[i]->aus();
    }

    switch (value) {
      case 1:
        leds[3]->ein();
        break;
      case 2:
        leds[0]->ein();
        leds[6]->ein();
        break;
      case 3:
        leds[0]->ein();
        leds[3]->ein();
        leds[6]->ein();
        break;
      case 4:
        leds[0]->ein();
        leds[2]->ein();
        leds[4]->ein();
        leds[6]->ein();
        break;
      case 5:
        leds[0]->ein();
        leds[2]->ein();
        leds[3]->ein();
        leds[4]->ein();
        leds[6]->ein();
        break;
      case 6:
        leds[0]->ein();
        leds[1]->ein();
        leds[2]->ein();
        leds[4]->ein();
        leds[5]->ein();
        leds[6]->ein();
        // Schalter abfragen ob mit MUsik oder ohne
        if (digitalRead(pc4Pin) == HIGH) {
          blinkSixLeds();
          playMelodyWithBlinking();
        } else {
          blinkSixLeds();
          blinkLeds();
        }

        leds[0]->ein();
        leds[1]->ein();
        leds[2]->ein();
        leds[4]->ein();
        leds[5]->ein();
        leds[6]->ein();
        break;
    }
    warte(waitingTime);
    for (int i = 0; i < 7; i++) {
      leds[i]->aus();
    }
  }

// LED13 steuerung und Übertragung an VS
void updateLED13() {
    if (boolwaitingTime) {
        led13->ein();
        if (!led13State) {
            Serial.println("i"); // LED13 AN
            led13State = true;
        }
    } else {
        if (millis() - lastLED13BlinkTime >= blinkInterval13) {
            led13State = !led13State;
            led13->setZustand(led13State);
            lastLED13BlinkTime = millis();
            
            if (led13State) {
                Serial.println("i"); // LED13 AN
            } else {
                Serial.println("j"); // LED13 AUS
            }
        }
    }
}


  // LEDs nacheinander blinken lassen
  void blinkLeds() {
    for (int j = 0; j < 4; j++) {
      for (int i = 0; i < 7; i++) {
        leds[i]->ein();
        if (warte(200)) return;
        leds[i]->aus();
      }
    }
  }

  // Melodie abspielen mit blinkenden LEDs
  void playMelodyWithBlinking() {
    int melody[] = {
#ifndef DISABLE_PART_1
      NOTE_G4,
      NOTE_A4,
      NOTE_C5,
      NOTE_A4,
      NOTE_E5,
      NOTE_E5,
      REST,
      NOTE_D5,
      REST,
#endif

#ifndef DISABLE_PART_2
      NOTE_G4,
      NOTE_A4,
      NOTE_C5,
      NOTE_A4,
      NOTE_G5,
      NOTE_B4,
      REST,
      NOTE_C5,
      REST,
      NOTE_B4,
      NOTE_A4,
      REST,
#endif

#ifndef DISABLE_PART_3
      NOTE_G4,
      NOTE_A4,
      NOTE_C5,
      NOTE_A4,
      NOTE_C5,
      NOTE_D5,
      REST,
      NOTE_B4,
      NOTE_A4,
      NOTE_G4,
      REST,
      NOTE_G4,
      REST,
      NOTE_D5,
      REST,
      NOTE_C5,
      REST,
#endif

#ifndef DISABLE_PART_4
      NOTE_C5,
      REST,
      NOTE_D5,
      REST,
      NOTE_G4,
      REST,
      NOTE_D5,
      REST,
      NOTE_E5,
      REST,
      NOTE_G5,
      NOTE_F5,
      NOTE_E5,
      REST,
#endif

#ifndef DISABLE_PART_5
      NOTE_C5,
      REST,
      NOTE_D5,
      REST,
      NOTE_G4,
      REST
#endif

    };

    int durations[] = {
#ifndef DISABLE_PART_1
      8,
      8,
      8,
      8,
      2,
      8,
      8,
      2,
      8,
#endif

#ifndef DISABLE_PART_2
      8,
      8,
      8,
      8,
      2,
      8,
      8,
      2,
      8,
      8,
      8,
      8,
#endif

#ifndef DISABLE_PART_3
      8,
      8,
      8,
      8,
      2,
      8,
      8,
      4,
      8,
      3,
      8,
      8,
      8,
      8,
      8,
      1,
      4,
#endif


#ifndef DISABLE_PART_4
      2,
      6,
      2,
      6,
      4,
      4,
      2,
      6,
      2,
      3,
      8,
      8,
      8,
      8,
#endif


#ifndef DISABLE_PART_5
      2,
      6,
      2,
      6,
      2,
      1
#endif

    };

    //Musik und LED´s passend Abspielen und Blinken lassen
    int size = sizeof(durations) / sizeof(int);
    for (int note = 0; note < size; note++) {
      unsigned long currentTime = millis();

      if (currentTime - lastBlinkTime >= blinkInterval) {
        leds[currentLed]->aus();
        currentLed = (currentLed + 1) % 7;
        leds[currentLed]->ein();
        lastBlinkTime = currentTime;
      }

      int duration = 1000 / durations[note];  // Notendauer berechnen
      tone(buzzerPin, melody[note], duration);
      if (warte(duration * 1.30)) break;  // Dauer der Note + kleine Pause
    }

    for (int i = 0; i < 7; i++) {
      leds[i]->aus();
    }
  }

  // Blinkmuster für 6 LEDs
  void blinkSixLeds() {
    int sixLeds[] = { 0, 1, 2, 4, 5, 6 };

    for (int j = 0; j < 3; j++) {
      for (int i = 0; i < 6; i++) {
        leds[sixLeds[i]]->ein();
      }
      delay(200);

      for (int i = 0; i < 6; i++) {
        leds[sixLeds[i]]->aus();
      }
      delay(200);
    }
  }


  // wartezeit (delay) mit abbruchmöglichkeiten
  bool warte(unsigned int ms) {
    bool abbruch = false;
    bool lastState = digitalRead(buttonPin);
    unsigned long endeZeit = millis() + ms;

    while (millis() < endeZeit) {
      delay(1);

      // Taster-Eingabe
      bool state = digitalRead(buttonPin);
      if ((state == LOW) && (lastState == HIGH)) {
        abbruch = true;
        break;
      }
      lastState = state;

      // Serielle Eingabe
      if (Serial.available() > 0) {
        char input = Serial.read();
        if (input == 'w') {
          abbruch = true;
          Serial.println("Wartezeit abgebrochen");
          break;
        }
      }
    }

    return abbruch;
  }
};

DiceGame* game;


void setup() {
  Serial.begin(9600);
  game = new DiceGame;
}
void loop() {
  game->loop();
}
