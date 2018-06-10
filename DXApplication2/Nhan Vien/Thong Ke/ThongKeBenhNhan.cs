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
namespace QuanLyPhongKham
{
    public partial class ThongKeBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        function function = new function();
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        BenhNhan benhNhan = new BenhNhan();

        public static string TongSoLuong { get; set; }
        public static string TongTien { get; set; }
        public static string NhapNgay { get; set; }

        public ThongKeBenhNhan()
        {
            InitializeComponent();
        }

        private void Load_reportBenhNhan(string NhapNgay)
        {
            string query = @"select  BN.Ho, BN.Ten,BN.NamSinh,BN.DiaChi,HSKB.ChuanDoan,NV.TenNhanVien,"+
                            " HD.TongTien,SUBSTRING( HSKB.NgayGioKham,1,10) as NgayGioKham"+
                        " from BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan "+
                        " join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien join HoaDon HD on HSKB.MaSoKhamBenh = HD.MaSoKhamBenh" +
                        " where HD.NgayGioLap like N'%" + NhapNgay  + "%'";

            connection.connect();

            string Load_TongTien_TongKham = @"select  count(HD.MaHoaDon),sum(HD.TongTien)
                                                from BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan join NhanVien NV on BN.MaSoBenhNhan = NV.MaSoNhanVien join HoaDon HD on HSKB.MaSoKhamBenh = HD.MaSoKhamBenh
                                                    where HD.NgayGioLap like N'%" + NhapNgay + "'";
            DataTable dataTable = connection.SQL(Load_TongTien_TongKham);
            TongSoLuong = dataTable.Rows[0][0].ToString();
            TongTien = dataTable.Rows[0][1].ToString();

            dataSet = new DataSet();
            dataSet.Clear();
            //đổ dữ liệu vào dataAdapter
            sqlDataAdapter = new SqlDataAdapter(query, connection.con);
            sqlDataAdapter.Fill(dataSet, "HoaDon");
            benhNhan.DataSource = dataSet.Tables["HoaDon"];
            benhNhan.Bindata();
            connection.disconnect();
            //hiển thị report lên documentViewer1
            documentViewer1.PrintingSystem = benhNhan.PrintingSystem;
            benhNhan.CreateDocument();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (checkB_TimTheoThang.Checked == true)
            {
                NhapNgay = dtP_NhapNgay.Value.Month.ToString() + "/" + dtP_NhapNgay.Value.Year.ToString();
                Load_reportBenhNhan(NhapNgay);
            }
            else if (checkB_TimTheoNam.Checked == true)
            {
                NhapNgay = dtP_NhapNgay.Value.Year.ToString();
                Load_reportBenhNhan(NhapNgay);
            }
            else if (checkB_TimTheoNgay.Checked == true)
            {
                NhapNgay = dtP_NhapNgay.Text;
                Load_reportBenhNhan(NhapNgay);
            }
        }

        private void checkB_TimTheoNgay_Click(object sender, EventArgs e)
        {
            checkB_TimTheoThang.Checked = false;
            checkB_TimTheoNam.Checked = false;
        }

        private void checkB_TimTheoThang_Click(object sender, EventArgs e)
        {
            checkB_TimTheoNam.Checked = false;
            checkB_TimTheoNgay.Checked = false;
        }

        private void checkB_TimTheoNam_Click(object sender, EventArgs e)
        {
            checkB_TimTheoThang.Checked = false;
            checkB_TimTheoNgay.Checked = false;
        }
    }
}