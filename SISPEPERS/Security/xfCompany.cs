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

namespace SISPEPERS.Seguridad
{
    public partial class xfCompany : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfCompany mSgIns;
        public static xfCompany SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfCompany();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfCompany()
        {
            InitializeComponent();
        }

        private void xfCompany_Activated(object sender, EventArgs e)
        {
            ((xfMain)MdiParent).fra = this;
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

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

        private void xfCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfCompany_Deactivate(object sender, EventArgs e)
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

        private void xfCompany_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var oBe = new BESVMC_PAIS();
            var oBr = new BRSVMC_PAIS();

            var oBeC = new BESVMC_COMP();
            var oBrC = new BRSVMC_COMP();

            oBeC.NUM_ACCI = 4;

            var oListC = oBrC.Get_SVPR_COMP_LIST(oBeC);
            gdcCompany.DataSource = oListC;

            oBe.NUM_ACCI = 4;
            oBe.COD_COMP = SESSION_COMP;
            var oList = oBr.Get_SVPR_PAIS_LIST(oBe);

            lueCOD_PAIS.Properties.DataSource = oList;
            lueCOD_PAIS.Properties.Columns.Clear();
            lueCOD_PAIS.Properties.Columns.Add(new LookUpColumnInfo("ALF_PAIS", 100, "Paises"));
            lueCOD_PAIS.Properties.DisplayMember = "ALF_PAIS";
            lueCOD_PAIS.Properties.ValueMember = "COD_PAIS";

            StateControl(true);
        }

        private void lueCOD_PAIS_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DEPA();
                var oBr = new BRSVMC_DEPA();

                oBe.NUM_ACCI = 5;
                oBe.COD_PAIS = Convert.ToInt32(Obj.EditValue);
                var oList = oBr.Get_SVPR_DEPA_LIST(oBe);

