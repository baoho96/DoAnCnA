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
        public DangNhap()
        {
            InitializeComponent();
        }
        //private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter da;
        function function = new function();
        connection connection = new connection();        
        int quyentruycap { get; set; }
        public static string TenBacSi { get; set; }
        public static int MaSoBacSi { get; set; }

        public void btn_DangNhap_Click(object sender, EventArgs e)
        {

            var passMD5 = function.toMD5(txt_matkhau.Text);
            string query = "select TenNhanVien,MaSoNhanVien,QuyenTruyCap from NhanVien where taikhoan ='" + txt_taikhoan.Text +
                "'and matkhau = '"+ passMD5 + "'";
            connection.connect();
            cmd = new SqlCommand(query, connection.con);
            da = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                function.Notice("Sai Mật khẩu hoặc tên Đăng nhập. Vui lòng nhập lại", 0);
            }
            else
            {
                TenBacSi = dt.Rows[0][0].ToString();
                MaSoBacSi = int.Parse(dt.Rows[0][1].ToString());
            }
            if (dt!=null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if(dr["quyentruycap"].ToString()=="1")
                    {
                        quyentruycap = 1;
                        Admin admin = new Admin();
                        admin.Show();
                        
                        this.Visible = false;
                    }
                    else if(dr["quyentruycap"].ToString()=="2")
                    {
                        quyentruycap = 2;
                        NhanVien nhanVien = new NhanVien();
                        nhanVien.Show();
                        this.Visible=false;
                    }
                    else if (dr["quyentruycap"].ToString() == "3")
                    {
                        quyentruycap = 3;                        
                        BacSi bacSi = new BacSi();
                        bacSi.Show();
                        this.Visible = false;
                    }
                    else if (dr["quyentruycap"].ToString() == "4")
                    {
                        quyentruycap = 4;
                        DuocSi duocSi = new DuocSi();
                        duocSi.Show();
                        this.Visible = false;
                    }
                    else if (dr["quyentruycap"].ToString() == "5")
                    {
                        quyentruycap = 5;
                        NhanVienThuNgan nhanVienThuNgan = new NhanVienThuNgan();
                        nhanVienThuNgan.Show();
                        this.Visible = false;
                    }
                }
                
            }
            
            connection.disconnect();
        }
        

        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}