namespace Führerschein
{
    partial class frmFahrerLicenseHistoie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrFahrerLicenseHistorie1 = new Führerschein.ctrFahrerLicenseHistorie();
            this.ctrlPersonKarteMitFilter1 = new Führerschein.ctrlPersonKarteMitFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Führerschein Historie";
            // 
            // ctrFahrerLicenseHistorie1
            // 
            this.ctrFahrerLicenseHistorie1.Location = new System.Drawing.Point(3, 384);
            this.ctrFahrerLicenseHistorie1.Name = "ctrFahrerLicenseHistorie1";
            this.ctrFahrerLicenseHistorie1.Size = new System.Drawing.Size(1039, 337);
            this.ctrFahrerLicenseHistorie1.TabIndex = 5;
            // 
            // ctrlPersonKarteMitFilter1
            // 
            this.ctrlPersonKarteMitFilter1.FilterEnabled = true;
            this.ctrlPersonKarteMitFilter1.Location = new System.Drawing.Point(207, 3);
            this.ctrlPersonKarteMitFilter1.Name = "ctrlPersonKarteMitFilter1";
            this.ctrlPersonKarteMitFilter1.ShowAddPerson = true;
            this.ctrlPersonKarteMitFilter1.Size = new System.Drawing.Size(843, 375);
            this.ctrlPersonKarteMitFilter1.TabIndex = 1;
            this.ctrlPersonKarteMitFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonKarteMitFilter1_OnPersonSelected);
            this.ctrlPersonKarteMitFilter1.Load += new System.EventHandler(this.ctrlPersonKarteMitFilter1_Load);
            // 
            // frmFahrerLicenseHistoie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 719);
            this.Controls.Add(this.ctrFahrerLicenseHistorie1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlPersonKarteMitFilter1);
            this.Name = "frmFahrerLicenseHistoie";
            this.Text = "frmFahrerLicenseHistorie";
            this.Load += new System.EventHandler(this.frmFahrerLicenseHistoie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonKarteMitFilter ctrlPersonKarteMitFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ctrFahrerLicenseHistorie ctrFahrerLicenseHistorie1;
    }
}