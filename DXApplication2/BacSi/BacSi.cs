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
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
namespace QuanLyPhongKham
{
    public partial class BacSi : DevExpress.XtraBars.Ribbon.RibbonForm 
    {
        #region khởi tạo
        connection connection = new connection();
        DangNhap dangNhap = new DangNhap();
        DonThuoc donThuoc = new DonThuoc();
        function function = new function();
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bindingSource = new BindingSource();
        SqlCommand cmd;        
        DialogResult result;
        #endregion
        #region Biến khởi tạo
        public static bool RowClick = false;
        public static string Ho_BenhNhan { get; set; }
        public static string Ten_BenhNhan { get; set; }
        public static string XetNghiem_BenhNhan { get; set; }
        public static string KetQuaXetNghiem_BenhNhan { get; set; }
        public static string ChuanDoan_BenhNhan { get; set; }
        public static string GhiChu_BenhNhan { get; set; }
        public static string NamSinh_BenhNhan { get; set; }
        public static string GioiTinh_BenhNhan { get; set; }
        public static string DiaChi_BenhNhan { get; set; }
        public static string BacSiKham_BenhNhan { get; set; }
        public static int ID_MSKB { get; set; }
        public static int ID_MSBN { get; set; }
        public static string TienThuoc { get; set; }
        public static int ID_MSDT { get; set; }
        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
        #endregion
        public BacSi()
        {
            InitializeComponent();            
        }
        private void BacSi_Load(object sender, EventArgs e)
        {
            KiemTra_HoSoChoXetNghiem_HetHan();
            Load_HoSoKhamBenh();
            function.Timer_load(timer_tick);
        }
        #region Chức năng chung
        public void timer_tick(object sender, EventArgs e)
        {
            int danhsachBenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.FocusedRowHandle;
            Load_HoSoKhamBenh();
            BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.FocusedRowHandle = danhsachBenhNhan;
            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";
        }
        private void Load_HoSoKhamBenh()
        {
            connection.connect();
            string Load_Data = @"SELECT     DISTINCT   HSKB.MaSoKhamBenh, HSKB.MaSoBenhNhan,NV.TenNhanVien, BN.Ho, BN.Ten, BN.GioiTinh," +
                                                    " BN.NamSinh, HSKB.NgayGioKham, HSKB.MaSoBacSi, HSKB.XetNghiem,HSKB.KetQuaXetNghiem," +
                                                    " HSKB.ChuanDoan, HSKB.TienKham, HSKB.NgayTaiKham, HSKB.GhiChu, " +
                                                    "HSKB.KiemTraKham, HSKB.LiDoKham, BN.DiaChi, BN.SoDienThoai, BN.HinhAnh, HSKB.KiemTraTaiKham,HSKB.CheckChoKham" +
                                " FROM            HoSoKhamBenh HSKB LEFT JOIN" +
                                                    " BenhNhan BN ON BN.MaSoBenhNhan = HSKB.MaSoBenhNhan" +
                                                    " left join NhanVien NV on HSKB.MaSoBacSi = NV.MaSoNhanVien" +
                                                    " where HSKB.NgayGioKham like '" + ngay + "/" + thang + "/" + nam + "%' and HSKB.KiemTraKham is NULL OR CheckChoKham = 1";
            da = new SqlDataAdapter(Load_Data, connection.con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "HoSoKhamBenh");
            bindingSource.DataSource = ds.Tables["HoSoKhamBenh"];
            BacSi_gridControl_danhsachBenhNhanDaKhamTrongNgay.DataSource = bindingSource;            
            connection.disconnect();
            GanGiaTri();
        }
        private void KiemTra_HoSoChoXetNghiem_HetHan()
        {

            string GetDate_Kham = @"declare @NgayGioiHan1 int =10" +//tạo 1 biến int giá trị 10 (10 ngày)
                                    " delete from HoSoKhamBenh where CheckChoKham = 1 and" +//xóa hồ sơ tại CheckChoKham =1
                                    " @NgayGioiHan1<DATEDIFF(DAY,CONVERT(datetime, NgayGioKham,103),GETDATE()) ";//Kiểm tra Ngày khám có nhỏ hơn 10 ngày
                                                                                                                 //convert Ngày khám từ string thày datetime và so sánh với Ngày hiện tại
                                                                                                                 //lấy kết quả ra số ngày chênh lệch
            connection.connect();
            connection.delete(GetDate_Kham);
            connection.disconnect();
        }
        public void Refresh_BacSi()
        {
            function.ClearControl(panelControl2);            
            Load_HoSoKhamBenh();
            RowClick = false;
            panelControl2.Enabled = false;
        }
        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void GanGiaTri()
        {
            BacSiKham_BenhNhan = DangNhap.TenBacSi;
        }
        private void txt_TienKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
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
        #region Ribbon Control
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refresh_BacSi();
            function.ClearFilterText(BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay);
        }

