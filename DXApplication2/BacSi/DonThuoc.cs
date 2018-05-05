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

namespace QuanLyPhongKham
{
    public partial class DonThuoc : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        function function = new function();
        BacSi bacSi;
        public DonThuoc()
        {
            InitializeComponent();
        }

        private void DonThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongKhamDataSet.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);

            load_DonThuoc_comB_donvitinh();

            GanGiaTri();
        }
        private void GanGiaTri()
        {
            txt_Ho.Text = BacSi.Ho_BenhNhan;
            txt_Ten.Text = BacSi.Ten_BenhNhan;
            txt_NamSinh.Text = BacSi.NamSinh_BenhNhan;
            txt_GioiTinh.Text = BacSi.GioiTinh_BenhNhan;
            txt_DiaChi.Text = BacSi.DiaChi_BenhNhan;
            txt_XetNghiem.Text = BacSi.XetNghiem_BenhNhan;
            txt_ChuanDoan.Text = BacSi.ChuanDoan_BenhNhan;
            txt_GhiChuKham.Text = BacSi.GhiChu_BenhNhan;
            txt_BacSiKham.Text = BacSi.BacSiKham_BenhNhan;
        }
        private void load_DonThuoc_comB_donvitinh()
        {
            comB_DonViTinh.Items.Add("Viên");
            comB_DonViTinh.Items.Add("Vĩ");
            comB_DonViTinh.Items.Add("Hộp");
            comB_DonViTinh.Items.Add("Thùng");
        }

        private void gridView1_DonThuoc_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender,e);
        }

        private void gridView1_DonThuoc_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }

        private void btn_ThemThuoc_Click(object sender, EventArgs e)
        {
            
        }
    }
}