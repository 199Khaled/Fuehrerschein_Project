namespace Führerschein
{
    partial class FrmLokalerFührerscheinAntragsListe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFilterBei = new System.Windows.Forms.Label();
            this.cbFilterLokalerFührerschein = new System.Windows.Forms.ComboBox();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.dgvLokalerFührerscheinAntragsListe = new System.Windows.Forms.DataGridView();
            this.cmsLokalerFührerschein = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.antragsDetailsSehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAntragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antragLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.antragZurückziehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.prüfungFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seheTestFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.schreibTestFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.fahrTestFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.führerscheinAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalerFührerscheinAntragsListe)).BeginInit();
            this.cmsLokalerFührerschein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterBei
            // 
            this.lblFilterBei.AutoSize = true;
            this.lblFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBei.Location = new System.Drawing.Point(23, 250);
            this.lblFilterBei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterBei.Name = "lblFilterBei";
            this.lblFilterBei.Size = new System.Drawing.Size(86, 20);
            this.lblFilterBei.TabIndex = 2;
            this.lblFilterBei.Text = "Filter Bei:";
            // 
            // cbFilterLokalerFührerschein
            // 
            this.cbFilterLokalerFührerschein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterLokalerFührerschein.FormattingEnabled = true;
            this.cbFilterLokalerFührerschein.Items.AddRange(new object[] {
            "None",
            "LF_AntragsID",
            "Führerschein Klasse",
            "Ausweisnummer",
            "Vollname",
            "AntragsDatum",
            "Bestandene Prüfungen",
            "Status"});
            this.cbFilterLokalerFührerschein.Location = new System.Drawing.Point(115, 250);
            this.cbFilterLokalerFührerschein.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterLokalerFührerschein.Name = "cbFilterLokalerFührerschein";
            this.cbFilterLokalerFührerschein.Size = new System.Drawing.Size(190, 28);
            this.cbFilterLokalerFührerschein.TabIndex = 3;
            this.cbFilterLokalerFührerschein.SelectedIndexChanged += new System.EventHandler(this.cbFilterLokalerFührerschein_SelectedIndexChanged);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(323, 252);
            this.txtbFilterWert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(205, 26);
            this.txtbFilterWert.TabIndex = 4;
            this.txtbFilterWert.TextChanged += new System.EventHandler(this.txtbFilterWert_TextChanged);
            // 
            // dgvLokalerFührerscheinAntragsListe
            // 
            this.dgvLokalerFührerscheinAntragsListe.AllowUserToAddRows = false;
            this.dgvLokalerFührerscheinAntragsListe.AllowUserToDeleteRows = false;
            this.dgvLokalerFührerscheinAntragsListe.AllowUserToOrderColumns = true;
            this.dgvLokalerFührerscheinAntragsListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLokalerFührerscheinAntragsListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokalerFührerscheinAntragsListe.ContextMenuStrip = this.cmsLokalerFührerschein;
            this.dgvLokalerFührerscheinAntragsListe.Location = new System.Drawing.Point(12, 284);
            this.dgvLokalerFührerscheinAntragsListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLokalerFührerscheinAntragsListe.Name = "dgvLokalerFührerscheinAntragsListe";
            this.dgvLokalerFührerscheinAntragsListe.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvLokalerFührerscheinAntragsListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLokalerFührerscheinAntragsListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokalerFührerscheinAntragsListe.Size = new System.Drawing.Size(1097, 314);
            this.dgvLokalerFührerscheinAntragsListe.TabIndex = 5;
            // 
            // cmsLokalerFührerschein
            // 
            this.cmsLokalerFührerschein.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLokalerFührerschein.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.antragsDetailsSehenToolStripMenuItem,
            this.updateAntragToolStripMenuItem,
            this.antragLöschenToolStripMenuItem,
            this.toolStripSeparator2,
            this.antragZurückziehenToolStripMenuItem,
            this.toolStripSeparator3,
            this.prüfungFestlegenToolStripMenuItem,
            this.toolStripSeparator4,
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem,
            this.toolStripSeparator5,
            this.führerscheinAnzeigenToolStripMenuItem,
            this.toolStripSeparator6,
            this.aToolStripMenuItem});
            this.cmsLokalerFührerschein.Name = "cmsLokalerFührerschein";
            this.cmsLokalerFührerschein.Size = new System.Drawing.Size(318, 344);
            this.cmsLokalerFührerschein.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLokalerFührerschein_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(314, 6);
            // 
            // antragsDetailsSehenToolStripMenuItem
            // 
            this.antragsDetailsSehenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.antragsDetailsSehenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.antragsDetailsSehenToolStripMenuItem.Name = "antragsDetailsSehenToolStripMenuItem";
            this.antragsDetailsSehenToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.antragsDetailsSehenToolStripMenuItem.Text = "&Antrags Details Anzeigen";
            this.antragsDetailsSehenToolStripMenuItem.Click += new System.EventHandler(this.antragsDetailsSehenToolStripMenuItem_Click);
            // 
            // updateAntragToolStripMenuItem
            // 
            this.updateAntragToolStripMenuItem.Image = global::Führerschein.Properties.Resources.edit_32;
            this.updateAntragToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAntragToolStripMenuItem.Name = "updateAntragToolStripMenuItem";
            this.updateAntragToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.updateAntragToolStripMenuItem.Text = "&Update Antrag";
            this.updateAntragToolStripMenuItem.Click += new System.EventHandler(this.updateAntragToolStripMenuItem_Click);
            // 
            // antragLöschenToolStripMenuItem
            // 
            this.antragLöschenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Delete_32_2;
            this.antragLöschenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.antragLöschenToolStripMenuItem.Name = "antragLöschenToolStripMenuItem";
            this.antragLöschenToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.antragLöschenToolStripMenuItem.Text = "Antrag &Löschen";
            this.antragLöschenToolStripMenuItem.Click += new System.EventHandler(this.antragLöschenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(314, 6);
            // 
            // antragZurückziehenToolStripMenuItem
            // 
            this.antragZurückziehenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Delete_32;
            this.antragZurückziehenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.antragZurückziehenToolStripMenuItem.Name = "antragZurückziehenToolStripMenuItem";
            this.antragZurückziehenToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.antragZurückziehenToolStripMenuItem.Text = "Antrag &Zurückziehen";
            this.antragZurückziehenToolStripMenuItem.Click += new System.EventHandler(this.antragZurückziehenToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(314, 6);
            // 
            // prüfungFestlegenToolStripMenuItem
            // 
            this.prüfungFestlegenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seheTestFestlegenToolStripMenuItem,
            this.toolStripSeparator7,
            this.schreibTestFestlegenToolStripMenuItem,
            this.toolStripSeparator8,
            this.fahrTestFestlegenToolStripMenuItem});
            this.prüfungFestlegenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Schedule_Test_32;
            this.prüfungFestlegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prüfungFestlegenToolStripMenuItem.Name = "prüfungFestlegenToolStripMenuItem";
            this.prüfungFestlegenToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.prüfungFestlegenToolStripMenuItem.Text = "&Prüfung Festlegen";
            // 
            // seheTestFestlegenToolStripMenuItem
            // 
            this.seheTestFestlegenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Vision_Test_Schdule;
            this.seheTestFestlegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheTestFestlegenToolStripMenuItem.Name = "seheTestFestlegenToolStripMenuItem";
            this.seheTestFestlegenToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.seheTestFestlegenToolStripMenuItem.Text = "Sehe Test Festlegen";
            this.seheTestFestlegenToolStripMenuItem.Click += new System.EventHandler(this.seheTestFestlegenToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(218, 6);
            // 
            // schreibTestFestlegenToolStripMenuItem
            // 
            this.schreibTestFestlegenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Written_Test_32;
            this.schreibTestFestlegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schreibTestFestlegenToolStripMenuItem.Name = "schreibTestFestlegenToolStripMenuItem";
            this.schreibTestFestlegenToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.schreibTestFestlegenToolStripMenuItem.Text = "Schreib Test Festlegen";
            this.schreibTestFestlegenToolStripMenuItem.Click += new System.EventHandler(this.schreibTestFestlegenToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(218, 6);
            // 
            // fahrTestFestlegenToolStripMenuItem
            // 
            this.fahrTestFestlegenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Street_Test_32;
            this.fahrTestFestlegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fahrTestFestlegenToolStripMenuItem.Name = "fahrTestFestlegenToolStripMenuItem";
            this.fahrTestFestlegenToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.fahrTestFestlegenToolStripMenuItem.Text = "Fahr Test Festlegen";
            this.fahrTestFestlegenToolStripMenuItem.Click += new System.EventHandler(this.fahrTestFestlegenToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(314, 6);
            // 
            // ausstellungDesFührerscheinserstmalToolStripMenuItem
            // 
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.Image = global::Führerschein.Properties.Resources.IssueDrivingLicense_32;
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.Name = "ausstellungDesFührerscheinserstmalToolStripMenuItem";
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.Text = "Ausstellung des &Führerscheins(erstmal)";
            this.ausstellungDesFührerscheinserstmalToolStripMenuItem.Click += new System.EventHandler(this.ausstellungDesFührerscheinserstmalToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(314, 6);
            // 
            // führerscheinAnzeigenToolStripMenuItem
            // 
            this.führerscheinAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.führerscheinAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.führerscheinAnzeigenToolStripMenuItem.Name = "führerscheinAnzeigenToolStripMenuItem";
            this.führerscheinAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.führerscheinAnzeigenToolStripMenuItem.Text = "Führerschein Anzei&gen";
            this.führerscheinAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.führerscheinAnzeigenToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(314, 6);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonLicenseHistory_32;
            this.aToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.aToolStripMenuItem.Text = "Führerschein Historie Anzeigen";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 613);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(82, 613);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 8;
            this.lblRecord.Text = "###";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = global::Führerschein.Properties.Resources.New_Application_64;
            this.btnAddNew.Location = new System.Drawing.Point(1002, 215);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(98, 63);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(637, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(411, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(416, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lokaler License Liste";
            // 
            // FrmLokalerFührerscheinAntragsListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvLokalerFührerscheinAntragsListe);
            this.Controls.Add(this.txtbFilterWert);
            this.Controls.Add(this.cbFilterLokalerFührerschein);
            this.Controls.Add(this.lblFilterBei);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLokalerFührerscheinAntragsListe";
            this.Text = "Lokaler  führerschein AntragsListe";
            this.Load += new System.EventHandler(this.FrmLokalerFührerscheinAntragsListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalerFührerscheinAntragsListe)).EndInit();
            this.cmsLokalerFührerschein.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFilterBei;
        private System.Windows.Forms.ComboBox cbFilterLokalerFührerschein;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.DataGridView dgvLokalerFührerscheinAntragsListe;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsLokalerFührerschein;
        private System.Windows.Forms.ToolStripMenuItem antragsDetailsSehenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAntragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antragLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem antragZurückziehenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem prüfungFestlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausstellungDesFührerscheinserstmalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem führerscheinAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem seheTestFestlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem schreibTestFestlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrTestFestlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label label2;
    }
}