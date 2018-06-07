namespace QuanLyPhongKham
{
    partial class BenhNhanKhamTrongNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenhNhanKhamTrongNgay));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1_filekhac = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2_excel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1_BenhNhanKhamTrongNgay = new DevExpress.XtraGrid.GridControl();
            this.gridView1_BenhNhanKhamTrongNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1_MSKB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2_MSBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3_Ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5_NgayTaiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6_NamSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8_XetNghiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9_KQXN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10_ChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_LiDoKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1_TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_BenhNhanKhamTrongNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_BenhNhanKhamTrongNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1_filekhac,
            this.barButtonItem2_excel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Left;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(872, 85);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1_filekhac
            // 
            this.barButtonItem1_filekhac.Caption = "Xuất file khác";
            this.barButtonItem1_filekhac.Id = 1;
            this.barButtonItem1_filekhac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_filekhac.ImageOptions.Image")));
            this.barButtonItem1_filekhac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_filekhac.ImageOptions.LargeImage")));
            this.barButtonItem1_filekhac.Name = "barButtonItem1_filekhac";
            this.barButtonItem1_filekhac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_filekhac_ItemClick);
            // 
            // barButtonItem2_excel
            // 
            this.barButtonItem2_excel.Caption = "Excel";
            this.barButtonItem2_excel.Id = 2;
            this.barButtonItem2_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2_excel.ImageOptions.Image")));
            this.barButtonItem2_excel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2_excel.ImageOptions.LargeImage")));
            this.barButtonItem2_excel.Name = "barButtonItem2_excel";
            this.barButtonItem2_excel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_excel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Print";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1_filekhac);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2_excel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(872, 23);
            // 
            // gridControl1_BenhNhanKhamTrongNgay
            // 
            this.gridControl1_BenhNhanKhamTrongNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_BenhNhanKhamTrongNgay.Location = new System.Drawing.Point(0, 85);
            this.gridControl1_BenhNhanKhamTrongNgay.MainView = this.gridView1_BenhNhanKhamTrongNgay;
            this.gridControl1_BenhNhanKhamTrongNgay.MenuManager = this.ribbon;
            this.gridControl1_BenhNhanKhamTrongNgay.Name = "gridControl1_BenhNhanKhamTrongNgay";
            this.gridControl1_BenhNhanKhamTrongNgay.Size = new System.Drawing.Size(872, 491);
            this.gridControl1_BenhNhanKhamTrongNgay.TabIndex = 2;
            this.gridControl1_BenhNhanKhamTrongNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1_BenhNhanKhamTrongNgay});
            // 
            // gridView1_BenhNhanKhamTrongNgay
            // 
            this.gridView1_BenhNhanKhamTrongNgay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1_MSKB,
            this.gridColumn2_MSBN,
            this.gridColumn3_Ho,
            this.gridColumn4_Ten,
            this.gridColumn5_NgayTaiKham,
            this.gridColumn6_NamSinh,
            this.gridColumn8_XetNghiem,
            this.gridColumn9_KQXN,
            this.gridColumn10_ChuanDoan,
            this.gridColumn1_GhiChu,
            this.gridColumn1_LiDoKham,
            this.gridColumn1_TenNhanVien});
            this.gridView1_BenhNhanKhamTrongNgay.GridControl = this.gridControl1_BenhNhanKhamTrongNgay;
            this.gridView1_BenhNhanKhamTrongNgay.Name = "gridView1_BenhNhanKhamTrongNgay";
            this.gridView1_BenhNhanKhamTrongNgay.OptionsBehavior.Editable = false;
            this.gridView1_BenhNhanKhamTrongNgay.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1_MSKB
            // 
            this.gridColumn1_MSKB.Caption = "MSKB";
            this.gridColumn1_MSKB.FieldName = "MaSoKhamBenh";
            this.gridColumn1_MSKB.Name = "gridColumn1_MSKB";
            this.gridColumn1_MSKB.Visible = true;
            this.gridColumn1_MSKB.VisibleIndex = 0;
            this.gridColumn1_MSKB.Width = 40;
            // 
            // gridColumn2_MSBN
            // 
            this.gridColumn2_MSBN.Caption = "MSBN";
            this.gridColumn2_MSBN.FieldName = "MaSoBenhNhan";
            this.gridColumn2_MSBN.Name = "gridColumn2_MSBN";
            this.gridColumn2_MSBN.Visible = true;
            this.gridColumn2_MSBN.VisibleIndex = 1;
            this.gridColumn2_MSBN.Width = 43;
            // 
            // gridColumn3_Ho
            // 
            this.gridColumn3_Ho.Caption = "Họ";
            this.gridColumn3_Ho.FieldName = "Ho";
            this.gridColumn3_Ho.Name = "gridColumn3_Ho";
            this.gridColumn3_Ho.Visible = true;
            this.gridColumn3_Ho.VisibleIndex = 2;
            this.gridColumn3_Ho.Width = 66;
            // 
            // gridColumn4_Ten
            // 
            this.gridColumn4_Ten.Caption = "Tên";
            this.gridColumn4_Ten.FieldName = "Ten";
            this.gridColumn4_Ten.Name = "gridColumn4_Ten";
            this.gridColumn4_Ten.Visible = true;
            this.gridColumn4_Ten.VisibleIndex = 3;
            this.gridColumn4_Ten.Width = 66;
            // 
            // gridColumn5_NgayTaiKham
            // 
            this.gridColumn5_NgayTaiKham.Caption = "Ngày tái khám";
            this.gridColumn5_NgayTaiKham.FieldName = "NgayTaiKham";
            this.gridColumn5_NgayTaiKham.Name = "gridColumn5_NgayTaiKham";
            this.gridColumn5_NgayTaiKham.Visible = true;
            this.gridColumn5_NgayTaiKham.VisibleIndex = 6;
            this.gridColumn5_NgayTaiKham.Width = 66;
            // 
            // gridColumn6_NamSinh
            // 
            this.gridColumn6_NamSinh.Caption = "Ngày sinh";
            this.gridColumn6_NamSinh.FieldName = "NamSinh";
            this.gridColumn6_NamSinh.Name = "gridColumn6_NamSinh";
            this.gridColumn6_NamSinh.Visible = true;
            this.gridColumn6_NamSinh.VisibleIndex = 4;
            this.gridColumn6_NamSinh.Width = 66;
            // 
            // gridColumn8_XetNghiem
            // 
            this.gridColumn8_XetNghiem.Caption = "Xét nghiệm";
            this.gridColumn8_XetNghiem.FieldName = "XetNghiem";
            this.gridColumn8_XetNghiem.Name = "gridColumn8_XetNghiem";
            this.gridColumn8_XetNghiem.Visible = true;
            this.gridColumn8_XetNghiem.VisibleIndex = 7;
            this.gridColumn8_XetNghiem.Width = 66;
            // 
            // gridColumn9_KQXN
            // 
            this.gridColumn9_KQXN.Caption = "Kết quả";
            this.gridColumn9_KQXN.FieldName = "KetQuaXetNghiem";
            this.gridColumn9_KQXN.Name = "gridColumn9_KQXN";
            this.gridColumn9_KQXN.Visible = true;
            this.gridColumn9_KQXN.VisibleIndex = 8;
            this.gridColumn9_KQXN.Width = 66;
            // 
            // gridColumn10_ChuanDoan
            // 
            this.gridColumn10_ChuanDoan.Caption = "Chuẩn đoán";
            this.gridColumn10_ChuanDoan.FieldName = "ChuanDoan";
            this.gridColumn10_ChuanDoan.Name = "gridColumn10_ChuanDoan";
            this.gridColumn10_ChuanDoan.Visible = true;
            this.gridColumn10_ChuanDoan.VisibleIndex = 9;
            this.gridColumn10_ChuanDoan.Width = 66;
            // 
            // gridColumn1_GhiChu
            // 
            this.gridColumn1_GhiChu.Caption = "Ghi chú";
            this.gridColumn1_GhiChu.FieldName = "GhiChu";
            this.gridColumn1_GhiChu.Name = "gridColumn1_GhiChu";
            this.gridColumn1_GhiChu.Visible = true;
            this.gridColumn1_GhiChu.VisibleIndex = 10;
            this.gridColumn1_GhiChu.Width = 66;
            // 
            // gridColumn1_LiDoKham
            // 
            this.gridColumn1_LiDoKham.Caption = "Lí do khám";
            this.gridColumn1_LiDoKham.FieldName = "LiDoKham";
            this.gridColumn1_LiDoKham.Name = "gridColumn1_LiDoKham";
            this.gridColumn1_LiDoKham.Visible = true;
            this.gridColumn1_LiDoKham.VisibleIndex = 5;
            this.gridColumn1_LiDoKham.Width = 66;
            // 
            // gridColumn1_TenNhanVien
            // 
            this.gridColumn1_TenNhanVien.Caption = "Bác sĩ";
            this.gridColumn1_TenNhanVien.FieldName = "TenNhanVien";
            this.gridColumn1_TenNhanVien.Name = "gridColumn1_TenNhanVien";
            this.gridColumn1_TenNhanVien.Visible = true;
            this.gridColumn1_TenNhanVien.VisibleIndex = 11;
            this.gridColumn1_TenNhanVien.Width = 79;
            // 
            // BenhNhanKhamTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 599);
            this.Controls.Add(this.gridControl1_BenhNhanKhamTrongNgay);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BenhNhanKhamTrongNgay";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Bệnh Nhân khám trong ngày";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_BenhNhanKhamTrongNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_BenhNhanKhamTrongNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_filekhac;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2_excel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1_BenhNhanKhamTrongNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1_BenhNhanKhamTrongNgay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_MSKB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2_MSBN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3_Ho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5_NgayTaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6_NamSinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8_XetNghiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9_KQXN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10_ChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_LiDoKham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_TenNhanVien;
    }
}