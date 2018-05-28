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
        Admin admin;
        NhanVien nhanVien;
        BacSi bacSi;
        NhanVienThuNgan nhanVienThuNgan;
        DuocSi duocSi;
        function function = new function();
        connection connection = new connection();
        public static string TenBacSi { get; set; }
        public static int MaSoBacSi { get; set; }
        public string QuyenTruyCap { get; set; }
        public DangNhap()
        {
            InitializeComponent();           
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            admin = new Admin();
            nhanVien = new NhanVien();
            bacSi= new BacSi();
            nhanVienThuNgan = new NhanVienThuNgan();
            duocSi = new DuocSi();
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

                if (QuyenTruyCap == "1")
                {
                    admin.Show();
                    this.Visible = false;
                }
                else if (QuyenTruyCap == "2")
                {
                    nhanVien.Show();
                    this.Visible = false;
                }
                else if (QuyenTruyCap == "3")
                {
                    bacSi.Show();
                    this.Visible = false;
                }
                else if (QuyenTruyCap == "4")
                {                   
                    duocSi.Show();
                    this.Visible = false;
                }
                else if (QuyenTruyCap == "5")
                {                  
                    nhanVienThuNgan.Show();
                    this.Visible = false;
                }
            }
            connection.disconnect();
        }

        public void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}