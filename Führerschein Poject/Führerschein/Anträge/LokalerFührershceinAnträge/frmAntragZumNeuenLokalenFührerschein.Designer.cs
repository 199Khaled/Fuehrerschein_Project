namespace Führerschein
{
    partial class frmAntragZumNeuenLokalenFührerschein
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonKarteMitFilter1 = new Führerschein.ctrlPersonKarteMitFilter();
            this.tabpAntragsInfo = new System.Windows.Forms.TabPage();
            this.cbFührerscheinKlasse = new System.Windows.Forms.ComboBox();
            this.lblErstelltVonBenutzer = new System.Windows.Forms.Label();
            this.lblAntragsGebühren = new System.Windows.Forms.Label();
            this.lblAntragsDatum = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblLokalerFührerscheinID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpPersonInfo.SuspendLayout();
            this.tabpAntragsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpPersonInfo);
            this.tabControl1.Controls.Add(this.tabpAntragsInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpPersonInfo
            // 
            this.tabpPersonInfo.Controls.Add(this.btnNext);
            this.tabpPersonInfo.Controls.Add(this.ctrlPersonKarteMitFilter1);
            this.tabpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabpPersonInfo.Name = "tabpPersonInfo";
            this.tabpPersonInfo.Size = new System.Drawing.Size(1160, 553);
            this.tabpPersonInfo.TabIndex = 2;
            this.tabpPersonInfo.Text = "PersonInfo";
            this.tabpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Führerschein.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(781, 512);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(198, 38);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "zur AntragsInfo";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonKarteMitFilter1
            // 
            this.ctrlPersonKarteMitFilter1.FilterEnabled = true;
            this.ctrlPersonKarteMitFilter1.Location = new System.Drawing.Point(19, 30);
            this.ctrlPersonKarteMitFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonKarteMitFilter1.Name = "ctrlPersonKarteMitFilter1";
            this.ctrlPersonKarteMitFilter1.ShowAddPerson = true;
            this.ctrlPersonKarteMitFilter1.Size = new System.Drawing.Size(1115, 479);
            this.ctrlPersonKarteMitFilter1.TabIndex = 0;
            this.ctrlPersonKarteMitFilter1.Load += new System.EventHandler(this.ctrlPersonKarteMitFilter1_Load);
            // 
            // tabpAntragsInfo
            // 
            this.tabpAntragsInfo.Controls.Add(this.cbFührerscheinKlasse);
            this.tabpAntragsInfo.Controls.Add(this.lblErstelltVonBenutzer);
            this.tabpAntragsInfo.Controls.Add(this.lblAntragsGebühren);
            this.tabpAntragsInfo.Controls.Add(this.lblAntragsDatum);
            this.tabpAntragsInfo.Controls.Add(this.pictureBox6);
            this.tabpAntragsInfo.Controls.Add(this.pictureBox7);
            this.tabpAntragsInfo.Controls.Add(this.pictureBox8);
            this.tabpAntragsInfo.Controls.Add(this.pictureBox9);
            this.tabpAntragsInfo.Controls.Add(this.pictureBox10);
            this.tabpAntragsInfo.Controls.Add(this.lblLokalerFührerscheinID);
            this.tabpAntragsInfo.Controls.Add(this.label10);
            this.tabpAntragsInfo.Controls.Add(this.label11);
            this.tabpAntragsInfo.Controls.Add(this.label12);
            this.tabpAntragsInfo.Controls.Add(this.label13);
            this.tabpAntragsInfo.Controls.Add(this.label14);
            this.tabpAntragsInfo.Location = new System.Drawing.Point(4, 29);
            this.tabpAntragsInfo.Name = "tabpAntragsInfo";
            this.tabpAntragsInfo.Size = new System.Drawing.Size(1160, 553);
            this.tabpAntragsInfo.TabIndex = 3;
            this.tabpAntragsInfo.Text = "AntragsInfo";
            this.tabpAntragsInfo.UseVisualStyleBackColor = true;
            // 
            // cbFührerscheinKlasse
            // 
            this.cbFührerscheinKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFührerscheinKlasse.FormattingEnabled = true;
            this.cbFührerscheinKlasse.Location = new System.Drawing.Point(449, 204);
            this.cbFührerscheinKlasse.Name = "cbFührerscheinKlasse";
            this.cbFührerscheinKlasse.Size = new System.Drawing.Size(244, 28);
            this.cbFührerscheinKlasse.TabIndex = 29;
            // 
            // lblErstelltVonBenutzer
            // 
            this.lblErstelltVonBenutzer.AutoSize = true;
            this.lblErstelltVonBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErstelltVonBenutzer.Location = new System.Drawing.Point(445, 312);
            this.lblErstelltVonBenutzer.Name = "lblErstelltVonBenutzer";
            this.lblErstelltVonBenutzer.Size = new System.Drawing.Size(49, 20);
            this.lblErstelltVonBenutzer.TabIndex = 28;
            this.lblErstelltVonBenutzer.Text = "[???]";
            // 
            // lblAntragsGebühren
            // 
            this.lblAntragsGebühren.AutoSize = true;
            this.lblAntragsGebühren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntragsGebühren.Location = new System.Drawing.Point(445, 260);
            this.lblAntragsGebühren.Name = "lblAntragsGebühren";
            this.lblAntragsGebühren.Size = new System.Drawing.Size(49, 20);
            this.lblAntragsGebühren.TabIndex = 27;
            this.lblAntragsGebühren.Text = "[???]";
            // 
            // lblAntragsDatum
            // 
            this.lblAntragsDatum.AutoSize = true;
            this.lblAntragsDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntragsDatum.Location = new System.Drawing.Point(445, 152);
            this.lblAntragsDatum.Name = "lblAntragsDatum";
            this.lblAntragsDatum.Size = new System.Drawing.Size(49, 20);
            this.lblAntragsDatum.TabIndex = 26;
            this.lblAntragsDatum.Text = "[???]";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Führerschein.Properties.Resources.User_32__2;
            this.pictureBox6.Location = new System.Drawing.Point(391, 312);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Führerschein.Properties.Resources.money_32;
            this.pictureBox7.Location = new System.Drawing.Point(392, 260);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.pictureBox8.Location = new System.Drawing.Point(393, 204);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Führerschein.Properties.Resources.Calendar_32;
            this.pictureBox9.Location = new System.Drawing.Point(393, 152);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox10.Location = new System.Drawing.Point(393, 94);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // lblLokalerFührerscheinID
            // 
            this.lblLokalerFührerscheinID.AutoSize = true;
            this.lblLokalerFührerscheinID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokalerFührerscheinID.Location = new System.Drawing.Point(445, 94);
            this.lblLokalerFührerscheinID.Name = "lblLokalerFührerscheinID";
            this.lblLokalerFührerscheinID.Size = new System.Drawing.Size(49, 20);
            this.lblLokalerFührerscheinID.TabIndex = 20;
            this.lblLokalerFührerscheinID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Erstellt Von:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Antrag Gebühren:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(196, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Führerschein Klasse:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(243, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "AntragsDatum:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(171, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "L.Führerschein.Antrag.ID:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitel.Location = new System.Drawing.Point(331, 20);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(493, 31);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Antrag zum neuen lokalen Führerschein";
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(12, 635);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(158, 38);
            this.btnBeenden.TabIndex = 2;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Image = global::Führerschein.Properties.Resources.Save_32;
            this.btnSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeichern.Location = new System.Drawing.Point(176, 635);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(158, 38);
            this.btnSpeichern.TabIndex = 3;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // frmAntragZumNeuenLokalenFührerschein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 685);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAntragZumNeuenLokalenFührerschein";
            this.Text = "frmAntragZumNeuenLokalenFührerschein";
            this.Deactivate += new System.EventHandler(this.frmAntragZumNeuenLokalenFührerschein_Deactivate);
            this.Load += new System.EventHandler(this.frmAntragZumNeuenLokalenFührerschein_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpPersonInfo.ResumeLayout(false);
            this.tabpAntragsInfo.ResumeLayout(false);
            this.tabpAntragsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabpPersonInfo;
        private ctrlPersonKarteMitFilter ctrlPersonKarteMitFilter1;
        private System.Windows.Forms.TabPage tabpAntragsInfo;
        private System.Windows.Forms.ComboBox cbFührerscheinKlasse;
        private System.Windows.Forms.Label lblErstelltVonBenutzer;
        private System.Windows.Forms.Label lblAntragsGebühren;
        private System.Windows.Forms.Label lblAntragsDatum;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblLokalerFührerscheinID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}