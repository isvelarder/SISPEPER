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
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;
using BusinessEntities.Sales;
using BusinessRules.Sales;
using BusinessEntities.Report;
using BusinessRules.Report;
using DevExpress.XtraGrid.Views.Grid;

namespace SISPEPERS.Report
{
    public partial class xfCustomerSales : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        public xfCustomerSales()
        {
            InitializeComponent();
        }
        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfCustomerSales mSgIns;
        public static xfCustomerSales SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfCustomerSales();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void xfCustomerSales_Activated(object sender, EventArgs e)
        {
            ((xfMain)MdiParent).fra = this;

            var oBeAcce = new BESVMD_ACCE();
            var oBrAcce = new BRSVMD_ACCE();
            oBeAcce.NUM_ACCI = 5;
            oBeAcce.ALF_NOMB = FORM_SUBO;
            oBeAcce.COD_PERF = SESSION_PERF;
            var oListBotones = oBrAcce.Get_SVPR_ACCE_LIST(oBeAcce);

            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            {
                if (oListBotones.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                    itemLink.Item.Visibility = BarItemVisibility.Always;
                else
                    itemLink.Item.Visibility = BarItemVisibility.Never;
            }
        }

        private void xfCustomerSales_Deactivate(object sender, EventArgs e)
        {
            var oBeAcce = new BESVMD_ACCE();
            oBeAcce.NUM_ACCI = 5;
            oBeAcce.ALF_NOMB = FORM_SUBO;
            oBeAcce.COD_PERF = SESSION_PERF;
            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            {
                itemLink.Item.Visibility = BarItemVisibility.Never;
            }
        }

        private void xfCustomerSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }

        private void xfCustomerSales_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            deFEC_DESD.DateTime = DateTime.Today;
            deFEC_HAST.DateTime = DateTime.Today;
        }

        public void Export()
        {
            SaveFileDialog oSd = new SaveFileDialog();
            oSd.DefaultExt = "xlsx";
            oSd.FileName = "Ventas por cliente-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString("00") + DateTime.Today.Day.ToString("00") + "-" + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00");
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
                oBe.NUM_ACCI = 5;

                var oList = oBr.SVPR_REPO_LIST(oBe);

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
                        gdvResults.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gdvResults.Columns[i].DisplayFormat.FormatString = "n2";
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

        private void gdvResults_DoubleClick(object sender, EventArgs e)
        {
            var Grid = (GridView)sender;
            if (Grid.FocusedRowHandle >= 0)
            {
                if (Grid.RowCount > 0)
                {
                    var row = (DataRowView)Grid.GetRow(Grid.FocusedRowHandle);
                    var COD_SOCI_NEGO = row[1];
                    using (var oForm = new xfViewSalesOrder(Convert.ToInt32(COD_SOCI_NEGO),deFEC_DESD.DateTime,deFEC_HAST.DateTime))
                    {
                        oForm.ShowDialog();
                    }
                }
            }
        }
    }
}