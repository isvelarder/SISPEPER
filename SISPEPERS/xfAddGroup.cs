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
using BusinessEntities.Sales;

namespace SISPEPERS
{
    public partial class xfAddGroup : DevExpress.XtraEditors.XtraForm
    {
        public BESVTD_COTI_GROU oBe;

        public xfAddGroup()
        {
            InitializeComponent();
            oBe = new BESVTD_COTI_GROU();
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_NOMB.Text))
                    throw new ArgumentException("Ingrese el nombre del agrupamiento");
                oBe.ALF_NOMB = txtALF_NOMB.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void xfAddGroup_Load(object sender, EventArgs e)
        {

        }

        private void txtALF_NOMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtALF_NOMB.Text))
                        throw new ArgumentException("Ingrese el nombre del agrupamiento");
                    oBe.ALF_NOMB = txtALF_NOMB.Text;
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}