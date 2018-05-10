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
using System.Data.SqlClient;
namespace QuanLyPhongKham
{
    public partial class DonThuoc : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        function function = new function();
        BacSi bacSi;
        SqlDataAdapter da;
        BindingSource bindingSource = new BindingSource();
        int ID_MSDT;
        int ID_MSKB;
        int ID_Thuoc_RowClick;
        
        bool RowClick = false;
        
        public DonThuoc()
        {
            InitializeComponent();
        }

        private void DonThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongKhamDataSet.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);

            
            Load_DonThuoc();
            GanGiaTri();
            
        }
        private void Load_DonThuoc()
        {
            ID_MSKB = BacSi.ID_MSKB;
            string query = @"select T.TenThuoc,T.MaSoThuoc,T.DonViTinh,T.DonGia,DST.SoLuong,DST.CachDung"+
                                " from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc "+
                                            " left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc "+
                                " where DT.MaSoKhamBenh = "+ID_MSKB;
            connection.connect();
            da = new SqlDataAdapter(query, connection.con);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "DanhSachThuoc");
            bindingSource.DataSource = ds.Tables["DanhSachThuoc"];
            gridC_danhsachDonThuoc.DataSource = bindingSource;
            connection.disconnect();
        }
        private void refresh_DonThuoc()
        {
            function.ClearControl(panelControl1);
            txt_TenThuoc.Text = "";
            //gridC_danhsachDonThuoc.Refresh();
            //gridView1_DonThuoc.RefreshData();
            Load_DonThuoc();
            RowClick = false;
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
            int ID_Thuoc;
            
            if (function.checkNull(panelControl1)==true)
            {
                if(RowClick == true)
                {
                    ID_Thuoc = ID_Thuoc_RowClick;//gán ID thuốc cho ID rowlick
                    function.Notice("Nếu bạn muốn Cập nhật thuốc vui lòng chọn thuốc và nhấn nút 'Cập Nhật'",1);
                }
                else
                {
                    ID_Thuoc = int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("MaSoThuoc").ToString());//lấy mã số thuốc từ chọn tên thuốc trong ComboboxEdit
                }
                
                connection.connect();

                string insert_DT = @"begin if not exists(select MaSoKhamBenh from DonThuoc where MaSoKhamBenh = "+ ID_MSKB+")" +
                                    " begin insert into DonThuoc(MaSoKhamBenh) values("+ID_MSKB+")"+
                                    "end end";//sử dụng lệnh IF NOT EXISTS để kiểm tra trong Đơn thuốc có MaSoKhamBenh đó hay chưa, nếu chưa thì Insert, không thi bỏ qua
                connection.insert(insert_DT);

                string get_MSDT = @"select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB;
                DataTable dataTable = connection.SQL(get_MSDT);
                ID_MSDT = int.Parse(dataTable.Rows[0][0].ToString());//Lấy mã số Đơn thuốc mới vừa tạo ra

                string insert_DST = @"Begin if not exists(select MaSoThuoc from DanhSachThuoc where MaSoThuoc ="+ ID_Thuoc+" and MaSoDonThuoc = "+ID_MSDT+")"+
                                    " begin insert into DanhSachThuoc(MaSoDonThuoc,MaSoThuoc,SoLuong,CachDung) values" +
                " (" + ID_MSDT + "," + ID_Thuoc + "," + txt_SoLuong.Text + ",N'" + txt_CachDung.Text + "') end end";
                connection.insert(insert_DST);//Insert vào Danh Sách Thuốc từ MSDT vừa tạo, ID_Thuoc từ Cột trong ComboBoxEdit

                connection.disconnect();
                refresh_DonThuoc();
            }
        }

        private void gridView1_DonThuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            RowClick = true;
            txt_TenThuoc.Text = gridView1_DonThuoc.GetFocusedRowCellValue("TenThuoc").ToString();
            txt_SoLuong.Text = gridView1_DonThuoc.GetFocusedRowCellValue("SoLuong").ToString();
            txt_CachDung.Text = gridView1_DonThuoc.GetFocusedRowCellValue("CachDung").ToString();
            ID_Thuoc_RowClick = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("MaSoThuoc").ToString());//lấy ID thuốc khi click vào Row trong gridview
           
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int ID_Thuoc = int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("MaSoThuoc").ToString());//lấy mã số thuốc từ chọn tên thuốc trong ComboboxEdit
            string update_DonThuoc = @"update DanhSachThuoc set MaSoThuoc = " + ID_Thuoc + "," +
                                        " SoLuong = " + txt_SoLuong.Text + "," +
                                        " CachDung = N'" + txt_CachDung.Text + "'" +
                                        " where MaSoDonThuoc = " + ID_MSDT + " and MaSoThuoc = " + ID_Thuoc_RowClick ;
            connection.connect();
            connection.sql(update_DonThuoc);
            connection.disconnect();
            refresh_DonThuoc();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string Xoa_DanhSachThuoc = @"delete from DanhSachThuoc where MaSoThuoc = "+ID_Thuoc_RowClick;
            connection.connect();
            connection.delete(Xoa_DanhSachThuoc);
            connection.disconnect();
            refresh_DonThuoc();
        }
    }
}