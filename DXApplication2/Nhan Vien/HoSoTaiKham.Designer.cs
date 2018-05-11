namespace QuanLyPhongKham
{
    partial class HoSoTaiKham
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
            this.gridControl1_HoSoTaiKham = new DevExpress.XtraGrid.GridControl();
            this.cardView1_HoSoTaiKham = new DevExpress.XtraGrid.Views.Card.CardView();
            this.clMaSoKhamBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayGioKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clXetNghiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clLiDoKham = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoSoTaiKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1_HoSoTaiKham)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1_HoSoTaiKham
            // 
            this.gridControl1_HoSoTaiKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_HoSoTaiKham.Location = new System.Drawing.Point(0, 0);
            this.gridControl1_HoSoTaiKham.MainView = this.cardView1_HoSoTaiKham;
            this.gridControl1_HoSoTaiKham.Name = "gridControl1_HoSoTaiKham";
            this.gridControl1_HoSoTaiKham.Size = new System.Drawing.Size(568, 373);
            this.gridControl1_HoSoTaiKham.TabIndex = 0;
            this.gridControl1_HoSoTaiKham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1_HoSoTaiKham});
            // 
            // cardView1_HoSoTaiKham
            // 
            this.cardView1_HoSoTaiKham.CardCaptionFormat = "Tái khám";
            this.cardView1_HoSoTaiKham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaSoKhamBenh,
            this.clTenNhanVien,
            this.clNgayGioKham,
            this.clLiDoKham,
            this.clXetNghiem,
            this.clChuanDoan,
            this.clGhiChu});
            this.cardView1_HoSoTaiKham.FocusedCardTopFieldIndex = 0;
            this.cardView1_HoSoTaiKham.GridControl = this.gridControl1_HoSoTaiKham;
            this.cardView1_HoSoTaiKham.Name = "cardView1_HoSoTaiKham";
            this.cardView1_HoSoTaiKham.OptionsBehavior.Editable = false;
            this.cardView1_HoSoTaiKham.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.cardView1_HoSoTaiKham.ViewCaption = "Hồ Sơ Tái Khám";
            // 
            // clMaSoKhamBenh
            // 
            this.clMaSoKhamBenh.Caption = "Mã số khám bệnh";
            this.clMaSoKhamBenh.FieldName = "MaSoKhamBenh";
            this.clMaSoKhamBenh.Name = "clMaSoKhamBenh";
            this.clMaSoKhamBenh.Visible = true;
            this.clMaSoKhamBenh.VisibleIndex = 0;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.Caption = "Tên Bác Sĩ";
            this.clTenNhanVien.FieldName = "TenNhanVien";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.Visible = true;
            this.clTenNhanVien.VisibleIndex = 1;
            // 
            // clNgayGioKham
            // 
            this.clNgayGioKham.Caption = "Ngày Giờ Khám";
            this.clNgayGioKham.FieldName = "NgayGioKham";
            this.clNgayGioKham.Name = "clNgayGioKham";
            this.clNgayGioKham.Visible = true;
            this.clNgayGioKham.VisibleIndex = 2;
            // 
            // clXetNghiem
            // 
            this.clXetNghiem.Caption = "Xét Nghiệm";
            this.clXetNghiem.FieldName = "XetNghiem";
            this.clXetNghiem.Name = "clXetNghiem";
            this.clXetNghiem.Visible = true;
            this.clXetNghiem.VisibleIndex = 4;
            // 
            // clChuanDoan
            // 
            this.clChuanDoan.Caption = "Chuẩn Đoán";
            this.clChuanDoan.FieldName = "ChuanDoan";
            this.clChuanDoan.Name = "clChuanDoan";
            this.clChuanDoan.Visible = true;
            this.clChuanDoan.VisibleIndex = 5;
            // 
            // clGhiChu
            // 
            this.clGhiChu.Caption = "Ghi Chú";
            this.clGhiChu.FieldName = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Visible = true;
            this.clGhiChu.VisibleIndex = 6;
            // 
            // clLiDoKham
            // 
            this.clLiDoKham.Caption = "Lí Do Khám";
            this.clLiDoKham.FieldName = "LiDoKham";
            this.clLiDoKham.Name = "clLiDoKham";
            this.clLiDoKham.Visible = true;
            this.clLiDoKham.VisibleIndex = 3;
            // 
            // HoSoTaiKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.gridControl1_HoSoTaiKham);
            this.Name = "HoSoTaiKham";
            this.Text = "Hồ Sơ Tái Khám";
            this.Load += new System.EventHandler(this.HoSoTaiKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoSoTaiKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1_HoSoTaiKham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1_HoSoTaiKham;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1_HoSoTaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn clMaSoKhamBenh;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayGioKham;
        private DevExpress.XtraGrid.Columns.GridColumn clLiDoKham;
        private DevExpress.XtraGrid.Columns.GridColumn clXetNghiem;
        private DevExpress.XtraGrid.Columns.GridColumn clChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
    }
}