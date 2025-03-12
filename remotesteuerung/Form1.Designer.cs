namespace wuerfelremotesteuerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtgrundfunktionen = new System.Windows.Forms.Label();
            this.btnwuerfeln = new System.Windows.Forms.Button();
            this.txteinzelsteuerung = new System.Windows.Forms.Label();
            this.btnled1 = new System.Windows.Forms.Button();
            this.btnled2 = new System.Windows.Forms.Button();
            this.btnled3 = new System.Windows.Forms.Button();
            this.btnled4 = new System.Windows.Forms.Button();
            this.btnled7 = new System.Windows.Forms.Button();
            this.btnled6 = new System.Windows.Forms.Button();
            this.btnled5 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbxSchnittstellen = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblinfoc = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblausgabestatus = new System.Windows.Forms.Label();
            this.lblschnittstelle = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblvorhersagen = new System.Windows.Forms.Label();
            this.btnerg6 = new System.Windows.Forms.Button();
            this.btnerg5 = new System.Windows.Forms.Button();
            this.btnerg4 = new System.Windows.Forms.Button();
            this.btnerg3 = new System.Windows.Forms.Button();
            this.btnerg2 = new System.Windows.Forms.Button();
            this.btnerg1 = new System.Windows.Forms.Button();
            this.lblergebnisue = new System.Windows.Forms.Label();
            this.lblergebnis = new System.Windows.Forms.Label();
            this.lblvorhersageue = new System.Windows.Forms.Label();
            this.lblvorhersagetf = new System.Windows.Forms.Label();
            this.picLED = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLED)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgrundfunktionen
            // 
            this.txtgrundfunktionen.AutoSize = true;
            this.txtgrundfunktionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrundfunktionen.Location = new System.Drawing.Point(228, 320);
            this.txtgrundfunktionen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtgrundfunktionen.Name = "txtgrundfunktionen";
            this.txtgrundfunktionen.Size = new System.Drawing.Size(117, 18);
            this.txtgrundfunktionen.TabIndex = 0;
            this.txtgrundfunktionen.Text = "Grundfunktionen";
            // 
            // btnwuerfeln
            // 
            this.btnwuerfeln.Location = new System.Drawing.Point(255, 350);
            this.btnwuerfeln.Margin = new System.Windows.Forms.Padding(2);
            this.btnwuerfeln.Name = "btnwuerfeln";
            this.btnwuerfeln.Size = new System.Drawing.Size(58, 21);
            this.btnwuerfeln.TabIndex = 1;
            this.btnwuerfeln.Text = "Würfeln";
            this.btnwuerfeln.UseVisualStyleBackColor = true;
            this.btnwuerfeln.Click += new System.EventHandler(this.btnwuerfeln_Click);
            // 
            // txteinzelsteuerung
            // 
            this.txteinzelsteuerung.AutoSize = true;
            this.txteinzelsteuerung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.txteinzelsteuerung.Location = new System.Drawing.Point(230, 15);
            this.txteinzelsteuerung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txteinzelsteuerung.Name = "txteinzelsteuerung";
            this.txteinzelsteuerung.Size = new System.Drawing.Size(113, 18);
            this.txteinzelsteuerung.TabIndex = 2;
            this.txteinzelsteuerung.Text = "Einzelsteuerung";
            // 
            // btnled1
            // 
            this.btnled1.Location = new System.Drawing.Point(202, 45);
            this.btnled1.Margin = new System.Windows.Forms.Padding(2);
            this.btnled1.Name = "btnled1";
            this.btnled1.Size = new System.Drawing.Size(48, 21);
            this.btnled1.TabIndex = 3;
            this.btnled1.Text = "LED 1";
            this.btnled1.UseVisualStyleBackColor = true;
            this.btnled1.Click += new System.EventHandler(this.btnled1_Click);
            // 
            // btnled2
            // 
            this.btnled2.Location = new System.Drawing.Point(202, 87);
            this.btnled2.Margin = new System.Windows.Forms.Padding(2);
            this.btnled2.Name = "btnled2";
            this.btnled2.Size = new System.Drawing.Size(48, 21);
            this.btnled2.TabIndex = 4;
            this.btnled2.Text = "LED 2";
            this.btnled2.UseVisualStyleBackColor = true;
            this.btnled2.Click += new System.EventHandler(this.btnled2_Click);
            // 
            // btnled3
            // 
            this.btnled3.Location = new System.Drawing.Point(202, 130);
            this.btnled3.Margin = new System.Windows.Forms.Padding(2);
            this.btnled3.Name = "btnled3";
            this.btnled3.Size = new System.Drawing.Size(48, 21);
            this.btnled3.TabIndex = 5;
            this.btnled3.Text = "LED 3";
            this.btnled3.UseVisualStyleBackColor = true;
            this.btnled3.Click += new System.EventHandler(this.btnled3_Click);
            // 
            // btnled4
            // 
            this.btnled4.Location = new System.Drawing.Point(260, 87);
            this.btnled4.Margin = new System.Windows.Forms.Padding(2);
            this.btnled4.Name = "btnled4";
            this.btnled4.Size = new System.Drawing.Size(48, 21);
            this.btnled4.TabIndex = 6;
            this.btnled4.Text = "LED 4";
            this.btnled4.UseVisualStyleBackColor = true;
            this.btnled4.Click += new System.EventHandler(this.btnled4_Click);
            // 
            // btnled7
            // 
            this.btnled7.Location = new System.Drawing.Point(322, 130);
            this.btnled7.Margin = new System.Windows.Forms.Padding(2);
            this.btnled7.Name = "btnled7";
            this.btnled7.Size = new System.Drawing.Size(48, 21);
            this.btnled7.TabIndex = 9;
            this.btnled7.Text = "LED 7";
            this.btnled7.UseVisualStyleBackColor = true;
            this.btnled7.Click += new System.EventHandler(this.btnled7_Click);
            // 
            // btnled6
            // 
            this.btnled6.Location = new System.Drawing.Point(322, 87);
            this.btnled6.Margin = new System.Windows.Forms.Padding(2);
            this.btnled6.Name = "btnled6";
            this.btnled6.Size = new System.Drawing.Size(48, 21);
            this.btnled6.TabIndex = 8;
            this.btnled6.Text = "LED 6";
            this.btnled6.UseVisualStyleBackColor = true;
            this.btnled6.Click += new System.EventHandler(this.btnled6_Click);
            // 
            // btnled5
            // 
            this.btnled5.Location = new System.Drawing.Point(322, 45);
            this.btnled5.Margin = new System.Windows.Forms.Padding(2);
            this.btnled5.Name = "btnled5";
            this.btnled5.Size = new System.Drawing.Size(48, 21);
            this.btnled5.TabIndex = 7;
            this.btnled5.Text = "LED 5";
            this.btnled5.UseVisualStyleBackColor = true;
            this.btnled5.Click += new System.EventHandler(this.btnled5_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(106, 30);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(54, 21);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbxSchnittstellen
            // 
            this.cbxSchnittstellen.BackColor = System.Drawing.SystemColors.Window;
            this.cbxSchnittstellen.FormattingEnabled = true;
            this.cbxSchnittstellen.Location = new System.Drawing.Point(6, 30);
            this.cbxSchnittstellen.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSchnittstellen.Name = "cbxSchnittstellen";
            this.cbxSchnittstellen.Size = new System.Drawing.Size(99, 21);
            this.cbxSchnittstellen.TabIndex = 10;
            this.cbxSchnittstellen.Text = "Port Auswählen";
            this.cbxSchnittstellen.SelectedIndexChanged += new System.EventHandler(this.cbxSchnittstellen_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblinfoc);
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.lblausgabestatus);
            this.panel1.Controls.Add(this.lblschnittstelle);
            this.panel1.Controls.Add(this.btnopen);
            this.panel1.Controls.Add(this.cbxSchnittstellen);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 185);
            this.panel1.TabIndex = 11;
            // 
            // lblinfoc
            // 
            this.lblinfoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblinfoc.Location = new System.Drawing.Point(28, 143);
            this.lblinfoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfoc.MaximumSize = new System.Drawing.Size(104, 26);
            this.lblinfoc.Name = "lblinfoc";
            this.lblinfoc.Size = new System.Drawing.Size(104, 26);
            this.lblinfoc.TabIndex = 15;
            this.lblinfoc.Text = "Bitte Port auswählen";
            this.lblinfoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(37, 122);
            this.lblinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(82, 17);
            this.lblinfo.TabIndex = 14;
            this.lblinfo.Text = "Information:";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(86, 62);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 21);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblausgabestatus
            // 
            this.lblausgabestatus.AutoSize = true;
            this.lblausgabestatus.Location = new System.Drawing.Point(81, 99);
            this.lblausgabestatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblausgabestatus.Name = "lblausgabestatus";
            this.lblausgabestatus.Size = new System.Drawing.Size(58, 13);
            this.lblausgabestatus.TabIndex = 13;
            this.lblausgabestatus.Text = "unbekannt";
            // 
            // lblschnittstelle
            // 
            this.lblschnittstelle.AutoSize = true;
            this.lblschnittstelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschnittstelle.Location = new System.Drawing.Point(36, 6);
            this.lblschnittstelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblschnittstelle.Name = "lblschnittstelle";
            this.lblschnittstelle.Size = new System.Drawing.Size(96, 20);
            this.lblschnittstelle.TabIndex = 12;
            this.lblschnittstelle.Text = "Schnittstelle";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(32, 62);
            this.btnopen.Margin = new System.Windows.Forms.Padding(2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(51, 21);
            this.btnopen.TabIndex = 11;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(29, 96);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 17);
            this.lblstatus.TabIndex = 12;
            this.lblstatus.Text = "Status:";
            // 
            // lblvorhersagen
            // 
            this.lblvorhersagen.AutoSize = true;
            this.lblvorhersagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvorhersagen.Location = new System.Drawing.Point(199, 203);
            this.lblvorhersagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvorhersagen.Name = "lblvorhersagen";
            this.lblvorhersagen.Size = new System.Drawing.Size(170, 18);
            this.lblvorhersagen.TabIndex = 12;
            this.lblvorhersagen.Text = "Ergebnisse Vorhersagen";
            // 
            // btnerg6
            // 
            this.btnerg6.Location = new System.Drawing.Point(321, 271);
            this.btnerg6.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg6.Name = "btnerg6";
            this.btnerg6.Size = new System.Drawing.Size(48, 21);
            this.btnerg6.TabIndex = 18;
            this.btnerg6.Text = "6";
            this.btnerg6.UseVisualStyleBackColor = true;
            this.btnerg6.Click += new System.EventHandler(this.btnerg6_Click);
            // 
            // btnerg5
            // 
            this.btnerg5.Location = new System.Drawing.Point(260, 271);
            this.btnerg5.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg5.Name = "btnerg5";
            this.btnerg5.Size = new System.Drawing.Size(48, 21);
            this.btnerg5.TabIndex = 17;
            this.btnerg5.Text = "5";
            this.btnerg5.UseVisualStyleBackColor = true;
            this.btnerg5.Click += new System.EventHandler(this.btnerg5_Click);
            // 
            // btnerg4
            // 
            this.btnerg4.Location = new System.Drawing.Point(202, 271);
            this.btnerg4.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg4.Name = "btnerg4";
            this.btnerg4.Size = new System.Drawing.Size(48, 21);
            this.btnerg4.TabIndex = 16;
            this.btnerg4.Text = "4";
            this.btnerg4.UseVisualStyleBackColor = true;
            this.btnerg4.Click += new System.EventHandler(this.btnerg4_Click);
            // 
            // btnerg3
            // 
            this.btnerg3.Location = new System.Drawing.Point(322, 233);
            this.btnerg3.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg3.Name = "btnerg3";
            this.btnerg3.Size = new System.Drawing.Size(48, 21);
            this.btnerg3.TabIndex = 15;
            this.btnerg3.Text = "3";
            this.btnerg3.UseVisualStyleBackColor = true;
            this.btnerg3.Click += new System.EventHandler(this.btnerg3_Click);
            // 
            // btnerg2
            // 
            this.btnerg2.Location = new System.Drawing.Point(260, 233);
            this.btnerg2.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg2.Name = "btnerg2";
            this.btnerg2.Size = new System.Drawing.Size(48, 21);
            this.btnerg2.TabIndex = 14;
            this.btnerg2.Text = "2";
            this.btnerg2.UseVisualStyleBackColor = true;
            this.btnerg2.Click += new System.EventHandler(this.btnerg2_Click);
            // 
            // btnerg1
            // 
            this.btnerg1.Location = new System.Drawing.Point(202, 233);
            this.btnerg1.Margin = new System.Windows.Forms.Padding(2);
            this.btnerg1.Name = "btnerg1";
            this.btnerg1.Size = new System.Drawing.Size(48, 21);
            this.btnerg1.TabIndex = 13;
            this.btnerg1.Text = "1";
            this.btnerg1.UseVisualStyleBackColor = true;
            this.btnerg1.Click += new System.EventHandler(this.btnerg1_Click);
            // 
            // lblergebnisue
            // 
            this.lblergebnisue.AutoSize = true;
            this.lblergebnisue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblergebnisue.Location = new System.Drawing.Point(11, 203);
            this.lblergebnisue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblergebnisue.Name = "lblergebnisue";
            this.lblergebnisue.Size = new System.Drawing.Size(66, 18);
            this.lblergebnisue.TabIndex = 19;
            this.lblergebnisue.Text = "Ergebnis";
            // 
            // lblergebnis
            // 
            this.lblergebnis.AutoSize = true;
            this.lblergebnis.Location = new System.Drawing.Point(12, 232);
            this.lblergebnis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblergebnis.Name = "lblergebnis";
            this.lblergebnis.Size = new System.Drawing.Size(58, 13);
            this.lblergebnis.TabIndex = 16;
            this.lblergebnis.Text = "unbekannt";
            // 
            // lblvorhersageue
            // 
            this.lblvorhersageue.AutoSize = true;
            this.lblvorhersageue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvorhersageue.Location = new System.Drawing.Point(91, 203);
            this.lblvorhersageue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvorhersageue.Name = "lblvorhersageue";
            this.lblvorhersageue.Size = new System.Drawing.Size(84, 18);
            this.lblvorhersageue.TabIndex = 20;
            this.lblvorhersageue.Text = "Vorhersage";
            // 
            // lblvorhersagetf
            // 
            this.lblvorhersagetf.AutoSize = true;
            this.lblvorhersagetf.Location = new System.Drawing.Point(101, 232);
            this.lblvorhersagetf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvorhersagetf.Name = "lblvorhersagetf";
            this.lblvorhersagetf.Size = new System.Drawing.Size(58, 13);
            this.lblvorhersagetf.TabIndex = 21;
            this.lblvorhersagetf.Text = "unbekannt";
            // 
            // picLED
            // 
            this.picLED.BackColor = System.Drawing.Color.Transparent;
            this.picLED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLED.Image = ((System.Drawing.Image)(resources.GetObject("picLED.Image")));
            this.picLED.ImageLocation = "";
            this.picLED.Location = new System.Drawing.Point(58, 271);
            this.picLED.Name = "picLED";
            this.picLED.Size = new System.Drawing.Size(66, 84);
            this.picLED.TabIndex = 22;
            this.picLED.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 391);
            this.Controls.Add(this.picLED);
            this.Controls.Add(this.lblvorhersagetf);
            this.Controls.Add(this.lblvorhersageue);
            this.Controls.Add(this.lblergebnis);
            this.Controls.Add(this.lblergebnisue);
            this.Controls.Add(this.btnerg6);
            this.Controls.Add(this.btnerg5);
            this.Controls.Add(this.btnerg4);
            this.Controls.Add(this.btnerg3);
            this.Controls.Add(this.btnerg2);
            this.Controls.Add(this.btnerg1);
            this.Controls.Add(this.lblvorhersagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnled7);
            this.Controls.Add(this.btnled6);
            this.Controls.Add(this.btnled5);
            this.Controls.Add(this.btnled4);
            this.Controls.Add(this.btnled3);
            this.Controls.Add(this.btnled2);
            this.Controls.Add(this.btnled1);
            this.Controls.Add(this.txteinzelsteuerung);
            this.Controls.Add(this.btnwuerfeln);
            this.Controls.Add(this.txtgrundfunktionen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Würfel Remotesteuerung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtgrundfunktionen;
        private System.Windows.Forms.Button btnwuerfeln;
        private System.Windows.Forms.Label txteinzelsteuerung;
        private System.Windows.Forms.Button btnled1;
        private System.Windows.Forms.Button btnled2;
        private System.Windows.Forms.Button btnled3;
        private System.Windows.Forms.Button btnled4;
        private System.Windows.Forms.Button btnled7;
        private System.Windows.Forms.Button btnled6;
        private System.Windows.Forms.Button btnled5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cbxSchnittstellen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblschnittstelle;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblausgabestatus;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblinfoc;
        private System.Windows.Forms.Label lblvorhersagen;
        private System.Windows.Forms.Button btnerg6;
        private System.Windows.Forms.Button btnerg5;
        private System.Windows.Forms.Button btnerg4;
        private System.Windows.Forms.Button btnerg3;
        private System.Windows.Forms.Button btnerg2;
        private System.Windows.Forms.Button btnerg1;
        private System.Windows.Forms.Label lblergebnis;
        private System.Windows.Forms.Label lblergebnisue;
        private System.Windows.Forms.Label lblvorhersageue;
        private System.Windows.Forms.Label lblvorhersagetf;
        private System.Windows.Forms.PictureBox picLED;
    }
}

