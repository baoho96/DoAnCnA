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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.label17 = new System.Windows.Forms.Label();
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_InHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.label17);
            this.panelControl6.Controls.Add(this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl6.Location = new System.Drawing.Point(0, 293);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1008, 368);
            this.panelControl6.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label17.Location = new System.Drawing.Point(2, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 19);
            this.label17.TabIndex = 1;
            this.label17.Text = "Bệnh nhân đã khám trong ngày";
            // 
            // TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham
            // 
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Location = new System.Drawing.Point(2, 24);
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.MainView = this.gridView1;
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Name = "TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham";
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Size = new System.Drawing.Size(1004, 342);
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.TabIndex = 0;
            this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham;
            this.gridView1.Name = "gridView1";
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Location = new System.Drawing.Point(604, 52);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(114, 49);
            this.btn_InHoaDon.TabIndex = 22;
            this.btn_InHoaDon.Text = "In hóa đơn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(604, 107);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 45);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Xem Báo Cáo";
            // 
            // NhanVienThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.panelControl6);
            this.MaximizeBox = false;
            this.Name = "NhanVienThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên Thu Ngân";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl6;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.GridControl TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_InHoaDon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}