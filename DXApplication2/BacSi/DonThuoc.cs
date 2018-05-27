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
        
        #region Các thuộc tính được tạo với static để sử dụng chung với các form khác
        public static int ID_MSDT { get; set; }
        public static string Ho { get; set; }
        public static string Ten { get; set; }
        public static string NamSinh { get; set; }
        public static string DiaChi { get; set; }
        public static string ChuanDoan { get; set; }
        public static string GhiChu { get; set; }
        public static string NgayKeDon { get; set; }
        public static string TienThuoc { get; set; }
        public static string BacSiKham { get; set; }
        public static int ID_MSKB { get; set; }
        #endregion

        int ID_Thuoc_RowClick;
        bool TenThuocClick;
        bool RowClick;
        
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
            
            string query = @"select T.TenThuoc,T.MaSoThuoc,T.DonViTinhNhoNhat,T.DonGiaNhoNhat,DST.SoLuong,DST.CachDung"+
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
            if(ID_MSDT==0)//Kiểm tra Mã số đơn thuốc của biến toàn cục có rỗng hay không, nếu rỗng thì sẽ lấy MSĐT
                //vì khi Thêm Thuốc sẽ tạo mã số đơn thuốc mới duy nhất cho 1 mã số khám bệnh (MSKB)
            {
                string get_MSDT = @"begin if exists(select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB + ")" +
                                    "begin select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB +
                                    " end end";
                DataTable dataTable = connection.SQL(get_MSDT);
                if (dataTable.Rows.Count > 0)//kiểm tra mã số đơn thuốc(MSĐT) trong csdl có hay không
                {
                    ID_MSDT = int.Parse(dataTable.Rows[0][0].ToString());//Lấy mã số Đơn thuốc mới vừa tạo ra
                }
                else//nếu không có thì sẽ không gán vào biến toàn cục, nghĩa là Bệnh nhân mới nên chưa tạo Đơn thuốc
                { }
            }

            //TinhTienThuoc();
            connection.disconnect();
        }
        private void refresh_DonThuoc()
        {
            function.ClearControl(panelControl1);
            txt_TenThuoc.Text = "";
            txt_TenThuoc.Refresh();
            //thuocBindingSource.ResetCurrentItem();
            //searchLookUpEdit1View.RefreshData();
            this.thuocTableAdapter.Fill(this.phongKhamDataSet.Thuoc);

            //gridC_danhsachDonThuoc.Refresh();
            //gridView1_DonThuoc.RefreshData();
            Load_DonThuoc();
            RowClick = false;
        }
        private void GanGiaTri()//lấy giá trị từ form Bác Sĩ gán vào các textBox trong Đơn Thuốc
        {
            Ho=txt_Ho.Text = BacSi.Ho_BenhNhan;
            Ten=txt_Ten.Text = BacSi.Ten_BenhNhan;
            NamSinh=txt_NamSinh.Text = BacSi.NamSinh_BenhNhan;
            txt_GioiTinh.Text = BacSi.GioiTinh_BenhNhan;
            DiaChi=txt_DiaChi.Text = BacSi.DiaChi_BenhNhan;
            txt_XetNghiem.Text = BacSi.XetNghiem_BenhNhan;
            txt_KetQuaXetNghiem.Text = BacSi.KetQuaXetNghiem_BenhNhan;
            ChuanDoan =txt_ChuanDoan.Text = BacSi.ChuanDoan_BenhNhan;
            txt_GhiChuKham.Text = BacSi.GhiChu_BenhNhan;
            BacSiKham= txt_BacSiKham.Text = BacSi.BacSiKham_BenhNhan;
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
            int SoluongThuocNhoNhat_TrongKho = int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("SoLuongNhoNhat").ToString());
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
                if(ID_MSDT==0)
                {
                    string get_MSDT = @"select MaSoDonThuoc from DonThuoc where MaSoKhamBenh = " + ID_MSKB;
                    DataTable dataTable = connection.SQL(get_MSDT);
                    ID_MSDT = int.Parse(dataTable.Rows[0][0].ToString());//Lấy mã số Đơn thuốc mới vừa tạo ra
                }
                else
                {

                }

                //string GetSoluongThuocNhoNhat_TrongKho = @"select SoLuongNhoNhat from Thuoc where MaSoThuoc = " + ID_Thuoc;
                //DataTable dt_SoLuongNhoNhat = connection.SQL(GetSoluongThuocNhoNhat_TrongKho);                
                //int SoluongThuocNhoNhat_TrongKho = int.Parse(dt_SoLuongNhoNhat.Rows[0][0].ToString());

                if(int.Parse(txt_SoLuong.Text) > SoluongThuocNhoNhat_TrongKho)
                {
                    MessageBox.Show("Số lượng trong kho không đủ!","Thông báo!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if(int.Parse(txt_SoLuong.Text) <= SoluongThuocNhoNhat_TrongKho)
                {
                    int SoLuongThuocNhoNhat_TrongKho_HienTai = SoluongThuocNhoNhat_TrongKho - int.Parse(txt_SoLuong.Text);
                    string insert_DST = @"Begin if not exists(select MaSoThuoc from DanhSachThuoc where MaSoThuoc =" + ID_Thuoc + " and MaSoDonThuoc = " + ID_MSDT + ")" +
                                    " begin insert into DanhSachThuoc(MaSoDonThuoc,MaSoThuoc,SoLuong,CachDung) values" +
                " (" + ID_MSDT + "," + ID_Thuoc + "," + txt_SoLuong.Text + ",N'" + txt_CachDung.Text + "')"+
                                    " update Thuoc set SoLuongNhoNhat ="+ SoLuongThuocNhoNhat_TrongKho_HienTai+
                                     " where MaSoThuoc =" + ID_Thuoc + " end end";
                    connection.insert(insert_DST);//Insert vào Danh Sách Thuốc từ MSDT vừa tạo, ID_Thuoc từ Cột trong ComboBoxEdit
                    if (SoLuongThuocNhoNhat_TrongKho_HienTai == 0 || SoLuongThuocNhoNhat_TrongKho_HienTai <= 10)
                    {
                        MessageBox.Show("Số lượng trong kho đã hết! Vui lòng liên hệ đặt hàng", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                connection.disconnect();
                refresh_DonThuoc();
            }
        }

        private void gridView1_DonThuoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            RowClick = true;
            TenThuocClick = false;
            txt_TenThuoc.Text = gridView1_DonThuoc.GetFocusedRowCellValue("TenThuoc").ToString();
            txt_SoLuong.Text = gridView1_DonThuoc.GetFocusedRowCellValue("SoLuong").ToString();
            txt_CachDung.Text = gridView1_DonThuoc.GetFocusedRowCellValue("CachDung").ToString();
            ID_Thuoc_RowClick = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("MaSoThuoc").ToString());//lấy ID thuốc khi click vào Row trong gridview
           
        }
        private void Update_TinhToan_TinhSoLuongThuocCu(int ID_Thuoc)//Tính số lượng của Thuốc cũ khi update Thuốc mới. Dành cho Người dùng nhấn thay đổi tên thuốc để update
        {
            int SoluongThuocNhoNhat_TrongKho = int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("SoLuongNhoNhat").ToString());//Lấy Số lượng nhỏ nhất khi click vào Text Tên Thuốc
            int SoLuongThuocCu_DaNhap_TrongDonThuoc = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("SoLuong").ToString());//Lấy sô lượng Đã nhập của Thuốc cũ đã thêm 
            if (int.Parse(txt_SoLuong.Text) > SoluongThuocNhoNhat_TrongKho)//kiểm tra Số lượng thuốc mới nhập 
            {
                MessageBox.Show("Số lượng trong kho không đủ!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(txt_SoLuong.Text) <= SoluongThuocNhoNhat_TrongKho)
            {               
                //tính số lượng thuốc cũ trong đơn thuốc để Update
                string GetSoLuongThuoc_TrongFormDonThuoc = @"select SoLuongNhoNhat from Thuoc where MaSoThuoc = "  + ID_Thuoc_RowClick;//Lấy số lượng Thuốc khi RowClick vào gridview
                DataTable datatable_GetSoLuongThuoc_TrongFormDonThuoc = connection.SQL(GetSoLuongThuoc_TrongFormDonThuoc);
                int SoLuongThuocCu_TrongFormDonThuoc = int.Parse(datatable_GetSoLuongThuoc_TrongFormDonThuoc.Rows[0][0].ToString());//Lấy số lượng Thuốc khi RowClick vào gridview

                int SoLuongThuocCu_KhoMoi_TrongFormThuoc = SoLuongThuocCu_DaNhap_TrongDonThuoc + SoLuongThuocCu_TrongFormDonThuoc;//Tính số lượng mới của thuốc bị thay đổi trong kho để update 
                string Update_CongSoLuongThuocCu = @"update Thuoc set SoLuongNhoNhat = "+ SoLuongThuocCu_KhoMoi_TrongFormThuoc + " Where MaSoThuoc = " + ID_Thuoc_RowClick;
                connection.sql(Update_CongSoLuongThuocCu);

                //tính số lượng thuốc mới để Update
                int SoLuongThuocNhoNhat_TrongKho_HienTai = SoluongThuocNhoNhat_TrongKho - int.Parse(txt_SoLuong.Text);//Tính số lượng thuốc sau khi chọn Tên thuốc mới
                string update_DonThuoc = @"update DanhSachThuoc set MaSoThuoc = " + ID_Thuoc + "," +
                                        " SoLuong = " + txt_SoLuong.Text + "," +
                                        " CachDung = N'" + txt_CachDung.Text + "'" +
                                        " where MaSoDonThuoc = " + ID_MSDT + " and MaSoThuoc = " + ID_Thuoc_RowClick + ";" +
                                        " update Thuoc set SoLuongNhoNhat =" + SoLuongThuocNhoNhat_TrongKho_HienTai +
                                        " where MaSoThuoc =" + ID_Thuoc;//Cập nhật thuốc ngay tại con trỏ chuột đã bấm

                connection.sql(update_DonThuoc);
                if (SoLuongThuocNhoNhat_TrongKho_HienTai == 0 || SoLuongThuocNhoNhat_TrongKho_HienTai <= 10)
                {
                    MessageBox.Show("Số lượng trong kho đã hết! Vui lòng liên hệ đặt hàng", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void Update_TinhToan_TinhSoLuongThuocNhapMoi(int ID_Thuoc)//Tính số lượng của Thuốc cũ khi update Thuốc mới. Dành cho Người dùng Update Số lượng thuốc nhưng không thay đổi tên thuốc
        {
            int SoLuongDonThuoc_NhapCu = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("SoLuong").ToString());

            string GetSoluongThuocNhoNhat_HienTaiTrongKho = @"select SoLuongNhoNhat from Thuoc where MaSoThuoc = " + ID_Thuoc;
            DataTable dt_SoLuongNhoNhat = connection.SQL(GetSoluongThuocNhoNhat_HienTaiTrongKho);
            int SoluongThuocNhoNhat_HienTaiTrongKho = int.Parse(dt_SoLuongNhoNhat.Rows[0][0].ToString());

            int SoLuongThuoc_KhoDuMoi;
            int SoLuongThuoc_KhoMoi;
            if (int.Parse(txt_SoLuong.Text) < SoluongThuocNhoNhat_HienTaiTrongKho)
            {
                SoLuongThuoc_KhoDuMoi = SoluongThuocNhoNhat_HienTaiTrongKho - int.Parse(txt_SoLuong.Text);
                SoLuongThuoc_KhoMoi = SoLuongDonThuoc_NhapCu + SoLuongThuoc_KhoDuMoi;
                if (SoLuongThuoc_KhoMoi < 0)
                {
                    MessageBox.Show("Số lượng trong kho không đủ!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SoLuongThuoc_KhoMoi > 0)
                {
                    string update_DonThuoc = @"update DanhSachThuoc set MaSoThuoc = " + ID_Thuoc + "," +
                                        " SoLuong = " + txt_SoLuong.Text + "," +
                                        " CachDung = N'" + txt_CachDung.Text + "'" +
                                        " where MaSoDonThuoc = " + ID_MSDT + " and MaSoThuoc = " + ID_Thuoc_RowClick + ";" +
                                        " update Thuoc set SoLuongNhoNhat =" + SoLuongThuoc_KhoMoi +
                                        " where MaSoThuoc =" + ID_Thuoc;//Cập nhật thuốc ngay tại con trỏ chuột đã bấm

                    connection.sql(update_DonThuoc);
                }
                if (SoLuongThuoc_KhoMoi >= 0 && SoLuongThuoc_KhoMoi <= 10)
                {
                    MessageBox.Show("Số lượng trong kho đã gần hết! Vui lòng liên hệ đặt hàng", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (int.Parse(txt_SoLuong.Text) > SoluongThuocNhoNhat_HienTaiTrongKho)
            {
                SoLuongThuoc_KhoDuMoi = SoluongThuocNhoNhat_HienTaiTrongKho - int.Parse(txt_SoLuong.Text);
                SoLuongThuoc_KhoMoi = SoLuongDonThuoc_NhapCu + SoLuongThuoc_KhoDuMoi;
                if (SoLuongThuoc_KhoMoi < 0)
                {
                    MessageBox.Show("Số lượng trong kho không đủ!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SoLuongThuoc_KhoMoi > 0)
                {
                    string update_DonThuoc = @"update DanhSachThuoc set MaSoThuoc = " + ID_Thuoc + "," +
                                       " SoLuong = " + txt_SoLuong.Text + "," +
                                       " CachDung = N'" + txt_CachDung.Text + "'" +
                                       " where MaSoDonThuoc = " + ID_MSDT + " and MaSoThuoc = " + ID_Thuoc_RowClick + ";" +
                                       " update Thuoc set SoLuongNhoNhat =" + SoLuongThuoc_KhoMoi +
                                       " where MaSoThuoc =" + ID_Thuoc;//Cập nhật thuốc ngay tại con trỏ chuột đã bấm
                    connection.sql(update_DonThuoc);
                }

                if (SoLuongThuoc_KhoMoi >= 0 && SoLuongThuoc_KhoMoi <= 10)
                {
                    MessageBox.Show("Số lượng trong kho đã gần hết! Vui lòng liên hệ đặt hàng", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            connection.connect();
            int ID_Thuoc=0;
            string TenThuoc = txt_TenThuoc.Text;
            string TenThuoc_RowClick = gridView1_DonThuoc.GetFocusedRowCellValue("TenThuoc").ToString();
            if (RowClick ==true && TenThuocClick==false)//Khi người dùng không chọn vào Tên thuốc mà nhấn Update luôn
            {
                ID_Thuoc = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("MaSoThuoc").ToString());
                Update_TinhToan_TinhSoLuongThuocNhapMoi(ID_Thuoc);
            }
            else if(RowClick==true && TenThuoc == TenThuoc_RowClick)//Khi người dùng chọn vào Tên thuốc nhưng giống với tên thuốc hiện tại (Không thay đổi tên thuốc, chỉ chọn)
            {
                ID_Thuoc= int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("MaSoThuoc").ToString());//lấy mã số thuốc từ chọn tên thuốc trong ComboboxEdit
                Update_TinhToan_TinhSoLuongThuocNhapMoi(ID_Thuoc);
            }
            else if(RowClick == true && TenThuoc != TenThuoc_RowClick)//Khi người dùng chọn vào tên thuốc và lấy tên thuốc khác so với thuốc hiện tại
            {
                ID_Thuoc = int.Parse(searchLookUpEdit1View.GetFocusedRowCellValue("MaSoThuoc").ToString());
                Update_TinhToan_TinhSoLuongThuocCu(ID_Thuoc);
            }            
            connection.disconnect();
            refresh_DonThuoc();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int SoLuongThuocCu_DaNhap_TrongDonThuoc = int.Parse(gridView1_DonThuoc.GetFocusedRowCellValue("SoLuong").ToString());
            connection.connect();
            string GetSoLuongThuoc_TrongFormDonThuoc = @"select SoLuongNhoNhat from Thuoc where MaSoThuoc = " + ID_Thuoc_RowClick;//Lấy số lượng Thuốc khi RowClick vào gridview
            DataTable datatable_GetSoLuongThuoc_TrongFormDonThuoc = connection.SQL(GetSoLuongThuoc_TrongFormDonThuoc);
            int SoLuongThuocCu_TrongFormDonThuoc = int.Parse(datatable_GetSoLuongThuoc_TrongFormDonThuoc.Rows[0][0].ToString());//Lấy số lượng Thuốc khi RowClick vào gridview

            int SoLuongThuocCu_KhoMoi_TrongFormThuoc = SoLuongThuocCu_DaNhap_TrongDonThuoc + SoLuongThuocCu_TrongFormDonThuoc;

            string Xoa_DanhSachThuoc = @"delete from DanhSachThuoc where MaSoThuoc = " + ID_Thuoc_RowClick;//xóa thuốc ngay tại con trỏ chuột đã bấm
            connection.connect();
            connection.delete(Xoa_DanhSachThuoc);

            string Update_SoLuongThuoc_trongKho = @" update Thuoc set SoLuongNhoNhat =" + SoLuongThuocCu_KhoMoi_TrongFormThuoc +
                                                     " where MaSoThuoc =" + ID_Thuoc_RowClick;
            
            connection.delete(Update_SoLuongThuoc_trongKho);

            connection.disconnect();
            refresh_DonThuoc();
        }

        private void btn_XemDonThuoc_Click(object sender, EventArgs e)
        {
            NgayKeDon = dtP_NgayKeDon.Text;//gán giá trị từ form Đơn Thuốc sang form Xem Đơn Thuốc
            GhiChu = txt_GhiChu.Text;//gán giá trị từ form Đơn Thuốc sang form Xem Đơn Thuốc
            //TienThuoc =mtxt_TienThuoc.Text;//gán giá trị từ form Đơn Thuốc sang form Xem Đơn Thuốc
            
            printDonThuoc printDonThuoc = new printDonThuoc();//show form Xem đơn thuốc

            printDonThuoc.ShowDialog();            
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)//nút Hoàn thành
        {
            if(function.checkNull(panelControl4)==true)
            {
                string query = @"update DonThuoc set " +
                                " NgayKeDon = N'" + dtP_NgayKeDon.Text + "'," +
                                " GhiChu = N'" + txt_GhiChu.Text + "'," +
                                " TongTienThuoc = h.TongTien "  +//gán 1 biến tạm cho TongTienThuoc
                                " from ( select sum(T.DonGiaNhoNhat * DST.SoLuong) as TongTien " +//tính sum của DonGia * SoLuong
                                "           from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc " + //hàm tính sum bình thường giống hàm Tính Tiền Thuốc
                                "           left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc where DT.MaSoKhamBenh =  " + ID_MSKB + ") h"+ //gán biến h 
                                " join DonThuoc DT on DT.MaSoKhamBenh =" + ID_MSKB;
                connection.connect();
                connection.sql(query);
                connection.disconnect();
                ID_MSDT = 0;
                this.Close();
                
            }

        }

        private void TinhTienThuoc()//hàm tự động tính tiền thuốc khi load form Đơn thuốc lên
        {
            string query = @"select sum(T.DonGiaNhoNhat * DST.SoLuong)" +//tính tổng của Đơn giá * Số Lượng nhập vào
                                " from DanhSachThuoc DST left join Thuoc T on DST.MaSoThuoc = T.MaSoThuoc " +
                                            " left join DonThuoc DT on DST.MaSoDonThuoc = DT.MaSoDonThuoc " +
                                " where DT.MaSoKhamBenh = " + ID_MSKB;
            DataTable dataTable = connection.SQL(query);
            TienThuoc = dataTable.Rows[0][0].ToString();//Gán tiền thuốc vào text
        }

        private void DonThuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ID_MSDT = 0;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ID_MSDT = 0;
            this.Close();
        }

        private void txt_TenThuoc_MouseClick(object sender, MouseEventArgs e)
        {
            TenThuocClick = true;
        }

        
    }
}