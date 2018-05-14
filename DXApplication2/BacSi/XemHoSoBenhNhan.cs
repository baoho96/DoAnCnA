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
    public partial class XemHoSoBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        BindingSource bindingSource = new BindingSource();
        SqlCommand sqlCommand = new SqlCommand();
        public XemHoSoBenhNhan()
        {
            InitializeComponent();
            load_donthuoc();
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
    }
}