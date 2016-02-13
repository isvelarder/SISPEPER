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
using BusinessEntities.Ubigeo;
using BusinessRules.Ubigeo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using BusinessEntities.Generics;
using BusinessRules.Generics;

namespace SISPEPERS.Generics
{
    public partial class xfPaymentTerm : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfPaymentTerm mSgIns;
        public static xfPaymentTerm SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfPaymentTerm();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfPaymentTerm()
        {
            InitializeComponent();
        }

        private void xfPaymentTerm_Activated(object sender, EventArgs e)
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

        private void xfPaymentTerm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfPaymentTerm_Deactivate(object sender, EventArgs e)
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

        private void xfPaymentTerm_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_COND_PAGO();
            var oBrC = new BRSVMC_COND_PAGO();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_COND_PAGO_LIST(oBeC);
            gdcPaymentTerm.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_COND_PAGO.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_COND_PAGO.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_COND_PAGO.Properties.ReadOnly = vState;
            txtNUM_DIAS.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            gdcPaymentTerm.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_COND_PAGO.Text = "";
            txtALF_COND_PAGO.Text = "";
            txtNUM_DIAS.Text = "";
            meALF_DESC.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_COND_PAGO.Text))
                    throw new ArgumentException("Ingresar el tipo de socio");

                var oBe = new BESVMC_COND_PAGO();
                var oBr = new BRSVMC_COND_PAGO();

                if (string.IsNullOrEmpty(txtCOD_COND_PAGO.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_COND_PAGO = Convert.ToInt32(txtCOD_COND_PAGO.Text);
                }

                oBe.ALF_COND_PAGO = txtALF_COND_PAGO.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.NUM_DIAS = Convert.ToInt32(txtNUM_DIAS.Text);
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_COND_PAGO(oBe);
                txtCOD_COND_PAGO.Text = oBe.COD_COND_PAGO.ToString();
                var oBeC = new BESVMC_COND_PAGO();
                var oBrC = new BRSVMC_COND_PAGO();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_COND_PAGO_LIST(oBeC);
                gdcPaymentTerm.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvPaymentTerm_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_COND_PAGO)Grid.GetRow(e.RowHandle);
                    txtCOD_COND_PAGO.Text = oBe.COD_COND_PAGO.ToString();
                    txtALF_COND_PAGO.Text = oBe.ALF_COND_PAGO;
                    txtNUM_DIAS.Text = oBe.NUM_DIAS.ToString();
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_COND_PAGO.Focus();
                }
            }
        }

        private void gdvPaymentTerm_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_COND_PAGO)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_COND_PAGO.Text = oBe.COD_COND_PAGO.ToString();
                    txtALF_COND_PAGO.Text = oBe.ALF_COND_PAGO;
                    txtNUM_DIAS.Text = oBe.NUM_DIAS.ToString();
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_COND_PAGO.Focus();
                }
            }
        }
    }
}