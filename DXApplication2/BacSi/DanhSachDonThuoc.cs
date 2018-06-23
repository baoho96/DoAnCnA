using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyPhongKham
{
    public partial class DanhSachDonThuoc : Form
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        BindingSource bindingSource = new BindingSource();
        #endregion
        #region Biến khởi tạo
        int ID_MSKB = NhanVien.ID_MSKB_DoubleClick;
        #endregion
        public DanhSachDonThuoc()
        {
            InitializeComponent();            
        }
        private void DanhSachDonThuoc_Load(object sender, EventArgs e)
        {
            Load_DanhSachDonThuoc();
        }
        #region Chức năng chung
        private void Load_DanhSachDonThuoc()
        {
            string query = @"SELECT DanhSachThuoc.MaSoDonThuoc, DanhSachThuoc.MaSoThuoc, DanhSachThuoc.CachDung, "+
                                " DanhSachThuoc.SoLuong, Thuoc.TenThuoc, LoaiThuoc.TenLoaiThuoc "+
                             " FROM            DanhSachThuoc INNER JOIN "+
                             " Thuoc ON DanhSachThuoc.MaSoThuoc = Thuoc.MaSoThuoc INNER JOIN " +
                             " LoaiThuoc ON Thuoc.MaSoLoaiThuoc = LoaiThuoc.MaSoLoaiThuoc INNER JOIN" +
                             " DonThuoc ON DanhSachThuoc.MaSoDonThuoc = DonThuoc.MaSoDonThuoc"+
                             " where DanhSachThuoc.MaSoDonThuoc = "+XemHoSoBenhNhan.MSDT;
            connection.connect();
            da = new SqlDataAdapter(query, connection.con);
            ds.Clear();
            da.Fill(ds, "DanhSachThuoc");
            bindingSource.DataSource = ds.Tables["DanhSachThuoc"];
            gridControl1_HoSoTaiKham.DataSource = bindingSource;
            connection.disconnect();
        }
        #endregion
    }
}
