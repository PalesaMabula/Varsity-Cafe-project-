
namespace VarsityCafeProject_Group28
{
    partial class MaintainProducts
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
            this.addProducts = new System.Windows.Forms.TabPage();
            this.deleteProducts = new System.Windows.Forms.TabPage();
            this.updateProducts = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addProducts);
            this.tabControl1.Controls.Add(this.deleteProducts);
            this.tabControl1.Controls.Add(this.updateProducts);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 750);
            this.tabControl1.TabIndex = 0;
            // 
            // addProducts
            // 
            this.addProducts.Location = new System.Drawing.Point(4, 29);
            this.addProducts.Name = "addProducts";
            this.addProducts.Padding = new System.Windows.Forms.Padding(3);
            this.addProducts.Size = new System.Drawing.Size(1276, 717);
            this.addProducts.TabIndex = 0;
            this.addProducts.Text = "Add Products";
            this.addProducts.UseVisualStyleBackColor = true;
            // 
            // deleteProducts
            // 
            this.deleteProducts.Location = new System.Drawing.Point(4, 29);
            this.deleteProducts.Name = "deleteProducts";
            this.deleteProducts.Padding = new System.Windows.Forms.Padding(3);
            this.deleteProducts.Size = new System.Drawing.Size(1275, 717);
            this.deleteProducts.TabIndex = 1;
            this.deleteProducts.Text = "Delete Products";
            this.deleteProducts.UseVisualStyleBackColor = true;
            // 
            // updateProducts
            // 
            this.updateProducts.Location = new System.Drawing.Point(4, 29);
            this.updateProducts.Name = "updateProducts";
            this.updateProducts.Size = new System.Drawing.Size(1275, 717);
            this.updateProducts.TabIndex = 2;
            this.updateProducts.Text = "Update Products";
            this.updateProducts.UseVisualStyleBackColor = true;
            // 
            // MaintainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "MaintainProducts";
            this.Text = "MaintainProducts";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addProducts;
        private System.Windows.Forms.TabPage deleteProducts;
        private System.Windows.Forms.TabPage updateProducts;
    }
}