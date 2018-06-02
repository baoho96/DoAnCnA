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
            lblTextTongKham.Text = ThongKeBenhNhan.TongSoLuong;
            lblTextTongTien.Text = ThongKeBenhNhan.TongTien;

            lblHo.DataBindings.Add("Text", DataSource, "Ho");
            lblTen.DataBindings.Add("Text", DataSource, "Ten");
            lblNgaySinh.DataBindings.Add("Text", DataSource, "NamSinh");
            lblDiaChi.DataBindings.Add("Text", DataSource, "DiaChi");
            lblChuanDoan.DataBindings.Add("Text", DataSource, "ChuanDoan");
            lblBacSiKham.DataBindings.Add("Text", DataSource, "TenNhanVien");
            lblTienKham.DataBindings.Add("Text", DataSource, "TongTien");
            lblNgayKham.DataBindings.Add("Text", DataSource, "NgayGioKham");
            
            lblNgayHienTai.Text = DateTime.Now.ToString();
            lblNgayTim.Text = ThongKeBenhNhan.NhapNgay;
        }
    }
}
