// Würfel Remotesteuerung (V8) | Noah Roters | 12.03.2025
//Versionsänderungen: 
// +LED´s auf Remotesteuerung spiegeln
// +void senden (übersichtshalber)

using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace wuerfelremotesteuerung
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool sendenErfolgreich;

        public Form1()
        {
            InitializeComponent();
            picLED.Visible = false;


            serialPort = new SerialPort();

            serialPort.DataReceived += SerialPort_DataReceived; // Event listener
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePortListe();
            btnopen.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Bei Schließen LED´s ausschalten
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) // Auslesen Serial Port
        {
            try
            {
                string incomingData = serialPort.ReadLine().Trim();

                if (incomingData == "i")//LED13 AN
                {
                    Invoke(new Action(() => picLED.Visible = true));
                    return;
                }
                else if (incomingData == "j")//LED13 AUS
                {
                    Invoke(new Action(() => picLED.Visible = false));
                    return;
                }

                Console.WriteLine($"Empfangen: {incomingData}"); // Debug-Ausgabe

                if (incomingData.StartsWith("result:"))
                {
                    string numberString = incomingData.Substring(7).Trim();
                    if (int.TryParse(numberString, out int diceValue))
                    {
                        Invoke(new Action(() =>
                        {
                            lblergebnis.Text = $"Gewürfelt: {diceValue}";
                            lblvorhersagetf.Text = "Deaktiviert";
                            SetButtonsEnabled(true);
                        }));
                    }
                }
                else if (incomingData.StartsWith("LED "))
                {
                    string[] parts = incomingData.Split(' ');
                    if (parts.Length == 3 && int.TryParse(parts[1], out int ledIndex))
                    {
                        bool ledAn = parts[2] == "AN";// AN = true

                        Invoke(new Action(() =>
                        {
                            SetButtonState(ledIndex + 1, ledAn);
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show("Fehler beim Empfangen: " + ex.Message)));
            }
            Console.WriteLine($" ");
        }

        private void cbxSchnittstellen_SelectedIndexChanged(object sender, EventArgs e) // Wenn Schnittstellenänderung auffordern zum Port schließen
        {

            lblinfoc.Text = "Bitte zuerst Port schließen";

        }

        private void SetButtonState(int ledIndex, bool isOn) // Einzelsteuerungs-button Farben setzen
        {
            Button targetButton = GetButtonByLedIndex(ledIndex);
            if (targetButton != null)
            {
                targetButton.BackColor = isOn ? Color.HotPink : SystemColors.Control;
            }
        }

        private Button GetButtonByLedIndex(int ledIndex) // Button passend zur Anzeige über Einzelauswahl färben 
        {
            switch (ledIndex)
            {
                case 1: return btnled1;
                case 2: return btnled2;
                case 3: return btnled3;
                case 4: return btnled4;
                case 5: return btnled5;
                case 6: return btnled6;
                case 7: return btnled7;
                default: return null;
            }
        }

        private void ResetAllLeds() // Alle LED´s ausschalten und Buttons auf Standartfarbe setzen
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write("h");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Serielle Verbindung nicht geöffnet!");
            }
            btnled1.BackColor = SystemColors.Control;
            btnled2.BackColor = SystemColors.Control;
            btnled3.BackColor = SystemColors.Control;
            btnled4.BackColor = SystemColors.Control;
            btnled5.BackColor = SystemColors.Control;
            btnled6.BackColor = SystemColors.Control;
            btnled7.BackColor = SystemColors.Control;
        }

        private void SetButtonsEnabled(bool isEnabled) // Buttons nach Vorhersage Dis-/ Enable
        {
            btnled1.Enabled = isEnabled;
            btnled2.Enabled = isEnabled;
            btnled3.Enabled = isEnabled;
            btnled4.Enabled = isEnabled;
            btnled5.Enabled = isEnabled;
            btnled6.Enabled = isEnabled;
            btnled7.Enabled = isEnabled;

            btnerg1.Enabled = isEnabled;
            btnerg2.Enabled = isEnabled;
            btnerg3.Enabled = isEnabled;
            btnerg4.Enabled = isEnabled;
            btnerg5.Enabled = isEnabled;
            btnerg6.Enabled = isEnabled;
        }

        private bool senden(String sendeText) // Senden an Microcontroller
        {
            bool ok = false;
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(sendeText);
                    ok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Serielle Verbindung nicht geöffnet!");
            }
            return ok;
        }


        private void btnwuerfeln_Click(object sender, EventArgs e) // Würfeln
        {

            try
            {
                ResetAllLeds();
                senden("w");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = "Deaktiviert";
                SetButtonsEnabled(true);
            }
        }

        
        private void btnopen_Click(object sender, EventArgs e) // Port öffnen
        {
            try
            {
                serialPort.PortName = cbxSchnittstellen.Text;
                serialPort.Open();
                lblausgabestatus.Text = "verbunden";
            }
            catch (Exception exi)
            {
                MessageBox.Show("Fehler beim Oeffnen!\n" + exi.Message);

            }
        }
        
        private void btnclose_Click(object sender, EventArgs e) //Port schließen
        {
            serialPort.Close();
            lblausgabestatus.Text = "geschlossen";
            lblinfoc.Text = "";
            btnopen.Enabled = true;
        }

        private void updatePortListe() // Port Liste Updaten
        {

            string[] portListe;
            portListe = System.IO.Ports.SerialPort.GetPortNames();
            cbxSchnittstellen.Items.Clear();
            foreach (string port in portListe)
            {
                cbxSchnittstellen.Items.Add(port);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e) // Button zur Update Port Liste
        {
            updatePortListe();
        }



        private void btnled1_Click(object sender, EventArgs e) // Einzelsteuerung LED1
        {
            senden("a");
        }

        private void btnled2_Click(object sender, EventArgs e) // Einzelsteuerung LED2
        {
            senden("b");
        }

        private void btnled3_Click(object sender, EventArgs e) // Einzelsteuerung LED3
        {
            senden("c");
        }

        private void btnled4_Click(object sender, EventArgs e) // Einzelsteuerung LED4
        {
            senden("d");
        }

        private void btnled5_Click(object sender, EventArgs e) // Einzelsteuerung LED5
        {
            senden("e");
        }

        private void btnled6_Click(object sender, EventArgs e) // Einzelsteuerung LED6
        {
            senden("f");
        }

        private void btnled7_Click(object sender, EventArgs e) // Einzelsteuerung LED7
        {
            senden("g");
        }


        private void btnerg1_Click(object sender, EventArgs e) // Vorhersage 1
        {
            try
            {
                senden("o");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 1";
                SetButtonsEnabled(false);
            }
        }

        private void btnerg2_Click(object sender, EventArgs e) // Vorhersage 2
        {
            try
            {
                senden("p");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 2";
                SetButtonsEnabled(false);
            }
        }

        private void btnerg3_Click(object sender, EventArgs e) // Vorhersage 3
        {
            try
            {
                senden("q");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 3";
                SetButtonsEnabled(false);
            }
        }

        private void btnerg4_Click(object sender, EventArgs e) // Vorhersage 4
        {
            try
            {
                senden("r");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 4";
                SetButtonsEnabled(false);
            }
        }

        private void btnerg5_Click(object sender, EventArgs e) // Vorhersage 5
        {
            try
            {
                senden("s");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 5";
                SetButtonsEnabled(false);
            }
        }

        private void btnerg6_Click(object sender, EventArgs e) // Vorhersage 6
        {
            try
            {
                senden("t");
                sendenErfolgreich = true;
            }
            catch (Exception)
            {
                throw;
            }
            if (sendenErfolgreich)
            {
                lblvorhersagetf.Text = $"Aktiviert: 6";
                SetButtonsEnabled(false);
            }
        }

    }
}