        private void bbtn_TaoDonThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            btn_TaoDonThuoc_Click(sender, e);
        }

        private void bbtn_HoSoKhamBenh_ItemClick(object sender, ItemClickEventArgs e)
        {
            XemHoSoBenhNhan xemHoSoBenhNhan = new XemHoSoBenhNhan();
            xemHoSoBenhNhan.ShowDialog();
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            BacSiKham_BenhNhan = "";
        }

        private void barButtonItem1_Xuatfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            BacSi_gridControl_danhsachBenhNhanDaKhamTrongNgay.ShowRibbonPrintPreview();
        }

        private void barButtonItem1_KhamTrongNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
            BenhNhanKhamTrongNgay benhNhanKhamTrongNgay = new BenhNhanKhamTrongNgay();
            benhNhanKhamTrongNgay.ShowDialog();
        }

        private void barButtonItem1_Excel_ItemClick(object sender, ItemClickEventArgs e)
        {
            function.ToExcel(result, BacSi_gridControl_danhsachBenhNhanDaKhamTrongNgay);
        }
        #endregion
        #region Chức năng chính
        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_RowClick(object sender, RowClickEventArgs e)//nhất vào hàng trong gridview
        {
            RowClick = true;//kiểm tra người dùng có chọn trên grid view hay chưa
            panelControl2.Enabled = true;//mở chế độ có thể chỉnh sửa
            ID_MSBN = int.Parse(BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
            txt_ho.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("Ho").ToString();
            txt_ten.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("Ten").ToString();
            ID_MSKB = int.Parse(BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            Ho_BenhNhan = txt_ho.Text;
            Ten_BenhNhan = txt_ten.Text;
            NamSinh_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("NamSinh").ToString();
            GioiTinh_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("GioiTinh").ToString();
            DiaChi_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("DiaChi").ToString();
            if (txt_xetnghiem.Text=="" && txt_KetQuaXetNghiem.Text == "" && txt_chuandoan.Text == "" && txt_GhiChu.Text == "" && txt_TienKham.Text=="")
            {//nếu các text box này trống, thì sẽ được đưa dữ liệu vào                
                txt_xetnghiem.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("XetNghiem").ToString();
                txt_KetQuaXetNghiem.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("KetQuaXetNghiem").ToString();
                txt_chuandoan.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("ChuanDoan").ToString();
                txt_GhiChu.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("GhiChu").ToString();
                txt_TienKham.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("TienKham").ToString();                              
            }                     

            connection.connect();
            string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID_MSBN;
            cmd = new SqlCommand(layhinhanh, connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if(dr["hinhanh"].ToString() != "")
                {
                    if(File.Exists(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString()))
                    {
                        pictureBox1_BenhNhan.Image = new Bitmap(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString());
                    }
                    else
                    {
                        function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục",1);
                        pictureBox1_BenhNhan.Image = null;
                    }
                }
                else
                {
                    pictureBox1_BenhNhan.Image = null;
                    continue;
                }
            }
            dr.Close();
            connection.disconnect();
        }
        private void btn_TaoDonThuoc_Click(object sender, EventArgs e)//nút tạo đơn thuốc
        {
            if (RowClick == false)//kiểm tra người dùng có chọn trên grid view hay chưa
            {
                function.Notice("Bạn nên chọn bệnh nhân trước!", 1);
            }
            else
            {
                XetNghiem_BenhNhan = txt_xetnghiem.Text;//gán những giá trị trong Form Bác sĩ tới Đơn thuốc
                KetQuaXetNghiem_BenhNhan = txt_KetQuaXetNghiem.Text;
                ChuanDoan_BenhNhan = txt_chuandoan.Text;
                GhiChu_BenhNhan = txt_GhiChu.Text;
                BacSiKham_BenhNhan = DangNhap.TenBacSi;
                DonThuoc donThuoc = new DonThuoc();
                donThuoc.ShowDialog();
            }
        }
        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (txt_chuandoan.Text != "" && txt_GhiChu.Text != "" && txt_TienKham.Text != "")//không cho để trống Chẩn đoán, ghi chú, tiền khám
            {
                connection.connect();
                if (dtP_NgayTaiKham.Value <= DateTime.Now)//kiểm tra nếu nhỏ hơn ngày hiện tại thì không có tái khám
                {
                    if(MessageBox.Show("Bạn nhập Ngày Tái Khám < hơn hoặc = ngày hiện tại!!"+"\n"
                                    + "Bạn có chắc Bệnh nhân không cần tái khám!!"
                                    ,"Thông báo nhập Ngày tái khám",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                    {                        
                        string get_ID_MSDT = @"select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB;
                        DataTable dataTable = connection.SQL(get_ID_MSDT);
                        if (dataTable.Rows.Count <= 0)
                        {
                            function.Notice("Bạn cần phải tạo đơn thuốc cho Hồ Sơ Khám Bệnh", 1);
                        }
                        else
                        {
                            ID_MSDT = int.Parse(dataTable.Rows[0][0].ToString());

                            string query = @"update HoSoKhamBenh set " +
                                            " XetNghiem = N'" + txt_xetnghiem.Text + "'," +
                                            " KetQuaXetNghiem = N'" + txt_KetQuaXetNghiem.Text + "'," +
                                            " ChuanDoan = N'" + txt_chuandoan.Text + "'," +
                                            " GhiChu = N'" + txt_GhiChu.Text + "'," +
                                            " NgayTaiKham = N''," +
                                            " NgayGioKham = N'" + ngay + "/" + thang + "/" + nam  + "'," +
                                            " TienKham  = " + txt_TienKham.Text + "," +
                                            " KiemTraKham = 1" + "," +
                                            " MaSoBacSi = " + DangNhap.MaSoBacSi + "," +
                                            " CheckChoKham = 0" +
                                            " where MaSoBenhNhan =" + ID_MSBN + " and " + " MaSoKhamBenh = " + ID_MSKB + ";" +
                                            " insert into HoaDon(MaSoKhamBenh,MaSoDonThuoc,NgayGioLap) values (" + ID_MSKB + "," + ID_MSDT + ",'" + ngay + "/" + thang + "/" + nam + "')";

                            connection.sql(query);
                            connection.disconnect();
                            Refresh_BacSi();
                        }
                    }                    
                }
                else if(dtP_NgayTaiKham.Value > DateTime.Now)//lớn hơn thì insert ngày tái khám
                {                                      
                    string get_ID_MSDT = @"select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB;
                    DataTable dataTable = connection.SQL(get_ID_MSDT);
                    if (dataTable.Rows.Count <= 0)
                    {
                        function.Notice("Bạn cần phải tạo đơn thuốc cho Hồ Sơ Khám Bệnh", 1);
                    }
                    else
                    {
                        ID_MSDT = int.Parse(dataTable.Rows[0][0].ToString());
                        string query = @"update HoSoKhamBenh set " +
                                        " XetNghiem = N'" + txt_xetnghiem.Text + "'," +
                                        " KetQuaXetNghiem = N'" + txt_KetQuaXetNghiem.Text + "'," +
                                        " ChuanDoan = N'" + txt_chuandoan.Text + "'," +
                                        " GhiChu = N'" + txt_GhiChu.Text + "'," +
                                        " NgayTaiKham = N'" + dtP_NgayTaiKham.Text + "'," +
                                        " NgayGioKham = N'" + ngay + "/" + thang + "/" + nam + "'," +
                                        " TienKham  = " + txt_TienKham.Text + "," +
                                        " KiemTraKham = 1" + "," +
                                        " MaSoBacSi = " + DangNhap.MaSoBacSi + "," +
                                        " CheckChoKham = 0" +
                                        " where MaSoBenhNhan =" + ID_MSBN + " and " + " MaSoKhamBenh = " + ID_MSKB + ";" +
                                        " insert into HoaDon(MaSoKhamBenh,MaSoDonThuoc,NgayGioLap) values (" + ID_MSKB + "," + ID_MSDT + ",'" + ngay + "/" + thang + "/" + nam + "')";
                        connection.sql(query);
                        connection.disconnect();
                        Refresh_BacSi();
                    }
                }
            }
            else { function.Notice("Bạn nên nhập đủ thông tin Chuẩn đoán, Ghi chú, Tiền khám",0); }
        }       
        
        private void btn_ChoKham_Click(object sender, EventArgs e)
        {
            if (txt_xetnghiem.Text == "" && txt_chuandoan.Text == "" && txt_GhiChu.Text == "")//không cho để trống
            {
                function.Notice("Bạn nên nhập Yêu cầu xét nghiệm, Chẩn đoán, Ghi chú", 0);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn Đưa thông tin Bệnh Nhân vào Chờ Xét Nghiệm??" + "\n" +//hiện thông báo
                                    "Lưu ý, Thông tin 'Xét nghiệm, Chẩn đoán, Ghi chú' sẽ được lưu." + "\n" +
                                    "Thông tin sẽ tự xóa sau 10 ngày", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.connect();
                    string query1 = @"select DST.MaSoDonThuoc
                                        from DanhSachThuoc DST join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc
					                                             join HoSoKhamBenh HSKB on DT.MaSoKhamBenh = HSKB.MaSoKhamBenh
                                        where HSKB.MaSoKhamBenh =  " + ID_MSKB;
                    DataTable dataTable = connection.SQL(query1);
                    if (dataTable.Rows.Count > 0)//kiểm tra mã số đơn thuốc có tồn tại
                    {
                        function.Notice("Bạn nên xóa thuốc trong Đơn thuốc!", 0);
                    }
                    else
                    {//nếu không thì sẽ insert vào hồ sơ khám bệnh là bệnh nhân chờ khám
                        string query = @"update HoSoKhamBenh set " +
                                        " XetNghiem = N'" + txt_xetnghiem.Text + "'," +
                                        " KetQuaXetNghiem = N'" + txt_KetQuaXetNghiem.Text + "'," +
                                        " ChuanDoan = N'" + txt_chuandoan.Text + "'," +
                                        " GhiChu = N'" + txt_GhiChu.Text + "'," +
                                        " MaSoBacSi = " + DangNhap.MaSoBacSi + "," +
                                        " NgayTaiKham = N'" + dtP_NgayTaiKham.Text + "'," +
                                        " CheckChoKham = 1" + "," +
                                        " KiemTraKham = 0" +
                                        " where MaSoBenhNhan =" + ID_MSBN + " and " + " MaSoKhamBenh = " + ID_MSKB;

                        connection.sql(query);                        
                        Refresh_BacSi();
                    }
                    connection.disconnect();
                }
            }
        }
        #endregion
    }
}