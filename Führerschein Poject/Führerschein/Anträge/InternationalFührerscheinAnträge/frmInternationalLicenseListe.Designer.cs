namespace Führerschein
{
    partial class frmInternationalLicenseListe
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
            this.lblRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.lblFilterBei = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicense = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personInfoAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personLicenseHistorieAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIstAktive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicense)).BeginInit();
            this.cmsInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(93, 590);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 17;
            this.lblRecord.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Record:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = global::Führerschein.Properties.Resources.New_Application_64;
            this.btnAddNew.Location = new System.Drawing.Point(985, 213);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 57);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(320, 244);
            this.txtbFilterWert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(205, 29);
            this.txtbFilterWert.TabIndex = 13;
            this.txtbFilterWert.Visible = false;
            this.txtbFilterWert.TextChanged += new System.EventHandler(this.txtbFilterWert_TextChanged);
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "None",
            "Int_LicenseID",
            "AntragsID",
            "FahrerID",
            "Lokal_LicenseID",
            "IstAktive"});
            this.cbFilterBei.Location = new System.Drawing.Point(112, 245);
            this.cbFilterBei.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(190, 28);
            this.cbFilterBei.TabIndex = 12;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // lblFilterBei
            // 
            this.lblFilterBei.AutoSize = true;
            this.lblFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBei.Location = new System.Drawing.Point(27, 253);
            this.lblFilterBei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterBei.Name = "lblFilterBei";
            this.lblFilterBei.Size = new System.Drawing.Size(86, 20);
            this.lblFilterBei.TabIndex = 11;
            this.lblFilterBei.Text = "Filter Bei:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(638, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(369, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Internationaler License Liste";
            // 
            // dgvInternationalLicense
            // 
            this.dgvInternationalLicense.AllowUserToAddRows = false;
            this.dgvInternationalLicense.AllowUserToDeleteRows = false;
            this.dgvInternationalLicense.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicense.ContextMenuStrip = this.cmsInternationalLicense;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicense.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicense.Location = new System.Drawing.Point(31, 276);
            this.dgvInternationalLicense.Name = "dgvInternationalLicense";
            this.dgvInternationalLicense.ReadOnly = true;
            this.dgvInternationalLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicense.Size = new System.Drawing.Size(1059, 299);
            this.dgvInternationalLicense.TabIndex = 19;
            // 
            // cmsInternationalLicense
            // 
            this.cmsInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsInternationalLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personInfoAnzeigenToolStripMenuItem,
            this.licenseInfoAnzeigenToolStripMenuItem,
            this.personLicenseHistorieAnzeigenToolStripMenuItem});
            this.cmsInternationalLicense.Name = "cmsInternationalLicense";
            this.cmsInternationalLicense.Size = new System.Drawing.Size(323, 118);
            // 
            // personInfoAnzeigenToolStripMenuItem
            // 
            this.personInfoAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.personInfoAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personInfoAnzeigenToolStripMenuItem.Name = "personInfoAnzeigenToolStripMenuItem";
            this.personInfoAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.personInfoAnzeigenToolStripMenuItem.Text = "Person Info anzeigen";
            this.personInfoAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.personInfoAnzeigenToolStripMenuItem_Click);
            // 
            // licenseInfoAnzeigenToolStripMenuItem
            // 
            this.licenseInfoAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.licenseInfoAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.licenseInfoAnzeigenToolStripMenuItem.Name = "licenseInfoAnzeigenToolStripMenuItem";
            this.licenseInfoAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.licenseInfoAnzeigenToolStripMenuItem.Text = "License Info anzeigen";
            this.licenseInfoAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoAnzeigenToolStripMenuItem_Click);
            // 
            // personLicenseHistorieAnzeigenToolStripMenuItem
            // 
            this.personLicenseHistorieAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.PersonLicenseHistory_32;
            this.personLicenseHistorieAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personLicenseHistorieAnzeigenToolStripMenuItem.Name = "personLicenseHistorieAnzeigenToolStripMenuItem";
            this.personLicenseHistorieAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.personLicenseHistorieAnzeigenToolStripMenuItem.Text = "Person License Historie anzeigen";
            this.personLicenseHistorieAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.personLicenseHistorieAnzeigenToolStripMenuItem_Click);
            // 
            // cbIstAktive
            // 
            this.cbIstAktive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIstAktive.FormattingEnabled = true;
            this.cbIstAktive.Items.AddRange(new object[] {
            "Alle",
            "Ja",
            "Nein"});
            this.cbIstAktive.Location = new System.Drawing.Point(320, 245);
            this.cbIstAktive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIstAktive.Name = "cbIstAktive";
            this.cbIstAktive.Size = new System.Drawing.Size(76, 28);
            this.cbIstAktive.TabIndex = 20;
            this.cbIstAktive.SelectedIndexChanged += new System.EventHandler(this.cbIstAktive_SelectedIndexChanged);
            // 
            // frmInternationalLicenseListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 617);
            this.Controls.Add(this.cbIstAktive);
            this.Controls.Add(this.dgvInternationalLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtbFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.lblFilterBei);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInternationalLicenseListe";
            this.Text = "frmInternationalLicenseListe";
            this.Load += new System.EventHandler(this.frmInternationalLicenseListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicense)).EndInit();
            this.cmsInternationalLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.Label lblFilterBei;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalLicense;
        private System.Windows.Forms.ComboBox cbIstAktive;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem personInfoAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personLicenseHistorieAnzeigenToolStripMenuItem;
    }
}