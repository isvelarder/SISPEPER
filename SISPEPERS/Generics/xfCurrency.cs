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
using BusinessEntities.Sales;

namespace SISPEPERS.Generics
{
    public partial class xfCurrency : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfCurrency mSgIns;
        public static xfCurrency SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfCurrency();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfCurrency()
        {
            InitializeComponent();
        }

        private void xfCurrency_Activated(object sender, EventArgs e)
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

        private void xfCurrency_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfCurrency_Deactivate(object sender, EventArgs e)
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

        private void xfCurrency_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_MONE();
            var oBrC = new BRSVMC_MONE();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_MONE_LIST(oBeC);
            gdcCurrency.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_MONE.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_MONE.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_MONE.Properties.ReadOnly = vState;
            txtALF_MONE_SIMB.Properties.ReadOnly = vState;
            gdcCurrency.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_MONE.Text = "";
            txtALF_MONE.Text = "";
            txtALF_MONE_SIMB.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_MONE.Text))
                    throw new ArgumentException("Ingresar el nombre de la moneda");

                if (string.IsNullOrEmpty(txtALF_MONE_SIMB.Text))
                    throw new ArgumentException("Ingresar el simbolo de la moneda");

                var oBe = new BESVMC_MONE();
                var oBr = new BRSVMC_MONE();

                if (string.IsNullOrEmpty(txtCOD_MONE.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_MONE = Convert.ToInt32(txtCOD_MONE.Text);
                }

                oBe.ALF_MONE = txtALF_MONE.Text;
                oBe.ALF_MONE_SIMB = txtALF_MONE_SIMB.Text;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_MONE(oBe);
                txtCOD_MONE.Text = oBe.COD_MONE.ToString();
                var oBeC = new BESVMC_MONE();
                var oBrC = new BRSVMC_MONE();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_MONE_LIST(oBeC);
                gdcCurrency.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvBranch_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_MONE)Grid.GetRow(e.RowHandle);
                    txtCOD_MONE.Text = oBe.COD_MONE.ToString();
                    txtALF_MONE.Text = oBe.ALF_MONE;
                    txtALF_MONE_SIMB.Text = oBe.ALF_MONE_SIMB;
                    txtALF_MONE.Focus();
                }
            }
        }

        private void gdvBranch_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_MONE)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_MONE.Text = oBe.COD_MONE.ToString();
                    txtALF_MONE.Text = oBe.ALF_MONE;
                    txtALF_MONE_SIMB.Text = oBe.ALF_MONE_SIMB;
                    txtALF_MONE.Focus();
                }
            }
        }
    }
}