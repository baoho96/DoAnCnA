namespace QuanLyPhongKham
{
    partial class BenhNhanThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenhNhanThanhToan));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1_XuatFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_ToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1_HoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1_HoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MSKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MSHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MSBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_XetNghiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KQXN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GhiChu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NgayGioKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NgayTaiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TongTienThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TienKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KiemTraLayThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_KiemTraThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1_XuatFile,
            this.barButtonItem1_ToExcel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(442, 79);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1_XuatFile
            // 
            this.barButtonItem1_XuatFile.Caption = "Xuất File PDF";
            this.barButtonItem1_XuatFile.Id = 1;
            this.barButtonItem1_XuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_XuatFile.ImageOptions.Image")));
            this.barButtonItem1_XuatFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_XuatFile.ImageOptions.LargeImage")));
            this.barButtonItem1_XuatFile.Name = "barButtonItem1_XuatFile";
            this.barButtonItem1_XuatFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_XuatFile_ItemClick);
            // 
            // barButtonItem1_ToExcel
            // 
            this.barButtonItem1_ToExcel.Caption = "Xuất File Excel";
            this.barButtonItem1_ToExcel.Id = 2;
            this.barButtonItem1_ToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_ToExcel.ImageOptions.Image")));
            this.barButtonItem1_ToExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_ToExcel.ImageOptions.LargeImage")));
            this.barButtonItem1_ToExcel.Name = "barButtonItem1_ToExcel";
            this.barButtonItem1_ToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ToExcel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Export";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1_XuatFile);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1_ToExcel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // gridControl1_HoaDon
            // 
            this.gridControl1_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_HoaDon.Location = new System.Drawing.Point(0, 79);
            this.gridControl1_HoaDon.MainView = this.gridView1_HoaDon;
            this.gridControl1_HoaDon.Name = "gridControl1_HoaDon";
            this.gridControl1_HoaDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1_HoaDon.Size = new System.Drawing.Size(442, 339);
            this.gridControl1_HoaDon.TabIndex = 9;
            this.gridControl1_HoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1_HoaDon});
            // 
            // gridView1_HoaDon
            // 
            this.gridView1_HoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MSDT,
            this.col_MSKB,
            this.col_MSHD,
            this.col_MSBN,
            this.col_Ho,
            this.col_Ten,
            this.col_NamSinh,
            this.col_SoDienThoai,
            this.col_DiaChi,
            this.col_XetNghiem,
            this.col_KQXN,
            this.col_ChuanDoan,
            this.col_GhiChu,
            this.col_GhiChu1,
            this.col_NgayGioKham,
            this.col_NgayTaiKham,
            this.col_TongTienThuoc,
            this.col_TienKham,
            this.col_TongTien,
            this.col_TenNhanVien,
            this.col_KiemTraLayThuoc,
            this.col_KiemTraThanhToan});
            this.gridView1_HoaDon.GridControl = this.gridControl1_HoaDon;
            this.gridView1_HoaDon.Name = "gridView1_HoaDon";
            this.gridView1_HoaDon.OptionsBehavior.Editable = false;
            this.gridView1_HoaDon.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1_HoaDon.OptionsFind.AlwaysVisible = true;
            this.gridView1_HoaDon.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_HoaDon_CustomDrawRowIndicator);
            this.gridView1_HoaDon.RowCountChanged += new System.EventHandler(this.gridView1_HoaDon_RowCountChanged);
            // 
            // col_MSDT
            // 
            this.col_MSDT.Caption = "MSDT";
            this.col_MSDT.FieldName = "MaSoDonThuoc";
            this.col_MSDT.Name = "col_MSDT";
            // 
            // col_MSKB
            // 
            this.col_MSKB.Caption = "MSKB";
            this.col_MSKB.FieldName = "MaSoKhamBenh";
            this.col_MSKB.Name = "col_MSKB";
            // 
            // col_MSHD
            // 
            this.col_MSHD.Caption = "MSHD";
            this.col_MSHD.FieldName = "MaHoaDon";
            this.col_MSHD.Name = "col_MSHD";
            // 
            // col_MSBN
            // 
            this.col_MSBN.Caption = "MSBN";
            this.col_MSBN.FieldName = "MaSoBenhNhan";
            this.col_MSBN.Name = "col_MSBN";
            this.col_MSBN.Width = 60;
            // 
            // col_Ho
            // 
            this.col_Ho.Caption = "Họ";
            this.col_Ho.FieldName = "Ho";
            this.col_Ho.Name = "col_Ho";
            this.col_Ho.Visible = true;
            this.col_Ho.VisibleIndex = 0;
            this.col_Ho.Width = 277;
            // 
            // col_Ten
            // 
            this.col_Ten.Caption = "Tên";
            this.col_Ten.FieldName = "Ten";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.Visible = true;
            this.col_Ten.VisibleIndex = 1;
            this.col_Ten.Width = 116;
            // 
            // col_NamSinh
            // 
            this.col_NamSinh.Caption = "NamSinh";
            this.col_NamSinh.FieldName = "NamSinh";
            this.col_NamSinh.Name = "col_NamSinh";
            // 
            // col_SoDienThoai
            // 
            this.col_SoDienThoai.Caption = "SĐT";
            this.col_SoDienThoai.FieldName = "SoDienThoai";
            this.col_SoDienThoai.Name = "col_SoDienThoai";
            this.col_SoDienThoai.Visible = true;
            this.col_SoDienThoai.VisibleIndex = 2;
            this.col_SoDienThoai.Width = 140;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.Caption = "DiaChi";
            this.col_DiaChi.FieldName = "DiaChi";
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_XetNghiem
            // 
            this.col_XetNghiem.Caption = "XetNghiem";
            this.col_XetNghiem.FieldName = "XetNghiem";
            this.col_XetNghiem.Name = "col_XetNghiem";
            // 
            // col_KQXN
            // 
            this.col_KQXN.Caption = "KQXN";
            this.col_KQXN.FieldName = "KQXN";
            this.col_KQXN.Name = "col_KQXN";
            // 
            // col_ChuanDoan
            // 
            this.col_ChuanDoan.Caption = "ChuanDoan";
            this.col_ChuanDoan.FieldName = "ChuanDoan";
            this.col_ChuanDoan.Name = "col_ChuanDoan";
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.Caption = "GhiChu";
            this.col_GhiChu.FieldName = "GhiChu";
            this.col_GhiChu.Name = "col_GhiChu";
            // 
            // col_GhiChu1
            // 
            this.col_GhiChu1.Caption = "GhiChu1";
            this.col_GhiChu1.FieldName = "GhiChu1";
            this.col_GhiChu1.Name = "col_GhiChu1";
            // 
            // col_NgayGioKham
            // 
            this.col_NgayGioKham.Caption = "NgayGioKham";
            this.col_NgayGioKham.FieldName = "NgayGioKham";
            this.col_NgayGioKham.Name = "col_NgayGioKham";
            // 
            // col_NgayTaiKham
            // 
            this.col_NgayTaiKham.Caption = "NgayTaiKham";
            this.col_NgayTaiKham.FieldName = "NgayTaiKham";
            this.col_NgayTaiKham.Name = "col_NgayTaiKham";
            // 
            // col_TongTienThuoc
            // 
            this.col_TongTienThuoc.Caption = "TongTienThuoc";
            this.col_TongTienThuoc.FieldName = "TongTienThuoc";
            this.col_TongTienThuoc.Name = "col_TongTienThuoc";
            // 
            // col_TienKham
            // 
            this.col_TienKham.Caption = "TienKham";
            this.col_TienKham.FieldName = "TienKham";
            this.col_TienKham.Name = "col_TienKham";
            // 
            // col_TongTien
            // 
            this.col_TongTien.Caption = "TongTien";
            this.col_TongTien.FieldName = "TongTien";
            this.col_TongTien.Name = "col_TongTien";
            // 
            // col_TenNhanVien
            // 
            this.col_TenNhanVien.Caption = "TenNhanVien";
            this.col_TenNhanVien.FieldName = "TenNhanVien";
            this.col_TenNhanVien.Name = "col_TenNhanVien";
            // 
            // col_KiemTraLayThuoc
            // 
            this.col_KiemTraLayThuoc.Caption = "Lấy Thuốc";
            this.col_KiemTraLayThuoc.FieldName = "KiemTraLayThuoc";
            this.col_KiemTraLayThuoc.Name = "col_KiemTraLayThuoc";
            this.col_KiemTraLayThuoc.Visible = true;
            this.col_KiemTraLayThuoc.VisibleIndex = 3;
            this.col_KiemTraLayThuoc.Width = 109;
            // 
            // col_KiemTraThanhToan
            // 
            this.col_KiemTraThanhToan.Caption = "Thanh toán";
            this.col_KiemTraThanhToan.FieldName = "KiemTraThanhToan";
            this.col_KiemTraThanhToan.Name = "col_KiemTraThanhToan";
            this.col_KiemTraThanhToan.Visible = true;
            this.col_KiemTraThanhToan.VisibleIndex = 4;
            this.col_KiemTraThanhToan.Width = 115;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // BenhNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.gridControl1_HoaDon);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "BenhNhanThanhToan";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Danh sách Bệnh Nhân trong ngày";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1_HoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1_HoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn col_MSDT;
        private DevExpress.XtraGrid.Columns.GridColumn col_MSKB;
        private DevExpress.XtraGrid.Columns.GridColumn col_MSHD;
        private DevExpress.XtraGrid.Columns.GridColumn col_MSBN;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ho;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn col_NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn col_SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn col_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn col_XetNghiem;
        private DevExpress.XtraGrid.Columns.GridColumn col_KQXN;
        private DevExpress.XtraGrid.Columns.GridColumn col_ChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn col_GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn col_GhiChu1;
        private DevExpress.XtraGrid.Columns.GridColumn col_NgayGioKham;
        private DevExpress.XtraGrid.Columns.GridColumn col_NgayTaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn col_TongTienThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn col_TienKham;
        private DevExpress.XtraGrid.Columns.GridColumn col_TongTien;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn col_KiemTraLayThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn col_KiemTraThanhToan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_XuatFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_ToExcel;
    }
}