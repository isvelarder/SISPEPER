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
using BusinessEntities.Generics;
using BusinessRules.Generics;
using DevExpress.XtraEditors.Controls;
using BusinessRules.Management;
using BusinessEntities.Management;
using BusinessEntities.Ubigeo;
using BusinessRules.Ubigeo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace SISPEPERS.Management
{
    public partial class xfBusinessPartner : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }
        private List<BESVMD_SOCI_NEGO_CONT> oListCont;
        private List<BESVMD_SOCI_NEGO_SUCU> oListBranch;

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfBusinessPartner mSgIns;
        public static xfBusinessPartner SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfBusinessPartner();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfBusinessPartner()
        {
            InitializeComponent();
            oListCont = new List<BESVMD_SOCI_NEGO_CONT>();
            oListBranch = new List<BESVMD_SOCI_NEGO_SUCU>();
        }

        private void xfBusinessPartner_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            gdcContacts.DataSource = oListCont;
            gdcBranch.DataSource = oListBranch;

            var oBeTC = new BESVMC_TIPO_CONT();
            var oBrTC = new BRSVMC_TIPO_CONT();

            oBeTC.NUM_ACCI = 4;
            oBeTC.COD_COMP = SESSION_COMP;
            var oListTC = oBrTC.Get_SVPR_TIPO_CONT_LIST(oBeTC);

            rilueCOD_TIPO_CONT.DataSource = oListTC;
            rilueCOD_TIPO_CONT.Columns.Clear();
            rilueCOD_TIPO_CONT.Columns.Add(new LookUpColumnInfo("ALF_TIPO_CONT", 100, "Tipo contacto"));
            rilueCOD_TIPO_CONT.DisplayMember = "ALF_TIPO_CONT";
            rilueCOD_TIPO_CONT.ValueMember = "COD_TIPO_CONT";

            var oBeT = new BESVMC_TIPO_SOCI();
            var oBrT = new BRSVMC_TIPO_SOCI();

            oBeT.NUM_ACCI = 4;
            oBeT.COD_COMP = SESSION_COMP;
            var oListT = oBrT.Get_SVPR_TIPO_SOCI_LIST(oBeT);

            lueCOD_TIPO_SOCI.Properties.DataSource = oListT;
            lueCOD_TIPO_SOCI.Properties.Columns.Clear();
            lueCOD_TIPO_SOCI.Properties.Columns.Add(new LookUpColumnInfo("ALF_TIPO_SOCI", 100, "Tipo asociado"));
            lueCOD_TIPO_SOCI.Properties.DisplayMember = "ALF_TIPO_SOCI";
            lueCOD_TIPO_SOCI.Properties.ValueMember = "COD_TIPO_SOCI";

            var oBeI = new BESVMC_TIPO_IDEN();
            var oBrI = new BRSVMC_TIPO_IDEN();

            oBeI.NUM_ACCI = 4;
            oBeI.COD_COMP = SESSION_COMP;
            var oListI = oBrI.Get_SVPR_TIPO_IDEN_LIST(oBeI);

            lueCOD_TIPO_IDEN.Properties.DataSource = oListI;
            lueCOD_TIPO_IDEN.Properties.Columns.Clear();
            lueCOD_TIPO_IDEN.Properties.Columns.Add(new LookUpColumnInfo("ALF_TIPO_IDEN", 100, "Tipo identificación"));
            lueCOD_TIPO_IDEN.Properties.DisplayMember = "ALF_TIPO_IDEN";
            lueCOD_TIPO_IDEN.Properties.ValueMember = "COD_TIPO_IDEN";

            var oBeE = new BESVMC_SOCI_NEGO();
            var oBrE = new BRSVMC_SOCI_NEGO();

            oBeE.NUM_ACCI = 5;
            oBeE.COD_COMP = SESSION_COMP;
            var oListE = oBrE.Get_SVPR_SOCI_NEGO_LIST(oBeE);

            lueCOD_EJEC_COME.Properties.DataSource = oListE;
            lueCOD_EJEC_COME.Properties.Columns.Clear();
            lueCOD_EJEC_COME.Properties.Columns.Add(new LookUpColumnInfo("ALF_NOMB", 100, "Ejecutivo comercial"));
            lueCOD_EJEC_COME.Properties.DisplayMember = "ALF_NOMB";
            lueCOD_EJEC_COME.Properties.ValueMember = "COD_SOCI_NEGO";

            var oBeCP = new BESVMC_COND_PAGO();
            var oBrCP = new BRSVMC_COND_PAGO();

            oBeCP.NUM_ACCI = 4;
            oBeCP.COD_COMP = SESSION_COMP;
            var oListCP = oBrCP.Get_SVPR_COND_PAGO_LIST(oBeCP);

            lueCOD_COND_PAGO.Properties.DataSource = oListCP;
            lueCOD_COND_PAGO.Properties.Columns.Clear();
            lueCOD_COND_PAGO.Properties.Columns.Add(new LookUpColumnInfo("ALF_COND_PAGO", 100, "Condición de pago"));
            lueCOD_COND_PAGO.Properties.DisplayMember = "ALF_COND_PAGO";
            lueCOD_COND_PAGO.Properties.ValueMember = "COD_COND_PAGO";

            var oBeP = new BESVMC_PAIS();
            var oBrP = new BRSVMC_PAIS();

            oBeP.NUM_ACCI = 4;
            oBeP.COD_COMP = SESSION_COMP;
            var oListP = oBrP.Get_SVPR_PAIS_LIST(oBeP);
            var oListPE = oBrP.Get_SVPR_PAIS_LIST(oBeP);

            lueCOD_PAIS_DIRE_FISC.Properties.DataSource = oListP;
            lueCOD_PAIS_DIRE_FISC.Properties.Columns.Clear();
            lueCOD_PAIS_DIRE_FISC.Properties.Columns.Add(new LookUpColumnInfo("ALF_PAIS", 100, "Paises"));
            lueCOD_PAIS_DIRE_FISC.Properties.DisplayMember = "ALF_PAIS";
            lueCOD_PAIS_DIRE_FISC.Properties.ValueMember = "COD_PAIS";

            lueCOD_PAIS_DIRE_FACT.Properties.DataSource = oListPE;
            lueCOD_PAIS_DIRE_FACT.Properties.Columns.Clear();
            lueCOD_PAIS_DIRE_FACT.Properties.Columns.Add(new LookUpColumnInfo("ALF_PAIS", 100, "Paises"));
            lueCOD_PAIS_DIRE_FACT.Properties.DisplayMember = "ALF_PAIS";
            lueCOD_PAIS_DIRE_FACT.Properties.ValueMember = "COD_PAIS";

            StateControl(true);
        }

        private void lueCOD_PAIS_DIRE_FISC_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DEPA();
                var oBr = new BRSVMC_DEPA();

                oBe.NUM_ACCI = 5;
                oBe.COD_PAIS = Convert.ToInt32(Obj.EditValue);
                var oList = oBr.Get_SVPR_DEPA_LIST(oBe);

                lueCOD_DEPA_DIRE_FISC.Properties.DataSource = oList;
                lueCOD_DEPA_DIRE_FISC.Properties.Columns.Clear();
                lueCOD_DEPA_DIRE_FISC.Properties.Columns.Add(new LookUpColumnInfo("ALF_DEPA", 100, "Departamento"));
                lueCOD_DEPA_DIRE_FISC.Properties.DisplayMember = "ALF_DEPA";
                lueCOD_DEPA_DIRE_FISC.Properties.ValueMember = "COD_DEPA";
            }
            else
            {
                lueCOD_DEPA_DIRE_FISC.Properties.DataSource = null;
            }
        }

        private void lueCOD_DEPA_DIRE_FISC_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_PROV();
                var oBr = new BRSVMC_PROV();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(Obj.EditValue);
                var oList = oBr.Get_SVPR_PROV_LIST(oBe);

                lueCOD_PROV_DIRE_FISC.Properties.DataSource = oList;
                lueCOD_PROV_DIRE_FISC.Properties.Columns.Clear();
                lueCOD_PROV_DIRE_FISC.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROV", 100, "Provincia"));
                lueCOD_PROV_DIRE_FISC.Properties.DisplayMember = "ALF_PROV";
                lueCOD_PROV_DIRE_FISC.Properties.ValueMember = "COD_PROV";
                if (lueCOD_PROV_DIRE_FISC.EditValue != null)
                {
                    var oBeP = new BESVMC_DIST();
                    var oBrP = new BRSVMC_DIST();

                    oBeP.NUM_ACCI = 5;
                    oBeP.COD_DEPA = Convert.ToString(lueCOD_DEPA_DIRE_FISC.EditValue);
                    oBeP.COD_PROV = Convert.ToString(lueCOD_PROV_DIRE_FISC.EditValue);
                    var oListP = oBrP.Get_SVPR_DIST_LIST(oBeP);

                    lueCOD_DIST_DIRE_FISC.Properties.DataSource = oListP;
                    lueCOD_DIST_DIRE_FISC.Properties.Columns.Clear();
                    lueCOD_DIST_DIRE_FISC.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                    lueCOD_DIST_DIRE_FISC.Properties.DisplayMember = "ALF_DIST";
                    lueCOD_DIST_DIRE_FISC.Properties.ValueMember = "COD_DIST";
                }
                else
                {
                    lueCOD_DIST_DIRE_FISC.Properties.DataSource = null;
                }
            }
            else
            {
                lueCOD_PROV_DIRE_FISC.Properties.DataSource = null;
                lueCOD_DIST_DIRE_FISC.Properties.DataSource = null;
            }
        }

        private void lueCOD_PROV_DIRE_FISC_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DIST();
                var oBr = new BRSVMC_DIST();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(lueCOD_DEPA_DIRE_FISC.EditValue);
                oBe.COD_PROV = Convert.ToString(lueCOD_PROV_DIRE_FISC.EditValue);
                var oList = oBr.Get_SVPR_DIST_LIST(oBe);

                lueCOD_DIST_DIRE_FISC.Properties.DataSource = oList;
                lueCOD_DIST_DIRE_FISC.Properties.Columns.Clear();
                lueCOD_DIST_DIRE_FISC.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                lueCOD_DIST_DIRE_FISC.Properties.DisplayMember = "ALF_DIST";
                lueCOD_DIST_DIRE_FISC.Properties.ValueMember = "COD_DIST";
            }
            else
            {
                lueCOD_DIST_DIRE_FISC.Properties.DataSource = null;
            }
        }

        private void lueCOD_PAIS_DIRE_RECE_FACT_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DEPA();
                var oBr = new BRSVMC_DEPA();

                oBe.NUM_ACCI = 5;
                oBe.COD_PAIS = Convert.ToInt32(Obj.EditValue);
                var oList = oBr.Get_SVPR_DEPA_LIST(oBe);

                lueCOD_DEPA_DIRE_RECE_FACT.Properties.DataSource = oList;
                lueCOD_DEPA_DIRE_RECE_FACT.Properties.Columns.Clear();
                lueCOD_DEPA_DIRE_RECE_FACT.Properties.Columns.Add(new LookUpColumnInfo("ALF_DEPA", 100, "Departamento"));
                lueCOD_DEPA_DIRE_RECE_FACT.Properties.DisplayMember = "ALF_DEPA";
                lueCOD_DEPA_DIRE_RECE_FACT.Properties.ValueMember = "COD_DEPA";
            }
            else
            {
                lueCOD_DEPA_DIRE_RECE_FACT.Properties.DataSource = null;
            }
        }

        private void lueCOD_DEPA_DIRE_RECE_FACT_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_PROV();
                var oBr = new BRSVMC_PROV();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(Obj.EditValue);
                var oList = oBr.Get_SVPR_PROV_LIST(oBe);

                lueCOD_PROV_DIRE_RECE_FACT.Properties.DataSource = oList;
                lueCOD_PROV_DIRE_RECE_FACT.Properties.Columns.Clear();
                lueCOD_PROV_DIRE_RECE_FACT.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROV", 100, "Provincia"));
                lueCOD_PROV_DIRE_RECE_FACT.Properties.DisplayMember = "ALF_PROV";
                lueCOD_PROV_DIRE_RECE_FACT.Properties.ValueMember = "COD_PROV";
                if (lueCOD_PROV_DIRE_RECE_FACT.EditValue != null)
                {
                    var oBeP = new BESVMC_DIST();
                    var oBrP = new BRSVMC_DIST();

                    oBeP.NUM_ACCI = 5;
                    oBeP.COD_DEPA = Convert.ToString(lueCOD_DEPA_DIRE_RECE_FACT.EditValue);
                    oBeP.COD_PROV = Convert.ToString(lueCOD_PROV_DIRE_RECE_FACT.EditValue);
                    var oListP = oBrP.Get_SVPR_DIST_LIST(oBeP);

                    lueCOD_DIST_DIRE_RECE_FACT.Properties.DataSource = oListP;
                    lueCOD_DIST_DIRE_RECE_FACT.Properties.Columns.Clear();
                    lueCOD_DIST_DIRE_RECE_FACT.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                    lueCOD_DIST_DIRE_RECE_FACT.Properties.DisplayMember = "ALF_DIST";
                    lueCOD_DIST_DIRE_RECE_FACT.Properties.ValueMember = "COD_DIST";
                }
                else
                {
                    lueCOD_DIST_DIRE_RECE_FACT.Properties.DataSource = null;
                }
            }
            else
            {
                lueCOD_PROV_DIRE_RECE_FACT.Properties.DataSource = null;
                lueCOD_DIST_DIRE_RECE_FACT.Properties.DataSource = null;
            }
        }

        private void lueCOD_PROV_DIRE_RECE_FACT_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit Obj = (LookUpEdit)sender;

            if (Obj.EditValue != null)
            {
                var oBe = new BESVMC_DIST();
                var oBr = new BRSVMC_DIST();

                oBe.NUM_ACCI = 5;
                oBe.COD_DEPA = Convert.ToString(lueCOD_DEPA_DIRE_RECE_FACT.EditValue);
                oBe.COD_PROV = Convert.ToString(lueCOD_PROV_DIRE_RECE_FACT.EditValue);
                var oList = oBr.Get_SVPR_DIST_LIST(oBe);

                lueCOD_DIST_DIRE_RECE_FACT.Properties.DataSource = oList;
                lueCOD_DIST_DIRE_RECE_FACT.Properties.Columns.Clear();
                lueCOD_DIST_DIRE_RECE_FACT.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
                lueCOD_DIST_DIRE_RECE_FACT.Properties.DisplayMember = "ALF_DIST";
                lueCOD_DIST_DIRE_RECE_FACT.Properties.ValueMember = "COD_DIST";
            }
            else
            {
                lueCOD_DIST_DIRE_RECE_FACT.Properties.DataSource = null;
            }
        }

        private void xfBusinessPartner_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfBusinessPartner_Activated(object sender, EventArgs e)
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

        private void xfBusinessPartner_Deactivate(object sender, EventArgs e)
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

        public void Save()
        {
            try
            {
                var oBe = new BESVMC_SOCI_NEGO();
                var oBr = new BRSVMC_SOCI_NEGO();

                if (lueCOD_TIPO_SOCI.Properties.ReadOnly)
                    throw new ArgumentException("Habilite la opción para nuevo asociado");
                if (lueCOD_TIPO_SOCI.EditValue == null)
                    throw new ArgumentException("Seleccione el tipo de asociado");
                if (string.IsNullOrEmpty(txtALF_NOMB.Text))
                    throw new ArgumentException("Ingrese nombre para el socio de negocio");
                if (lueCOD_TIPO_IDEN.EditValue == null)
                    throw new ArgumentException("Seleccione el tipo de identificación");
                if (string.IsNullOrEmpty(txtALF_NUME_IDEN.Text))
                    throw new ArgumentException("Ingrese el numero de la identificación");

                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_SOCI_NEGO=Convert.ToInt32(txtCOD_SOCI_NEGO.Text);
                }

                if (lueCOD_EJEC_COME.EditValue != null)
                    oBe.COD_EJEC_COME = Convert.ToInt32(lueCOD_EJEC_COME.EditValue);
                if (lueCOD_COND_PAGO.EditValue != null)
                    oBe.COD_COND_PAGO = Convert.ToInt32(lueCOD_COND_PAGO.EditValue);
                if (lueCOD_PAIS_DIRE_FISC.EditValue != null)
                    oBe.COD_PAIS_DIRE_FISC = Convert.ToInt32(lueCOD_PAIS_DIRE_FISC.EditValue);
                if (lueCOD_PAIS_DIRE_FACT.EditValue != null)
                    oBe.COD_PAIS_DIRE_FACT = Convert.ToInt32(lueCOD_PAIS_DIRE_FACT.EditValue);

                oBe.COD_TIPO_SOCI = Convert.ToInt32(lueCOD_TIPO_SOCI.EditValue);
                oBe.ALF_NOMB = txtALF_NOMB.Text;
                oBe.COD_TIPO_IDEN = Convert.ToInt32(lueCOD_TIPO_IDEN.EditValue);
                oBe.ALF_NUME_IDEN = txtALF_NUME_IDEN.Text;
                oBe.ALF_DIRE_FISC = txtALF_DIRE_FISC.Text;
                oBe.COD_DEPA_DIRE_FISC = lueCOD_DEPA_DIRE_FISC.EditValue == null ? null : lueCOD_DEPA_DIRE_FISC.EditValue.ToString();
                oBe.COD_PROV_DIRE_FISC = lueCOD_PROV_DIRE_FISC.EditValue == null ? null : lueCOD_PROV_DIRE_FISC.EditValue.ToString();
                oBe.COD_DIST_DIRE_FISC = lueCOD_DIST_DIRE_FISC.EditValue == null ? null : lueCOD_DIST_DIRE_FISC.EditValue.ToString();

                oBe.ALF_DIRE_RECE_FACT = txtALF_DIRE_RECE_FACT.Text;
                oBe.COD_DEPA_RECE_FACT = lueCOD_DEPA_DIRE_RECE_FACT.EditValue == null ? null : lueCOD_DEPA_DIRE_RECE_FACT.EditValue.ToString();
                oBe.COD_PROV_RECE_FACT = lueCOD_PROV_DIRE_RECE_FACT.EditValue == null ? null : lueCOD_PROV_DIRE_RECE_FACT.EditValue.ToString();
                oBe.COD_DIST_RECE_FACT = lueCOD_DIST_DIRE_RECE_FACT.EditValue == null ? null : lueCOD_DIST_DIRE_RECE_FACT.EditValue.ToString();
                oBe.ALF_TELE = txtALF_TELE.Text;
                oBe.ALF_FAXX = txtALF_FAXX.Text;

                gdvContacts.CloseEditor();
                gdvContacts.RefreshData();
                gdvBranch.CloseEditor();
                gdvBranch.RefreshData();

                oBe.LST_CONT = (List<BESVMD_SOCI_NEGO_CONT>)gdcContacts.DataSource;
                oBe.LST_SUCU = (List<BESVMD_SOCI_NEGO_SUCU>)gdcBranch.DataSource;
                oBe.LST_SUCU.RemoveAll(item => string.IsNullOrWhiteSpace(item.ALF_SUCU));

                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;

                oBr.Set_SVPR_SOCI_NEGO(oBe);

                txtCOD_SOCI_NEGO.Text = oBe.COD_SOCI_NEGO.ToString();
                StateControl(true);
                XtraMessageBox.Show("Operacion realizada con exito!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void AddItemContact()
        {
            try
            {
                oListCont.Add(new BESVMD_SOCI_NEGO_CONT { COD_SOCI_NEGO_SUCU=gdvBranch.FocusedRowHandle});
                gdvContacts.RefreshData();
                gdvContacts.FocusedRowHandle = gdvContacts.RowCount - 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveItemContact()
        {
            try
            {
                var oBe = ((BESVMD_SOCI_NEGO_CONT)gdvContacts.GetRow(gdvContacts.FocusedRowHandle));
                DialogResult oResult = XtraMessageBox.Show("Seguro que desea eliminar el Item?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (oResult == DialogResult.Yes)
                {
                    oListCont.Remove(oBe);
                    if (oListCont.Count == 0)
                        oListCont.Add(new BESVMD_SOCI_NEGO_CONT());
                }
                gdvContacts.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            lueCOD_TIPO_SOCI.Focus();
        }

        public void Edit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("No existe ningún registro seleccionado");
                StateControl(false);
                lueCOD_TIPO_SOCI.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }

        private void ClearControl()
        {
            txtCOD_SOCI_NEGO.Text = "";
            lueCOD_TIPO_SOCI.EditValue = null;
            txtALF_NOMB.Text = "";
            lueCOD_TIPO_IDEN.EditValue = null;
            txtALF_NUME_IDEN.Text = "";
            lueCOD_EJEC_COME.EditValue = null;
            lueCOD_COND_PAGO.EditValue = null;
            txtALF_DIRE_FISC.Text = "";
            lueCOD_PAIS_DIRE_FISC.EditValue = null;
            lueCOD_DEPA_DIRE_FISC.EditValue = null;
            lueCOD_PROV_DIRE_FISC.EditValue = null;
            lueCOD_DIST_DIRE_FISC.EditValue = null;
            txtALF_DIRE_RECE_FACT.Text = "";
            lueCOD_PAIS_DIRE_FACT.EditValue = null;
            lueCOD_DEPA_DIRE_RECE_FACT.EditValue = null;
            lueCOD_PROV_DIRE_RECE_FACT.EditValue = null;
            lueCOD_DIST_DIRE_RECE_FACT.EditValue = null;
            txtALF_TELE.Text = "";
            txtALF_FAXX.Text = "";

            oListCont.Clear();
            gdvContacts.RefreshData();
            oListBranch.Clear();
            gdvBranch.RefreshData();
        }

        private void StateControl(bool vState)
        {
            txtCOD_SOCI_NEGO.Properties.ReadOnly = vState;
            lueCOD_TIPO_SOCI.Properties.ReadOnly = vState;
            txtALF_NOMB.Properties.ReadOnly = vState;
            lueCOD_TIPO_IDEN.Properties.ReadOnly = vState;
            txtALF_NUME_IDEN.Properties.ReadOnly = vState;
            lueCOD_EJEC_COME.Properties.ReadOnly = vState;
            lueCOD_COND_PAGO.Properties.ReadOnly = vState;
            txtALF_DIRE_FISC.Properties.ReadOnly = vState;
            lueCOD_PAIS_DIRE_FISC.Properties.ReadOnly = vState;
            lueCOD_DEPA_DIRE_FISC.Properties.ReadOnly = vState;
            lueCOD_PROV_DIRE_FISC.Properties.ReadOnly = vState;
            lueCOD_DIST_DIRE_FISC.Properties.ReadOnly = vState;
            txtALF_DIRE_RECE_FACT.Properties.ReadOnly = vState;
            lueCOD_PAIS_DIRE_FACT.Properties.ReadOnly = vState;
            lueCOD_DEPA_DIRE_RECE_FACT.Properties.ReadOnly = vState;
            lueCOD_PROV_DIRE_RECE_FACT.Properties.ReadOnly = vState;
            lueCOD_DIST_DIRE_RECE_FACT.Properties.ReadOnly = vState;
            txtALF_TELE.Properties.ReadOnly = vState;
            txtALF_FAXX.Properties.ReadOnly = vState;

            gdcContacts.Enabled = !vState;
            gdcBranch.Enabled = !vState;
        }

        public void SearchSociNego()
        {
            try
            {
                using(var oForm = new xfSearchPerson(SESSION_COMP))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        ClearControl();
                        txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                        lueCOD_TIPO_SOCI.EditValue = oForm.oBe.COD_TIPO_SOCI;
                        txtALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                        lueCOD_TIPO_IDEN.EditValue = oForm.oBe.COD_TIPO_IDEN;
                        txtALF_NUME_IDEN.Text = oForm.oBe.ALF_NUME_IDEN;
                        lueCOD_EJEC_COME.EditValue = oForm.oBe.COD_EJEC_COME;
                        lueCOD_COND_PAGO.EditValue = oForm.oBe.COD_COND_PAGO;
                        txtALF_DIRE_FISC.Text = oForm.oBe.ALF_DIRE_FISC;
                        lueCOD_PAIS_DIRE_FISC.EditValue = oForm.oBe.COD_PAIS_DIRE_FISC;
                        lueCOD_DEPA_DIRE_FISC.EditValue = oForm.oBe.COD_DEPA_DIRE_FISC;
                        lueCOD_PROV_DIRE_FISC.EditValue = oForm.oBe.COD_PROV_DIRE_FISC;
                        lueCOD_DIST_DIRE_FISC.EditValue = oForm.oBe.COD_DIST_DIRE_FISC;
                        txtALF_DIRE_RECE_FACT.Text = oForm.oBe.ALF_DIRE_RECE_FACT;
                        lueCOD_PAIS_DIRE_FACT.EditValue = oForm.oBe.COD_PAIS_DIRE_FACT;
                        lueCOD_DEPA_DIRE_RECE_FACT.EditValue = oForm.oBe.COD_DEPA_RECE_FACT;
                        lueCOD_PROV_DIRE_RECE_FACT.EditValue = oForm.oBe.COD_PROV_RECE_FACT;
                        lueCOD_DIST_DIRE_RECE_FACT.EditValue = oForm.oBe.COD_DIST_RECE_FACT;
                        txtALF_TELE.Text = oForm.oBe.ALF_TELE;
                        txtALF_FAXX.Text = oForm.oBe.ALF_FAXX;

                        //SUCURSALES
                        var oBeS = new BESVMD_SOCI_NEGO_SUCU();
                        var oBrS = new BRSVMD_SOCI_NEGO_SUCU();

                        oBeS.COD_SOCI_NEGO = oForm.oBe.COD_SOCI_NEGO;
                        oBeS.NUM_ACCI = 5;

                        var oListS = oBrS.Get_SVPR_SOCI_NEGO_SUCU_LIST(oBeS);

                        oListS.ForEach(obj =>
                        {
                            oListBranch.Add(obj);
                        });

                        //CONTACTOS
                        var oBe = new BESVMD_SOCI_NEGO_CONT();
                        var oBr = new BRSVMD_SOCI_NEGO_CONT();

                        oBe.COD_SOCI_NEGO = oForm.oBe.COD_SOCI_NEGO;
                        oBe.NUM_ACCI = 5;

                        var oList = oBr.Get_SVPR_SOCI_NEGO_CONT_LIST(oBe);

                        oList.ForEach(obj =>
                        {
                            oListCont.Add(obj);
                        });

                        gdvContacts.RefreshData();
                        gdvBranch.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void ribeALF_PAIS_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                using (xfUbigeoDireccion oForm = new xfUbigeoDireccion(SESSION_COMP))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).COD_PAIS = Convert.ToInt32(oForm.lueCOD_PAIS.EditValue);
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).ALF_PAIS = oForm.lueCOD_PAIS.Text;
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).COD_DEPA = oForm.luePopCOD_DEPA.EditValue==null?"":oForm.luePopCOD_DEPA.EditValue.ToString();
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).ALF_DEPA = oForm.luePopCOD_DEPA.EditValue == null ? "" : oForm.luePopCOD_DEPA.Text;
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).COD_PROV = oForm.luePopCOD_PROV.EditValue == null ? "" : oForm.luePopCOD_PROV.EditValue.ToString();
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).ALF_PROV = oForm.luePopCOD_PROV.EditValue == null ? "" : oForm.luePopCOD_PROV.Text;
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).COD_DIST = oForm.luePopCOD_DIST.EditValue == null ? "" : oForm.luePopCOD_DIST.EditValue.ToString();
                        ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle)).ALF_DIST = oForm.luePopCOD_DIST.EditValue == null ? "" : oForm.luePopCOD_DIST.Text;
                        gdvBranch.RefreshRow(gdvBranch.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddItemBranch()
        {
            try
            {
                oListBranch.Add(new BESVMD_SOCI_NEGO_SUCU{COD_SOCI_NEGO_SUCU=gdvBranch.RowCount });
                gdvBranch.RefreshData();
                gdvBranch.FocusedRowHandle = gdvBranch.RowCount - 1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveItemBranch()
        {
            try
            {
                var oBe = ((BESVMD_SOCI_NEGO_SUCU)gdvBranch.GetRow(gdvBranch.FocusedRowHandle));
                DialogResult oResult = XtraMessageBox.Show("Seguro que desea eliminar el Item?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (oResult == DialogResult.Yes)
                {
                    oListBranch.Remove(oBe);
                }
                gdvBranch.RefreshData();
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
                    var oBe = (BESVMD_SOCI_NEGO_SUCU)Grid.GetRow(e.RowHandle);
                    gdvContacts.ActiveFilter.Add(gdvContacts.Columns["COD_SOCI_NEGO_SUCU"],
                        new ColumnFilterInfo(String.Format("[COD_SOCI_NEGO_SUCU] = {0} ", oBe.COD_SOCI_NEGO_SUCU), ""));
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
                    var oBe = (BESVMD_SOCI_NEGO_SUCU)Grid.GetRow(e.FocusedRowHandle);
                    gdvContacts.ActiveFilter.Add(gdvContacts.Columns["COD_SOCI_NEGO_SUCU"],
                        new ColumnFilterInfo(String.Format("[COD_SOCI_NEGO_SUCU] = {0} ", oBe.COD_SOCI_NEGO_SUCU), ""));
                }
            }
        }
    }
}