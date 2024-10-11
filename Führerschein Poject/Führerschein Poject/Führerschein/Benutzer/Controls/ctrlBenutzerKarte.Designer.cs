namespace Führerschein
{
    partial class ctrlBenutzerKarte
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
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblIsAktive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBenutzerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBenutzerID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctrlPersonKarte1 = new Führerschein.ctrlPersonKarte();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Controls.Add(this.lblIsAktive);
            this.gbLoginInfo.Controls.Add(this.label3);
            this.gbLoginInfo.Controls.Add(this.lblBenutzerName);
            this.gbLoginInfo.Controls.Add(this.label2);
            this.gbLoginInfo.Controls.Add(this.lblBenutzerID);
            this.gbLoginInfo.Controls.Add(this.label1);
            this.gbLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginInfo.Location = new System.Drawing.Point(19, 327);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(840, 100);
            this.gbLoginInfo.TabIndex = 1;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "LoginInfo";
            // 
            // lblIsAktive
            // 
            this.lblIsAktive.AutoSize = true;
            this.lblIsAktive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAktive.Location = new System.Drawing.Point(739, 49);
            this.lblIsAktive.Name = "lblIsAktive";
            this.lblIsAktive.Size = new System.Drawing.Size(29, 20);
            this.lblIsAktive.TabIndex = 5;
            this.lblIsAktive.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IsAktive:";
            // 
            // lblBenutzerName
            // 
            this.lblBenutzerName.AutoSize = true;
            this.lblBenutzerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerName.Location = new System.Drawing.Point(397, 49);
            this.lblBenutzerName.Name = "lblBenutzerName";
            this.lblBenutzerName.Size = new System.Drawing.Size(59, 20);
            this.lblBenutzerName.TabIndex = 3;
            this.lblBenutzerName.Text = "?????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benutzer Name:";
            // 
            // lblBenutzerID
            // 
            this.lblBenutzerID.AutoSize = true;
            this.lblBenutzerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerID.Location = new System.Drawing.Point(135, 49);
            this.lblBenutzerID.Name = "lblBenutzerID";
            this.lblBenutzerID.Size = new System.Drawing.Size(29, 20);
            this.lblBenutzerID.TabIndex = 1;
            this.lblBenutzerID.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzer ID:";
            // 
            // ctrlPersonKarte1
            // 
            this.ctrlPersonKarte1.IsPersonFound = false;
            this.ctrlPersonKarte1.Location = new System.Drawing.Point(19, 12);
            this.ctrlPersonKarte1.Name = "ctrlPersonKarte1";
            this.ctrlPersonKarte1.Size = new System.Drawing.Size(853, 309);
            this.ctrlPersonKarte1.TabIndex = 0;
            // 
            // ctrlBenutzerKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ctrlPersonKarte1);
            this.Name = "ctrlBenutzerKarte";
            this.Size = new System.Drawing.Size(885, 441);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonKarte ctrlPersonKarte1;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblIsAktive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBenutzerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBenutzerID;
    }
}
