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

            xlbMSDT.Text = NhanVienThuNgan.ID_MSDT.ToString();//gán dữ liệu từ form Nhân Viên Thu ngân
            xlbMSHD.Text = NhanVienThuNgan.ID_MSHD.ToString();
            xlbID_MSKB.Text = NhanVienThuNgan.ID_MSKB.ToString();
            xlbMSBN.Text = NhanVienThuNgan.ID_MSBN.ToString();
            xlb_Ho.Text = NhanVienThuNgan.Ho;
            xlbTen.Text= NhanVienThuNgan.Ten;
            xlbNamSinh.Text= NhanVienThuNgan.NamSinh;
            xlbDiaChi.Text= NhanVienThuNgan.DiaChi;
            lblSDT.Text = NhanVienThuNgan.SDT;
            xlbChuanDoan.Text = NhanVienThuNgan.ChuanDoan;
            lblYeuCauXetNghiem.Text = NhanVienThuNgan.YeuCauXetNghiem;
            lblKetQuaXetNghiem.Text = NhanVienThuNgan.KetQuaXetNghiem;



            lblTenThuoc.DataBindings.Add("Text", DataSource, "TenThuoc");//Load dữ liệu từ SQL và gán vào label
            lblSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");
            lblDonViTinh.DataBindings.Add("Text", DataSource, "DonViTinhNhoNhat");
            lblDonGia.DataBindings.Add("Text", DataSource, "DonGiaNhoNhat");
            lblCachDung.DataBindings.Add("Text", DataSource, "CachDung");

            lbGhiChu.Text = NhanVienThuNgan.GhiChuHSDT;
            lblGhiChuKhamBenh.Text = NhanVienThuNgan.GhiChuHSKB;
            lbTienThuoc.Text = NhanVienThuNgan.TienThuoc;
            lblTienKham.Text = NhanVienThuNgan.TienKham;
            lblTongTien.Text = NhanVienThuNgan.TongTien;
            lbNgayKeDon.Text = NhanVienThuNgan.NgayKham;
            lbNgayTaiKham.Text = NhanVienThuNgan.NgayTaiKham;

            lblBacSiKham.Text = NhanVienThuNgan.BacSiKham;
            lblNguoiLap.Text = NhanVienThuNgan.NguoiLap;
            
        }
    }
}
