namespace Führerschein
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAnträge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFührerscheinService = new System.Windows.Forms.ToolStripMenuItem();
            this.neuFührerscheinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalerFührerscheinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalerFührerscheinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FührerscheinErneuerntoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.prüfungWiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anträgeBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalerFührerscheinAntragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalFührerscheinAntragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beschlagnahmeFührerscheineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.führerscheinBeschlagnahmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.führerscheinFreigebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anträgeKategorieBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypenBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenschen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFahrer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBenutzer = new System.Windows.Forms.ToolStripMenuItem();
            this.accountEinsetellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAktuelleBenutzerInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPasswordÄndern = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbmelden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAnträge,
            this.tsmiMenschen,
            this.tsmiFahrer,
            this.tsmiBenutzer,
            this.accountEinsetellungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 84);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAnträge
            // 
            this.tsmiAnträge.Checked = true;
            this.tsmiAnträge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAnträge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFührerscheinService,
            this.anträgeBearbeitenToolStripMenuItem,
            this.beschlagnahmeFührerscheineToolStripMenuItem,
            this.anträgeKategorieBearbeitenToolStripMenuItem,
            this.testTypenBearbeitenToolStripMenuItem});
            this.tsmiAnträge.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAnträge.Image = global::Führerschein.Properties.Resources.Applications_64;
            this.tsmiAnträge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAnträge.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.tsmiAnträge.Name = "tsmiAnträge";
            this.tsmiAnträge.Size = new System.Drawing.Size(186, 80);
            this.tsmiAnträge.Text = "Application";
            // 
            // tsmiFührerscheinService
            // 
            this.tsmiFührerscheinService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuFührerscheinToolStripMenuItem,
            this.FührerscheinErneuerntoolStripMenuItem1,
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2,
            this.prüfungWiederholenToolStripMenuItem});
            this.tsmiFührerscheinService.Image = global::Führerschein.Properties.Resources.Driver_License_48;
            this.tsmiFührerscheinService.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFührerscheinService.Name = "tsmiFührerscheinService";
            this.tsmiFührerscheinService.Size = new System.Drawing.Size(392, 70);
            this.tsmiFührerscheinService.Text = "Führerschein Service";
            this.tsmiFührerscheinService.Click += new System.EventHandler(this.tsmiFührerscheinService_Click);
            // 
            // neuFührerscheinToolStripMenuItem
            // 
            this.neuFührerscheinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalerFührerscheinToolStripMenuItem,
            this.internationalerFührerscheinToolStripMenuItem});
            this.neuFührerscheinToolStripMenuItem.Image = global::Führerschein.Properties.Resources.LocalDriving_License;
            this.neuFührerscheinToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neuFührerscheinToolStripMenuItem.Name = "neuFührerscheinToolStripMenuItem";
            this.neuFührerscheinToolStripMenuItem.Size = new System.Drawing.Size(539, 38);
            this.neuFührerscheinToolStripMenuItem.Text = "Neu Führerschein";
            // 
            // lokalerFührerscheinToolStripMenuItem
            // 
            this.lokalerFührerscheinToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Local_32;
            this.lokalerFührerscheinToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lokalerFührerscheinToolStripMenuItem.Name = "lokalerFührerscheinToolStripMenuItem";
            this.lokalerFührerscheinToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.lokalerFührerscheinToolStripMenuItem.Text = "Lokaler Führerschein";
            this.lokalerFührerscheinToolStripMenuItem.Click += new System.EventHandler(this.lokalerFührerscheinToolStripMenuItem_Click);
            // 
            // internationalerFührerscheinToolStripMenuItem
            // 
            this.internationalerFührerscheinToolStripMenuItem.Image = global::Führerschein.Properties.Resources.International_32;
            this.internationalerFührerscheinToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalerFührerscheinToolStripMenuItem.Name = "internationalerFührerscheinToolStripMenuItem";
            this.internationalerFührerscheinToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.internationalerFührerscheinToolStripMenuItem.Text = "International Führerschein";
            this.internationalerFührerscheinToolStripMenuItem.Click += new System.EventHandler(this.internationalerFührerscheinToolStripMenuItem_Click);
            // 
            // FührerscheinErneuerntoolStripMenuItem1
            // 
            this.FührerscheinErneuerntoolStripMenuItem1.Image = global::Führerschein.Properties.Resources.LocalDriving_License;
            this.FührerscheinErneuerntoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FührerscheinErneuerntoolStripMenuItem1.Name = "FührerscheinErneuerntoolStripMenuItem1";
            this.FührerscheinErneuerntoolStripMenuItem1.Size = new System.Drawing.Size(539, 38);
            this.FührerscheinErneuerntoolStripMenuItem1.Text = "Den Führerschein Erneuern";
            this.FührerscheinErneuerntoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2
            // 
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.Image = global::Führerschein.Properties.Resources.LocalDriving_License;
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.Name = "ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2";
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.Size = new System.Drawing.Size(539, 38);
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.Text = "Beschädigter oder verlorener Führerschein ersetzen";
            this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2.Click += new System.EventHandler(this.ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2_Click);
            // 
            // prüfungWiederholenToolStripMenuItem
            // 
            this.prüfungWiederholenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Retake_Test_32;
            this.prüfungWiederholenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prüfungWiederholenToolStripMenuItem.Name = "prüfungWiederholenToolStripMenuItem";
            this.prüfungWiederholenToolStripMenuItem.Size = new System.Drawing.Size(539, 38);
            this.prüfungWiederholenToolStripMenuItem.Text = "Prüfung Wiederholen";
            this.prüfungWiederholenToolStripMenuItem.Click += new System.EventHandler(this.prüfungWiederholenToolStripMenuItem_Click);
            // 
            // anträgeBearbeitenToolStripMenuItem
            // 
            this.anträgeBearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalerFührerscheinAntragToolStripMenuItem,
            this.internationalFührerscheinAntragToolStripMenuItem});
            this.anträgeBearbeitenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Manage_Applications_64;
            this.anträgeBearbeitenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anträgeBearbeitenToolStripMenuItem.Name = "anträgeBearbeitenToolStripMenuItem";
            this.anträgeBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.anträgeBearbeitenToolStripMenuItem.Text = "Anträge Bearbeiten";
            // 
            // lokalerFührerscheinAntragToolStripMenuItem
            // 
            this.lokalerFührerscheinAntragToolStripMenuItem.Image = global::Führerschein.Properties.Resources.LocalDriving_License;
            this.lokalerFührerscheinAntragToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lokalerFührerscheinAntragToolStripMenuItem.Name = "lokalerFührerscheinAntragToolStripMenuItem";
            this.lokalerFührerscheinAntragToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.lokalerFührerscheinAntragToolStripMenuItem.Text = "Lokaler Führerscheine Liste";
            this.lokalerFührerscheinAntragToolStripMenuItem.Click += new System.EventHandler(this.lokalerFührerscheinAntragToolStripMenuItem_Click);
            // 
            // internationalFührerscheinAntragToolStripMenuItem
            // 
            this.internationalFührerscheinAntragToolStripMenuItem.Image = global::Führerschein.Properties.Resources.International_32;
            this.internationalFührerscheinAntragToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalFührerscheinAntragToolStripMenuItem.Name = "internationalFührerscheinAntragToolStripMenuItem";
            this.internationalFührerscheinAntragToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.internationalFührerscheinAntragToolStripMenuItem.Text = "international Führerscheine Liste";
            this.internationalFührerscheinAntragToolStripMenuItem.Click += new System.EventHandler(this.internationalFührerscheinAntragToolStripMenuItem_Click);
            // 
            // beschlagnahmeFührerscheineToolStripMenuItem
            // 
            this.beschlagnahmeFührerscheineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem,
            this.führerscheinBeschlagnahmenToolStripMenuItem,
            this.führerscheinFreigebenToolStripMenuItem});
            this.beschlagnahmeFührerscheineToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Detain_64;
            this.beschlagnahmeFührerscheineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.beschlagnahmeFührerscheineToolStripMenuItem.Name = "beschlagnahmeFührerscheineToolStripMenuItem";
            this.beschlagnahmeFührerscheineToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.beschlagnahmeFührerscheineToolStripMenuItem.Text = "Beschlagnahme Führerscheine";
            // 
            // beschlagnahmteFührerscheineVerwaltenToolStripMenuItem
            // 
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Detain_32;
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.Name = "beschlagnahmteFührerscheineVerwaltenToolStripMenuItem";
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.Size = new System.Drawing.Size(457, 38);
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.Text = "Beschlagnahmte Führerscheine verwalten";
            this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem.Click += new System.EventHandler(this.beschlagnahmteFührerscheineVerwaltenToolStripMenuItem_Click);
            // 
            // führerscheinBeschlagnahmenToolStripMenuItem
            // 
            this.führerscheinBeschlagnahmenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Detain_32;
            this.führerscheinBeschlagnahmenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.führerscheinBeschlagnahmenToolStripMenuItem.Name = "führerscheinBeschlagnahmenToolStripMenuItem";
            this.führerscheinBeschlagnahmenToolStripMenuItem.Size = new System.Drawing.Size(457, 38);
            this.führerscheinBeschlagnahmenToolStripMenuItem.Text = "Führerschein beschlagnahmen";
            this.führerscheinBeschlagnahmenToolStripMenuItem.Click += new System.EventHandler(this.führerscheinBeschlagnahmenToolStripMenuItem_Click);
            // 
            // führerscheinFreigebenToolStripMenuItem
            // 
            this.führerscheinFreigebenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Release_Detained_License_32;
            this.führerscheinFreigebenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.führerscheinFreigebenToolStripMenuItem.Name = "führerscheinFreigebenToolStripMenuItem";
            this.führerscheinFreigebenToolStripMenuItem.Size = new System.Drawing.Size(457, 38);
            this.führerscheinFreigebenToolStripMenuItem.Text = "Führerschein freigeben";
            this.führerscheinFreigebenToolStripMenuItem.Click += new System.EventHandler(this.führerscheinFreigebenToolStripMenuItem_Click);
            // 
            // anträgeKategorieBearbeitenToolStripMenuItem
            // 
            this.anträgeKategorieBearbeitenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Application_Types_64;
            this.anträgeKategorieBearbeitenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anträgeKategorieBearbeitenToolStripMenuItem.Name = "anträgeKategorieBearbeitenToolStripMenuItem";
            this.anträgeKategorieBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.anträgeKategorieBearbeitenToolStripMenuItem.Text = "AnträgeKategorie Bearbeiten";
            this.anträgeKategorieBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.anträgeKategorieBearbeitenToolStripMenuItem_Click);
            // 
            // testTypenBearbeitenToolStripMenuItem
            // 
            this.testTypenBearbeitenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Test_Type_64;
            this.testTypenBearbeitenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.testTypenBearbeitenToolStripMenuItem.Name = "testTypenBearbeitenToolStripMenuItem";
            this.testTypenBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(392, 70);
            this.testTypenBearbeitenToolStripMenuItem.Text = "Test Typen Bearbeiten";
            this.testTypenBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.testTypenBearbeitenToolStripMenuItem_Click);
            // 
            // tsmiMenschen
            // 
            this.tsmiMenschen.AutoSize = false;
            this.tsmiMenschen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiMenschen.Image = global::Führerschein.Properties.Resources.People_64;
            this.tsmiMenschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMenschen.Name = "tsmiMenschen";
            this.tsmiMenschen.Size = new System.Drawing.Size(200, 80);
            this.tsmiMenschen.Text = "Menschen";
            this.tsmiMenschen.Click += new System.EventHandler(this.tsmiMenschen_Click);
            // 
            // tsmiFahrer
            // 
            this.tsmiFahrer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFahrer.Image = global::Führerschein.Properties.Resources.Drivers_64;
            this.tsmiFahrer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFahrer.Name = "tsmiFahrer";
            this.tsmiFahrer.Size = new System.Drawing.Size(142, 80);
            this.tsmiFahrer.Text = "Fahrer";
            this.tsmiFahrer.Click += new System.EventHandler(this.tsmiFahrer_Click);
            // 
            // tsmiBenutzer
            // 
            this.tsmiBenutzer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiBenutzer.Image = global::Führerschein.Properties.Resources.Users_2_64;
            this.tsmiBenutzer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBenutzer.Name = "tsmiBenutzer";
            this.tsmiBenutzer.Size = new System.Drawing.Size(164, 80);
            this.tsmiBenutzer.Text = "Benutzer";
            this.tsmiBenutzer.Click += new System.EventHandler(this.tsmiBenutzer_Click);
            // 
            // accountEinsetellungToolStripMenuItem
            // 
            this.accountEinsetellungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAktuelleBenutzerInfos,
            this.tsmiPasswordÄndern,
            this.tsmiAbmelden});
            this.accountEinsetellungToolStripMenuItem.Image = global::Führerschein.Properties.Resources.account_settings_64;
            this.accountEinsetellungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountEinsetellungToolStripMenuItem.Name = "accountEinsetellungToolStripMenuItem";
            this.accountEinsetellungToolStripMenuItem.Size = new System.Drawing.Size(268, 80);
            this.accountEinsetellungToolStripMenuItem.Text = "Account Einsetellung";
            this.accountEinsetellungToolStripMenuItem.Click += new System.EventHandler(this.accountEinsetellungToolStripMenuItem_Click);
            // 
            // tsmiAktuelleBenutzerInfos
            // 
            this.tsmiAktuelleBenutzerInfos.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.tsmiAktuelleBenutzerInfos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAktuelleBenutzerInfos.Name = "tsmiAktuelleBenutzerInfos";
            this.tsmiAktuelleBenutzerInfos.Size = new System.Drawing.Size(292, 38);
            this.tsmiAktuelleBenutzerInfos.Text = "Aktuelle Benutzer Info";
            this.tsmiAktuelleBenutzerInfos.Click += new System.EventHandler(this.tsmiAktuelleBenutzerInfos_Click);
            // 
            // tsmiPasswordÄndern
            // 
            this.tsmiPasswordÄndern.Image = global::Führerschein.Properties.Resources.Password_32;
            this.tsmiPasswordÄndern.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPasswordÄndern.Name = "tsmiPasswordÄndern";
            this.tsmiPasswordÄndern.Size = new System.Drawing.Size(292, 38);
            this.tsmiPasswordÄndern.Text = "Password Ändern";
            this.tsmiPasswordÄndern.Click += new System.EventHandler(this.tsmiPasswordÄndern_Click);
            // 
            // tsmiAbmelden
            // 
            this.tsmiAbmelden.Image = global::Führerschein.Properties.Resources.sign_out_32__2;
            this.tsmiAbmelden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAbmelden.Name = "tsmiAbmelden";
            this.tsmiAbmelden.Size = new System.Drawing.Size(292, 38);
            this.tsmiAbmelden.Text = "Abmelden";
            this.tsmiAbmelden.Click += new System.EventHandler(this.tsmiAbmelden_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 565);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmiAnträge;
        private System.Windows.Forms.ToolStripMenuItem tsmiFührerscheinService;
        private System.Windows.Forms.ToolStripMenuItem anträgeBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beschlagnahmeFührerscheineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anträgeKategorieBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypenBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenschen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFahrer;
        private System.Windows.Forms.ToolStripMenuItem tsmiBenutzer;
        private System.Windows.Forms.ToolStripMenuItem accountEinsetellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAktuelleBenutzerInfos;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasswordÄndern;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbmelden;
        private System.Windows.Forms.ToolStripMenuItem neuFührerscheinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalerFührerscheinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalerFührerscheinAntragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prüfungWiederholenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FührerscheinErneuerntoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ErsatzFürVerlorenenOderBeschädigtentoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem beschlagnahmteFührerscheineVerwaltenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem führerscheinBeschlagnahmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem führerscheinFreigebenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalerFührerscheinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalFührerscheinAntragToolStripMenuItem;
    }
}