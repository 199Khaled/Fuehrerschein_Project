namespace Führerschein
{
    partial class frmBenutzerInfo
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
            this.ctrlBenutzerKarte1 = new Führerschein.ctrlBenutzerKarte();
            this.SuspendLayout();
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(12, 459);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(166, 47);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // ctrlBenutzerKarte1
            // 
            this.ctrlBenutzerKarte1.Location = new System.Drawing.Point(12, 12);
            this.ctrlBenutzerKarte1.Name = "ctrlBenutzerKarte1";
            this.ctrlBenutzerKarte1.Size = new System.Drawing.Size(885, 441);
            this.ctrlBenutzerKarte1.TabIndex = 0;
            // 
            // frmBenutzerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 512);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.ctrlBenutzerKarte1);
            this.Name = "frmBenutzerInfo";
            this.Text = "frmBenutzerInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBenutzerKarte ctrlBenutzerKarte1;
        private System.Windows.Forms.Button btnBeenden;
    }
}