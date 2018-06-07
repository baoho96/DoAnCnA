using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
namespace QuanLyPhongKham
{
    public partial class reportDonThuocFormDuocSi : DevExpress.XtraReports.UI.XtraReport
    {
        public reportDonThuocFormDuocSi()
        {
            InitializeComponent();
        }
        public void Bindata()
        {   
            xlb_Ho.Text = DuocSi.Ho;
            xlbTen.Text = DuocSi.Ten;
            xlbNamSinh.Text = DuocSi.NamSinh;
            lblSDT.Text = DuocSi.SDT;
            xlbChuanDoan.Text = DuocSi.ChuanDoan;

            lblTenThuoc.DataBindings.Add("Text", DataSource, "TenThuoc");//Load dữ liệu từ SQL và gán vào label
            lblSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");
            lblDonViTinh.DataBindings.Add("Text", DataSource, "DonViTinhNhoNhat");
            lblDonGia.DataBindings.Add("Text", DataSource, "DonGiaNhoNhat");
            lblCachDung.DataBindings.Add("Text", DataSource, "CachDung");

            lbGhiChu.Text = DuocSi.GhiChuHSDT;
            lblGhiChuKhamBenh.Text = DuocSi.GhiChuHSKB;
            lbNgayKeDon.Text = DuocSi.NgayKham;

            lblBacSiKham.Text = DuocSi.BacSiKham;
            lblNguoiLap.Text = DuocSi.NguoiLap;

        }
    }
}
