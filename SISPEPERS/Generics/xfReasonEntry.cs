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
using BusinessEntities.Warehouse;

namespace SISPEPERS.Generics
{
    public partial class xfReasonEntry : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfReasonEntry mSgIns;
        public static xfReasonEntry SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfReasonEntry();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfReasonEntry()
        {
            InitializeComponent();
        }

        private void xfReasonEntry_Activated(object sender, EventArgs e)
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

        private void xfReasonEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfReasonEntry_Deactivate(object sender, EventArgs e)
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

        private void xfReasonEntry_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BEReason();
            var oBrC = new BRSVMC_MOTI();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_TIPO_MOTI = 1;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_MOTI_LIST(oBeC);
            gdcReason.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_MOTI.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_MOTI.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_MOTI.Properties.ReadOnly = vState;
            gdcReason.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_MOTI.Text = "";
            txtALF_MOTI.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_MOTI.Text))
                    throw new ArgumentException("Ingresar nombre para el motivo");

                var oBe = new BEReason();
                var oBr = new BRSVMC_MOTI();

                if (string.IsNullOrEmpty(txtCOD_MOTI.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_MOTI = Convert.ToInt32(txtCOD_MOTI.Text);
                }

                oBe.ALF_MOTI = txtALF_MOTI.Text;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_TIPO_MOTI = 1;

                oBr.Set_SVPR_MOTI(oBe);
                txtCOD_MOTI.Text = oBe.COD_MOTI.ToString();
                var oBeC = new BEReason();
                var oBrC = new BRSVMC_MOTI();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_TIPO_MOTI = 1;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_MOTI_LIST(oBeC);
                gdcReason.DataSource = oListC;
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
                    var oBe = (BEReason)Grid.GetRow(e.RowHandle);
                    txtCOD_MOTI.Text = oBe.COD_MOTI.ToString();
                    txtALF_MOTI.Text = oBe.ALF_MOTI;
                    txtALF_MOTI.Focus();
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
                    var oBe = (BEReason)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_MOTI.Text = oBe.COD_MOTI.ToString();
                    txtALF_MOTI.Text = oBe.ALF_MOTI;
                    txtALF_MOTI.Focus();
                }
            }
        }
    }
}