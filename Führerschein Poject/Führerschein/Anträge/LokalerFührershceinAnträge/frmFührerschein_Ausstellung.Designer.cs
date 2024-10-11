namespace Führerschein
{
    partial class frmFührerschein_Ausstellung
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
            this.lable = new System.Windows.Forms.Label();
            this.txtNotizen = new System.Windows.Forms.TextBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnFührerscheinAusstellung = new System.Windows.Forms.Button();
            this.ctrFührerscheinAntragsInfo1 = new Führerschein.ctrFührerscheinAntragsInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Führerschein.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(71, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(3, 454);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(61, 20);
            this.lable.TabIndex = 179;
            this.lable.Text = "Notes:";
            // 
            // txtNotizen
            // 
            this.txtNotizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotizen.Location = new System.Drawing.Point(118, 454);
            this.txtNotizen.MaxLength = 500;
            this.txtNotizen.Multiline = true;
            this.txtNotizen.Name = "txtNotizen";
            this.txtNotizen.Size = new System.Drawing.Size(831, 127);
            this.txtNotizen.TabIndex = 176;
            // 
            // btnBeenden
            // 
            this.btnBeenden.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(118, 589);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(125, 37);
            this.btnBeenden.TabIndex = 178;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnFührerscheinAusstellung
            // 
            this.btnFührerscheinAusstellung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFührerscheinAusstellung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFührerscheinAusstellung.Image = global::Führerschein.Properties.Resources.License_View_32;
            this.btnFührerscheinAusstellung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFührerscheinAusstellung.Location = new System.Drawing.Point(261, 589);
            this.btnFührerscheinAusstellung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFührerscheinAusstellung.Name = "btnFührerscheinAusstellung";
            this.btnFührerscheinAusstellung.Size = new System.Drawing.Size(126, 37);
            this.btnFührerscheinAusstellung.TabIndex = 177;
            this.btnFührerscheinAusstellung.Text = "Ausstellen";
            this.btnFührerscheinAusstellung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFührerscheinAusstellung.UseVisualStyleBackColor = true;
            this.btnFührerscheinAusstellung.Click += new System.EventHandler(this.btnFührerscheinAusstellung_Click);
            // 
            // ctrFührerscheinAntragsInfo1
            // 
            this.ctrFührerscheinAntragsInfo1.Location = new System.Drawing.Point(9, 6);
            this.ctrFührerscheinAntragsInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrFührerscheinAntragsInfo1.Name = "ctrFührerscheinAntragsInfo1";
            this.ctrFührerscheinAntragsInfo1.Size = new System.Drawing.Size(940, 441);
            this.ctrFührerscheinAntragsInfo1.TabIndex = 181;
            // 
            // frmFührerschein_Ausstellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 635);
            this.Controls.Add(this.ctrFührerscheinAntragsInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.txtNotizen);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnFührerscheinAusstellung);
            this.Name = "frmFührerschein_Ausstellung";
            this.Text = "Führerschein zum ersten Mal Ausstellen";
            this.Load += new System.EventHandler(this.frmFührerschein_Ausstellung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox txtNotizen;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnFührerscheinAusstellung;
        private ctrFührerscheinAntragsInfo ctrFührerscheinAntragsInfo1;
    }
}