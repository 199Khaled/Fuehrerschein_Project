namespace Führerschein
{
    partial class frmFahrerInternationalLicenseInfoAnzeigen
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
            this.btnBeenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrFahrerInternationalLicenseInfo1 = new Führerschein.ctrFahrerInternationalLicenseInfo();
            this.SuspendLayout();
            // 
            // btnBeenden
            // 
            this.btnBeenden.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(12, 307);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(132, 42);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeenden.UseVisualStyleBackColor = false;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "International License Info";
            // 
            // ctrFahrerInternationalLicenseInfo1
            // 
            this.ctrFahrerInternationalLicenseInfo1.Location = new System.Drawing.Point(2, 62);
            this.ctrFahrerInternationalLicenseInfo1.Name = "ctrFahrerInternationalLicenseInfo1";
            this.ctrFahrerInternationalLicenseInfo1.Size = new System.Drawing.Size(986, 239);
            this.ctrFahrerInternationalLicenseInfo1.TabIndex = 0;
            // 
            // frmFahrerInternationalLicenseInfoAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.ctrFahrerInternationalLicenseInfo1);
            this.Name = "frmFahrerInternationalLicenseInfoAnzeigen";
            this.Text = "frmFahrerInternationalLicenseInfoAnzeigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrFahrerInternationalLicenseInfo ctrFahrerInternationalLicenseInfo1;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Label label1;
    }
}