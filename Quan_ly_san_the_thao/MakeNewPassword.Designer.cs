namespace Quan_ly_san_the_thao
{
    partial class MakeNewPassword
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ChangePw = new System.Windows.Forms.Button();
            this.tb_NewPwConfirm = new System.Windows.Forms.TextBox();
            this.lb_NewPwConfirm = new System.Windows.Forms.Label();
            this.tb_NewPw = new System.Windows.Forms.TextBox();
            this.lb_NewPw = new System.Windows.Forms.Label();
            this.lb_CreateNewPw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(249, 277);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(324, 38);
            this.btn_Back.TabIndex = 31;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_ChangePw
            // 
            this.btn_ChangePw.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePw.Location = new System.Drawing.Point(249, 222);
            this.btn_ChangePw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChangePw.Name = "btn_ChangePw";
            this.btn_ChangePw.Size = new System.Drawing.Size(324, 49);
            this.btn_ChangePw.TabIndex = 30;
            this.btn_ChangePw.Text = "Đổi mật khẩu";
            this.btn_ChangePw.UseVisualStyleBackColor = true;
            this.btn_ChangePw.Click += new System.EventHandler(this.btn_ChangePw_Click);
            // 
            // tb_NewPwConfirm
            // 
            this.tb_NewPwConfirm.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewPwConfirm.Location = new System.Drawing.Point(377, 154);
            this.tb_NewPwConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NewPwConfirm.Name = "tb_NewPwConfirm";
            this.tb_NewPwConfirm.Size = new System.Drawing.Size(299, 28);
            this.tb_NewPwConfirm.TabIndex = 29;
            this.tb_NewPwConfirm.UseSystemPasswordChar = true;
            // 
            // lb_NewPwConfirm
            // 
            this.lb_NewPwConfirm.AutoSize = true;
            this.lb_NewPwConfirm.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewPwConfirm.Location = new System.Drawing.Point(113, 162);
            this.lb_NewPwConfirm.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_NewPwConfirm.Name = "lb_NewPwConfirm";
            this.lb_NewPwConfirm.Size = new System.Drawing.Size(223, 20);
            this.lb_NewPwConfirm.TabIndex = 28;
            this.lb_NewPwConfirm.Text = "Xác nhận mật khẩu mới:";
            // 
            // tb_NewPw
            // 
            this.tb_NewPw.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewPw.Location = new System.Drawing.Point(377, 103);
            this.tb_NewPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NewPw.Name = "tb_NewPw";
            this.tb_NewPw.Size = new System.Drawing.Size(299, 28);
            this.tb_NewPw.TabIndex = 27;
            this.tb_NewPw.UseSystemPasswordChar = true;
            // 
            // lb_NewPw
            // 
            this.lb_NewPw.AutoSize = true;
            this.lb_NewPw.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewPw.Location = new System.Drawing.Point(203, 112);
            this.lb_NewPw.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_NewPw.Name = "lb_NewPw";
            this.lb_NewPw.Size = new System.Drawing.Size(134, 20);
            this.lb_NewPw.TabIndex = 26;
            this.lb_NewPw.Text = "Mật khẩu mới:";
            // 
            // lb_CreateNewPw
            // 
            this.lb_CreateNewPw.AutoSize = true;
            this.lb_CreateNewPw.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreateNewPw.Location = new System.Drawing.Point(243, 41);
            this.lb_CreateNewPw.Name = "lb_CreateNewPw";
            this.lb_CreateNewPw.Size = new System.Drawing.Size(301, 34);
            this.lb_CreateNewPw.TabIndex = 25;
            this.lb_CreateNewPw.Text = "Tạo mật khẩu mới";
            this.lb_CreateNewPw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MakeNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ChangePw);
            this.Controls.Add(this.tb_NewPwConfirm);
            this.Controls.Add(this.lb_NewPwConfirm);
            this.Controls.Add(this.tb_NewPw);
            this.Controls.Add(this.lb_NewPw);
            this.Controls.Add(this.lb_CreateNewPw);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MakeNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeNewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ChangePw;
        private System.Windows.Forms.TextBox tb_NewPwConfirm;
        private System.Windows.Forms.Label lb_NewPwConfirm;
        private System.Windows.Forms.TextBox tb_NewPw;
        private System.Windows.Forms.Label lb_NewPw;
        private System.Windows.Forms.Label lb_CreateNewPw;
    }
}