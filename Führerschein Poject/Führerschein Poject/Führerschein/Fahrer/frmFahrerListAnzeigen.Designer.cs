namespace Führerschein
{
    partial class frmFahrerListAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvFahrer = new System.Windows.Forms.DataGridView();
            this.cmsFahrer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPersonInfoAnzeigen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterPersonFührerscheinAnzeigen = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDriverImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrer)).BeginInit();
            this.cmsFahrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(377, 266);
            this.txtFilterWert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(256, 29);
            this.txtFilterWert.TabIndex = 129;
            this.txtFilterWert.Visible = false;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(388, 191);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 40);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "Manage Drivers";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFahrer
            // 
            this.dgvFahrer.AllowUserToAddRows = false;
            this.dgvFahrer.AllowUserToDeleteRows = false;
            this.dgvFahrer.AllowUserToResizeRows = false;
            this.dgvFahrer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFahrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFahrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFahrer.ContextMenuStrip = this.cmsFahrer;
            this.dgvFahrer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFahrer.Location = new System.Drawing.Point(46, 308);
            this.dgvFahrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFahrer.MultiSelect = false;
            this.dgvFahrer.Name = "dgvFahrer";
            this.dgvFahrer.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFahrer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFahrer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFahrer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFahrer.Size = new System.Drawing.Size(1097, 277);
            this.dgvFahrer.TabIndex = 126;
            this.dgvFahrer.TabStop = false;
            // 
            // cmsFahrer
            // 
            this.cmsFahrer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsFahrer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonInfoAnzeigen,
            this.tsmiAlterPersonFührerscheinAnzeigen});
            this.cmsFahrer.Name = "cmsFahrer";
            this.cmsFahrer.Size = new System.Drawing.Size(339, 134);
            // 
            // tsmiPersonInfoAnzeigen
            // 
            this.tsmiPersonInfoAnzeigen.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.tsmiPersonInfoAnzeigen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPersonInfoAnzeigen.Name = "tsmiPersonInfoAnzeigen";
            this.tsmiPersonInfoAnzeigen.Size = new System.Drawing.Size(338, 54);
            this.tsmiPersonInfoAnzeigen.Text = "Person Info anzeigen";
            this.tsmiPersonInfoAnzeigen.Click += new System.EventHandler(this.tsmiPersonInfoAnzeigen_Click);
            // 
            // tsmiAlterPersonFührerscheinAnzeigen
            // 
            this.tsmiAlterPersonFührerscheinAnzeigen.Image = global::Führerschein.Properties.Resources.Driver_License_48;
            this.tsmiAlterPersonFührerscheinAnzeigen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAlterPersonFührerscheinAnzeigen.Name = "tsmiAlterPersonFührerscheinAnzeigen";
            this.tsmiAlterPersonFührerscheinAnzeigen.Size = new System.Drawing.Size(338, 54);
            this.tsmiAlterPersonFührerscheinAnzeigen.Text = "Person License Historie anzeigen";
            this.tsmiAlterPersonFührerscheinAnzeigen.Click += new System.EventHandler(this.tsmiAlterPersonFührerscheinAnzeigen_Click);
            // 
            // pbDriverImage
            // 
            this.pbDriverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDriverImage.Image = global::Führerschein.Properties.Resources.Driver_Main;
            this.pbDriverImage.InitialImage = null;
            this.pbDriverImage.Location = new System.Drawing.Point(455, 14);
            this.pbDriverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDriverImage.Name = "pbDriverImage";
            this.pbDriverImage.Size = new System.Drawing.Size(308, 172);
            this.pbDriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverImage.TabIndex = 127;
            this.pbDriverImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 130;
            this.label1.Text = "Filter bei:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "None",
            "FahrerID",
            "PersonID",
            "AusweisNummer",
            "Vollname",
            "ZahlDerAktiveLicense"});
            this.cbFilterBei.Location = new System.Drawing.Point(130, 267);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(240, 28);
            this.cbFilterBei.TabIndex = 131;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(42, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 40);
            this.label2.TabIndex = 132;
            this.label2.Text = "Record:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecord.Location = new System.Drawing.Point(108, 594);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(56, 40);
            this.lblRecord.TabIndex = 133;
            this.lblRecord.Text = "###";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFahrerListAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 643);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterWert);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFahrer);
            this.Controls.Add(this.pbDriverImage);
            this.Name = "frmFahrerListAnzeigen";
            this.Text = "frmFahrerListAnzeigen";
            this.Load += new System.EventHandler(this.frmFahrerListAnzeigen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrer)).EndInit();
            this.cmsFahrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFahrer;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsFahrer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonInfoAnzeigen;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterPersonFührerscheinAnzeigen;
    }
}