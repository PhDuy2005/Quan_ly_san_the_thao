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
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_ChonMon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Football = new System.Windows.Forms.Button();
            this.btn_Badminton = new System.Windows.Forms.Button();
            this.btn_Volleyball = new System.Windows.Forms.Button();
            this.btn_Basketball = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(797, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_welcome);
            this.panel1.Location = new System.Drawing.Point(1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 76);
            this.panel1.TabIndex = 1;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_welcome.Location = new System.Drawing.Point(119, 11);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(575, 46);
            this.lb_welcome.TabIndex = 0;
            this.lb_welcome.Text = "CHÀO MỪNG [TÊN KHÁCH HÀNG]";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChonMon
            // 
            this.lb_ChonMon.AutoSize = true;
            this.lb_ChonMon.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lb_ChonMon.Location = new System.Drawing.Point(144, 10);
            this.lb_ChonMon.Name = "lb_ChonMon";
            this.lb_ChonMon.Size = new System.Drawing.Size(523, 46);
            this.lb_ChonMon.TabIndex = 1;
            this.lb_ChonMon.Text = "Xin vui lòng chọn môn thể thao";
            this.lb_ChonMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Basketball);
            this.panel2.Controls.Add(this.btn_Volleyball);
            this.panel2.Controls.Add(this.btn_Badminton);
            this.panel2.Controls.Add(this.btn_Football);
            this.panel2.Controls.Add(this.lb_ChonMon);
            this.panel2.Location = new System.Drawing.Point(2, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 225);
            this.panel2.TabIndex = 2;
            // 
            // btn_Football
            // 
            this.btn_Football.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Football.Location = new System.Drawing.Point(33, 127);
            this.btn_Football.Name = "btn_Football";
            this.btn_Football.Size = new System.Drawing.Size(167, 46);
            this.btn_Football.TabIndex = 2;
            this.btn_Football.Text = "Bóng đá";
            this.btn_Football.UseVisualStyleBackColor = true;
            // 
            // btn_Badminton
            // 
            this.btn_Badminton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Badminton.Location = new System.Drawing.Point(225, 127);
            this.btn_Badminton.Name = "btn_Badminton";
            this.btn_Badminton.Size = new System.Drawing.Size(167, 46);
            this.btn_Badminton.TabIndex = 2;
            this.btn_Badminton.Text = "Cầu lông";
            this.btn_Badminton.UseVisualStyleBackColor = true;
            // 
            // btn_Volleyball
            // 
            this.btn_Volleyball.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Volleyball.Location = new System.Drawing.Point(416, 127);
            this.btn_Volleyball.Name = "btn_Volleyball";
            this.btn_Volleyball.Size = new System.Drawing.Size(167, 46);
            this.btn_Volleyball.TabIndex = 2;
            this.btn_Volleyball.Text = "Bóng chuyền";
            this.btn_Volleyball.UseVisualStyleBackColor = true;
            // 
            // btn_Basketball
            // 
            this.btn_Basketball.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Basketball.Location = new System.Drawing.Point(605, 127);
            this.btn_Basketball.Name = "btn_Basketball";
            this.btn_Basketball.Size = new System.Drawing.Size(167, 46);
            this.btn_Basketball.TabIndex = 2;
            this.btn_Basketball.Text = "Bóng rổ";
            this.btn_Basketball.UseVisualStyleBackColor = true;
            // 
            // SportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SportListForm";
            this.Text = "SportListForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_ChonMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Basketball;
        private System.Windows.Forms.Button btn_Volleyball;
        private System.Windows.Forms.Button btn_Badminton;
        private System.Windows.Forms.Button btn_Football;
    }
}