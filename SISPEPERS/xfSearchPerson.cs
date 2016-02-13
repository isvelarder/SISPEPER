using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Management;
using BusinessRules.Management;

namespace SISPEPERS
{
    public partial class xfSearchPerson : XtraForm
    {
        public BESVMC_SOCI_NEGO oBe;
        public int NUM_ACCI { get; set; }
        private int SESSION_COMP;
        public xfSearchPerson(int COD_COMP)
        {
            InitializeComponent();
            oBe = new BESVMC_SOCI_NEGO();
            SESSION_COMP = COD_COMP;
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            var oBeS = new BESVMC_SOCI_NEGO();
            var oBrS = new BRSVMC_SOCI_NEGO();

            oBeS.ALF_NOMB = txtALF_REFE.Text;
            oBeS.ALF_NUME_IDEN = txtALF_DNII.Text;
            oBeS.COD_COMP = SESSION_COMP;
            oBeS.NUM_ACCI = (NUM_ACCI == 0) ? 6 : NUM_ACCI;

            var oList = oBrS.Get_SVPR_SOCI_NEGO_LIST(oBeS);

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
                    oBe = (BESVMC_SOCI_NEGO)gdvResults.GetRow(gdvResults.FocusedRowHandle);
                    DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
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