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

namespace SISPEPERS.Management
{
    public partial class xfSeriesAnnul : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }
        private int FORM_ESTA { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfSeriesAnnul mSgIns;
        public static xfSeriesAnnul SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfSeriesAnnul();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfSeriesAnnul()
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

            var oBeTC = new BESVMC_TIPO_DOCU();
            var oBrTC = new BRSVMC_TIPO_DOCU();

            oBeTC.NUM_ACCI = 4;
            oBeTC.COD_COMP = SESSION_COMP;
            var oListTC = oBrTC.Get_SVPR_TIPO_DOCU_LIST(oBeTC);

            lueCOD_TIPO_DOCU.Properties.DataSource = oListTC;
            lueCOD_TIPO_DOCU.Properties.Columns.Clear();
            lueCOD_TIPO_DOCU.Properties.Columns.Add(new LookUpColumnInfo("ALF_TIPO_DOCU", 100, "Tipo documento"));
            lueCOD_TIPO_DOCU.Properties.DisplayMember = "ALF_TIPO_DOCU";
            lueCOD_TIPO_DOCU.Properties.ValueMember = "COD_TIPO_DOCU";

            var oBeC = new BESVMC_SERI_CORR();
            var oBrC = new BRSVMC_SERI_CORR();

            oBeC.NUM_ACCI = 4;
            oBeC.COD_COMP = SESSION_COMP;

            var oListC = oBrC.Get_SVPR_SERI_CORR_LIST(oBeC);
            gdcSeries.DataSource = oListC;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_SERI.Focus();
            FORM_ESTA = 1;
        }

        public void Edit()
        {
            StateControl(false);
            lueCOD_TIPO_DOCU.Properties.ReadOnly = true;
            txtALF_SERI.Properties.ReadOnly = true;
            txtNUM_CORR.Focus();
            FORM_ESTA = 2;
        }

        public void Undo()
        {
            StateControl(true);

        }

        private void StateControl(bool vState)
        {
            lueCOD_TIPO_DOCU.Properties.ReadOnly = vState;
            txtALF_SERI.Properties.ReadOnly = vState;
            txtNUM_CORR.Properties.ReadOnly = vState;
            gdcSeries.Enabled = vState;
        }

        private void ClearControl()
        {
            lueCOD_TIPO_DOCU.EditValue = null;
            txtALF_SERI.Text = "";
            txtNUM_CORR.Text = "";
        }

        public void Save()
        {
            if (txtNUM_CORR.Properties.ReadOnly) return;
            try
            {
                if (lueCOD_TIPO_DOCU.EditValue == null)
                    throw new ArgumentException("Seleccione el tipo de documento");

                if (string.IsNullOrEmpty(txtALF_SERI.Text))
                    throw new ArgumentException("Ingresar la serie");

                if (string.IsNullOrEmpty(txtNUM_CORR.Text))
                    throw new ArgumentException("Ingresar el correlativo");

                var oBe = new BESVMC_SERI_CORR();
                var oBr = new BRSVMC_SERI_CORR();

                if (FORM_ESTA==1)
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_TIPO_DOCU = Convert.ToInt32(lueCOD_TIPO_DOCU.EditValue);
                }

                oBe.COD_TIPO_DOCU = Convert.ToInt32(lueCOD_TIPO_DOCU.EditValue);
                oBe.ALF_SERI = txtALF_SERI.Text;
                oBe.NUM_CORR = Convert.ToInt32(txtNUM_CORR.Text);
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_SERI_CORR(oBe);
                lueCOD_TIPO_DOCU.EditValue = oBe.COD_TIPO_DOCU.ToString();
                var oBeC = new BESVMC_SERI_CORR();
                var oBrC = new BRSVMC_SERI_CORR();

                oBeC.NUM_ACCI = 4;
                oBeC.COD_COMP = SESSION_COMP;

                var oListC = oBrC.Get_SVPR_SERI_CORR_LIST(oBeC);
                gdcSeries.DataSource = oListC;
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
                    var oBe = (BESVMC_SERI_CORR)Grid.GetRow(e.RowHandle);
                    lueCOD_TIPO_DOCU.EditValue = oBe.COD_TIPO_DOCU;
                    txtALF_SERI.Text = oBe.ALF_SERI;
                    txtNUM_CORR.Text = oBe.NUM_CORR.ToString();
                    txtALF_SERI.Focus();
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
                    var oBe = (BESVMC_SERI_CORR)Grid.GetRow(e.FocusedRowHandle);
                    lueCOD_TIPO_DOCU.EditValue = oBe.COD_TIPO_DOCU;
                    txtALF_SERI.Text = oBe.ALF_SERI;
                    txtNUM_CORR.Text = oBe.NUM_CORR.ToString();
                    txtALF_SERI.Focus();
                }
            }
        }
    }
}