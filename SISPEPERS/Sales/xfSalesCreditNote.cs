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
using DevExpress.XtraReports.UI;
using BusinessRules.Warehouse;

namespace SISPEPERS.Sales
{
    public partial class xfSalesCreditNote : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string SESSION_IMPU { get; set; }
        public decimal SESSION_PORC_IMPU { get; set; }

        public string FORM_SUBO { get; set; }
        public int COD_DVEN { get; set; }
        public List<BESVTD_COTI> oListArti;
        public List<BESVTD_COTI> oListArtiCompleted;
        public List<BESVTD_COTI> oListArtiGroup;
        public List<BESVTD_COTI_GROU> oListGroup;
        private List<BESVTC_COTI> oListGrem;

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfSalesCreditNote mSgIns;
        public static xfSalesCreditNote SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfSalesCreditNote();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        /// <summary>
        /// CONSTRUCTOR DE LA CLASE
        /// </summary>
        public xfSalesCreditNote()
        {
            InitializeComponent();
            oListArti = new List<BESVTD_COTI>();
            oListArtiCompleted = new List<BESVTD_COTI>();
            oListArtiGroup = new List<BESVTD_COTI>();
            oListGroup = new List<BESVTD_COTI_GROU>();
            oListGrem = new List<BESVTC_COTI>();
        }
        /// <summary>
        /// LIMPIAR LOS CONTROLES
        /// </summary>
        private void ClearControl()
        {
            txtCOD_SOCI_NEGO.Text = "";
            beALF_NOMB.Text = "";
            txtALF_DIRE_FISC.Text = "";
            txtALF_TELE.Text = "";
            txtALF_FAXX.Text = "";
            txtALF_CONT.Text = "";
            lueCOD_SUCU.EditValue = null;
            lueCOD_MONE.EditValue = null;
            lueCOD_ALMA.EditValue = null;
            txtNUM_DESC.Text = "0%";
            txtNUM_NCRE.Text = "";
            deFEC_REGI.DateTime = DateTime.Today;
            deFEC_DOCU.DateTime = DateTime.Today;
            deFEC_VENC.DateTime = DateTime.Today;
            txtALF_ESTA.Text = "";
            oListArti.Clear();
            oListArtiCompleted.Clear();
            oListGroup.Clear();
            oListArtiGroup.Clear();
            gdvArticles.RefreshData();
            gdvArticlesCompleted.RefreshData();
            gdvGroups.RefreshData();
            gdvArticlesGroup.RefreshData();
            txtNUM_CANT_ADDD.Text = "0";
            txtNUM_CANT_REMO.Text = "0";
            meALF_OBSE.Text = "";
            txtNUM_SUBT.Text = "";
            txtNUM_IGVV.Text = "";
            txtNUM_TOTA.Text = "";
            lblALF_SONN.Text = "";
            lueALF_SERI.EditValue = null;
            txtNUM_CORR.Text = "";
            beALF_GUIA_REMI_STOR.Text = "";
            txtALF_NUME_FACT.Text = "";
            txtALF_NUME_IDEN.Text = "";
            COD_DVEN = 0;
            //SERIES
            var oBeSe = new BESVMC_SERI_CORR();
            var oBrSe = new BRSVMC_SERI_CORR();

            oBeSe.NUM_ACCI = 5;
            oBeSe.COD_TIPO_DOCU = 3;
            oBeSe.COD_COMP = SESSION_COMP;
            var oListSe = oBrSe.Get_SVPR_SERI_CORR_LIST(oBeSe);

            lueALF_SERI.Properties.DataSource = oListSe;
            lueALF_SERI.Properties.Columns.Clear();
            lueALF_SERI.Properties.Columns.Add(new LookUpColumnInfo("ALF_SERI", 100, "Serie"));
            lueALF_SERI.Properties.DisplayMember = "ALF_SERI";
            lueALF_SERI.Properties.ValueMember = "ALF_SERI";
            chkIGV.Checked = true;
        }
        /// <summary>
        /// ACTIVAR O DESACTIVAR LOS CONTROLES
        /// </summary>
        /// <param name="vState"></param>
        private void StateControl(bool vState)
        {
            beALF_NOMB.Enabled = !vState;
            lueCOD_SUCU.Properties.ReadOnly = vState;
            lueCOD_MONE.Properties.ReadOnly = vState;
            lueCOD_ALMA.Properties.ReadOnly = true;
            txtNUM_DESC.Properties.ReadOnly = vState;
            deFEC_DOCU.Properties.ReadOnly = vState;
            deFEC_VENC.Properties.ReadOnly = vState;
            gdcArticles.Enabled = !vState;
            gdcGroups.Enabled = !vState;
            gdcArticlesGroup.Enabled = !vState;
            txtNUM_CANT_ADDD.Properties.ReadOnly = vState;
            txtNUM_CANT_REMO.Properties.ReadOnly = vState;
            meALF_OBSE.Properties.ReadOnly = vState;
            sbADD.Enabled = !vState;
            sbREMOVE.Enabled = !vState;
            beALF_GUIA_REMI_STOR.Properties.ReadOnly=true;
            lueALF_SERI.Properties.ReadOnly = vState;
            chkIGV.Properties.ReadOnly = true;
        }
        /// <summary>
        /// NUEVO
        /// </summary>
        public void New()
        {
            ClearControl();
            StateControl(false);
            gcaNUM_CANT.OptionsColumn.AllowEdit = true;
            gcaNUM_CANT.OptionsColumn.AllowFocus = true;
            gcaNUM_CANT.OptionsColumn.ReadOnly = false;
            beALF_NOMB.Focus();
        }
        /// <summary>
        /// EDITAR
        /// </summary>
        public void Edit()
        {
            return;
            try
            {
                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                    throw new ArgumentException("No esta seleccionada nunguna guia");
                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtNUM_NCRE.Text;
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_TIPO_DOCU = 4;
                oBe.NUM_ACCI = 6;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);
                txtALF_ESTA.Text = oList[0].ALF_ESTA;
                if (oList[0].ALF_ESTA.Equals("CANCELADA"))
                    throw new ArgumentException("El documento de venta esta cancelado");
                if (oList[0].ALF_ESTA.Equals("CERRADA"))
                    throw new ArgumentException("El documento de venta esta cerrado");
                if (oList[0].ALF_ESTA.Equals("APROBADA"))
                    throw new ArgumentException("El documento de venta esta aprobado");
                StateControl(false);
                beALF_NOMB.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// DESHACER
        /// </summary>
        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }
        /// <summary>
        /// GUARDAR
        /// </summary>
        public void Save()
        {
            if (lueALF_SERI.Properties.ReadOnly) return;
            try
            {
                gdvArticles.CloseEditor();
                gdvArticles.RefreshData();
                gdvGroups.CloseEditor();
                gdvGroups.RefreshData();
                gdvArticlesCompleted.CloseEditor();
                gdvArticlesCompleted.RefreshData();
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("Seleccione un cliente");
                if (lueCOD_SUCU.EditValue == null)
                    throw new ArgumentException("Seleccione la sucursal");
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione la moneda");
                if (lueALF_SERI.EditValue == null)
                    throw new ArgumentException("Seleccione la serie");
                if (string.IsNullOrEmpty(txtNUM_CORR.Text))
                    throw new ArgumentException("Defina correctamente la numeracion del documento");
                if (oListArtiCompleted.Count == 0)
                    throw new ArgumentException("No existen articulos para el documento de venta");

                if (XtraMessageBox.Show("Esta seguro de guardar la nota de credito.?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();

                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_OVEN = Convert.ToInt32(txtNUM_NCRE.Text);
                    oBe.COD_DOCU_SECU = oBe.COD_OVEN;
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
                oBe.LST_COTI_DETA = oListArtiCompleted;
                oBe.LST_COTI_GROU = oListGroup;
                oBe.LST_COTI_ARTI_GROU = oListArtiGroup;
                oBe.LST_GREM = oListGrem;

                oBe.NUM_SUBT = decimal.Parse(txtNUM_SUBT.Text);
                oBe.NUM_IGVV = decimal.Parse(txtNUM_IGVV.Text);
                oBe.NUM_TOTA = decimal.Parse(txtNUM_TOTA.Text);

                oBe.ALF_OBSE = meALF_OBSE.Text;
                oBe.ALF_TOTA = lblALF_SONN.Text;
                oBe.COD_TIPO_DOCU = 5;
                oBe.COD_DOCU_INIC = COD_DVEN;
                oBe.ALF_SERI = lueALF_SERI.EditValue.ToString();
                oBe.NUM_CORR = Convert.ToInt32(txtNUM_CORR.Text);
                oBe.IND_IMPU = chkIGV.Checked;

                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_ALMA = Convert.ToInt32(lueCOD_ALMA.EditValue);

                oBr.Set_SVPR_COTI(oBe);

                txtNUM_NCRE.Text = oBe.COD_DOCU_SECU.ToString();
                StateControl(true);

                XtraMessageBox.Show("Operación realizada con exito!!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// EVENTO LOAD DEL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNote_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;
            SESSION_IMPU = ((xfMain)MdiParent).SESSION_IMPU;
            SESSION_PORC_IMPU = ((xfMain)MdiParent).SESSION_PORC_IMPU;
            lblALF_IMPU.Text = SESSION_IMPU;


            var obral = new BRWarehouse();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);

            lueCOD_ALMA.Properties.DataSource = olsal;
            lueCOD_ALMA.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén", 20);
            lueCOD_ALMA.Properties.Columns.Add(lkci);
            lueCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            lueCOD_ALMA.Properties.ValueMember = "COD_ALMA";
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

            gdcArticles.DataSource = oListArti;
            gdcArticlesCompleted.DataSource = oListArtiCompleted;
            gdcArticlesGroup.DataSource = oListArtiGroup;
            gdcGroups.DataSource = oListGroup;

            StateControl(true);
        }
        /// <summary>
        /// AL ACTIVAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNote_Activated(object sender, EventArgs e)
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
        /// <summary>
        /// AL CERRAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }
        /// <summary>
        /// AL DESACTIVAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNote_Deactivate(object sender, EventArgs e)
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
        /// <summary>
        /// INVOCAR A LA PANTALLA PARA AGREGAR SOCIO DE NEGOCIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beALF_SOCI_NEGO_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            using (xfSearchPerson oForm = new xfSearchPerson(SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                    txtALF_NUME_IDEN.Text = oForm.oBe.ALF_NUME_IDEN;

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
        /// <summary>
        /// CALCULAR EL TOTAL EN LETRAS
        /// </summary>
        /// <param name="Num"></param>
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
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// QUITAR ARTICULO
        /// </summary>
        public void RemoveArticle()
        {
            try
            {
                if (gdvArticles.RowCount > 0)
                {
                    var COD_ARTI = ((BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle)).ALF_CODI_ARTI;
                    if (!COD_ARTI.Equals("SERVICIO"))
                        throw new ArgumentException("No se puede quitar items agregados desde la guia de remisión");
                    oListArti.Remove((BESVTD_COTI)gdvArticles.GetRow(gdvArticles.FocusedRowHandle));
                }
                ListArticleCompletedUpdate();
                gdvArticlesCompleted.RefreshData();
                gdvArticles.RefreshData();
                txtNUM_SUBT.Text = (oListArtiCompleted.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// AGREGAR ARTICULO
        /// </summary>
        public void AddArticle()
        {
            try
            {
                using (var oForm = new xfSearchArticleSales(SESSION_COMP))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        //if (oForm.oBe.ALF_CODI_ARTI.ToUpper().Equals("SERVICIO"))
                        //    throw new ArgumentException("Solo se puede agregar servicio");

                        var oBe = new BESVTD_COTI();
                        oBe.COD_ARTI = oForm.oBe.COD_ARTI;
                        oBe.ALF_CODI_ARTI = oForm.oBe.ALF_CODI_ARTI;
                        oBe.ALF_ARTI = oForm.oBe.ALF_ARTI;
                        oBe.NUM_PREC_UNIT = oForm.oBe.NUM_PREC;
                        oBe.NUM_PORC_DESC = oForm.oBe.NUM_DESC;
                        oBe.NUM_DESC = oBe.NUM_PREC_UNIT * oForm.oBe.NUM_DESC;
                        oBe.NUM_CANT = 1;
                        oBe.NUM_IMPO = oBe.NUM_CANT * (oBe.NUM_PREC_UNIT - (oBe.NUM_PREC_UNIT * oForm.oBe.NUM_DESC));
                        oListArti.Add(oBe);
                        ListArticleCompletedUpdate();
                        gdvArticlesCompleted.RefreshData();
                        gdvArticles.RefreshData();
                        txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                        txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                        txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                        ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// CELLVALUE DE LA GRILLA ARTICULOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gdvArticles_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVTD_COTI)Grid.GetRow(e.RowHandle);
                    oBe.NUM_DESC = oBe.NUM_PREC_UNIT * oBe.NUM_PORC_DESC;
                    oBe.NUM_IMPO = oBe.NUM_CANT * (oBe.NUM_PREC_UNIT - oBe.NUM_DESC);
                    ((BESVTD_COTI)Grid.GetRow(e.RowHandle)).NUM_DESC = oBe.NUM_DESC;
                    ((BESVTD_COTI)Grid.GetRow(e.RowHandle)).NUM_IMPO = oBe.NUM_IMPO;
                    txtNUM_SUBT.Text = (oListArti.Sum(obj => obj.NUM_IMPO) + oListArtiGroup.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                    txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                    txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                    txtNUM_CANT_ADDD.Text = oBe.NUM_CANT.ToString();
                    ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
                    ListArticleCompletedUpdate();
                    gdvArticlesCompleted.RefreshData();
                }
            }
        }
        /// <summary>
        /// AL REALIZAR UN CLIC EN LA GRILLA DE ARTICULOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL REALIZAR UN CLIC SOBRE LA UNA FILA DE LA GRILLA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL CAMBIAR EL FOCO DE UNA FILA EN LA GRILLA DE ARTICULOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL REALIZAR CLIC EN UNA FILA DE LA GRILLA DE GRUPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL CAMBIAR EL FOCO DE UNA FILA EN LA GRILLA DE DETALLE DEL GRUPO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL PRESIONAR EL BOTON AGREGAR AL DETALLE DEL GRUPO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_CANT_ADDD.Text))
                    throw new ArgumentException("Ingrese correctamente la cantidad que desea agregar");
                if (Convert.ToInt32(txtNUM_CANT_ADDD.Text) <= 0)
                    throw new ArgumentException("Ingrese correctamente la cantidad que desea agregar");
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
                        oBeA.NUM_CANT_DESP = oBe.NUM_CANT_DESP;
                        oBeA.NUM_STOC_REAL = oBe.NUM_STOC_REAL;
                        oBeA.NUM_STOC_VIRT = oBe.NUM_STOC_VIRT;
                        oBeA.NUM_CANT_REAL_DISP = oBe.NUM_CANT_REAL_DISP;
                        oBeA.NUM_CANT_REAL_COMP_PEDI = oBe.NUM_CANT_REAL_COMP_PEDI;
                        oBeA.NUM_STOC_COMP = oBe.NUM_STOC_COMP;
                        oBeA.NUM_STOC_VIRT_COMP = oBe.NUM_STOC_VIRT_COMP;
                        oBeA.NUM_CANT_VIRT_DISP = oBe.NUM_CANT_VIRT_DISP;
                        oBeA.NUM_CANT_VIRT_COMP_PEDI = oBe.NUM_CANT_VIRT_COMP_PEDI;

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
                        ListArticleCompletedUpdate();
                        gdvArticlesCompleted.RefreshData();
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
        /// <summary>
        /// REMOVER GRUPO
        /// </summary>
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
            ListArticleCompletedUpdate();
            gdvArticlesCompleted.RefreshData();
            gdvGroups.RefreshData();
            gdvArticlesGroup.RefreshData();
            gdvArticles.RefreshData();
        }
        /// <summary>
        /// AGREGAR GRUPO
        /// </summary>
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
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// AL CAMBIAR EL FOCO DE UNA FILA EN LA GRILLA DE GRUPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL REALIZAR CLIC SOBRE UNA FILA DE LA GRILLA DE GRUPOS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// AL REALIZAR CLIC AL BOTON DE QUITAR ARTICULO AL DETALLE DEL GRUPO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_CANT_REMO.Text))
                    throw new ArgumentException("Ingrese correctamente la cantidad que desea quitar");
                if (Convert.ToInt32(txtNUM_CANT_REMO.Text) <= 0)
                    throw new ArgumentException("Ingrese correctamente la cantidad que desea quitar");

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
                        oBeA.NUM_CANT_DESP = oBe.NUM_CANT_DESP;
                        oBeA.NUM_STOC_REAL = oBe.NUM_STOC_REAL;
                        oBeA.NUM_STOC_VIRT = oBe.NUM_STOC_VIRT;
                        oBeA.NUM_CANT_REAL_DISP = oBe.NUM_CANT_REAL_DISP;
                        oBeA.NUM_CANT_REAL_COMP_PEDI = oBe.NUM_CANT_REAL_COMP_PEDI;
                        oBeA.NUM_STOC_COMP = oBe.NUM_STOC_COMP;
                        oBeA.NUM_STOC_VIRT_COMP = oBe.NUM_STOC_VIRT_COMP;
                        oBeA.NUM_CANT_VIRT_DISP = oBe.NUM_CANT_VIRT_DISP;
                        oBeA.NUM_CANT_VIRT_COMP_PEDI = oBe.NUM_CANT_VIRT_COMP_PEDI;

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
                        ListArticleCompletedUpdate();
                        gdvArticlesCompleted.RefreshData();
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
        /// <summary>
        /// AL PRESIONAR LA TECLA ENTER 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNUM_DESC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                oListArti.ForEach(obj =>
                {
                    obj.NUM_PORC_DESC = decimal.Round(decimal.Parse(txtNUM_DESC.Text.Replace("%", "")) / decimal.Parse("100.00"), 2);
                    obj.NUM_DESC = decimal.Round(obj.NUM_PREC_UNIT * obj.NUM_PORC_DESC, 2);
                    obj.NUM_IMPO = decimal.Round(obj.NUM_CANT * (obj.NUM_PREC_UNIT - obj.NUM_DESC), 2);
                });
                oListArtiGroup.ForEach(obj =>
                {
                    obj.NUM_PORC_DESC = decimal.Round(decimal.Parse(txtNUM_DESC.Text.Replace("%", "")) / decimal.Parse("100.00"), 2);
                    obj.NUM_DESC = decimal.Round(obj.NUM_PREC_UNIT * obj.NUM_PORC_DESC, 2);
                    obj.NUM_IMPO = decimal.Round(obj.NUM_CANT * (obj.NUM_PREC_UNIT - obj.NUM_DESC), 2);
                });
                txtNUM_DESC.Text = txtNUM_DESC.Text.Replace("%", "") + "%";

                txtNUM_SUBT.Text = (oListArtiCompleted.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
                txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
                txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
                ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
            }
            ListArticleCompletedUpdate();
            gdvArticlesCompleted.RefreshData();
            gdvArticles.RefreshData();
            gdvArticlesGroup.RefreshData();
        }
        /// <summary>
        /// INVOCAR EL CUADRO DE BUSQUEDA PARA LA NOTA DE CREDITO
        /// </summary>
        public void SearchSalesCreditNote()
        {
            ClearControl();
            using (var oForm = new xfSearchQuote(5, SESSION_COMP))
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
                    txtALF_NUME_FACT.Text = oForm.oBe.ALF_NUME_DOCU;
                    beALF_GUIA_REMI_STOR.Text = oForm.oBe.ALF_NUME_DOCU;
                    COD_DVEN = oForm.oBe.COD_DVEN;
                    txtNUM_NCRE.Text = oForm.oBe.COD_NCRE.ToString();
                    deFEC_REGI.EditValue = oForm.oBe.FEC_REGI;
                    deFEC_DOCU.EditValue = oForm.oBe.FEC_DOCU;
                    deFEC_VENC.EditValue = oForm.oBe.FEC_PAGO;
                    txtALF_ESTA.Text = oForm.oBe.ALF_ESTA;
                    lueCOD_MONE.EditValue = oForm.oBe.COD_MONE;
                    lueALF_SERI.EditValue = oForm.oBe.ALF_SERI;
                    txtNUM_CORR.Text = oForm.oBe.NUM_CORR.ToString("0000000");
                    lueCOD_ALMA.EditValue = oForm.oBe.COD_ALMA;
                    txtALF_NUME_IDEN.Text = oForm.oBe.ALF_NUME_IDEN;
                    chkIGV.Checked = oForm.oBe.IND_IMPU;
                    chkIND_LIQU.Checked = oForm.oBe.IND_LIQU;

                    meALF_OBSE.Text = oForm.oBe.ALF_OBSE;
                    lblALF_SONN.Text = oForm.oBe.ALF_TOTA;

                    txtNUM_SUBT.Text = oForm.oBe.NUM_SUBT.ToString("#,##0.00");
                    txtNUM_IGVV.Text = oForm.oBe.NUM_IGVV.ToString("#,##0.00");
                    txtNUM_TOTA.Text = oForm.oBe.NUM_TOTA.ToString("#,##0.00");

                    var oBeSu = new BESVMD_SOCI_NEGO_SUCU();
                    var oBrSu = new BRSVMD_SOCI_NEGO_SUCU();

                    oBeSu.NUM_ACCI = 5;
                    oBeSu.COD_SOCI_NEGO = oForm.oBe.COD_SOCI_NEGO;
                    var oListTC = oBrSu.Get_SVPR_SOCI_NEGO_SUCU_LIST(oBeSu);

                    lueCOD_SUCU.Properties.DataSource = oListTC;
                    lueCOD_SUCU.Properties.Columns.Clear();
                    lueCOD_SUCU.Properties.Columns.Add(new LookUpColumnInfo("ALF_SUCU", 100, "Sucursal"));
                    lueCOD_SUCU.Properties.DisplayMember = "ALF_SUCU";
                    lueCOD_SUCU.Properties.ValueMember = "COD_SOCI_NEGO_SUCU";
                    lueCOD_SUCU.EditValue = oForm.oBe.COD_SUCU;

                    var oBe = new BESVTD_COTI();
                    var oBr = new BRSVTD_COTI();

                    oBe.COD_COTI = oForm.oBe.COD_DVEN;
                    oBe.NUM_ACCI = 5;
                    oBe.COD_TIPO_DOCU = 4;
                    var oList = oBr.Get_SVPR_COTI_DETA_LIST(oBe);

                    oList.ForEach(obj =>
                    {
                        oListArti.Add(obj);
                    });
                    gdvArticles.RefreshData();

                    var oBeG = new BESVTD_COTI_GROU();
                    var oBrG = new BRSVTD_COTI_GROU();

                    oBeG.COD_COTI = oForm.oBe.COD_DVEN;
                    oBeG.NUM_ACCI = 5;
                    oBeG.COD_TIPO_DOCU = 4;
                    var oListG = oBrG.Get_SVPR_COTI_GROU_LIST(oBeG);

                    oListG.ForEach(obj =>
                    {
                        oListGroup.Add(obj);
                    });
                    gdvGroups.RefreshData();

                    var oBeDG = new BESVTD_COTI();
                    var oBrDG = new BRSVTD_COTI_GROU_DETA();

                    oBeDG.COD_COTI = oForm.oBe.COD_DVEN;
                    oBeDG.NUM_ACCI = 5;
                    oBeDG.COD_TIPO_DOCU = 4;
                    var oListDG = oBrDG.Get_SVPR_COTI_GROU_DETA_LIST(oBeDG);

                    oListDG.ForEach(obj =>
                    {
                        oListArtiGroup.Add(obj);
                    });
                    ListArticleCompletedUpdate();
                    gdvArticlesCompleted.RefreshData();
                    gdvArticlesGroup.RefreshData();
                }
            }
        }
        /// <summary>
        /// PRESENTAR LA ORDEN DE VENTA CON LA INFORMACION PROVENIENTE DE LA COTIZACION
        /// </summary>
        /// <param name="COD_COTI"></param>
        public void SearchInvoice(int COD_DVENp)
        {
            ClearControl();
            StateControl(false);
            
            beALF_NOMB.Enabled = false;
            lueCOD_SUCU.Properties.ReadOnly = true;
            lueCOD_MONE.Properties.ReadOnly = true;
            lueCOD_ALMA.Properties.ReadOnly = true;
            txtNUM_DESC.Properties.ReadOnly = true;
            gcaNUM_CANT.OptionsColumn.AllowEdit = false;
            gcaNUM_CANT.OptionsColumn.AllowFocus = false;
            gcaNUM_CANT.OptionsColumn.ReadOnly = true;
            var oBe = new BESVTC_COTI();
            var oBr = new BRSVTC_COTI();
            oBe.ALF_NUME_IDEN = COD_DVENp.ToString();
            oBe.COD_TIPO_DOCU = 4;
            oBe.COD_COMP = SESSION_COMP;
            oBe.NUM_ACCI = 9;

            var oListDV = oBr.Get_SVPR_COTI_BUSC(oBe);
            LoadBranch(oListDV[0].COD_SOCI_NEGO);
            txtCOD_SOCI_NEGO.Text = oListDV[0].COD_SOCI_NEGO.ToString();
            beALF_NOMB.Text = oListDV[0].ALF_NOMB;
            txtALF_DIRE_FISC.Text = oListDV[0].ALF_DIRE;
            txtALF_TELE.Text = "";
            txtALF_FAXX.Text = "";
            txtALF_CONT.Text = oListDV[0].ALF_CONT;
            lueCOD_SUCU.EditValue = oListDV[0].COD_SUCU;
            txtNUM_DESC.Text = oListDV[0].NUM_DESC.ToString("#,##0.00");
            txtALF_NUME_FACT.Text = oListDV[0].ALF_NUME_SUNA;
            beALF_GUIA_REMI_STOR.Text = oListDV[0].ALF_NUME_DOCU;
            COD_DVEN = oListDV[0].COD_DVEN;
            txtNUM_NCRE.Text = string.Empty;
            deFEC_REGI.EditValue = DateTime.Today;
            deFEC_DOCU.EditValue = DateTime.Today;
            deFEC_VENC.EditValue = DateTime.Today;
            txtALF_ESTA.Text = oListDV[0].ALF_ESTA;
            lueCOD_MONE.EditValue = oListDV[0].COD_MONE;
            lueCOD_ALMA.EditValue = oListDV[0].COD_ALMA;
            txtALF_NUME_IDEN.Text = oListDV[0].ALF_NUME_IDEN;
            chkIGV.Checked = oListDV[0].IND_IMPU;
            chkIND_LIQU.Checked = oListDV[0].IND_LIQU;

            meALF_OBSE.Text = oListDV[0].ALF_OBSE;
            lblALF_SONN.Text = oListDV[0].ALF_TOTA;

            txtNUM_SUBT.Text = oListDV[0].NUM_SUBT.ToString("#,##0.00");
            txtNUM_IGVV.Text = oListDV[0].NUM_IGVV.ToString("#,##0.00");
            txtNUM_TOTA.Text = oListDV[0].NUM_TOTA.ToString("#,##0.00");

            var oBeSu = new BESVMD_SOCI_NEGO_SUCU();
            var oBrSu = new BRSVMD_SOCI_NEGO_SUCU();

            oBeSu.NUM_ACCI = 5;
            oBeSu.COD_SOCI_NEGO = oListDV[0].COD_SOCI_NEGO;
            var oListTC = oBrSu.Get_SVPR_SOCI_NEGO_SUCU_LIST(oBeSu);

            lueCOD_SUCU.Properties.DataSource = oListTC;
            lueCOD_SUCU.Properties.Columns.Clear();
            lueCOD_SUCU.Properties.Columns.Add(new LookUpColumnInfo("ALF_SUCU", 100, "Sucursal"));
            lueCOD_SUCU.Properties.DisplayMember = "ALF_SUCU";
            lueCOD_SUCU.Properties.ValueMember = "COD_SOCI_NEGO_SUCU";
            lueCOD_SUCU.EditValue = oListDV[0].COD_SUCU;

            var oBeD = new BESVTD_COTI();
            var oBrD = new BRSVTD_COTI();

            oBeD.COD_COTI = oListDV[0].COD_DVEN;
            oBeD.NUM_ACCI = 5;
            oBeD.COD_TIPO_DOCU = 4;
            var oList = oBrD.Get_SVPR_COTI_DETA_LIST(oBeD);

            oList.ForEach(obj =>
            {
                oListArti.Add(obj);
            });
            gdvArticles.RefreshData();

            var oBeG = new BESVTD_COTI_GROU();
            var oBrG = new BRSVTD_COTI_GROU();

            oBeG.COD_COTI = oListDV[0].COD_DVEN;
            oBeG.NUM_ACCI = 5;
            oBeG.COD_TIPO_DOCU = 4;
            var oListG = oBrG.Get_SVPR_COTI_GROU_LIST(oBeG);

            oListG.ForEach(obj =>
            {
                oListGroup.Add(obj);
            });
            gdvGroups.RefreshData();

            var oBeDG = new BESVTD_COTI();
            var oBrDG = new BRSVTD_COTI_GROU_DETA();

            oBeDG.COD_COTI = oListDV[0].COD_DVEN;
            oBeDG.NUM_ACCI = 5;
            oBeDG.COD_TIPO_DOCU = 4;
            var oListDG = oBrDG.Get_SVPR_COTI_GROU_DETA_LIST(oBeDG);

            oListDG.ForEach(obj =>
            {
                oListArtiGroup.Add(obj);
            });
            ListArticleCompletedUpdate();
            gdvArticlesCompleted.RefreshData();
            gdvArticlesGroup.RefreshData();
        }
        /// <summary>
        /// AL SELECCIONAR UNA MONEDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueCOD_MONE_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCOD_MONE.EditValue != null)
            {
                if (!string.IsNullOrEmpty(txtNUM_TOTA.Text))
                    ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
            }
        }
        /// <summary>
        /// AL SELECCIONAR UNA SUCURSAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        txtALF_DIRE_FISC.Text = oBe.ALF_DIRE;

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// ACTUALIZAR LA LISTA DE ARTICULOS COMPLETA
        /// </summary>
        private void ListArticleCompletedUpdate()
        {
            var oListTemporal = new List<BESVTD_COTI>();
            oListArti.ForEach(obj =>
            {
                var oBeAdd = new BESVTD_COTI();
                oBeAdd.COD_ARTI = obj.COD_ARTI;
                oBeAdd.ALF_ARTI = obj.ALF_ARTI;
                oBeAdd.ALF_CODI_ARTI = obj.ALF_CODI_ARTI;
                oBeAdd.NUM_PREC_UNIT = obj.NUM_PREC_UNIT;
                oBeAdd.NUM_PORC_DESC = obj.NUM_PORC_DESC;
                oBeAdd.NUM_DESC = obj.NUM_DESC;
                oBeAdd.NUM_CANT = obj.NUM_CANT;
                oBeAdd.NUM_IMPO = obj.NUM_IMPO;
                oBeAdd.NUM_CANT_DESP = obj.NUM_CANT_DESP;
                oBeAdd.NUM_STOC_REAL = obj.NUM_STOC_REAL;
                oBeAdd.NUM_STOC_VIRT = obj.NUM_STOC_VIRT;
                oBeAdd.NUM_CANT_REAL_DISP = obj.NUM_CANT_REAL_DISP;
                oBeAdd.NUM_CANT_REAL_COMP_PEDI = obj.NUM_CANT_REAL_COMP_PEDI;
                oBeAdd.NUM_STOC_COMP = obj.NUM_STOC_COMP;
                oBeAdd.NUM_STOC_VIRT_COMP = obj.NUM_STOC_VIRT_COMP;
                oBeAdd.NUM_CANT_VIRT_DISP = obj.NUM_CANT_VIRT_DISP;
                oBeAdd.NUM_CANT_VIRT_COMP_PEDI = obj.NUM_CANT_VIRT_COMP_PEDI;
                oListTemporal.Add(oBeAdd);
            });
            oListArtiGroup.ForEach(obj =>
            {
                var oBeAdd = new BESVTD_COTI();
                oBeAdd.COD_ARTI = obj.COD_ARTI;
                oBeAdd.ALF_ARTI = obj.ALF_ARTI;
                oBeAdd.ALF_CODI_ARTI = obj.ALF_CODI_ARTI;
                oBeAdd.NUM_PREC_UNIT = obj.NUM_PREC_UNIT;
                oBeAdd.NUM_PORC_DESC = obj.NUM_PORC_DESC;
                oBeAdd.NUM_DESC = obj.NUM_DESC;
                oBeAdd.NUM_CANT = obj.NUM_CANT;
                oBeAdd.NUM_IMPO = obj.NUM_IMPO;
                oBeAdd.NUM_CANT_DESP = obj.NUM_CANT_DESP;
                oBeAdd.NUM_STOC_REAL = obj.NUM_STOC_REAL;
                oBeAdd.NUM_STOC_VIRT = obj.NUM_STOC_VIRT;
                oBeAdd.NUM_CANT_REAL_DISP = obj.NUM_CANT_REAL_DISP;
                oBeAdd.NUM_CANT_REAL_COMP_PEDI = obj.NUM_CANT_REAL_COMP_PEDI;
                oBeAdd.NUM_STOC_COMP = obj.NUM_STOC_COMP;
                oBeAdd.NUM_STOC_VIRT_COMP = obj.NUM_STOC_VIRT_COMP;
                oBeAdd.NUM_CANT_VIRT_DISP = obj.NUM_CANT_VIRT_DISP;
                oBeAdd.NUM_CANT_VIRT_COMP_PEDI = obj.NUM_CANT_VIRT_COMP_PEDI;
                oListTemporal.Add(oBeAdd);
            });
            oListArtiCompleted.Clear();
            oListTemporal.ForEach(obj =>
            {
                //if (oListArtiCompleted.Count(objI => objI.COD_ARTI == obj.COD_ARTI) > 0)
                //{
                //    var NUM_CANT = oListArtiCompleted.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_CANT;
                //    var NUM_IMPO = oListArtiCompleted.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_IMPO;

                //    oListArtiCompleted.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_CANT = NUM_CANT + obj.NUM_CANT;
                //    oListArtiCompleted.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_IMPO = NUM_IMPO + obj.NUM_IMPO;
                //}
                //else
                //{
                oListArtiCompleted.Add(obj);
                //}
            });
        }
        /// <summary>
        /// ANULAR LA ORDEN DE VENTA
        /// </summary>
        public void Annul()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                    throw new ArgumentException("Seleccione un documento de venta");

                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtNUM_NCRE.Text;
                oBe.COD_TIPO_DOCU = 5;
                oBe.COD_COMP = SESSION_COMP;
                oBe.NUM_ACCI = 6;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);
                txtALF_ESTA.Text = oList[0].ALF_ESTA;
                if (oList[0].ALF_ESTA.Equals("CANCELADA"))
                    throw new ArgumentException("La nota de crédito esta anulada");

                if (XtraMessageBox.Show("Seguro que desea anular la nota de crédito?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oBe.NUM_ACCI = 3;
                    oBe.COD_DOCU_SECU = Convert.ToInt32(txtNUM_NCRE.Text);
                    oBe.COD_DOCU_INIC = COD_DVEN;
                    oBe.COD_TIPO_DOCU = 5;

                    oBe.COD_USUA_CREA = SESSION_USER;
                    oBe.COD_USUA_MODI = SESSION_USER;
                    oBe.COD_COMP = SESSION_COMP;

                    oBr.Set_SVPR_COTI(oBe);
                    txtALF_ESTA.Text = "ANULADA";
                    StateControl(true);

                    XtraMessageBox.Show("Operación realizada con exito!!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lueALF_SERI_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit obj = (LookUpEdit)sender;
            if (obj != null)
            {
                var oBe = (BESVMC_SERI_CORR)obj.GetSelectedDataRow();
                if (oBe != null)
                {
                    txtNUM_CORR.Text = oBe.NUM_CORR.ToString("0000000");
                }
            }
        }

        private void beALF_GUIA_REMI_STOR_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
        }
        public void SearchDetailReferralGuide(int COD_GREM)
        {
            var oBeC = new BESVTD_COTI();
            var oBrC = new BRSVTD_COTI();

            oBeC.COD_COTI = COD_GREM;
            oBeC.NUM_ACCI = 5;
            oBeC.COD_TIPO_DOCU = 3;
            var oListC = oBrC.Get_SVPR_COTI_DETA_LIST(oBeC);

            oListC.ForEach(obj =>
            {
                //if (oListArti.Count(objA => objA.COD_ARTI == obj.COD_ARTI) > 0)
                //{
                //    var NUM_CANT = oListArti.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_CANT;
                //    var NUM_IMPO = oListArti.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_IMPO;

                //    oListArti.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_CANT = NUM_CANT + obj.NUM_CANT;
                //    oListArti.Find(objIi => objIi.COD_ARTI == obj.COD_ARTI).NUM_IMPO = NUM_IMPO + obj.NUM_IMPO;
                //}
                //else
                //{
                oListArti.Add(obj);
                //}
            });
            gdvArticles.RefreshData();
            ListArticleCompletedUpdate();
            gdvArticlesCompleted.RefreshData();
            txtNUM_SUBT.Text = (oListArtiCompleted.Sum(obj => obj.NUM_IMPO)).ToString("#,##0.00");
            txtNUM_IGVV.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) * (chkIGV.Checked ? SESSION_PORC_IMPU : Convert.ToDecimal("0.00"))).ToString("#,##0.00");
            txtNUM_TOTA.Text = (Convert.ToDecimal(txtNUM_SUBT.Text) + Convert.ToDecimal(txtNUM_IGVV.Text)).ToString("#,##0.00");
            ALF_TOTA(Convert.ToDecimal(txtNUM_TOTA.Text));
        }

        public void GenerateCreditNote()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                    throw new ArgumentException("Seleccione un documento de venta");

                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtNUM_NCRE.Text;
                oBe.COD_TIPO_DOCU = 4;
                oBe.COD_COMP = SESSION_COMP;
                oBe.NUM_ACCI = 6;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);
                txtALF_ESTA.Text = oList[0].ALF_ESTA;
                if (oList[0].ALF_ESTA.Equals("CANCELADA"))
                    throw new ArgumentException("El documento de venta esta cancelado");

                Sales.xfSalesCreditNote.SgIns.MdiParent = this.MdiParent;
                Sales.xfSalesCreditNote.SgIns.Activate();
                Sales.xfSalesCreditNote.SgIns.FORM_SUBO = "bbiCreditNote";
                Sales.xfSalesCreditNote.SgIns.Show();
                Sales.xfSalesCreditNote.SgIns.BringToFront();

                Sales.xfSalesCreditNote.SgIns.SearchInvoice(int.Parse(txtNUM_NCRE.Text));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ViewSelector()
        {
            using (var oForm = new xfSelectorCreditNote())
            {
                oForm.ShowDialog();
            }
        }
        /// <summary>
        /// IMPRIMIR EL DOCUMENTO DE VENTA
        /// </summary>
        public void Print()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                    throw new ArgumentException("La nota de cédito no esta guardada");
                var Report = new xrSalesCreditNote();
                var oBe = new BESVTC_COTI();
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtNUM_NCRE.Text;
                oBe.NUM_ACCI = 8;
                oBe.COD_TIPO_DOCU = 5;
                oBe.COD_COMP = SESSION_COMP;
                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);
                oList.ForEach(obj =>
                {
                    obj.ALF_NUME_IDEN = txtALF_NUME_IDEN.Text;
                });
                var SIMB = (BESVMC_MONE)lueCOD_MONE.GetSelectedDataRow();
                var tfs = (SIMB.ALF_MONE_SIMB == "USD") ? "{0:$0.00}" : "{0:c2}";
                Report.xrlPrice.DataBindings["Text"].FormatString = tfs;
                Report.xrlAmount.DataBindings["Text"].FormatString = tfs;
                Report.xrlSubtotal.DataBindings["Text"].FormatString = tfs;
                Report.xrlIgv.DataBindings["Text"].FormatString = tfs;
                Report.xrlTotal.DataBindings["Text"].FormatString = tfs;

                Report.DataSource = oList;
                Report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// IMPRIMIR EL DOCUMENTO DE VENTA KIT
        /// </summary>
        public void PrintKit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                    throw new ArgumentException("La nota de crédito no esta guardada");
                var Report = new xrSalesInvoiceKit();

                var _oBe = new BESVTC_COTI();
                var _oBr = new BRSVTC_COTI();
                _oBe.ALF_NUME_IDEN = txtNUM_NCRE.Text;
                _oBe.NUM_ACCI = 8;
                _oBe.COD_TIPO_DOCU = 5;
                _oBe.COD_COMP = SESSION_COMP;
                var _oList = _oBr.Get_SVPR_COTI_BUSC(_oBe);
                var ALF_DIRE_FISC = _oList[0].ALF_DIRE;
                var oList = new List<BESVTC_COTI>();

                oListGroup.ForEach(obj =>
                {
                    var oBeIn = new BESVTC_COTI();
                    oBeIn.FEC_DOCU = deFEC_DOCU.DateTime;
                    oBeIn.ALF_NUME_DOCU = lueALF_SERI.Text + "-" + txtNUM_CORR.Text;
                    oBeIn.ALF_NOMB = beALF_NOMB.Text;
                    oBeIn.ALF_DIRE = ALF_DIRE_FISC;
                    oBeIn.ALF_NUME_IDEN = txtALF_NUME_IDEN.Text;
                    oBeIn.ALF_NUME_GUIA = beALF_GUIA_REMI_STOR.Text;
                    oBeIn.ALF_TOTA = lblALF_SONN.Text;
                    oBeIn.NUM_SUBT = decimal.Parse(txtNUM_SUBT.Text);
                    oBeIn.NUM_IGVV = decimal.Parse(txtNUM_IGVV.Text);
                    oBeIn.NUM_TOTA = decimal.Parse(txtNUM_TOTA.Text);
                    oBeIn.ALF_NOMB_GROU = obj.ALF_NOMB;
                    oBeIn.NUM_CANT = obj.NUM_CANT;
                    oBeIn.NUM_IMPO = (from objI in oListArtiGroup
                                      where objI.COD_COTI_GROU == obj.COD_COTI_GROU
                                      select (objI.NUM_PREC_UNIT - objI.NUM_DESC) * objI.NUM_CANT).Sum();
                    oBeIn.NUM_PREC_UNIT = oBeIn.NUM_IMPO / oBeIn.NUM_CANT;
                    oList.Add(oBeIn);
                });

                oListArti.ForEach(obj =>
                {
                    var oBeIn = new BESVTC_COTI();
                    oBeIn.FEC_DOCU = deFEC_DOCU.DateTime;
                    oBeIn.ALF_NUME_DOCU = lueALF_SERI.Text + "-" + txtNUM_CORR.Text;
                    oBeIn.ALF_NOMB = beALF_NOMB.Text;
                    oBeIn.ALF_DIRE = ALF_DIRE_FISC;
                    oBeIn.ALF_NUME_IDEN = txtALF_NUME_IDEN.Text;
                    oBeIn.ALF_NUME_GUIA = beALF_GUIA_REMI_STOR.Text;
                    oBeIn.ALF_TOTA = lblALF_SONN.Text;
                    oBeIn.NUM_SUBT = decimal.Parse(txtNUM_SUBT.Text);
                    oBeIn.NUM_IGVV = decimal.Parse(txtNUM_IGVV.Text);
                    oBeIn.NUM_TOTA = decimal.Parse(txtNUM_TOTA.Text);
                    oBeIn.ALF_NOMB_GROU = obj.ALF_ARTI;
                    oBeIn.NUM_CANT = obj.NUM_CANT;
                    oBeIn.NUM_IMPO = obj.NUM_IMPO;
                    oBeIn.NUM_PREC_UNIT = obj.NUM_PREC_UNIT;
                    oList.Add(oBeIn);
                });

                var SIMB = (BESVMC_MONE)lueCOD_MONE.GetSelectedDataRow();
                var tfs = (SIMB.ALF_MONE_SIMB == "USD") ? "{0:$0.00}" : "{0:c2}";
                Report.xrlPrice.DataBindings["Text"].FormatString = tfs;
                Report.xrlAmount.DataBindings["Text"].FormatString = tfs;
                Report.xrlSubtotal.DataBindings["Text"].FormatString = tfs;
                Report.xrlIgv.DataBindings["Text"].FormatString = tfs;
                Report.xrlTotal.DataBindings["Text"].FormatString = tfs;

                Report.DataSource = oList;
                Report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LiquidateBill()
        {
            var oResult = XtraMessageBox.Show("Seguro que desea dar por liquidada la factura?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oResult == DialogResult.Yes)
            {
                var oBr = new BRSVTC_COTI();
                var oBe = new BESVTC_COTI();

                try
                {
                    if (string.IsNullOrEmpty(txtNUM_NCRE.Text))
                        throw new ArgumentException("Seleccione una factura.");
                    oBe.COD_COTI = Convert.ToInt32(txtNUM_NCRE.Text);
                    oBe.COD_USUA_MODI = SESSION_USER;
                    oBe.NUM_ACCI = 4;
                    oBr.Set_SVPR_DOCU_ESTA(oBe);
                    chkIND_LIQU.Checked = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}