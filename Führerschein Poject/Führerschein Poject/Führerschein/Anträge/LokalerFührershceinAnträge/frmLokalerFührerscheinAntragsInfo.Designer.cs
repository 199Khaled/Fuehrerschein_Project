namespace Führerschein
{
    partial class frmLokalerFührerscheinAntragsInfo
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
            this.ctrFührerscheinAntragsInfo1 = new Führerschein.ctrFührerscheinAntragsInfo();
            this.SuspendLayout();
            // 
            // btnBeenden
            // 
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Image = global::Führerschein.Properties.Resources.Close_32;
            this.btnBeenden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeenden.Location = new System.Drawing.Point(12, 464);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(111, 41);
            this.btnBeenden.TabIndex = 0;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // ctrFührerscheinAntragsInfo1
            // 
            this.ctrFührerscheinAntragsInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrFührerscheinAntragsInfo1.Name = "ctrFührerscheinAntragsInfo1";
            this.ctrFührerscheinAntragsInfo1.Size = new System.Drawing.Size(1033, 446);
            this.ctrFührerscheinAntragsInfo1.TabIndex = 1;
            this.ctrFührerscheinAntragsInfo1.Load += new System.EventHandler(this.ctrFührerscheinAntragsInfo1_Load_1);
            // 
            // frmLokalerFührerscheinAntragsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.ctrFührerscheinAntragsInfo1);
            this.Controls.Add(this.btnBeenden);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLokalerFührerscheinAntragsInfo";
            this.Text = "frmLokalerFührerscheinAntragsInfo";
            this.Load += new System.EventHandler(this.frmLokalerFührerscheinAntragsInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeenden;
        private ctrFührerscheinAntragsInfo ctrFührerscheinAntragsInfo1;
    }
}