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
    public partial class xfModelArticle : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfModelArticle mSgIns;
        public static xfModelArticle SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfModelArticle();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfModelArticle()
        {
            InitializeComponent();
        }

        private void xfModelArticle_Activated(object sender, EventArgs e)
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

        private void xfModelArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfModelArticle_Deactivate(object sender, EventArgs e)
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

        private void xfModelArticle_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_MODE_ARTI();
            var oBrC = new BRSVMC_MODE_ARTI();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_MODE_ARTI_LIST(oBeC);
            gdcModelArticle.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_MODE_ARTI.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_MODE_ARTI.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_MODE_ARTI.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            gdcModelArticle.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_MODE_ARTI.Text = "";
            txtALF_MODE_ARTI.Text = "";
            meALF_DESC.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_MODE_ARTI.Text))
                    throw new ArgumentException("Ingresar modelo de artículo");

                var oBe = new BESVMC_MODE_ARTI();
                var oBr = new BRSVMC_MODE_ARTI();

                if (string.IsNullOrEmpty(txtCOD_MODE_ARTI.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_MODE_ARTI = Convert.ToInt32(txtCOD_MODE_ARTI.Text);
                }

                oBe.ALF_MODE_ARTI = txtALF_MODE_ARTI.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_MODE_ARTI(oBe);
                txtCOD_MODE_ARTI.Text = oBe.COD_MODE_ARTI.ToString();
                var oBeC = new BESVMC_MODE_ARTI();
                var oBrC = new BRSVMC_MODE_ARTI();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_MODE_ARTI_LIST(oBeC);
                gdcModelArticle.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdvTypeContact_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_MODE_ARTI)Grid.GetRow(e.RowHandle);
                    txtCOD_MODE_ARTI.Text = oBe.COD_MODE_ARTI.ToString();
                    txtALF_MODE_ARTI.Text = oBe.ALF_MODE_ARTI;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_MODE_ARTI.Focus();
                }
            }
        }

        private void gdvTypeContact_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_MODE_ARTI)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_MODE_ARTI.Text = oBe.COD_MODE_ARTI.ToString();
                    txtALF_MODE_ARTI.Text = oBe.ALF_MODE_ARTI;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_MODE_ARTI.Focus();
                }
            }
        }
    }
}