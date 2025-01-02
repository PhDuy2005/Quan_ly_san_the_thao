namespace Quan_ly_san_the_thao
{
    partial class AdminStat
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lb_ChkInDate = new System.Windows.Forms.Label();
            this.lb_ReserveDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GetStatFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker1.CustomFormat = "dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker2.CustomFormat = "dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(287, 30);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lb_ChkInDate
            // 
            this.lb_ChkInDate.AutoSize = true;
            this.lb_ChkInDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChkInDate.ForeColor = System.Drawing.Color.Black;
            this.lb_ChkInDate.Location = new System.Drawing.Point(73, 89);
            this.lb_ChkInDate.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_ChkInDate.Name = "lb_ChkInDate";
            this.lb_ChkInDate.Size = new System.Drawing.Size(91, 20);
            this.lb_ChkInDate.TabIndex = 22;
            this.lb_ChkInDate.Text = "Đến ngày";
            this.lb_ChkInDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ReserveDate
            // 
            this.lb_ReserveDate.AutoSize = true;
            this.lb_ReserveDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReserveDate.ForeColor = System.Drawing.Color.Black;
            this.lb_ReserveDate.Location = new System.Drawing.Point(73, 39);
            this.lb_ReserveDate.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_ReserveDate.Name = "lb_ReserveDate";
            this.lb_ReserveDate.Size = new System.Drawing.Size(78, 20);
            this.lb_ReserveDate.TabIndex = 21;
            this.lb_ReserveDate.Text = "Từ ngày";
            this.lb_ReserveDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng chuyền",
            "Bóng rổ",
            "Cầu lông"});
            this.comboBox1.Location = new System.Drawing.Point(284, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 31);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Đến ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // btn_GetStatFile
            // 
            this.btn_GetStatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GetStatFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetStatFile.Location = new System.Drawing.Point(590, 37);
            this.btn_GetStatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetStatFile.Name = "btn_GetStatFile";
            this.btn_GetStatFile.Size = new System.Drawing.Size(198, 129);
            this.btn_GetStatFile.TabIndex = 36;
            this.btn_GetStatFile.Text = "Xuất báo cáo";
            this.btn_GetStatFile.UseVisualStyleBackColor = false;
            this.btn_GetStatFile.Click += new System.EventHandler(this.btn_GetStatFile_Click);
            // 
            // AdminStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GetStatFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_ChkInDate);
            this.Controls.Add(this.lb_ReserveDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AdminStat";
            this.Text = "AdminStat";
            this.Load += new System.EventHandler(this.AdminStat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lb_ChkInDate;
        private System.Windows.Forms.Label lb_ReserveDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GetStatFile;
    }
}