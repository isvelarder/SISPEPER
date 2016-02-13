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
using BusinessRules.Generics;
using BusinessEntities.Sales;
using DevExpress.XtraEditors.Controls;
using BusinessEntities.Warehouse;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using BusinessRules.Sales;
using BusinessEntities.Generics;
using BusinessEntities.Management;
using BusinessRules.Management;
using BusinessRules.Tool;
using BusinessEntities.Purchase;
using DevExpress.XtraReports.UI;
using BusinessRules.Purchase;

namespace SISPEPERS.Sales
{
    public partial class xfQuote : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string SESSION_IMPU { get; set; }
        public decimal SESSION_PORC_IMPU { get; set; }
        public string FORM_SUBO { get; set; }
        public List<BESVTD_COTI> oListArti;
        public List<BESVTD_COTI> oListArtiGroup;
        public List<BESVTD_COTI_GROU> oListGroup;

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfQuote mSgIns;
        public static xfQuote SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfQuote();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfQuote()
        {
            InitializeComponent();
            oListArti = new List<BESVTD_COTI>();
            oListArtiGroup = new List<BESVTD_COTI>();
            oListGroup = new List<BESVTD_COTI_GROU>();
        }

        private void ClearControl()
        {
            txtCOD_SOCI_NEGO.Text = "";
            beALF_NOMB.Text = "";
            txtALF_DIRE_FISC.Text = "";
            txtALF_TELE.Text = "";
            txtALF_FAXX.Text = "";
            txtALF_CONT.Text = "";
            txtALF_ATEN.Text = "";
            lueCOD_SUCU.EditValue = null;
            lueCOD_MONE.EditValue = 2;
            lueCOD_PROY.EditValue = null;
            lkeCOD_MOTI.EditValue = null;
            txtNUM_DESC.Text = "0%";
            txtNUM_COTI.Text = "";
            deFEC_REGI.DateTime = DateTime.Today;
            deFEC_DOCU.DateTime = DateTime.Today;
            deFEC_VENC.DateTime = DateTime.Today;
            txtALF_ESTA.Text = "";
            oListArti.Clear();
            oListGroup.Clear();
            oListArtiGroup.Clear();
            gdvArticles.RefreshData();
            gdvGroups.RefreshData();
            gdvArticlesGroup.RefreshData();
            txtNUM_CANT_ADDD.Text = "0";
            txtNUM_CANT_REMO.Text = "0";
            meALF_OBSE.Text = "";
            txtNUM_SUBT.Text = "";
            txtNUM_IGVV.Text = "";
            txtNUM_TOTA.Text = "";
            lblALF_SONN.Text = "SON: ";
            chkIGV.Checked = true;
            lueCOD_EJEC_COME.EditValue = null;
        }

        private void StateControl(bool vState)
        {
            beALF_NOMB.Enabled = !vState;
            lueCOD_SUCU.Properties.ReadOnly = vState;
            lueCOD_MONE.Properties.ReadOnly = vState;
            lueCOD_PROY.Properties.ReadOnly = vState;
            txtNUM_DESC.Properties.ReadOnly = vState;
            deFEC_DOCU.Properties.ReadOnly = vState;
            deFEC_VENC.Properties.ReadOnly = vState;
            txtALF_ATEN.Properties.ReadOnly = vState;
            gdcArticles.Enabled = !vState;
            gdcGroups.Enabled = !vState;
            gdcArticlesGroup.Enabled = !vState;
            txtNUM_CANT_ADDD.Properties.ReadOnly = vState;
            txtNUM_CANT_REMO.Properties.ReadOnly = vState;
            meALF_OBSE.Properties.ReadOnly = vState;
            lkeCOD_MOTI.Properties.ReadOnly = vState;
            mmoALF_COND_COME.Properties.ReadOnly = vState;
            sbADD.Enabled = !vState;
            sbREMOVE.Enabled = !vState;
            chkIGV.Properties.ReadOnly = vState;
            lueCOD_EJEC_COME.Properties.ReadOnly = vState;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_ESTA.Text = "PENDIENTE";
            beALF_NOMB.Focus();
        }

