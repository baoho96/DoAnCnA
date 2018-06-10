namespace QuanLyPhongKham
{
    partial class ThemLoaiThuoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLoaiThuoc));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tenloaithuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridC_danhsachloaithuoc = new DevExpress.XtraGrid.GridControl();
            this.loaiThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongKhamDataSet = new QuanLyPhongKham.PhongKhamDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSoLoaiThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSoLoaiThuoc1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTenLoaiThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiThuoc1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.loaiThuocTableAdapter = new QuanLyPhongKham.PhongKhamDataSetTableAdapters.LoaiThuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_danhsachloaithuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaSoLoaiThuoc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenLoaiThuoc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGhiChu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label17);
            this.panelControl1.Controls.Add(this.btn_xoa);
            this.panelControl1.Controls.Add(this.btn_capnhat);
            this.panelControl1.Controls.Add(this.btn_themmoi);
            this.panelControl1.Controls.Add(this.txt_ghichu);
            this.panelControl1.Controls.Add(this.txt_tenloaithuoc);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 122);
            this.panelControl1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(2, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Loại thuốc";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(405, 81);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Enabled = false;
            this.btn_capnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhat.ImageOptions.Image")));
            this.btn_capnhat.Location = new System.Drawing.Point(324, 81);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 36);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_themmoi.ImageOptions.Image")));
            this.btn_themmoi.Location = new System.Drawing.Point(243, 81);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 36);
            this.btn_themmoi.TabIndex = 2;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(122, 54);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(336, 21);
            this.txt_ghichu.TabIndex = 1;
            // 
            // txt_tenloaithuoc
            // 
            this.txt_tenloaithuoc.Location = new System.Drawing.Point(122, 27);
            this.txt_tenloaithuoc.Name = "txt_tenloaithuoc";
            this.txt_tenloaithuoc.Size = new System.Drawing.Size(336, 21);
            this.txt_tenloaithuoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại thuốc";
            // 
            // gridC_danhsachloaithuoc
            // 
            this.gridC_danhsachloaithuoc.DataSource = this.loaiThuocBindingSource;
            this.gridC_danhsachloaithuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridC_danhsachloaithuoc.Location = new System.Drawing.Point(2, 21);
            this.gridC_danhsachloaithuoc.MainView = this.gridView1;
            this.gridC_danhsachloaithuoc.Name = "gridC_danhsachloaithuoc";
            this.gridC_danhsachloaithuoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colMaSoLoaiThuoc1,
            this.colTenLoaiThuoc1,
            this.colGhiChu1});
            this.gridC_danhsachloaithuoc.Size = new System.Drawing.Size(488, 215);
            this.gridC_danhsachloaithuoc.TabIndex = 1;
            this.gridC_danhsachloaithuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loaiThuocBindingSource
            // 
            this.loaiThuocBindingSource.DataMember = "LoaiThuoc";
            this.loaiThuocBindingSource.DataSource = this.phongKhamDataSet;
            // 
            // phongKhamDataSet
            // 
            this.phongKhamDataSet.DataSetName = "PhongKhamDataSet";
            this.phongKhamDataSet.EnforceConstraints = false;
            this.phongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSoLoaiThuoc,
            this.colTenLoaiThuoc,
            this.colGhiChu});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridC_danhsachloaithuoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenLoaiThuoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaSoLoaiThuoc
            // 
            this.colMaSoLoaiThuoc.Caption = "Mã số loại thuốc";
            this.colMaSoLoaiThuoc.ColumnEdit = this.colMaSoLoaiThuoc1;
            this.colMaSoLoaiThuoc.FieldName = "MaSoLoaiThuoc";
            this.colMaSoLoaiThuoc.Name = "colMaSoLoaiThuoc";
            this.colMaSoLoaiThuoc.Visible = true;
            this.colMaSoLoaiThuoc.VisibleIndex = 0;
            // 
            // colMaSoLoaiThuoc1
            // 
            this.colMaSoLoaiThuoc1.AutoHeight = false;
            this.colMaSoLoaiThuoc1.Name = "colMaSoLoaiThuoc1";
            // 
            // colTenLoaiThuoc
            // 
            this.colTenLoaiThuoc.Caption = "Tên loại thuốc";
            this.colTenLoaiThuoc.ColumnEdit = this.colTenLoaiThuoc1;
            this.colTenLoaiThuoc.FieldName = "TenLoaiThuoc";
            this.colTenLoaiThuoc.Name = "colTenLoaiThuoc";
            this.colTenLoaiThuoc.Visible = true;
            this.colTenLoaiThuoc.VisibleIndex = 1;
            // 
            // colTenLoaiThuoc1
            // 
            this.colTenLoaiThuoc1.AutoHeight = false;
            this.colTenLoaiThuoc1.Name = "colTenLoaiThuoc1";
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.ColumnEdit = this.colGhiChu1;
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // colGhiChu1
            // 
            this.colGhiChu1.AutoHeight = false;
            this.colGhiChu1.Name = "colGhiChu1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.gridC_danhsachloaithuoc);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 123);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(492, 238);
            this.panelControl2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách loại thuốc";
            // 
            // loaiThuocTableAdapter
            // 
            this.loaiThuocTableAdapter.ClearBeforeFill = true;
            // 
            // ThemLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 361);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemLoaiThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Loại thuốc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemLoaiThuoc_FormClosed);
            this.Load += new System.EventHandler(this.ThemLoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_danhsachloaithuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaSoLoaiThuoc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenLoaiThuoc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGhiChu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_capnhat;
        private DevExpress.XtraEditors.SimpleButton btn_themmoi;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tenloaithuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridC_danhsachloaithuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label3;
        
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoLoaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colMaSoLoaiThuoc1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colTenLoaiThuoc1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colGhiChu1;
        private PhongKhamDataSet phongKhamDataSet;
        private System.Windows.Forms.BindingSource loaiThuocBindingSource;
        private PhongKhamDataSetTableAdapters.LoaiThuocTableAdapter loaiThuocTableAdapter;
    }
}