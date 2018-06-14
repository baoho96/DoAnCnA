namespace QuanLyPhongKham
{
    partial class reportDonThuocFormDuocSi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblSTT = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenThuoc = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSoLuong = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDonViTinh = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDonGia = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCachDung = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSDT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlb_Ho = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbTen = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbNamSinh = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbChuanDoan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBacSiKham = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGhiChuKhamBenh = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNguoiLap = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbGhiChu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgayKeDon = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSTT,
            this.lblTenThuoc,
            this.lblSoLuong,
            this.lblDonViTinh,
            this.lblDonGia,
            this.lblCachDung});
            this.Detail.HeightF = 26.04167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblSTT
            // 
            this.lblSTT.BorderColor = System.Drawing.Color.Black;
            this.lblSTT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblSTT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber([TenThuoc])")});
            this.lblSTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSTT.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSTT.SizeF = new System.Drawing.SizeF(34.375F, 22.99999F);
            this.lblSTT.StylePriority.UseBorderColor = false;
            this.lblSTT.StylePriority.UseBorders = false;
            this.lblSTT.StylePriority.UseFont = false;
            this.lblSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lblSTT.Summary = xrSummary1;
            this.lblSTT.Text = "STT";
            this.lblSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblSTT.TextFormatString = "{0}.";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblTenThuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTenThuoc.LocationFloat = new DevExpress.Utils.PointFloat(34.375F, 0F);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenThuoc.SizeF = new System.Drawing.SizeF(135.9374F, 23F);
            this.lblTenThuoc.StylePriority.UseBorders = false;
            this.lblTenThuoc.StylePriority.UseFont = false;
            this.lblTenThuoc.StylePriority.UseTextAlignment = false;
            this.lblTenThuoc.Text = "Tên Thuốc";
            this.lblTenThuoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSoLuong.LocationFloat = new DevExpress.Utils.PointFloat(170.3124F, 0F);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSoLuong.SizeF = new System.Drawing.SizeF(68.74994F, 23F);
            this.lblSoLuong.StylePriority.UseBorders = false;
            this.lblSoLuong.StylePriority.UseFont = false;
            this.lblSoLuong.StylePriority.UseTextAlignment = false;
            this.lblSoLuong.Text = "Số Lượng";
            this.lblSoLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblDonViTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDonViTinh.LocationFloat = new DevExpress.Utils.PointFloat(239.0624F, 0F);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDonViTinh.SizeF = new System.Drawing.SizeF(80.20836F, 23F);
            this.lblDonViTinh.StylePriority.UseBorders = false;
            this.lblDonViTinh.StylePriority.UseFont = false;
            this.lblDonViTinh.StylePriority.UseTextAlignment = false;
            this.lblDonViTinh.Text = "Đơn vị tính";
            this.lblDonViTinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDonGia.LocationFloat = new DevExpress.Utils.PointFloat(319.2708F, 0F);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDonGia.SizeF = new System.Drawing.SizeF(95.83334F, 23F);
            this.lblDonGia.StylePriority.UseBorders = false;
            this.lblDonGia.StylePriority.UseFont = false;
            this.lblDonGia.StylePriority.UseTextAlignment = false;
            this.lblDonGia.Text = "Đơn Giá";
            this.lblDonGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblCachDung
            // 
            this.lblCachDung.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblCachDung.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblCachDung.LocationFloat = new DevExpress.Utils.PointFloat(415.1042F, 0F);
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCachDung.SizeF = new System.Drawing.SizeF(234.3749F, 23F);
            this.lblCachDung.StylePriority.UseBorders = false;
            this.lblCachDung.StylePriority.UseFont = false;
            this.lblCachDung.StylePriority.UseTextAlignment = false;
            this.lblCachDung.Text = "Cách Dùng";
            this.lblCachDung.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 1F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.lblSDT,
            this.xrLabel3,
            this.xrLabel17,
            this.xrLabel1,
            this.xrLabel4,
            this.xlb_Ho,
            this.xlbTen,
            this.xlbNamSinh,
            this.xrLabel9,
            this.xlabel7,
            this.xlbChuanDoan,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel7});
            this.ReportHeader.HeightF = 244.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(465.1043F, 114.9583F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(78.75F, 35.41673F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "SĐT người thân";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblSDT
            // 
            this.lblSDT.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblSDT.LocationFloat = new DevExpress.Utils.PointFloat(543.8542F, 114.9583F);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSDT.SizeF = new System.Drawing.SizeF(105.6249F, 23F);
            this.lblSDT.StylePriority.UseBorders = false;
            this.lblSDT.StylePriority.UseTextAlignment = false;
            this.lblSDT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(206.2501F, 65.33336F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(219.7917F, 36.91667F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Đơn Thuốc";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BorderColor = System.Drawing.Color.Black;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0.5207539F, 220.4583F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(33.33333F, 22.99999F);
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "STT";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0.520911F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(137.5F, 47.99999F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Phòng khám bệnh nhi Bảo Tiến";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(3.645913F, 119.125F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(64.5833F, 18.83334F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Họ & tên";
            // 
            // xlb_Ho
            // 
            this.xlb_Ho.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xlb_Ho.LocationFloat = new DevExpress.Utils.PointFloat(68.22922F, 114.9583F);
            this.xlb_Ho.Name = "xlb_Ho";
            this.xlb_Ho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlb_Ho.SizeF = new System.Drawing.SizeF(159.3751F, 23F);
            this.xlb_Ho.StylePriority.UseBorders = false;
            this.xlb_Ho.StylePriority.UseTextAlignment = false;
            this.xlb_Ho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xlbTen
            // 
            this.xlbTen.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xlbTen.LocationFloat = new DevExpress.Utils.PointFloat(227.6043F, 114.9583F);
            this.xlbTen.Name = "xlbTen";
            this.xlbTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbTen.SizeF = new System.Drawing.SizeF(62.49995F, 23F);
            this.xlbTen.StylePriority.UseBorders = false;
            this.xlbTen.StylePriority.UseTextAlignment = false;
            this.xlbTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xlbNamSinh
            // 
            this.xlbNamSinh.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xlbNamSinh.LocationFloat = new DevExpress.Utils.PointFloat(371.9794F, 114.9583F);
            this.xlbNamSinh.Name = "xlbNamSinh";
            this.xlbNamSinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbNamSinh.SizeF = new System.Drawing.SizeF(84.375F, 23F);
            this.xlbNamSinh.StylePriority.UseBorders = false;
            this.xlbNamSinh.StylePriority.UseTextAlignment = false;
            this.xlbNamSinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(306.3544F, 119.125F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(65.625F, 18.83333F);
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Năm Sinh";
            // 
            // xlabel7
            // 
            this.xlabel7.BorderColor = System.Drawing.Color.Black;
            this.xlabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xlabel7.LocationFloat = new DevExpress.Utils.PointFloat(3.645913F, 162.875F);
            this.xlabel7.Name = "xlabel7";
            this.xlabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlabel7.SizeF = new System.Drawing.SizeF(80.20834F, 18.83333F);
            this.xlabel7.StylePriority.UseBorderColor = false;
            this.xlabel7.StylePriority.UseFont = false;
            this.xlabel7.Text = "Chẩn đoán";
            // 
            // xlbChuanDoan
            // 
            this.xlbChuanDoan.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xlbChuanDoan.LocationFloat = new DevExpress.Utils.PointFloat(85.52094F, 162.875F);
            this.xlbChuanDoan.Name = "xlbChuanDoan";
            this.xlbChuanDoan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbChuanDoan.SizeF = new System.Drawing.SizeF(261.8748F, 32.37498F);
            this.xlbChuanDoan.StylePriority.UseBorders = false;
            this.xlbChuanDoan.StylePriority.UseTextAlignment = false;
            this.xlbChuanDoan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(415.1043F, 220.4583F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(234.3749F, 23F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Cách Dùng";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(319.2708F, 220.4583F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(95.83334F, 23F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Đơn Giá";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(239.0624F, 220.4583F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(80.20836F, 23F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Đơn vị tính";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(170.3124F, 220.4583F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(68.75F, 23F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Số Lượng";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(33.85407F, 220.4583F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(136.4583F, 23F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Tên Thuốc";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel26,
            this.lblBacSiKham,
            this.lblGhiChuKhamBenh,
            this.xrLabel29,
            this.lblNguoiLap,
            this.xrLabel15,
            this.lbGhiChu,
            this.xrLabel16,
            this.xrLabel14,
            this.lbNgayKeDon});
            this.ReportFooter.HeightF = 214.375F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BorderColor = System.Drawing.Color.Black;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(267.8125F, 97.54175F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(115.625F, 18.83333F);
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Bác Sĩ khám";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblBacSiKham
            // 
            this.lblBacSiKham.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblBacSiKham.LocationFloat = new DevExpress.Utils.PointFloat(223.4373F, 182F);
            this.lblBacSiKham.Name = "lblBacSiKham";
            this.lblBacSiKham.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBacSiKham.SizeF = new System.Drawing.SizeF(206.875F, 23F);
            this.lblBacSiKham.StylePriority.UseBorders = false;
            this.lblBacSiKham.StylePriority.UseTextAlignment = false;
            this.lblBacSiKham.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblGhiChuKhamBenh
            // 
            this.lblGhiChuKhamBenh.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblGhiChuKhamBenh.LocationFloat = new DevExpress.Utils.PointFloat(428.6455F, 0F);
            this.lblGhiChuKhamBenh.Name = "lblGhiChuKhamBenh";
            this.lblGhiChuKhamBenh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGhiChuKhamBenh.SizeF = new System.Drawing.SizeF(216.667F, 40.70829F);
            this.lblGhiChuKhamBenh.StylePriority.UseBorders = false;
            this.lblGhiChuKhamBenh.StylePriority.UseTextAlignment = false;
            this.lblGhiChuKhamBenh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(345.9375F, 0F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(75.93762F, 40.70829F);
            this.xrLabel29.StylePriority.UseBorderColor = false;
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "Ghi chú Khám bệnh";
            // 
            // lblNguoiLap
            // 
            this.lblNguoiLap.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblNguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(448.4375F, 182F);
            this.lblNguoiLap.Name = "lblNguoiLap";
            this.lblNguoiLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNguoiLap.SizeF = new System.Drawing.SizeF(196.875F, 23F);
            this.lblNguoiLap.StylePriority.UseBorders = false;
            this.lblNguoiLap.StylePriority.UseTextAlignment = false;
            this.lblNguoiLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BorderColor = System.Drawing.Color.Black;
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(345.9375F, 50.75003F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(81.25F, 18.83333F);
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Ngày Khám";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbGhiChu.LocationFloat = new DevExpress.Utils.PointFloat(97.39573F, 0F);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbGhiChu.SizeF = new System.Drawing.SizeF(216.667F, 40.70829F);
            this.lbGhiChu.StylePriority.UseBorders = false;
            this.lbGhiChu.StylePriority.UseTextAlignment = false;
            this.lbGhiChu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(465.1043F, 97.54175F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(147.9168F, 18.83333F);
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Chữ kí người giao thuốc";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BorderColor = System.Drawing.Color.Black;
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(5.312636F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(64.99999F, 40.70829F);
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Ghi chú Đơn thuốc";
            // 
            // lbNgayKeDon
            // 
            this.lbNgayKeDon.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbNgayKeDon.LocationFloat = new DevExpress.Utils.PointFloat(460.9376F, 50.75003F);
            this.lbNgayKeDon.Name = "lbNgayKeDon";
            this.lbNgayKeDon.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayKeDon.SizeF = new System.Drawing.SizeF(137.5002F, 23F);
            this.lbNgayKeDon.StylePriority.UseBorders = false;
            this.lbNgayKeDon.StylePriority.UseTextAlignment = false;
            this.lbNgayKeDon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // reportDonThuocFormDuocSi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(33, 167, 0, 1);
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblSTT;
        private DevExpress.XtraReports.UI.XRLabel lblTenThuoc;
        private DevExpress.XtraReports.UI.XRLabel lblSoLuong;
        private DevExpress.XtraReports.UI.XRLabel lblDonViTinh;
        private DevExpress.XtraReports.UI.XRLabel lblDonGia;
        private DevExpress.XtraReports.UI.XRLabel lblCachDung;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel lblBacSiKham;
        private DevExpress.XtraReports.UI.XRLabel lblGhiChuKhamBenh;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel lblNguoiLap;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel lbGhiChu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel lbNgayKeDon;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lblSDT;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xlb_Ho;
        private DevExpress.XtraReports.UI.XRLabel xlbTen;
        private DevExpress.XtraReports.UI.XRLabel xlbNamSinh;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xlabel7;
        private DevExpress.XtraReports.UI.XRLabel xlbChuanDoan;
    }
}