        public void Edit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_COTI.Text))
                    throw new ArgumentException("No esta seleccionada nunguna cotización");
                if (txtALF_ESTA.Text.Equals("CANCELADA"))
                    throw new ArgumentException("La cotización esta cancelada");
                if (txtALF_ESTA.Text.Equals("APROBADA"))
                    throw new ArgumentException("La cotización ya esta aprobada");

                StateControl(false);
                beALF_NOMB.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Duplicate()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_COTI.Text))
                    throw new ArgumentException("No esta seleccionada nunguna cotización");
                StateControl(false);
                txtNUM_COTI.Text = "";
                txtALF_ESTA.Text = "";
                deFEC_DOCU.DateTime = DateTime.Today;
                deFEC_REGI.DateTime = DateTime.Today;
                deFEC_VENC.DateTime = DateTime.Today;
                beALF_NOMB.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }

        public void Save()
        {
            try
            {
                gdvArticles.CloseEditor();
                gdvArticles.RefreshData();
                gdvGroups.CloseEditor();
                gdvGroups.RefreshData();
                if (txtALF_ESTA.Text.Equals("CANCELADA"))
                    throw new ArgumentException("La cotización esta cancelada");
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("Seleccione un cliente");
                if (lueCOD_SUCU.EditValue == null)
                    throw new ArgumentException("Seleccione la sucursal");
                if (string.IsNullOrEmpty(lueCOD_SUCU.Text))
                    throw new ArgumentException("Seleccione la sucursal");
                if (oListArti.Count == 0 && oListArtiGroup.Count == 0)
                    throw new ArgumentException("Agregar articulos a la lista");
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione la moneda");
                if (lueCOD_PROY.EditValue == null)
                    throw new ArgumentException("Seleccione el proyecto");
                if (lkeCOD_MOTI.EditValue == null)
                    throw new ArgumentException("Seleccione el motivo");
                if (lueCOD_EJEC_COME.EditValue == null)
                    throw new ArgumentException("Seleccione el ejecutivo comercial");
                if (string.IsNullOrEmpty(txtALF_ATEN.Text))
                    throw new ArgumentException("Ingrese el data correspondiente a atención con un minimo de 6 caracteres.");
                if (txtALF_ATEN.Text.Length<6)
                    throw new ArgumentException("Ingrese el data correspondiente a atención con un minimo de 6 caracteres.");

                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();

                if (string.IsNullOrEmpty(txtNUM_COTI.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_COTI = Convert.ToInt32(txtNUM_COTI.Text);
                    oBe.COD_DOCU_SECU = oBe.COD_COTI;
                }

                oBe.COD_SOCI_NEGO = Convert.ToInt32(txtCOD_SOCI_NEGO.Text);
                oBe.ALF_NOMB = beALF_NOMB.Text;
                oBe.ALF_DIRE = txtALF_DIRE_FISC.Text;
                oBe.ALF_CONT = txtALF_CONT.Text;
                oBe.COD_SUCU = Convert.ToInt32(lueCOD_SUCU.EditValue);
                oBe.COD_MONE = Convert.ToInt32(lueCOD_MONE.EditValue);
                oBe.NUM_DESC = Convert.ToDecimal(txtNUM_DESC.Text.Replace("%", ""));
                oBe.FEC_DOCU = deFEC_DOCU.DateTime;
                oBe.FEC_VENC = deFEC_VENC.DateTime;

                oBe.LST_COTI = oListArti;
                oBe.LST_COTI_GROU = oListGroup;
                oBe.LST_COTI_ARTI_GROU = oListArtiGroup;

                oBe.NUM_SUBT = decimal.Parse(txtNUM_SUBT.Text);
                oBe.NUM_IGVV = decimal.Parse(txtNUM_IGVV.Text);
                oBe.NUM_TOTA = decimal.Parse(txtNUM_TOTA.Text);

                oBe.ALF_OBSE = meALF_OBSE.Text;
                oBe.ALF_TOTA = lblALF_SONN.Text;
                oBe.COD_TIPO_DOCU = 1;
                oBe.COD_PROY=Convert.ToInt32(lueCOD_PROY.EditValue);
                oBe.ALF_ATEN = txtALF_ATEN.Text;
                oBe.COD_MOTI = Convert.ToInt32(lkeCOD_MOTI.EditValue);

                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;
                oBe.ALF_COND_COME = mmoALF_COND_COME.Text.Trim();
                oBe.COD_EJEC_COME = Convert.ToInt32(lueCOD_EJEC_COME.EditValue);
                oBe.IND_IMPU = chkIGV.Checked;

                oBr.Set_SVPR_COTI(oBe);

                txtNUM_COTI.Text = oBe.COD_DOCU_SECU.ToString();
                StateControl(true);

                XtraMessageBox.Show("Operación realizada con exito!!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Annul()
        {
            try
            {
                if (txtALF_ESTA.Text.Equals("CANCELADA"))
                    throw new ArgumentException("La cotización esta cancelada");
                if (string.IsNullOrEmpty(txtNUM_COTI.Text))
                    throw new ArgumentException("Seleccione una cotización");
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("Seleccione un cliente");
                if (lueCOD_SUCU.EditValue == null)
                    throw new ArgumentException("Seleccione la sucursal");
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione la moneda");

                if (XtraMessageBox.Show("Seguro que desea cancelar la cotización?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var oBe = new BESVTC_COTI();
                    var oBr = new BRSVTC_COTI();

                    oBe.NUM_ACCI = 3;
                    oBe.COD_DOCU_SECU = Convert.ToInt32(txtNUM_COTI.Text);

                    oBe.COD_SOCI_NEGO = Convert.ToInt32(txtCOD_SOCI_NEGO.Text);
                    oBe.ALF_NOMB = beALF_NOMB.Text;
                    oBe.ALF_DIRE = txtALF_DIRE_FISC.Text;
                    oBe.ALF_CONT = txtALF_CONT.Text;
                    oBe.COD_SUCU = Convert.ToInt32(lueCOD_SUCU.EditValue);
                    oBe.COD_MONE = Convert.ToInt32(lueCOD_MONE.EditValue);
                    oBe.NUM_DESC = Convert.ToDecimal(txtNUM_DESC.Text.Replace("%", ""));
                    oBe.FEC_DOCU = deFEC_DOCU.DateTime;
                    oBe.FEC_VENC = deFEC_VENC.DateTime;

                    oBe.LST_COTI = oListArti;
                    oBe.LST_COTI_GROU = oListGroup;
                    oBe.LST_COTI_ARTI_GROU = oListArtiGroup;

                    oBe.NUM_SUBT = decimal.Parse(txtNUM_SUBT.Text);
                    oBe.NUM_IGVV = decimal.Parse(txtNUM_IGVV.Text);
                    oBe.NUM_TOTA = decimal.Parse(txtNUM_TOTA.Text);

                    oBe.ALF_OBSE = meALF_OBSE.Text;
                    oBe.ALF_TOTA = lblALF_SONN.Text;

                    oBe.COD_TIPO_DOCU = 1;
                    oBe.COD_USUA_CREA = SESSION_USER;
                    oBe.COD_USUA_MODI = SESSION_USER;
                    oBe.COD_COMP = SESSION_COMP;

                    oBr.Set_SVPR_COTI(oBe);

                    txtNUM_COTI.Text = oBe.COD_COTI.ToString();
                    txtALF_ESTA.Text = "CANCELADA";
                    StateControl(true);

                    XtraMessageBox.Show("Operación realizada con exito!!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xfQuote_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;
            SESSION_IMPU = ((xfMain)MdiParent).SESSION_IMPU;
            SESSION_PORC_IMPU = ((xfMain)MdiParent).SESSION_PORC_IMPU;
            lblALF_IMPU.Text = SESSION_IMPU;

            //MONEDAS
            var oBeMo = new BESVMC_MONE();
            var oBrMo = new BRSVMC_MONE();

            oBeMo.NUM_ACCI = 4;
            oBeMo.COD_COMP = SESSION_COMP;
            var oListMo = oBrMo.Get_SVPR_MONE_LIST(oBeMo);

            lueCOD_MONE.Properties.DataSource = oListMo;
            lueCOD_MONE.Properties.Columns.Clear();
            lueCOD_MONE.Properties.Columns.Add(new LookUpColumnInfo("ALF_MONE", 100, "Moneda"));
            lueCOD_MONE.Properties.DisplayMember = "ALF_MONE";
            lueCOD_MONE.Properties.ValueMember = "COD_MONE";
            //PROYECTOS
            var oBePr = new BESVMC_PROY();
            var oBrPr = new BRSVMC_PROY();

            oBePr.NUM_ACCI = 5;
            oBePr.COD_COMP = SESSION_COMP;
            var oListPr = oBrPr.Get_SVPR_PROY_LIST(oBePr);

            lueCOD_PROY.Properties.DataSource = oListPr;
            lueCOD_PROY.Properties.Columns.Clear();
            lueCOD_PROY.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROY", 100, "Proyecto"));
            lueCOD_PROY.Properties.DisplayMember = "ALF_PROY";
            lueCOD_PROY.Properties.ValueMember = "COD_PROY";
            //MOTIVOS
            var oBeM = new BEReason();
            oBeM.COD_COMP = SESSION_COMP;
            oBeM.COD_TIPO_MOTI = 2;
            oBeM.NUM_ACCI = 4;
            var obrmo = new BRSVMC_MOTI();
            var olsmo = obrmo.Get_SVPR_MOTI_LIST(oBeM);
            lkeCOD_MOTI.Properties.DataSource = olsmo;
            lkeCOD_MOTI.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_MOTI", "Motivo", 20);
            lkeCOD_MOTI.Properties.Columns.Add(lkci);
            lkeCOD_MOTI.Properties.DisplayMember = "ALF_MOTI";
            lkeCOD_MOTI.Properties.ValueMember = "COD_MOTI";
            //EJECUTIVO COMERCIAL
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

            gdcArticles.DataSource = oListArti;
            gdcArticlesGroup.DataSource = oListArtiGroup;
            gdcGroups.DataSource = oListGroup;

            StateControl(true);
        }

        private void xfQuote_Activated(object sender, EventArgs e)
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

        private void xfQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfQuote_Deactivate(object sender, EventArgs e)
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

        private void beALF_SOCI_NEGO_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            using (xfSearchPerson oForm = new xfSearchPerson(SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                    LoadBranch(oForm.oBe.COD_SOCI_NEGO);
                }
            }
        }

        private void LoadBranch(int COD_SOCI_NEGO)
        {
            var oBeTC = new BESVMD_SOCI_NEGO_SUCU();
            var oBrTC = new BRSVMD_SOCI_NEGO_SUCU();

            oBeTC.NUM_ACCI = 5;
            oBeTC.COD_SOCI_NEGO = COD_SOCI_NEGO;
            var oListTC = oBrTC.Get_SVPR_SOCI_NEGO_SUCU_LIST(oBeTC);

            lueCOD_SUCU.Properties.DataSource = oListTC;
            lueCOD_SUCU.Properties.Columns.Clear();
            lueCOD_SUCU.Properties.Columns.Add(new LookUpColumnInfo("ALF_SUCU", 100, "Sucursal"));
            lueCOD_SUCU.Properties.DisplayMember = "ALF_SUCU";
            lueCOD_SUCU.Properties.ValueMember = "COD_SOCI_NEGO_SUCU";
        }

        private void ALF_TOTA(decimal Num)
        {
            try
            {
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione la moneda");

                var SIMB = (BESVMC_MONE)lueCOD_MONE.GetSelectedDataRow();
                var molt = new BRNumLetter();
                lblALF_SONN.Text = molt.Convertir(Num.ToString(), true, SIMB.ALF_MONE_SIMB);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void RemoveArticle()
        {
            if (gdvArticles.RowCount > 0)
            {
                oListArti.Remove((BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle));
            }
            gdvArticles.RefreshData();
            txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
            txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked?SESSION_PORC_IMPU:Convert.ToDecimal("0.00"))).ToString("#,##0.00");
            txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
            ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
        }

        public void AddArticle()
        {
            try
            {
                var obr = new BRPurchase();
                var TIPO_CAMB = obr.Get_PSGN_SPLS_SVMC_TIPO_CAMB(SESSION_COMP, 1);
                using(var oForm = new xfSearchArticleSales(SESSION_COMP))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        var oBe = new BESVTD_COTI();
                        oBe.COD_ARTI = oForm.oBe.COD_ARTI;
                        oBe.ALF_CODI_ARTI = oForm.oBe.ALF_CODI_ARTI;
                        oBe.ALF_ARTI = oForm.oBe.ALF_ARTI;
                        if (lueCOD_MONE.EditValue.ToString().Equals("2"))
                        {
                            oBe.NUM_PREC_UNIT = oForm.oBe.NUM_PREC;
                        }
                        else
                        {
                            oBe.NUM_PREC_UNIT = Math.Round(oForm.oBe.NUM_PREC*TIPO_CAMB,2);
                        }

                        oBe.NUM_PORC_DESC = Convert.ToDecimal(txtNUM_DESC.Text.Replace("%", ""));
                        oBe.NUM_DESC = oBe.NUM_PREC_UNIT * decimal.Round((oBe.NUM_PORC_DESC/decimal.Parse("100.00")),2);
                        oBe.NUM_CANT = 1;
                        oBe.NUM_IMPO = oBe.NUM_CANT * (oBe.NUM_PREC_UNIT - (oBe.NUM_PREC_UNIT * decimal.Round((oBe.NUM_PORC_DESC / decimal.Parse("100.00")), 2)));
                        oListArti.Add(oBe);
                        gdvArticles.RefreshData();
                        txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                        txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked?SESSION_PORC_IMPU:Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                        txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                        ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gdvArticles_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount>0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(e.RowHandle);
                    oBe.NUM_DESC = oBe.NUM_PREC_UNIT * decimal.Round((oBe.NUM_PORC_DESC / decimal.Parse("100.00")), 2);
                    oBe.NUM_IMPO=oBe.NUM_CANT*(oBe.NUM_PREC_UNIT-oBe.NUM_DESC);
                    ((BESVTD_COTI)Grid.GetRow(e.RowHandle)).NUM_DESC = oBe.NUM_DESC;
                    ((BESVTD_COTI)Grid.GetRow(e.RowHandle)).NUM_IMPO = oBe.NUM_IMPO;
                    txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                    txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked?SESSION_PORC_IMPU:Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                    txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                    txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                    ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
                }
            }
        }

        private void gdvArticles_Click(object sender, EventArgs e)
        {
            GridView Grid = (GridView)sender;
            if (Grid.RowCount > 0)
            {
                if (Grid.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(Grid.FocusedRowHandle);
                    txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                }
            }
        }

        private void gdvArticles_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;
            if (Grid.RowCount > 0)
            {
                if (Grid.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(Grid.FocusedRowHandle);
                    txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                }
            }
        }

        private void gdvArticles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;
            if (Grid.RowCount > 0)
            {
                if (Grid.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(Grid.FocusedRowHandle);
                    txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                }
            }
        }

        private void gdvArticlesGroup_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;
            if (Grid.RowCount > 0)
            {
                if (Grid.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(Grid.FocusedRowHandle);
                    txtNUM_CANT_REMO.Text = oBe.NUM_CANT.ToString();
                }
            }
        }

        private void gdvArticlesGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;
            if (Grid.RowCount > 0)
            {
                if (Grid.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(Grid.FocusedRowHandle);
                    txtNUM_CANT_REMO.Text = oBe.NUM_CANT.ToString();
                }
            }
        }

        private void sbADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvGroups.RowCount == 0)
                    throw new ArgumentException("No existen kit definidos");
                if (gdvArticles.RowCount > 0)
                {
                    if (gdvArticles.FocusedRowHandle >= 0)
                    {
                        var oBeA = new BESVTD_COTI();
                        var oBe = (BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle);

                        oBeA.COD_ARTI = oBe.COD_ARTI;
                        oBeA.ALF_CODI_ARTI = oBe.ALF_CODI_ARTI;
                        oBeA.ALF_ARTI = oBe.ALF_ARTI;
                        oBeA.NUM_PREC_UNIT = oBe.NUM_PREC_UNIT;
                        oBeA.NUM_PORC_DESC = oBe.NUM_PORC_DESC;
                        oBeA.NUM_DESC = oBe.NUM_DESC;
                        oBeA.NUM_CANT = oBe.NUM_CANT;

                        if (oBeA.NUM_CANT < Convert.ToInt32(txtNUM_CANT_ADDD.Text))
                            throw new ArgumentException("No existe la cantidad suficiente");

                        oBeA.COD_COTI_GROU = ((BESVTD_COTI_GROU)gdvGroups.GetRow(gdvGroups.FocusedRowHandle)).COD_COTI_GROU;
                        ((BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle)).NUM_CANT = oBeA.NUM_CANT - Convert.ToInt32(txtNUM_CANT_ADDD.Text);
                        
                        if (((BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle)).NUM_CANT == 0)
                        {
                            oListArti.Remove(oBe);
                        }
                        oBeA.NUM_CANT = Convert.ToInt32(txtNUM_CANT_ADDD.Text);
                        oBeA.NUM_IMPO = oBeA.NUM_CANT * (oBeA.NUM_PREC_UNIT - oBeA.NUM_DESC);
                        oBe.NUM_IMPO = oBe.NUM_CANT * (oBe.NUM_PREC_UNIT - oBe.NUM_DESC);
                        txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                        //if (oListArtiGroup.Count(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU) > 0)
                        //{
                        //    oListArtiGroup.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_CANT = oListArtiGroup.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_CANT + oBeA.NUM_CANT;
                        //    oListArtiGroup.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_IMPO = oListArtiGroup.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_IMPO + oBeA.NUM_IMPO;
                        //}
                        //else
                        //{
                            oListArtiGroup.Add(oBeA);
                        //}

                        gdvArticlesGroup.RefreshData();
                        gdvArticles.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveGroup()
        {
            if (gdvGroups.RowCount > 0)
            {
                var oBe = (BESVTD_COTI_GROU)gdvGroups.GetRow(gdvGroups.FocusedRowHandle);
                var oList = new List<BESVTD_COTI>(oListArtiGroup);
                oList.ForEach(obj =>
                {
                    if (obj.COD_COTI_GROU == oBe.COD_COTI_GROU)
                    {
                        //if (oListArti.Count(Obj => Obj.COD_ARTI == obj.COD_ARTI) > 0)
                        //{
                        //    oListArti.Find(OBJ => OBJ.COD_ARTI == obj.COD_ARTI).NUM_CANT = oListArti.Find(OBJ => OBJ.COD_ARTI == obj.COD_ARTI).NUM_CANT + obj.NUM_CANT;
                        //    oListArti.Find(OBJ => OBJ.COD_ARTI == obj.COD_ARTI).NUM_IMPO = oListArti.Find(OBJ => OBJ.COD_ARTI == obj.COD_ARTI).NUM_IMPO + obj.NUM_IMPO;
                        //}
                        //else
                        //{
                            oListArti.Add(obj);
                        //}
                        oListArtiGroup.Remove(obj);
                    }
                });
                oListGroup.Remove(oBe);
            }
            gdvGroups.RefreshData();
            gdvArticlesGroup.RefreshData();
            gdvArticles.RefreshData();
        }

        public void AddGroup()
        {
            try
            {
                if (oListArti.Count == 0)
                    throw new ArgumentException("No existen articulos para agrupar");
                using (var oForm = new xfAddGroup())
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        oForm.oBe.COD_COTI_GROU = oListGroup.Count;
                        oForm.oBe.NUM_CANT = 1;
                        oListGroup.Add(oForm.oBe);
                    }
                }
                gdvGroups.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gdvGroups_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI_GROU)Grid.GetRow(e.FocusedRowHandle);
                    gdvArticlesGroup.ActiveFilter.Add(gdvArticlesGroup.Columns["COD_COTI_GROU"],
                        new ColumnFilterInfo(String.Format("[COD_COTI_GROU] = {0} ", oBe.COD_COTI_GROU), ""));
                }
            }
        }

        private void gdvGroups_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI_GROU)Grid.GetRow(e.RowHandle);
                    gdvArticlesGroup.ActiveFilter.Add(gdvArticlesGroup.Columns["COD_COTI_GROU"],
                        new ColumnFilterInfo(String.Format("[COD_COTI_GROU] = {0} ", oBe.COD_COTI_GROU), ""));
                }
            }
        }

        private void sbREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvArticlesGroup.RowCount > 0)
                {
                    if (gdvArticlesGroup.FocusedRowHandle >= 0)
                    {
                        var oBeA = new BESVTD_COTI();
                        var oBe = (BESVTD_COTI)gdvArticlesGroup.GetRow(gdvArticlesGroup.FocusedRowHandle);

                        oBeA.COD_ARTI = oBe.COD_ARTI;
                        oBeA.ALF_CODI_ARTI = oBe.ALF_CODI_ARTI;
                        oBeA.ALF_ARTI = oBe.ALF_ARTI;
                        oBeA.NUM_PREC_UNIT = oBe.NUM_PREC_UNIT;
                        oBeA.NUM_PORC_DESC = oBe.NUM_PORC_DESC;
                        oBeA.NUM_DESC = oBe.NUM_DESC;
                        oBeA.NUM_CANT = oBe.NUM_CANT;

                        if (oBeA.NUM_CANT < Convert.ToInt32(txtNUM_CANT_REMO.Text))
                            throw new ArgumentException("No existe la cantidad suficiente");

                        oBeA.COD_COTI_GROU = ((BESVTD_COTI_GROU)gdvGroups.GetRow(gdvGroups.FocusedRowHandle)).COD_COTI_GROU;
                        ((BESVTD_COTI)gdvArticlesGroup.GetRow(gdvArticlesGroup.FocusedRowHandle)).NUM_CANT = oBeA.NUM_CANT - Convert.ToInt32(txtNUM_CANT_REMO.Text);

                        if (((BESVTD_COTI)gdvArticlesGroup.GetRow(gdvArticlesGroup.FocusedRowHandle)).NUM_CANT == 0)
                        {
                            oListArtiGroup.Remove(oBe);
                        }
                        oBeA.NUM_CANT = Convert.ToInt32(txtNUM_CANT_REMO.Text);
                        oBeA.NUM_IMPO = oBeA.NUM_CANT * (oBeA.NUM_PREC_UNIT - oBeA.NUM_DESC);
                        oBe.NUM_IMPO = oBe.NUM_CANT * (oBe.NUM_PREC_UNIT - oBe.NUM_DESC);
                        txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                        //if (oListArti.Count(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU) > 0)
                        //{
                        //    oListArti.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_CANT = oListArti.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_CANT + oBeA.NUM_CANT;
                        //    oListArti.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_IMPO = oListArti.Find(obj => obj.COD_ARTI == oBeA.COD_ARTI && obj.COD_COTI_GROU == oBeA.COD_COTI_GROU).NUM_IMPO + oBeA.NUM_IMPO;
                        //}
                        //else
                        //{
                            oListArti.Add(oBeA);
                        //}

                        gdvArticlesGroup.RefreshData();
                        gdvArticles.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNUM_DESC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                oListArti.ForEach(obj =>
                {
                    obj.NUM_PORC_DESC = decimal.Parse(txtNUM_DESC.Text.Replace("%", ""));
                    obj.NUM_DESC = decimal.Round(obj.NUM_PREC_UNIT * decimal.Round((obj.NUM_PORC_DESC / decimal.Parse("100.00")), 2), 2);
                    obj.NUM_IMPO = decimal.Round(obj.NUM_CANT * (obj.NUM_PREC_UNIT - obj.NUM_DESC),2);
                });
                oListArtiGroup.ForEach(obj =>
                {
                    obj.NUM_PORC_DESC = decimal.Parse(txtNUM_DESC.Text.Replace("%", ""));
                    obj.NUM_DESC = decimal.Round(obj.NUM_PREC_UNIT * decimal.Round((obj.NUM_PORC_DESC / decimal.Parse("100.00")), 2), 2);
                    obj.NUM_IMPO = decimal.Round(obj.NUM_CANT * (obj.NUM_PREC_UNIT - obj.NUM_DESC), 2);
                });
                txtNUM_DESC.Text = txtNUM_DESC.Text.Replace("%", "") + "%";

                txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked?SESSION_PORC_IMPU:Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
            }
            gdvArticles.RefreshData();
            gdvArticlesGroup.RefreshData();
        }

        public void SearchQuote()
        {
            ClearControl();
            using (var oForm = new xfSearchQuote(1,SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBranch(oForm.oBe.COD_SOCI_NEGO);
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                    txtALF_DIRE_FISC.Text = oForm.oBe.ALF_DIRE;
                    txtALF_TELE.Text = "";
                    txtALF_FAXX.Text = "";
                    txtALF_CONT.Text = oForm.oBe.ALF_CONT;
                    lueCOD_SUCU.EditValue = oForm.oBe.COD_SUCU;
                    txtNUM_DESC.Text = oForm.oBe.NUM_DESC.ToString("#,##0.00");
                    txtNUM_COTI.Text = oForm.oBe.COD_COTI.ToString();
                    deFEC_REGI.EditValue = oForm.oBe.FEC_REGI;
                    deFEC_DOCU.EditValue = oForm.oBe.FEC_DOCU;
                    deFEC_VENC.EditValue = oForm.oBe.FEC_VENC;
                    txtALF_ESTA.Text = oForm.oBe.ALF_ESTA;
                    lueCOD_MONE.EditValue = oForm.oBe.COD_MONE;
                    lueCOD_PROY.EditValue = oForm.oBe.COD_PROY;
                    ALF_EJEC_COME = oForm.oBe.ALF_EJEC_COME;
                    txtALF_ATEN.Text = oForm.oBe.ALF_ATEN;
                    lkeCOD_MOTI.EditValue = oForm.oBe.COD_MOTI;
                    mmoALF_COND_COME.Text = oForm.oBe.ALF_COND_COME;
                    lueCOD_EJEC_COME.EditValue = oForm.oBe.COD_EJEC_COME;
                    chkIGV.Checked = oForm.oBe.IND_IMPU;

                    meALF_OBSE.Text = oForm.oBe.ALF_OBSE;
                    lblALF_SONN.Text = oForm.oBe.ALF_TOTA;

                    txtNUM_SUBT.Text = oForm.oBe.NUM_SUBT.ToString("#,##0.00");
                    txtNUM_IGVV.Text = oForm.oBe.NUM_IGVV.ToString("#,##0.00");
                    txtNUM_TOTA.Text = oForm.oBe.NUM_TOTA.ToString("#,##0.00");

                    var oBe = new BESVTD_COTI();
                    var oBr = new BRSVTD_COTI();

                    oBe.COD_COTI = oForm.oBe.COD_COTI;
                    oBe.NUM_ACCI = 5;
                    oBe.COD_TIPO_DOCU = 1;
                    var oList = oBr.Get_SVPR_COTI_DETA_LIST(oBe);

                    oList.ForEach(obj =>
                    {
                        oListArti.Add(obj);
                    });
                    gdvArticles.RefreshData();

                    var oBeG = new BESVTD_COTI_GROU();
                    var oBrG = new BRSVTD_COTI_GROU();

                    oBeG.COD_COTI = oForm.oBe.COD_COTI;
                    oBeG.NUM_ACCI = 5;
                    oBeG.COD_TIPO_DOCU = 1;
                    var oListG = oBrG.Get_SVPR_COTI_GROU_LIST(oBeG);

                    oListG.ForEach(obj =>
                    {
                        oListGroup.Add(obj);
                    });
                    gdvGroups.RefreshData();

                    var oBeDG = new BESVTD_COTI();
                    var oBrDG = new BRSVTD_COTI_GROU_DETA();

                    oBeDG.COD_COTI = oForm.oBe.COD_COTI;
                    oBeDG.NUM_ACCI = 5;
                    oBeDG.COD_TIPO_DOCU = 1;
                    var oListDG = oBrDG.Get_SVPR_COTI_GROU_DETA_LIST(oBeDG);

                    oListDG.ForEach(obj =>
                    {
                        oListArtiGroup.Add(obj);
                    });
                    gdvArticlesGroup.RefreshData();

                    var oBeTC = new BESVMD_SOCI_NEGO_SUCU();
                    var oBrTC = new BRSVMD_SOCI_NEGO_SUCU();

                    oBeTC.NUM_ACCI = 5;
                    oBeTC.COD_SOCI_NEGO = oForm.oBe.COD_SOCI_NEGO;
                    var oListTC = oBrTC.Get_SVPR_SOCI_NEGO_SUCU_LIST(oBeTC);

                    lueCOD_SUCU.Properties.DataSource = oListTC;
                    lueCOD_SUCU.Properties.Columns.Clear();
                    lueCOD_SUCU.Properties.Columns.Add(new LookUpColumnInfo("ALF_SUCU", 100, "Sucursal"));
                    lueCOD_SUCU.Properties.DisplayMember = "ALF_SUCU";
                    lueCOD_SUCU.Properties.ValueMember = "COD_SOCI_NEGO_SUCU";

                    lueCOD_SUCU.EditValue = oForm.oBe.COD_SUCU;
                }
            }
        }

        private void lueCOD_MONE_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCOD_MONE.EditValue != null)
            {
                if (!string.IsNullOrEmpty(txtNUM_TOTA.Text))
                    ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
                
                var obr = new BRPurchase();
                var TIPO_CAMB = obr.Get_PSGN_SPLS_SVMC_TIPO_CAMB(SESSION_COMP, 1);
                if (lueCOD_MONE.EditValue.ToString().Equals("2"))
                {
                    var lines = (List<BESVTD_COTI>)gdvArticles.DataSource;
                    if (lines == null) return;
                    lines.ForEach(item =>
                    {
                        item.NUM_PREC_UNIT = Math.Round(item.NUM_PREC_UNIT / TIPO_CAMB, 2);
                        item.NUM_DESC = Math.Round((item.NUM_PREC_UNIT * item.NUM_PORC_DESC) / 100, 2);
                        item.NUM_IMPO = item.NUM_CANT * (item.NUM_PREC_UNIT - item.NUM_DESC);
                    });
                }
                else
                {
                    var lines = (List<BESVTD_COTI>)gdvArticles.DataSource;
                    if (lines == null) return;
                    lines.ForEach(item =>
                    {
                        item.NUM_PREC_UNIT = Math.Round(item.NUM_PREC_UNIT * TIPO_CAMB, 2);
                        item.NUM_DESC = Math.Round((item.NUM_PREC_UNIT * item.NUM_PORC_DESC) / 100, 2);
                        item.NUM_IMPO = item.NUM_CANT * (item.NUM_PREC_UNIT - item.NUM_DESC);
                    });
                }
                gdvArticles.RefreshData();
                txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
            }
        }

        private void lueCOD_SUCU_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LookUpEdit combo = (LookUpEdit)sender;

                if (combo.Properties.DataSource != null && combo.EditValue != null)
                {
                    var oBe = (BESVMD_SOCI_NEGO_SUCU)combo.GetSelectedDataRow();
                    if (oBe != null)
                    {
                        txtALF_DIRE_FISC.Text = oBe.ALF_DIRE+" "+oBe.ALF_DEPA+"/"+oBe.ALF_PROV+"/"+oBe.ALF_DIST;

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Approve()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_COTI.Text))
                    throw new ArgumentException("Debe guardar la cotizacion o seleccione una correctamente");

                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtNUM_COTI.Text;
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_TIPO_DOCU = 1;
                oBe.NUM_ACCI = 6;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);

                if (!oList[0].ALF_ESTA.Equals("PENDIENTE"))
                {
                    txtALF_ESTA.Text = oList[0].ALF_ESTA;
                    throw new ArgumentException("La cotización esta " + oList[0].ALF_ESTA);
                }
                Sales.xfSalesOrder.SgIns.MdiParent = this.MdiParent;
                Sales.xfSalesOrder.SgIns.Activate();
                Sales.xfSalesOrder.SgIns.FORM_SUBO = "bbiSalesOrder";
                Sales.xfSalesOrder.SgIns.Show();
                Sales.xfSalesOrder.SgIns.BringToFront();

                Sales.xfSalesOrder.SgIns.SearchSalesOrder(int.Parse(txtNUM_COTI.Text));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lueCOD_PROY_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using(var oForm = new xfProject(SESSION_COMP,SESSION_USER))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        var oBePr = new BESVMC_PROY();
                        var oBrPr = new BRSVMC_PROY();

                        oBePr.NUM_ACCI = 5;
                        oBePr.COD_COMP = SESSION_COMP;
                        var oListPr = oBrPr.Get_SVPR_PROY_LIST(oBePr);

                        lueCOD_PROY.Properties.DataSource = oListPr;
                        lueCOD_PROY.Properties.Columns.Clear();
                        lueCOD_PROY.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROY", 100, "Proyecto"));
                        lueCOD_PROY.Properties.DisplayMember = "ALF_PROY";
                        lueCOD_PROY.Properties.ValueMember = "COD_PROY";

                        lueCOD_PROY.EditValue = oForm.oBe.COD_PROY;
                    }
                }
            }
        }
        public string ALF_EJEC_COME { get; set; }
        public void Set_Export()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNUM_COTI.Text))
                    throw new ArgumentException(_Message.MsgSelectCO);
                var split = deFEC_REGI.DateTime.ToLongDateString().Split(',');
                var oc = new xrQuote();
                var odoc = new BESVTC_COTI()
                {
                    COD_COTI = Convert.ToInt32(txtNUM_COTI.Text),
                    ALF_EJEC_COME = lueCOD_EJEC_COME.Text,
                    ALF_NOMB = beALF_NOMB.Text,
                    ALF_DIRE = txtALF_DIRE_FISC.Text,
                    ALF_PROY = lueCOD_PROY.Text,
                    NUM_SUBT = Convert.ToDecimal(txtNUM_SUBT.EditValue),
                    ALF_FECH_LARG = "Lima, " + split[1],
                    ALF_ATEN=txtALF_ATEN.Text
                };

                oc.bdsDocument.DataSource = odoc;
                var olst = (List<BESVTD_COTI>)gdvArticles.DataSource;
                var i = 1;
                olst.ForEach(item =>
                {
                    item.NUM_LINE = i;
                    i += 1;
                });
                oc.bdsDocumentLines.DataSource = olst;

                var SIMB = (BESVMC_MONE)lueCOD_MONE.GetSelectedDataRow();
                var tfs = (SIMB.ALF_MONE_SIMB == "USD") ? "{0:$ #,##0.00}" : "{0:c2}";

                oc.tlcNUM_PREC_UNIT.DataBindings["Text"].FormatString = tfs;
                oc.tlcNUM_IMPO.DataBindings["Text"].FormatString = tfs;
                oc.lblNUM_SUBT.DataBindings["Text"].FormatString = tfs;
                var ALF_COND_COME = mmoALF_COND_COME.Text;
                if (string.IsNullOrWhiteSpace(ALF_COND_COME))
                {
                    ALF_COND_COME = "1.- Los precios no incluyen IGV." + Environment.NewLine +
                                    "2.- Los precios están expresados en " + ((SIMB.ALF_MONE_SIMB == "USD") ? "Dolares Americanos." : "Nuevos Soles.") + Environment.NewLine +
                                    "3.- El pago debera ser en " + ((SIMB.ALF_MONE_SIMB == "USD") ? "Dolares Americanos." : "Nuevos Soles.") + Environment.NewLine +
                                    "4.- Entrega de la Mercancía: Dependiendo disponibilidad." + Environment.NewLine +
                                    "5.- Forma de pago: Crédito a 30 días entregado el producto." + Environment.NewLine +
                                    "6.- Vigencia de la cotización: 30 días naturales a partir de la fecha de esta cotización." + Environment.NewLine +
                                    "7.- Garantía de un año contra defectos de fabricación.";
                }
                oc.lblCOND_COME.Text = ALF_COND_COME;
                using (var printTool = new ReportPrintTool(oc))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    _Message.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void chkIGV_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit chk = (CheckEdit)sender;
            txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
            txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chk.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
            txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
            ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
        }

    }
}