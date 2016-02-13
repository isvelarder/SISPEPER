using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using BusinessRules.Report;
using System.Windows.Forms;
using BusinessEntities.Security;
using BusinessEntities.Report;
using BusinessEntities.Warehouse;
using BusinessRules.Security;
using DevExpress.XtraBars;

namespace SISPEPERS.Report
{
    public partial class xfStockInventory : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        public List<BECloneStockInventoy> ostin { get; set; }
        public xfStockInventory()
        {
            InitializeComponent();

            ostin = new List<BECloneStockInventoy>();
        }
        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfStockInventory mSgIns;
        public static xfStockInventory SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfStockInventory();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void Get_Refresh()
        {
            var obr = new BRStockInventory();
            ostin = obr.Get_PSGN_SPLS_SVMD_ALMA_INVE(SESSION_COMP);
            var alma = ostin.Select(item => item.ALF_ALMA).Distinct().ToList();
            alma.ForEach(item =>
            {
                ostin.Where(obj => string.IsNullOrWhiteSpace(obj.ALF_ALMA))
                    .ToList()
                    .ForEach(row => { row.ALF_ALMA = item; });
            });

            pgcStock.DataSource = ostin;
            pgcStock.BestFit();
        }
        private void Get_Search()
        {
            var olst = new List<BECloneStockInventoy>();
            if (cbeParameter.SelectedIndex == 0)
                olst = ostin.Where(item => item.ALF_ARTI.ToUpper().Contains(txtValue.Text.ToUpper())).Select(item => item.Clone() as BECloneStockInventoy).ToList();
            else if (cbeParameter.SelectedIndex == 1)
                olst = ostin.Where(item => item.ALF_CODI_ARTI.ToUpper().Contains(txtValue.Text.ToUpper())).Select(item => item.Clone() as BECloneStockInventoy).ToList();
            else
                olst = ostin.Where(item => item.ALF_ALMA.ToUpper().Contains(txtValue.Text.ToUpper())).Select(item => item.Clone() as BECloneStockInventoy).ToList();

            pgcStock.DataSource = olst;
            pgcStock.BestFit();
        }
        private void Get_Load()
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            Get_Refresh();
        }
        private void xfStockInventory_Load(object sender, EventArgs e)
        {
            Get_Load();
        }

        private void xfStockInventory_Activated(object sender, EventArgs e)
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
            Get_Load();
        }

        private void xfStockInventory_Deactivate(object sender, EventArgs e)
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
        private void xfStockInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        public void Set_Export()
        {
            try
            {
                var olst = (List<BECloneStockInventoy>)pgcStock.DataSource;
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
                    pgcStock.ExportToXlsx(oExp.FileName);
                    if (XtraMessageBox.Show(WhMessage.MsgOpenFile, WhMessage.MsgInsCaption,
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

        private void sbtRefresh_Click(object sender, EventArgs e)
        {
            Get_Refresh();
        }

        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Get_Search();
        }

        private void cbeParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Focus();
            txtValue.SelectAll();
        }

        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Get_Search();
        }
    }
}