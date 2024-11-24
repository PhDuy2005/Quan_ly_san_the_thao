namespace Quan_ly_san_the_thao
{
    partial class PasswordConfirmation
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
            this.lb_PasswordConfirmation = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.ckBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.llb_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_PasswordConfirmation
            // 
            this.lb_PasswordConfirmation.AutoSize = true;
            this.lb_PasswordConfirmation.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasswordConfirmation.Location = new System.Drawing.Point(12, 62);
            this.lb_PasswordConfirmation.Name = "lb_PasswordConfirmation";
            this.lb_PasswordConfirmation.Size = new System.Drawing.Size(320, 34);
            this.lb_PasswordConfirmation.TabIndex = 2;
            this.lb_PasswordConfirmation.Text = "Xác nhận mật khẩu";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Password.Location = new System.Drawing.Point(18, 120);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(406, 28);
            this.tb_Password.TabIndex = 4;
            // 
            // ckBox_ShowPassword
            // 
            this.ckBox_ShowPassword.AutoSize = true;
            this.ckBox_ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBox_ShowPassword.Location = new System.Drawing.Point(18, 165);
            this.ckBox_ShowPassword.Name = "ckBox_ShowPassword";
            this.ckBox_ShowPassword.Size = new System.Drawing.Size(125, 22);
            this.ckBox_ShowPassword.TabIndex = 5;
            this.ckBox_ShowPassword.Text = "Hiện mật khẩu";
            this.ckBox_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // llb_ForgotPassword
            // 
            this.llb_ForgotPassword.AutoSize = true;
            this.llb_ForgotPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_ForgotPassword.Location = new System.Drawing.Point(14, 231);
            this.llb_ForgotPassword.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.llb_ForgotPassword.Name = "llb_ForgotPassword";
            this.llb_ForgotPassword.Size = new System.Drawing.Size(151, 20);
            this.llb_ForgotPassword.TabIndex = 7;
            this.llb_ForgotPassword.TabStop = true;
            this.llb_ForgotPassword.Text = "Quên mật khẩu?";
            this.llb_ForgotPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Next.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(339, 220);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(85, 39);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Tiếp";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // PasswordConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.llb_ForgotPassword);
            this.Controls.Add(this.ckBox_ShowPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lb_PasswordConfirmation);
            this.Name = "PasswordConfirmation";
            this.Text = "PasswordConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PasswordConfirmation;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.CheckBox ckBox_ShowPassword;
        private System.Windows.Forms.LinkLabel llb_ForgotPassword;
        private System.Windows.Forms.Button btn_Next;
    }
}