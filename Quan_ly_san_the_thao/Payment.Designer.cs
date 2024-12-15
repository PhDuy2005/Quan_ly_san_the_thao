namespace Quan_ly_san_the_thao
{
    partial class Payment
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
            this.lb_PaymentInfo = new System.Windows.Forms.Label();
            this.lb_NgayDat = new System.Windows.Forms.Label();
            this.lb_NgayNhan = new System.Windows.Forms.Label();
            this.lb_ReserveDate = new System.Windows.Forms.Label();
            this.lb_ChkInDate = new System.Windows.Forms.Label();
            this.lb_NguoiDat = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.dgv_FieldInfo = new System.Windows.Forms.DataGridView();
            this.cl_Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_RentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FieldInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_PaymentInfo
            // 
            this.lb_PaymentInfo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PaymentInfo.Location = new System.Drawing.Point(166, 15);
            this.lb_PaymentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PaymentInfo.Name = "lb_PaymentInfo";
            this.lb_PaymentInfo.Size = new System.Drawing.Size(259, 28);
            this.lb_PaymentInfo.TabIndex = 16;
            this.lb_PaymentInfo.Text = "Thông tin đặt sân";
            this.lb_PaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_NgayDat
            // 
            this.lb_NgayDat.AutoSize = true;
            this.lb_NgayDat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayDat.ForeColor = System.Drawing.Color.Gray;
            this.lb_NgayDat.Location = new System.Drawing.Point(98, 63);
            this.lb_NgayDat.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_NgayDat.Name = "lb_NgayDat";
            this.lb_NgayDat.Size = new System.Drawing.Size(101, 17);
            this.lb_NgayDat.TabIndex = 17;
            this.lb_NgayDat.Text = "Ngày đặt sân";
            // 
            // lb_NgayNhan
            // 
            this.lb_NgayNhan.AutoSize = true;
            this.lb_NgayNhan.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayNhan.ForeColor = System.Drawing.Color.Gray;
            this.lb_NgayNhan.Location = new System.Drawing.Point(405, 63);
            this.lb_NgayNhan.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_NgayNhan.Name = "lb_NgayNhan";
            this.lb_NgayNhan.Size = new System.Drawing.Size(113, 17);
            this.lb_NgayNhan.TabIndex = 18;
            this.lb_NgayNhan.Text = "Ngày nhận sân";
            // 
            // lb_ReserveDate
            // 
            this.lb_ReserveDate.AutoSize = true;
            this.lb_ReserveDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReserveDate.ForeColor = System.Drawing.Color.Black;
            this.lb_ReserveDate.Location = new System.Drawing.Point(77, 91);
            this.lb_ReserveDate.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_ReserveDate.Name = "lb_ReserveDate";
            this.lb_ReserveDate.Size = new System.Drawing.Size(155, 17);
            this.lb_ReserveDate.TabIndex = 19;
            this.lb_ReserveDate.Text = "//Đổi label theo ngày";
            // 
            // lb_ChkInDate
            // 
            this.lb_ChkInDate.AutoSize = true;
            this.lb_ChkInDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChkInDate.ForeColor = System.Drawing.Color.Black;
            this.lb_ChkInDate.Location = new System.Drawing.Point(382, 91);
            this.lb_ChkInDate.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_ChkInDate.Name = "lb_ChkInDate";
            this.lb_ChkInDate.Size = new System.Drawing.Size(155, 17);
            this.lb_ChkInDate.TabIndex = 20;
            this.lb_ChkInDate.Text = "//Đổi label theo ngày";
            // 
            // lb_NguoiDat
            // 
            this.lb_NguoiDat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NguoiDat.ForeColor = System.Drawing.Color.Gray;
            this.lb_NguoiDat.Location = new System.Drawing.Point(98, 141);
            this.lb_NguoiDat.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_NguoiDat.Name = "lb_NguoiDat";
            this.lb_NguoiDat.Size = new System.Drawing.Size(92, 16);
            this.lb_NguoiDat.TabIndex = 21;
            this.lb_NguoiDat.Text = "Người đặt";
            this.lb_NguoiDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Black;
            this.lb_Name.Location = new System.Drawing.Point(64, 166);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(190, 17);
            this.lb_Name.TabIndex = 22;
            this.lb_Name.Text = "//Đổi thành tên người đặt";
            // 
            // lb_Phone
            // 
            this.lb_Phone.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(367, 166);
            this.lb_Phone.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(173, 16);
            this.lb_Phone.TabIndex = 23;
            this.lb_Phone.Text = "//Đổi thành SĐT";
            this.lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SDT
            // 
            this.lb_SDT.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.ForeColor = System.Drawing.Color.Gray;
            this.lb_SDT.Location = new System.Drawing.Point(405, 141);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(104, 16);
            this.lb_SDT.TabIndex = 24;
            this.lb_SDT.Text = "Số điện thoại";
            this.lb_SDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.ForeColor = System.Drawing.Color.Gray;
            this.lb_ThanhTien.Location = new System.Drawing.Point(34, 314);
            this.lb_ThanhTien.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(136, 24);
            this.lb_ThanhTien.TabIndex = 33;
            this.lb_ThanhTien.Text = "Thành tiền:";
            this.lb_ThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Total
            // 
            this.lb_Total.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.Color.Black;
            this.lb_Total.Location = new System.Drawing.Point(181, 314);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(237, 24);
            this.lb_Total.TabIndex = 34;
            this.lb_Total.Text = "//Đổi thành tổng tiền (VNĐ)";
            this.lb_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Pay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.Location = new System.Drawing.Point(333, 363);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(176, 31);
            this.btn_Pay.TabIndex = 35;
            this.btn_Pay.Text = "Thanh toán";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // dgv_FieldInfo
            // 
            this.dgv_FieldInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FieldInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Field,
            this.cl_RentTime,
            this.cl_UnitPrice,
            this.cl_Discount});
            this.dgv_FieldInfo.Location = new System.Drawing.Point(9, 197);
            this.dgv_FieldInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_FieldInfo.Name = "dgv_FieldInfo";
            this.dgv_FieldInfo.RowHeadersWidth = 51;
            this.dgv_FieldInfo.RowTemplate.Height = 24;
            this.dgv_FieldInfo.Size = new System.Drawing.Size(582, 103);
            this.dgv_FieldInfo.TabIndex = 37;
            // 
            // cl_Field
            // 
            this.cl_Field.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_Field.HeaderText = "Sân";
            this.cl_Field.MinimumWidth = 6;
            this.cl_Field.Name = "cl_Field";
            // 
            // cl_RentTime
            // 
            this.cl_RentTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_RentTime.HeaderText = "Thời gian thuê";
            this.cl_RentTime.MinimumWidth = 6;
            this.cl_RentTime.Name = "cl_RentTime";
            // 
            // cl_UnitPrice
            // 
            this.cl_UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_UnitPrice.HeaderText = "Đơn giá";
            this.cl_UnitPrice.MinimumWidth = 6;
            this.cl_UnitPrice.Name = "cl_UnitPrice";
            // 
            // cl_Discount
            // 
            this.cl_Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_Discount.HeaderText = "Giảm giá";
            this.cl_Discount.MinimumWidth = 6;
            this.cl_Discount.Name = "cl_Discount";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this.dgv_FieldInfo);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_ThanhTien);
            this.Controls.Add(this.lb_SDT);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_NguoiDat);
            this.Controls.Add(this.lb_ChkInDate);
            this.Controls.Add(this.lb_ReserveDate);
            this.Controls.Add(this.lb_NgayNhan);
            this.Controls.Add(this.lb_NgayDat);
            this.Controls.Add(this.lb_PaymentInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FieldInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PaymentInfo;
        private System.Windows.Forms.Label lb_NgayDat;
        private System.Windows.Forms.Label lb_NgayNhan;
        private System.Windows.Forms.Label lb_ReserveDate;
        private System.Windows.Forms.Label lb_ChkInDate;
        private System.Windows.Forms.Label lb_NguoiDat;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.DataGridView dgv_FieldInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_RentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Discount;
    }
}