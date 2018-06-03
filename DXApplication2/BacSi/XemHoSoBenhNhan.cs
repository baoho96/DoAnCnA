using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace QuanLyPhongKham
{
    public partial class XemHoSoBenhNhan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        BindingSource bindingSource = new BindingSource();
        SqlCommand sqlCommand = new SqlCommand();
        public static int MSDT { get; set; }

        public XemHoSoBenhNhan()
        {
            InitializeComponent();
            //load_donthuoc();
        }
        private void load_donthuoc()
        {
            string query = @"SELECT DISTINCT 
                         HSKB.MaSoKhamBenh, HSKB.MaSoBenhNhan, BN.Ho, BN.Ten, BN.GioiTinh, BN.NamSinh, HSKB.NgayGioKham, HSKB.XetNghiem, HSKB.ChuanDoan, HSKB.TienKham, HSKB.NgayTaiKham, HSKB.GhiChu, 
                         HSKB.KiemTraKham, HSKB.LiDoKham, BN.DiaChi, BN.SoDienThoai, BN.HinhAnh, BN.CanNang, HSTK.MaSoTaiKham, HSKB.KiemTraTaiKham,NV.TenNhanVien
                        FROM            HoSoKhamBenh AS HSKB LEFT OUTER JOIN
                         BenhNhan AS BN ON BN.MaSoBenhNhan = HSKB.MaSoBenhNhan LEFT OUTER JOIN
                         HoSoTaiKham AS HSTK ON HSTK.MaSoKhamBenh = HSKB.MaSoKhamBenh
                        LEFT OUTER JOIN NhanVien AS NV on HSKB.MaSoBacSi = NV.MaSoNhanVien";
            connection.connect();
            sqlDataAdapter = new SqlDataAdapter(query, connection.con);
            dataSet = new DataSet();
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet, "HoSoKhamBenh");
            bindingSource.DataSource = dataSet.Tables["HoSoKhamBenh"];
            gridControl1_TimKiemBenhNhan.DataSource = bindingSource;
            connection.disconnect();
        }


        private void gridView1_TimKiemBenhNhan_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void XemHoSoBenhNhan_Load(object sender, EventArgs e)
        {
            phongKhamDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'phongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.phongKhamDataSet.DonThuoc);
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoTaiKham' table. You can move, or remove it, as needed.
            this.hoSoTaiKhamTableAdapter.Fill(this.phongKhamDataSet.HoSoTaiKham);
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoKhamBenh' table. You can move, or remove it, as needed.
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
        }

        private void btn_indanhsach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1_TimKiemBenhNhan.ShowRibbonPrintPreview();
        }

        private void gridView2_DonThuoc_DoubleClick(object sender, EventArgs e)
        {            
            DanhSachDonThuoc danhSachDonThuoc = new DanhSachDonThuoc();
            danhSachDonThuoc.ShowDialog();
        }

        private void gridControl1_TimKiemBenhNhan_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            MSDT=FocusedViewChanged(sender,e);
        }
        private int FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            GridControl gridControl = sender as GridControl;
            GridView gridView = gridControl.FocusedView as GridView;
            if (gridView != null)
                MSDT =int.Parse( gridView.GetFocusedRowCellValue(gridView.Columns[0]).ToString());
            return MSDT;
        }
    }
}