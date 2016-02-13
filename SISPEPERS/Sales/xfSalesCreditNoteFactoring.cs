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
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;
using BusinessEntities.Management;
using BusinessEntities.Generics;
using BusinessRules.Generics;
using DevExpress.XtraEditors.Controls;
using BusinessEntities.Sales;
using BusinessRules.Sales;
using BusinessRules.Management;

namespace SISPEPERS.Sales
{
    public partial class xfSalesCreditNoteFactoring : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string SESSION_IMPU { get; set; }
        public decimal SESSION_PORC_IMPU { get; set; }
        public string FORM_SUBO { get; set; }
        public int COD_DVEN { get; set; }
        
        private List<BESVTC_COTI> oListInvoice;

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfSalesCreditNoteFactoring mSgIns;
        public static xfSalesCreditNoteFactoring SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfSalesCreditNoteFactoring();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        public xfSalesCreditNoteFactoring()
        {
            InitializeComponent();
            oListInvoice = new List<BESVTC_COTI>();
        }

        private void xfSalesCreditNoteFactoring_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;
            SESSION_IMPU = ((xfMain)MdiParent).SESSION_IMPU;
            SESSION_PORC_IMPU = ((xfMain)MdiParent).SESSION_PORC_IMPU;
            lblALF_IMPU.Text = SESSION_IMPU;
            StateControl(true);
            //MONEDAS
            var oBeMo = new BESVMC_MONE();
            var oBrMo = new BRSVMC_MONE();

            oBeMo.NUM_ACCI = 4;
            oBeMo.COD_COMP = SESSION_COMP;
            var oListMo = oBrMo.Get_SVPR_MONE_LIST(oBeMo);
            gdcInvoices.DataSource = oListInvoice;

