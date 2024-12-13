namespace Quan_ly_san_the_thao
{
    partial class SportListForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_changePw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Greeting = new System.Windows.Forms.Label();
            this.lb_ChooseSport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_UserInfo,
            this.tsmi_changePw,
            this.tsmi_LogOut});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.thoátToolStripMenuItem.Text = "Tài khoản";
            // 
            // tsmi_UserInfo
            // 
            this.tsmi_UserInfo.Name = "tsmi_UserInfo";
            this.tsmi_UserInfo.Size = new System.Drawing.Size(186, 26);
            this.tsmi_UserInfo.Text = "Xem thông tin";
            this.tsmi_UserInfo.Click += new System.EventHandler(this.UserInfo_Click);
            // 
            // tsmi_changePw
            // 
            this.tsmi_changePw.Name = "tsmi_changePw";
            this.tsmi_changePw.Size = new System.Drawing.Size(186, 26);
            this.tsmi_changePw.Text = "Đổi mật khẩu";
            // 
            // tsmi_LogOut
            // 
            this.tsmi_LogOut.Name = "tsmi_LogOut";
            this.tsmi_LogOut.Size = new System.Drawing.Size(186, 26);
            this.tsmi_LogOut.Text = "Đăng xuất";
            // 
            // lb_Greeting
            // 
            this.lb_Greeting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Greeting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_Greeting.Location = new System.Drawing.Point(3, 43);
            this.lb_Greeting.Name = "lb_Greeting";
            this.lb_Greeting.Size = new System.Drawing.Size(796, 88);
            this.lb_Greeting.TabIndex = 2;
            this.lb_Greeting.Text = "CHÀO MỪNG [TÊN KHÁCH HÀNG]";
            this.lb_Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChooseSport
            // 
            this.lb_ChooseSport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ChooseSport.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lb_ChooseSport.Location = new System.Drawing.Point(4, 143);
            this.lb_ChooseSport.Name = "lb_ChooseSport";
            this.lb_ChooseSport.Size = new System.Drawing.Size(796, 54);
            this.lb_ChooseSport.TabIndex = 3;
            this.lb_ChooseSport.Text = "Xin vui lòng chọn môn";
            this.lb_ChooseSport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cầu lông";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(217, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bóng rổ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(613, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "Bóng đá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(415, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 63);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bóng chuyền";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ChooseSport);
            this.Controls.Add(this.lb_Greeting);
            this.Controls.Add(this.menuStrip);
            this.Name = "SportListForm";
            this.Text = "SportListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SportListForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lb_Greeting;
        private System.Windows.Forms.Label lb_ChooseSport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_changePw;
        private System.Windows.Forms.ToolStripMenuItem tsmi_LogOut;
    }
}