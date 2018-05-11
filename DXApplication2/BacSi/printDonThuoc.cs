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
    public partial class printDonThuoc : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        DataSet ds = new DataSet(); //khai báo dataset để truyền dữ liệu vào report
        SqlDataAdapter da = new SqlDataAdapter();
        reportDonThuoc reportDonThuoc = new reportDonThuoc();

        public printDonThuoc()
        {
            InitializeComponent();
        }

        private void printDonThuoc_Load(object sender, EventArgs e)
        {
            Load_reportDonThuoc();
        }
        private void Load_reportDonThuoc()
        {
            string Load_MSDT = @"select T.TenThuoc,T.DonViTinh,T.DonGia,DST.SoLuong,DST.CachDung" +
                                " from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc " +
                                            " left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc " +
                                " where DT.MaSoKhamBenh = " + DonThuoc.ID_MSKB + " And DT.MaSoDonThuoc =" + DonThuoc.ID_MSDT;
            connection.connect();
            ds.Clear();
            //đổ dữ liệu vào dataAdapter
            da = new SqlDataAdapter(Load_MSDT, connection.con);
            da.Fill(ds, "DonThuoc");
            reportDonThuoc.DataSource = ds.Tables["DonThuoc"];
            reportDonThuoc.Bindata();
            connection.disconnect();
            //hiển thị report lên documentViewer1
            documentViewer1.PrintingSystem = reportDonThuoc.PrintingSystem;
            reportDonThuoc.CreateDocument();
        }


        private void printDonThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonThuoc donThuoc = new DonThuoc();
            donThuoc.Show();
        }
    }
}