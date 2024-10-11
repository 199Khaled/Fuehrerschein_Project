namespace Führerschein
{
    partial class frmMenschenListe
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
            this.cbFilternBei = new System.Windows.Forms.ComboBox();
            this.txtbGefiltertBei = new System.Windows.Forms.TextBox();
            this.dgvMenschenListe = new System.Windows.Forms.DataGridView();
            this.cmsMenschen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNeuePersonHinfügen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonLöschen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmailSenden = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNeu = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenschenListe)).BeginInit();
            this.cmsMenschen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(484, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menschen führen";
            // 
            // cbFilternBei
            // 
            this.cbFilternBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilternBei.FormattingEnabled = true;
            this.cbFilternBei.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "AusweisNummer",
            "Vorname",
            "Nachname",
            "Geburtstag",
            "Anschrift",
            "Telefon",
            "Email",
            "LandsName",
            "FotoPfad"});
            this.cbFilternBei.Location = new System.Drawing.Point(114, 244);
            this.cbFilternBei.Name = "cbFilternBei";
            this.cbFilternBei.Size = new System.Drawing.Size(140, 28);
            this.cbFilternBei.TabIndex = 2;
            this.cbFilternBei.SelectedIndexChanged += new System.EventHandler(this.cbFilternBei_SelectedIndexChanged);
            // 
            // txtbGefiltertBei
            // 
            this.txtbGefiltertBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbGefiltertBei.Location = new System.Drawing.Point(269, 246);
            this.txtbGefiltertBei.Name = "txtbGefiltertBei";
            this.txtbGefiltertBei.Size = new System.Drawing.Size(198, 26);
            this.txtbGefiltertBei.TabIndex = 3;
            this.txtbGefiltertBei.TextChanged += new System.EventHandler(this.txtbGefiltertBei_TextChanged);
            this.txtbGefiltertBei.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbGefiltertBei_KeyPress);
            // 
            // dgvMenschenListe
            // 
            this.dgvMenschenListe.AllowUserToAddRows = false;
            this.dgvMenschenListe.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenschenListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenschenListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenschenListe.ContextMenuStrip = this.cmsMenschen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenschenListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenschenListe.Location = new System.Drawing.Point(12, 281);
            this.dgvMenschenListe.Name = "dgvMenschenListe";
            this.dgvMenschenListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenschenListe.Size = new System.Drawing.Size(1196, 366);
            this.dgvMenschenListe.TabIndex = 4;
            // 
            // cmsMenschen
            // 
            this.cmsMenschen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMenschen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonDetails,
            this.toolStripSeparator1,
            this.tsmiNeuePersonHinfügen,
            this.tsmiUpdatePerson,
            this.tsmiPersonLöschen,
            this.toolStripSeparator2,
            this.tsmiEmailSenden});
            this.cmsMenschen.Name = "cmsMenschen";
            this.cmsMenschen.Size = new System.Drawing.Size(267, 206);
            // 
            // tsmiPersonDetails
            // 
            this.tsmiPersonDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPersonDetails.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.tsmiPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPersonDetails.Name = "tsmiPersonDetails";
            this.tsmiPersonDetails.Size = new System.Drawing.Size(266, 38);
            this.tsmiPersonDetails.Text = "Sehe Details";
            this.tsmiPersonDetails.Click += new System.EventHandler(this.tsmiPersonDetails_Click);
            // 
            // tsmiNeuePersonHinfügen
            // 
            this.tsmiNeuePersonHinfügen.Image = global::Führerschein.Properties.Resources.AddPerson_32;
            this.tsmiNeuePersonHinfügen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiNeuePersonHinfügen.Name = "tsmiNeuePersonHinfügen";
            this.tsmiNeuePersonHinfügen.Size = new System.Drawing.Size(266, 38);
            this.tsmiNeuePersonHinfügen.Text = "Neue Person hinzufügen";
            this.tsmiNeuePersonHinfügen.Click += new System.EventHandler(this.tsmiNeuePersonHinfügen_Click);
            // 
            // tsmiUpdatePerson
            // 
            this.tsmiUpdatePerson.Image = global::Führerschein.Properties.Resources.edit_32;
            this.tsmiUpdatePerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdatePerson.Name = "tsmiUpdatePerson";
            this.tsmiUpdatePerson.Size = new System.Drawing.Size(266, 38);
            this.tsmiUpdatePerson.Text = "Update Person";
            this.tsmiUpdatePerson.Click += new System.EventHandler(this.tsmiUpdatePerson_Click);
            // 
            // tsmiPersonLöschen
            // 
            this.tsmiPersonLöschen.Image = global::Führerschein.Properties.Resources.Delete_32;
            this.tsmiPersonLöschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPersonLöschen.Name = "tsmiPersonLöschen";
            this.tsmiPersonLöschen.Size = new System.Drawing.Size(266, 38);
            this.tsmiPersonLöschen.Text = "Person löschen";
            this.tsmiPersonLöschen.Click += new System.EventHandler(this.tsmiPersonLöschen_Click);
            // 
            // tsmiEmailSenden
            // 
            this.tsmiEmailSenden.Image = global::Führerschein.Properties.Resources.send_email_32;
            this.tsmiEmailSenden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEmailSenden.Name = "tsmiEmailSenden";
            this.tsmiEmailSenden.Size = new System.Drawing.Size(266, 38);
            this.tsmiEmailSenden.Text = "Email Senden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtern Bei:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(105, 667);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(27, 20);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "??";
            // 
            // btnBeenden
            // 
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(1065, 667);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(143, 34);
            this.btnBeenden.TabIndex = 8;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(490, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNeu
            // 
            this.btnAddNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNeu.Image = global::Führerschein.Properties.Resources.AddPerson_32;
            this.btnAddNeu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNeu.Location = new System.Drawing.Point(1033, 228);
            this.btnAddNeu.Name = "btnAddNeu";
            this.btnAddNeu.Size = new System.Drawing.Size(175, 47);
            this.btnAddNeu.TabIndex = 9;
            this.btnAddNeu.Text = "Add Neu Perosn";
            this.btnAddNeu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNeu.UseVisualStyleBackColor = true;
            this.btnAddNeu.Click += new System.EventHandler(this.btnAddNeu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // frmMenschenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 713);
            this.Controls.Add(this.btnAddNeu);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMenschenListe);
            this.Controls.Add(this.txtbGefiltertBei);
            this.Controls.Add(this.cbFilternBei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenschenListe";
            this.Text = "frmMenschenListe";
            this.Load += new System.EventHandler(this.frmMenschenListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenschenListe)).EndInit();
            this.cmsMenschen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilternBei;
        private System.Windows.Forms.TextBox txtbGefiltertBei;
        private System.Windows.Forms.DataGridView dgvMenschenListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.ContextMenuStrip cmsMenschen;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiNeuePersonHinfügen;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonLöschen;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmailSenden;
        private System.Windows.Forms.Button btnAddNeu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}