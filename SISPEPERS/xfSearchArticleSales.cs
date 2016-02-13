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
using BusinessEntities.Management;
using BusinessRules.Management;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;

namespace SISPEPERS
{
    public partial class xfSearchArticleSales : DevExpress.XtraEditors.XtraForm
    {
        public BESVMC_ARTI oBe;
        private int SESSION_COMP;

        public xfSearchArticleSales(int COMP)
        {
            InitializeComponent();
            oBe = new BESVMC_ARTI();
            SESSION_COMP = COMP;
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            var oBeS = new BESVMC_ARTI();
            var oBrS = new BRSVMC_ARTI();

            oBeS.ALF_ARTI = txtALF_REFE.Text;
            oBeS.ALF_CODI_ARTI = txtALF_CODI.Text;
            oBeS.COD_COMP = SESSION_COMP;
            oBeS.NUM_ACCI = 6;

            var oList = oBrS.Get_SVPR_ARTI_LIST(oBeS);

            gdcResults.DataSource = oList;
        }

        private void Accept()
        {
            try
            {
                if (gdvResults.RowCount <= 0)
                    throw new ArgumentException("No existen registros en la lista");

                if (gdvResults.FocusedRowHandle >= 0)
                {
                    oBe = (BESVMC_ARTI)gdvResults.GetRow(gdvResults.FocusedRowHandle);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cancel();
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Accept();
        }

        private void gdvResults_DoubleClick(object sender, EventArgs e)
        {
            Accept();
        }
    }
}