                lueCOD_DEPA.Properties.DataSource = oList;
                lueCOD_DEPA.Properties.Columns.Clear();
                lueCOD_DEPA.Properties.Columns.Add(new LookUpColumnInfo("ALF_DEPA", 100, "Departamento"));
                lueCOD_DEPA.Properties.DisplayMember = "ALF_DEPA";
                lueCOD_DEPA.Properties.ValueMember = "COD_DEPA";
            }
            else
            {
                lueCOD_DEPA.Properties.DataSource = null;
            }
        }

        private void lueCOD_DEPA_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_PROV();
                var oBr = new BRSVMC_PROV();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(Obj.EditValue);
                var oList = oBr.Get_SVPR_PROV_LIST(oBe);

                lueCOD_PROV.Properties.DataSource = oList;
                lueCOD_PROV.Properties.Columns.Clear();
                lueCOD_PROV.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROV", 100, "Provincia"));
                lueCOD_PROV.Properties.DisplayMember = "ALF_PROV";
                lueCOD_PROV.Properties.ValueMember = "COD_PROV";
                if (lueCOD_PROV.EditValue != null)
                {
                    var oBeP = new BESVMC_DIST();
                    var oBrP = new BRSVMC_DIST();

                    oBeP.NUM_ACCI = 5;
                    oBeP.COD_DEPA = Convert.ToString(lueCOD_DEPA.EditValue);
                    oBeP.COD_PROV = Convert.ToString(lueCOD_PROV.EditValue);
                    var oListP = oBrP.Get_SVPR_DIST_LIST(oBeP);

                    lueCOD_DIST.Properties.DataSource = oListP;
                    lueCOD_DIST.Properties.Columns.Clear();
                    lueCOD_DIST.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                    lueCOD_DIST.Properties.DisplayMember = "ALF_DIST";
                    lueCOD_DIST.Properties.ValueMember = "COD_DIST";
                }
                else
                {
                    lueCOD_DIST.Properties.DataSource = null;
                }
            }
            else
            {
                lueCOD_PROV.Properties.DataSource = null;
                lueCOD_DIST.Properties.DataSource = null;
            }
        }

        private void lueCOD_PROV_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DIST();
                var oBr = new BRSVMC_DIST();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(lueCOD_DEPA.EditValue);
                oBe.COD_PROV = Convert.ToString(lueCOD_PROV.EditValue);
                var oList = oBr.Get_SVPR_DIST_LIST(oBe);

                lueCOD_DIST.Properties.DataSource = oList;
                lueCOD_DIST.Properties.Columns.Clear();
                lueCOD_DIST.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                lueCOD_DIST.Properties.DisplayMember = "ALF_DIST";
                lueCOD_DIST.Properties.ValueMember = "COD_DIST";
            }
            else
            {
                lueCOD_DIST.Properties.DataSource = null;
            }
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_COMP.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_COMP.Focus();
        }

        public void Undo()
        {
            StateControl(true);
            
        }

        private void StateControl(bool vState)
        {
            txtALF_COMP.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            lueCOD_PAIS.Properties.ReadOnly = vState;
            lueCOD_DEPA.Properties.ReadOnly = vState;
            lueCOD_PROV.Properties.ReadOnly = vState;
            lueCOD_DIST.Properties.ReadOnly = vState;
            gdcCompany.Enabled = vState;
        }

        private void ClearControl()
        {
            txtCOD_COMP.Text = "";
            txtALF_COMP.Text = "";
            meALF_DESC.Text = "";
            lueCOD_PAIS.EditValue = null;
            lueCOD_DEPA.EditValue = null;
            lueCOD_PROV.EditValue = null;
            lueCOD_DIST.EditValue = null;
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_COMP.Text))
                    throw new ArgumentException("Ingresar el nombre de la compañia");
                if (lueCOD_PAIS.EditValue==null)
                    throw new ArgumentException("Seleccione el país");

                var oBe = new BESVMC_COMP();
                var oBr = new BRSVMC_COMP();

                if (string.IsNullOrEmpty(txtCOD_COMP.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_COMP=Convert.ToInt32(txtCOD_COMP.Text);
                }

                oBe.ALF_COMP = txtALF_COMP.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.COD_PAIS = Convert.ToInt32(lueCOD_PAIS.EditValue);
                oBe.COD_DEPA = lueCOD_DEPA.EditValue==null?"":lueCOD_DEPA.EditValue.ToString();
                oBe.COD_PROV = lueCOD_PROV.EditValue == null ? "" : lueCOD_PROV.EditValue.ToString();
                oBe.COD_DIST = lueCOD_DIST.EditValue == null ? "" : lueCOD_DIST.EditValue.ToString();
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;

                oBr.Set_SVPR_COMP(oBe);
                txtCOD_COMP.Text = oBe.COD_COMP.ToString();
                var oBeC = new BESVMC_COMP();
                var oBrC = new BRSVMC_COMP();

                oBeC.NUM_ACCI = 4;

                var oListC = oBrC.Get_SVPR_COMP_LIST(oBeC);
                gdcCompany.DataSource = oListC;
                StateControl(true);
                XtraMessageBox.Show("Operación realizada con exito!!!","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gdvCompany_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_COMP)Grid.GetRow(e.RowHandle);
                    txtCOD_COMP.Text = oBe.COD_COMP.ToString();
                    txtALF_COMP.Text = oBe.ALF_COMP;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    lueCOD_PAIS.EditValue = oBe.COD_PAIS;
                    lueCOD_DEPA.EditValue = oBe.COD_DEPA;
                    lueCOD_PROV.EditValue = oBe.COD_PROV;
                    lueCOD_DIST.EditValue = oBe.COD_DIST;
                    txtALF_COMP.Focus();
                }
            }
        }

        private void gdvCompany_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_COMP)Grid.GetRow(e.FocusedRowHandle);
                    txtCOD_COMP.Text = oBe.COD_COMP.ToString();
                    txtALF_COMP.Text = oBe.ALF_COMP;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    lueCOD_PAIS.EditValue = oBe.COD_PAIS;
                    lueCOD_DEPA.EditValue = oBe.COD_DEPA;
                    lueCOD_PROV.EditValue = oBe.COD_PROV;
                    lueCOD_DIST.EditValue = oBe.COD_DIST;
                    txtALF_COMP.Focus();
                }
            }
        }
    }
}