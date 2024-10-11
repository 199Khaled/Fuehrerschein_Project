namespace Führerschein
{
    partial class frmTestTypeListe
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgvTestTypen = new System.Windows.Forms.DataGridView();
            this.cmsTestTypen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdateTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypen)).BeginInit();
            this.cmsTestTypen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(320, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Type Verwalten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(90, 571);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "###";
            // 
            // dgvTestTypen
            // 
            this.dgvTestTypen.AllowUserToAddRows = false;
            this.dgvTestTypen.AllowUserToDeleteRows = false;
            this.dgvTestTypen.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypen.ContextMenuStrip = this.cmsTestTypen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypen.Location = new System.Drawing.Point(16, 265);
            this.dgvTestTypen.Name = "dgvTestTypen";
            this.dgvTestTypen.ReadOnly = true;
            this.dgvTestTypen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypen.Size = new System.Drawing.Size(943, 280);
            this.dgvTestTypen.TabIndex = 4;
            this.dgvTestTypen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestTypen_CellContentClick);
            // 
            // cmsTestTypen
            // 
            this.cmsTestTypen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateTestType});
            this.cmsTestTypen.Name = "cmsTestTypen";
            this.cmsTestTypen.Size = new System.Drawing.Size(193, 42);
            // 
            // tsmiUpdateTestType
            // 
            this.tsmiUpdateTestType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiUpdateTestType.Image = global::Führerschein.Properties.Resources.edit_32;
            this.tsmiUpdateTestType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdateTestType.Name = "tsmiUpdateTestType";
            this.tsmiUpdateTestType.Size = new System.Drawing.Size(192, 38);
            this.tsmiUpdateTestType.Text = "Update Test Type";
            this.tsmiUpdateTestType.Click += new System.EventHandler(this.tsmiUpdateTestType_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(815, 552);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(144, 43);
            this.btnBeenden.TabIndex = 5;
            this.btnBeenden.Text = "beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Schedule_Test_512;
            this.pictureBox1.Location = new System.Drawing.Point(326, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTestTypeListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 604);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.dgvTestTypen);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "frmTestTypeListe";
            this.Text = "frmTestTypeListe";
            this.Load += new System.EventHandler(this.frmTestTypeListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypen)).EndInit();
            this.cmsTestTypen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView dgvTestTypen;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypen;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateTestType;
    }
}