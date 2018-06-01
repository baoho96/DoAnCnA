using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongKham
{
    public partial class DoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        public void Bindata()
        {
            lblTextTongKham.Text = ThongKeDoanhThu.TongSoLuong;
            lblTextTongTien.Text = ThongKeDoanhThu.TongTien;
            lblNgayThangNam.DataBindings.Add("Text",DataSource, "NgayGioLap");
            lblTongKham.DataBindings.Add("Text", DataSource, "SoLuong");
            lblTongTien.DataBindings.Add("Text", DataSource, "TongTien");
            lblNgayHienTai.Text = DateTime.Now.ToString();
            lblNgayTim.Text = ThongKeDoanhThu.NhapNgay;
        }

    }
}
