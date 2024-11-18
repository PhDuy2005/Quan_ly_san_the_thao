namespace Quan_ly_san_the_thao
{
    partial class ForgotPassword
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
            this.lb_EnterPhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_EnterPhoneNumber
            // 
            this.lb_EnterPhoneNumber.AutoSize = true;
            this.lb_EnterPhoneNumber.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EnterPhoneNumber.Location = new System.Drawing.Point(12, 62);
            this.lb_EnterPhoneNumber.Name = "lb_EnterPhoneNumber";
            this.lb_EnterPhoneNumber.Size = new System.Drawing.Size(314, 34);
            this.lb_EnterPhoneNumber.TabIndex = 1;
            this.lb_EnterPhoneNumber.Text = "Nhập số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số điện thoại của bạn để nhận mã xác nhận OTP";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_EnterPhoneNumber);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EnterPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}