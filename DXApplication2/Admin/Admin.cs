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
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;

namespace QuanLyPhongKham
{
    public partial class Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlCommand cmd;
        OpenFileDialog open;        
        DialogResult result;
        #endregion
        #region Biến khởi tạo
        public static bool IfAdmin;
        bool textchanged = false;
        int ID_Loaithuoc { get; set; }
        string hinhanh = null;
        string MatkhauSoSanh;
        #endregion
        public Admin()
        {
            InitializeComponent();
        }

        public void Admin_Load(object sender, EventArgs e)
        {
            phongKhamDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'phongKhamDataSet.VatDung' table. You can move, or remove it, as needed.
            this.vatDungTableAdapter.Fill(this.phongKhamDataSet.VatDung);

            // TODO: This line of code loads data into the 'phongKhamDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.phongKhamDataSet.NhanVien);
            load_qlyNhanVien_comB_Gioitinh();
            load_qlyNhanVien_comB_ViTri();
            load_qlyNhanVien_comB_QuyenTruyCap();

            // TODO: This line of code loads data into the 'phongKhamDataSet.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);
            load_qlyThuoc_comB_loaithuoc();
            load_qlyThuoc_comB_donvitinh();
            load_qlyThuoc_comB_donvitinhnhonhat();

            LoadForm();//khởi tạo các form khác khi hiện form Admin
            function.Timer_load(timer_tick);
        }
        #region Chức năng chung của Form
        public void LoadForm()
        {
            Winform.themLoaiThuoc = new ThemLoaiThuoc();
            Winform.bacSi = new BacSi();
            Winform.nhanVien = new NhanVien();
            Winform.duocSi = new DuocSi();
            Winform.nhanVienThuNgan = new NhanVienThuNgan();
        }

        public void timer_tick(object sender, EventArgs e)
        {
            int qlythuoc = gridView1_thuoc.FocusedRowHandle;
            int qlynhanvien = gridView1_NhanVien.FocusedRowHandle;
            int qlyvatdung = gridView1_VatDung.FocusedRowHandle;

            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);
            this.nhanVienTableAdapter.Fill(this.phongKhamDataSet.NhanVien);
            this.vatDungTableAdapter.Fill(this.phongKhamDataSet.VatDung);

