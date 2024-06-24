
namespace VarsityCafeProject_Group28
{
    partial class MaintainSuppliers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addSuppliers = new System.Windows.Forms.TabPage();
            this.deleteSuppliers = new System.Windows.Forms.TabPage();
            this.updateSuppliers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addSuppliers);
            this.tabControl1.Controls.Add(this.deleteSuppliers);
            this.tabControl1.Controls.Add(this.updateSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 791);
            this.tabControl1.TabIndex = 0;
            // 
            // addSuppliers
            // 
            this.addSuppliers.Location = new System.Drawing.Point(4, 29);
            this.addSuppliers.Name = "addSuppliers";
            this.addSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.addSuppliers.Size = new System.Drawing.Size(1219, 758);
            this.addSuppliers.TabIndex = 0;
            this.addSuppliers.Text = "Add Suppliers";
            this.addSuppliers.UseVisualStyleBackColor = true;
            // 
            // deleteSuppliers
            // 
            this.deleteSuppliers.Location = new System.Drawing.Point(4, 29);
            this.deleteSuppliers.Name = "deleteSuppliers";
            this.deleteSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.deleteSuppliers.Size = new System.Drawing.Size(1219, 758);
            this.deleteSuppliers.TabIndex = 1;
            this.deleteSuppliers.Text = "Delete Suppliers";
            this.deleteSuppliers.UseVisualStyleBackColor = true;
            // 
            // updateSuppliers
            // 
            this.updateSuppliers.Location = new System.Drawing.Point(4, 29);
            this.updateSuppliers.Name = "updateSuppliers";
            this.updateSuppliers.Size = new System.Drawing.Size(1219, 758);
            this.updateSuppliers.TabIndex = 2;
            this.updateSuppliers.Text = "Update Suppliers";
            this.updateSuppliers.UseVisualStyleBackColor = true;
            // 
            // MaintainSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 786);
            this.Controls.Add(this.tabControl1);
            this.Name = "MaintainSuppliers";
            this.Text = "MaintainSuppliers";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addSuppliers;
        private System.Windows.Forms.TabPage deleteSuppliers;
        private System.Windows.Forms.TabPage updateSuppliers;
    }
}