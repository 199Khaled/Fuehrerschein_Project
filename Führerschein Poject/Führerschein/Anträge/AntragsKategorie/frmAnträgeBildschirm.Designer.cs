namespace Führerschein
{
    partial class frmAnträgeBildschirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmsAnträge = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdateAntragsKategorie = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAntragsKategorie = new System.Windows.Forms.DataGridView();
            this.cmsAnträge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntragsKategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(269, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "AntragsKategorie verwalten";
            // 
            // cmsAnträge
            // 
            this.cmsAnträge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateAntragsKategorie});
            this.cmsAnträge.Name = "contextMenuStrip1";
            this.cmsAnträge.Size = new System.Drawing.Size(245, 42);
            // 
            // tsmiUpdateAntragsKategorie
            // 
            this.tsmiUpdateAntragsKategorie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiUpdateAntragsKategorie.Image = global::Führerschein.Properties.Resources.edit_32;
            this.tsmiUpdateAntragsKategorie.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdateAntragsKategorie.Name = "tsmiUpdateAntragsKategorie";
            this.tsmiUpdateAntragsKategorie.Size = new System.Drawing.Size(244, 38);
            this.tsmiUpdateAntragsKategorie.Text = "Update AntragsKategorie ";
            this.tsmiUpdateAntragsKategorie.Click += new System.EventHandler(this.tsmiUpdateAntragsKategorie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 579);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(89, 579);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "###";
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(716, 559);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(160, 46);
            this.btnBeenden.TabIndex = 5;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(263, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAntragsKategorie
            // 
            this.dgvAntragsKategorie.AllowUserToAddRows = false;
            this.dgvAntragsKategorie.AllowUserToDeleteRows = false;
            this.dgvAntragsKategorie.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAntragsKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntragsKategorie.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAntragsKategorie.Location = new System.Drawing.Point(31, 274);
            this.dgvAntragsKategorie.Name = "dgvAntragsKategorie";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAntragsKategorie.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAntragsKategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAntragsKategorie.Size = new System.Drawing.Size(845, 278);
            this.dgvAntragsKategorie.TabIndex = 6;
            // 
            // frmAnträgeBildschirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 614);
            this.Controls.Add(this.dgvAntragsKategorie);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnträgeBildschirm";
            this.Text = "frmAnträgeBildschirm";
            this.Load += new System.EventHandler(this.frmAnträgeBildschirm_Load);
            this.cmsAnträge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntragsKategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.ContextMenuStrip cmsAnträge;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateAntragsKategorie;
        private System.Windows.Forms.DataGridView dgvAntragsKategorie;
    }
}