namespace QuanLyPhongKham
{
    partial class ThemCho
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
            this.ThemCho_txt_LiDoKham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ThemCho_dtP_ThoiGianKham = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ThemCho_btn_ThemCho = new DevExpress.XtraEditors.SimpleButton();
            this.ThemCho_btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemCho_txt_LiDoKham
            // 
            this.ThemCho_txt_LiDoKham.Location = new System.Drawing.Point(94, 98);
            this.ThemCho_txt_LiDoKham.Multiline = true;
            this.ThemCho_txt_LiDoKham.Name = "ThemCho_txt_LiDoKham";
            this.ThemCho_txt_LiDoKham.Size = new System.Drawing.Size(199, 61);
            this.ThemCho_txt_LiDoKham.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lí Do Khám";
            // 
            // ThemCho_dtP_ThoiGianKham
            // 
            this.ThemCho_dtP_ThoiGianKham.CustomFormat = "dd/MM/yyyy    hh:mm";
            this.ThemCho_dtP_ThoiGianKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThemCho_dtP_ThoiGianKham.Location = new System.Drawing.Point(108, 61);
            this.ThemCho_dtP_ThoiGianKham.Name = "ThemCho_dtP_ThoiGianKham";
            this.ThemCho_dtP_ThoiGianKham.Size = new System.Drawing.Size(185, 20);
            this.ThemCho_dtP_ThoiGianKham.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian khám";
            // 
            // ThemCho_btn_ThemCho
            // 
            this.ThemCho_btn_ThemCho.Location = new System.Drawing.Point(114, 195);
            this.ThemCho_btn_ThemCho.Name = "ThemCho_btn_ThemCho";
            this.ThemCho_btn_ThemCho.Size = new System.Drawing.Size(76, 31);
            this.ThemCho_btn_ThemCho.TabIndex = 12;
            this.ThemCho_btn_ThemCho.Text = "Thêm Chờ";
            this.ThemCho_btn_ThemCho.Click += new System.EventHandler(this.ThemCho_btn_ThemCho_Click);
            // 
            // ThemCho_btn_Thoat
            // 
            this.ThemCho_btn_Thoat.Location = new System.Drawing.Point(217, 195);
            this.ThemCho_btn_Thoat.Name = "ThemCho_btn_Thoat";
            this.ThemCho_btn_Thoat.Size = new System.Drawing.Size(76, 31);
            this.ThemCho_btn_Thoat.TabIndex = 12;
            this.ThemCho_btn_Thoat.Text = "Thoát";
            this.ThemCho_btn_Thoat.Click += new System.EventHandler(this.ThemCho_btn_Thoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(73, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thông tin khám bệnh";
            // 
            // ThemCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 238);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ThemCho_btn_Thoat);
            this.Controls.Add(this.ThemCho_btn_ThemCho);
            this.Controls.Add(this.ThemCho_dtP_ThoiGianKham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ThemCho_txt_LiDoKham);
            this.Controls.Add(this.label5);
            this.Name = "ThemCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chờ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ThemCho_txt_LiDoKham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ThemCho_dtP_ThoiGianKham;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton ThemCho_btn_ThemCho;
        private DevExpress.XtraEditors.SimpleButton ThemCho_btn_Thoat;
        private System.Windows.Forms.Label label11;
    }
}