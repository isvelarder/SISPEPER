using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Purchase;
using BusinessRules.Report;
using BusinessEntities.Warehouse;
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;

namespace SISPEPERS.Report
{
    public partial class xfPurchase3 : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }
        public xfPurchase3()
        {
            InitializeComponent();
        }
        private static xfPurchase3 mSgIns;
        public static xfPurchase3 SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfPurchase3();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void Get_Search()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dteFEC_DESD.Text))
                    throw new ArgumentException("Fecha inicial incorrecta.");
                if (string.IsNullOrWhiteSpace(dteFEC_HAST.Text))
                    throw new ArgumentException("Fecha final incorrecta");
                if (DateTime.Compare(dteFEC_DESD.DateTime, dteFEC_HAST.DateTime) > 0)
                    throw new ArgumentException("Rango de fechas incorrecto.");

                var obj = new BEDocument() { FEC_REGI_INIC = dteFEC_DESD.DateTime, FEC_REGI_FINA = dteFEC_HAST.DateTime, COD_SUCU = SESSION_COMP };

                var obr = new BRReportPurchase();
                var olst = obr.Get_PPRP_SPLS_COM3(obj);

                gdcReport.DataSource = olst;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, _Message.MsgInsCaption, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Get_Search();
        }
        public void Set_Export()
        {
            try
            {
                var olst = (List<BEDocument>)gdvReport.DataSource;
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

        private void dteFEC_DESD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Get_Search();
        }

        private void xfPurchase1_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;
        }
        private void xfPurchase1_Activated(object sender, EventArgs e)
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

        private void xfPurchase1_Deactivate(object sender, EventArgs e)
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
        private void xfPurchase1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
    }
}