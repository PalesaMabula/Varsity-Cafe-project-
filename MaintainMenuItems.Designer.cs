
namespace VarsityCafeProject_Group28
{
    partial class MaintainMenuItems
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
            this.addMenuItems = new System.Windows.Forms.TabPage();
            this.deleteMenuItems = new System.Windows.Forms.TabPage();
            this.updateMenuItems = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addMenuItems);
            this.tabControl1.Controls.Add(this.deleteMenuItems);
            this.tabControl1.Controls.Add(this.updateMenuItems);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1304, 783);
            this.tabControl1.TabIndex = 0;
            // 
            // addMenuItems
            // 
            this.addMenuItems.Location = new System.Drawing.Point(4, 29);
            this.addMenuItems.Name = "addMenuItems";
            this.addMenuItems.Padding = new System.Windows.Forms.Padding(3);
            this.addMenuItems.Size = new System.Drawing.Size(1296, 750);
            this.addMenuItems.TabIndex = 0;
            this.addMenuItems.Text = "Add MenuItems";
            this.addMenuItems.UseVisualStyleBackColor = true;
            // 
            // deleteMenuItems
            // 
            this.deleteMenuItems.Location = new System.Drawing.Point(4, 29);
            this.deleteMenuItems.Name = "deleteMenuItems";
            this.deleteMenuItems.Padding = new System.Windows.Forms.Padding(3);
            this.deleteMenuItems.Size = new System.Drawing.Size(1296, 750);
            this.deleteMenuItems.TabIndex = 1;
            this.deleteMenuItems.Text = "Delete MenuItems";
            this.deleteMenuItems.UseVisualStyleBackColor = true;
            // 
            // updateMenuItems
            // 
            this.updateMenuItems.Location = new System.Drawing.Point(4, 29);
            this.updateMenuItems.Name = "updateMenuItems";
            this.updateMenuItems.Size = new System.Drawing.Size(1296, 750);
            this.updateMenuItems.TabIndex = 2;
            this.updateMenuItems.Text = "Update MenuItems";
            this.updateMenuItems.UseVisualStyleBackColor = true;
            // 
            // MaintainMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 784);
            this.Controls.Add(this.tabControl1);
            this.Name = "MaintainMenuItems";
            this.Text = "MaintainMenuItems";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addMenuItems;
        private System.Windows.Forms.TabPage deleteMenuItems;
        private System.Windows.Forms.TabPage updateMenuItems;
    }
}