using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;

namespace QuanLyPhongKham
{
    class function
    {
        public static void Notice(string noidung, int type)
        {
            switch (type)
            {
                case 0:
                    MessageBox.Show(noidung, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show(noidung, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
            }
        }
        public static Boolean checkNull(Control form)
        {
            try
            {
                foreach (Control a in form.Controls)
                {
                    if (a is TextBox)
                    {
                        TextBox textBox = (TextBox)a;
                        if (textBox.Text == "")
                        {
                            Notice("Bạn phải nhập vào ô nhập còn trống", 0);                            
                            return false;
                        }         
                    }                    
                    if (a is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)a;
                        if (comboBox.Text=="")
                        {
                            Notice("Bạn phải nhập vào ô lựa chọn còn trống", 0); return false;
                        }                                            
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }

        public static Boolean checkrong(Control form)
        {
            try
            {
                foreach (Control a in form.Controls)
                {
                    if (a is TextBox)
                    {
                        TextBox textBox = (TextBox)a;
                        if (textBox.Text == "")
                        {
                            
                            return false;
                        }
                    }

                    if (a is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)a;
                        if (comboBox.Text == "")
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public static string toMD5(string matkhau)
        {
            MD5CryptoServiceProvider myMD5 = new MD5CryptoServiceProvider();
            byte[] myPass = System.Text.Encoding.UTF8.GetBytes(matkhau);
            myPass = myMD5.ComputeHash(myPass);

            StringBuilder s = new StringBuilder();
            foreach (byte p in myPass)
            {
                s.Append(p.ToString("x").ToLower());
            }
            return s.ToString();
        }
        public static void ClearControl(Control form)//hàm clear tất cả
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0;
                        comboBox.Text = "";
                        comboBox.Items.Clear();
                    }
                }
                
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }
                if (control is RadioButton)
                {
                    RadioButton rdbtn = (RadioButton)control;
                    rdbtn.Checked = false;
                }
                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is ListView)
                {
                    ListView listview = (ListView)control;
                    listview.Items.Clear();
                }
                if(control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image=null;
                }
            }
        }

        //vẽ cột số thứ tự cho gridview
        bool indicatorIcon = true;
        public void CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 10;
        }

        public void KoNhapKiTu(object sender,KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!Char.IsLetterOrDigit(e.KeyChar))
                {
                    if (e.KeyChar == '\b')//loại nút Backspace ra
                    { }
                    else { e.Handled = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToExcel(string noidung,DialogResult result,GridControl gridControl)
        {
            if (MessageBox.Show(noidung, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = "D:";
                save.Filter = "Select File |*.xlsx||*.docx";
                
                result = save.ShowDialog();
                string link = save.FileName;
                save.RestoreDirectory = true;
                if (result == DialogResult.OK)
                {
                    if (save.FilterIndex == 1)
                        gridControl.ExportToXlsx(link);
                    if (save.FilterIndex == 2)
                        gridControl.ExportToDocx(link);
                }
            }
        }
        public void Timer_load(EventHandler eventHandler)
        {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); //30s
            timer.Tick += new EventHandler(eventHandler);
            timer.Start();
        }
        public void FilterText(GridView gridView)
        {
            if (!string.IsNullOrEmpty(gridView.FindFilterText) && !gridView.FindFilterText.Contains('"'))
                gridView.FindFilterText = "\"" + gridView.FindFilterText + "\"";
        }
        public void ClearFilterText(GridView gridView)
        {
            gridView.FindFilterText = "";
        }
    }
}
