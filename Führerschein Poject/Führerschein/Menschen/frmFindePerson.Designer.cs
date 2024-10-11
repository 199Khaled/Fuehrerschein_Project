namespace Führerschein
{
    partial class frmFindePerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonKarteMitFilter1 = new Führerschein.ctrlPersonKarteMitFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nach Person Suchen";
            // 
            // ctrlPersonKarteMitFilter1
            // 
            this.ctrlPersonKarteMitFilter1.FilterEnabled = true;
            this.ctrlPersonKarteMitFilter1.Location = new System.Drawing.Point(10, 72);
            this.ctrlPersonKarteMitFilter1.Name = "ctrlPersonKarteMitFilter1";
            this.ctrlPersonKarteMitFilter1.ShowAddPerson = true;
            this.ctrlPersonKarteMitFilter1.Size = new System.Drawing.Size(868, 427);
            this.ctrlPersonKarteMitFilter1.TabIndex = 1;
            this.ctrlPersonKarteMitFilter1.Load += new System.EventHandler(this.ctrlPersonKarteMitFilter1_Load);
            // 
            // frmFindePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 482);
            this.Controls.Add(this.ctrlPersonKarteMitFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmFindePerson";
            this.Text = "frmFindePerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlPersonKarteMitFilter ctrlPersonKarteMitFilter1;
    }
}