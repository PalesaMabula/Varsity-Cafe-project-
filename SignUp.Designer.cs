
namespace VarsityCafeProject_Group28
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NametxtBx = new System.Windows.Forms.TextBox();
            this.SurnametxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernametxtBx = new System.Windows.Forms.TextBox();
            this.LAB = new System.Windows.Forms.Label();
            this.EmailtxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordtxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.passworderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passworderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NametxtBx
            // 
            this.NametxtBx.Location = new System.Drawing.Point(336, 127);
            this.NametxtBx.Name = "NametxtBx";
            this.NametxtBx.Size = new System.Drawing.Size(142, 26);
            this.NametxtBx.TabIndex = 1;
            // 
            // SurnametxtBx
            // 
            this.SurnametxtBx.Location = new System.Drawing.Point(336, 213);
            this.SurnametxtBx.Name = "SurnametxtBx";
            this.SurnametxtBx.Size = new System.Drawing.Size(142, 26);
            this.SurnametxtBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // UsernametxtBx
            // 
            this.UsernametxtBx.Location = new System.Drawing.Point(336, 302);
            this.UsernametxtBx.Name = "UsernametxtBx";
            this.UsernametxtBx.Size = new System.Drawing.Size(142, 26);
            this.UsernametxtBx.TabIndex = 5;
            // 
            // LAB
            // 
            this.LAB.AutoSize = true;
            this.LAB.Location = new System.Drawing.Point(192, 308);
            this.LAB.Name = "LAB";
            this.LAB.Size = new System.Drawing.Size(87, 20);
            this.LAB.TabIndex = 4;
            this.LAB.Text = "Username:";
            // 
            // EmailtxtBx
            // 
            this.EmailtxtBx.Location = new System.Drawing.Point(336, 404);
            this.EmailtxtBx.Name = "EmailtxtBx";
            this.EmailtxtBx.Size = new System.Drawing.Size(142, 26);
            this.EmailtxtBx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // PasswordtxtBx
            // 
            this.PasswordtxtBx.Location = new System.Drawing.Point(336, 512);
            this.PasswordtxtBx.Name = "PasswordtxtBx";
            this.PasswordtxtBx.Size = new System.Drawing.Size(142, 26);
            this.PasswordtxtBx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Location = new System.Drawing.Point(235, 630);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(176, 66);
            this.SignUpbtn.TabIndex = 10;
            this.SignUpbtn.Text = "SignUp";
            this.SignUpbtn.UseVisualStyleBackColor = true;
            // 
            // passworderrorProvider
            // 
            this.passworderrorProvider.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 793);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.PasswordtxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailtxtBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsernametxtBx);
            this.Controls.Add(this.LAB);
            this.Controls.Add(this.SurnametxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametxtBx);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passworderrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NametxtBx;
        private System.Windows.Forms.TextBox SurnametxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernametxtBx;
        private System.Windows.Forms.Label LAB;
        private System.Windows.Forms.TextBox EmailtxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordtxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.ErrorProvider passworderrorProvider;
    }
}