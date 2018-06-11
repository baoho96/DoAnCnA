namespace QuanLyPhongKham
{
    partial class DuocSi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuocSi));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_Toexcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XuatFile = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1_BenhNhanLayThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl_DanhSachBenhNhan = new DevExpress.XtraGrid.GridControl();
            this.gridView_DanhSachBenhNhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1_Ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4_LayThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LayThuocXong = new DevExpress.XtraEditors.SimpleButton();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.txt_capnhat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanhSachBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btn_DangXuat,
            this.barButtonItem1_Toexcel,
            this.btn_XuatFile,
            this.bbiRefresh,
            this.barButtonItem1_BenhNhanLayThuoc});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 28;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Left;
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1012, 130);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_DangXuat.Caption = "Đăng Xuất";
            this.btn_DangXuat.Id = 23;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // barButtonItem1_Toexcel
            // 
            this.barButtonItem1_Toexcel.Caption = "Xuất File Excel";
            this.barButtonItem1_Toexcel.Id = 24;
            this.barButtonItem1_Toexcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_Toexcel.ImageOptions.Image")));
            this.barButtonItem1_Toexcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_Toexcel.ImageOptions.LargeImage")));
            this.barButtonItem1_Toexcel.Name = "barButtonItem1_Toexcel";
            this.barButtonItem1_Toexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_Toexcel_ItemClick);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Caption = "Xuất File PDF";
            this.btn_XuatFile.Id = 25;
            this.btn_XuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatFile.ImageOptions.Image")));
            this.btn_XuatFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XuatFile.ImageOptions.LargeImage")));
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XuatFile_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 26;
            this.bbiRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.Image")));
            this.bbiRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRefresh.ImageOptions.LargeImage")));
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barButtonItem1_BenhNhanLayThuoc
            // 
            this.barButtonItem1_BenhNhanLayThuoc.Caption = "Bệnh Nhân đã lấy thuốc";
            this.barButtonItem1_BenhNhanLayThuoc.Id = 27;
            this.barButtonItem1_BenhNhanLayThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_BenhNhanLayThuoc.ImageOptions.Image")));
            this.barButtonItem1_BenhNhanLayThuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1_BenhNhanLayThuoc.ImageOptions.LargeImage")));
            this.barButtonItem1_BenhNhanLayThuoc.Name = "barButtonItem1_BenhNhanLayThuoc";
            this.barButtonItem1_BenhNhanLayThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_BenhNhanLayThuoc_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1_BenhNhanLayThuoc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1_Toexcel);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_XuatFile);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1012, 31);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_DanhSachBenhNhan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_LayThuocXong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 538);
            this.panel2.TabIndex = 5;
            // 
            // gridControl_DanhSachBenhNhan
            // 
            this.gridControl_DanhSachBenhNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl_DanhSachBenhNhan.Location = new System.Drawing.Point(0, 74);
            this.gridControl_DanhSachBenhNhan.MainView = this.gridView_DanhSachBenhNhan;
            this.gridControl_DanhSachBenhNhan.MenuManager = this.ribbonControl;
            this.gridControl_DanhSachBenhNhan.Name = "gridControl_DanhSachBenhNhan";
            this.gridControl_DanhSachBenhNhan.Size = new System.Drawing.Size(470, 464);
            this.gridControl_DanhSachBenhNhan.TabIndex = 4;
            this.gridControl_DanhSachBenhNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DanhSachBenhNhan});
            // 
            // gridView_DanhSachBenhNhan
            // 
            this.gridView_DanhSachBenhNhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1_Ho,
            this.gridColumn2_Ten,
            this.gridColumn3_SDT,
            this.gridColumn4_LayThuoc});
            this.gridView_DanhSachBenhNhan.GridControl = this.gridControl_DanhSachBenhNhan;
            this.gridView_DanhSachBenhNhan.Name = "gridView_DanhSachBenhNhan";
            this.gridView_DanhSachBenhNhan.OptionsBehavior.Editable = false;
            this.gridView_DanhSachBenhNhan.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView_DanhSachBenhNhan.OptionsFind.AlwaysVisible = true;
            this.gridView_DanhSachBenhNhan.OptionsView.ShowGroupPanel = false;
            this.gridView_DanhSachBenhNhan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4_LayThuoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_DanhSachBenhNhan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DanhSachBenhNhan_RowClick);
            this.gridView_DanhSachBenhNhan.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_DanhSachBenhNhan_CustomDrawRowIndicator);
            this.gridView_DanhSachBenhNhan.RowCountChanged += new System.EventHandler(this.gridView_DanhSachBenhNhan_RowCountChanged);
            // 
            // gridColumn1_Ho
            // 
            this.gridColumn1_Ho.Caption = "Họ";
            this.gridColumn1_Ho.FieldName = "Ho";
            this.gridColumn1_Ho.Name = "gridColumn1_Ho";
            this.gridColumn1_Ho.Visible = true;
            this.gridColumn1_Ho.VisibleIndex = 0;
            this.gridColumn1_Ho.Width = 365;
            // 
            // gridColumn2_Ten
            // 
            this.gridColumn2_Ten.Caption = "Tên";
            this.gridColumn2_Ten.FieldName = "Ten";
            this.gridColumn2_Ten.Name = "gridColumn2_Ten";
            this.gridColumn2_Ten.Visible = true;
            this.gridColumn2_Ten.VisibleIndex = 1;
            this.gridColumn2_Ten.Width = 146;
            // 
            // gridColumn3_SDT
            // 
            this.gridColumn3_SDT.Caption = "SĐT";
            this.gridColumn3_SDT.FieldName = "SoDienThoai";
            this.gridColumn3_SDT.Name = "gridColumn3_SDT";
            this.gridColumn3_SDT.Visible = true;
            this.gridColumn3_SDT.VisibleIndex = 2;
            this.gridColumn3_SDT.Width = 135;
            // 
            // gridColumn4_LayThuoc
            // 
            this.gridColumn4_LayThuoc.Caption = "Lấy thuốc";
            this.gridColumn4_LayThuoc.FieldName = "KiemTraDaLayThuoc";
            this.gridColumn4_LayThuoc.Name = "gridColumn4_LayThuoc";
            this.gridColumn4_LayThuoc.Visible = true;
            this.gridColumn4_LayThuoc.VisibleIndex = 3;
            this.gridColumn4_LayThuoc.Width = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách bệnh nhân khám trong ngày";
            // 
            // btn_LayThuocXong
            // 
            this.btn_LayThuocXong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_LayThuocXong.Appearance.Options.UseFont = true;
            this.btn_LayThuocXong.Enabled = false;
            this.btn_LayThuocXong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LayThuocXong.ImageOptions.Image")));
            this.btn_LayThuocXong.Location = new System.Drawing.Point(327, 26);
            this.btn_LayThuocXong.Name = "btn_LayThuocXong";
            this.btn_LayThuocXong.Size = new System.Drawing.Size(120, 36);
            this.btn_LayThuocXong.TabIndex = 0;
            this.btn_LayThuocXong.Text = "Lấy Thuốc Xong";
            this.btn_LayThuocXong.Click += new System.EventHandler(this.btn_LayThuocXong_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(486, 130);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(526, 538);
            this.documentViewer1.Status = "Xem trước đơn thuốc";
            this.documentViewer1.TabIndex = 8;
            this.documentViewer1.Zoom = 0.75F;
            // 
            // txt_capnhat
            // 
            this.txt_capnhat.Enabled = false;
            this.txt_capnhat.Location = new System.Drawing.Point(35, 670);
            this.txt_capnhat.Multiline = true;
            this.txt_capnhat.Name = "txt_capnhat";
            this.txt_capnhat.Size = new System.Drawing.Size(160, 23);
            this.txt_capnhat.TabIndex = 11;
            // 
            // DuocSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 699);
            this.Controls.Add(this.txt_capnhat);
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "DuocSi";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nhân viên Giao thuốc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuocSi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanhSachBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_LayThuocXong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private System.Windows.Forms.TextBox txt_capnhat;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_Toexcel;
        private DevExpress.XtraBars.BarButtonItem btn_XuatFile;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.GridControl gridControl_DanhSachBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DanhSachBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_Ho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4_LayThuoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_BenhNhanLayThuoc;
    }
}