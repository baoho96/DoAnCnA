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
namespace QuanLyPhongKham
{
    public partial class NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khởi tạo
        SqlCommand cmd;
        BindingSource bindingSource = new BindingSource();
        OpenFileDialog open;
        string hinhanh = null;
        DialogResult result;
        function function = new function();
        connection connection = new connection();
        ThemCho themCho;
        #endregion

        #region Biến khởi tạo
        string ngay = DateTime.Now.Day.ToString("d2");
        string thang = DateTime.Now.Month.ToString("d2");
        string nam = DateTime.Now.Year.ToString();
        public static int ID_MSKB_DoubleClick { get; set; }
        #endregion

        public NhanVien()
        {
            InitializeComponent();
        }
        #region Chức năng chung       
        
        private void NhanVien_Load(object sender, EventArgs e)
        {
            phongKhamDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'phongKhamDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);

            //this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);//Load Hồ Sơ Khám Bệnh cho tab Tìm kiếm bệnh nhân khám bệnh
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoKhamBenh' table. You can move, or remove it, as needed.
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);

            this.hoSoTaiKhamTableAdapter1.Fill(this.phongKhamDataSet.HoSoTaiKham);//Load Hồ sơ tái khám ở tab Tìm kiếm bệnh nhân khám bênh



            load_TiepNhanBenhNhan_comB_GioiTinh();
            load_DanhSachBenhNhan_comB_GioiTinh();

