namespace Führerschein
{
    partial class ctrFahrerLicenseInfoMitFilter
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFahrerLicenseFilter = new System.Windows.Forms.GroupBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.txtbFilterWert = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrFahrerLicenseInfo1 = new Führerschein.ctrFahrerLicenseInfo();
            this.gbFahrerLicenseFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbFahrerLicenseFilter
            // 
            this.gbFahrerLicenseFilter.BackColor = System.Drawing.SystemColors.Info;
            this.gbFahrerLicenseFilter.Controls.Add(this.btnSuchen);
            this.gbFahrerLicenseFilter.Controls.Add(this.txtbFilterWert);
            this.gbFahrerLicenseFilter.Controls.Add(this.label1);
            this.gbFahrerLicenseFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFahrerLicenseFilter.Location = new System.Drawing.Point(20, 12);
            this.gbFahrerLicenseFilter.Name = "gbFahrerLicenseFilter";
            this.gbFahrerLicenseFilter.Size = new System.Drawing.Size(540, 79);
            this.gbFahrerLicenseFilter.TabIndex = 1;
            this.gbFahrerLicenseFilter.TabStop = false;
            this.gbFahrerLicenseFilter.Text = "Filter";
            // 
            // btnSuchen
            // 
            this.btnSuchen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuchen.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.btnSuchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuchen.Location = new System.Drawing.Point(399, 25);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(109, 37);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // txtbFilterWert
            // 
            this.txtbFilterWert.Location = new System.Drawing.Point(112, 30);
            this.txtbFilterWert.Name = "txtbFilterWert";
            this.txtbFilterWert.Size = new System.Drawing.Size(256, 26);
            this.txtbFilterWert.TabIndex = 1;
            this.txtbFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterWert_KeyPress);
            this.txtbFilterWert.Validating += new System.ComponentModel.CancelEventHandler(this.txtbFilterWert_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ctrFahrerLicenseInfo1
            // 
            this.ctrFahrerLicenseInfo1.Location = new System.Drawing.Point(3, 97);
            this.ctrFahrerLicenseInfo1.Name = "ctrFahrerLicenseInfo1";
            this.ctrFahrerLicenseInfo1.Size = new System.Drawing.Size(974, 353);
            this.ctrFahrerLicenseInfo1.TabIndex = 3;
            // 
            // ctrFahrerLicenseInfoMitFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrFahrerLicenseInfo1);
            this.Controls.Add(this.gbFahrerLicenseFilter);
            this.Name = "ctrFahrerLicenseInfoMitFilter";
            this.Size = new System.Drawing.Size(993, 463);
            this.Load += new System.EventHandler(this.ctrFahrerLicenseInfoMitFilter_Load);
            this.gbFahrerLicenseFilter.ResumeLayout(false);
            this.gbFahrerLicenseFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFahrerLicenseFilter;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.TextBox txtbFilterWert;
        private ctrFahrerLicenseInfo ctrFahrerLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
