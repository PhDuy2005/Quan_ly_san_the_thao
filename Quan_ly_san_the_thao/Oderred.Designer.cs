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
            this.dgv_OderredInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OderredInfo)).BeginInit();
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
            // dgv_OderredInfo
            // 
            this.dgv_OderredInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OderredInfo.Location = new System.Drawing.Point(12, 99);
            this.dgv_OderredInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_OderredInfo.Name = "dgv_OderredInfo";
            this.dgv_OderredInfo.RowHeadersWidth = 51;
            this.dgv_OderredInfo.RowTemplate.Height = 24;
            this.dgv_OderredInfo.Size = new System.Drawing.Size(776, 306);
            this.dgv_OderredInfo.TabIndex = 38;
            // 
            // Oderred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_OderredInfo);
            this.Controls.Add(this.lb_PaymentInfo);
            this.Name = "Oderred";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oderred";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OderredInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_PaymentInfo;
        private System.Windows.Forms.DataGridView dgv_OderredInfo;
    }
}