            filterColumn_TiepNhanBenhNhan();
            function.Timer_load(timer_tick);
        }
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        { 
            gridView1_TimBenhNhan.ClearGrouping();   //Tìm kiếm bệnh nhân         
            gridView4_DanhSachBenhNhan.ClearGrouping();//Tiếp nhận bệnh nhân cũ
            gridView1_TimKiemBenhNhan.ClearGrouping();//Tiếp nhận bệnh nhân tái khám

            RefreshAll();

            gridView1_TiepNhanBenhNhan.FocusedRowHandle = 0;
            gridView4_DanhSachBenhNhan.FocusedRowHandle = 0;
            gridView1_TimKiemBenhNhan.FocusedRowHandle = 0;
            gridView1_TimBenhNhan.FocusedRowHandle = 0;

            function.ClearFilterText(gridView1_TiepNhanBenhNhan);
            function.ClearFilterText(gridView4_DanhSachBenhNhan);
            function.ClearFilterText(gridView1_TimKiemBenhNhan);
            function.ClearFilterText(gridView1_TimBenhNhan);

            gridView1_TiepNhanBenhNhan.UnselectRow(int.Parse(gridView1_TiepNhanBenhNhan.FocusedRowHandle.ToString()));
            gridView4_DanhSachBenhNhan.UnselectRow(int.Parse(gridView4_DanhSachBenhNhan.FocusedRowHandle.ToString()));
            gridView1_TimKiemBenhNhan.UnselectRow(int.Parse(gridView1_TimKiemBenhNhan.FocusedRowHandle.ToString()));
            gridView1_TimBenhNhan.UnselectRow(int.Parse(gridView1_TimBenhNhan.FocusedRowHandle.ToString()));
        }
        public void RefreshAll()
        {
            gridControl1_TimBenhNhan.Refresh();
            gridControl1_TimKiemBenhNhan.Refresh();
            TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Refresh();
            DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan.Refresh();

            refresh_TiepNhanBenhNhan();
            refresh_DanhSachBenhNhan();//Tiếp nhận bệnh nhân cũ
            refresh_TimKiemBenhNhan();//Tiếp nhận bệnh nhân tái khám
            refresh_TimKiemBenhNhanTaiKham();           
        }
        public void timer_tick(object sender, EventArgs e)
        {
            int TiepNhanBenhNhan = gridView1_TiepNhanBenhNhan.FocusedRowHandle;
            int DanhSachBenhNhan = gridView4_DanhSachBenhNhan.FocusedRowHandle;
            int TimKiemBenhNhan = gridView1_TimKiemBenhNhan.FocusedRowHandle;
            int TimBenhNhan = gridView1_TimBenhNhan.FocusedRowHandle;

            this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);

            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoKhamBenh' table. You can move, or remove it, as needed.
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            this.hoSoTaiKhamTableAdapter1.Fill(this.phongKhamDataSet.HoSoTaiKham);//Load Hồ sơ tái khám ở tab Tìm kiếm bệnh nhân khám bênh

            gridView1_TiepNhanBenhNhan.FocusedRowHandle = TiepNhanBenhNhan;
            gridView4_DanhSachBenhNhan.FocusedRowHandle = DanhSachBenhNhan;
            gridView1_TimKiemBenhNhan.FocusedRowHandle = TimKiemBenhNhan;
            gridView1_TimBenhNhan.FocusedRowHandle = TimBenhNhan;
            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";

        }
        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        #region tab Tiếp nhận bệnh nhân
        private void DanhSachBenhNhan_txt_CanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }

        private void DanhSachBenhNhan_txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void filterColumn_TiepNhanBenhNhan()
        {           
            string ngay = DateTime.Now.Day.ToString("d2");
            string thang = DateTime.Now.Month.ToString("d2");
            string nam = DateTime.Now.Year.ToString();            
            gridView1_TiepNhanBenhNhan.ActiveFilterString = "Contains([NgayGioKham], '" + ngay + "/" + thang + "/" + nam + "') And [KiemTraKham] Is Null";            
        }
        private void refresh_TiepNhanBenhNhan()
        {
            function.ClearControl(panelControl2);
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            load_TiepNhanBenhNhan_comB_GioiTinh();
            hinhanh = null;
            result = new DialogResult();
            TiepNhanBenhNhan_btn_CapNhat.Enabled = false;
            TiepNhanBenhNhan_btn_Xoa.Enabled = false;
        }
        private void load_TiepNhanBenhNhan_comB_GioiTinh()
        {
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Nam");
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Nữ");
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Khác");
        }
        private void TiepNhanBenhNhan_txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void TiepNhanBenhNhan_txt_CanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void gridView1_TiepNhanBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void gridView1_TiepNhanBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void pictureBox1_BenhNhan_DoubleClick(object sender, EventArgs e)
        {
            open = new OpenFileDialog();            
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_BenhNhan.Image = Image.FromStream(open.OpenFile());

                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1,
                            open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_BenhNhan.Image = new Bitmap(open.FileName);
            }
        }
        
        private void TiepNhanBenhNhan_btn_TaoMoi_Click(object sender, EventArgs e)
        {
            if (function.checkNull(panelControl2) == true)
            {
                connection.connect();

                if (pictureBox1_BenhNhan.Image != null)
                {
                    if (result == DialogResult.OK)
                    {
                        hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1,
                                    open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                        string previewPath = Application.StartupPath + @"\Hinh\BenhNhan\" + hinhanh;
                        string linkHinhAnh = open.FileName;
                        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                    }
                    else { }
                }
                else { }                
                string KiemTraTonTai = @"select Ho, Ten,NamSinh,SoDienThoai from BenhNhan" +
                    " where Ho like N'%" + TiepNhanBenhNhan_txt_Ho.Text + "%' and Ten like N'%" + TiepNhanBenhNhan_txt_Ten.Text +
                    "%' and NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "' and CheckDaKham = 1 or SoDienThoai = N'"+ TiepNhanBenhNhan_txt_SDT.Text +"'";
                DataTable dt = connection.SQL(KiemTraTonTai);

                if ((dt.Rows.Count != 0) && (TiepNhanBenhNhan_txt_SDT.Text == dt.Rows[0][3].ToString()))
                {
                    if (MessageBox.Show("Bạn đã nhập trùng Số điện thoại: " + TiepNhanBenhNhan_txt_SDT.Text + "\n" +
                        "Vui lòng kiểm tra lại thông tin Bệnh nhân??!",
                        "Thông Báo nhập trùng Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                    }
                }
                else if (dt.Rows.Count >= 1)
                {
                    if (MessageBox.Show("Bạn đã nhập trùng Họ & Tên:" + TiepNhanBenhNhan_txt_Ho.Text + " " + TiepNhanBenhNhan_txt_Ten.Text + "\n" +
                        "Năm sinh: " + TiepNhanBenhNhan_dtP_namsinh.Text + "\n" +
                        "Bạn có muốn Thêm bệnh nhân vào hàng chờ khám??!",
                        "Thông Báo nhập trùng Thông Tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int ID_BenhNhan;
                        string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
                            + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
                        DataTable dt1 = connection.SQL(layMSBN);
                        ID_BenhNhan = int.Parse(dt1.Rows[0][0].ToString());
                        if(CheckTrungBenhNhanKhamTrongNgay(ID_BenhNhan, ngay + "/" + thang + "/" + nam)==false)
                        {
                            string query = @"begin if not exists (select HSKB.MaSoBenhNhan ,HSKB.NgayGioKham" +
                                        " from  BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan" +
                                        " where HSKB.MaSoBenhNhan = " + ID_BenhNhan + "and HSKB.NgayGioKham like '" + ngay + "/" + thang + "/" + nam + "%')" +
                                " begin insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                                + ID_BenhNhan + ","
                                + "N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "',"
                                + "'" + TiepNhanBenhNhan_dtP_NgayKham.Text + "')end end" +
                                "  update BenhNhan set CheckDaKham = 1 where MaSoBenhNhan = " + ID_BenhNhan;
                            connection.insert(query);
                            refresh_TiepNhanBenhNhan();
                        }                        
                    }
                }                
                else
                {
                    string query = @" insert into BenhNhan(Ho, Ten, NamSinh,DiaChi, SoDienThoai, GioiTinh,HinhAnh,CanNang,TenNguoiThan,CheckDaKham) values"
                   + "(N'" + TiepNhanBenhNhan_txt_Ho.Text + "',"
                   + "N'" + TiepNhanBenhNhan_txt_Ten.Text + "',"
                   + "'" + TiepNhanBenhNhan_dtP_namsinh.Text + "',"
                   + "N'" + TiepNhanBenhNhan_txt_DiaChi.Text + "',"
                   + "N'" + TiepNhanBenhNhan_txt_SDT.Text + "',"
                   + "N'" + TiepNhanBenhNhan_comB_GioiTinh.Text + "',"
                   + "N'" + hinhanh + "',"
                   + TiepNhanBenhNhan_txt_CanNang.Text + ","
                   + "N'" + TiepNhanBenhNhan_txt_TenNguoiThan.Text + "',"
                   + " 1 )";
                    connection.insert(query);

                    ThemChoKham_TiepNhanBenhNhan();

                    refresh_TiepNhanBenhNhan();                    
                    hoSoTaiKhamTableAdapter1.Fill(phongKhamDataSet.HoSoTaiKham);
                    //this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);
                    this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
                    this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);
                    MessageBox.Show("Nhập Thành công!", "Thông Báo Nhập");
                }
                dt.Dispose();

                connection.disconnect();
            }
        }
        private void ThemChoKham_TiepNhanBenhNhan()
        {
            int ID_BenhNhan;
            string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
                            + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
            DataTable dt = connection.SQL(layMSBN);
            ID_BenhNhan = int.Parse(dt.Rows[0][0].ToString());

            string query = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                + ID_BenhNhan + ","
                + "N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "',"
                + "'" + TiepNhanBenhNhan_dtP_NgayKham.Text + "')";
            connection.insert(query);
        }
        private void gridView1_TiepNhanBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            TiepNhanBenhNhan_btn_CapNhat.Enabled = true;
            TiepNhanBenhNhan_btn_Xoa.Enabled = true;
            TiepNhanBenhNhan_txt_LiDoKham.Text = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("LiDoKham").ToString();
            TiepNhanBenhNhan_dtP_NgayKham.Text = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("NgayGioKham").ToString();            
        }

        private void TiepNhanBenhNhan_btn_CapNhat_Click(object sender, EventArgs e)
        {
            connection.connect();
            string ID_MSKB = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString();

            string query1 = @"update HoSoKhamBenh set LiDoKham = N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "'," +
                "NgayGioKham ='" + TiepNhanBenhNhan_dtP_NgayKham.Text + "'" +
                " where MaSoKhamBenh =" + ID_MSKB;
            connection.sql(query1);
            connection.disconnect();
            refresh_TiepNhanBenhNhan();            
        }

        private void TiepNhanBenhNhan_btn_Xoa_Click(object sender, EventArgs e)
        {
            string ID_BenhNhan = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
            string ID_KhamBenh = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString();

            connection.connect();
            string query1 = @"delete from HoSoKhamBenh where MaSoBenhNhan = " + ID_BenhNhan + " and MaSoKhamBenh = "+ ID_KhamBenh;
            connection.delete(query1);
            connection.disconnect();
            refresh_TiepNhanBenhNhan();
        }
        
        private void barButtonItem2_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NhanVien_tabP_TiepNhanBenhNhan.Focus() == true)
            {
                function.ToExcel( result, TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham);
            }
            if (NhanVien_tabP_DanhSachBenhNhan.Focus() == true)
            {
                function.ToExcel(result, DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan);
            }
            if (NhanVien_tabP_DanhSachBenhNhanTaiKham.Focus() == true)
            {
                function.ToExcel( result, gridControl1_TimKiemBenhNhan);
            }
            if (xtra_TimBenhNhan.Focus() == true)
            {
                function.ToExcel(result, gridControl1_TimBenhNhan);
            }
        }
        private void barButtonItem1_Xuatfilekhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NhanVien_tabP_TiepNhanBenhNhan.Focus() == true)
            {
                TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.ShowRibbonPrintPreview();
            }
            if (NhanVien_tabP_DanhSachBenhNhan.Focus() == true)
            {
                DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan.ShowRibbonPrintPreview();
            }
            if (NhanVien_tabP_DanhSachBenhNhanTaiKham.Focus() == true)
            {
                gridControl1_TimKiemBenhNhan.ShowRibbonPrintPreview();
            }
            if (xtra_TimBenhNhan.Focus() == true)
            {
                gridControl1_TimBenhNhan.ShowRibbonPrintPreview();
            }
        }

        #endregion

        #region Tiếp nhận bệnh nhân cũ
        private void refresh_DanhSachBenhNhan()
        {
            function.ClearControl(panelControl4);
            
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);
            load_DanhSachBenhNhan_comB_GioiTinh();
            hinhanh = null;
            result = new DialogResult();
            panelControl4.Enabled = false;
        }
        private void load_DanhSachBenhNhan_comB_GioiTinh()
        {
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Nam");
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Nữ");
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Khác");
        }
        private void pictureBox1_DanhSachBenhNhan_DoubleClick(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_DanhSachBenhNhan.Image = Image.FromStream(open.OpenFile());
                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1,
                            open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_DanhSachBenhNhan.Image = new Bitmap(open.FileName);
            }
        }

        private void DanhSachBenhNhan_btn_DieuChinh_Click(object sender, EventArgs e)
        {
            
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                if (function.checkNull(panelControl4) == true)//kiểm tra các thành phần có rỗng hay không
                {
                    connection.connect();
                    string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
                
                    if (pictureBox1_DanhSachBenhNhan.Image != null)//kiểm tra picturebox có rỗng hay không
                    {
                        if (result == DialogResult.OK)
                        {
                            string previewPath = Application.StartupPath + @"\Hinh\BenhNhan\" + hinhanh;
                            string linkHinhAnh = open.FileName;
                            File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                        }
                        else
                        {
                            string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
                            DataTable dt1 = connection.SQL(layhinhanh);
                            hinhanh = dt1.Rows[0][0].ToString();
                        }
                    }
                    else { }

                    string query = @"update BenhNhan set Ho = N'" + DanhSachBenhNhan_txt_Ho.Text + "'," +
                    "Ten = N'" + DanhSachBenhNhan_txt_Ten.Text + "'," +
                    "SoDienThoai = N'" + DanhSachBenhNhan_txt_SDT.Text + "'," +
                    "GioiTinh = N'" + DanhSachBenhNhan_comB_GioiTinh.Text + "'," +
                    "NamSinh ='" + DanhSachBenhNhan_dtP_NamSinh.Text + "'," +
                    "DiaChi = N'" + DanhSachBenhNhan_txt_DiaChi.Text + "'," +
                    "HinhAnh = N'" + hinhanh + "'," +
                    "TenNguoiThan = N'" + DanhSachBenhNhan_txt_TenNguoiThan.Text + "'," +
                    "CanNang = " + DanhSachBenhNhan_txt_CanNang.Text +
                    " where MaSoBenhNhan =" + ID;
                    connection.sql(query);

                    connection.disconnect();
                    refresh_DanhSachBenhNhan();
                }
            }
            
        }
        private void DanhSachBenhNhan_btn_ThemCho_Click(object sender, EventArgs e)
        {
            
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                
                connection.connect();
                int ID_BenhNhan = int.Parse(gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
                string ngaykham;
                string lidokham;
                themCho = new ThemCho();
                themCho.ShowDialog();

                ngaykham = themCho.ngaykham;
                lidokham = themCho.lidokham;
                string ngaykhamCheck = ngay + "/" + thang + "/" + nam;
                if (CheckTrungBenhNhanKhamTrongNgay(ID_BenhNhan,ngaykhamCheck) == false)
                {
                    string query = @"begin if not exists (select HSKB.MaSoBenhNhan ,HSKB.NgayGioKham" +
                                    " from  BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan" +
                                        " where HSKB.MaSoBenhNhan = " + ID_BenhNhan + "and HSKB.NgayGioKham like '" + ngaykhamCheck + "%')" +
                                 " begin insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                    + ID_BenhNhan + ","
                    + "N'" + lidokham + "',"
                    + "'" + ngaykham + "') end end";
                    connection.insert(query);
                    connection.disconnect();
                    refresh_DanhSachBenhNhan();
                }
                connection.disconnect();

            }
            
        }
        private bool CheckTrungBenhNhanKhamTrongNgay(int ID_BenhNhan, string ngaykhamCheck)
        {
            bool a;            
            string CheckBenhNhanKhamTrongNgay = @"select HSKB.MaSoBenhNhan ,HSKB.NgayGioKham" +
                                    " from  BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan" +
                                        " where HSKB.MaSoBenhNhan = " + ID_BenhNhan + "and HSKB.NgayGioKham like '" + ngaykhamCheck + "%'";
            DataTable dt = connection.SQL(CheckBenhNhanKhamTrongNgay);
            if(dt.Rows.Count > 0)
            {
                function.Notice("Bệnh nhân đã được thêm vào hàng chờ khám trong ngày"+"\n"+"Bạn vui lòng kiểm tra lại.", 0);
                a = true;
                return a;
            }
            else { a = false; return a; }
        }

        private void gridView4_DanhSachBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            panelControl4.Enabled = true;
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if(ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
                DanhSachBenhNhan_txt_Ho.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("Ho").ToString();
                DanhSachBenhNhan_txt_Ten.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("Ten").ToString();
                DanhSachBenhNhan_dtP_NamSinh.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("NamSinh").ToString();
                DanhSachBenhNhan_comB_GioiTinh.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("GioiTinh").ToString();
                DanhSachBenhNhan_txt_SDT.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("SoDienThoai").ToString();
                DanhSachBenhNhan_txt_DiaChi.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("DiaChi").ToString();
                DanhSachBenhNhan_txt_CanNang.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("CanNang").ToString();
                DanhSachBenhNhan_txt_TenNguoiThan.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("TenNguoiThan").ToString();

                connection.connect();
                string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
                cmd = new SqlCommand(layhinhanh, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
                    {
                        //kiểm tra hình ảnh có trong thư mục hay không
                        if (File.Exists(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString()))
                        {
                            //có thì sẽ load hình ảnh vào pictureBox
                            pictureBox1_DanhSachBenhNhan.Image = new Bitmap(Application.StartupPath + @"\Hinh\BenhNhan\" +
                                                                            dr["hinhanh"].ToString());
                        }
                        else
                        {
                            //không thì hiện thông báo
                            function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
                            pictureBox1_DanhSachBenhNhan.Image = null;
                        }
                    }
                    else
                    {
                        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
                        pictureBox1_DanhSachBenhNhan.Image = null;
                        continue;
                    }
                }
                dr.Close();
                connection.disconnect();
            }
            else { }            
        }

        private void gridView4_DanhSachBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void gridView4_DanhSachBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            { // Double Click
                string cellValue = e.CellValue.ToString();
                MessageBox.Show(cellValue);
            }
        }

        private void DanhSachBenhNhan_btn_Xoa_Click(object sender, EventArgs e)
        {
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();

                connection.connect();
                string query1 = @"delete from BenhNhan where MaSoBenhNhan = " + ID;
                connection.delete(query1);
                connection.disconnect();
                refresh_DanhSachBenhNhan();
            }
        }
        #endregion

        #region Tiếp Nhận bệnh nhân tái khám
        private void refresh_TimKiemBenhNhan()//Tiếp Nhận bệnh nhân tái khám
        {            
            function.ClearControl(panelControl5);            
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            this.hoSoTaiKhamTableAdapter1.Fill(this.phongKhamDataSet.HoSoTaiKham);
            TimKiemBenhNhanKham_btn_ThemChoTaiKham.Enabled = false;
            TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Enabled = false;
        }
        
        private void gridView1_TimKiemBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            TimKiemBenhNhanKham_btn_ThemChoTaiKham.Enabled = true;
            TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Enabled = true;
        }
        

        private void gridView1_TimKiemBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void TimKiemBenhNhanKham_btn_ThemChoTaiKham_Click(object sender, EventArgs e)
        {
            connection.connect();
            //lấy thông tin khi click chuột vào gridview
            int KiemTraTaiKham = 1;
            string ngaykhamCheck = TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Value.Day.ToString("d2") + "/" +
                                    TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Value.Month.ToString("d2") + "/" + 
                                    TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Value.Year.ToString();
            //tạo object và gán cho cột khi row click để kiểm tra khi sử dụng chức năng group column
            object ID_BenhNhan_CheckNull = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            //sử dụng if để kiểm tra rỗng. Nếu không rỗng thì tiếp tục chức năng
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                int ID_BenhNhan = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
                int ID_MSKB_old = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
                string LiDoKham = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("LiDoKham").ToString();
                string Check_ID_MSKB_OLD_CoTonTai = @"select MaSoKhamBenh from HoSoTaiKham where MaSoKhamBenh =" + ID_MSKB_old;
                DataTable dataTable0 = connection.SQL(Check_ID_MSKB_OLD_CoTonTai);
                if (dataTable0.Rows.Count >= 1)//kiểm tra tồn tại của cột trong sql
                {
                    function.Notice("Hồ Sơ số " + ID_MSKB_old + " đã có Tái khám!", 0);
                }
                else
                {
                    if (CheckTrungBenhNhanKhamTrongNgay(ID_BenhNhan, ngaykhamCheck) == false)
                    {
                        string Insert_HSKB = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham,KiemTraTaiKham) values ("
                                + ID_BenhNhan + ","
                                + "N'" + LiDoKham + "',"
                                + "'" + TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Text + "',"
                                + KiemTraTaiKham + ")";
                        connection.insert(Insert_HSKB);

                        //lấy ID MSKB mới khi vừa insert vào hồ sơ khám bệnh
                        string LayID_MSKB_New = @"select MaSoKhamBenh from HoSoKhamBenh"
                            + " where MaSoBenhNhan = " + ID_BenhNhan + " AND"
                            + " LiDoKham = N'" + LiDoKham + "' AND "
                            + " NgayGioKham = '" + TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Text + "' AND "
                            + " KiemTraTaiKham = " + KiemTraTaiKham;
                        DataTable dataTable = connection.SQL(LayID_MSKB_New);
                        int ID_MSKB_New = int.Parse(dataTable.Rows[0][0].ToString());

                        //insert vào hồ sơ tái khám
                        string Insert_HSTK = @"insert into HoSoTaiKham(MaSoTaiKham,MaSoKhamBenh,MaSoBenhNhan) values ("
                            + ID_MSKB_New + ","
                            + ID_MSKB_old + ","
                            + ID_BenhNhan + ")";
                        connection.insert(Insert_HSTK);
                        MessageBox.Show("Nhập Bệnh nhân tái khám thành công!", "Thông Báo Nhập");
                        connection.disconnect();
                        refresh_TimKiemBenhNhan();
                    }
                    
                }
                //insert vào Hồ sơ khám bệnh
            }
            else { }
        }
        #endregion
        
        #region Tìm kiếm bệnh nhân khám
        private void gridView1_TimBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void refresh_TimKiemBenhNhanTaiKham()
        {
            function.ClearControl(panelControl3);
            function.ClearControl(panelControl1);
            TimKiemBenhNhanKham_btn_XoaHoSo.Enabled = false;
            clTimBenhNhan_NgayTaiKham.Visible = false;
            clTimBenhNhan_NgayKham.Visible = false;
        }
        private void TimKiemBenhNhanKham_btn_TimKiemNgayKham_Click(object sender, EventArgs e)//tìm kiếm hồ sơ theo ngày khám
        {
            gridView1_TimBenhNhan.FindFilterText = "";
            if (TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked)//kiểm tra check tìm theo ngày hay tháng
            {                
                gridView1_TimBenhNhan.ClearGrouping();//clear group column trong gridview
                clTimBenhNhan_NgayTaiKham.Visible = false;
                clTimBenhNhan_NgayKham.GroupIndex = 1;//group column ngày khám 
                //đưa text ngày khám vào phần tìm kiếm trong gridview
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_NgayKham.Text;
            }
            else if (TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked)
            {                
                gridView1_TimBenhNhan.ClearGrouping();//clear group column trong gridview
                clTimBenhNhan_NgayTaiKham.Visible = false;
                clTimBenhNhan_NgayKham.GroupIndex = 1;//group column ngày khám 
                //đưa text tháng + năm khám vào phần tìm kiếm trong gridview
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_NgayKham.Value.Month.ToString("d2") 
                                                + "/" + TimKiemBenhNhanKhamBenh_dtP_NgayKham.Value.Year.ToString();
            }
        }
        private void TimKiemBenhNhanKham_btn_TimKiemTaiKham_Click(object sender, EventArgs e)//tìm kiếm hồ sơ theo ngày tái khám
        {
            gridView1_TimBenhNhan.FindFilterText = "";
            if (TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked)//kiểm tra check tìm theo ngày hay tháng
            {                
                gridView1_TimBenhNhan.ClearGrouping();//clear group column trong gridview
                clTimBenhNhan_NgayKham.Visible = false;
                clTimBenhNhan_NgayTaiKham.GroupIndex = 1;//group column ngày tái khám
                //đưa text ngày khám vào phần tìm kiếm trong gridview
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_TaiKham.Text;
            }
            else if (TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked)
            {                
                gridView1_TimBenhNhan.ClearGrouping();//clear group column trong gridview
                clTimBenhNhan_NgayKham.Visible = false;
                clTimBenhNhan_NgayTaiKham.GroupIndex = 1;//group column ngày tái khám 
                //đưa text tháng + năm khám vào phần tìm kiếm trong gridview
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_TaiKham.Value.Month.ToString("d2")
                                                + "/" + TimKiemBenhNhanKhamBenh_dtP_TaiKham.Value.Year.ToString();
            }
        }
        private void gridView1_TimBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            object ID_MSKB_CheckNull = gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh");
            if (ID_MSKB_CheckNull != null && ID_MSKB_CheckNull != DBNull.Value)
            {
                TimKiemBenhNhanKham_btn_XoaHoSo.Enabled = true;
                int ID_MSKB = int.Parse(gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            }
        }
        private void TimKiemBenhNhanKham_btn_XoaHoSo_Click(object sender, EventArgs e)
        {
            object ID_MSKB_CheckNull = gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh");
            if (ID_MSKB_CheckNull != null && ID_MSKB_CheckNull != DBNull.Value)
            {
                int ID_MSKB = int.Parse(gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());

                connection.connect();
                string query1 = @"delete from HoSoKhamBenh where MaSoKhamBenh = " + ID_MSKB;
                connection.delete(query1);
                this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
                connection.disconnect();
                refresh_TimKiemBenhNhanTaiKham();
            }
        }
        private void TimKiemBenhNhanKhamBenh_checB_NgayKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_ThangKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_NgayTaiKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_ThangTaiKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked = false;
            TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked = false;
        }
        #endregion              
    }

}