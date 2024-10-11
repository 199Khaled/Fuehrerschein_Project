namespace Führerschein
{
    partial class frmAddUpdateBenutzer
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
            this.lblTile = new System.Windows.Forms.Label();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tcBenutzerInfo = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonKarteMitFilter1 = new Führerschein.ctrlPersonKarteMitFilter();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBenutzerID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtBenutzerName = new System.Windows.Forms.TextBox();
            this.txtPasswordBestätigen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBenutzerPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcBenutzerInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTile.Location = new System.Drawing.Point(224, 34);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(359, 31);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Neue Benutzer hinzufügen";
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(12, 598);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(121, 40);
            this.btnBeenden.TabIndex = 2;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Enabled = false;
            this.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Image = global::Führerschein.Properties.Resources.Save_32;
            this.btnSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeichern.Location = new System.Drawing.Point(150, 598);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(127, 40);
            this.btnSpeichern.TabIndex = 3;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Führerschein.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(666, 431);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(169, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "zum Anmelden";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tcBenutzerInfo
            // 
            this.tcBenutzerInfo.Controls.Add(this.tbPersonInfo);
            this.tcBenutzerInfo.Controls.Add(this.tpLoginInfo);
            this.tcBenutzerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBenutzerInfo.Location = new System.Drawing.Point(-1, 82);
            this.tcBenutzerInfo.Name = "tcBenutzerInfo";
            this.tcBenutzerInfo.SelectedIndex = 0;
            this.tcBenutzerInfo.Size = new System.Drawing.Size(909, 510);
            this.tcBenutzerInfo.TabIndex = 5;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.ctrlPersonKarteMitFilter1);
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(901, 477);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonKarteMitFilter1
            // 
            this.ctrlPersonKarteMitFilter1.FilterEnabled = true;
            this.ctrlPersonKarteMitFilter1.Location = new System.Drawing.Point(12, 21);
            this.ctrlPersonKarteMitFilter1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ctrlPersonKarteMitFilter1.Name = "ctrlPersonKarteMitFilter1";
            this.ctrlPersonKarteMitFilter1.ShowAddPerson = true;
            this.ctrlPersonKarteMitFilter1.Size = new System.Drawing.Size(867, 403);
            this.ctrlPersonKarteMitFilter1.TabIndex = 0;
            this.ctrlPersonKarteMitFilter1.Load += new System.EventHandler(this.ctrlPersonKarteMitFilter1_Load);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.pictureBox2);
            this.tpLoginInfo.Controls.Add(this.lblBenutzerID);
            this.tpLoginInfo.Controls.Add(this.label6);
            this.tpLoginInfo.Controls.Add(this.chkIsActive);
            this.tpLoginInfo.Controls.Add(this.txtBenutzerName);
            this.tpLoginInfo.Controls.Add(this.txtPasswordBestätigen);
            this.tpLoginInfo.Controls.Add(this.label7);
            this.tpLoginInfo.Controls.Add(this.label8);
            this.tpLoginInfo.Controls.Add(this.label9);
            this.tpLoginInfo.Controls.Add(this.txtBenutzerPassword);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.pictureBox8);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(901, 477);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "LoginInfo";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(195, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // lblBenutzerID
            // 
            this.lblBenutzerID.AutoSize = true;
            this.lblBenutzerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerID.Location = new System.Drawing.Point(235, 88);
            this.lblBenutzerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenutzerID.Name = "lblBenutzerID";
            this.lblBenutzerID.Size = new System.Drawing.Size(39, 20);
            this.lblBenutzerID.TabIndex = 142;
            this.lblBenutzerID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 141;
            this.label6.Text = "UserID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(233, 244);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 140;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtBenutzerName
            // 
            this.txtBenutzerName.Location = new System.Drawing.Point(233, 126);
            this.txtBenutzerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBenutzerName.MaxLength = 50;
            this.txtBenutzerName.Name = "txtBenutzerName";
            this.txtBenutzerName.Size = new System.Drawing.Size(167, 26);
            this.txtBenutzerName.TabIndex = 131;
            this.txtBenutzerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBenutzerName_Validating_1);
            // 
            // txtPasswordBestätigen
            // 
            this.txtPasswordBestätigen.Location = new System.Drawing.Point(233, 198);
            this.txtPasswordBestätigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordBestätigen.MaxLength = 50;
            this.txtPasswordBestätigen.Name = "txtPasswordBestätigen";
            this.txtPasswordBestätigen.PasswordChar = '*';
            this.txtPasswordBestätigen.Size = new System.Drawing.Size(167, 26);
            this.txtPasswordBestätigen.TabIndex = 137;
            this.txtPasswordBestätigen.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordBestätigen_Validating_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 133;
            this.label7.Text = "UserName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 138;
            this.label8.Text = "Confirm Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 134;
            this.label9.Text = "Password:";
            // 
            // txtBenutzerPassword
            // 
            this.txtBenutzerPassword.Location = new System.Drawing.Point(233, 162);
            this.txtBenutzerPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBenutzerPassword.MaxLength = 50;
            this.txtBenutzerPassword.Name = "txtBenutzerPassword";
            this.txtBenutzerPassword.PasswordChar = '*';
            this.txtBenutzerPassword.Size = new System.Drawing.Size(167, 26);
            this.txtBenutzerPassword.TabIndex = 132;
            this.txtBenutzerPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBenutzerPassword_Validating_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(195, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Führerschein.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(195, 124);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 136;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(195, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateBenutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.tcBenutzerInfo);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblTile);
            this.Name = "frmAddUpdateBenutzer";
            this.Text = "frmAddUpdateBenutzer";
            this.Load += new System.EventHandler(this.frmAddUpdateBenutzer_Load);
            this.tcBenutzerInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonKarteMitFilter ctrlPersonKarteMitFilter1;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tcBenutzerInfo;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBenutzerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtBenutzerName;
        private System.Windows.Forms.TextBox txtPasswordBestätigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBenutzerPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}