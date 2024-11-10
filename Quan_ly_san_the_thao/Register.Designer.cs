namespace Quan_ly_san_the_thao
{
    partial class Register
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
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_fullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(104, 55);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(101, 16);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên đăng nhập:";
            // 
            // lb_fullName
            // 
            this.lb_fullName.AutoSize = true;
            this.lb_fullName.Location = new System.Drawing.Point(104, 91);
            this.lb_fullName.Name = "lb_fullName";
            this.lb_fullName.Size = new System.Drawing.Size(49, 16);
            this.lb_fullName.TabIndex = 1;
            this.lb_fullName.Text = "Họ tên:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_fullName);
            this.Controls.Add(this.lb_username);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_fullName;
    }
}