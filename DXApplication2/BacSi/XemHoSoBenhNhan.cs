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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace QuanLyPhongKham
{
    public partial class XemHoSoBenhNhan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();  
        DialogResult result;
        #endregion
        #region Biến khởi tạo
        public static int MSDT { get; set; }
        #endregion
        public XemHoSoBenhNhan()
        {
            InitializeComponent();
        }
        #region Ribbon Control
        private void barButtonItem1_ToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            function.ToExcel(result, gridControl1_TimKiemBenhNhan);
        }
        private void btn_indanhsach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1_TimKiemBenhNhan.ShowRibbonPrintPreview();
        }
        #endregion
        #region Chức năng chung
        private void gridView1_TimKiemBenhNhan_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            function.CustomDrawRowIndicator(sender, e);
        }

        private void gridView1_TimKiemBenhNhan_RowCountChanged(object sender, EventArgs e)
        {
            function.RowCountChanged(sender, e);
        }
        private void XemHoSoBenhNhan_Load(object sender, EventArgs e)
        {
            phongKhamDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'phongKhamDataSet.DonThuoc' table. You can move, or remove it, as needed.
            this.donThuocTableAdapter.Fill(this.phongKhamDataSet.DonThuoc);
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoTaiKham' table. You can move, or remove it, as needed.
            this.hoSoTaiKhamTableAdapter.Fill(this.phongKhamDataSet.HoSoTaiKham);
            // TODO: This line of code loads data into the 'phongKhamDataSet.HoSoKhamBenh' table. You can move, or remove it, as needed.
            this.hoSoKhamBenhTableAdapter.Fill(this.phongKhamDataSet.HoSoKhamBenh);
        }
        private void gridControl1_TimKiemBenhNhan_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            GridControl gridControl = sender as GridControl;
            GridView gridView = gridControl.FocusedView as GridView;
            if (gridView != null)
                MSDT = int.Parse(gridView.GetFocusedRowCellValue(gridView.Columns[0]).ToString());//chọn cột đầu tiên khi nhấn vào mũi tên
        }               
        private void gridView2_DonThuoc_DoubleClick(object sender, EventArgs e)
        {            
            DanhSachDonThuoc danhSachDonThuoc = new DanhSachDonThuoc();
            danhSachDonThuoc.ShowDialog();
        }
        #endregion
    }
}