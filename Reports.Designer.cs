
namespace VarsityCafeProject_Group28
{
    partial class Reports
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
            this.ReportTypecmbBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportlstBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReportTypecmbBx
            // 
            this.ReportTypecmbBx.FormattingEnabled = true;
            this.ReportTypecmbBx.Items.AddRange(new object[] {
            "Stock count",
            "Supplier transactions",
            "Customer transactions",
            "Top 5 purchased goods"});
            this.ReportTypecmbBx.Location = new System.Drawing.Point(269, 80);
            this.ReportTypecmbBx.Name = "ReportTypecmbBx";
            this.ReportTypecmbBx.Size = new System.Drawing.Size(189, 28);
            this.ReportTypecmbBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Type:";
            // 
            // ReportlstBx
            // 
            this.ReportlstBx.FormattingEnabled = true;
            this.ReportlstBx.ItemHeight = 20;
            this.ReportlstBx.Location = new System.Drawing.Point(545, 80);
            this.ReportlstBx.Name = "ReportlstBx";
            this.ReportlstBx.Size = new System.Drawing.Size(709, 624);
            this.ReportlstBx.TabIndex = 2;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 794);
            this.Controls.Add(this.ReportlstBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTypecmbBx);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ReportTypecmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ReportlstBx;
    }
}