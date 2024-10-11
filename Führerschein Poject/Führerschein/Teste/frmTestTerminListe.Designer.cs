namespace Führerschein
{
    partial class frmTestTerminListe
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
            this.pbTestTermine = new System.Windows.Forms.PictureBox();
            this.lblTestTilte = new System.Windows.Forms.Label();
            this.dgvTestTermin = new System.Windows.Forms.DataGridView();
            this.cmsAntrag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdatetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TestFestlegentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lable1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnTerminFestlegen = new System.Windows.Forms.Button();
            this.ctrFührerscheinAntragsInfo1 = new Führerschein.ctrFührerscheinAntragsInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTermine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTermin)).BeginInit();
            this.cmsAntrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTestTermine
            // 
            this.pbTestTermine.Image = global::Führerschein.Properties.Resources.Vision_512;
            this.pbTestTermine.Location = new System.Drawing.Point(292, 12);
            this.pbTestTermine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbTestTermine.Name = "pbTestTermine";
            this.pbTestTermine.Size = new System.Drawing.Size(107, 92);
            this.pbTestTermine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTermine.TabIndex = 0;
            this.pbTestTermine.TabStop = false;
            // 
            // lblTestTilte
            // 
            this.lblTestTilte.AutoSize = true;
            this.lblTestTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTilte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTestTilte.Location = new System.Drawing.Point(421, 58);
            this.lblTestTilte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestTilte.Name = "lblTestTilte";
            this.lblTestTilte.Size = new System.Drawing.Size(111, 25);
            this.lblTestTilte.TabIndex = 3;
            this.lblTestTilte.Text = "Test Titel";
            // 
            // dgvTestTermin
            // 
            this.dgvTestTermin.AllowUserToAddRows = false;
            this.dgvTestTermin.AllowUserToDeleteRows = false;
            this.dgvTestTermin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTestTermin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTermin.ContextMenuStrip = this.cmsAntrag;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTermin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTermin.Location = new System.Drawing.Point(19, 586);
            this.dgvTestTermin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTestTermin.Name = "dgvTestTermin";
            this.dgvTestTermin.ReadOnly = true;
            this.dgvTestTermin.Size = new System.Drawing.Size(867, 151);
            this.dgvTestTermin.TabIndex = 5;
            // 
            // cmsAntrag
            // 
            this.cmsAntrag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatetoolStripMenuItem1,
            this.TestFestlegentoolStripMenuItem1});
            this.cmsAntrag.Name = "cmsAntrag";
            this.cmsAntrag.Size = new System.Drawing.Size(167, 80);
            // 
            // UpdatetoolStripMenuItem1
            // 
            this.UpdatetoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatetoolStripMenuItem1.Image = global::Führerschein.Properties.Resources.edit_32;
            this.UpdatetoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdatetoolStripMenuItem1.Name = "UpdatetoolStripMenuItem1";
            this.UpdatetoolStripMenuItem1.Size = new System.Drawing.Size(166, 38);
            this.UpdatetoolStripMenuItem1.Text = "Update";
            this.UpdatetoolStripMenuItem1.Click += new System.EventHandler(this.UpdatetoolStripMenuItem1_Click);
            // 
            // TestFestlegentoolStripMenuItem1
            // 
            this.TestFestlegentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFestlegentoolStripMenuItem1.Image = global::Führerschein.Properties.Resources.Test_32;
            this.TestFestlegentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TestFestlegentoolStripMenuItem1.Name = "TestFestlegentoolStripMenuItem1";
            this.TestFestlegentoolStripMenuItem1.Size = new System.Drawing.Size(166, 38);
            this.TestFestlegentoolStripMenuItem1.Text = "Test Festlege";
            this.TestFestlegentoolStripMenuItem1.Click += new System.EventHandler(this.TestFestlegentoolStripMenuItem1_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(14, 749);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 20);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "#Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(113, 749);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "###";
            // 
            // btnTerminFestlegen
            // 
            this.btnTerminFestlegen.BackColor = System.Drawing.Color.Turquoise;
            this.btnTerminFestlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminFestlegen.Image = global::Führerschein.Properties.Resources.AddAppointment_32;
            this.btnTerminFestlegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminFestlegen.Location = new System.Drawing.Point(904, 580);
            this.btnTerminFestlegen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTerminFestlegen.Name = "btnTerminFestlegen";
            this.btnTerminFestlegen.Size = new System.Drawing.Size(80, 53);
            this.btnTerminFestlegen.TabIndex = 8;
            this.btnTerminFestlegen.Text = "Add";
            this.btnTerminFestlegen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminFestlegen.UseVisualStyleBackColor = false;
            this.btnTerminFestlegen.Click += new System.EventHandler(this.btnTerminFestlegen_Click);
            // 
            // ctrFührerscheinAntragsInfo1
            // 
            this.ctrFührerscheinAntragsInfo1.Location = new System.Drawing.Point(13, 110);
            this.ctrFührerscheinAntragsInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrFührerscheinAntragsInfo1.Name = "ctrFührerscheinAntragsInfo1";
            this.ctrFührerscheinAntragsInfo1.Size = new System.Drawing.Size(1051, 470);
            this.ctrFührerscheinAntragsInfo1.TabIndex = 9;
            // 
            // frmTestTerminListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 751);
            this.Controls.Add(this.ctrFührerscheinAntragsInfo1);
            this.Controls.Add(this.btnTerminFestlegen);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.dgvTestTermin);
            this.Controls.Add(this.lblTestTilte);
            this.Controls.Add(this.pbTestTermine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTestTerminListe";
            this.Text = "frmTestTerminListe";
            this.Load += new System.EventHandler(this.frmTestTerminListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTermine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTermin)).EndInit();
            this.cmsAntrag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestTermine;
        private System.Windows.Forms.Label lblTestTilte;
        private System.Windows.Forms.DataGridView dgvTestTermin;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnTerminFestlegen;
        private System.Windows.Forms.ContextMenuStrip cmsAntrag;
        private System.Windows.Forms.ToolStripMenuItem UpdatetoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TestFestlegentoolStripMenuItem1;
        private ctrFührerscheinAntragsInfo ctrFührerscheinAntragsInfo1;
    }
}