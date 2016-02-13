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
using BusinessEntities.Report;
using BusinessRules.Report;

namespace SISPEPERS.Report
{
    public partial class xfViewSalesOrder : DevExpress.XtraEditors.XtraForm
    {
        BEReport oBe;
        public xfViewSalesOrder(int COD_SOCI_NEGO,DateTime FEC_DESD, DateTime FEC_HAST)
        {
            InitializeComponent();
            oBe = new BEReport();
            oBe.COD_SOCI_NEGO = COD_SOCI_NEGO;
            oBe.FEC_DESD = FEC_DESD;
            oBe.FEC_HAST = FEC_HAST;
        }

        private void xfViewSalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                var oBr = new BRSales();

                oBe.NUM_ACCI = 12;

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
                oBe.NUM_ACCI = 13;

                var oList02 = oBr.SVPR_REPO_LIST(oBe);

                gdcResults01.DataSource = oList02;
                gdvResults01.BestFitColumns();
                for (int i = 0; i < gdvResults01.Columns.Count; i++)
                {
                    gdvResults01.Columns[i].OptionsColumn.AllowEdit = false;
                    gdvResults01.Columns[i].OptionsColumn.AllowFocus = false;
                    gdvResults01.Columns[i].OptionsColumn.ReadOnly = true;

                    var Type = gdvResults01.Columns[i].ColumnType;

                    if (Type.Name.ToUpper().Equals("DECIMAL"))
                    {
                        gdvResults01.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gdvResults01.Columns[i].DisplayFormat.FormatString = "n2";
                        gdvResults01.Columns[i].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        gdvResults01.Columns[i].SummaryItem.DisplayFormat = "{0:#,##0.00}";
                        gdvResults01.Columns[i].Width = gdvResults01.Columns[i].Width + 20;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}