            gridView1_thuoc.FocusedRowHandle = qlythuoc;
            gridView1_NhanVien.FocusedRowHandle = qlynhanvien;
            gridView1_VatDung.FocusedRowHandle = qlyvatdung;
            txt_capnhat.Text = "Cập nhật lúc: " + DateTime.Now.Hour.ToString() + " giờ : " + DateTime.Now.Minute.ToString() + " phút";
        }
        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion

        #region Ribbon Admin
        public void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)//nút refresh toàn form
        {
            refresh_qlyThuoc();
            refresh_qlyNhanVien();
            refresh_qlyVatDung();

            function.ClearFilterText(gridView1_thuoc);
            function.ClearFilterText(gridView1_NhanVien);
            function.ClearFilterText(gridView1_VatDung);
        }
        private void barButtonItem1_BacSi_ItemClick(object sender, ItemClickEventArgs e)
        {
            IfAdmin = true;
            Winform.bacSi.Refresh_BacSi();
            Winform.bacSi.ShowDialog();
        }

        private void barButtonItem2_DuocSi_ItemClick(object sender, ItemClickEventArgs e)
        {
            IfAdmin = true;
            Winform.duocSi.refresh_DuocSi();
            Winform.duocSi.ShowDialog();
        }

        private void barButtonItem3_TiepTan_ItemClick(object sender, ItemClickEventArgs e)
        {
            IfAdmin = true;
            Winform.nhanVien.RefreshAll();
            Winform.nhanVien.ShowDialog();
        }

        private void barButtonItem4_ThuNgan_ItemClick(object sender, ItemClickEventArgs e)
        {
            IfAdmin = true;
            Winform.nhanVienThuNgan.refresh_HoaDon();
            Winform.nhanVienThuNgan.ShowDialog();
        }
        
        private void barButtonItem1_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (admin_tabP_qlyThuoc.Focus() == true)
            {
                function.ToExcel(result, gridControl1);
            }
            if (admin_tabP_qlyNhanvien.Focus() == true)
            {
                function.ToExcel(result, gridControl2);
            }
            if (admin_tabP_qlyVatdung.Focus() == true)
            {
                function.ToExcel(result, gridControl3);
            }
        }
        private void barButtonItem1_XuatDinhDang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (admin_tabP_qlyThuoc.Focus() == true)
            {
                gridControl1.ShowRibbonPrintPreview();
            }
            if (admin_tabP_qlyNhanvien.Focus() == true)
            {
                gridControl2.ShowRibbonPrintPreview();
            }
            if (admin_tabP_qlyVatdung.Focus() == true)
            {
                gridControl3.ShowRibbonPrintPreview();
            }
        }
        #endregion

        #region form Thuốc        
        private void gridView1_thuoc_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)//vẽ cột số thứ tự cho gridview
        {
                function.CustomDrawRowIndicator(sender, e);
        }
        private void gridView1_thuoc_RowCountChanged(object sender, EventArgs e)//đếm số Row cho gridview
        {
                function.RowCountChanged(sender, e);
        }

        public void refresh_ComboBoxLoaiThuoc()//hàm refresh ComboBoxLoaiThuoc
        {
            qlyThuoc_comB_loaithuoc.SelectedIndex = 0;
            qlyThuoc_comB_loaithuoc.Text = "";
            qlyThuoc_comB_loaithuoc.Items.Clear();
            load_qlyThuoc_comB_loaithuoc();            
        }
        public void refresh_qlyThuoc()//hàm refresh tab QlyThuoc
        {
            function.ClearControl(panelControl1);
            load_qlyThuoc_comB_loaithuoc();
            load_qlyThuoc_comB_donvitinh();
            load_qlyThuoc_comB_donvitinhnhonhat();
            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);
            hinhanh = null;
            result = new DialogResult();//khởi tạo lại biến result để nhấn vào chọn hình mới trong Picturebox 
            qlyThuoc_btn_capnhat.Enabled = false;
            qlyThuoc_btn_xoa.Enabled = false;
        }
        #region Load dữ liệu cho comboBox Form Thuốc
        public void load_qlyThuoc_comB_loaithuoc()//load ComboBox loại thuốc
        {
            connection.connect();
            string query = @"select tenloaithuoc from loaithuoc";            
            cmd = new SqlCommand(query, connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tenloaithuoc = dr["tenloaithuoc"].ToString();
                qlyThuoc_comB_loaithuoc.Items.Add(tenloaithuoc) ;
            }
            dr.Close();
            connection.disconnect();
        }

        private void load_qlyThuoc_comB_donvitinh()//load ComboBox Đơn Vị Tính Lớn nhất
        {
            qlyThuoc_comB_donvitinh.Items.Add("Thùng");
            qlyThuoc_comB_donvitinh.Items.Add("Hộp");
            qlyThuoc_comB_donvitinh.Items.Add("Lon");
            
        }
        private void load_qlyThuoc_comB_donvitinhnhonhat()//load ComboBox Đơn Vị Tính Lớn nhất
        {
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Viên");
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Vĩ");
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Tuýp");
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Chai");
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Lọ");
            qlyThuoc_comB_donvitinhnhonhat.Items.Add("Bình");
        }
        #endregion

        private void pictureBox1_Thuoc_DoubleClick(object sender, EventArgs e)//sự kiện khi nhấp double vào Picture Box
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_Thuoc.Image = Image.FromStream(open.OpenFile());
                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_Thuoc.Image = new Bitmap(open.FileName);
            }
        }

        #region Ràng buộc không được nhập ký tự
        private void qlyThuoc_txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)//không được nhập kí tự
        {
            function.KoNhapKiTu(sender, e);
        }
        private void qlyThuoc_txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)//không được nhập kí tự
        {
            function.KoNhapKiTu(sender, e);
        }
        private void qlyThuoc_txt_DonGiaNhoNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void qlyThuoc_txt_SoLuongNhoNhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        #endregion

        private void qlyThuoc_comB_loaithuoc_SelectedIndexChanged(object sender, EventArgs e)//Lấy mã loại thuốc khi chọn ComboBox Loại Thuốc
        {
            string tenloaithuoc = qlyThuoc_comB_loaithuoc.SelectedItem.ToString();
            string query = @"select masoloaithuoc from loaithuoc where tenloaithuoc = N'" + tenloaithuoc + "'";
            connection.connect();
            DataTable dt = connection.SQL(query);
            if(dt.Rows.Count <= 0)
            {
                refresh_ComboBoxLoaiThuoc();
            }
            else
            {
                ID_Loaithuoc = int.Parse(dt.Rows[0][0].ToString());
            }
            
        }

        private void gridView1_thuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)//Sự kiện khi chọn vào hàng trong gridview
        {
            object ID_Thuoc_CheckNull = gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc");
            if (ID_Thuoc_CheckNull != null && ID_Thuoc_CheckNull != DBNull.Value)
            {
                qlyThuoc_btn_capnhat.Enabled = true;
                qlyThuoc_btn_xoa.Enabled = true;

                string ID = gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc").ToString();
                string MaSoLoaiThuoc = gridView1_thuoc.GetFocusedRowCellValue("MaSoLoaiThuoc").ToString();
                qlyThuoc_txt_tenthuoc.Text = gridView1_thuoc.GetFocusedRowCellValue("TenThuoc").ToString();
                qlyThuoc_txt_SoLuong.Text = gridView1_thuoc.GetFocusedRowCellValue("SoLuong").ToString();
                qlyThuoc_txt_DonGia.Text = gridView1_thuoc.GetFocusedRowCellValue("DonGia").ToString();
                qlyThuoc_txt_cachdung.Text = gridView1_thuoc.GetFocusedRowCellValue("CachDung").ToString();
                qlyThuoc_dtP_ngaytao.Text = gridView1_thuoc.GetFocusedRowCellValue("NgayNhap").ToString();
                qlyThuoc_comB_donvitinh.Text = gridView1_thuoc.GetFocusedRowCellValue("DonViTinh").ToString();
                qlyThuoc_comB_donvitinhnhonhat.Text = gridView1_thuoc.GetFocusedRowCellValue("DonViTinhNhoNhat").ToString();
                qlyThuoc_txt_SoLuongNhoNhat.Text = gridView1_thuoc.GetFocusedRowCellValue("SoLuongNhoNhat").ToString();
                qlyThuoc_txt_DonGiaNhoNhat.Text = gridView1_thuoc.GetFocusedRowCellValue("DonGiaNhoNhat").ToString();

                connection.connect();
                string laytenloaithuoc = @"select tenloaithuoc from loaithuoc where masoloaithuoc = " + MaSoLoaiThuoc;
                if (MaSoLoaiThuoc != "")
                {
                    DataTable dt = connection.SQL(laytenloaithuoc);
                    qlyThuoc_comB_loaithuoc.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    qlyThuoc_comB_loaithuoc.Text = "";
                }

                string layhinhanh = @"select hinhanh from thuoc where MaSoThuoc = " + ID;
                cmd = new SqlCommand(layhinhanh, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
                    {
                        if (File.Exists(Application.StartupPath + @"\Hinh\Thuoc\" + dr["hinhanh"].ToString()))//kiểm tra hình ảnh có trong thư mục hay không
                        {
                            //có thì sẽ load hình ảnh vào pictureBox
                            pictureBox1_Thuoc.Image = new Bitmap(Application.StartupPath + @"\Hinh\Thuoc\" + dr["hinhanh"].ToString());
                        }
                        else
                        {
                            //không thì hiện thông báo
                            //function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
                            pictureBox1_Thuoc.Image = null;
                        }
                    }
                    else
                    {
                        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
                        pictureBox1_Thuoc.Image = null;
                        continue;
                    }
                }
                dr.Close();
                connection.disconnect();
            }
        }
        #region Chức năng Thêm, Xóa, Sửa
        private void qlyThuoc_btn_themloaithuoc_Click(object sender, EventArgs e)//chuyển sang form thêm loại thuốc
        {            
            Winform.themLoaiThuoc.ShowDialog();
        }

        private void qlyThuoc_btn_taomoi_Click(object sender, EventArgs e)//sự kiện nút Tạo mới
        {
            if (function.checkNull(panelControl1) == true)
            {
                connection.connect();
                //kiểm tra tên thuốc có bị trùng hay không
                string checktenthuoc = @"select top 1 tenthuoc from thuoc where tenthuoc = N'" + qlyThuoc_txt_tenthuoc.Text + "'";
                cmd = new SqlCommand(checktenthuoc, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();

                //hinhanh = null;
                if (pictureBox1_Thuoc.Image != null)//kiểm tra picturebox có rỗng hay không
                {
                    if (result == DialogResult.OK)
                    {
                        hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                        string previewPath = Application.StartupPath + @"\Hinh\Thuoc\" + hinhanh;
                        string linkHinhAnh = open.FileName;
                        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                    }
                    else { }
                }
                else { }

                if (dr.Read())
                {
                    function.Notice("Bạn nhập trùng tên thuốc!", 0);
                }
                else
                {
                    dr.Close();
                    string query = @" insert into thuoc(masoloaithuoc,tenthuoc,soluong,dongia,donvitinh,ngaynhap,cachdung,hinhanh,DonViTinhNhoNhat,SoLuongNhoNhat,DonGiaNhoNhat) values ("
                        + ID_Loaithuoc + ",N'"
                        + qlyThuoc_txt_tenthuoc.Text + "',"
                        + qlyThuoc_txt_SoLuong.Text + ","
                        + qlyThuoc_txt_DonGia.Text + ",N'"
                        + qlyThuoc_comB_donvitinh.Text + "','"
                        + qlyThuoc_dtP_ngaytao.Text + "',N'"
                        + qlyThuoc_txt_cachdung.Text + "',N'"
                        + hinhanh + "',N'"
                        + qlyThuoc_comB_donvitinhnhonhat.Text + "',"
                        + qlyThuoc_txt_SoLuongNhoNhat.Text + ","
                        + qlyThuoc_txt_DonGiaNhoNhat.Text + ") ";
                    connection.insert(query);
                    connection.disconnect();
                    refresh_qlyThuoc();
                }

            }
        }

        private void qlyThuoc_btn_xoa_Click(object sender, EventArgs e)//sự kiện nút xóa
        {
            object ID_Thuoc_CheckNull = gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc");
            if (ID_Thuoc_CheckNull != null && ID_Thuoc_CheckNull != DBNull.Value)
            {
                string ID = gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc").ToString();

                connection.connect();
                string query = @"delete from thuoc where masothuoc = " + ID;
                connection.delete(query);
                connection.disconnect();
                refresh_qlyThuoc();

            }
        }
      
        private void qlyThuoc_btn_capnhat_Click(object sender, EventArgs e)//sự kiện nút cập nhật
        {
            object ID_Thuoc_CheckNull = gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc");
            if (ID_Thuoc_CheckNull != null && ID_Thuoc_CheckNull != DBNull.Value)
            {
                if (function.checkNull(panelControl1) == true)//kiểm tra các thành phần có rỗng hay không
                {
                    connection.connect();
                    int ID = int.Parse(gridView1_thuoc.GetFocusedRowCellValue("MaSoThuoc").ToString());

                    var tenloaithuoc = qlyThuoc_comB_loaithuoc.SelectedItem;
                    string laymasoloaithuoc = @"select masoloaithuoc from loaithuoc where tenloaithuoc = N'" + tenloaithuoc + "'";
                    DataTable dt = connection.SQL(laymasoloaithuoc);
                    ID_Loaithuoc = int.Parse(dt.Rows[0][0].ToString());

                    if (pictureBox1_Thuoc.Image != null)//kiểm tra picturebox có rỗng hay không
                    {
                        if (result == DialogResult.OK)
                        {
                            string previewPath = Application.StartupPath + @"\Hinh\Thuoc\" + hinhanh;
                            string linkHinhAnh = open.FileName;
                            File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                        }
                        else
                        {
                            string layhinhanh = @"select hinhanh from thuoc where MaSoThuoc = " + ID;
                            DataTable dt1 = connection.SQL(layhinhanh);
                            hinhanh = dt1.Rows[0][0].ToString();
                        }
                    }
                    else { }

                    string query = @"update Thuoc set TenThuoc = N'" + qlyThuoc_txt_tenthuoc.Text +
                    "', CachDung = N'" + qlyThuoc_txt_cachdung.Text + "'," +
                    "SoLuong =" + qlyThuoc_txt_SoLuong.Text + "," +
                    "DonGia =" + qlyThuoc_txt_DonGia.Text + "," +
                    "NgayNhap ='" + qlyThuoc_dtP_ngaytao.Text + "'," +
                    "MaSoLoaiThuoc =" + ID_Loaithuoc + "," +
                    "DonViTinh=N'" + qlyThuoc_comB_donvitinh.Text + "'," +
                    "HinhAnh = N'" + hinhanh + "'," +
                    " DonViTinhNhoNhat = N'" + qlyThuoc_comB_donvitinhnhonhat.Text + "'," +
                    " SoLuongNhoNhat = " + qlyThuoc_txt_SoLuongNhoNhat.Text + "," +
                    " DonGiaNhoNhat = " + qlyThuoc_txt_DonGiaNhoNhat.Text +
                    " where MaSoThuoc =" + ID;
                    connection.sql(query);
                    connection.disconnect();
                    refresh_qlyThuoc();
                }
            }
        }
        #endregion

        #endregion

        #region form Nhân Viên
        #region Chức năng phụ trong Tab Nhân viên
        private void qlyNhanvien_txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void qlyNhanvien_txt_Luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void gridView1_NhanVien_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_NhanVien_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void qlyNhanvien_txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            textchanged = true;
        }
        private bool txt_matkhau_changed()
        {
            return true;
        }
        private void refresh_qlyNhanVien()
        {
            function.ClearControl(panelControl3_NhanVien);
            this.nhanVienTableAdapter.Fill(this.phongKhamDataSet.NhanVien);
            load_qlyNhanVien_comB_Gioitinh();
            load_qlyNhanVien_comB_ViTri();
            load_qlyNhanVien_comB_QuyenTruyCap();
            hinhanh = null;
            result = new DialogResult();
            qlyNhanvien_btn_capnhat.Enabled = false;
            qlyNhanvien_btn_xoa.Enabled = false;
        }
        #endregion
        #region Load ComboBox
        private void load_qlyNhanVien_comB_Gioitinh()//load ComboBox giới Tính
        {
            qlyNhanvien_comB_gioitinh.Items.Add("Nam");
            qlyNhanvien_comB_gioitinh.Items.Add("Nữ");
            qlyNhanvien_comB_gioitinh.Items.Add("Khác");
            
        }
        private void load_qlyNhanVien_comB_ViTri()//load ComboBox Vị trí 
        {
            qlyNhanvien_comB_vitri.Items.Add("Điều dưỡng");
            qlyNhanvien_comB_vitri.Items.Add("Bác Sĩ");
            qlyNhanvien_comB_vitri.Items.Add("Giao thuốc");
            qlyNhanvien_comB_vitri.Items.Add("Thu Ngân");
        }
        private void load_qlyNhanVien_comB_QuyenTruyCap()//load ComboBox Quyền truy cập
        {
            qlyNhanvien_comB_QuyenTruyCap.Items.Add("Điều dưỡng    (2)");
            qlyNhanvien_comB_QuyenTruyCap.Items.Add("Bác Sĩ             (3)");
            qlyNhanvien_comB_QuyenTruyCap.Items.Add("Giao thuốc     (4)");
            qlyNhanvien_comB_QuyenTruyCap.Items.Add("Thu ngân       (5)");
        }
        #endregion        
        
        int quyentruycap;
        private void qlyNhanvien_comB_QuyenTruyCap_SelectedIndexChanged(object sender, EventArgs e)//lấy quyền truy cập
        {
            
            if(qlyNhanvien_comB_QuyenTruyCap.SelectedIndex == 0)
            {
                quyentruycap = 2;//Tiếp tân
            }
            else if (qlyNhanvien_comB_QuyenTruyCap.SelectedIndex == 1)
            {
                quyentruycap = 3;//Bác sĩ
            }
            else if (qlyNhanvien_comB_QuyenTruyCap.SelectedIndex == 2)
            {
                quyentruycap = 4;//Dược sĩ
            }
            else if (qlyNhanvien_comB_QuyenTruyCap.SelectedIndex == 3)
            {
                quyentruycap = 5;//Thu ngân
            }
        }
        private void pictureBox1_NhanVien_DoubleClick(object sender, EventArgs e)//Thêm hình ảnh
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_NhanVien.Image = Image.FromStream(open.OpenFile());

                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_NhanVien.Image = new Bitmap(open.FileName);
            }
        }
        private void gridView1_NhanVien_RowClick(object sender, RowClickEventArgs e)
        {
            object ID_NhanVien_CheckNull = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien");
            if (ID_NhanVien_CheckNull != null && ID_NhanVien_CheckNull != DBNull.Value)
            {
                qlyNhanvien_btn_capnhat.Enabled = true;
                qlyNhanvien_btn_xoa.Enabled = true;
                string ID = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien").ToString();
                qlyNhanvien_txt_hoten.Text = gridView1_NhanVien.GetFocusedRowCellValue("TenNhanVien").ToString();
                qlyNhanvien_comB_gioitinh.Text = gridView1_NhanVien.GetFocusedRowCellValue("GioiTinh").ToString();
                qlyNhanvien_txt_sdt.Text = gridView1_NhanVien.GetFocusedRowCellValue("SoDienThoai").ToString();
                qlyNhanvien_comB_vitri.Text = gridView1_NhanVien.GetFocusedRowCellValue("ViTri").ToString();
                qlyNhanvien_dtP_ngaysinh.Text = gridView1_NhanVien.GetFocusedRowCellValue("NgaySinh").ToString();
                qlyNhanvien_txt_diachi.Text = gridView1_NhanVien.GetFocusedRowCellValue("DiaChi").ToString();
                qlyNhanvien_dtP_ngaytao.Text = gridView1_NhanVien.GetFocusedRowCellValue("NgayTao").ToString();
                qlyNhanvien_txt_taikhoan.Text = gridView1_NhanVien.GetFocusedRowCellValue("TaiKhoan").ToString();
                MatkhauSoSanh = qlyNhanvien_txt_matkhau.Text = gridView1_NhanVien.GetFocusedRowCellValue("MatKhau").ToString();
                qlyNhanvien_comB_QuyenTruyCap.Text = gridView1_NhanVien.GetFocusedRowCellValue("QuyenTruyCap").ToString();
                qlyNhanvien_txt_Luong.Text = gridView1_NhanVien.GetFocusedRowCellValue("Luong").ToString();

                connection.connect();
                string layhinhanh = @"select hinhanh from NhanVien where MaSoNhanVien = " + ID;
                cmd = new SqlCommand(layhinhanh, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
                    {
                        if (File.Exists(Application.StartupPath + @"\Hinh\NhanVien\" + dr["hinhanh"].ToString()))//kiểm tra hình ảnh có trong thư mục hay không
                        {
                            //có thì sẽ load hình ảnh vào pictureBox
                            pictureBox1_NhanVien.Image = new Bitmap(Application.StartupPath + @"\Hinh\NhanVien\" + dr["hinhanh"].ToString());
                        }
                        else
                        {
                            //không thì hiện thông báo
                            //function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
                            pictureBox1_NhanVien.Image = null;
                        }
                    }
                    else
                    {
                        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
                        pictureBox1_NhanVien.Image = null;
                        continue;
                    }
                }
                dr.Close();

                connection.disconnect();
            }
        }
        #region Thêm, Xóa, Sửa Tab Nhân Viên
        private void qlyNhanvien_btn_taomoi_Click(object sender, EventArgs e)
        {
            if (function.checkNull(panelControl3_NhanVien) == true)
            {
                connection.connect();

                var matkhau = function.toMD5(qlyNhanvien_txt_matkhau.Text);

                //result = new DialogResult();
                if (pictureBox1_NhanVien.Image != null)//kiểm tra picturebox có rỗng hay không
                {
                    if (result == DialogResult.OK)
                    {
                        hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                        string previewPath = Application.StartupPath + @"\Hinh\NhanVien\" + hinhanh;
                        string linkHinhAnh = open.FileName;
                        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                    }
                    else { }
                }
                else { }

                string CheckTrungTaiKhoan = @"select TaiKhoan from NhanVien where TaiKhoan = N'" + qlyNhanvien_txt_taikhoan.Text + "'";                
                DataTable TrungTaiKhoan = connection.SQL(CheckTrungTaiKhoan);
                if(TrungTaiKhoan.Rows.Count > 0)
                {
                    function.Notice("Bạn nhập trùng tên Tài Khoản nhân viên!", 0);
                }
                else
                {
                    string query = @"begin if not exists (select TaiKhoan from NhanVien where TaiKhoan = N'" + qlyNhanvien_txt_taikhoan.Text + "') "
                                        + "begin insert into NhanVien(TenNhanVien, NgaySinh, ViTri, DiaChi, SoDienThoai, QuyenTruyCap, TaiKhoan, MatKhau, NgayTao, GioiTinh,HinhAnh,Luong) values"
                                        + "(N'" + qlyNhanvien_txt_hoten.Text + "',"
                                        + "'" + qlyNhanvien_dtP_ngaysinh.Text + "',"
                                        + "N'" + qlyNhanvien_comB_vitri.Text + "',"
                                        + "N'" + qlyNhanvien_txt_diachi.Text + "',"
                                        + "N'" + qlyNhanvien_txt_sdt.Text + "',"
                                        + quyentruycap + ","
                                        + "N'" + qlyNhanvien_txt_taikhoan.Text + "',"
                                        + "'" + matkhau + "',"
                                        + "'" + qlyNhanvien_dtP_ngaytao.Text + "',"
                                        + "N'" + qlyNhanvien_comB_gioitinh.Text + "',"
                                        + "N'" + hinhanh + "',"
                                        + qlyNhanvien_txt_Luong.Text + ") end end";
                    connection.insert(query);
                    connection.disconnect();
                    refresh_qlyNhanVien();
                }
                connection.disconnect();
            }            
        }        

        private void qlyNhanvien_btn_capnhat_Click(object sender, EventArgs e)
        {
            object ID_NhanVien_CheckNull = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien");
            if (ID_NhanVien_CheckNull != null && ID_NhanVien_CheckNull != DBNull.Value)
            {
                if (function.checkNull(panelControl3_NhanVien) == true)//kiểm tra các thành phần có rỗng hay không
                {
                    string matkhau = qlyNhanvien_txt_matkhau.Text;
                    if (textchanged == true && MatkhauSoSanh != matkhau)
                    {
                        matkhau = function.toMD5(qlyNhanvien_txt_matkhau.Text);
                    }
                    connection.connect();
                    string ID = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien").ToString();
                    
                    if (pictureBox1_NhanVien.Image != null)//kiểm tra picturebox có rỗng hay không
                    {
                        if (result == DialogResult.OK)
                        {
                            string previewPath = Application.StartupPath + @"\Hinh\NhanVien\" + hinhanh;
                            string linkHinhAnh = open.FileName;
                            File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                        }
                        else
                        {
                            string layhinhanh = @"select hinhanh from NhanVien where MaSoNhanVien = " + ID;
                            DataTable dt1 = connection.SQL(layhinhanh);
                            hinhanh = dt1.Rows[0][0].ToString();
                        }
                    }
                    else { }

                    string query = @"update NhanVien set TenNhanVien = N'" + qlyNhanvien_txt_hoten.Text + "'," +
                    "GioiTinh = N'" + qlyNhanvien_comB_gioitinh.Text + "'," +
                    "SoDienThoai = N'" + qlyNhanvien_txt_sdt.Text + "'," +
                    "ViTri = N'" + qlyNhanvien_comB_vitri.Text + "'," +
                    "NgaySinh ='" + qlyNhanvien_dtP_ngaysinh.Text + "'," +
                    "DiaChi = N'" + qlyNhanvien_txt_diachi.Text + "'," +
                    "NgayTao='" + qlyNhanvien_dtP_ngaytao.Text + "'," +
                    "TaiKhoan = N'" + qlyNhanvien_txt_taikhoan.Text + "'," +
                    "MatKhau = N'" + matkhau + "'," +
                    "QuyenTruyCap =" + quyentruycap + "," +
                    "HinhAnh = N'" + hinhanh + "'," +
                    "Luong = " + qlyNhanvien_txt_Luong.Text +
                    " where MaSoNhanVien =" + ID;
                    connection.sql(query);
                    connection.disconnect();
                    refresh_qlyNhanVien();
                }
            }
        }
        
        private void qlyNhanvien_btn_xoa_Click(object sender, EventArgs e)
        {
            object ID_NhanVien_CheckNull = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien");
            if (ID_NhanVien_CheckNull != null && ID_NhanVien_CheckNull != DBNull.Value)
            {
                string ID = gridView1_NhanVien.GetFocusedRowCellValue("MaSoNhanVien").ToString();

                connection.connect();
                string query = @"delete from NhanVien where MaSoNhanVien = " + ID;
                connection.delete(query);
                connection.disconnect();
                refresh_qlyNhanVien();
            }
        }
        #endregion 
        #endregion

        #region form Vật dụng
        private void refresh_qlyVatDung()
        {
            function.ClearControl(panelControl5_VatDung);
            this.vatDungTableAdapter.Fill(this.phongKhamDataSet.VatDung);
            hinhanh = null;
            result = new DialogResult();
            qlyVatdung_btn_capnhat.Enabled = false;
            qlyVatdung_btn_xoa.Enabled = false;
        }

        private void qlyVatdung_txt_sonamsudung_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }

        private void qlyVatdung_txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }

        private void gridView1_VatDung_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_VatDung_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_VatDung.Image = Image.FromStream(open.OpenFile());

                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_VatDung.Image = new Bitmap(open.FileName);
            }
        }

        private void gridView1_VatDung_RowClick(object sender, RowClickEventArgs e)
        {
            object ID_VatDung_CheckNull = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung");
            if(ID_VatDung_CheckNull !=null && ID_VatDung_CheckNull!= DBNull.Value)
            {
                qlyVatdung_btn_capnhat.Enabled = true;
                qlyVatdung_btn_xoa.Enabled = true;
                string ID = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung").ToString();
                qlyVatdung_txt_tenvatdung.Text = gridView1_VatDung.GetFocusedRowCellValue("TenVatDung").ToString();
                qlyVatdung_txt_soluong.Text = gridView1_VatDung.GetFocusedRowCellValue("SoLuong").ToString();
                qlyVatdung_txt_sonamsudung.Text = gridView1_VatDung.GetFocusedRowCellValue("SoNamSuDung").ToString();
                qlyVatdung_dtP_ngaytao.Text = gridView1_VatDung.GetFocusedRowCellValue("NgayTao").ToString();

                connection.connect();

                string layhinhanh = @"select hinhanh from VatDung where MaSoVatDung = " + ID;
                cmd = new SqlCommand(layhinhanh, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
                    {
                        if (File.Exists(Application.StartupPath + @"\Hinh\VatDung\" + dr["hinhanh"].ToString()))//kiểm tra hình ảnh có trong thư mục hay không
                        {
                            //có thì sẽ load hình ảnh vào pictureBox
                            pictureBox1_VatDung.Image = new Bitmap(Application.StartupPath + @"\Hinh\VatDung\" + dr["hinhanh"].ToString());
                        }
                        else
                        {
                            //không thì hiện thông báo
                            //function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
                            pictureBox1_VatDung.Image = null;
                        }
                    }
                    else
                    {
                        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
                        pictureBox1_VatDung.Image = null;
                        continue;
                    }
                }
                dr.Close();

                connection.disconnect();
            }
            
        }
        #region Thêm, Xóa, Sửa
        private void qlyVatdung_btn_taomoi_Click(object sender, EventArgs e)
        {
            if (function.checkNull(panelControl5_VatDung) == true)
            {
                connection.connect();

                if (pictureBox1_VatDung.Image != null)//kiểm tra picturebox có rỗng hay không
                {
                    if (result == DialogResult.OK)
                    {
                        hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                        string previewPath = Application.StartupPath + @"\Hinh\VatDung\" + hinhanh;
                        string linkHinhAnh = open.FileName;
                        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                    }
                    else { }
                }
                else { }

                string query = @"insert into VatDung(TenVatDung, SoLuong, SoNamSuDung, NgayTao,HinhAnh) values"
                    + "(N'" + qlyVatdung_txt_tenvatdung.Text + "',"
                    + qlyVatdung_txt_soluong.Text + ","
                    + qlyVatdung_txt_sonamsudung.Text + ","
                    + "'" + qlyVatdung_dtP_ngaytao.Text + "',"
                    + "N'" + hinhanh + "')";
                connection.insert(query);
                connection.disconnect();
                refresh_qlyVatDung();
            }
            
        }

        private void qlyVatdung_btn_capnhat_Click(object sender, EventArgs e)
        {
            object ID_VatDung_CheckNull = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung");
            if (ID_VatDung_CheckNull != null && ID_VatDung_CheckNull != DBNull.Value)
            {
                if (function.checkNull(panelControl5_VatDung) == true)//kiểm tra các thành phần có rỗng hay không
                {
                    connection.connect();
                    string ID = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung").ToString();


                    if (pictureBox1_VatDung.Image != null)//kiểm tra picturebox có rỗng hay không
                    {
                        if (result == DialogResult.OK)
                        {
                            string previewPath = Application.StartupPath + @"\Hinh\VatDung\" + hinhanh;
                            string linkHinhAnh = open.FileName;
                            File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                        }
                        else
                        {
                            string layhinhanh = @"select hinhanh from VatDung where MaSoVatDung = " + ID;
                            DataTable dt1 = connection.SQL(layhinhanh);
                            hinhanh = dt1.Rows[0][0].ToString();
                        }
                    }
                    else { }

                    string query = @"update VatDung set TenVatDung = N'" + qlyVatdung_txt_tenvatdung.Text + "'," +
                        "SoLuong =" + qlyVatdung_txt_soluong.Text + "," +
                        "SoNamSuDung =" + qlyVatdung_txt_sonamsudung.Text + "," +
                        "NgayTao =" + "'" + qlyVatdung_dtP_ngaytao.Text + "'," +
                        "HinhAnh= N'" + hinhanh + "'" +
                        " where MaSoVatDung =" + ID;
                    connection.sql(query);
                    connection.disconnect();
                    refresh_qlyVatDung();
                }
            }
        }

        private void qlyVatdung_btn_xoa_Click(object sender, EventArgs e)
        {
            object ID_VatDung_CheckNull = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung");
            if (ID_VatDung_CheckNull != null && ID_VatDung_CheckNull != DBNull.Value)
            {
                string ID = gridView1_VatDung.GetFocusedRowCellValue("MaSoVatDung").ToString();

                connection.connect();
                string query = @"delete from VatDung where MaSoVatDung = " + ID;
                connection.delete(query);
                connection.disconnect();
                refresh_qlyVatDung();
            }
        }
#endregion

#endregion
    }
}