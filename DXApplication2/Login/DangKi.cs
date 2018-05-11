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
    public partial class DangKi : DevExpress.XtraEditors.XtraForm
    {
        public DangKi()
        {
            InitializeComponent();
        }
        connection connection = new connection();
        function function = new function();
        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text==txt_nhaplaimk.Text)
            {
                var pass = function.toMD5(txt_matkhau.Text);
                connection.connect();
                string query = @"insert into Admin(taikhoan,matkhau) values ('" + txt_taikhoan.Text + "','" + pass + "')";
                connection.insert(query);
                connection.disconnect();
            }
            else {
                function.Notice("Bạn cần nhập mật khẩu giống nhau!", 1);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Visible = false;
            
        }
    }
}