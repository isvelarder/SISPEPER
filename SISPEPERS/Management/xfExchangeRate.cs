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
using BusinessEntities.Management;
using BusinessRules.Management;

namespace SISPEPERS.Management
{
    public partial class xfExchangeRate : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfExchangeRate mSgIns;
        public static xfExchangeRate SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfExchangeRate();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfExchangeRate()
        {
            InitializeComponent();
        }

        private void xfExchangeRate_Activated(object sender, EventArgs e)
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

        private void xfExchangeRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfExchangeRate_Deactivate(object sender, EventArgs e)
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

        private void xfExchangeRate_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_TIPO_CAMB();
            var oBrC = new BRSVMC_TIPO_CAMB();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_TIPO_CAMB_LIST(oBeC);
            gdcExchangeRate.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            deFEC_TIPO_CAMB.DateTime = DateTime.Today;
            deFEC_TIPO_CAMB.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            deFEC_TIPO_CAMB.Focus();
        }

        public void Undo()
        {
            StateControl(true);
            ClearControl();
        }

        private void StateControl(bool vState)
        {
            deFEC_TIPO_CAMB.Properties.ReadOnly = vState;
            txtNUM_TIPO_CAMB_COMP.Properties.ReadOnly = vState;
            txtNUM_TIPO_CAMB_VENT.Properties.ReadOnly = vState;
            gdcExchangeRate.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_TIPO_CAMB.Text = "";
            deFEC_TIPO_CAMB.DateTime = DateTime.Today;
            txtNUM_TIPO_CAMB_COMP.Text = "";
            txtNUM_TIPO_CAMB_VENT.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(deFEC_TIPO_CAMB.Text))
                    throw new ArgumentException("Ingresar la fecha del tipo de cambio");

                var oBe = new BESVMC_TIPO_CAMB();
                var oBr = new BRSVMC_TIPO_CAMB();

                if (string.IsNullOrEmpty(txtCOD_TIPO_CAMB.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_TIPO_CAMB = Convert.ToInt32(txtCOD_TIPO_CAMB.Text);
                }

                oBe.FEC_TIPO_CAMB = deFEC_TIPO_CAMB.DateTime;
                oBe.NUM_TIPO_CAMB_COMP = Convert.ToDecimal(txtNUM_TIPO_CAMB_COMP.Text);
                oBe.NUM_TIPO_CAMB_VENT = Convert.ToDecimal(txtNUM_TIPO_CAMB_VENT.Text);
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_TIPO_CAMB(oBe);
                txtCOD_TIPO_CAMB.Text = oBe.COD_TIPO_CAMB.ToString();
                var oBeC = new BESVMC_TIPO_CAMB();
                var oBrC = new BRSVMC_TIPO_CAMB();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_TIPO_CAMB_LIST(oBeC);
                gdcExchangeRate.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvExchangeRate_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_TIPO_CAMB)Grid.GetRow(e.RowHandle);
                    txtCOD_TIPO_CAMB.Text = oBe.COD_TIPO_CAMB.ToString();
                    txtNUM_TIPO_CAMB_COMP.Text = oBe.NUM_TIPO_CAMB_COMP.ToString("#,##0.00");
                    txtNUM_TIPO_CAMB_VENT.Text = oBe.NUM_TIPO_CAMB_VENT.ToString("#,##0.00");
                    deFEC_TIPO_CAMB.EditValue = oBe.FEC_TIPO_CAMB;
                    deFEC_TIPO_CAMB.Focus();
                }
            }
        }

        private void gdvExchangeRate_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_TIPO_CAMB)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_TIPO_CAMB.Text = oBe.COD_TIPO_CAMB.ToString();
                    txtNUM_TIPO_CAMB_COMP.Text = oBe.NUM_TIPO_CAMB_COMP.ToString("#,##0.00");
                    txtNUM_TIPO_CAMB_VENT.Text = oBe.NUM_TIPO_CAMB_VENT.ToString("#,##0.00");
                    deFEC_TIPO_CAMB.EditValue = oBe.FEC_TIPO_CAMB;
                    deFEC_TIPO_CAMB.Focus();
                }
            }
        }
    }
}