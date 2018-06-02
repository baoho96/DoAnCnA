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
    public partial class ThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        connection connection = new connection();
        function function = new function();
        SqlCommand sqlCommand;
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource = new BindingSource();
        DoanhThu doanhThu = new DoanhThu();

        public static string TongSoLuong { get; set; }
        public static string TongTien { get; set; }
        public static string NhapNgay { get; set; }
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(checkB_TimTheoThang.Checked ==true)
            {
                NhapNgay = dtP_NhapNgay.Value.Month.ToString() + "/" + dtP_NhapNgay.Value.Year.ToString();
                Load_reportDoanhThu(NhapNgay);
            }
            else if(checkB_TimTheoNam.Checked==true)
            {
                NhapNgay =  dtP_NhapNgay.Value.Year.ToString();
                Load_reportDoanhThu(NhapNgay);
            }
        }
        private void Load_reportDoanhThu(string NhapNgay)
        {
            string query = @"select NgayGioLap,COUNT(MaHoaDon) as SoLuong, sum(TongTien) as TongTien "+
                            " from HoaDon "+
                            " where NgayGioLap like N'%"+ NhapNgay + "'"+
                            " group by NgayGioLap";
            
            connection.connect();

            string Load_TongTien_TongKham = @"select COUNT(MaHoaDon) as TongSoLuong, sum(TongTien) as TongTien --tính tổng theo doanh thu
                                                from HoaDon
                                                    where NgayGioLap like N'%"+NhapNgay+"'";
            DataTable dataTable = connection.SQL(Load_TongTien_TongKham);
            TongSoLuong = dataTable.Rows[0][0].ToString();
            TongTien = dataTable.Rows[0][1].ToString();

            dataSet = new DataSet();
            dataSet.Clear();
            //đổ dữ liệu vào dataAdapter
            sqlDataAdapter = new SqlDataAdapter(query, connection.con);
            sqlDataAdapter.Fill(dataSet, "HoaDon");
            doanhThu.DataSource = dataSet.Tables["HoaDon"];
            doanhThu.Bindata();
            connection.disconnect();
            //hiển thị report lên documentViewer1
            documentViewer1_DoanhThu.PrintingSystem = doanhThu.PrintingSystem;
            doanhThu.CreateDocument();
        }

        private void checkB_TimTheoThang_Click(object sender, EventArgs e)
        {
            checkB_TimTheoNam.Checked = false;
        }

        private void checkB_TimTheoNam_Click(object sender, EventArgs e)
        {
            checkB_TimTheoThang.Checked = false;
        }
    }
}