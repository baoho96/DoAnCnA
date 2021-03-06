﻿using System;
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
using DevExpress.XtraBars;

namespace QuanLyPhongKham
{
    public partial class ThemLoaiThuoc : DevExpress.XtraEditors.XtraForm
    {
        #region Khởi tạo
        connection connection = new connection();
        function function = new function();
        SqlCommand cmd;
        #endregion
        public ThemLoaiThuoc()
        {
            InitializeComponent();
        }
        private void ThemLoaiThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongKhamDataSet.LoaiThuoc' table. You can move, or remove it, as needed.
            this.loaiThuocTableAdapter.Fill(this.phongKhamDataSet.LoaiThuoc);
        }
        
        private void ThemLoaiThuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is Admin)
                {
                    ((Admin)fm).refresh_ComboBoxLoaiThuoc();
                    break;
                }
            }
        }
        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            if(function.checkNull(panelControl1) !=false)
            {
                connection.connect();
                string checktenloaithuoc = @"select top 1 tenloaithuoc from loaithuoc where tenloaithuoc = N'" + txt_tenloaithuoc.Text + "'";
                cmd = new SqlCommand(checktenloaithuoc, connection.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    function.Notice("Bạn nhập trùng tên loại thuốc", 0);
                }
                else
                {
                    dr.Close();
                    if (txt_tenloaithuoc.Text == "")
                    {
                        function.Notice("Bạn phải nhập Tên loại thuốc", 0);
                    }
                    else
                    {
                        string query = @" insert into loaithuoc(tenloaithuoc,ghichu) values (N'" + txt_tenloaithuoc.Text + "',N'" + txt_ghichu.Text + "')";
                        connection.insert(query);
                    }
                    connection.disconnect();
                    function.ClearControl(panelControl1);
                    this.loaiThuocTableAdapter.Fill(this.phongKhamDataSet.LoaiThuoc);
                    btn_capnhat.Enabled = false;
                    btn_xoa.Enabled = false;
                }
            }                     
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (function.checkNull(panelControl1) != false)
            {
                string ID = gridView1.GetFocusedRowCellValue("MaSoLoaiThuoc").ToString();
                connection.connect();
                string query = @"update Loaithuoc set tenloaithuoc = N'" + txt_tenloaithuoc.Text + "', ghichu = N'" + txt_ghichu.Text + "' where masoloaithuoc =" + ID;
                connection.sql(query);
                connection.disconnect();
                function.ClearControl(panelControl1);
                this.loaiThuocTableAdapter.Fill(this.phongKhamDataSet.LoaiThuoc);
            }
        }
  
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ID = gridView1.GetFocusedRowCellValue("MaSoLoaiThuoc").ToString();
            connection.connect();

            string query = @"delete from loaithuoc where masoloaithuoc=" + ID + "; update Thuoc set Masoloaithuoc = 0 where Masoloaithuoc = "+ID;
            connection.delete(query);
            connection.disconnect();
            function.ClearControl(panelControl1);
            this.loaiThuocTableAdapter.Fill(this.phongKhamDataSet.LoaiThuoc);
        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            btn_capnhat.Enabled = true;
            btn_xoa.Enabled = true;
            string ID = gridView1.GetFocusedRowCellValue("MaSoLoaiThuoc").ToString();
            txt_tenloaithuoc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenLoaiThuoc"]).ToString();
            txt_ghichu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["GhiChu"]).ToString();                    
        }

        
    }
}