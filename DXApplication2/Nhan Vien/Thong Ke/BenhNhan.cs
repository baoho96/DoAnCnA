using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongKham
{
    public partial class BenhNhan : DevExpress.XtraReports.UI.XtraReport
    {
        public BenhNhan()
        {
            InitializeComponent();
        }
        public void Bindata()
        {
            lblTextTongKham.Text = ThongKeDoanhThu.TongSoLuong;
            lblTextTongTien.Text = ThongKeDoanhThu.TongTien;
            
            lblNgayHienTai.Text = DateTime.Now.ToString();
            lblNgayTim.Text = ThongKeDoanhThu.NhapNgay;
        }
    }
}
