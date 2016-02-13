using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Security;
using BusinessRules.Security;
using DevExpress.XtraEditors.Controls;
using System;

namespace SISPEPERS
{
    public partial class xfLogin : XtraForm
    {
        public BESVMC_USUA oBe;
        public xfLogin()
        {
            oBe = new BESVMC_USUA();
            InitializeComponent();
        }
        /// <summary>
        /// METODO CANCELAR
        /// </summary>
        private void Cancel()
        {
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// METODO ACEPTAR
        /// </summary>
        private void Accept()
        {
            var oBr = new BRSVMC_USUA();

            oBe.COD_USUA = txtUserName.Text;
            oBe.COD_COMP = 1;// Convert.ToInt32(lueCOD_COMP.EditValue);
            oBe.ALF_PASS = BRCryptography.Encrypt(txtPassword.Text);
            oBe.NUM_ACCI = 5;

            var oList = oBr.Get_SVPR_USUA_LIST(oBe);

            if (oList.Count > 0)
            {
                oBe.ALF_NOMB = oList[0].ALF_NOMB;
                oBe.COD_PERF = oList[0].COD_PERF;
                oBe.ALF_IMPU = oList[0].ALF_IMPU;
                oBe.NUM_PORC_IMPU = oList[0].NUM_PORC_IMPU;
                DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Datos de acceso incorrectos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// PRESIONAR EL BOTON ACEPTAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Accept();
        }
        /// <summary>
        /// PRESIONAR EL BOTON CANCELAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cancel();
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bbiAccept_ItemClick(null, null);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bbiAccept_ItemClick(null, null);
            }
        }

        private void xfLogin_Load(object sender, System.EventArgs e)
        {
            var oBeC = new BESVMC_COMP();
            var oBrC = new BRSVMC_COMP();

            oBeC.NUM_ACCI = 4;

            var oListC = oBrC.Get_SVPR_COMP_LIST(oBeC);

            lueCOD_COMP.Properties.DataSource = oListC;
            lueCOD_COMP.Properties.Columns.Clear();
            lueCOD_COMP.Properties.Columns.Add(new LookUpColumnInfo("ALF_COMP", 100, "Compañia"));
            lueCOD_COMP.Properties.DisplayMember = "ALF_COMP";
            lueCOD_COMP.Properties.ValueMember = "COD_COMP";
        }
    }
}