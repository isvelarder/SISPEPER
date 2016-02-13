using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using BusinessEntities.Security;
using BusinessRules.Security;
using DevExpress.XtraBars;
using System.Windows.Forms;
using BusinessRules.Report;
using BusinessEntities.Report;
using BusinessEntities.Warehouse;
using System.Drawing;
using BusinessRules.Warehouse;

namespace SISPEPERS.Report
{
    public partial class xfStockValued : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }
        public xfStockValued()
        {
            InitializeComponent();
        }
        private static xfStockValued mSgIns;
        public static xfStockValued SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfStockValued();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void xfStockValued_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var obral = new BRWarehouse();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);
            ccbCOD_ALMA.Properties.DataSource = olsal;
            ccbCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            ccbCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            Get_Search();
        }
        private void xfStockValued_Activated(object sender, EventArgs e)
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

        private void xfStockValued_Deactivate(object sender, EventArgs e)
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
        private void xfStockValued_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        private void Get_Search()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                var obj = new BEStockValued() 
                { 
                    COD_COMP = SESSION_COMP, 
                    COD_ALMA = (ccbCOD_ALMA.Properties.GetCheckedItems() == null) ? null : ccbCOD_ALMA.Properties.GetCheckedItems().ToString() 
                };

                if (string.IsNullOrWhiteSpace(obj.COD_ALMA)) obj.COD_ALMA = null;

                var obr = new BRStockInventory();
                var olst = obr.Get_PSCP_SPLS_SVMD_ALMA_INVE_VALO(obj);
                gdcReport.DataSource = olst;
                gdvReport.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    msgIcon);
            }
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Get_Search();
        }

        private void gdvKardex_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "NUM_COST_VALO")
            {
                e.Appearance.ForeColor = Color.DarkGreen;
            }
            else if (e.Column.FieldName == "NUM_VENT_VALO")
            {
                e.Appearance.ForeColor = Color.Navy;
            }
        }
        public void Set_Export()
        {
            try
            {
                var olst = (List<BEStockValued>)gdvReport.DataSource;
                if (olst.Count == 0) return;
                using (var oExp = new SaveFileDialog
                {
                    Title = WhMessage.MsgSelFile,
                    Filter = WhMessage.MsgFilExport,
                    ValidateNames = true
                })
                {
                    if (oExp.ShowDialog() != DialogResult.OK)
                        return;
                    gdvReport.ExportToXlsx(oExp.FileName);
                    if (XtraMessageBox.Show(WhMessage.MsgConExport, WhMessage.MsgInsCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(oExp.FileName);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}