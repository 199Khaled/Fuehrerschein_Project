namespace Führerschein
{
    partial class frmFreigabeBeschlagnahmteFührerschein
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
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnFreigabe = new System.Windows.Forms.Button();
            this.llLicenseHistorieAnzeigen = new System.Windows.Forms.LinkLabel();
            this.llLicenseInfoAnzeigen = new System.Windows.Forms.LinkLabel();
            this.gpBeschlagnahmeInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblAntragsID = new System.Windows.Forms.Label();
            this.lblInsgesamteGebühren = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblAntragsGebühren = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblStrafgebühren = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErstelltBeiBenutzer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBeschlagnahmtesDatum = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBeschlagnahmeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrFahrerLicenseInfoMitFilter1 = new Führerschein.ctrFahrerLicenseInfoMitFilter();
            this.gpBeschlagnahmeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeenden
            // 
            this.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(881, 531);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(137, 37);
            this.btnBeenden.TabIndex = 193;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnFreigabe
            // 
            this.btnFreigabe.Enabled = false;
            this.btnFreigabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreigabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreigabe.Image = global::Führerschein.Properties.Resources.Release_Detained_License_32;
            this.btnFreigabe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreigabe.Location = new System.Drawing.Point(880, 471);
            this.btnFreigabe.Name = "btnFreigabe";
            this.btnFreigabe.Size = new System.Drawing.Size(138, 37);
            this.btnFreigabe.TabIndex = 194;
            this.btnFreigabe.Text = "Freigeben";
            this.btnFreigabe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFreigabe.UseVisualStyleBackColor = true;
            this.btnFreigabe.Click += new System.EventHandler(this.btnFreigabe_Click);
            // 
            // llLicenseHistorieAnzeigen
            // 
            this.llLicenseHistorieAnzeigen.AutoSize = true;
            this.llLicenseHistorieAnzeigen.Enabled = false;
            this.llLicenseHistorieAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseHistorieAnzeigen.Location = new System.Drawing.Point(890, 625);
            this.llLicenseHistorieAnzeigen.Name = "llLicenseHistorieAnzeigen";
            this.llLicenseHistorieAnzeigen.Size = new System.Drawing.Size(191, 20);
            this.llLicenseHistorieAnzeigen.TabIndex = 195;
            this.llLicenseHistorieAnzeigen.TabStop = true;
            this.llLicenseHistorieAnzeigen.Text = "License Historie anzeigen";
            this.llLicenseHistorieAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseHistorieAnzeigen_LinkClicked);
            // 
            // llLicenseInfoAnzeigen
            // 
            this.llLicenseInfoAnzeigen.AutoSize = true;
            this.llLicenseInfoAnzeigen.Enabled = false;
            this.llLicenseInfoAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseInfoAnzeigen.Location = new System.Drawing.Point(890, 591);
            this.llLicenseInfoAnzeigen.Name = "llLicenseInfoAnzeigen";
            this.llLicenseInfoAnzeigen.Size = new System.Drawing.Size(165, 20);
            this.llLicenseInfoAnzeigen.TabIndex = 196;
            this.llLicenseInfoAnzeigen.TabStop = true;
            this.llLicenseInfoAnzeigen.Text = "License Info anzeigen";
            this.llLicenseInfoAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseInfoAnzeigen_LinkClicked);
            // 
            // gpBeschlagnahmeInfo
            // 
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox7);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblAntragsID);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblInsgesamteGebühren);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label8);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label7);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox6);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblAntragsGebühren);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label6);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox5);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblStrafgebühren);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox8);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblLicenseID);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label10);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox2);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox1);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label1);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblErstelltBeiBenutzer);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label2);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox3);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblBeschlagnahmtesDatum);
            this.gpBeschlagnahmeInfo.Controls.Add(this.pictureBox4);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label5);
            this.gpBeschlagnahmeInfo.Controls.Add(this.lblBeschlagnahmeID);
            this.gpBeschlagnahmeInfo.Controls.Add(this.label4);
            this.gpBeschlagnahmeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBeschlagnahmeInfo.Location = new System.Drawing.Point(24, 471);
            this.gpBeschlagnahmeInfo.Name = "gpBeschlagnahmeInfo";
            this.gpBeschlagnahmeInfo.Size = new System.Drawing.Size(850, 173);
            this.gpBeschlagnahmeInfo.TabIndex = 192;
            this.gpBeschlagnahmeInfo.TabStop = false;
            this.gpBeschlagnahmeInfo.Text = "Beschlagnahme Info";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(620, 135);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 203;
            this.pictureBox7.TabStop = false;
            // 
            // lblAntragsID
            // 
            this.lblAntragsID.AutoSize = true;
            this.lblAntragsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntragsID.Location = new System.Drawing.Point(658, 135);
            this.lblAntragsID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntragsID.Name = "lblAntragsID";
            this.lblAntragsID.Size = new System.Drawing.Size(59, 20);
            this.lblAntragsID.TabIndex = 202;
            this.lblAntragsID.Text = "[????]";
            // 
            // lblInsgesamteGebühren
            // 
            this.lblInsgesamteGebühren.AutoSize = true;
            this.lblInsgesamteGebühren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsgesamteGebühren.Location = new System.Drawing.Point(268, 129);
            this.lblInsgesamteGebühren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsgesamteGebühren.Name = "lblInsgesamteGebühren";
            this.lblInsgesamteGebühren.Size = new System.Drawing.Size(59, 20);
            this.lblInsgesamteGebühren.TabIndex = 202;
            this.lblInsgesamteGebühren.Text = "[$$$$]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 200;
            this.label8.Text = "Antrag ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 200;
            this.label7.Text = "Insgesamte Gebühren:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Führerschein.Properties.Resources.money_32;
            this.pictureBox6.Location = new System.Drawing.Point(230, 129);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 201;
            this.pictureBox6.TabStop = false;
            // 
            // lblAntragsGebühren
            // 
            this.lblAntragsGebühren.AutoSize = true;
            this.lblAntragsGebühren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntragsGebühren.Location = new System.Drawing.Point(268, 94);
            this.lblAntragsGebühren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntragsGebühren.Name = "lblAntragsGebühren";
            this.lblAntragsGebühren.Size = new System.Drawing.Size(59, 20);
            this.lblAntragsGebühren.TabIndex = 199;
            this.lblAntragsGebühren.Text = "[$$$$]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 197;
            this.label6.Text = "Antrag Gebühren:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Führerschein.Properties.Resources.money_32;
            this.pictureBox5.Location = new System.Drawing.Point(230, 94);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 198;
            this.pictureBox5.TabStop = false;
            // 
            // lblStrafgebühren
            // 
            this.lblStrafgebühren.AutoSize = true;
            this.lblStrafgebühren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrafgebühren.Location = new System.Drawing.Point(658, 100);
            this.lblStrafgebühren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrafgebühren.Name = "lblStrafgebühren";
            this.lblStrafgebühren.Size = new System.Drawing.Size(59, 20);
            this.lblStrafgebühren.TabIndex = 196;
            this.lblStrafgebühren.Text = "[$$$$]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(620, 28);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 195;
            this.pictureBox8.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(658, 24);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(49, 20);
            this.lblLicenseID.TabIndex = 191;
            this.lblLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 190;
            this.label10.Text = "License ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(229, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Man_32;
            this.pictureBox1.Location = new System.Drawing.Point(620, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 181;
            this.label1.Text = "Erstellt Bei:";
            // 
            // lblErstelltBeiBenutzer
            // 
            this.lblErstelltBeiBenutzer.AutoSize = true;
            this.lblErstelltBeiBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErstelltBeiBenutzer.Location = new System.Drawing.Point(658, 62);
            this.lblErstelltBeiBenutzer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErstelltBeiBenutzer.Name = "lblErstelltBeiBenutzer";
            this.lblErstelltBeiBenutzer.Size = new System.Drawing.Size(59, 20);
            this.lblErstelltBeiBenutzer.TabIndex = 180;
            this.lblErstelltBeiBenutzer.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 177;
            this.label2.Text = "Strafgebühren:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Führerschein.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(620, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 178;
            this.pictureBox3.TabStop = false;
            // 
            // lblBeschlagnahmtesDatum
            // 
            this.lblBeschlagnahmtesDatum.AutoSize = true;
            this.lblBeschlagnahmtesDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschlagnahmtesDatum.Location = new System.Drawing.Point(268, 56);
            this.lblBeschlagnahmtesDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeschlagnahmtesDatum.Name = "lblBeschlagnahmtesDatum";
            this.lblBeschlagnahmtesDatum.Size = new System.Drawing.Size(109, 20);
            this.lblBeschlagnahmtesDatum.TabIndex = 176;
            this.lblBeschlagnahmtesDatum.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Führerschein.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(230, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 175;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 174;
            this.label5.Text = "BeschlagnahmtesDatum:";
            // 
            // lblBeschlagnahmeID
            // 
            this.lblBeschlagnahmeID.AutoSize = true;
            this.lblBeschlagnahmeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschlagnahmeID.Location = new System.Drawing.Point(268, 24);
            this.lblBeschlagnahmeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeschlagnahmeID.Name = "lblBeschlagnahmeID";
            this.lblBeschlagnahmeID.Size = new System.Drawing.Size(49, 20);
            this.lblBeschlagnahmeID.TabIndex = 173;
            this.lblBeschlagnahmeID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 172;
            this.label4.Text = "Beschlagnahme ID:";
            // 
            // ctrFahrerLicenseInfoMitFilter1
            // 
            this.ctrFahrerLicenseInfoMitFilter1.FilterEnabled = true;
            this.ctrFahrerLicenseInfoMitFilter1.Location = new System.Drawing.Point(12, 2);
            this.ctrFahrerLicenseInfoMitFilter1.Name = "ctrFahrerLicenseInfoMitFilter1";
            this.ctrFahrerLicenseInfoMitFilter1.Size = new System.Drawing.Size(993, 453);
            this.ctrFahrerLicenseInfoMitFilter1.TabIndex = 0;
            this.ctrFahrerLicenseInfoMitFilter1.OnLicenseSelected += new System.Action<int>(this.ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected);
            // 
            // frmFreigabeBeschlagnahmteFührerschein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 647);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnFreigabe);
            this.Controls.Add(this.llLicenseHistorieAnzeigen);
            this.Controls.Add(this.llLicenseInfoAnzeigen);
            this.Controls.Add(this.gpBeschlagnahmeInfo);
            this.Controls.Add(this.ctrFahrerLicenseInfoMitFilter1);
            this.Name = "frmFreigabeBeschlagnahmteFührerschein";
            this.Text = "frmFreigabeBeschlagnahmteFührerschein";
            this.Load += new System.EventHandler(this.frmFreigabeBeschlagnahmteFührerschein_Load);
            this.gpBeschlagnahmeInfo.ResumeLayout(false);
            this.gpBeschlagnahmeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrFahrerLicenseInfoMitFilter ctrFahrerLicenseInfoMitFilter1;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnFreigabe;
        private System.Windows.Forms.LinkLabel llLicenseHistorieAnzeigen;
        private System.Windows.Forms.LinkLabel llLicenseInfoAnzeigen;
        private System.Windows.Forms.GroupBox gpBeschlagnahmeInfo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblAntragsID;
        private System.Windows.Forms.Label lblInsgesamteGebühren;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblAntragsGebühren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblStrafgebühren;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErstelltBeiBenutzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBeschlagnahmtesDatum;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBeschlagnahmeID;
        private System.Windows.Forms.Label label4;
    }
}