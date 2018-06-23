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
using System.Configuration;
using System.Data.SqlClient;
namespace QuanLyPhongKham
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        #region khởi tạo
        function function = new function();
        connection connection = new connection();
        #endregion
        #region Biến khởi tạo
        public static string TenBacSi { get; set; }
        public static int MaSoBacSi { get; set; }
        public string QuyenTruyCap { get; set; }
        #endregion
        public DangNhap()
        {
            InitializeComponent();           
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            Winform.admin = new Admin();
            Winform.bacSi = new BacSi();
            Winform.nhanVien = new NhanVien();
            Winform.duocSi = new DuocSi();
            Winform.nhanVienThuNgan = new NhanVienThuNgan();
        }                     

        public void btn_DangNhap_Click(object sender, EventArgs e)
        {
            TenBacSi = "";
            var passMD5 = function.toMD5(txt_matkhau.Text);
            string query = "select TenNhanVien,MaSoNhanVien,QuyenTruyCap from NhanVien where taikhoan ='" + txt_taikhoan.Text +"'"+
                            " and matkhau = '"+ passMD5 + "'";
            connection.connect();            
            DataTable dt = connection.SQL(query);
            if (dt.Rows.Count == 0)
            {
                function.Notice("Sai Mật khẩu hoặc tên Đăng nhập. Vui lòng nhập lại", 0);
            }
            else
            {
                TenBacSi = dt.Rows[0][0].ToString();
                MaSoBacSi = int.Parse(dt.Rows[0][1].ToString());
                QuyenTruyCap = dt.Rows[0][2].ToString();
                PhanQuyen(QuyenTruyCap);
            }
            connection.disconnect();
        }
        public void PhanQuyen(string QuyenTruyCap)
        {
            if (QuyenTruyCap == "1")//Admin
            {
                Winform.admin.Show();
                this.Visible = false;
            }
            else if (QuyenTruyCap == "2")//Nhân viên điều dưỡng
            {
                Winform.nhanVien.Show();
                this.Visible = false;
            }
            else if (QuyenTruyCap == "3")//Bác sĩ
            {
                Winform.bacSi.Show();
                this.Visible = false;
            }
            else if (QuyenTruyCap == "4")// Nhân viên giao thuốc
            {
                Winform.duocSi.Show();
                this.Visible = false;
            }
            else if (QuyenTruyCap == "5")//Nhân viên thu ngân
            {
                Winform.nhanVienThuNgan.Show();
                this.Visible = false;
            }
        }
        public void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}