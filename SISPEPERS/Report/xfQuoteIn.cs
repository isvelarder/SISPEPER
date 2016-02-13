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
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;
using BusinessEntities.Sales;
using BusinessRules.Sales;

namespace SISPEPERS.Report
{
    public partial class xfQuoteIn : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        public xfQuoteIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfQuoteIn mSgIns;
        public static xfQuoteIn SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfQuoteIn();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void xfQuoteIn_Activated(object sender, EventArgs e)
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

        private void xfQuoteIn_Deactivate(object sender, EventArgs e)
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

        private void xfQuoteIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }

        private void xfQuoteIn_Load(object sender, EventArgs e)
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
            oSd.FileName = "CotizacioneEmitidas-" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString("00") + DateTime.Today.Day.ToString("00") + "-" + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00");
            if (oSd.ShowDialog() == DialogResult.OK)
            {
                gdcResults.ExportToXlsx(oSd.FileName);
            }
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();

                oBe.ALF_NUME_IDEN = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;
                oBe.FEC_DESD = deFEC_DESD.DateTime;
                oBe.FEC_HAST = deFEC_HAST.DateTime;
                oBe.COD_TIPO_DOCU = 1; 
                oBe.NUM_ACCI = 7;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);

                gdcResults.DataSource = oList;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}