            lueCOD_MONE.Properties.DataSource = oListMo;
            lueCOD_MONE.Properties.Columns.Clear();
            lueCOD_MONE.Properties.Columns.Add(new LookUpColumnInfo("ALF_MONE", 100, "Moneda"));
            lueCOD_MONE.Properties.DisplayMember = "ALF_MONE";
            lueCOD_MONE.Properties.ValueMember = "COD_MONE";
        }
        /// <summary>
        /// AL ACTIVAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNoteFactoring_Activated(object sender, EventArgs e)
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
        private void xfSalesCreditNoteFactoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }
        /// <summary>
        /// AL DESACTIVAR EL FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xfSalesCreditNoteFactoring_Deactivate(object sender, EventArgs e)
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

        private void beALF_NOMB_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (xfSearchPerson oForm = new xfSearchPerson(SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                    txtALF_NUME_IDEN.Text = oForm.oBe.ALF_NUME_IDEN;
                    txtALF_DIRE_FISC.Text = oForm.oBe.ALF_DIRE_FISC;
                    txtALF_TELE.Text = oForm.oBe.ALF_TELE;
                    txtALF_CONT.Text = oForm.oBe.ALF_CONT;
                }
            }
        }

        /// <summary>
        /// ACTIVAR O DESACTIVAR LOS CONTROLES
        /// </summary>
        /// <param name="vState"></param>
        private void StateControl(bool vState)
        {
            deFEC_DOCU.Properties.ReadOnly = vState;
            deFEC_VENC.Properties.ReadOnly = vState;
            deFEC_REGI.Properties.ReadOnly = vState;
            deFEC_NEGO.Properties.ReadOnly = vState;
            beALF_NOMB.Enabled = !vState;
            txtNUM_DESC.Properties.ReadOnly = vState;
            lueCOD_MONE.Properties.ReadOnly = vState;
            lueALF_SERI.Properties.ReadOnly = vState;
        }
        private void ClearControl()
        {
            deFEC_DOCU.EditValue = DateTime.Today;
            deFEC_VENC.EditValue = DateTime.Today;
            deFEC_REGI.EditValue = DateTime.Today;
            deFEC_NEGO.EditValue = DateTime.Today;
            beALF_NOMB.Text = "";
            txtALF_DIRE_FISC.Text = "";
            txtALF_FAXX.Text = "";
            txtALF_TELE.Text = "";
            txtALF_CONT.Text = "";
            txtALF_ESTA.Text = "";
            txtALF_NUME_IDEN.Text = "";
            lueALF_SERI.EditValue = null;
            txtNUM_CORR.Text = "";
            txtNUM_DESC.Text = "0.00";
            txtNUM_NCRE.Text = "";
            txtNUM_SUBT.Text = "";
            txtNUM_IGVV.Text = "";
            txtNUM_TOTA.Text = "";
            meALF_OBSE.Text = "";
            oListInvoice.Clear();
            gdvInvoices.RefreshData();
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
        }
        /// <summary>
        /// INVOCAR EL CUADRO DE BUSQUEDA PARA LA NOTA DE CREDITO
        /// </summary>
        public void SearchSalesCreditNote()
        {
            ClearControl();
            using (var oForm = new xfSearchQuote(6, SESSION_COMP))
            {
                if (oForm.ShowDialog() == DialogResult.OK)
                {
                    txtCOD_SOCI_NEGO.Text = oForm.oBe.COD_SOCI_NEGO.ToString();
                    beALF_NOMB.Text = oForm.oBe.ALF_NOMB;
                    txtALF_DIRE_FISC.Text = oForm.oBe.ALF_DIRE;
                    txtALF_TELE.Text = "";
                    txtALF_FAXX.Text = "";
                    txtALF_CONT.Text = oForm.oBe.ALF_CONT;
                    txtNUM_DESC.Text = oForm.oBe.NUM_DESC.ToString("#,##0.00");
                    COD_DVEN = oForm.oBe.COD_DVEN;
                    txtNUM_NCRE.Text = oForm.oBe.COD_NCRE.ToString();
                    deFEC_REGI.EditValue = oForm.oBe.FEC_REGI;
                    deFEC_DOCU.EditValue = oForm.oBe.FEC_DOCU;
                    deFEC_VENC.EditValue = oForm.oBe.FEC_PAGO;
                    txtALF_ESTA.Text = oForm.oBe.ALF_ESTA;
                    lueCOD_MONE.EditValue = oForm.oBe.COD_MONE;
                    lueALF_SERI.EditValue = oForm.oBe.ALF_SERI;
                    txtNUM_CORR.Text = oForm.oBe.NUM_CORR.ToString("0000000");
                    txtALF_NUME_IDEN.Text = oForm.oBe.ALF_NUME_IDEN;
                    chkIGV.Checked = oForm.oBe.IND_IMPU;

                    meALF_OBSE.Text = oForm.oBe.ALF_OBSE;
                    lblALF_SONN.Text = oForm.oBe.ALF_TOTA;

                    txtNUM_SUBT.Text = oForm.oBe.NUM_SUBT.ToString("#,##0.00");
                    txtNUM_IGVV.Text = oForm.oBe.NUM_IGVV.ToString("#,##0.00");
                    txtNUM_TOTA.Text = oForm.oBe.NUM_TOTA.ToString("#,##0.00");

                    var oBe = new BESVTD_COTI();
                    var oBr = new BRSVTD_COTI();

                    oBe.COD_COTI = oForm.oBe.COD_DVEN;
                    oBe.NUM_ACCI = 5;
                    oBe.COD_TIPO_DOCU = 4;
                    var oList = oBr.Get_SVPR_COTI_DETA_LIST(oBe);

                }
            }
        }
        /// <summary>
        /// NUEVO
        /// </summary>
        public void New()
        {
            ClearControl();
            StateControl(false);
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

        public void AddInvoice()
        {
            if (!beALF_NOMB.Enabled) return;
            try
            {
                if (string.IsNullOrEmpty(txtALF_NUME_IDEN.Text))
                    throw new ArgumentException("Primero debe seleccionar un cliente.");
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione un tipo moneda.");
                using (var oForm = new xfSearchInvoice(4, SESSION_COMP,txtALF_NUME_IDEN.Text,Convert.ToInt32(lueCOD_MONE.EditValue)))
                {
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        oListInvoice.ForEach(obj=>{
                            if (obj.ALF_NUME_SUNA.Equals(oForm.oBe.ALF_NUME_SUNA))
                                throw new ArgumentException("La factura ya esta en la lista");
                        });

                        oListInvoice.Add(oForm.oBe);
                        oListInvoice.ForEach(obj =>
                        {
                            obj.FEC_NEGO = deFEC_NEGO.DateTime;
                            obj.NUM_DIAS = ((TimeSpan)(obj.FEC_PAGO - obj.FEC_NEGO)).Days;
                        });
                        gdvInvoices.RefreshData();
                        gdvInvoices.RefreshData();
                    }
                }
                CalculateAmountTotal();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void deFEC_NEGO_EditValueChanged(object sender, EventArgs e)
        {
            var Date = (DateEdit)sender;
            try
            {
                if (Date.DateTime > DateTime.Today)
                {
                    throw new ArgumentException("La fecha de negociación no puede ser superior a la actual");
                }

                oListInvoice.ForEach(obj =>
                {
                    if (obj.FEC_DOCU > Date.DateTime)
                        throw new ArgumentException("La factura " + obj.ALF_NUME_SUNA + " tiene fecha inferior a la de negociación");
                });

                oListInvoice.ForEach(obj =>
                {
                    obj.FEC_NEGO = Date.DateTime;
                    obj.NUM_DIAS = ((TimeSpan)(obj.FEC_PAGO - obj.FEC_NEGO)).Days;
                    obj.NUM_TASA_DIAA = (Convert.ToDecimal(txtNUM_DESC.Text)/100) / 30;
                    obj.NUM_FACT = obj.NUM_TASA_DIAA * obj.NUM_DIAS;
                    obj.NUM_FACT_DESC = obj.NUM_FACT * obj.NUM_DIAS;
                });
                CalculateAmountTotal();
                gdvInvoices.RefreshData();
            }
            catch (Exception ex)
            {
                Date.EditValue = DateTime.Today;
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lueCOD_MONE_EditValueChanged(object sender, EventArgs e)
        {
            oListInvoice.Clear();
            gdvInvoices.RefreshData();
        }

        private void txtNUM_DESC_EditValueChanged(object sender, EventArgs e)
        {
            var Text = (TextEdit)sender;
            try
            {
                if (string.IsNullOrEmpty(Text.Text))
                {
                    if (Convert.ToDecimal(Text.Text) < 0)
                    {
                        throw new ArgumentException("El porcentaje de descuento no puede ser menor a cero.");
                    }
                }

                oListInvoice.ForEach(obj =>
                {
                    obj.NUM_TASA_DIAA = (Convert.ToDecimal(txtNUM_DESC.Text) / 100) / 30;
                    obj.NUM_FACT = obj.NUM_TASA_DIAA * obj.NUM_DIAS;
                    obj.NUM_FACT_DESC = obj.NUM_FACT * obj.NUM_DIAS;
                });
                CalculateAmountTotal();
                gdvInvoices.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateAmountTotal()
        {
            decimal NUM_TOTA = 0;
            oListInvoice.ForEach(obj => {
                NUM_TOTA += obj.NUM_FACT_DESC;
            });
            txtNUM_SUBT.Text = (NUM_TOTA / Convert.ToDecimal(1.18)).ToString("#,##0.00");
            txtNUM_IGVV.Text = (NUM_TOTA - (NUM_TOTA / Convert.ToDecimal(1.18))).ToString("#,##0.00");
            txtNUM_TOTA.Text = NUM_TOTA.ToString("#,##0.00");
        }

        public void RemoveInvoice()
        {
            if (!beALF_NOMB.Enabled) return;
            try
            {
                if (gdvInvoices.RowCount<=0)
                {
                    throw new ArgumentException("No existen registros que borrar.");
                }
                var oBe = (BESVTC_COTI)gdvInvoices.GetRow(gdvInvoices.FocusedRowHandle);
                oListInvoice.Remove(oBe);
                gdvInvoices.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// DESHACER
        /// </summary>
        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }        /// <summary>
        /// GUARDAR
        /// </summary>
        public void Save()
        {
            if (lueALF_SERI.Properties.ReadOnly) return;
            try
            {
                if (string.IsNullOrEmpty(txtCOD_SOCI_NEGO.Text))
                    throw new ArgumentException("Seleccione un cliente");
                if (lueCOD_MONE.EditValue == null)
                    throw new ArgumentException("Seleccione la moneda");
                if (lueALF_SERI.EditValue == null)
                    throw new ArgumentException("Seleccione la serie");
                if (string.IsNullOrEmpty(txtNUM_CORR.Text))
                    throw new ArgumentException("Defina correctamente la numeracion del documento");
                if (oListInvoice.Count == 0)
                    throw new ArgumentException("Debe agregar al menos una factura.");

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
                oBe.COD_MONE = Convert.ToInt32(lueCOD_MONE.EditValue);
                oBe.NUM_DESC = Convert.ToDecimal(txtNUM_DESC.Text.Replace("%", ""));
                oBe.FEC_DOCU = deFEC_DOCU.DateTime;
                oBe.FEC_VENC = deFEC_VENC.DateTime;

                oBe.LST_FACT = oListInvoice;

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
                oBe.IND_FACT = true;

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

    }
}