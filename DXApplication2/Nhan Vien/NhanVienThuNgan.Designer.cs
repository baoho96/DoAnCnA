namespace QuanLyPhongKham
{
    partial class NhanVienThuNgan
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienThuNgan));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_XuatFile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.chBox_LayThuoc = new System.Windows.Forms.CheckBox();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.gridControl1_HoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1_HoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXetNghiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQuaXetNghiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChuDonThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChuHSKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTaiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBacSiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiemTraThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKiemTraLayThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.bbiRefresh,
            this.barButtonItem1_DangXuat,
            this.barButtonItem1_XuatFile});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Left;
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1014, 130);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barButtonItem1_DangXuat
            // 
            this.barButtonItem1_DangXuat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1_DangXuat.Caption = "Đăng xuất";
            this.barButtonItem1_DangXuat.Id = 20;
            this.barButtonItem1_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_DangXuat.ImageOptions.Image")));
            this.barButtonItem1_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_DangXuat.ImageOptions.LargeImage")));
            this.barButtonItem1_DangXuat.Name = "barButtonItem1_DangXuat";
            this.barButtonItem1_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_DangXuat_ItemClick);
            // 
            // barButtonItem1_XuatFile
            // 
            this.barButtonItem1_XuatFile.Caption = "Xuất file Danh sách Bệnh nhân";
            this.barButtonItem1_XuatFile.Id = 21;
            this.barButtonItem1_XuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_XuatFile.ImageOptions.Image")));
            this.barButtonItem1_XuatFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_XuatFile.ImageOptions.LargeImage")));
            this.barButtonItem1_XuatFile.Name = "barButtonItem1_XuatFile";
            this.barButtonItem1_XuatFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_XuatFile_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1_XuatFile);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1_DangXuat);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThanhToan);
            this.panel1.Controls.Add(this.chBox_LayThuoc);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 75);
            this.panel1.TabIndex = 4;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ThanhToan.Appearance.Options.UseFont = true;
            this.btn_ThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.ImageOptions.Image")));
            this.btn_ThanhToan.Location = new System.Drawing.Point(313, 12);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(95, 37);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // chBox_LayThuoc
            // 
            this.chBox_LayThuoc.AutoSize = true;
            this.chBox_LayThuoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chBox_LayThuoc.Location = new System.Drawing.Point(38, 22);
            this.chBox_LayThuoc.Name = "chBox_LayThuoc";
            this.chBox_LayThuoc.Size = new System.Drawing.Size(200, 18);
            this.chBox_LayThuoc.TabIndex = 0;
            this.chBox_LayThuoc.Text = "Bệnh nhân đồng ý lấy thuốc";
            this.chBox_LayThuoc.UseVisualStyleBackColor = true;
            // 
            // documentViewer1
            // 
            this.documentViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(452, 130);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(562, 538);
            this.documentViewer1.TabIndex = 5;
            // 
            // gridControl1_HoaDon
            // 
            this.gridControl1_HoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1_HoaDon.Location = new System.Drawing.Point(0, 26);
            this.gridControl1_HoaDon.MainView = this.gridView1_HoaDon;
            this.gridControl1_HoaDon.MenuManager = this.ribbonControl;
            this.gridControl1_HoaDon.Name = "gridControl1_HoaDon";
            this.gridControl1_HoaDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1_HoaDon.Size = new System.Drawing.Size(446, 425);
            this.gridControl1_HoaDon.TabIndex = 8;
            this.gridControl1_HoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1_HoaDon});
            // 
            // gridView1_HoaDon
            // 
            this.gridView1_HoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHo,
            this.colTen,
            this.colSDT,
            this.colMSBN,
            this.colMSKB,
            this.colMSHD,
            this.colMSDT,
            this.colDiaChi,
            this.colNamSinh,
            this.colChuanDoan,
            this.colXetNghiem,
            this.colKetQuaXetNghiem,
            this.colGhiChuDonThuoc,
            this.colGhiChuHSKB,
            this.colTienThuoc,
            this.colTienKham,
            this.collTongTien,
            this.colNgayTaiKham,
            this.colNgayKham,
            this.colBacSiKham,
            this.colKiemTraThanhToan,
            this.colKiemTraLayThuoc});
            this.gridView1_HoaDon.GridControl = this.gridControl1_HoaDon;
            this.gridView1_HoaDon.Name = "gridView1_HoaDon";
            this.gridView1_HoaDon.OptionsBehavior.Editable = false;
            this.gridView1_HoaDon.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1_HoaDon.OptionsFind.AlwaysVisible = true;
            this.gridView1_HoaDon.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKiemTraThanhToan, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1_HoaDon.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_HoaDon_RowClick);
            this.gridView1_HoaDon.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_HoaDon_CustomDrawRowIndicator);
            this.gridView1_HoaDon.RowCountChanged += new System.EventHandler(this.gridView1_HoaDon_RowCountChanged);
            // 
            // colHo
            // 
            this.colHo.Caption = "Họ";
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 0;
            this.colHo.Width = 215;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 143;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT Người thân";
            this.colSDT.FieldName = "SoDienThoai";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            this.colSDT.Width = 214;
            // 
            // colMSBN
            // 
            this.colMSBN.Caption = "MSBN";
            this.colMSBN.FieldName = "MaSoBenhNhan";
            this.colMSBN.Name = "colMSBN";
            // 
            // colMSKB
            // 
            this.colMSKB.Caption = "MSKB";
            this.colMSKB.FieldName = "MaSoKhamBenh";
            this.colMSKB.Name = "colMSKB";
            // 
            // colMSHD
            // 
            this.colMSHD.Caption = "MSHĐ";
            this.colMSHD.FieldName = "MaHoaDon";
            this.colMSHD.Name = "colMSHD";
            // 
            // colMSDT
            // 
            this.colMSDT.Caption = "MSĐT";
            this.colMSDT.FieldName = "MaSoDonThuoc";
            this.colMSDT.Name = "colMSDT";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colNamSinh
            // 
            this.colNamSinh.Caption = "Năm Sinh";
            this.colNamSinh.FieldName = "NamSinh";
            this.colNamSinh.Name = "colNamSinh";
            // 
            // colChuanDoan
            // 
            this.colChuanDoan.Caption = "Chuẩn đoán";
            this.colChuanDoan.FieldName = "ChuanDoan";
            this.colChuanDoan.Name = "colChuanDoan";
            // 
            // colXetNghiem
            // 
            this.colXetNghiem.Caption = "Xét Nghiệm";
            this.colXetNghiem.FieldName = "XetNghiem";
            this.colXetNghiem.Name = "colXetNghiem";
            // 
            // colKetQuaXetNghiem
            // 
            this.colKetQuaXetNghiem.Caption = "Kết quả xét nghiệm";
            this.colKetQuaXetNghiem.FieldName = "KetQuaXetNghiem";
            this.colKetQuaXetNghiem.Name = "colKetQuaXetNghiem";
            // 
            // colGhiChuDonThuoc
            // 
            this.colGhiChuDonThuoc.Caption = "Ghi Chú ĐT";
            this.colGhiChuDonThuoc.FieldName = "GhiChu";
            this.colGhiChuDonThuoc.Name = "colGhiChuDonThuoc";
            // 
            // colGhiChuHSKB
            // 
            this.colGhiChuHSKB.Caption = "Ghi chú HSKB";
            this.colGhiChuHSKB.FieldName = "GhiChu1";
            this.colGhiChuHSKB.Name = "colGhiChuHSKB";
            // 
            // colTienThuoc
            // 
            this.colTienThuoc.Caption = "Tiền Thuốc";
            this.colTienThuoc.FieldName = "TienThuoc";
            this.colTienThuoc.Name = "colTienThuoc";
            // 
            // colTienKham
            // 
            this.colTienKham.Caption = "Tiền Khám";
            this.colTienKham.FieldName = "TienKham";
            this.colTienKham.Name = "colTienKham";
            // 
            // collTongTien
            // 
            this.collTongTien.Caption = "Tổng tiền";
            this.collTongTien.FieldName = "TongTien";
            this.collTongTien.Name = "collTongTien";
            // 
            // colNgayTaiKham
            // 
            this.colNgayTaiKham.Caption = "Ngày Tái Khám";
            this.colNgayTaiKham.FieldName = "NgayTaiKham";
            this.colNgayTaiKham.Name = "colNgayTaiKham";
            // 
            // colNgayKham
            // 
            this.colNgayKham.Caption = "Ngày Khám";
            this.colNgayKham.FieldName = "NgayGioKham";
            this.colNgayKham.Name = "colNgayKham";
            // 
            // colBacSiKham
            // 
            this.colBacSiKham.Caption = "Bác Sĩ";
            this.colBacSiKham.FieldName = "TenNhanVien";
            this.colBacSiKham.Name = "colBacSiKham";
            // 
            // colKiemTraThanhToan
            // 
            this.colKiemTraThanhToan.Caption = "Thanh toán";
            this.colKiemTraThanhToan.FieldName = "KiemTraThanhToan";
            this.colKiemTraThanhToan.Name = "colKiemTraThanhToan";
            this.colKiemTraThanhToan.Visible = true;
            this.colKiemTraThanhToan.VisibleIndex = 3;
            this.colKiemTraThanhToan.Width = 120;
            // 
            // colKiemTraLayThuoc
            // 
            this.colKiemTraLayThuoc.Caption = "Lấy thuốc";
            this.colKiemTraLayThuoc.FieldName = "KiemTraLayThuoc";
            this.colKiemTraLayThuoc.Name = "colKiemTraLayThuoc";
            this.colKiemTraLayThuoc.Visible = true;
            this.colKiemTraLayThuoc.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gridControl1_HoaDon);
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 451);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách bệnh nhân khám trong ngày";
            // 
            // NhanVienThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.HtmlText = "Nhân viên Thu Ngân";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NhanVienThuNgan";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVienThuNgan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_ThanhToan;
        private System.Windows.Forms.CheckBox chBox_LayThuoc;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_DangXuat;
        private DevExpress.XtraGrid.GridControl gridControl1_HoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1_HoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMSKB;
        private DevExpress.XtraGrid.Columns.GridColumn colMSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn colXetNghiem;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQuaXetNghiem;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChuDonThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChuHSKB;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTienKham;
        private DevExpress.XtraGrid.Columns.GridColumn collTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKham;
        private DevExpress.XtraGrid.Columns.GridColumn colMSHD;
        private DevExpress.XtraGrid.Columns.GridColumn colBacSiKham;
        private DevExpress.XtraGrid.Columns.GridColumn colMSBN;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn colKiemTraThanhToan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_XuatFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colKiemTraLayThuoc;
    }
}