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
    public partial class xfCountry : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfCountry mSgIns;
        public static xfCountry SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfCountry();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfCountry()
        {
            InitializeComponent();
        }

        private void xfCountry_Activated(object sender, EventArgs e)
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

        private void xfCountry_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfCountry_Deactivate(object sender, EventArgs e)
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

        private void xfCountry_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            StateControl(true);
            var oBeC = new BESVMC_PAIS();
            var oBrC = new BRSVMC_PAIS();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_PAIS_LIST(oBeC);
            gdcBranch.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_PAIS.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_PAIS.Focus();
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            txtALF_PAIS.Properties.ReadOnly = vState;
            txtALF_IMPU.Properties.ReadOnly = vState;
            txtNUM_PORC_IMPU.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            gdcBranch.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_PAIS.Text = "";
            txtALF_PAIS.Text = "";
            txtALF_IMPU.Text = "";
            txtNUM_PORC_IMPU.Text = "";
            meALF_DESC.Text = "";
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_PAIS.Text))
                    throw new ArgumentException("Ingresar el nombre de la sucursal");

                var oBe = new BESVMC_PAIS();
                var oBr = new BRSVMC_PAIS();

                if (string.IsNullOrEmpty(txtCOD_PAIS.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_PAIS = Convert.ToInt32(txtCOD_PAIS.Text);
                }

                oBe.ALF_PAIS = txtALF_PAIS.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.ALF_IMPU = txtALF_IMPU.Text;
                oBe.NUM_PORC_IMPU=Convert.ToDecimal(txtNUM_PORC_IMPU.Text);
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_PAIS(oBe);
                txtCOD_PAIS.Text = oBe.COD_PAIS.ToString();
                ((xfMain)MdiParent).SESSION_PORC_IMPU = oBe.NUM_PORC_IMPU;
                ((xfMain)MdiParent).SESSION_IMPU = oBe.ALF_IMPU;
                var oBeC = new BESVMC_PAIS();
                var oBrC = new BRSVMC_PAIS();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_PAIS_LIST(oBeC);
                gdcBranch.DataSource = oListC;
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
                    var oBe = (BESVMC_PAIS)Grid.GetRow(e.RowHandle);
                    txtCOD_PAIS.Text = oBe.COD_PAIS.ToString();
                    txtALF_PAIS.Text = oBe.ALF_PAIS;
                    txtALF_IMPU.Text = oBe.ALF_IMPU;
                    txtNUM_PORC_IMPU.Text = oBe.NUM_PORC_IMPU.ToString();
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_PAIS.Focus();
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
                    var oBe = (BESVMC_PAIS)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_PAIS.Text = oBe.COD_PAIS.ToString();
                    txtALF_PAIS.Text = oBe.ALF_PAIS;
                    txtALF_IMPU.Text = oBe.ALF_IMPU;
                    txtNUM_PORC_IMPU.Text = oBe.NUM_PORC_IMPU.ToString();
                    meALF_DESC.Text = oBe.ALF_DESC;
                    txtALF_PAIS.Focus();
                }
            }
        }
    }
}