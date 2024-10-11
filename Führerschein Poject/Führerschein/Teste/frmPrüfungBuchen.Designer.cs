namespace Führerschein
{
    partial class frmPrüfungBuchen
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
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtNotizen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErgebnisMessage = new System.Windows.Forms.Label();
            this.rbDurchgefallen = new System.Windows.Forms.RadioButton();
            this.rbBestanden = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrPrüfungDaten1 = new Führerschein.ctrPrüfungDaten();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Image = global::Führerschein.Properties.Resources.Save_32;
            this.btnSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeichern.Location = new System.Drawing.Point(596, 640);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(147, 35);
            this.btnSpeichern.TabIndex = 235;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(298, 640);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(147, 35);
            this.btnBeenden.TabIndex = 234;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Führerschein.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(120, 571);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 233;
            this.pictureBox9.TabStop = false;
            // 
            // txtNotizen
            // 
            this.txtNotizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotizen.Location = new System.Drawing.Point(298, 571);
            this.txtNotizen.Multiline = true;
            this.txtNotizen.Name = "txtNotizen";
            this.txtNotizen.Size = new System.Drawing.Size(445, 63);
            this.txtNotizen.TabIndex = 232;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 231;
            this.label4.Text = "Notizen:";
            // 
            // lblErgebnisMessage
            // 
            this.lblErgebnisMessage.AutoSize = true;
            this.lblErgebnisMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErgebnisMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErgebnisMessage.Location = new System.Drawing.Point(422, 533);
            this.lblErgebnisMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErgebnisMessage.Name = "lblErgebnisMessage";
            this.lblErgebnisMessage.Size = new System.Drawing.Size(69, 20);
            this.lblErgebnisMessage.TabIndex = 230;
            this.lblErgebnisMessage.Text = "??????";
            this.lblErgebnisMessage.Visible = false;
            // 
            // rbDurchgefallen
            // 
            this.rbDurchgefallen.AutoSize = true;
            this.rbDurchgefallen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDurchgefallen.ForeColor = System.Drawing.Color.Maroon;
            this.rbDurchgefallen.Location = new System.Drawing.Point(286, 529);
            this.rbDurchgefallen.Name = "rbDurchgefallen";
            this.rbDurchgefallen.Size = new System.Drawing.Size(117, 24);
            this.rbDurchgefallen.TabIndex = 229;
            this.rbDurchgefallen.Text = "Drchgefallen";
            this.rbDurchgefallen.UseVisualStyleBackColor = true;
            // 
            // rbBestanden
            // 
            this.rbBestanden.AutoSize = true;
            this.rbBestanden.Checked = true;
            this.rbBestanden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBestanden.ForeColor = System.Drawing.Color.Maroon;
            this.rbBestanden.Location = new System.Drawing.Point(175, 529);
            this.rbBestanden.Name = "rbBestanden";
            this.rbBestanden.Size = new System.Drawing.Size(105, 24);
            this.rbBestanden.TabIndex = 228;
            this.rbBestanden.TabStop = true;
            this.rbBestanden.Text = "Bestanden";
            this.rbBestanden.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Führerschein.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(119, 526);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 227;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 226;
            this.label3.Text = "Ergebnis:";
            // 
            // ctrPrüfungDaten1
            // 
            this.ctrPrüfungDaten1.Location = new System.Drawing.Point(152, 0);
            this.ctrPrüfungDaten1.Name = "ctrPrüfungDaten1";
            this.ctrPrüfungDaten1.Size = new System.Drawing.Size(620, 523);
            this.ctrPrüfungDaten1.TabIndex = 236;
            // 
            // frmPrüfungBuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 679);
            this.Controls.Add(this.ctrPrüfungDaten1);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtNotizen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblErgebnisMessage);
            this.Controls.Add(this.rbDurchgefallen);
            this.Controls.Add(this.rbBestanden);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label3);
            this.Name = "frmPrüfungBuchen";
            this.Text = "frmPrüfungBuchen";
            this.Load += new System.EventHandler(this.frmPrüfungBuchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtNotizen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErgebnisMessage;
        private System.Windows.Forms.RadioButton rbDurchgefallen;
        private System.Windows.Forms.RadioButton rbBestanden;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private ctrPrüfungDaten ctrPrüfungDaten1;
    }
}