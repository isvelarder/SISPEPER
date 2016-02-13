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
    public partial class xfTypeIdentification : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfTypeIdentification mSgIns;
        public static xfTypeIdentification SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfTypeIdentification();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfTypeIdentification()
        {
            InitializeComponent();
        }

        private void xfTypeIdentification_Activated(object sender, EventArgs e)
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

        private void xfTypeIdentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfTypeIdentification_Deactivate(object sender, EventArgs e)
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

        private void xfTypeIdentification_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_TIPO_IDEN();
            var oBrC = new BRSVMC_TIPO_IDEN();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_TIPO_IDEN_LIST(oBeC);
            gdcTypeIdent.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_TIPO_IDEN.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_TIPO_IDEN.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_TIPO_IDEN.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            gdcTypeIdent.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_TIPO_IDEN.Text = "";
            txtALF_TIPO_IDEN.Text = "";
            meALF_DESC.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_TIPO_IDEN.Text))
                    throw new ArgumentException("Ingresar el tipo de socio");

                var oBe = new BESVMC_TIPO_IDEN();
                var oBr = new BRSVMC_TIPO_IDEN();

                if (string.IsNullOrEmpty(txtCOD_TIPO_IDEN.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_TIPO_IDEN = Convert.ToInt32(txtCOD_TIPO_IDEN.Text);
                }

                oBe.ALF_TIPO_IDEN = txtALF_TIPO_IDEN.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_TIPO_IDEN(oBe);
                txtCOD_TIPO_IDEN.Text = oBe.COD_TIPO_IDEN.ToString();
                var oBeC = new BESVMC_TIPO_IDEN();
                var oBrC = new BRSVMC_TIPO_IDEN();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_TIPO_IDEN_LIST(oBeC);
                gdcTypeIdent.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvTypeIdent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_TIPO_IDEN)Grid.GetRow(e.RowHandle);
                    txtCOD_TIPO_IDEN.Text = oBe.COD_TIPO_IDEN.ToString();
                    txtALF_TIPO_IDEN.Text = oBe.ALF_TIPO_IDEN;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_TIPO_IDEN.Focus();
                }
            }
        }

        private void gdvTypeIdent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_TIPO_IDEN)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_TIPO_IDEN.Text = oBe.COD_TIPO_IDEN.ToString();
                    txtALF_TIPO_IDEN.Text = oBe.ALF_TIPO_IDEN;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_TIPO_IDEN.Focus();
                }
            }
        }
    }
}