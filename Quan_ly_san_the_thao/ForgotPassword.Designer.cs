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
            this.lb_Note = new System.Windows.Forms.Label();
            this.tb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_EnterPhoneNumber
            // 
            this.lb_EnterPhoneNumber.AutoSize = true;
            this.lb_EnterPhoneNumber.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EnterPhoneNumber.Location = new System.Drawing.Point(12, 60);
            this.lb_EnterPhoneNumber.Name = "lb_EnterPhoneNumber";
            this.lb_EnterPhoneNumber.Size = new System.Drawing.Size(314, 34);
            this.lb_EnterPhoneNumber.TabIndex = 1;
            this.lb_EnterPhoneNumber.Text = "Nhập số điện thoại";
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Note.Location = new System.Drawing.Point(15, 107);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(335, 18);
            this.lb_Note.TabIndex = 2;
            this.lb_Note.Text = "Nhập số điện thoại của bạn để đổi mật khẩu";
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PhoneNumber.ForeColor = System.Drawing.Color.LightGray;
            this.tb_PhoneNumber.Location = new System.Drawing.Point(53, 171);
            this.tb_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.Size = new System.Drawing.Size(407, 28);
            this.tb_PhoneNumber.TabIndex = 3;
            this.tb_PhoneNumber.Text = "Nhập số điện thoại...";
            this.tb_PhoneNumber.Enter += new System.EventHandler(this.Phone_Enter);
            this.tb_PhoneNumber.Leave += new System.EventHandler(this.Phone_Leave);
            // 
            // btn_Verify
            // 
            this.btn_Verify.BackColor = System.Drawing.Color.Lime;
            this.btn_Verify.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verify.Location = new System.Drawing.Point(92, 230);
            this.btn_Verify.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(325, 39);
            this.btn_Verify.TabIndex = 4;
            this.btn_Verify.Text = "Xác nhận";
            this.btn_Verify.UseVisualStyleBackColor = false;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 502);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.tb_PhoneNumber);
            this.Controls.Add(this.lb_Note);
            this.Controls.Add(this.lb_EnterPhoneNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EnterPhoneNumber;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.TextBox tb_PhoneNumber;
        private System.Windows.Forms.Button btn_Verify;
    }
}