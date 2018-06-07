namespace QuanLyPhongKham
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_nhaplaimk = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DangKi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_nhaplaimk);
            this.groupControl1.Controls.Add(this.txt_matkhau);
            this.groupControl1.Controls.Add(this.txt_taikhoan);
            this.groupControl1.Controls.Add(this.btn_thoat);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btn_DangKi);
            this.groupControl1.Location = new System.Drawing.Point(13, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(259, 236);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông tin đăng kí";
            // 
            // txt_nhaplaimk
            // 
            this.txt_nhaplaimk.Location = new System.Drawing.Point(112, 139);
            this.txt_nhaplaimk.Name = "txt_nhaplaimk";
            this.txt_nhaplaimk.PasswordChar = '*';
            this.txt_nhaplaimk.Size = new System.Drawing.Size(130, 21);
            this.txt_nhaplaimk.TabIndex = 9;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(112, 112);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(130, 21);
            this.txt_matkhau.TabIndex = 9;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(112, 85);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(130, 21);
            this.txt_taikhoan.TabIndex = 9;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(179, 196);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Quay lại";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(57, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng kí Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.Location = new System.Drawing.Point(98, 196);
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Size = new System.Drawing.Size(75, 23);
            this.btn_DangKi.TabIndex = 8;
            this.btn_DangKi.Text = "Đăng kí";
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // DangKi
            // 
            this.AcceptButton = this.btn_DangKi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_DangKi;
        private System.Windows.Forms.TextBox txt_nhaplaimk;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}