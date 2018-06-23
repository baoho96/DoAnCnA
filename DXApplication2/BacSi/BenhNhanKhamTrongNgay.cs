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
    public partial class BenhNhanKhamTrongNgay : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        BindingSource bindingSource = new BindingSource();
        DataSet dataSet = new DataSet();
        DialogResult result;
        #endregion
        #region Biến khởi tạo
        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
        #endregion
        public BenhNhanKhamTrongNgay()
        {
            InitializeComponent();            
        }
        private void BenhNhanKhamTrongNgay_Load(object sender, EventArgs e)
        {
            Load_HoSoKhamBenh();
        }
        #region Chức năng chung
        private void Load_HoSoKhamBenh()
        {
            connection.connect();
            string Load_Data = @"SELECT DISTINCT 
                         HSKB.MaSoKhamBenh, HSKB.MaSoBenhNhan, BN.Ho, BN.Ten, BN.GioiTinh, BN.NamSinh, HSKB.NgayGioKham, HSKB.XetNghiem,HSKB.KetQuaXetNghiem,
                            HSKB.ChuanDoan, HSKB.NgayTaiKham, HSKB.GhiChu, HSKB.LiDoKham,NV.TenNhanVien
                         FROM            HoSoKhamBenh AS HSKB LEFT OUTER JOIN
                         BenhNhan AS BN ON BN.MaSoBenhNhan = HSKB.MaSoBenhNhan LEFT OUTER JOIN
                         HoSoTaiKham AS HSTK ON HSTK.MaSoKhamBenh = HSKB.MaSoKhamBenh
                         LEFT OUTER JOIN NhanVien AS NV on HSKB.MaSoBacSi = NV.MaSoNhanVien
                         where NgayGioKham like N'%" + ngay + "/" + thang + "/" + nam + "%' and KiemTraKham = 1";
            sqlDataAdapter = new SqlDataAdapter(Load_Data, connection.con);
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet, "HoSoKhamBenh");
            bindingSource.DataSource = dataSet.Tables["HoSoKhamBenh"];
            gridControl1_BenhNhanKhamTrongNgay.DataSource = bindingSource;
            connection.disconnect();
        }
        private void barButtonItem1_filekhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1_BenhNhanKhamTrongNgay.Print();            
        }

        private void barButtonItem2_excel_ItemClick(object sender, ItemClickEventArgs e)
        {
            function.ToExcel(result, gridControl1_BenhNhanKhamTrongNgay);
        }

        private void gridView1_BenhNhanKhamTrongNgay_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void gridView1_BenhNhanKhamTrongNgay_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        #endregion
    }
}