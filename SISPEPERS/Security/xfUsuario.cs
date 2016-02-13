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
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace SISPEPERS.Seguridad
{
    public partial class xfUsuario : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfUsuario mSgIns;
        public static xfUsuario SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfUsuario();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfUsuario()
        {
            InitializeComponent();
        }

        private void xfUsuario_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var oBe = new BESVMC_PERF();
            var oBr = new BRSVMC_PERF();

            oBe.NUM_ACCI = 4;
            oBe.COD_COMP = SESSION_COMP;
            var oList = oBr.Get_SVPR_PERF_LIST(oBe);

            lueCOD_PERF.Properties.DataSource = oList;
            lueCOD_PERF.Properties.Columns.Clear();
            lueCOD_PERF.Properties.Columns.Add(new LookUpColumnInfo("ALF_PERF", 100, "Perfiles"));
            lueCOD_PERF.Properties.DisplayMember = "ALF_PERF";
            lueCOD_PERF.Properties.ValueMember = "COD_PERF";

            var oBeU = new BESVMC_USUA();
            var oBrU = new BRSVMC_USUA();

            oBeU.COD_COMP = SESSION_COMP;
            oBeU.NUM_ACCI = 4;

            var oListUser = oBrU.Get_SVPR_USUA_LIST(oBeU);

            gdcUsuarios.DataSource = oListUser;

            StateControl(true);
        }

        private void xfUsuario_Activated(object sender, EventArgs e)
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

        private void xfUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void beALF_EMPL_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using(xfSearchPerson oForm = new xfSearchPerson(SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    //ClearControl();
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                }
            }
        }

        private void xfUsuario_Deactivate(object sender, EventArgs e)
        {
            var oBeAcce = new BESVMD_ACCE();
            var oBrAcce = new BRSVMD_ACCE();
            oBeAcce.NUM_ACCI = 5;
            oBeAcce.ALF_NOMB = FORM_SUBO;
            oBeAcce.COD_PERF = SESSION_PERF;
            var oListBotones = oBrAcce.Get_SVPR_ACCE_LIST(oBeAcce);

            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            {
                itemLink.Item.Visibility = BarItemVisibility.Never;
            }
        }

        private void gdvUsuarios_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_USUA)gdvUsuarios.GetRow(e.RowHandle);
                    txtCOD_SOCI_NEGO.Text = oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oBe.ALF_NOMB;
                    txtCOD_USUA.Text = oBe.COD_USUA;
                    txtALF_PASS.Text = BRCryptography.Decrypt(oBe.ALF_PASS);
                    txtALF_PASS_REPE.Text = BRCryptography.Decrypt(oBe.ALF_PASS);
                    lueCOD_PERF.EditValue = oBe.COD_PERF;
                }
            }
        }

        private void gdvUsuarios_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_USUA)gdvUsuarios.GetRow(e.FocusedRowHandle);
                    txtCOD_SOCI_NEGO.Text = oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oBe.ALF_NOMB;
                    txtCOD_USUA.Text = oBe.COD_USUA;
                    txtALF_PASS.Text = BRCryptography.Decrypt(oBe.ALF_PASS);
                    txtALF_PASS_REPE.Text = BRCryptography.Decrypt(oBe.ALF_PASS);
                    lueCOD_PERF.EditValue = oBe.COD_PERF;
                }
            }
        }

        private void ClearControl()
        {
            txtCOD_SOCI_NEGO.Text = "";
            beALF_NOMB.Text = "";
            txtCOD_USUA.Text = "";
            txtALF_PASS.Text = "";
            txtALF_PASS_REPE.Text = "";
            lueCOD_PERF.EditValue = null;
        }

        private void StateControl(bool vState)
        {
            txtCOD_USUA.Properties.ReadOnly = vState;
            txtALF_PASS.Properties.ReadOnly = vState;
            txtALF_PASS_REPE.Properties.ReadOnly = vState;
            lueCOD_PERF.Properties.ReadOnly = vState;
            gdcUsuarios.Enabled = vState;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            beALF_NOMB.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtCOD_USUA.Properties.ReadOnly = true;
            beALF_NOMB.Focus();
        }

        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("Seleccione un empleado para asignarle el usuario");
                if (string.IsNullOrEmpty(txtALF_PASS.Text))
                    throw new ArgumentException("Escriba la contraseña");
                if (string.IsNullOrEmpty(txtALF_PASS_REPE.Text))
                    throw new ArgumentException("Escriba nuevamente la contraseña");
                if (lueCOD_PERF.EditValue == null)
                    throw new ArgumentException("Seleccione el perfil");
                if (!txtALF_PASS.Text.Equals(txtALF_PASS_REPE.Text))
                    throw new ArgumentException("Las contraseñas no coinciden ");

                var oBe = new BESVMC_USUA();
                var oBr = new BRSVMC_USUA();

                if (txtCOD_USUA.Properties.ReadOnly)
                {
                    oBe.NUM_ACCI = 2;
                }
                else
                {
                    oBe.NUM_ACCI = 1;
                }

                oBe.COD_SOCI_NEGO=Convert.ToInt32(txtCOD_SOCI_NEGO.Text);
                oBe.COD_USUA = txtCOD_USUA.Text;
                oBe.ALF_PASS = BRCryptography.Encrypt(txtALF_PASS.Text);
                oBe.COD_PERF = Convert.ToInt32(lueCOD_PERF.EditValue);
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;

                oBr.Set_SVPR_USUA(oBe);

                var oBeU = new BESVMC_USUA();
                var oBrU = new BRSVMC_USUA();

                oBeU.COD_COMP = SESSION_COMP;
                oBeU.NUM_ACCI = 4;

                var oListUser = oBrU.Get_SVPR_USUA_LIST(oBeU);

                gdcUsuarios.DataSource = oListUser;

                StateControl(true);

                XtraMessageBox.Show("Operacion realizada con exito!!!!","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}