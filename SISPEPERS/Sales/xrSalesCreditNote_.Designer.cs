namespace SISPEPERS.Sales
{
    partial class xrSalesCreditNote_
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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblPrecioUnit = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblImporte = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblRuc = new DevExpress.XtraReports.UI.XRLabel();
            this.bdsHead = new System.Windows.Forms.BindingSource(this.components);
            this.lblDireccion = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAnio = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMes = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDia = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblMontoLetras = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDiaCan = new DevExpress.XtraReports.UI.XRLabel();
            this.lblMesCan = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAnioCan = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIGV = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSubTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.bdsDetail = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 63.5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 254F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1861F, 63.5F);
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.lblPrecioUnit,
            this.lblImporte});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NUM_CANT")});
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 0, 254F);
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.37357147553221692D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ALF_ARTI")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 0, 254F);
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.Weight = 1.9081638808709849D;
            // 
            // lblPrecioUnit
            // 
            this.lblPrecioUnit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NUM_PREC_UNIT")});
            this.lblPrecioUnit.Dpi = 254F;
            this.lblPrecioUnit.Name = "lblPrecioUnit";
            this.lblPrecioUnit.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 0, 254F);
            this.lblPrecioUnit.StylePriority.UsePadding = false;
            this.lblPrecioUnit.StylePriority.UseTextAlignment = false;
            this.lblPrecioUnit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblPrecioUnit.Weight = 0.47728037480322089D;
            // 
            // lblImporte
            // 
            this.lblImporte.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "NUM_IMPO")});
            this.lblImporte.Dpi = 254F;
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 5, 0, 0, 254F);
            this.lblImporte.StylePriority.UsePadding = false;
            this.lblImporte.StylePriority.UseTextAlignment = false;
            this.lblImporte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblImporte.Weight = 0.4370992496507124D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 460F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 249F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblRuc,
            this.lblDireccion,
            this.lblCliente,
            this.lblAnio,
            this.lblMes,
            this.lblDia});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 468.3125F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblRuc
            // 
            this.lblRuc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "ALF_NUME_IDENT")});
            this.lblRuc.Dpi = 254F;
            this.lblRuc.LocationFloat = new DevExpress.Utils.PointFloat(204.3334F, 282.2917F);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblRuc.SizeF = new System.Drawing.SizeF(949.8541F, 58.41995F);
            this.lblRuc.StylePriority.UseTextAlignment = false;
            this.lblRuc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // bdsHead
            // 
            this.bdsHead.DataSource = typeof(BusinessEntities.Sales.BESVTC_COTI);
            // 
            // lblDireccion
            // 
            this.lblDireccion.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "ALF_DIRE")});
            this.lblDireccion.Dpi = 254F;
            this.lblDireccion.LocationFloat = new DevExpress.Utils.PointFloat(204.3334F, 208.2708F);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblDireccion.SizeF = new System.Drawing.SizeF(949.8542F, 58.42001F);
            this.lblDireccion.StylePriority.UseTextAlignment = false;
            this.lblDireccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            this.lblCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "ALF_NOMB")});
            this.lblCliente.Dpi = 254F;
            this.lblCliente.LocationFloat = new DevExpress.Utils.PointFloat(204.3333F, 136.8958F);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCliente.SizeF = new System.Drawing.SizeF(949.8541F, 58.42F);
            this.lblCliente.StylePriority.UseTextAlignment = false;
            this.lblCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblAnio
            // 
            this.lblAnio.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:yy}")});
            this.lblAnio.Dpi = 254F;
            this.lblAnio.LocationFloat = new DevExpress.Utils.PointFloat(909F, 46.00005F);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAnio.SizeF = new System.Drawing.SizeF(124.3542F, 58.42F);
            this.lblAnio.StylePriority.UseTextAlignment = false;
            this.lblAnio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblMes
            // 
            this.lblMes.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:MMMM}")});
            this.lblMes.Dpi = 254F;
            this.lblMes.LocationFloat = new DevExpress.Utils.PointFloat(441.8542F, 46.00005F);
            this.lblMes.Name = "lblMes";
            this.lblMes.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblMes.SizeF = new System.Drawing.SizeF(370.4165F, 58.42F);
            this.lblMes.StylePriority.UseTextAlignment = false;
            this.lblMes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblDia
            // 
            this.lblDia.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:dd}")});
            this.lblDia.Dpi = 254F;
            this.lblDia.LocationFloat = new DevExpress.Utils.PointFloat(169.3333F, 46.00001F);
            this.lblDia.Name = "lblDia";
            this.lblDia.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblDia.SizeF = new System.Drawing.SizeF(179.9166F, 58.42F);
            this.lblDia.StylePriority.UseTextAlignment = false;
            this.lblDia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblMontoLetras,
            this.lblDiaCan,
            this.lblMesCan,
            this.lblAnioCan,
            this.lblTotal,
            this.lblIGV,
            this.lblSubTotal});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 324.7183F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lblMontoLetras
            // 
            this.lblMontoLetras.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "ALF_TOTA")});
            this.lblMontoLetras.Dpi = 254F;
            this.lblMontoLetras.LocationFloat = new DevExpress.Utils.PointFloat(97.92684F, 0F);
            this.lblMontoLetras.Name = "lblMontoLetras";
            this.lblMontoLetras.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblMontoLetras.SizeF = new System.Drawing.SizeF(1444.625F, 58.42F);
            this.lblMontoLetras.StylePriority.UseTextAlignment = false;
            this.lblMontoLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblDiaCan
            // 
            this.lblDiaCan.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:dd}")});
            this.lblDiaCan.Dpi = 254F;
            this.lblDiaCan.LocationFloat = new DevExpress.Utils.PointFloat(544.8437F, 220.9406F);
            this.lblDiaCan.Name = "lblDiaCan";
            this.lblDiaCan.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblDiaCan.SizeF = new System.Drawing.SizeF(179.9166F, 58.42F);
            this.lblDiaCan.StylePriority.UseTextAlignment = false;
            this.lblDiaCan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblMesCan
            // 
            this.lblMesCan.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:MMMM}")});
            this.lblMesCan.Dpi = 254F;
            this.lblMesCan.LocationFloat = new DevExpress.Utils.PointFloat(817.3645F, 220.9406F);
            this.lblMesCan.Name = "lblMesCan";
            this.lblMesCan.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblMesCan.SizeF = new System.Drawing.SizeF(336.8231F, 58.42001F);
            this.lblMesCan.StylePriority.UseTextAlignment = false;
            this.lblMesCan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblAnioCan
            // 
            this.lblAnioCan.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "FEC_DOCU", "{0:yy}")});
            this.lblAnioCan.Dpi = 254F;
            this.lblAnioCan.LocationFloat = new DevExpress.Utils.PointFloat(1204.51F, 220.9407F);
            this.lblAnioCan.Name = "lblAnioCan";
            this.lblAnioCan.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAnioCan.SizeF = new System.Drawing.SizeF(124.3542F, 58.42F);
            this.lblAnioCan.StylePriority.UseTextAlignment = false;
            this.lblAnioCan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "NUM_TOTA")});
            this.lblTotal.Dpi = 254F;
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(1606.491F, 233.3607F);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(254.5094F, 91.35751F);
            this.lblTotal.StylePriority.UseTextAlignment = false;
            this.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // lblIGV
            // 
            this.lblIGV.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "NUM_IGVV")});
            this.lblIGV.Dpi = 254F;
            this.lblIGV.LocationFloat = new DevExpress.Utils.PointFloat(1606.49F, 142.0033F);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIGV.SizeF = new System.Drawing.SizeF(254.5095F, 91.35747F);
            this.lblIGV.StylePriority.UseTextAlignment = false;
            this.lblIGV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.bdsHead, "NUM_SUBT")});
            this.lblSubTotal.Dpi = 254F;
            this.lblSubTotal.LocationFloat = new DevExpress.Utils.PointFloat(1606.491F, 31.99997F);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblSubTotal.SizeF = new System.Drawing.SizeF(254.5094F, 94.00331F);
            this.lblSubTotal.StylePriority.UseTextAlignment = false;
            this.lblSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // bdsDetail
            // 
            this.bdsDetail.DataSource = typeof(BusinessEntities.Sales.BESVTD_COTI);
            // 
            // xrSalesCreditNote
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.DataSource = this.bdsDetail;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(196, 43, 460, 249);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ShowPrintMarginsWarning = false;
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        public System.Windows.Forms.BindingSource bdsHead;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lblRuc;
        private DevExpress.XtraReports.UI.XRLabel lblDireccion;
        private DevExpress.XtraReports.UI.XRLabel lblCliente;
        private DevExpress.XtraReports.UI.XRLabel lblAnio;
        private DevExpress.XtraReports.UI.XRLabel lblDia;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRLabel lblMes;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lblDiaCan;
        private DevExpress.XtraReports.UI.XRLabel lblMesCan;
        private DevExpress.XtraReports.UI.XRLabel lblAnioCan;
        private DevExpress.XtraReports.UI.XRLabel lblMontoLetras;
        public System.Windows.Forms.BindingSource bdsDetail;
        public DevExpress.XtraReports.UI.XRTableCell lblPrecioUnit;
        public DevExpress.XtraReports.UI.XRTableCell lblImporte;
        public DevExpress.XtraReports.UI.XRLabel lblSubTotal;
        public DevExpress.XtraReports.UI.XRLabel lblTotal;
        public DevExpress.XtraReports.UI.XRLabel lblIGV;
    }
}
