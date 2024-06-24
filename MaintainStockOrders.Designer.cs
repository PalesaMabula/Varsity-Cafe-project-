
namespace VarsityCafeProject_Group28
{
    partial class MaintainStockOrders
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
            this.addStockOrders = new System.Windows.Forms.TabPage();
            this.deleteStockOrders = new System.Windows.Forms.TabPage();
            this.updateStockOrders = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addStockOrders);
            this.tabControl1.Controls.Add(this.deleteStockOrders);
            this.tabControl1.Controls.Add(this.updateStockOrders);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 779);
            this.tabControl1.TabIndex = 0;
            // 
            // addStockOrders
            // 
            this.addStockOrders.Location = new System.Drawing.Point(4, 29);
            this.addStockOrders.Name = "addStockOrders";
            this.addStockOrders.Padding = new System.Windows.Forms.Padding(3);
            this.addStockOrders.Size = new System.Drawing.Size(1300, 746);
            this.addStockOrders.TabIndex = 0;
            this.addStockOrders.Text = "Add StockOrders";
            this.addStockOrders.UseVisualStyleBackColor = true;
            // 
            // deleteStockOrders
            // 
            this.deleteStockOrders.Location = new System.Drawing.Point(4, 29);
            this.deleteStockOrders.Name = "deleteStockOrders";
            this.deleteStockOrders.Padding = new System.Windows.Forms.Padding(3);
            this.deleteStockOrders.Size = new System.Drawing.Size(1300, 746);
            this.deleteStockOrders.TabIndex = 1;
            this.deleteStockOrders.Text = "Delete StockOrders";
            this.deleteStockOrders.UseVisualStyleBackColor = true;
            // 
            // updateStockOrders
            // 
            this.updateStockOrders.Location = new System.Drawing.Point(4, 29);
            this.updateStockOrders.Name = "updateStockOrders";
            this.updateStockOrders.Size = new System.Drawing.Size(1300, 746);
            this.updateStockOrders.TabIndex = 2;
            this.updateStockOrders.Text = "Update StockOrders";
            this.updateStockOrders.UseVisualStyleBackColor = true;
            // 
            // MaintainStockOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 784);
            this.Controls.Add(this.tabControl1);
            this.Name = "MaintainStockOrders";
            this.Text = "MaintainStockOrders";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addStockOrders;
        private System.Windows.Forms.TabPage deleteStockOrders;
        private System.Windows.Forms.TabPage updateStockOrders;
    }
}