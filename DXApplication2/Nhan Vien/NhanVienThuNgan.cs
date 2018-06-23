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
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        reportDonThuoc reportDonThuoc = new reportDonThuoc();
        DataSet dataSet =new DataSet();
        DangNhap dangNhap = new DangNhap();
        DialogResult result;
        #endregion

        #region Biến khởi tạo
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
        #endregion
        public NhanVienThuNgan()
        {
            InitializeComponent();            
        }
        private void NhanVienThuNgan_Load(object sender, EventArgs e)
        {
            Load_HoaDon();
            function.Timer_load(timer_tick);
        }
        #region Ribbon Control
        private void barButtonItem1_ThongKeDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKeDoanhThu thongKeDoanhThu = new ThongKeDoanhThu();
            thongKeDoanhThu.ShowDialog();
        }

        private void barButtonItem1_ThongKeBenhNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongKeBenhNhan thongKeBenhNhan = new ThongKeBenhNhan();
            thongKeBenhNhan.ShowDialog();
        }

        private void barButtonItem1_ToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {

            function.ToExcel(result, gridControl1_HoaDon);
        }

        private void barButtonItem1_BenhNhanLayThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            string XemBenhNhan = "HD.NgayGioLap like '" + ngay + "/" + thang + "/" + nam + "' And HD.KiemTraThanhToan = 1";
            int checkColumn = 0;
            BenhNhanThanhToan benhNhanThanhToan = new BenhNhanThanhToan(XemBenhNhan, checkColumn);
            benhNhanThanhToan.ShowDialog();
        }
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            refresh_HoaDon();
            function.ClearFilterText(gridView1_HoaDon);
        }
        private void barButtonItem1_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1_HoaDon.ShowRibbonPrintPreview();
        }
        private void barButtonItem1_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            BacSiKham = "";
            NguoiLap = "";
        }
        #endregion

        #region Chức năng chung
        private void gridView1_HoaDon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void gridView1_HoaDon_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }       
                
        private void Load_HoaDon()
        {
            NguoiLap = DangNhap.TenBacSi;//Tên nhân viên
            
            string query = @"select BN.MaSoBenhNhan,BN.Ten, BN.Ho, BN.SoDienThoai,BN.DiaChi,BN.NamSinh,HSKB.MaSoKhamBenh," +
                                    " DT.MaSoDonThuoc,DT.GhiChu,HSKB.XetNghiem,HSKB.ChuanDoan,HSKB.KetQuaXetNghiem,"+
                                    " HSKB.GhiChu,NV.TenNhanVien,HD.MaHoaDon,HSKB.NgayGioKham,DT.TongTienThuoc,"+
                                    " HSKB.TienKham,HD.TongTien,HSKB.NgayTaiKham,HD.KiemTraThanhToan,HD.KiemTraLayThuoc" +
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
            reportDonThuoc.CreateDocument();
            
            documentViewer1.PrintingSystem = reportDonThuoc.PrintingSystem;
            reportDonThuoc.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            documentViewer1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
        }
        public void refresh_HoaDon()
        {
            dataSet.Clear();
            gridControl1_HoaDon.Refresh();
            gridView1_HoaDon.RefreshData();
            documentViewer1.Refresh();
            documentViewer1.PrintingSystem = null;
            chBox_LayThuoc.Checked = false;
            chBox_LayThuoc.Enabled = false;
            btn_ThanhToan.Enabled = false;
            Load_HoaDon();
        }
        public void timer_tick(object sender, EventArgs e)
        {
            int HoaDon = gridView1_HoaDon.FocusedRowHandle;
            Load_HoaDon();
            gridView1_HoaDon.FocusedRowHandle = HoaDon;
            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";
        }
        private void NhanVienThuNgan_FormClosing(object sender, FormClosingEventArgs e)
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
        private void gridView1_HoaDon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object ID_MSHD_CheckNull = gridView1_HoaDon.GetFocusedRowCellValue("MaHoaDon");
            if (ID_MSHD_CheckNull != null && ID_MSHD_CheckNull != DBNull.Value)
            {
                chBox_LayThuoc.Enabled = true;
                btn_ThanhToan.Enabled = true;

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
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            connection.connect();
            
            if (chBox_LayThuoc.Checked ==true)
            {
                BenhNhanLayThuoc();
                string TinhTongTien = @"update HoaDon set"+
                                    " TongTien = H.TongTien"+","+
                                    " KiemTraThanhToan = 1 "+","+
                                    " MaNguoiLap = "+DangNhap.MaSoBacSi+ ","+
                                    " NgayGioLap = '" + ngay + "/" + thang + "/" + nam + "',"+
                                    " KiemTraLayThuoc = 1" +
                                    " from (select sum(HSKB.TienKham+DT.TongTienThuoc) as TongTien" +
                                    " from HoSoKhamBenh HSKB join DonThuoc DT on HSKB.MaSoKhamBenh = DT.MaSoKhamBenh"+
                                       " where HSKB.MaSoKhamBenh = " + ID_MSKB +" And DT.MaSoDonThuoc= "+ID_MSDT +") H " +
                                       " where MaHoaDon =" +ID_MSHD;
                
                connection.sql(TinhTongTien);
                connection.disconnect();
                refresh_HoaDon();
                if ((MessageBox.Show("Thanh toán thành công. Bạn có muốn In hóa đơn??","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes)
                {
                    printDonThuoc printDonThuoc = new printDonThuoc();
                    printDonThuoc.ShowDialog();
                }

            }
            else
            {
                string CheckKiemTraDaLayThuoc = @"select KiemTraDaLayThuoc from HoaDon where MaHoaDon =" + ID_MSHD;                
                DataTable KiemTraDaLayThuoc = connection.SQL(CheckKiemTraDaLayThuoc);
                if (KiemTraDaLayThuoc.Rows[0][0].ToString() != "")
                {
                    if ((MessageBox.Show("Bệnh nhân đã lấy thuốc, hãy chắc rằng bệnh nhân đã hoàn trả thuốc cho Nhân Viên Giao Thuốc.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        string TinhTongTien = @"update HoaDon set" +
                                    " TongTien = H.TongTien" + "," +
                                    " KiemTraThanhToan = 1 " + "," +
                                    " MaNguoiLap = " + DangNhap.MaSoBacSi + "," +
                                    " NgayGioLap = '" + ngay + "/" + thang + "/" + nam + "'," +
                                    " KiemTraLayThuoc = 0" + "," +
                                    " KiemTraDaLayThuoc = NULL" +
                                    " from (select HSKB.TienKham as TongTien" +
                                    " from HoSoKhamBenh HSKB join DonThuoc DT on HSKB.MaSoKhamBenh = DT.MaSoKhamBenh" +
                                       " where HSKB.MaSoKhamBenh = " + ID_MSKB + " And DT.MaSoDonThuoc= " + ID_MSDT + ") H " +
                                       " where MaHoaDon =" + ID_MSHD;
                        BenhNhanKhongLayThuoc();
                        connection.sql(TinhTongTien);
                        connection.disconnect();
                        refresh_HoaDon();
                        if ((MessageBox.Show("Thanh toán thành công. Bạn có muốn In hóa đơn??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                        {
                            printDonThuoc printDonThuoc = new printDonThuoc();
                            printDonThuoc.ShowDialog();
                        }
                    }
                }
                else
                {
                    string TinhTongTien = @"update HoaDon set" +
                                    " TongTien = H.TongTien" + "," +
                                    " KiemTraThanhToan = 1 " + "," +
                                    " MaNguoiLap = " + DangNhap.MaSoBacSi + "," +
                                    " NgayGioLap = '" + ngay + "/" + thang + "/" + nam + "'," +
                                    " KiemTraLayThuoc = 0" + 
                                    " from (select HSKB.TienKham as TongTien" +
                                    " from HoSoKhamBenh HSKB join DonThuoc DT on HSKB.MaSoKhamBenh = DT.MaSoKhamBenh" +
                                       " where HSKB.MaSoKhamBenh = " + ID_MSKB + " And DT.MaSoDonThuoc= " + ID_MSDT + ") H " +
                                       " where MaHoaDon =" + ID_MSHD;
                    BenhNhanKhongLayThuoc();
                    connection.sql(TinhTongTien);
                    connection.disconnect();
                    refresh_HoaDon();
                    if ((MessageBox.Show("Thanh toán thành công. Bạn có muốn In hóa đơn??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        printDonThuoc printDonThuoc = new printDonThuoc();
                        printDonThuoc.ShowDialog();
                    }
                }
                
            }
            
        }              
        
        void BenhNhanKhongLayThuoc()
        {
            int SoLuong;
            int MaSo;
            string get_MST_SL = @"select DST.MaSoThuoc,DST.SoLuong
						from DanhSachThuoc DST join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc
						where DST.MaSoDonThuoc = "+ ID_MSDT;
            DataTable dataTable = connection.SQL(get_MST_SL);
            
            for(int i = 0; i<dataTable.Rows.Count;i++)
            {
                MaSo = int.Parse(dataTable.Rows[i][0].ToString());
                SoLuong = int.Parse(dataTable.Rows[i][1].ToString());

                string update_Thuoc = @"update Thuoc set SoLuongNhoNhat = SoLuongNhoNhat + "+ SoLuong +
                                        " where MaSoThuoc = "+MaSo;
                connection.sql(update_Thuoc);
            }
            
        }
        void BenhNhanLayThuoc()
        {
            int SoLuong;
            int MaSo;
            string get_KiemTraLayThuoc = @"select KiemTraLayThuoc from HoaDon where MaHoaDon =" + ID_MSHD;
            DataTable dataTable_KTLT = connection.SQL(get_KiemTraLayThuoc);
            string KiemTraLayThuoc = dataTable_KTLT.Rows[0][0].ToString();
            if(KiemTraLayThuoc == "False")
            {
                string get_MST_SL = @"select DST.MaSoThuoc,DST.SoLuong
						from DanhSachThuoc DST join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc
						where DST.MaSoDonThuoc = " + ID_MSDT;
                DataTable dataTable_MST_SL = connection.SQL(get_MST_SL);

                for (int i = 0; i < dataTable_MST_SL.Rows.Count; i++)
                {
                    MaSo = int.Parse(dataTable_MST_SL.Rows[i][0].ToString());
                    SoLuong = int.Parse(dataTable_MST_SL.Rows[i][1].ToString());

                    string update_Thuoc = @"update Thuoc set SoLuongNhoNhat = SoLuongNhoNhat - " + SoLuong +
                                            " where MaSoThuoc = " + MaSo;
                    connection.sql(update_Thuoc);
                }
            }            
        }
        #endregion

        
    }
}