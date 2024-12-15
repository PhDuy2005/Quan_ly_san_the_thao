namespace Quan_ly_san_the_thao
{
    partial class OTPCode
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
            this.lb_OTP = new System.Windows.Forms.Label();
            this.lb_Note = new System.Windows.Forms.Label();
            this.tb_OTP = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.llb_Resend = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_OTP
            // 
            this.lb_OTP.AutoSize = true;
            this.lb_OTP.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OTP.Location = new System.Drawing.Point(12, 62);
            this.lb_OTP.Name = "lb_OTP";
            this.lb_OTP.Size = new System.Drawing.Size(231, 34);
            this.lb_OTP.TabIndex = 2;
            this.lb_OTP.Text = "Nhập mã OTP";
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Note.Location = new System.Drawing.Point(15, 107);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(226, 18);
            this.lb_Note.TabIndex = 3;
            this.lb_Note.Text = "Đừng lo việc mất tài khoản!!!";
            // 
            // tb_OTP
            // 
            this.tb_OTP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_OTP.ForeColor = System.Drawing.Color.LightGray;
            this.tb_OTP.Location = new System.Drawing.Point(43, 159);
            this.tb_OTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_OTP.Name = "tb_OTP";
            this.tb_OTP.Size = new System.Drawing.Size(365, 28);
            this.tb_OTP.TabIndex = 4;
            this.tb_OTP.Text = "Nhập mã xác nhận...";
            this.tb_OTP.Enter += new System.EventHandler(this.OTP_Enter);
            this.tb_OTP.Leave += new System.EventHandler(this.OTP_Leave);
            // 
            // btn_Verify
            // 
            this.btn_Verify.BackColor = System.Drawing.Color.Lime;
            this.btn_Verify.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verify.Location = new System.Drawing.Point(63, 224);
            this.btn_Verify.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(325, 39);
            this.btn_Verify.TabIndex = 5;
            this.btn_Verify.Text = "Xác nhận";
            this.btn_Verify.UseVisualStyleBackColor = false;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(63, 273);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(325, 39);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // llb_Resend
            // 
            this.llb_Resend.AutoSize = true;
            this.llb_Resend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Resend.LinkColor = System.Drawing.Color.Black;
            this.llb_Resend.Location = new System.Drawing.Point(181, 329);
            this.llb_Resend.Name = "llb_Resend";
            this.llb_Resend.Size = new System.Drawing.Size(89, 18);
            this.llb_Resend.TabIndex = 7;
            this.llb_Resend.TabStop = true;
            this.llb_Resend.Text = "Gửi lại mã";
            this.llb_Resend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llb_Resend.VisitedLinkColor = System.Drawing.Color.Black;
            this.llb_Resend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Resend_LinkClicked);
            // 
            // OTPCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.llb_Resend);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.tb_OTP);
            this.Controls.Add(this.lb_Note);
            this.Controls.Add(this.lb_OTP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OTPCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_OTP;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.TextBox tb_OTP;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.LinkLabel llb_Resend;
    }
}