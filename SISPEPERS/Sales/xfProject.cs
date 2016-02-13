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
using BusinessEntities.Generics;
using BusinessRules.Generics;

namespace SISPEPERS.Sales
{
    public partial class xfProject : DevExpress.XtraEditors.XtraForm
    {
        public BESVMC_PROY oBe;
        public int COD_COMP { get; set; }
        public string COD_USUA_CREA { get; set; }
        public xfProject(int COMP,string COD_USUA)
        {
            InitializeComponent();
            oBe = new BESVMC_PROY();
            COD_COMP = COMP;
            COD_USUA_CREA = COD_USUA;
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var oBr = new BRSVMC_PROY();
                if (string.IsNullOrEmpty(txtALF_PROY.Text))
                    throw new ArgumentException("Ingrese correctamente el nombre del proyecto");
                oBe.ALF_PROY = txtALF_PROY.Text;
                oBe.COD_COMP = COD_COMP;
                oBe.NUM_ACCI = 1;
                oBe.COD_USUA_CREA = COD_USUA_CREA;
                oBr.Set_SVPR_PROY(oBe);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}