namespace QuanLyPhongKham
{
    partial class DanhSachDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachDonThuoc));
            this.gridControl1_HoSoTaiKham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaSoDonThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenLoaiThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaSoThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCachDung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoSoTaiKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1_HoSoTaiKham
            // 
            this.gridControl1_HoSoTaiKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_HoSoTaiKham.Location = new System.Drawing.Point(0, 0);
            this.gridControl1_HoSoTaiKham.MainView = this.gridView1;
            this.gridControl1_HoSoTaiKham.Name = "gridControl1_HoSoTaiKham";
            this.gridControl1_HoSoTaiKham.Size = new System.Drawing.Size(568, 373);
            this.gridControl1_HoSoTaiKham.TabIndex = 0;
            this.gridControl1_HoSoTaiKham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaSoDonThuoc,
            this.clTenLoaiThuoc,
            this.clMaSoThuoc,
            this.clTenThuoc,
            this.clSoLuong,
            this.clCachDung});
            this.gridView1.GridControl = this.gridControl1_HoSoTaiKham;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.ViewCaption = "Hồ Sơ Tái Khám";
            // 
            // clMaSoDonThuoc
            // 
            this.clMaSoDonThuoc.Caption = "Đơn thuốc";
            this.clMaSoDonThuoc.FieldName = "MaSoDonThuoc";
            this.clMaSoDonThuoc.Name = "clMaSoDonThuoc";
            this.clMaSoDonThuoc.Width = 82;
            // 
            // clTenLoaiThuoc
            // 
            this.clTenLoaiThuoc.Caption = "Tên Loại Thuốc";
            this.clTenLoaiThuoc.FieldName = "TenLoaiThuoc";
            this.clTenLoaiThuoc.Name = "clTenLoaiThuoc";
            this.clTenLoaiThuoc.Visible = true;
            this.clTenLoaiThuoc.VisibleIndex = 1;
            this.clTenLoaiThuoc.Width = 165;
            // 
            // clMaSoThuoc
            // 
            this.clMaSoThuoc.Caption = "Mã thuốc";
            this.clMaSoThuoc.FieldName = "MaSoThuoc";
            this.clMaSoThuoc.Name = "clMaSoThuoc";
            this.clMaSoThuoc.Visible = true;
            this.clMaSoThuoc.VisibleIndex = 0;
            this.clMaSoThuoc.Width = 86;
            // 
            // clTenThuoc
            // 
            this.clTenThuoc.Caption = "Tên Thuốc";
            this.clTenThuoc.FieldName = "TenThuoc";
            this.clTenThuoc.Name = "clTenThuoc";
            this.clTenThuoc.Visible = true;
            this.clTenThuoc.VisibleIndex = 2;
            this.clTenThuoc.Width = 165;
            // 
            // clSoLuong
            // 
            this.clSoLuong.Caption = "Số Lượng";
            this.clSoLuong.FieldName = "SoLuong";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Visible = true;
            this.clSoLuong.VisibleIndex = 3;
            this.clSoLuong.Width = 79;
            // 
            // clCachDung
            // 
            this.clCachDung.Caption = "Cách Dùng";
            this.clCachDung.FieldName = "CachDung";
            this.clCachDung.Name = "clCachDung";
            this.clCachDung.Visible = true;
            this.clCachDung.VisibleIndex = 4;
            this.clCachDung.Width = 262;
            // 
            // DanhSachDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.gridControl1_HoSoTaiKham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachDonThuoc";
            this.Text = "Danh Sách Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HoSoTaiKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1_HoSoTaiKham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clMaSoDonThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn clTenLoaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn clMaSoThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn clTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn clCachDung;
    }
}