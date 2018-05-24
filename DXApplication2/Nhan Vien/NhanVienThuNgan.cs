using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace QuanLyPhongKham
{
    public partial class NhanVienThuNgan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        reportDonThuoc reportDonThuoc = new reportDonThuoc();
        SqlCommand sqlCommand;
        DataSet dataSet =new DataSet();
        DangNhap dangNhap = new DangNhap();

        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();

        public static int ID_MSDT { get; set; }
        public static int ID_MSKB { get; set; }
        public static int ID_MSHD { get; set; }
        public static int ID_MSBN { get; set; }

        public static string Ho { get; set; }
        public static string Ten { get; set; }
        public static string NamSinh { get; set; }
        public static string SDT { get; set; }
        public static string DiaChi { get; set; }

        public static string YeuCauXetNghiem { get; set; }
        public static string KetQuaXetNghiem { get; set; }
        public static string ChuanDoan { get; set; }
        public static string GhiChuHSKB { get; set; }
        public static string GhiChuHSDT { get; set; }
        public static string NgayKham { get; set; }
        public static string NgayTaiKham { get; set; }
        public static string TienThuoc { get; set; }
        public static string TienKham { get; set; }
        public static string TongTien { get; set; }
        public static string BacSiKham { get; set; }

        public static string NguoiLap { get; set; }

        public NhanVienThuNgan()
        {
            InitializeComponent();
            Load_HoaDon();

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1_HoaDon.ShowRibbonPrintPreview();
        }
        private void refresh_HoaDon()
        {
            dataSet.Clear();
            gridControl1_HoaDon.Refresh();
            gridView1_HoaDon.RefreshData();
            documentViewer1.Refresh();
            Load_HoaDon();
        }
        private void Load_HoaDon()
        {
            NguoiLap = DangNhap.TenBacSi;//Tên nhân viên
            
            string query = @"select BN.MaSoBenhNhan,BN.Ten, BN.Ho, BN.SoDienThoai,BN.DiaChi,BN.NamSinh,HSKB.MaSoKhamBenh," +
                                    " DT.MaSoDonThuoc,DT.GhiChu,HSKB.XetNghiem,HSKB.ChuanDoan,HSKB.KetQuaXetNghiem,"+
                                    " HSKB.GhiChu,NV.TenNhanVien,HD.MaHoaDon,HSKB.NgayGioKham,DT.TongTienThuoc,"+
                                    " HSKB.TienKham,HD.TongTien,HSKB.NgayTaiKham,HD.KiemTraThanhToan" +
                            " from HoaDon HD join HoSoKhamBenh HSKB on HD.MaSoKhamBenh = HSKB.MaSoKhamBenh " +
                            " join BenhNhan BN on HSKB.MaSoBenhNhan = BN.MaSoBenhNhan" +
                            " join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien" +
                            " join DonThuoc DT on DT.MaSoDonThuoc = HD.MaSoDonThuoc" +
                            " where HD.NgayGioLap like '" + ngay + "/" + thang + "/" + nam + "'";
            connection.connect();
            sqlDataAdapter = new SqlDataAdapter(query,connection.con);
            dataSet = new DataSet();
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet,"HoaDon");
            
            bindingSource.DataSource = dataSet.Tables["HoaDon"];
            gridControl1_HoaDon.DataSource = bindingSource;
            connection.disconnect();
        }
        private void Load_reportDonThuoc()
        {
            string Load_MSDT = @"select T.TenThuoc,T.DonViTinhNhoNhat,T.DonGiaNhoNhat,DST.SoLuong,DST.CachDung" +
                                " from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc " +
                                            " left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc " +
                                " where DT.MaSoKhamBenh = " + ID_MSKB + " And DT.MaSoDonThuoc =" + ID_MSDT;
            connection.connect();
            dataSet = new DataSet();
            dataSet.Clear();
            //đổ dữ liệu vào dataAdapter
            sqlDataAdapter = new SqlDataAdapter(Load_MSDT, connection.con);
            sqlDataAdapter.Fill(dataSet, "DonThuoc");
            reportDonThuoc.DataSource = dataSet.Tables["DonThuoc"];
            reportDonThuoc.Bindata();
            connection.disconnect();
            //hiển thị report lên documentViewer1
            documentViewer1.PrintingSystem = reportDonThuoc.PrintingSystem;
            reportDonThuoc.CreateDocument();
        }
        private void gridView1_HoaDon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender,e);
        }
        private void gridView1_HoaDon_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void gridView1_HoaDon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            panel1.Enabled = true;
            ID_MSDT = int.Parse(gridView1_HoaDon.GetFocusedRowCellValue("MaSoDonThuoc").ToString());
            ID_MSKB = int.Parse(gridView1_HoaDon.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            ID_MSHD = int.Parse(gridView1_HoaDon.GetFocusedRowCellValue("MaHoaDon").ToString());
            ID_MSBN = int.Parse(gridView1_HoaDon.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
            Ho = gridView1_HoaDon.GetFocusedRowCellValue("Ho").ToString();
            Ten = gridView1_HoaDon.GetFocusedRowCellValue("Ten").ToString();
            NamSinh = gridView1_HoaDon.GetFocusedRowCellValue("NamSinh").ToString();
            SDT = gridView1_HoaDon.GetFocusedRowCellValue("SoDienThoai").ToString();
            DiaChi = gridView1_HoaDon.GetFocusedRowCellValue("DiaChi").ToString();

            YeuCauXetNghiem = gridView1_HoaDon.GetFocusedRowCellValue("XetNghiem").ToString();
            KetQuaXetNghiem = gridView1_HoaDon.GetFocusedRowCellValue("KetQuaXetNghiem").ToString();
            ChuanDoan = gridView1_HoaDon.GetFocusedRowCellValue("ChuanDoan").ToString();
            GhiChuHSDT = gridView1_HoaDon.GetFocusedRowCellValue("GhiChu").ToString();
            GhiChuHSKB = gridView1_HoaDon.GetFocusedRowCellValue("GhiChu1").ToString();
            NgayKham = gridView1_HoaDon.GetFocusedRowCellValue("NgayGioKham").ToString();
            NgayTaiKham = gridView1_HoaDon.GetFocusedRowCellValue("NgayTaiKham").ToString();
            TienThuoc = gridView1_HoaDon.GetFocusedRowCellValue("TongTienThuoc").ToString();
            TienKham = gridView1_HoaDon.GetFocusedRowCellValue("TienKham").ToString();
            TongTien = gridView1_HoaDon.GetFocusedRowCellValue("TongTien").ToString();
            BacSiKham = gridView1_HoaDon.GetFocusedRowCellValue("TenNhanVien").ToString();

            Load_reportDonThuoc();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            connection.connect();
            if (chBox_LayThuoc.Checked ==true)
            {
                string TongTien = @"update HoaDon set"+
                                    " TongTien = H.TongTien"+","+
                                    " KiemTraThanhToan = 1 "+","+
                                    " NgayGioLap = '" + ngay + "/" + thang + "/" + nam + "'"+
                                    " from (select sum(HSKB.TienKham+DT.TongTienThuoc) as TongTien" +
                                    " from HoSoKhamBenh HSKB join DonThuoc DT on HSKB.MaSoKhamBenh = DT.MaSoKhamBenh"+
                                       " where HSKB.MaSoKhamBenh = " + ID_MSKB +" And DT.MaSoDonThuoc= "+ID_MSDT +") H " +
                                       " where MaHoaDon =" +ID_MSHD;
                
                connection.sql(TongTien);
                
            }
            else
            {
                string TongTien = @"update HoaDon set" +
                                    " TongTien = H.TongTien" + "," +
                                    " KiemTraThanhToan = 1 " + "," +
                                    " NgayGioLap = '" + ngay + "/" + thang + "/" + nam + "'" +
                                    " from (select HSKB.TienKham as TongTien" +
                                    " from HoSoKhamBenh HSKB join DonThuoc DT on HSKB.MaSoKhamBenh = DT.MaSoKhamBenh" +
                                       " where HSKB.MaSoKhamBenh = " + ID_MSKB + " And DT.MaSoDonThuoc= " + ID_MSDT + ") H " +
                                       " where MaHoaDon =" + ID_MSHD;

                connection.sql(TongTien);
            }
            connection.disconnect();
            refresh_HoaDon();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            refresh_HoaDon();
        }
    }
}