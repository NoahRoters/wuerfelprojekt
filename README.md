# Projekt: Würfelsteuerung mit Mikrocontroller und Remote-Software (Schulprojekt)

Dieses Projekt besteht aus zwei Hauptkomponenten:
1. **Die Mikrocontroller-Software** (C-Code für den ATmega8)
2. **Die Remote-Steuerungssoftware** (C#-Anwendung für Windows)

---

- Beide Komponenten arbeiten zusammen, um einen elektronischen Würfel mit LEDs zu steuern und das Würfelergebnis über eine serielle Schnittstelle an den PC zu übertragen.
- Die Hardware grundlage bezieht sich auf einer privaten Platinenkonstruktion.
- Großen dank geht an [@robsoncouto](https://github.com/robsoncouto) und seinem [Repository](https://github.com/robsoncouto/arduino-songs) für den Code der eigebetteten Musik und mitwirkenden Lehrer.

---

## 1. Mikrocontroller-Software (ATmega8)

### Funktionen:
- Steuert LEDs zur Anzeige des gewürfelten Ergebnisses.
- Sendet das Ergebnis an den PC über eine serielle Schnittstelle.
- Ermöglicht das Ein- und Ausschalten einzelner LEDs.
- Erkennt Befehle von der Remote-Software und führt entsprechende Aktionen aus.

### Steuerbefehle:
| Befehl | Funktion |
|--------|---------|
| `w` | Würfeln starten |
| `a` - `g` | Einzel-LEDs (1-7) steuern |
| `h` | Alle LEDs ausschalten |
| `o` - `t` | Vorhersage der Würfelzahl (1-6) |
| `i` | LED 13 an |
| `j` | LED 13 aus |

---

## 2. Remote-Steuerungssoftware (C#)

### Funktionen:
- Verbindung zum Mikrocontroller über die serielle Schnittstelle.
- Startet das Würfeln und zeigt das Ergebnis an.
- Steuert einzelne LEDs.
- Ermöglicht manipulation des nächsten Würfelvorgangs.
- Zeigt die aktuelle Statusmeldung des Würfels an.

### Steuerung:
- **Port auswählen und verbinden**: Nach dem Start der Anwendung kann der passende COM-Port ausgewählt und geöffnet werden. (Bevor der Port geöffnet werden kann muss dieser erst geschlossen werden)
- **Würfeln**: Durch Drücken des "Würfeln"-Buttons wird ein Wurf ausgelöst, und das Ergebnis wird angezeigt.
- **LED-Steuerung**: Einzelne LEDs können per Button aktiviert oder deaktiviert werden.
- **Vorhersage setzen**: Es kann eine Vorhersage für das Würfelergebnis getroffen werden, wodurch die Steuerbuttons deaktiviert werden, bis ein Ergebnis empfangen wurde.

### Voraussetzungen:
- .NET Framework 4.7 oder höher
- Serielle Schnittstelle und/oder zugehöriges Programm

---

## 3. Installation und Nutzung

### Hardware-Voraussetzungen:
- ATmega8 Mikrocontroller mit passender Schaltung (inkl. LEDs und Taster)(nicht erwerbbar)
- USB-zu-Seriell-Adapter (falls kein nativer COM-Port vorhanden ist)
- Windows-PC zur Steuerung

### Software-Voraussetzungen:
- AVR-GCC zur Kompilierung der Mikrocontroller-Software
- AVRDUDE zum Flashen der Firmware auf den ATmega8
- Visual Studio zur Entwicklung und Nutzung der Remote-Software

### Installation:
1. **Mikrocontroller-Software**
   - Empfohlen; Mit Arduino Software auf einen (Original-)Arduino flashen
   
2. **Remote-Software**
   - Die C#-Anwendung mit Visual Studio kompilieren oder die bereitgestellte EXE-Datei ausführen.
   - COM-Port auswählen und Verbindung herstellen.
   - Steuerung der LEDs oder Start des Würfelns.

---

## 4. Fehlerbehebung

### Kein COM-Port gefunden?
- Sicherstellen, dass der Mikrocontroller über USB oder eine serielle Verbindung angeschlossen ist.
- Im Gerätemanager prüfen, ob der Port erkannt wird.
- Anderen USB-Port oder einen anderen Adapter ausprobieren.

### Keine Reaktion auf Befehle?
- Mikrocontroller-Software erneut flashen.
- Baudrate in der C#-Anwendung überprüfen (muss mit der Firmware übereinstimmen).
- Verbindung mit einem Terminal-Programm wie PuTTY testen.

Falls weitere Probleme auftreten, gerne eine Anfrage stellen oder den Code auf Fehler überprüfen.

---

## 5. Lizenz und Danksagung
- Dieses Projekt ist ohne Lizenz und demnach gilt das standartmäßige Urheberrecht:
  - Niemand darf den Code reproduzieren, verteilen oder abgeleitete Werke davon erstellen.
  - Dieser Code soll eine Inspiration sein und darf daher nur in stark abgewandelter Form für private Zwecke benutzt werden!

