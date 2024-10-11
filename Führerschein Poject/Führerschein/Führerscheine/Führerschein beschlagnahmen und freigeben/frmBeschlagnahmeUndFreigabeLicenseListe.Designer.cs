namespace Führerschein
{
    partial class frmBeschlagnahmeUndFreigabeLicenseListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBeschlagnahmeLicense = new System.Windows.Forms.DataGridView();
            this.cmsAnträge = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personLiceneseHistorieAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.btnBeschlagnahme = new System.Windows.Forms.Button();
            this.btnFreigabe = new System.Windows.Forms.Button();
            this.cbIstFreigegeben = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschlagnahmeLicense)).BeginInit();
            this.cmsAnträge.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(379, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beschlagnahme License Liste ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(471, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBeschlagnahmeLicense
            // 
            this.dgvBeschlagnahmeLicense.AllowUserToAddRows = false;
            this.dgvBeschlagnahmeLicense.AllowUserToDeleteRows = false;
            this.dgvBeschlagnahmeLicense.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeschlagnahmeLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeschlagnahmeLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeschlagnahmeLicense.ContextMenuStrip = this.cmsAnträge;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeschlagnahmeLicense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeschlagnahmeLicense.Location = new System.Drawing.Point(43, 295);
            this.dgvBeschlagnahmeLicense.Name = "dgvBeschlagnahmeLicense";
            this.dgvBeschlagnahmeLicense.ReadOnly = true;
            this.dgvBeschlagnahmeLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeschlagnahmeLicense.Size = new System.Drawing.Size(1097, 270);
            this.dgvBeschlagnahmeLicense.TabIndex = 2;
            // 
            // cmsAnträge
            // 
            this.cmsAnträge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAnträge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem,
            this.licenseInfoAnzeigenToolStripMenuItem,
            this.personLiceneseHistorieAnzeigenToolStripMenuItem,
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem});
            this.cmsAnträge.Name = "cmsAnträge";
            this.cmsAnträge.Size = new System.Drawing.Size(336, 178);
            this.cmsAnträge.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAnträge_Opening);
            this.cmsAnträge.Opened += new System.EventHandler(this.cmsAnträge_Opened);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.personToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.personToolStripMenuItem.Text = "Person Daten anzeigen";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // licenseInfoAnzeigenToolStripMenuItem
            // 
            this.licenseInfoAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.licenseInfoAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.licenseInfoAnzeigenToolStripMenuItem.Name = "licenseInfoAnzeigenToolStripMenuItem";
            this.licenseInfoAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.licenseInfoAnzeigenToolStripMenuItem.Text = "License Info anzeigen";
            this.licenseInfoAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoAnzeigenToolStripMenuItem_Click);
            // 
            // personLiceneseHistorieAnzeigenToolStripMenuItem
            // 
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonLicenseHistory_32;
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.Name = "personLiceneseHistorieAnzeigenToolStripMenuItem";
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.Text = "Person Licenese Historie anzeigen";
            this.personLiceneseHistorieAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.personLiceneseHistorieAnzeigenToolStripMenuItem_Click);
            // 
            // FreigabBeschlagnahmteLicenseToolStripMenuItem
            // 
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.Image = global::Führerschein.Properties.Resources.Release_Detained_License_32;
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.Name = "FreigabBeschlagnahmteLicenseToolStripMenuItem";
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.Size = new System.Drawing.Size(335, 38);
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.Text = "Freigabe beschlagnahmter License";
            this.FreigabBeschlagnahmteLicenseToolStripMenuItem.Click += new System.EventHandler(this.FreigabBeschlagnahmteLicenseToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(39, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecord.Location = new System.Drawing.Point(127, 574);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(29, 20);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(39, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter bei:";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "None",
            "BeschlagnahmeID",
            "LicenseID",
            "Ausweisnummer",
            "Vollname",
            "istFreigegeben"});
            this.cbFilterBei.Location = new System.Drawing.Point(131, 260);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(191, 28);
            this.cbFilterBei.TabIndex = 6;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(328, 260);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(222, 29);
            this.txtFilterWert.TabIndex = 7;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // btnBeschlagnahme
            // 
            this.btnBeschlagnahme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBeschlagnahme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeschlagnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeschlagnahme.Image = global::Führerschein.Properties.Resources.Detain_32;
            this.btnBeschlagnahme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeschlagnahme.Location = new System.Drawing.Point(770, 247);
            this.btnBeschlagnahme.Name = "btnBeschlagnahme";
            this.btnBeschlagnahme.Size = new System.Drawing.Size(172, 41);
            this.btnBeschlagnahme.TabIndex = 8;
            this.btnBeschlagnahme.Text = "Beschlagnahmen";
            this.btnBeschlagnahme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeschlagnahme.UseVisualStyleBackColor = false;
            this.btnBeschlagnahme.Click += new System.EventHandler(this.btnBeschlagnahme_Click);
            // 
            // btnFreigabe
            // 
            this.btnFreigabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFreigabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreigabe.Image = global::Führerschein.Properties.Resources.Release_Detained_License_32;
            this.btnFreigabe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreigabe.Location = new System.Drawing.Point(968, 247);
            this.btnFreigabe.Name = "btnFreigabe";
            this.btnFreigabe.Size = new System.Drawing.Size(172, 41);
            this.btnFreigabe.TabIndex = 9;
            this.btnFreigabe.Text = "Freigeben";
            this.btnFreigabe.UseVisualStyleBackColor = false;
            this.btnFreigabe.Click += new System.EventHandler(this.btnFreigabe_Click);
            // 
            // cbIstFreigegeben
            // 
            this.cbIstFreigegeben.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIstFreigegeben.FormattingEnabled = true;
            this.cbIstFreigegeben.Items.AddRange(new object[] {
            "Alle",
            "Ja",
            "Nein"});
            this.cbIstFreigegeben.Location = new System.Drawing.Point(328, 261);
            this.cbIstFreigegeben.Name = "cbIstFreigegeben";
            this.cbIstFreigegeben.Size = new System.Drawing.Size(121, 28);
            this.cbIstFreigegeben.TabIndex = 10;
            this.cbIstFreigegeben.Visible = false;
            this.cbIstFreigegeben.SelectedIndexChanged += new System.EventHandler(this.cbIstFreigegeben_SelectedIndexChanged);
            // 
            // frmBeschlagnahmeUndFreigabeLicenseListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 603);
            this.Controls.Add(this.cbIstFreigegeben);
            this.Controls.Add(this.btnFreigabe);
            this.Controls.Add(this.btnBeschlagnahme);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBeschlagnahmeLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBeschlagnahmeUndFreigabeLicenseListe";
            this.Text = "frmBeschlagnahmeUndFreigabeLicenseListe";
            this.Load += new System.EventHandler(this.frmBeschlagnahmeUndFreigabeLicenseListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeschlagnahmeLicense)).EndInit();
            this.cmsAnträge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBeschlagnahmeLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.Button btnBeschlagnahme;
        private System.Windows.Forms.Button btnFreigabe;
        private System.Windows.Forms.ComboBox cbIstFreigegeben;
        private System.Windows.Forms.ContextMenuStrip cmsAnträge;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personLiceneseHistorieAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FreigabBeschlagnahmteLicenseToolStripMenuItem;
    }
}