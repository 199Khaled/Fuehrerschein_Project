namespace Führerschein
{
    partial class frmBenutzerListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsBenutzer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdatePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonLöschen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsminAddNeuePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPasswordÄndern = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmailSenden = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.cbIsAktive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnAddBenutzer = new System.Windows.Forms.Button();
            this.pbBrnutzerMange = new System.Windows.Forms.PictureBox();
            this.dgvBenutzer = new System.Windows.Forms.DataGridView();
            this.cmsBenutzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrnutzerMange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(341, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benutzer Verwalten";
            // 
            // cmsBenutzer
            // 
            this.cmsBenutzer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonDetails,
            this.toolStripSeparator1,
            this.tsmiUpdatePerson,
            this.tsmiPersonLöschen,
            this.tsminAddNeuePerson,
            this.toolStripSeparator2,
            this.tsmiPasswordÄndern,
            this.tsmiEmailSenden});
            this.cmsBenutzer.Name = "cmsBenutzer";
            this.cmsBenutzer.Size = new System.Drawing.Size(205, 244);
            // 
            // tsmiPersonDetails
            // 
            this.tsmiPersonDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPersonDetails.Image = global::Führerschein.Properties.Resources.PersonDetails_32;
            this.tsmiPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPersonDetails.Name = "tsmiPersonDetails";
            this.tsmiPersonDetails.Size = new System.Drawing.Size(204, 38);
            this.tsmiPersonDetails.Text = "Benutzer Details";
            this.tsmiPersonDetails.Click += new System.EventHandler(this.tsmiPersonDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiUpdatePerson
            // 
            this.tsmiUpdatePerson.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiUpdatePerson.Image = global::Führerschein.Properties.Resources.edit_32;
            this.tsmiUpdatePerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUpdatePerson.Name = "tsmiUpdatePerson";
            this.tsmiUpdatePerson.Size = new System.Drawing.Size(204, 38);
            this.tsmiUpdatePerson.Text = "Update Benutzer";
            this.tsmiUpdatePerson.Click += new System.EventHandler(this.tsmiUpdatePerson_Click);
            // 
            // tsmiPersonLöschen
            // 
            this.tsmiPersonLöschen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiPersonLöschen.Image = global::Führerschein.Properties.Resources.Delete_32;
            this.tsmiPersonLöschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPersonLöschen.Name = "tsmiPersonLöschen";
            this.tsmiPersonLöschen.Size = new System.Drawing.Size(204, 38);
            this.tsmiPersonLöschen.Text = "Benutzer Löschen";
            this.tsmiPersonLöschen.Click += new System.EventHandler(this.tsmiPersonLöschen_Click);
            // 
            // tsminAddNeuePerson
            // 
            this.tsminAddNeuePerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsminAddNeuePerson.Image = global::Führerschein.Properties.Resources.AddPerson_32;
            this.tsminAddNeuePerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsminAddNeuePerson.Name = "tsminAddNeuePerson";
            this.tsminAddNeuePerson.Size = new System.Drawing.Size(204, 38);
            this.tsminAddNeuePerson.Text = "Add Neue Benutzer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiPasswordÄndern
            // 
            this.tsmiPasswordÄndern.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPasswordÄndern.Image = global::Führerschein.Properties.Resources.Password_32;
            this.tsmiPasswordÄndern.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPasswordÄndern.Name = "tsmiPasswordÄndern";
            this.tsmiPasswordÄndern.Size = new System.Drawing.Size(204, 38);
            this.tsmiPasswordÄndern.Text = "Password Ändern";
            this.tsmiPasswordÄndern.Click += new System.EventHandler(this.tsmiPasswordÄndern_Click);
            // 
            // tsmiEmailSenden
            // 
            this.tsmiEmailSenden.Enabled = false;
            this.tsmiEmailSenden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiEmailSenden.Image = global::Führerschein.Properties.Resources.send_email_32;
            this.tsmiEmailSenden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiEmailSenden.Name = "tsmiEmailSenden";
            this.tsmiEmailSenden.Size = new System.Drawing.Size(204, 38);
            this.tsmiEmailSenden.Text = "Email Senden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter Bei:";
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "None",
            "BenutzerID",
            "PersonID",
            "BenutzerName",
            "Vollname",
            "IsAktive"});
            this.cbFilterBei.Location = new System.Drawing.Point(147, 313);
            this.cbFilterBei.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(192, 32);
            this.cbFilterBei.TabIndex = 4;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterWert.Location = new System.Drawing.Point(347, 315);
            this.txtbFilterWert.Margin = new System.Windows.Forms.Padding(4);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(243, 31);
            this.txtbFilterWert.TabIndex = 5;
            this.txtbFilterWert.TextChanged += new System.EventHandler(this.txtbFilterWert_TextChanged);
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            // 
            // cbIsAktive
            // 
            this.cbIsAktive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsAktive.FormattingEnabled = true;
            this.cbIsAktive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsAktive.Location = new System.Drawing.Point(347, 313);
            this.cbIsAktive.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsAktive.Name = "cbIsAktive";
            this.cbIsAktive.Size = new System.Drawing.Size(164, 32);
            this.cbIsAktive.TabIndex = 7;
            this.cbIsAktive.SelectedIndexChanged += new System.EventHandler(this.cbIsAktive_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 610);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(93, 610);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(45, 20);
            this.lblRecord.TabIndex = 9;
            this.lblRecord.Text = "####";
            // 
            // btnAddBenutzer
            // 
            this.btnAddBenutzer.Image = global::Führerschein.Properties.Resources.Add_New_User_72;
            this.btnAddBenutzer.Location = new System.Drawing.Point(855, 274);
            this.btnAddBenutzer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBenutzer.Name = "btnAddBenutzer";
            this.btnAddBenutzer.Size = new System.Drawing.Size(136, 72);
            this.btnAddBenutzer.TabIndex = 6;
            this.btnAddBenutzer.UseVisualStyleBackColor = true;
            this.btnAddBenutzer.Click += new System.EventHandler(this.btnAddBenutzer_Click);
            // 
            // pbBrnutzerMange
            // 
            this.pbBrnutzerMange.Image = global::Führerschein.Properties.Resources.Users_2_400;
            this.pbBrnutzerMange.Location = new System.Drawing.Point(321, 13);
            this.pbBrnutzerMange.Margin = new System.Windows.Forms.Padding(4);
            this.pbBrnutzerMange.Name = "pbBrnutzerMange";
            this.pbBrnutzerMange.Size = new System.Drawing.Size(320, 202);
            this.pbBrnutzerMange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrnutzerMange.TabIndex = 0;
            this.pbBrnutzerMange.TabStop = false;
            // 
            // dgvBenutzer
            // 
            this.dgvBenutzer.AllowUserToAddRows = false;
            this.dgvBenutzer.AllowUserToDeleteRows = false;
            this.dgvBenutzer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenutzer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBenutzer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBenutzer.Location = new System.Drawing.Point(28, 352);
            this.dgvBenutzer.Name = "dgvBenutzer";
            this.dgvBenutzer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBenutzer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBenutzer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBenutzer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenutzer.Size = new System.Drawing.Size(963, 241);
            this.dgvBenutzer.TabIndex = 10;
            // 
            // frmBenutzerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 632);
            this.Controls.Add(this.dgvBenutzer);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIsAktive);
            this.Controls.Add(this.btnAddBenutzer);
            this.Controls.Add(this.txtbFilterWert);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBrnutzerMange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBenutzerListe";
            this.Text = "frmBenutzerListe";
            this.Load += new System.EventHandler(this.frmBenutzerListe_Load);
            this.cmsBenutzer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrnutzerMange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenutzer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBrnutzerMange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private System.Windows.Forms.Button btnAddBenutzer;
        private System.Windows.Forms.ComboBox cbIsAktive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsBenutzer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonLöschen;
        private System.Windows.Forms.ToolStripMenuItem tsminAddNeuePerson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmailSenden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiPasswordÄndern;
        private System.Windows.Forms.DataGridView dgvBenutzer;
    }
}