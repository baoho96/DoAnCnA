using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
namespace QuanLyPhongKham
{
    public partial class NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader rd;
        BindingSource bindingSource = new BindingSource();
        DataSet ds;
        OpenFileDialog open;
        string hinhanh = null;
        DialogResult result;
        function function = new function();
        connection connection = new connection();
        ThemCho themCho;

        bool Rowfocus = false;//Kiểm tra khi chọn row

        public static int ID_MSKB_DoubleClick { get; set; }

        public NhanVien()
        {
            InitializeComponent();
        }



        private void NhanVien_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'phongKhamDataSet.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);

            this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);//Load Hồ Sơ Khám Bệnh cho tab Tìm kiếm bệnh nhân khám bệnh
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoKhamBenh' table. You can move, or remove it, as needed.
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);

            hoSoTaiKhamTableAdapter1.Fill(phongKhamDataSet.HoSoTaiKham);//Load Hồ sơ tái khám ở tab Tìm kiếm bệnh nhân khám bênh



            load_TiepNhanBenhNhan_comB_GioiTinh();

            load_DanhSachBenhNhan_comB_GioiTinh();

            filterColumn_TiepNhanBenhNhan();

            
        }
        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            refresh_TiepNhanBenhNhan();
            refresh_DanhSachBenhNhan();//Tiếp nhận bệnh nhân cũ
            refresh_TimKiemBenhNhan();//Tiếp nhận bệnh nhân tái khám
            refresh_TimKiemBenhNhanTaiKham();
            gridView1_TimBenhNhan.ClearGrouping();   //Tìm kiếm bệnh nhân         
            gridView4_DanhSachBenhNhan.ClearGrouping();//Tiếp nhận bệnh nhân cũ
            gridView1_TimKiemBenhNhan.ClearGrouping();//Tiếp nhận bệnh nhân tái khám

            gridView1_TiepNhanBenhNhan.UnselectRow(int.Parse(gridView1_TiepNhanBenhNhan.FocusedRowHandle.ToString()));            
            gridView4_DanhSachBenhNhan.UnselectRow(int.Parse(gridView4_DanhSachBenhNhan.FocusedRowHandle.ToString()));
            gridView1_TimKiemBenhNhan.UnselectRow(int.Parse(gridView1_TimKiemBenhNhan.FocusedRowHandle.ToString()));
            gridView1_TimBenhNhan.UnselectRow(int.Parse(gridView1_TimBenhNhan.FocusedRowHandle.ToString()));
        }
        #region tab Tiếp nhận bệnh nhân

        private void filterColumn_TiepNhanBenhNhan()
        {            //string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            string ngay = DateTime.Now.Day.ToString("d2");
            string thang = DateTime.Now.Month.ToString("d2");
            string nam = DateTime.Now.Year.ToString();            
            gridView1_TiepNhanBenhNhan.ActiveFilterString = "Contains([NgayGioKham], '" + ngay + "/" + thang + "/" + nam + "') And [KiemTraKham] Is Null";
            //gridView1_TimKiemBenhNhan.ActiveFilterString = "Contains([NgayTaiKham], '" + ngay + "/" + thang + "/" + nam + "')";
        }
        //private void Load_TiepNhanBenhNhan()
        //{
        //    connection.connect();

        //    string Load_Data = @"SELECT     DISTINCT   HSKB.MaSoKhamBenh, HSKB.MaSoBenhNhan, BN.Ho, BN.Ten, BN.GioiTinh, BN.NamSinh,"+
        //                 "HSKB.NgayGioKham, HSKB.MaSoBacSi, HSKB.XetNghiem, HSKB.ChuanDoan, HSKB.TienKham, HSKB.NgayTaiKham, HSKB.GhiChu, "+
        //                 "HSKB.KiemTraKham, HSKB.LiDoKham, BN.DiaChi, BN.SoDienThoai, BN.HinhAnh"+
        //                        "FROM            HoSoKhamBenh AS HSKB right OUTER JOIN"+
        //                                                "BenhNhan AS BN ON BN.MaSoBenhNhan = HSKB.MaSoBenhNhan";
        //    da = new SqlDataAdapter(Load_Data, connection.con);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds, "HoSoKhamBenh");

        //    bindingSource.DataSource = ds.Tables["HoSoKhamBenh"];
        //    TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.DataSource = bindingSource;

        //    connection.disconnect();
        //}
        private void refresh_TiepNhanBenhNhan()
        {
            function.ClearControl(panelControl2);
            
            TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.Refresh();
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            load_TiepNhanBenhNhan_comB_GioiTinh();

            hinhanh = null;
            result = new DialogResult();
            TiepNhanBenhNhan_btn_CapNhat.Enabled = false;
            TiepNhanBenhNhan_btn_Xoa.Enabled = false;
        }
        private void load_TiepNhanBenhNhan_comB_GioiTinh()
        {
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Nam");
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Nữ");
            TiepNhanBenhNhan_comB_GioiTinh.Items.Add("Khác");
        }
        private void TiepNhanBenhNhan_txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void TiepNhanBenhNhan_txt_CanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            function.KoNhapKiTu(sender, e);
        }
        private void gridView1_TiepNhanBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void TiepNhanBenhNhan_dtP_namsinh_ValueChanged(object sender, EventArgs e)
        {
            //DateTime ngaysinh = TiepNhanBenhNhan_dtP_namsinh.Value;
            //DateTime thoigiankham = TiepNhanBenhNhan_dtP_NgayKham.Value;
            //if (ngaysinh > thoigiankham)
            //{
            //    MessageBox.Show("Vui lòng nhập đúng Ngày sinh và Thời gian Khám");
            //}
        }
        private void gridView1_TiepNhanBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }
        private void pictureBox1_BenhNhan_DoubleClick(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_BenhNhan.Image = Image.FromStream(open.OpenFile());

                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_BenhNhan.Image = new Bitmap(open.FileName);
            }
        }
        private void TiepNhanBenhNhan_btn_TaoMoi_Click(object sender, EventArgs e)
        {
            if (function.checkNull(panelControl2) == true)
            {
                connection.connect();

                if (pictureBox1_BenhNhan.Image != null)//kiểm tra picturebox có rỗng hay không
                {
                    if (result == DialogResult.OK)
                    {
                        hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                        string previewPath = Application.StartupPath + @"\Hinh\BenhNhan\" + hinhanh;
                        string linkHinhAnh = open.FileName;
                        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                    }
                    else { }
                }
                else { }

                string KiemTraTonTai = @"select Ho, Ten,NamSinh,CheckDaKham from BenhNhan" +
                    " where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' and Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text +
                    "' and NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
                cmd = new SqlCommand(KiemTraTonTai, connection.con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][3].ToString() != "NULL")
                {
                    if (MessageBox.Show("Bạn đã trùng tên và bạn có muốn Thêm bệnh nhân vào hàng chờ khám??!", "Thông Báo Nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        int ID_BenhNhan;
                        int CheckKham = 1;
                        string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
                            + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
                        DataTable dt1 = connection.SQL(layMSBN);
                        ID_BenhNhan = int.Parse(dt1.Rows[0][0].ToString());

                        if (TiepNhanBenhNhan_txt_LiDoKham.Text != "")
                        {
                            string query = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                            + ID_BenhNhan + ","
                            + "N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "',"
                            + "'" + TiepNhanBenhNhan_dtP_NgayKham.Text + "')";
                            connection.insert(query);

                            string query1 = @"update BenhNhan set CheckDaKham = " + CheckKham + " where MaSoBenhNhan = " + ID_BenhNhan;
                            connection.insert(query1);
                            refresh_TiepNhanBenhNhan();
                        }
                        else { MessageBox.Show("Vui lòng nhập lý do khám và Nhấn vào nút 'Thêm chờ'", "Thông báo"); }

                    }


                }

                else
                {
                    //dt.Dispose();
                    int CheckDaKham = 1;
                    string query = @" insert into BenhNhan(Ho, Ten, NamSinh,DiaChi, SoDienThoai, GioiTinh,HinhAnh,CanNang,TenNguoiThan,CheckDaKham) values"
                   + "(N'" + TiepNhanBenhNhan_txt_Ho.Text + "',"
                   + "N'" + TiepNhanBenhNhan_txt_Ten.Text + "',"
                   + "'" + TiepNhanBenhNhan_dtP_namsinh.Text + "',"
                   + "N'" + TiepNhanBenhNhan_txt_DiaChi.Text + "',"
                   + TiepNhanBenhNhan_txt_SDT.Text + ","
                   + "N'" + TiepNhanBenhNhan_comB_GioiTinh.Text + "',"
                   + "N'" + hinhanh + "',"
                   + TiepNhanBenhNhan_txt_CanNang.Text + ","
                   + "N'" + TiepNhanBenhNhan_txt_TenNguoiThan.Text + "',"
                   + CheckDaKham + ")";
                    connection.insert(query);

                    ThemChoKham_TiepNhanBenhNhan();

                    refresh_TiepNhanBenhNhan();                    
                    hoSoTaiKhamTableAdapter1.Fill(phongKhamDataSet.HoSoTaiKham);
                    this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);
                    this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);
                    MessageBox.Show("Nhập Thành công!", "Thông Báo Nhập");
                }
                dt.Dispose();

                connection.disconnect();
            }
        }
        private void ThemChoKham_TiepNhanBenhNhan()
        {
            int ID_BenhNhan;
            string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
                            + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
            DataTable dt = connection.SQL(layMSBN);
            ID_BenhNhan = int.Parse(dt.Rows[0][0].ToString());

            string query = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                + ID_BenhNhan + ","
                + "N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "',"
                + "'" + TiepNhanBenhNhan_dtP_NgayKham.Text + "')";
            connection.insert(query);
        }
        //private void TiepNhanBenhNhan_btn_TimKiem_Click(object sender, EventArgs e)
        //{
        //    connection.connect();

        //    string Load_Data = @"select * from BenhNhan where Ho like '" + TiepNhanBenhNhan_txt_Ho.Text + "%'" +
        //                                              " and Ten like '" + TiepNhanBenhNhan_txt_Ten.Text + "'" +
        //                                              " and NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
        //    da = new SqlDataAdapter(Load_Data, connection.con);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds, "BenhNhan");

        //    bindingSource.DataSource = ds.Tables["BenhNhan"];
        //    TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.DataSource = bindingSource;
        //    this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
        //    //connection.disconnect();
        //}
        private void gridView1_TiepNhanBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            TiepNhanBenhNhan_btn_CapNhat.Enabled = true;
            TiepNhanBenhNhan_btn_Xoa.Enabled = true;
            TiepNhanBenhNhan_txt_LiDoKham.Text = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("LiDoKham").ToString();
            TiepNhanBenhNhan_dtP_NgayKham.Text = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("NgayGioKham").ToString();
            //string ID = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
            //TiepNhanBenhNhan_txt_Ho.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["Ho"]).ToString();
            //TiepNhanBenhNhan_txt_Ten.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["Ten"]).ToString();
            //TiepNhanBenhNhan_dtP_namsinh.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["NamSinh"]).ToString();
            //TiepNhanBenhNhan_comB_GioiTinh.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["GioiTinh"]).ToString();
            //TiepNhanBenhNhan_txt_SDT.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["SoDienThoai"]).ToString();
            //TiepNhanBenhNhan_txt_DiaChi.Text = gridView1_TiepNhanBenhNhan.GetRowCellValue(gridView1_TiepNhanBenhNhan.FocusedRowHandle, gridView1_TiepNhanBenhNhan.Columns["DiaChi"]).ToString();


            //connection.connect();

            //string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
            //cmd = new SqlCommand(layhinhanh, connection.con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
            //    {
            //        if (File.Exists(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString()))//kiểm tra hình ảnh có trong thư mục hay không
            //        {
            //            //có thì sẽ load hình ảnh vào pictureBox
            //            pictureBox1_BenhNhan.Image = new Bitmap(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString());
            //        }
            //        else
            //        {
            //            //không thì hiện thông báo
            //            function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
            //        }
            //    }
            //    else
            //    {
            //        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
            //        pictureBox1_BenhNhan.Image = null;
            //        continue;
            //    }
            //}
            //dr.Close();

            //connection.disconnect();
        }

        private void TiepNhanBenhNhan_btn_CapNhat_Click(object sender, EventArgs e)
        {
            connection.connect();
            string ID_MSKB = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString();

            string query1 = @"update HoSoKhamBenh set LiDoKham = N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "'," +
                "NgayGioKham ='" + TiepNhanBenhNhan_dtP_NgayKham.Text + "'" +
                " where MaSoKhamBenh =" + ID_MSKB;
            connection.sql(query1);
            connection.disconnect();
            refresh_TiepNhanBenhNhan();
            //if (pictureBox1_BenhNhan.Image != null)//kiểm tra picturebox có rỗng hay không
            //{
            //    if (result == DialogResult.OK)
            //    {
            //        string previewPath = Application.StartupPath + @"\Hinh\BenhNhan\" + hinhanh;
            //        string linkHinhAnh = open.FileName;
            //        File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
            //    }
            //    else
            //    {
            //        string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
            //        DataTable dt1 = connection.SQL(layhinhanh);
            //        hinhanh = dt1.Rows[0][0].ToString();
            //    }
            //}
            //else { }

            //string query = @"update BenhNhan set Ho = N'" + TiepNhanBenhNhan_txt_Ho.Text + "'," +
            //"Ten = N'" + TiepNhanBenhNhan_txt_Ten.Text + "'," +
            //"SoDienThoai =" + TiepNhanBenhNhan_txt_SDT.Text + "," +
            //"GioiTinh = N'" + TiepNhanBenhNhan_comB_GioiTinh.Text + "'," +
            //"NamSinh ='" + TiepNhanBenhNhan_dtP_namsinh.Text + "'," +
            //"DiaChi = N'" + TiepNhanBenhNhan_txt_DiaChi.Text + "'," +
            //"HinhAnh = N'" + hinhanh + "'" +
            //" where MaSoBenhNhan =" + ID;
            //connection.sql(query);




        }

        private void TiepNhanBenhNhan_btn_Xoa_Click(object sender, EventArgs e)
        {
            string ID_BenhNhan = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
            string ID_KhamBenh = gridView1_TiepNhanBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString();

            connection.connect();
            string query1 = @"delete from HoSoKhamBenh where MaSoBenhNhan = " + ID_BenhNhan + " and MaSoKhamBenh = "+ ID_KhamBenh;
            connection.delete(query1);
            connection.disconnect();
            refresh_TiepNhanBenhNhan();
        }
        //private void TiepNhanBenhNhan_btn_ThemCho_Click(object sender, EventArgs e)
        //{
        //    connection.connect();
        //    int ID_BenhNhan;
        //    int CheckKham = 1;
        //    string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
        //                    + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
        //    DataTable dt = connection.SQL(layMSBN);
        //    ID_BenhNhan = int.Parse(dt.Rows[0][0].ToString());

        //    string query = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
        //        + ID_BenhNhan + ","
        //        + "N'" + TiepNhanBenhNhan_txt_LiDoKham.Text + "',"
        //        + "'" + TiepNhanBenhNhan_dtP_NgayKham.Text + "')";
        //    connection.insert(query);

        //    string query1 = @"update BenhNhan set CheckDaKham = " + CheckKham + " where MaSoBenhNhan = " + ID_BenhNhan;
        //    connection.insert(query1);

        //    connection.disconnect();
        //    refresh_TiepNhanBenhNhan();
        //}
        
        private void barButtonItem2_XuatFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NhanVien_tabP_TiepNhanBenhNhan.Focus() == true)
            {
                function.ToExcel("Bạn muốn xuất file Tiếp nhận Bệnh nhân khám mới trong ngày??", result, TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham);
            }
            if (NhanVien_tabP_DanhSachBenhNhan.Focus() == true)
            {
                function.ToExcel("Bạn muốn xuất file Tiếp nhận bệnh nhân cũ???", result, DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan);
            }
            if (NhanVien_tabP_DanhSachBenhNhanTaiKham.Focus() == true)
            {
                function.ToExcel("Bạn muốn xuất file Tiếp nhận Bệnh Nhân tái khám???", result, gridControl1_TimKiemBenhNhan);
            }
            if (xtra_TimBenhNhan.Focus() == true)
            {
                function.ToExcel("Bạn muốn xuất file Danh Sách Bệnh Nhân Được tìm theo ngày???", result, gridControl1_TimBenhNhan);
            }
        }
        private void barButtonItem1_Xuatfilekhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NhanVien_tabP_TiepNhanBenhNhan.Focus() == true)
            {
                TiepNhanBenhNhan_gridC_danhsachBenhNhanDangKiKham.ShowRibbonPrintPreview();
            }
            if (NhanVien_tabP_DanhSachBenhNhan.Focus() == true)
            {
                DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan.ShowRibbonPrintPreview();
            }
            if (NhanVien_tabP_DanhSachBenhNhanTaiKham.Focus() == true)
            {
                gridControl1_TimKiemBenhNhan.ShowRibbonPrintPreview();
            }
            if (xtra_TimBenhNhan.Focus() == true)
            {
                gridControl1_TimBenhNhan.ShowRibbonPrintPreview();
            }
        }

        #endregion

        #region Tiếp nhận bệnh nhân cũ
        private void refresh_DanhSachBenhNhan()
        {
            function.ClearControl(panelControl4);
            this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            this.benhNhanTableAdapter.Fill(this.phongKhamDataSet.BenhNhan);
            load_DanhSachBenhNhan_comB_GioiTinh();
            hinhanh = null;
            result = new DialogResult();
            panelControl4.Enabled = false;
        }
        private void load_DanhSachBenhNhan_comB_GioiTinh()
        {
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Nam");
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Nữ");
            DanhSachBenhNhan_comB_GioiTinh.Items.Add("Khác");
        }
        private void pictureBox1_DanhSachBenhNhan_DoubleClick(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            open.Filter = "Select Images |*.jpg||*.png";
            open.Multiselect = false;
            result = open.ShowDialog();
            open.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                pictureBox1_DanhSachBenhNhan.Image = Image.FromStream(open.OpenFile());

                hinhanh = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1, open.FileName.Length - open.FileName.LastIndexOf("\\") - 1);
                pictureBox1_DanhSachBenhNhan.Image = new Bitmap(open.FileName);
            }
        }

        private void DanhSachBenhNhan_btn_DieuChinh_Click(object sender, EventArgs e)
        {
            
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                if (function.checkNull(panelControl4) == true)//kiểm tra các thành phần có rỗng hay không
                {
                    connection.connect();
                    string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
                
                    if (pictureBox1_DanhSachBenhNhan.Image != null)//kiểm tra picturebox có rỗng hay không
                    {
                        if (result == DialogResult.OK)
                        {
                            string previewPath = Application.StartupPath + @"\Hinh\BenhNhan\" + hinhanh;
                            string linkHinhAnh = open.FileName;
                            File.Copy(linkHinhAnh, previewPath, true);//copy file ảnh vào thư mục project
                        }
                        else
                        {
                            string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
                            DataTable dt1 = connection.SQL(layhinhanh);
                            hinhanh = dt1.Rows[0][0].ToString();
                        }
                    }
                    else { }

                    string query = @"update BenhNhan set Ho = N'" + DanhSachBenhNhan_txt_Ho.Text + "'," +
                    "Ten = N'" + DanhSachBenhNhan_txt_Ten.Text + "'," +
                    "SoDienThoai =" + DanhSachBenhNhan_txt_SDT.Text + "," +
                    "GioiTinh = N'" + DanhSachBenhNhan_comB_GioiTinh.Text + "'," +
                    "NamSinh ='" + DanhSachBenhNhan_dtP_NamSinh.Text + "'," +
                    "DiaChi = N'" + DanhSachBenhNhan_txt_DiaChi.Text + "'," +
                    "HinhAnh = N'" + hinhanh + "'," +
                    "TenNguoiThan = N'" + DanhSachBenhNhan_txt_TenNguoiThan.Text + "'," +
                    "CanNang = " + DanhSachBenhNhan_txt_CanNang.Text +
                    " where MaSoBenhNhan =" + ID;
                    connection.sql(query);

                    connection.disconnect();
                    refresh_DanhSachBenhNhan();
                }
            }
            
        }
        private void DanhSachBenhNhan_btn_ThemCho_Click(object sender, EventArgs e)
        {
            
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                string ngay = DateTime.Now.Day.ToString("d2");
                string thang = DateTime.Now.Month.ToString("d2");
                string nam = DateTime.Now.Year.ToString();
                connection.connect();
                int ID_BenhNhan = int.Parse(gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
                int CheckKham = 1;
                //string layMSBN = @"select MaSoBenhNhan from BenhNhan where Ho like N'" + TiepNhanBenhNhan_txt_Ho.Text + "%' And Ten like N'" + TiepNhanBenhNhan_txt_Ten.Text
                //                + "' And NamSinh = '" + TiepNhanBenhNhan_dtP_namsinh.Text + "'";
                //DataTable dt = connection.SQL(layMSBN);
                //ID_BenhNhan = int.Parse(dt.Rows[0][0].ToString());
                string ngaykham;
                string lidokham;
                themCho = new ThemCho();
                themCho.ShowDialog();

                ngaykham = themCho.ngaykham;
                lidokham = themCho.lidokham;
                string query = @"begin if not exists (select HSKB.MaSoBenhNhan ,HSKB.NgayGioKham" +
                                    " from  BenhNhan BN join HoSoKhamBenh HSKB on BN.MaSoBenhNhan = HSKB.MaSoBenhNhan" +
                                        " where HSKB.MaSoBenhNhan = " + ID_BenhNhan + "and HSKB.NgayGioKham like '" + ngay + "/" + thang + "/" + nam + "%')" +
                                 " begin insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham) values ("
                    + ID_BenhNhan + ","
                    + "N'" + lidokham + "',"
                    + "'" + ngaykham + "') end end";
                connection.insert(query);
                connection.disconnect();
                refresh_DanhSachBenhNhan();
                
            }
            
        }
        //private void DanhSachBenhNhan_btn_TimKiem_Click(object sender, EventArgs e)
        //{
        //    connection.connect();

        //    string Load_Data = @"select * from BenhNhan where Ho like '" + DanhSachBenhNhan_txt_Ho.Text + "%'" +
        //                                              " and Ten like '" + DanhSachBenhNhan_txt_Ten.Text + "'" +
        //                                              " and NamSinh = '" + DanhSachBenhNhan_dtP_NamSinh.Text + "'";
        //    da = new SqlDataAdapter(Load_Data, connection.con);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds, "BenhNhan");

        //    bindingSource.DataSource = ds.Tables["BenhNhan"];
        //    DanhSachBenhNhanTaiKham_gridC_danhsachBenhNhan.DataSource = bindingSource;

        //    connection.disconnect();
        //}

        private void gridView4_DanhSachBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            panelControl4.Enabled = true;
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if(ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();
                DanhSachBenhNhan_txt_Ho.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("Ho").ToString();
                DanhSachBenhNhan_txt_Ten.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("Ten").ToString();
                DanhSachBenhNhan_dtP_NamSinh.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("NamSinh").ToString();
                DanhSachBenhNhan_comB_GioiTinh.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("GioiTinh").ToString();
                DanhSachBenhNhan_txt_SDT.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("SoDienThoai").ToString();
                DanhSachBenhNhan_txt_DiaChi.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("DiaChi").ToString();
                DanhSachBenhNhan_txt_CanNang.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("CanNang").ToString();
                DanhSachBenhNhan_txt_TenNguoiThan.Text = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("TenNguoiThan").ToString();

                connection.connect();
                string layhinhanh = @"select hinhanh from BenhNhan where MaSoBenhNhan = " + ID;
                cmd = new SqlCommand(layhinhanh, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["hinhanh"].ToString() != "")//kiểm tra đường dẫn hình ảnh từ SQL
                    {
                        if (File.Exists(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString()))//kiểm tra hình ảnh có trong thư mục hay không
                        {
                            //có thì sẽ load hình ảnh vào pictureBox
                            pictureBox1_DanhSachBenhNhan.Image = new Bitmap(Application.StartupPath + @"\Hinh\BenhNhan\" + dr["hinhanh"].ToString());
                        }
                        else
                        {
                            //không thì hiện thông báo
                            function.Notice("Không có file " + dr["hinhanh"].ToString() + " trong thư mục", 1);
                            pictureBox1_DanhSachBenhNhan.Image = null;
                        }
                    }
                    else
                    {
                        //chưa insert hình ảnh thì picturebox sẽ không hiện gì hết
                        pictureBox1_DanhSachBenhNhan.Image = null;
                        continue;
                    }
                }
                dr.Close();

                connection.disconnect();
            }
            else
            {
                //function.Notice("Bạn nên chọn cụ thể hơn!", 0);
            }
            
        }

        private void gridView4_DanhSachBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void gridView4_DanhSachBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            { // Double Click
                string cellValue = e.CellValue.ToString();
                MessageBox.Show(cellValue);
            }
        }

        private void DanhSachBenhNhan_btn_Xoa_Click(object sender, EventArgs e)
        {
            object ID_BenhNhan_CheckNull = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            if (ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)
            {
                string ID = gridView4_DanhSachBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString();

                connection.connect();
                string query1 = @"delete from BenhNhan where MaSoBenhNhan = " + ID;
                connection.delete(query1);
                connection.disconnect();
                refresh_DanhSachBenhNhan();
            }
        }
        #endregion

        #region Tiếp Nhận bệnh nhân tái khám
        private void refresh_TimKiemBenhNhan()//Tiếp Nhận bệnh nhân tái khám
        {            
            function.ClearControl(panelControl5);
            this.hoSoTaiKhamTableAdapter1.Fill(this.phongKhamDataSet.HoSoTaiKham);
            this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            TimKiemBenhNhanKham_btn_ThemChoTaiKham.Enabled = false;
            TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Enabled = false;
        }
        
        private void gridView1_TimKiemBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            TimKiemBenhNhanKham_btn_ThemChoTaiKham.Enabled = true;
            TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Enabled = true;
        }
        

        private void gridView1_TimKiemBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }

        private void TimKiemBenhNhanKham_btn_ThemChoTaiKham_Click(object sender, EventArgs e)
        {
            connection.connect();
            //lấy thông tin khi click chuột vào gridview
            //int ID_BenhNhan = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
            //int ID_MSKB_old = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            //string LiDoKham = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("LiDoKham").ToString();
            int KiemTraTaiKham = 1;
            //tạo object và gán cho cột khi row click để kiểm tra khi sử dụng chức năng group column
            object ID_BenhNhan_CheckNull = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan");
            object ID_MSKB_old_CheckNull = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh");
            object LiDoKham_CheckNull = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("LiDoKham");
            //sử dụng if để kiểm tra rỗng. Nếu không rỗng thì tiếp tục chức năng
            if ((ID_BenhNhan_CheckNull != null && ID_BenhNhan_CheckNull != DBNull.Value)|| (ID_BenhNhan_CheckNull == null && ID_MSKB_old_CheckNull == DBNull.Value)|| (LiDoKham_CheckNull == null && LiDoKham_CheckNull == DBNull.Value))
            {
                int ID_BenhNhan = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoBenhNhan").ToString());
                int ID_MSKB_old = int.Parse(gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
                string LiDoKham = gridView1_TimKiemBenhNhan.GetFocusedRowCellValue("LiDoKham").ToString();
                string Check_ID_MSKB_OLD_CoTonTai = @"select MaSoKhamBenh from HoSoTaiKham where MaSoKhamBenh =" + ID_MSKB_old;
                DataTable dataTable0 = connection.SQL(Check_ID_MSKB_OLD_CoTonTai);
                //int ID_MSKB_OLD_CoTonTai = int.Parse(dataTable0.Rows[0][0].ToString());
                if (dataTable0.Rows.Count >= 1)//kiểm tra tồn tại của cột trong sql
                {
                    function.Notice("Hồ Sơ số " + ID_MSKB_old + " đã có Tái khám!", 0);
                }
                else
                {
                    string Insert_HSKB = @"insert into HoSoKhamBenh(MaSoBenhNhan,LiDoKham,NgayGioKham,KiemTraTaiKham) values ("
                    + ID_BenhNhan + ","
                    + "N'" + LiDoKham + "',"
                    + "'" + TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Text + "',"
                    + KiemTraTaiKham + ")";
                    connection.insert(Insert_HSKB);

                    //lấy ID MSKB mới khi vừa insert vào hồ sơ khám bệnh
                    string LayID_MSKB_New = @"select MaSoKhamBenh from HoSoKhamBenh"
                        + " where MaSoBenhNhan = " + ID_BenhNhan + " AND"
                        + " LiDoKham = N'" + LiDoKham + "' AND "
                        + " NgayGioKham = '" + TiepNhanBenhNhanTaiKham_dtP_ThoiGianKham.Text + "' AND "
                        + " KiemTraTaiKham = " + KiemTraTaiKham;
                    DataTable dataTable = connection.SQL(LayID_MSKB_New);
                    int ID_MSKB_New = int.Parse(dataTable.Rows[0][0].ToString());

                    //insert vào hồ sơ tái khám
                    string Insert_HSTK = @"insert into HoSoTaiKham(MaSoTaiKham,MaSoKhamBenh,MaSoBenhNhan) values ("
                        + ID_MSKB_New + ","
                        + ID_MSKB_old + ","
                        + ID_BenhNhan + ")";
                    connection.insert(Insert_HSTK);

                    connection.disconnect();
                    refresh_TimKiemBenhNhan();
                }
                //insert vào Hồ sơ khám bệnh
            }
            else
            {
                //function.Notice("Bạn nên chọn cụ thể hơn", 0);                
            }
        }





        #endregion

        
        #region Tìm kiếm bệnh nhân khám
        private void gridView1_TimBenhNhan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void refresh_TimKiemBenhNhanTaiKham()
        {
            function.ClearControl(panelControl3);
            function.ClearControl(panelControl1);
            this.hoSoTaiKhamTableAdapter1.Fill(this.phongKhamDataSet.HoSoTaiKham);
            this.hoSoKhamBenhTableAdapter1.Fill(this.phongKhamDataSet.HoSoKhamBenh);
            TimKiemBenhNhanKham_btn_XoaHoSo.Enabled = false;
        }
        private void TimKiemBenhNhanKham_btn_TimKiemNgayKham_Click(object sender, EventArgs e)
        {

            gridView1_TimBenhNhan.ClearGrouping();
            //colNgayTaiKham1.GroupIndex = -1;
            clTimBenhNhan_NgayKham.GroupIndex = 1;

            if (TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked)
            {
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_NgayKham.Text;
            }
            else if (TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked)
            {
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_NgayKham.Value.Month.ToString() + "/" + TimKiemBenhNhanKhamBenh_dtP_NgayKham.Value.Year.ToString();
            }
        }
        private void TimKiemBenhNhanKham_btn_TimKiemTaiKham_Click(object sender, EventArgs e)
        {
            gridView1_TimBenhNhan.ClearGrouping();
            //colNgayGioKham1.GroupIndex = -1;
            clTimBenhNhan_NgayTaiKham.GroupIndex = 1;
            if (TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked)
            {
                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_TaiKham.Text;
            }
            else if (TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked)
            {

                gridView1_TimBenhNhan.FindFilterText = TimKiemBenhNhanKhamBenh_dtP_TaiKham.Value.Month.ToString() + "/" + TimKiemBenhNhanKhamBenh_dtP_TaiKham.Value.Year.ToString();
            }
        }
        private void gridView1_TimBenhNhan_RowClick(object sender, RowClickEventArgs e)
        {
            object ID_MSKB_CheckNull = gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh");
            if (ID_MSKB_CheckNull != null && ID_MSKB_CheckNull != DBNull.Value)
            {
                TimKiemBenhNhanKham_btn_XoaHoSo.Enabled = true;
                int ID_MSKB = int.Parse(gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());
            }
        }
        private void TimKiemBenhNhanKham_btn_XoaHoSo_Click(object sender, EventArgs e)
        {
            object ID_MSKB_CheckNull = gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh");
            if (ID_MSKB_CheckNull != null && ID_MSKB_CheckNull != DBNull.Value)
            {
                int ID_MSKB = int.Parse(gridView1_TimBenhNhan.GetFocusedRowCellValue("MaSoKhamBenh").ToString());

                connection.connect();
                string query1 = @"delete from HoSoKhamBenh where MaSoKhamBenh = " + ID_MSKB;
                connection.delete(query1);
                connection.disconnect();
                refresh_TimKiemBenhNhanTaiKham();
            }
        }
        #endregion

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            //DangNhap dangNhap = new DangNhap();
            //dangNhap.Show();
            
            
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Admin.IfAdmin == true)
            {
                this.Hide();
            }
            else
            {
                if ((MessageBox.Show("Bạn Có Muốn Đăng Xuất không?", "Thông Báo!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            Admin.IfAdmin = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_NgayKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_ThangKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_ThangKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_NgayKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_NgayTaiKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_ThangTaiKham.Checked = false;
        }

        private void TimKiemBenhNhanKhamBenh_checB_ThangTaiKham_Click(object sender, EventArgs e)
        {
            TimKiemBenhNhanKhamBenh_checB_NgayTaiKham.Checked = false;
        }
    }

}