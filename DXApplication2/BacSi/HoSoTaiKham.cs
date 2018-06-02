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
    public partial class HoSoTaiKham : Form
    {
        int ID_MSKB = NhanVien.ID_MSKB_DoubleClick;
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bindingSource = new BindingSource();
        public HoSoTaiKham()
        {
            InitializeComponent();
        }
        
        private void Load_HoSoTaiKham()
        {
            string query = @"select  DISTINCT   HSKB.MaSoKhamBenh,NV.TenNhanVien,HSKB.NgayGioKham, HSKB.XetNghiem, HSKB.ChuanDoan, HSKB.GhiChu, HSKB.LiDoKham"+
                            " from HoSoKhamBenh HSKB right join HoSoTaiKham HSTK on HSKB.MaSoKhamBenh ="+ ID_MSKB +
                            " left join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien";
            connection.connect();

            da = new SqlDataAdapter(query, connection.con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds,"HoSoKhamBenh");

            bindingSource.DataSource = ds.Tables["HoSoKhamBenh"];
            gridControl1_HoSoTaiKham.DataSource = bindingSource;
            connection.disconnect();
        }

        private void HoSoTaiKham_Load(object sender, EventArgs e)
        {
            Load_HoSoTaiKham();
        }
    }
}
