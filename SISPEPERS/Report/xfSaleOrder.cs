using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;
using BusinessEntities.Report;
using BusinessRules.Report;

namespace SISPEPERS.Report
{
    public partial class xfSaleOrder : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        public xfSaleOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfSaleOrder mSgIns;
        public static xfSaleOrder SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfSaleOrder();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void xfSalesInvoice_Activated(object sender, EventArgs e)
        {
            //((xfMain)MdiParent).fra = this;

            //var oBeAcce = new BESVMD_ACCE();
            //var oBrAcce = new BRSVMD_ACCE();
            //oBeAcce.NUM_ACCI = 5;
            //oBeAcce.ALF_NOMB = FORM_SUBO;
            //oBeAcce.COD_PERF = SESSION_PERF;
            //var oListBotones = oBrAcce.Get_SVPR_ACCE_LIST(oBeAcce);

            //foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            //{
            //    if (oListBotones.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
            //        itemLink.Item.Visibility = BarItemVisibility.Always;
            //    else
            //        itemLink.Item.Visibility = BarItemVisibility.Never;
            //}
            //deFEC_DESD.DateTime = DateTime.Today;
            //deFEC_HAST.DateTime = DateTime.Today;
        }

        private void xfSalesInvoice_Deactivate(object sender, EventArgs e)
        {
            //var oBeAcce = new BESVMD_ACCE();
            //oBeAcce.NUM_ACCI = 5;
            //oBeAcce.ALF_NOMB = FORM_SUBO;
            //oBeAcce.COD_PERF = SESSION_PERF;
            //foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            //{
            //    itemLink.Item.Visibility = BarItemVisibility.Never;
            //}
        }

        private void xfSalesInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }

        private void xfSalesInvoice_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;
        }

        public void Export()
        {
            SaveFileDialog oSd = new SaveFileDialog();
            oSd.DefaultExt = "xlsx";
            oSd.FileName = "Registro de Ordenes de Venta-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString("00") + DateTime.Today.Day.ToString("00") + "-" + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00");
            if (oSd.ShowDialog() == DialogResult.OK)
            {
                gdcResults.ExportToXlsx(oSd.FileName);
            }
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var oBe = new BEReport();
                var oBr = new BRSales();

                oBe.COD_COMP = SESSION_COMP;
                oBe.FEC_DESD = deFEC_DESD.DateTime;
                oBe.FEC_HAST = deFEC_HAST.DateTime;
                oBe.NUM_ACCI = 1;

                var oList = oBr.Get_PSCP_SPLS_SVTC_OVEN(oBe);

                gdcResults.DataSource = oList;
                gdvResults.BestFitColumns();
                for (int i = 0; i < gdvResults.Columns.Count; i++)
                {
                    gdvResults.Columns[i].OptionsColumn.AllowEdit = false;
                    gdvResults.Columns[i].OptionsColumn.AllowFocus = false;
                    gdvResults.Columns[i].OptionsColumn.ReadOnly = true;

                    var Type = gdvResults.Columns[i].ColumnType;

                    if (Type.Name.ToUpper().Equals("DECIMAL"))
                    {
                        gdvResults.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        gdvResults.Columns[i].SummaryItem.DisplayFormat = "{0:#,##0.00}";
                        gdvResults.Columns[i].Width = gdvResults.Columns[i].Width + 20;
                    }
                }
                //gdvResults.OptionsView.ColumnAutoWidth=true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}