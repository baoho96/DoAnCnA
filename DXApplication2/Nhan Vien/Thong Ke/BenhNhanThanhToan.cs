using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
namespace QuanLyPhongKham
{
    public partial class BenhNhanThanhToan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        reportDonThuoc reportDonThuoc = new reportDonThuoc();
        DataSet dataSet = new DataSet();
        DangNhap dangNhap = new DangNhap();
        DialogResult result;
        #endregion
        #region Biến khởi tạo
        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
        public string XemBenhNhan;
        public int checkColumn;
        #endregion

        public BenhNhanThanhToan()
        {
            InitializeComponent();
        }
        public BenhNhanThanhToan(string _XemBenhNhan,int _checkColumn) :this()//sử dụng constructor để truyền dữ liệu
        {
            XemBenhNhan = _XemBenhNhan;
            checkColumn = _checkColumn;//0 là thu ngân. 1: giao thuốc
            if(checkColumn == 0)
            {                
                col_KiemTraDaLayThuoc.Visible = false;
            }
            else if(checkColumn ==1 )
            {
                col_KiemTraThanhToan.Visible = false;
                col_KiemTraLayThuoc.Visible = false;
            }
            Load_HoaDon(XemBenhNhan);
        }
        private void Load_HoaDon(string XemBenhNhan)
        {
            string query = @"select BN.MaSoBenhNhan,BN.Ten, BN.Ho, BN.SoDienThoai,BN.DiaChi,BN.NamSinh,HSKB.MaSoKhamBenh," +
                                    " DT.MaSoDonThuoc,DT.GhiChu,HSKB.XetNghiem,HSKB.ChuanDoan,HSKB.KetQuaXetNghiem," +
                                    " HSKB.GhiChu,NV.TenNhanVien,HD.MaHoaDon,HSKB.NgayGioKham,DT.TongTienThuoc," +
                                    " HSKB.TienKham,HD.TongTien,HSKB.NgayTaiKham,HD.KiemTraThanhToan,HD.KiemTraLayThuoc,HD.KiemTraDaLayThuoc" +
                            " from HoaDon HD join HoSoKhamBenh HSKB on HD.MaSoKhamBenh = HSKB.MaSoKhamBenh " +
                            " join BenhNhan BN on HSKB.MaSoBenhNhan = BN.MaSoBenhNhan" +
                            " join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien" +
                            " join DonThuoc DT on DT.MaSoDonThuoc = HD.MaSoDonThuoc" +
                            " where " + XemBenhNhan;//đưa câu truy vấn từ Form thu ngân or giao thuốc
            connection.connect();
            sqlDataAdapter = new SqlDataAdapter(query, connection.con);
            dataSet = new DataSet();
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet, "HoaDon");

            bindingSource.DataSource = dataSet.Tables["HoaDon"];
            gridControl1_HoaDon.DataSource = bindingSource;
            connection.disconnect();
        }

        private void barButtonItem1_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1_HoaDon.Print();
        }

        private void barButtonItem1_ToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            function.ToExcel(result,gridControl1_HoaDon);
        }

        private void gridView1_HoaDon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_HoaDon_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
    }
}