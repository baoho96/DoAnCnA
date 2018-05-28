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
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XuatFile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LayThuocXong = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_DanhSachBenhNhan = new DevExpress.XtraGrid.GridControl();
            this.gridView_DanhSachBenhNhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1_Ho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4_CheckLayThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanhSachBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanhSachBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.bbiRefresh,
            this.btn_DangXuat,
            this.btn_XuatFile});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1014, 143);
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
            // btn_DangXuat
            // 
            this.btn_DangXuat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_DangXuat.Caption = "Đăng Xuất";
            this.btn_DangXuat.Id = 20;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Caption = "Xuất File";
            this.btn_XuatFile.Id = 21;
            this.btn_XuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatFile.ImageOptions.Image")));
            this.btn_XuatFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XuatFile.ImageOptions.LargeImage")));
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XuatFile_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_XuatFile);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_LayThuocXong);
            this.panel2.Controls.Add(this.gridControl_DanhSachBenhNhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 525);
            this.panel2.TabIndex = 5;
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
            this.btn_LayThuocXong.Location = new System.Drawing.Point(304, 30);
            this.btn_LayThuocXong.Name = "btn_LayThuocXong";
            this.btn_LayThuocXong.Size = new System.Drawing.Size(120, 36);
            this.btn_LayThuocXong.TabIndex = 1;
            this.btn_LayThuocXong.Text = "Lấy Thuốc Xong";
            this.btn_LayThuocXong.Click += new System.EventHandler(this.btn_LayThuocXong_Click);
            // 
            // gridControl_DanhSachBenhNhan
            // 
            this.gridControl_DanhSachBenhNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl_DanhSachBenhNhan.Location = new System.Drawing.Point(0, 72);
            this.gridControl_DanhSachBenhNhan.MainView = this.gridView_DanhSachBenhNhan;
            this.gridControl_DanhSachBenhNhan.MenuManager = this.ribbonControl;
            this.gridControl_DanhSachBenhNhan.Name = "gridControl_DanhSachBenhNhan";
            this.gridControl_DanhSachBenhNhan.Size = new System.Drawing.Size(442, 453);
            this.gridControl_DanhSachBenhNhan.TabIndex = 0;
            this.gridControl_DanhSachBenhNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DanhSachBenhNhan});
            // 
            // gridView_DanhSachBenhNhan
            // 
            this.gridView_DanhSachBenhNhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1_Ho,
            this.gridColumn2_Ten,
            this.gridColumn3_SDT,
            this.gridColumn4_CheckLayThuoc});
            this.gridView_DanhSachBenhNhan.GridControl = this.gridControl_DanhSachBenhNhan;
            this.gridView_DanhSachBenhNhan.Name = "gridView_DanhSachBenhNhan";
            this.gridView_DanhSachBenhNhan.OptionsBehavior.Editable = false;
            this.gridView_DanhSachBenhNhan.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView_DanhSachBenhNhan.OptionsFind.AlwaysVisible = true;
            this.gridView_DanhSachBenhNhan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4_CheckLayThuoc, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.gridColumn1_Ho.Width = 173;
            // 
            // gridColumn2_Ten
            // 
            this.gridColumn2_Ten.Caption = "Tên";
            this.gridColumn2_Ten.FieldName = "Ten";
            this.gridColumn2_Ten.Name = "gridColumn2_Ten";
            this.gridColumn2_Ten.Visible = true;
            this.gridColumn2_Ten.VisibleIndex = 1;
            this.gridColumn2_Ten.Width = 247;
            // 
            // gridColumn3_SDT
            // 
            this.gridColumn3_SDT.Caption = "SĐT Người thân";
            this.gridColumn3_SDT.FieldName = "SoDienThoai";
            this.gridColumn3_SDT.Name = "gridColumn3_SDT";
            this.gridColumn3_SDT.Visible = true;
            this.gridColumn3_SDT.VisibleIndex = 2;
            this.gridColumn3_SDT.Width = 151;
            // 
            // gridColumn4_CheckLayThuoc
            // 
            this.gridColumn4_CheckLayThuoc.Caption = "Lấy thuốc";
            this.gridColumn4_CheckLayThuoc.FieldName = "KiemTraDaLayThuoc";
            this.gridColumn4_CheckLayThuoc.Name = "gridColumn4_CheckLayThuoc";
            this.gridColumn4_CheckLayThuoc.Visible = true;
            this.gridColumn4_CheckLayThuoc.VisibleIndex = 3;
            this.gridColumn4_CheckLayThuoc.Width = 121;
            // 
            // documentViewer1
            // 
            this.documentViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(442, 143);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(572, 525);
            this.documentViewer1.TabIndex = 8;
            // 
            // DuocSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 699);
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DuocSi";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Dược Sĩ";
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
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl_DanhSachBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DanhSachBenhNhan;
        private DevExpress.XtraEditors.SimpleButton btn_LayThuocXong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_XuatFile;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1_Ho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4_CheckLayThuoc;
    }
}