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
using BusinessEntities.Security;
using BusinessRules.Security;

namespace SISPEPERS.Security
{
    public partial class xfPasswordChange : DevExpress.XtraEditors.XtraForm
    {
        public string SESSION_USER;
        public int SESSION_COMP;
        public BESVMC_USUA oBe;

        public xfPasswordChange()
        {
            InitializeComponent();
            oBe = new BESVMC_USUA();
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var oBeV = new BESVMC_USUA();
                var oBrV = new BRSVMC_USUA();
                
                oBeV.ALF_PASS = BRCryptography.Encrypt(txtALF_PASS_ACTU.Text);
                oBeV.COD_USUA = SESSION_USER;
                oBeV.COD_COMP = SESSION_COMP;
                oBeV.NUM_ACCI = 6;

                var oList = oBrV.Get_SVPR_USUA_LIST(oBeV);

                if (oList.Count == 0)
                    throw new ArgumentException("La contraseña actual ingresada no es correcta");

                if (string.IsNullOrEmpty(txtALF_PASS.Text))
                    throw new ArgumentException("Ingrese correctamente la contraseña");
                if (string.IsNullOrEmpty(txtALF_PASS_REPE.Text))
                    throw new ArgumentException("Ingrese correctamente la contraseña");
                if (!txtALF_PASS.Text.Equals(txtALF_PASS_REPE.Text))
                    throw new ArgumentException("Las contraseñas ingresadas no coinciden");
                if (XtraMessageBox.Show("Esta seguro que desea cambiar la contraseña?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oBe.ALF_PASS = BRCryptography.Encrypt(txtALF_PASS.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void xfPasswordChange_Load(object sender, EventArgs e)
        {
            
        }

        private void xfPasswordChange_Activated(object sender, EventArgs e)
        {
            txtALF_PASS_ACTU.Focus();
        }
    }
}