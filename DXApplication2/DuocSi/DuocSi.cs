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
    public partial class DuocSi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        BindingSource bindingSource = new BindingSource();
        reportDonThuocFormDuocSi reportDonThuocFormDuocSi = new reportDonThuocFormDuocSi();
        DialogResult result;
        #endregion        
        
        #region Giá trị
        public static int ID_MSDT { get; set; }
        public static int ID_MSKB { get; set; }
        public static int ID_MSHD { get; set; }

        public static string Ho { get; set; }
        public static string Ten { get; set; }
        public static string NamSinh { get; set; }
        public static string SDT { get; set; }

        public static string ChuanDoan { get; set; }
        public static string GhiChuHSKB { get; set; }
        public static string GhiChuHSDT { get; set; }
        public static string NgayKham { get; set; }

        public static string BacSiKham { get; set; }
        public static string NguoiLap { get; set; }
        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
        #endregion

        public DuocSi()
        {
            InitializeComponent();            
        }
        private void DuocSi_Load(object sender, EventArgs e)
        {
            load_DanhSachBenhNhan();
            function.Timer_load(timer_tick);
        }
        #region RibbonControl
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            refresh_DuocSi();
            function.ClearFilterText(gridView_DanhSachBenhNhan);//clear text tìm trong gridview
        }
        private void btn_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl_DanhSachBenhNhan.ShowRibbonPrintPreview();
        }
        private void barButtonItem1_Toexcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            function.ToExcel(result, gridControl_DanhSachBenhNhan);
        }

        private void barButtonItem1_BenhNhanLayThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            //đưa câu truy vấn vào Form BenhNhanThanhToan để lọc đúng với xem bệnh nhân đã lấy thuốc
            string XemBenhNhan = "HD.NgayGioLap like '" + ngay + "/" + thang + "/" + nam + "' And HD.KiemTraDaLayThuoc = 1";
            int checkColumn = 1;//đặt giá trị để nhận biết là dược sĩ
            BenhNhanThanhToan benhNhanThanhToan = new BenhNhanThanhToan(XemBenhNhan, checkColumn);//truyền dữ liệu vào Form
            benhNhanThanhToan.ShowDialog();
        }
        #endregion

        #region Chức năng chung
        private void gridView_DanhSachBenhNhan_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void gridView_DanhSachBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        public void timer_tick(object sender, EventArgs e)
        {
            int TiepNhanBenhNhan = gridView_DanhSachBenhNhan.FocusedRowHandle;
            load_DanhSachBenhNhan();
            gridView_DanhSachBenhNhan.FocusedRowHandle = TiepNhanBenhNhan;
            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";
        }
        public void refresh_DuocSi()
        {
            dataSet.Clear();
            gridControl_DanhSachBenhNhan.Refresh();
            gridView_DanhSachBenhNhan.RefreshData();
            documentViewer1.PrintingSystem = null;
            load_DanhSachBenhNhan();
            btn_LayThuocXong.Enabled = false;
        }
        private void load_DanhSachBenhNhan()
        {
            NguoiLap = DangNhap.TenBacSi;
            string Load_data = @"select BN.Ten, BN.Ho, BN.SoDienThoai,BN.NamSinh,HSKB.MaSoKhamBenh," +
                                    " DT.MaSoDonThuoc,DT.GhiChu,HSKB.ChuanDoan," +
                                    " HSKB.GhiChu,NV.TenNhanVien,HD.MaHoaDon,HSKB.NgayGioKham," +
                                    " HD.KiemTraDaLayThuoc" +
                            " from HoaDon HD join HoSoKhamBenh HSKB on HD.MaSoKhamBenh = HSKB.MaSoKhamBenh " +
                            " join BenhNhan BN on HSKB.MaSoBenhNhan = BN.MaSoBenhNhan" +
                            " join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien" +
                            " join DonThuoc DT on DT.MaSoDonThuoc = HD.MaSoDonThuoc" +
                            " where HD.KiemTraLayThuoc = 1 And HD.KiemTraDaLayThuoc is NULL And HD.NgayGioLap like '" + ngay + "/" + thang + "/" + nam + "'";
            connection.connect();
            sqlDataAdapter = new SqlDataAdapter(Load_data, connection.con);
            dataSet.Clear();
            sqlDataAdapter.Fill(dataSet,"HoaDon");
            bindingSource.DataSource = dataSet.Tables["HoaDon"];
            gridControl_DanhSachBenhNhan.DataSource = bindingSource;
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
            reportDonThuocFormDuocSi.DataSource = dataSet.Tables["DonThuoc"];
            reportDonThuocFormDuocSi.Bindata();
            connection.disconnect();
            //hiển thị report lên documentViewer1
            documentViewer1.PrintingSystem = reportDonThuocFormDuocSi.PrintingSystem;
            reportDonThuocFormDuocSi.CreateDocument();
        }
        private void DuocSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Admin.IfAdmin == true)
            {
                this.Hide();
            }
            else
            {
                if ((MessageBox.Show("Bạn Có Muốn Đăng Xuất không?", "Thông Báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            Admin.IfAdmin = false;
        }
        #endregion

        #region Chức năng chính
        private void gridView_DanhSachBenhNhan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btn_LayThuocXong.Enabled = true;
            object ID_MSDT_CheckNull = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoDonThuoc");
            if (ID_MSDT_CheckNull != null && ID_MSDT_CheckNull != DBNull.Value)
            {
                ID_MSDT = int.Parse(gridView_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoDonThuoc").ToString());
                ID_MSKB = int.Parse(gridView_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
                ID_MSHD = int.Parse(gridView_DanhSachBenhNhan.GetFocusedRowCellValue("MaHoaDon").ToString());
                Ho = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("Ho").ToString();
                Ten = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("Ten").ToString();
                NamSinh = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("NamSinh").ToString();
                SDT = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("SoDienThoai").ToString();

                GhiChuHSDT = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("GhiChu").ToString();
                GhiChuHSKB = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("GhiChu1").ToString();
                NgayKham = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("NgayGioKham").ToString();

                BacSiKham = gridView_DanhSachBenhNhan.GetFocusedRowCellValue("TenNhanVien").ToString();
                Load_reportDonThuoc();//hiện report khi nhấn vào hàng trong gridview
            }
        }
        private void btn_LayThuocXong_Click(object sender, EventArgs e)
        {
            string Laythuocxong = @"update HoaDon set"+
                                    " KiemTraDaLayThuoc = 1" +
                                    " where MaHoaDon =" + ID_MSHD;
            connection.connect();
            connection.sql(Laythuocxong);
            connection.disconnect();            
            refresh_DuocSi();
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            BacSiKham = "";
            NguoiLap = "";
        }
        #endregion        
    }
}