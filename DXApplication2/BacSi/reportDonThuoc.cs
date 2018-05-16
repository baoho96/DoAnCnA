using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongKham
{
    public partial class reportDonThuoc : DevExpress.XtraReports.UI.XtraReport
    {

        public reportDonThuoc()
        {
            InitializeComponent();
        }
        public void Bindata()
        {

            xlbMSDT.Text = DonThuoc.ID_MSDT.ToString();//gán dữ liệu từ form Đơn Thuốc
            xlb_Ho.Text = DonThuoc.Ho;
            xlbTen.Text=DonThuoc.Ten;
            xlbNamSinh.Text=DonThuoc.NamSinh;
            xlbDiaChi.Text=DonThuoc.DiaChi;            
            xlbChuanDoan.Text = DonThuoc.ChuanDoan;
            
            lblTenThuoc.DataBindings.Add("Text", DataSource, "TenThuoc");//Load dữ liệu từ SQL và gán vào label
            lblSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");
            lblDonViTinh.DataBindings.Add("Text", DataSource, "DonViTinh");
            lblDonGia.DataBindings.Add("Text", DataSource, "DonGia");
            lblCachDung.DataBindings.Add("Text", DataSource, "CachDung");

            lbGhiChu.Text = DonThuoc.GhiChu;
            lbNgayKeDon.Text = DonThuoc.NgayKeDon;
            //lbTienThuoc.Text = DonThuoc.TienThuoc;
            lbBacSi.Text = DonThuoc.BacSiKham;
            
        }
    }
}
