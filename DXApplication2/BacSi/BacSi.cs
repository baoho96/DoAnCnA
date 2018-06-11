﻿using System;
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
        connection connection = new connection();
        SqlDataAdapter da;
        DataSet ds;
        BindingSource bindingSource = new BindingSource();
        SqlCommand cmd;
        DangNhap dangNhap = new DangNhap();
        DonThuoc donThuoc = new DonThuoc();
        function function = new function();
        DialogResult result;
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
        public BacSi()
        {
            //phongKhamDataSet1.EnforceConstraints = false;
            InitializeComponent();
            //GridLocalizer.Active = new MyGridLocalizer();
            KiemTra_HoSoChoXetNghiem_HetHan();
            Load_HoSoKhamBenh();

            function.Timer_load(timer_tick);
        }
        //public class MyGridLocalizer : GridLocalizer
        //{
        //    public override string GetLocalizedString(GridStringId id)
        //    {
        //        if (id == GridStringId.FindControlFindButton)
        //            return "Tìm Kiếm";
        //        if (id == GridStringId.FindControlClearButton)
        //            return "Nhập lại";
        //        return base.GetLocalizedString(id);
        //    }
        //}

        public void timer_tick(object sender, EventArgs e)
        {
            int danhsachBenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.FocusedRowHandle;
            Load_HoSoKhamBenh();
            BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.FocusedRowHandle = danhsachBenhNhan;

            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";

        }

        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);

        }

        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void Load_HoSoKhamBenh()
        {
            connection.connect();
            //quyentruycap = DangNhap.quyentruycap;
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

        private void Refresh_BacSi()
        {
            function.ClearControl(panelControl2);
            
            Load_HoSoKhamBenh();
            RowClick = false;
            panelControl2.Enabled = false;
        }

        private void GanGiaTri()
        {
            //txtTienThuoc.Text = TienThuoc;
            BacSiKham_BenhNhan = DangNhap.TenBacSi;
        }
        //private void load_TienThuoc()
        //{
        //    string query = @"select DT.TongTienThuoc "+
        //                    " from DonThuoc DT Left Join HoSoKhamBenh HSKB on DT.MaSoKhamBenh = HSKB.MaSoKhamBenh"+
        //                    " where HSKB.MaSoKhamBenh ="+ ID_MSKB;
        //    //connection.connect();
        //    DataTable dt = connection.SQL(query);
        //    if (dt.Rows.Count > 0)//tồn tại
        //    {
        //        txtTienThuoc.Text = dt.Rows[0][0].ToString();
        //    }
        //    //connection.disconnect();
        //}

        private void btn_TaoDonThuoc_Click(object sender, EventArgs e)
        {
            if(RowClick ==false)
            {
                function.Notice("Bạn nên chọn bệnh nhân trước!", 1);
            }
            
            else
            {
                XetNghiem_BenhNhan = txt_xetnghiem.Text;
                KetQuaXetNghiem_BenhNhan = txt_KetQuaXetNghiem.Text;
                ChuanDoan_BenhNhan = txt_chuandoan.Text;
                GhiChu_BenhNhan = txt_GhiChu.Text;
                BacSiKham_BenhNhan = DangNhap.TenBacSi;

                DonThuoc donThuoc = new DonThuoc();
                donThuoc.ShowDialog();
                
            }
            
        }

        private void BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay_RowClick(object sender, RowClickEventArgs e)
        {
            RowClick = true;
            panelControl2.Enabled = true;
            ID_MSBN = int.Parse(BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
            //txt_TenBacSi.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("TenNhanVien").ToString();
            txt_ho.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("Ho").ToString();
            txt_ten.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("Ten").ToString();
            ID_MSKB = int.Parse(BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            Ho_BenhNhan = txt_ho.Text;
            Ten_BenhNhan = txt_ten.Text;
            NamSinh_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("NamSinh").ToString();
            GioiTinh_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("GioiTinh").ToString();
            DiaChi_BenhNhan = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("DiaChi").ToString();
            //BacSiKham_BenhNhan= BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("TenNhanVien").ToString();
            if (txt_xetnghiem.Text=="" && txt_KetQuaXetNghiem.Text == "" && txt_chuandoan.Text == "" && txt_GhiChu.Text == "" && txt_TienKham.Text=="")
            {
                
                txt_xetnghiem.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("XetNghiem").ToString();
                txt_KetQuaXetNghiem.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("KetQuaXetNghiem").ToString();
                txt_chuandoan.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("ChuanDoan").ToString();
                txt_GhiChu.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("GhiChu").ToString();
                //dtP_NgayTaiKham.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("NgayTaiKham").ToString();
                txt_TienKham.Text = BacSi_gridView_danhsachBenhNhanDaKhamTrongNgay.GetFocusedRowCellValue("TienKham").ToString();                              
            }                     

            connection.connect();
            //load_TienThuoc(); Hàm Load tiền thuốc

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

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (txt_chuandoan.Text != "" && txt_GhiChu.Text != "" && txt_TienKham.Text != "")
            {
                if (dtP_NgayTaiKham.Value <= DateTime.Now)
                {
                    if(MessageBox.Show("Bạn nhập Ngày Tái Khám < hơn hoặc = ngày hiện tại!!"+"\n"
                                    + "Bạn có chắc Bệnh nhân không cần tái khám!!"
                                    ,"Thông báo nhập Ngày tái khám",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.connect();
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
                else if(dtP_NgayTaiKham.Value > DateTime.Now)
                {
                    
                    connection.connect();
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
            else { function.Notice("Bạn nên nhập đủ thông tin Chuẩn đoán, Ghi chú, Tiền khám",1); }
        }       

       

        private void txt_TienKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }

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

        private void BacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Admin.IfAdmin==true)
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
        private void KiemTra_HoSoChoXetNghiem_HetHan()
        {
            
            string GetDate_Kham = @"declare @NgayGioiHan1 int =10"+//tạo 1 biến int giá trị 10 (10 ngày)
                                    " delete from HoSoKhamBenh where CheckChoKham = 1 and" +//xóa hồ sơ tại CheckChoKham =1
                                    " @NgayGioiHan1<DATEDIFF(DAY,CONVERT(datetime, NgayGioKham,103),GETDATE()) ";//Kiểm tra Ngày khám có nhỏ hơn 10 ngày
                                                                        //convert Ngày khám từ string thày datetime và so sánh với Ngày hiện tại
                                                                        //lấy kết quả ra số ngày chênh lệch
            connection.connect();
            connection.delete(GetDate_Kham);
            connection.disconnect();
        }
        private void btn_ChoKham_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn Đưa thông tin Bệnh Nhân vào Chờ Xét Nghiệm??"+"\n"+
                                " Lưu ý, Thông tin 'Xét nghiệm, Chuẩn đoán, Ghi chú' sẽ được lưu."+"\n"+
                                " Thông tin sẽ tự xóa sau 10 ngày", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string query = @"update HoSoKhamBenh set " +
                                " XetNghiem = N'" + txt_xetnghiem.Text + "'," +
                                " KetQuaXetNghiem = N'" + txt_KetQuaXetNghiem.Text + "'," +
                                " ChuanDoan = N'" + txt_chuandoan.Text + "'," +
                                " GhiChu = N'" + txt_GhiChu.Text + "'," +
                                " MaSoBacSi = " + DangNhap.MaSoBacSi + "," +
                                " NgayTaiKham = N'" + dtP_NgayTaiKham.Text + "'," +
                                " CheckChoKham = 1" +","+
                                " KiemTraKham = 0" +
                                " where MaSoBenhNhan =" + ID_MSBN + " and " + " MaSoKhamBenh = " + ID_MSKB;

                                
                connection.connect();
                connection.sql(query);
                connection.disconnect();
                Refresh_BacSi();
            }
            
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
            function.ToExcel("Bạn có muốn xuất file Excel Bệnh nhân chờ khám??", result, BacSi_gridControl_danhsachBenhNhanDaKhamTrongNgay);
        }

    }
}