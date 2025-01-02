namespace Quan_ly_san_the_thao
{
    partial class Oderred
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
            this.lb_PaymentInfo.Location = new System.Drawing.Point(225, 9);
            this.lb_PaymentInfo.Name = "lb_PaymentInfo";
            this.lb_PaymentInfo.Size = new System.Drawing.Size(345, 34);
            this.lb_PaymentInfo.TabIndex = 17;
            this.lb_PaymentInfo.Text = "Thông tin đặt sân";
            this.lb_PaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_FieldInfo
            // 
            this.dgv_FieldInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FieldInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Field,
            this.cl_RentTime,
            this.cl_UnitPrice,
            this.cl_Discount});
            this.dgv_FieldInfo.Location = new System.Drawing.Point(12, 162);
            this.dgv_FieldInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_FieldInfo.Name = "dgv_FieldInfo";
            this.dgv_FieldInfo.RowHeadersWidth = 51;
            this.dgv_FieldInfo.RowTemplate.Height = 24;
            this.dgv_FieldInfo.Size = new System.Drawing.Size(776, 127);
            this.dgv_FieldInfo.TabIndex = 38;
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
            // Oderred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_FieldInfo);
            this.Controls.Add(this.lb_PaymentInfo);
            this.Name = "Oderred";
            this.Text = "Oderred";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FieldInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_PaymentInfo;
        private System.Windows.Forms.DataGridView dgv_FieldInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_RentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Discount;
    }
}