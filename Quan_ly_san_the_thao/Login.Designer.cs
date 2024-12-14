﻿namespace Quan_ly_san_the_thao
{
    partial class LoginForm
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
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.llb_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lb_SignIn = new System.Windows.Forms.Label();
            this.llb_SignIn = new System.Windows.Forms.LinkLabel();
            this.lb_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(123, 99);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(120, 17);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Tên đăng nhập:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(160, 140);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(78, 17);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(263, 93);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(225, 24);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(263, 133);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(225, 24);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(178, 210);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(243, 40);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // llb_ForgotPassword
            // 
            this.llb_ForgotPassword.AutoSize = true;
            this.llb_ForgotPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_ForgotPassword.Location = new System.Drawing.Point(389, 180);
            this.llb_ForgotPassword.Margin = new System.Windows.Forms.Padding(2, 12, 2, 12);
            this.llb_ForgotPassword.Name = "llb_ForgotPassword";
            this.llb_ForgotPassword.Size = new System.Drawing.Size(111, 14);
            this.llb_ForgotPassword.TabIndex = 6;
            this.llb_ForgotPassword.TabStop = true;
            this.llb_ForgotPassword.Text = "Quên mật khẩu?";
            this.llb_ForgotPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llb_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_ForgotPassword_LinkClicked);
            // 
            // lb_SignIn
            // 
            this.lb_SignIn.AutoSize = true;
            this.lb_SignIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SignIn.Location = new System.Drawing.Point(197, 280);
            this.lb_SignIn.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_SignIn.Name = "lb_SignIn";
            this.lb_SignIn.Size = new System.Drawing.Size(128, 14);
            this.lb_SignIn.TabIndex = 8;
            this.lb_SignIn.Text = "Chưa có tài khoản?";
            // 
            // llb_SignIn
            // 
            this.llb_SignIn.AutoSize = true;
            this.llb_SignIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_SignIn.Location = new System.Drawing.Point(314, 280);
            this.llb_SignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llb_SignIn.Name = "llb_SignIn";
            this.llb_SignIn.Size = new System.Drawing.Size(58, 14);
            this.llb_SignIn.TabIndex = 9;
            this.llb_SignIn.TabStop = true;
            this.llb_SignIn.Text = "Đăng ký";
            this.llb_SignIn.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llb_SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_SignIn_LinkClicked);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(174, 33);
            this.lb_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(272, 26);
            this.lb_Login.TabIndex = 15;
            this.lb_Login.Text = "Đăng nhập tài khoản";
            this.lb_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.llb_SignIn);
            this.Controls.Add(this.lb_SignIn);
            this.Controls.Add(this.llb_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel llb_ForgotPassword;
        private System.Windows.Forms.Label lb_SignIn;
        private System.Windows.Forms.LinkLabel llb_SignIn;
        private System.Windows.Forms.Label lb_Login;
    }
}