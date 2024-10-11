namespace Führerschein
{
    partial class frmFührerscheinBeschlagnahme
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
            this.btnBeenden = new System.Windows.Forms.Button();
            this.llLicenseInfoAnzeigen = new System.Windows.Forms.LinkLabel();
            this.btnBeschlagnahme = new System.Windows.Forms.Button();
            this.llLicenseHistorieAnzeigen = new System.Windows.Forms.LinkLabel();
            this.gpBeschlagnahme = new System.Windows.Forms.GroupBox();
            this.txtStrafgebühren = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErstelltBeiBenutzer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBeschlagnahmeDatum = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBeschlagnahmeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrFahrerLicenseInfoMitFilter1 = new Führerschein.ctrFahrerLicenseInfoMitFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBeschlagnahme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeenden
            // 
            this.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(884, 553);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(173, 37);
            this.btnBeenden.TabIndex = 186;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // llLicenseInfoAnzeigen
            // 
            this.llLicenseInfoAnzeigen.AutoSize = true;
            this.llLicenseInfoAnzeigen.Enabled = false;
            this.llLicenseInfoAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseInfoAnzeigen.Location = new System.Drawing.Point(892, 625);
            this.llLicenseInfoAnzeigen.Name = "llLicenseInfoAnzeigen";
            this.llLicenseInfoAnzeigen.Size = new System.Drawing.Size(165, 20);
            this.llLicenseInfoAnzeigen.TabIndex = 189;
            this.llLicenseInfoAnzeigen.TabStop = true;
            this.llLicenseInfoAnzeigen.Text = "License Info anzeigen";
            this.llLicenseInfoAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseInfoAnzeigen_LinkClicked);
            // 
            // btnBeschlagnahme
            // 
            this.btnBeschlagnahme.Enabled = false;
            this.btnBeschlagnahme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeschlagnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeschlagnahme.Image = global::Führerschein.Properties.Resources.International_32;
            this.btnBeschlagnahme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeschlagnahme.Location = new System.Drawing.Point(882, 503);
            this.btnBeschlagnahme.Name = "btnBeschlagnahme";
            this.btnBeschlagnahme.Size = new System.Drawing.Size(173, 37);
            this.btnBeschlagnahme.TabIndex = 187;
            this.btnBeschlagnahme.Text = "Beschlagnahmen";
            this.btnBeschlagnahme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeschlagnahme.UseVisualStyleBackColor = true;
            this.btnBeschlagnahme.Click += new System.EventHandler(this.btnBeschlagnahme_Click);
            // 
            // llLicenseHistorieAnzeigen
            // 
            this.llLicenseHistorieAnzeigen.AutoSize = true;
            this.llLicenseHistorieAnzeigen.Enabled = false;
            this.llLicenseHistorieAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseHistorieAnzeigen.Location = new System.Drawing.Point(878, 596);
            this.llLicenseHistorieAnzeigen.Name = "llLicenseHistorieAnzeigen";
            this.llLicenseHistorieAnzeigen.Size = new System.Drawing.Size(191, 20);
            this.llLicenseHistorieAnzeigen.TabIndex = 188;
            this.llLicenseHistorieAnzeigen.TabStop = true;
            this.llLicenseHistorieAnzeigen.Text = "License Historie anzeigen";
            this.llLicenseHistorieAnzeigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // gpBeschlagnahme
            // 
            this.gpBeschlagnahme.Controls.Add(this.txtStrafgebühren);
            this.gpBeschlagnahme.Controls.Add(this.pictureBox8);
            this.gpBeschlagnahme.Controls.Add(this.lblLicenseID);
            this.gpBeschlagnahme.Controls.Add(this.label10);
            this.gpBeschlagnahme.Controls.Add(this.pictureBox2);
            this.gpBeschlagnahme.Controls.Add(this.pictureBox1);
            this.gpBeschlagnahme.Controls.Add(this.label1);
            this.gpBeschlagnahme.Controls.Add(this.lblErstelltBeiBenutzer);
            this.gpBeschlagnahme.Controls.Add(this.label2);
            this.gpBeschlagnahme.Controls.Add(this.pictureBox3);
            this.gpBeschlagnahme.Controls.Add(this.lblBeschlagnahmeDatum);
            this.gpBeschlagnahme.Controls.Add(this.pictureBox4);
            this.gpBeschlagnahme.Controls.Add(this.label5);
            this.gpBeschlagnahme.Controls.Add(this.lblBeschlagnahmeID);
            this.gpBeschlagnahme.Controls.Add(this.label4);
            this.gpBeschlagnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBeschlagnahme.Location = new System.Drawing.Point(12, 503);
            this.gpBeschlagnahme.Name = "gpBeschlagnahme";
            this.gpBeschlagnahme.Size = new System.Drawing.Size(865, 141);
            this.gpBeschlagnahme.TabIndex = 185;
            this.gpBeschlagnahme.TabStop = false;
            this.gpBeschlagnahme.Text = "Beschlagnahme Info";
            // 
            // txtStrafgebühren
            // 
            this.txtStrafgebühren.Location = new System.Drawing.Point(252, 104);
            this.txtStrafgebühren.Name = "txtStrafgebühren";
            this.txtStrafgebühren.Size = new System.Drawing.Size(102, 26);
            this.txtStrafgebühren.TabIndex = 196;
            this.txtStrafgebühren.Validating += new System.ComponentModel.CancelEventHandler(this.txtStrafgebühren_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(581, 40);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 195;
            this.pictureBox8.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(619, 40);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(49, 20);
            this.lblLicenseID.TabIndex = 191;
            this.lblLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 190;
            this.label10.Text = "License ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(210, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Man_32;
            this.pictureBox1.Location = new System.Drawing.Point(581, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 181;
            this.label1.Text = "Erstellt bei:";
            // 
            // lblErstelltBeiBenutzer
            // 
            this.lblErstelltBeiBenutzer.AutoSize = true;
            this.lblErstelltBeiBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErstelltBeiBenutzer.Location = new System.Drawing.Point(619, 72);
            this.lblErstelltBeiBenutzer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErstelltBeiBenutzer.Name = "lblErstelltBeiBenutzer";
            this.lblErstelltBeiBenutzer.Size = new System.Drawing.Size(59, 20);
            this.lblErstelltBeiBenutzer.TabIndex = 180;
            this.lblErstelltBeiBenutzer.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 177;
            this.label2.Text = "Strafgebühren:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Führerschein.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(210, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 178;
            this.pictureBox3.TabStop = false;
            // 
            // lblBeschlagnahmeDatum
            // 
            this.lblBeschlagnahmeDatum.AutoSize = true;
            this.lblBeschlagnahmeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschlagnahmeDatum.Location = new System.Drawing.Point(248, 72);
            this.lblBeschlagnahmeDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeschlagnahmeDatum.Name = "lblBeschlagnahmeDatum";
            this.lblBeschlagnahmeDatum.Size = new System.Drawing.Size(109, 20);
            this.lblBeschlagnahmeDatum.TabIndex = 176;
            this.lblBeschlagnahmeDatum.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Führerschein.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(210, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 175;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 174;
            this.label5.Text = "Beschlagnahme Datum:";
            // 
            // lblBeschlagnahmeID
            // 
            this.lblBeschlagnahmeID.AutoSize = true;
            this.lblBeschlagnahmeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschlagnahmeID.Location = new System.Drawing.Point(248, 40);
            this.lblBeschlagnahmeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeschlagnahmeID.Name = "lblBeschlagnahmeID";
            this.lblBeschlagnahmeID.Size = new System.Drawing.Size(49, 20);
            this.lblBeschlagnahmeID.TabIndex = 173;
            this.lblBeschlagnahmeID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 172;
            this.label4.Text = "Beschlagnahme ID:";
            // 
            // ctrFahrerLicenseInfoMitFilter1
            // 
            this.ctrFahrerLicenseInfoMitFilter1.FilterEnabled = true;
            this.ctrFahrerLicenseInfoMitFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctrFahrerLicenseInfoMitFilter1.Name = "ctrFahrerLicenseInfoMitFilter1";
            this.ctrFahrerLicenseInfoMitFilter1.Size = new System.Drawing.Size(993, 467);
            this.ctrFahrerLicenseInfoMitFilter1.TabIndex = 0;
            this.ctrFahrerLicenseInfoMitFilter1.OnLicenseSelected += new System.Action<int>(this.ctrFahrerLicenseInfoMitFilter1_OnLicenseSelected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFührerscheinBeschlagnahme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 664);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.llLicenseInfoAnzeigen);
            this.Controls.Add(this.btnBeschlagnahme);
            this.Controls.Add(this.llLicenseHistorieAnzeigen);
            this.Controls.Add(this.gpBeschlagnahme);
            this.Controls.Add(this.ctrFahrerLicenseInfoMitFilter1);
            this.Name = "frmFührerscheinBeschlagnahme";
            this.Text = "frmFührerscheinBeschlagnahme";
            this.Load += new System.EventHandler(this.frmFührerscheinBeschlagnahme_Load);
            this.gpBeschlagnahme.ResumeLayout(false);
            this.gpBeschlagnahme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrFahrerLicenseInfoMitFilter ctrFahrerLicenseInfoMitFilter1;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.LinkLabel llLicenseInfoAnzeigen;
        private System.Windows.Forms.Button btnBeschlagnahme;
        private System.Windows.Forms.LinkLabel llLicenseHistorieAnzeigen;
        private System.Windows.Forms.GroupBox gpBeschlagnahme;
        private System.Windows.Forms.TextBox txtStrafgebühren;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErstelltBeiBenutzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBeschlagnahmeDatum;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBeschlagnahmeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}