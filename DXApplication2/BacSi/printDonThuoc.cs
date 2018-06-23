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
        #region Khởi tạo
        connection connection = new connection();        
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        reportDonThuoc reportDonThuoc = new reportDonThuoc();
        DataSet dataSet = new DataSet();
        #endregion
        public printDonThuoc()
        {
            InitializeComponent();
        }
        private void printDonThuoc_Load(object sender, EventArgs e)
        {
            Load_reportDonThuoc();
        }
        #region Chức năng chung
        private void Load_reportDonThuoc()
        {
            string Load_MSDT = @"select T.TenThuoc,T.DonViTinhNhoNhat,T.DonGiaNhoNhat,DST.SoLuong,DST.CachDung" +
                                " from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc " +
                                            " left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc " +
                                " where DT.MaSoKhamBenh = " + NhanVienThuNgan.ID_MSKB + " And DT.MaSoDonThuoc =" + NhanVienThuNgan.ID_MSDT;
            connection.connect();
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
        #endregion
    }
}