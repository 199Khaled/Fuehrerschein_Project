namespace Führerschein
{
    partial class frmPasswordÄndern
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAktuellesPassword = new System.Windows.Forms.TextBox();
            this.txtbNeuesPassword = new System.Windows.Forms.TextBox();
            this.txtbPasswordBestätigung = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAktuellesPasswordSehen = new System.Windows.Forms.Button();
            this.btnNeuesPasswordSehen = new System.Windows.Forms.Button();
            this.btnPasswortBastätigungSehen = new System.Windows.Forms.Button();
            this.ctrlBenutzerKarte1 = new Führerschein.ctrlBenutzerKarte();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktuelles Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neues Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password Bestätigen:";
            // 
            // txtbAktuellesPassword
            // 
            this.txtbAktuellesPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAktuellesPassword.Location = new System.Drawing.Point(296, 518);
            this.txtbAktuellesPassword.Name = "txtbAktuellesPassword";
            this.txtbAktuellesPassword.PasswordChar = '*';
            this.txtbAktuellesPassword.ReadOnly = true;
            this.txtbAktuellesPassword.Size = new System.Drawing.Size(283, 26);
            this.txtbAktuellesPassword.TabIndex = 7;
            // 
            // txtbNeuesPassword
            // 
            this.txtbNeuesPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNeuesPassword.Location = new System.Drawing.Point(296, 570);
            this.txtbNeuesPassword.Name = "txtbNeuesPassword";
            this.txtbNeuesPassword.PasswordChar = '*';
            this.txtbNeuesPassword.Size = new System.Drawing.Size(283, 26);
            this.txtbNeuesPassword.TabIndex = 8;
            // 
            // txtbPasswordBestätigung
            // 
            this.txtbPasswordBestätigung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPasswordBestätigung.Location = new System.Drawing.Point(296, 620);
            this.txtbPasswordBestätigung.Name = "txtbPasswordBestätigung";
            this.txtbPasswordBestätigung.PasswordChar = '*';
            this.txtbPasswordBestätigung.Size = new System.Drawing.Size(283, 26);
            this.txtbPasswordBestätigung.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(717, 613);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(166, 42);
            this.btnBeenden.TabIndex = 11;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Image = global::Führerschein.Properties.Resources.Save_32;
            this.btnSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeichern.Location = new System.Drawing.Point(717, 554);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(166, 42);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(258, 614);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(258, 564);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(258, 516);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAktuellesPasswordSehen
            // 
            this.btnAktuellesPasswordSehen.Image = global::Führerschein.Properties.Resources.Vision_Test_32;
            this.btnAktuellesPasswordSehen.Location = new System.Drawing.Point(585, 520);
            this.btnAktuellesPasswordSehen.Name = "btnAktuellesPasswordSehen";
            this.btnAktuellesPasswordSehen.Size = new System.Drawing.Size(48, 24);
            this.btnAktuellesPasswordSehen.TabIndex = 12;
            this.btnAktuellesPasswordSehen.UseVisualStyleBackColor = true;
            this.btnAktuellesPasswordSehen.Click += new System.EventHandler(this.btnAktuellesPasswordSehen_Click);
            // 
            // btnNeuesPasswordSehen
            // 
            this.btnNeuesPasswordSehen.Image = global::Führerschein.Properties.Resources.Vision_Test_32;
            this.btnNeuesPasswordSehen.Location = new System.Drawing.Point(585, 572);
            this.btnNeuesPasswordSehen.Name = "btnNeuesPasswordSehen";
            this.btnNeuesPasswordSehen.Size = new System.Drawing.Size(48, 24);
            this.btnNeuesPasswordSehen.TabIndex = 13;
            this.btnNeuesPasswordSehen.UseVisualStyleBackColor = true;
            this.btnNeuesPasswordSehen.Click += new System.EventHandler(this.btnNeuesPasswordSehen_Click);
            // 
            // btnPasswortBastätigungSehen
            // 
            this.btnPasswortBastätigungSehen.Image = global::Führerschein.Properties.Resources.Vision_Test_32;
            this.btnPasswortBastätigungSehen.Location = new System.Drawing.Point(585, 623);
            this.btnPasswortBastätigungSehen.Name = "btnPasswortBastätigungSehen";
            this.btnPasswortBastätigungSehen.Size = new System.Drawing.Size(48, 24);
            this.btnPasswortBastätigungSehen.TabIndex = 14;
            this.btnPasswortBastätigungSehen.UseVisualStyleBackColor = true;
            this.btnPasswortBastätigungSehen.Click += new System.EventHandler(this.btnPasswortBastätigungSehen_Click);
            // 
            // ctrlBenutzerKarte1
            // 
            this.ctrlBenutzerKarte1.Location = new System.Drawing.Point(12, 12);
            this.ctrlBenutzerKarte1.Name = "ctrlBenutzerKarte1";
            this.ctrlBenutzerKarte1.Size = new System.Drawing.Size(885, 477);
            this.ctrlBenutzerKarte1.TabIndex = 0;
            this.ctrlBenutzerKarte1.Load += new System.EventHandler(this.ctrlBenutzerKarte1_Load);
            // 
            // frmPasswordÄndern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 668);
            this.Controls.Add(this.btnPasswortBastätigungSehen);
            this.Controls.Add(this.btnNeuesPasswordSehen);
            this.Controls.Add(this.btnAktuellesPasswordSehen);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtbPasswordBestätigung);
            this.Controls.Add(this.txtbNeuesPassword);
            this.Controls.Add(this.txtbAktuellesPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBenutzerKarte1);
            this.Name = "frmPasswordÄndern";
            this.Text = "frmPasswordÄndern";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBenutzerKarte ctrlBenutzerKarte1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtbAktuellesPassword;
        private System.Windows.Forms.TextBox txtbNeuesPassword;
        private System.Windows.Forms.TextBox txtbPasswordBestätigung;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPasswortBastätigungSehen;
        private System.Windows.Forms.Button btnNeuesPasswordSehen;
        private System.Windows.Forms.Button btnAktuellesPasswordSehen;
    }
}