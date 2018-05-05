using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham
{
    public partial class ThemCho : Form
    {
        public ThemCho()
        {
            InitializeComponent();
        }
        public string ngaykham;
        public string lidokham;
        public void ThemCho_btn_ThemCho_Click(object sender, EventArgs e)
        {
            ngaykham = ThemCho_dtP_ThoiGianKham.Text;
            lidokham = ThemCho_txt_LiDoKham.Text;
            this.Close();
        }

        private void ThemCho_btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
