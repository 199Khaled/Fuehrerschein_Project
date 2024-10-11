namespace Führerschein
{
    partial class frmTestFestlegen
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
            this.ctrTestFestlegen1 = new Führerschein.ctrTestFestlegen();
            this.SuspendLayout();
            // 
            // ctrTestFestlegen1
            // 
            this.ctrTestFestlegen1.Location = new System.Drawing.Point(15, 25);
            this.ctrTestFestlegen1.Name = "ctrTestFestlegen1";
            this.ctrTestFestlegen1.Size = new System.Drawing.Size(680, 647);
            this.ctrTestFestlegen1.TabIndex = 0;
            this.ctrTestFestlegen1.TestTypeID = MenschenDataForm.clsTestTypen.enTestType.SehTest;
            // 
            // frmTestFestlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 674);
            this.Controls.Add(this.ctrTestFestlegen1);
            this.Name = "frmTestFestlegen";
            this.Text = "frmTestFestlegen";
            this.Load += new System.EventHandler(this.frmTestFestlegen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrTestFestlegen ctrTestFestlegen1;
    }
}