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
            lblTongTien.Text = DuocSi.TongTien;


            xlbMSDT.Text = DuocSi.ID_MSDT.ToString();//gán dữ liệu từ form Nhân Viên Thu ngân
            xlbMSHD.Text = DuocSi.ID_MSHD.ToString();
            xlbID_MSKB.Text = DuocSi.ID_MSKB.ToString();
            xlbMSBN.Text = DuocSi.ID_MSBN.ToString();
            xlb_Ho.Text = DuocSi.Ho;
            xlbTen.Text = DuocSi.Ten;
            xlbNamSinh.Text = DuocSi.NamSinh;
            xlbDiaChi.Text = DuocSi.DiaChi;
            lblSDT.Text = DuocSi.SDT;
            xlbChuanDoan.Text = DuocSi.ChuanDoan;
            lblYeuCauXetNghiem.Text = DuocSi.YeuCauXetNghiem;
            lblKetQuaXetNghiem.Text = DuocSi.KetQuaXetNghiem;



            lblTenThuoc.DataBindings.Add("Text", DataSource, "TenThuoc");//Load dữ liệu từ SQL và gán vào label
            lblSoLuong.DataBindings.Add("Text", DataSource, "SoLuong");
            lblDonViTinh.DataBindings.Add("Text", DataSource, "DonViTinhNhoNhat");
            lblDonGia.DataBindings.Add("Text", DataSource, "DonGiaNhoNhat");
            lblCachDung.DataBindings.Add("Text", DataSource, "CachDung");

            lbGhiChu.Text = DuocSi.GhiChuHSDT;
            lblGhiChuKhamBenh.Text = DuocSi.GhiChuHSKB;
            lbTienThuoc.Text = DuocSi.TienThuoc;
            lblTienKham.Text = DuocSi.TienKham;
            //lblTongTien.Text = DuocSi.TongTien;
            lbNgayKeDon.Text = DuocSi.NgayKham;
            lbNgayTaiKham.Text = DuocSi.NgayTaiKham;

            lblBacSiKham.Text = DuocSi.BacSiKham;
            lblNguoiLap.Text = DuocSi.NguoiLap;

        }
    }
}
