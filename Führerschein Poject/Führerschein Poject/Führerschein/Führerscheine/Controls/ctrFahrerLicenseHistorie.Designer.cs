namespace Führerschein
{
    partial class ctrFahrerLicenseHistorie
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFahrerLicense = new System.Windows.Forms.GroupBox();
            this.tabControlFahrerLicense = new System.Windows.Forms.TabControl();
            this.tpLokalerFührerschein = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLokalerFührerschein = new System.Windows.Forms.DataGridView();
            this.tpInternationalerFührerschein = new System.Windows.Forms.TabPage();
            this.lblRecord1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInternationalerFührerschein = new System.Windows.Forms.DataGridView();
            this.cmsLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.licenseInfoAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbFahrerLicense.SuspendLayout();
            this.tabControlFahrerLicense.SuspendLayout();
            this.tpLokalerFührerschein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalerFührerschein)).BeginInit();
            this.tpInternationalerFührerschein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalerFührerschein)).BeginInit();
            this.cmsLicenseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFahrerLicense
            // 
            this.gbFahrerLicense.Controls.Add(this.tabControlFahrerLicense);
            this.gbFahrerLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFahrerLicense.ForeColor = System.Drawing.Color.Maroon;
            this.gbFahrerLicense.Location = new System.Drawing.Point(3, 15);
            this.gbFahrerLicense.Name = "gbFahrerLicense";
            this.gbFahrerLicense.Size = new System.Drawing.Size(1007, 345);
            this.gbFahrerLicense.TabIndex = 0;
            this.gbFahrerLicense.TabStop = false;
            this.gbFahrerLicense.Text = "Fahrer License";
            // 
            // tabControlFahrerLicense
            // 
            this.tabControlFahrerLicense.Controls.Add(this.tpLokalerFührerschein);
            this.tabControlFahrerLicense.Controls.Add(this.tpInternationalerFührerschein);
            this.tabControlFahrerLicense.Location = new System.Drawing.Point(6, 37);
            this.tabControlFahrerLicense.Name = "tabControlFahrerLicense";
            this.tabControlFahrerLicense.SelectedIndex = 0;
            this.tabControlFahrerLicense.Size = new System.Drawing.Size(995, 302);
            this.tabControlFahrerLicense.TabIndex = 0;
            // 
            // tpLokalerFührerschein
            // 
            this.tpLokalerFührerschein.BackColor = System.Drawing.Color.Gainsboro;
            this.tpLokalerFührerschein.Controls.Add(this.label2);
            this.tpLokalerFührerschein.Controls.Add(this.lblRecord);
            this.tpLokalerFührerschein.Controls.Add(this.label1);
            this.tpLokalerFührerschein.Controls.Add(this.dgvLokalerFührerschein);
            this.tpLokalerFührerschein.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpLokalerFührerschein.Location = new System.Drawing.Point(4, 29);
            this.tpLokalerFührerschein.Name = "tpLokalerFührerschein";
            this.tpLokalerFührerschein.Padding = new System.Windows.Forms.Padding(3);
            this.tpLokalerFührerschein.Size = new System.Drawing.Size(987, 269);
            this.tpLokalerFührerschein.TabIndex = 0;
            this.tpLokalerFührerschein.Text = "Lokaler Führerschein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lokaler Führerschein Historie:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(105, 230);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(27, 20);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Record:";
            // 
            // dgvLokalerFührerschein
            // 
            this.dgvLokalerFührerschein.AllowUserToAddRows = false;
            this.dgvLokalerFührerschein.AllowUserToDeleteRows = false;
            this.dgvLokalerFührerschein.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLokalerFührerschein.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokalerFührerschein.ContextMenuStrip = this.cmsLicenseInfo;
            this.dgvLokalerFührerschein.Location = new System.Drawing.Point(21, 42);
            this.dgvLokalerFührerschein.Name = "dgvLokalerFührerschein";
            this.dgvLokalerFührerschein.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLokalerFührerschein.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLokalerFührerschein.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokalerFührerschein.Size = new System.Drawing.Size(949, 174);
            this.dgvLokalerFührerschein.TabIndex = 0;
            // 
            // tpInternationalerFührerschein
            // 
            this.tpInternationalerFührerschein.BackColor = System.Drawing.Color.Gainsboro;
            this.tpInternationalerFührerschein.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpInternationalerFührerschein.Controls.Add(this.lblRecord1);
            this.tpInternationalerFührerschein.Controls.Add(this.label4);
            this.tpInternationalerFührerschein.Controls.Add(this.label3);
            this.tpInternationalerFührerschein.Controls.Add(this.dgvInternationalerFührerschein);
            this.tpInternationalerFührerschein.Location = new System.Drawing.Point(4, 29);
            this.tpInternationalerFührerschein.Name = "tpInternationalerFührerschein";
            this.tpInternationalerFührerschein.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalerFührerschein.Size = new System.Drawing.Size(987, 269);
            this.tpInternationalerFührerschein.TabIndex = 1;
            this.tpInternationalerFührerschein.Text = "Internationaler Führerschein";
            // 
            // lblRecord1
            // 
            this.lblRecord1.AutoSize = true;
            this.lblRecord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecord1.Location = new System.Drawing.Point(106, 251);
            this.lblRecord1.Name = "lblRecord1";
            this.lblRecord1.Size = new System.Drawing.Size(27, 20);
            this.lblRecord1.TabIndex = 3;
            this.lblRecord1.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "#Record:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Internationaler Führerschein Historie:";
            // 
            // dgvInternationalerFührerschein
            // 
            this.dgvInternationalerFührerschein.AllowUserToAddRows = false;
            this.dgvInternationalerFührerschein.AllowUserToDeleteRows = false;
            this.dgvInternationalerFührerschein.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInternationalerFührerschein.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalerFührerschein.Location = new System.Drawing.Point(22, 42);
            this.dgvInternationalerFührerschein.Name = "dgvInternationalerFührerschein";
            this.dgvInternationalerFührerschein.ReadOnly = true;
            this.dgvInternationalerFührerschein.Size = new System.Drawing.Size(884, 197);
            this.dgvInternationalerFührerschein.TabIndex = 0;
            // 
            // cmsLicenseInfo
            // 
            this.cmsLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseInfoAnzeigenToolStripMenuItem});
            this.cmsLicenseInfo.Name = "cmsLicenseInfo";
            this.cmsLicenseInfo.Size = new System.Drawing.Size(244, 42);
            // 
            // licenseInfoAnzeigenToolStripMenuItem
            // 
            this.licenseInfoAnzeigenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseInfoAnzeigenToolStripMenuItem.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.licenseInfoAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.licenseInfoAnzeigenToolStripMenuItem.Name = "licenseInfoAnzeigenToolStripMenuItem";
            this.licenseInfoAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.licenseInfoAnzeigenToolStripMenuItem.Text = "License Info Anzeigen";
            this.licenseInfoAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoAnzeigenToolStripMenuItem_Click);
            // 
            // ctrFahrerLicenseHistorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFahrerLicense);
            this.Name = "ctrFahrerLicenseHistorie";
            this.Size = new System.Drawing.Size(1039, 351);
            this.Load += new System.EventHandler(this.ctrFahrerLicenseHistorie_Load);
            this.gbFahrerLicense.ResumeLayout(false);
            this.tabControlFahrerLicense.ResumeLayout(false);
            this.tpLokalerFührerschein.ResumeLayout(false);
            this.tpLokalerFührerschein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalerFührerschein)).EndInit();
            this.tpInternationalerFührerschein.ResumeLayout(false);
            this.tpInternationalerFührerschein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalerFührerschein)).EndInit();
            this.cmsLicenseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFahrerLicense;
        private System.Windows.Forms.TabControl tabControlFahrerLicense;
        private System.Windows.Forms.TabPage tpLokalerFührerschein;
        private System.Windows.Forms.TabPage tpInternationalerFührerschein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLokalerFührerschein;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInternationalerFührerschein;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
