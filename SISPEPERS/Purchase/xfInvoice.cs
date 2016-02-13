using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessRules.Purchase;
using DevExpress.XtraEditors.Controls;
using BusinessEntities.Purchase;
using System.Globalization;
using DevExpress.XtraEditors.Mask;
using BusinessEntities.Generics;
using System.ComponentModel.DataAnnotations;
using BusinessEntities.Security;
using BusinessRules.Security;
using DevExpress.XtraBars;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using BusinessRules.Tool;
using BusinessRules.Warehouse;

namespace SISPEPERS.Purchase
{
    public partial class xfInvoice : XtraForm
    {
        public BEDocument docb { get; set; }
        public xfInvoice()
        {
            InitializeComponent();
        }

        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfInvoice mSgIns;
        public static xfInvoice SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfInvoice();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        public void New()
        {
            ClearControls();
            StateControls(false);
            bteCOD_SOCI_NEGO.Focus();
        }
    
        private void ClearControls()
        {
            txtCOD_DOCU.Text = string.Empty;
            txtALF_NUM_SERI.EditValue = null;
            txtALF_NUM_CORR.EditValue = null;
            //txtNUM_TIPO_CAMB.EditValue = null;
            txtALF_NUM_RUCC.Text = string.Empty;

            bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption = string.Empty;
            bteCOD_SOCI_NEGO.Text = string.Empty;

            txtNUM_SUBB_TOTA.EditValue = 0.00;
            txtNUM_DESC.EditValue = 0.00;
            txtNUM_IGVV.EditValue = 0.00;
            txtNUM_TOTA.EditValue = 0.00;
            
            dteFEC_REGI.EditValue = DateTime.Now;
            dteFEC_DOCU.EditValue = DateTime.Now;
            dteFEC_ENTR.EditValue = DateTime.Now;
            dteFEC_PAGO.EditValue = null;

            lkeCOD_COND_PAGO.EditValue = null;
            lkeCOD_ALMA.EditValue = null;
            lkeCOD_MONE.ItemIndex = 0;
            lkeIND_ESTA.ItemIndex = 0;
            mmeALF_DIRE_FISC.Text = string.Empty;
            mmeALF_DIRE_ENTR.Text = string.Empty;
            mmeALF_COME.Text = string.Empty;

            rdgIND_TIPO_COMP.SelectedIndex = 0;

            var lines = new List<BEDocumentLines>();
            lines.Add(new BEDocumentLines() { COD_USUA_CREA = SESSION_USER });
            gdcLines.DataSource = lines;
            Set_Totals();
        }
        private void StateControls(bool vState)
        {
            rdgIND_TIPO_COMP.Properties.ReadOnly = vState;
            txtALF_NUM_SERI.Properties.ReadOnly = vState;
            txtALF_NUM_CORR.Properties.ReadOnly = vState;
            dteFEC_DOCU.Properties.ReadOnly = vState;
            dteFEC_ENTR.Properties.ReadOnly = vState;
            dteFEC_PAGO.Properties.ReadOnly = vState;
            lkeCOD_COND_PAGO.Properties.ReadOnly = vState;
            lkeCOD_ALMA.Properties.ReadOnly = vState;
            lkeCOD_MONE.Properties.ReadOnly = vState;
            mmeALF_DIRE_ENTR.Properties.ReadOnly = vState;
            mmeALF_COME.Properties.ReadOnly = vState;
            bteCOD_SOCI_NEGO.Properties.Buttons[1].Enabled = !vState;
            txtNUM_DESC.Properties.ReadOnly = vState;
            txtNUM_TIPO_CAMB.Properties.ReadOnly = vState;

            gdcLines.Enabled = !vState;
        }
        public void Undo()
        {
            ClearControls();
            StateControls(true);
        }
        private void InitializeCopy()
        {
            var barManager = new BarManager();
            if (barManager.Controller == null) barManager.Controller = new BarAndDockingController();
            barManager.Controller.PaintStyleName = "Skin";
            barManager.Controller.LookAndFeel.UseDefaultLookAndFeel = false;
            barManager.Controller.LookAndFeel.SkinName = "Office 2007 Blue";

            barManager.ItemClick += HandleSendCopyToDeliveryClick;
            var baritem = new BarButtonItem()
            {
                Manager = barManager,
                Caption = "Nota de Crédito Proveedor",
                Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/forward_16x16.png")
            };
            barManager.Items.Add(baritem);

            var popupMenu = new PopupMenu { Manager = barManager };
            foreach (var barItem in barManager.Items) popupMenu.ItemLinks.Add((BarItem)barItem);
            ddbCopy.DropDownControl = popupMenu;
        }
        private void HandleSendCopyToDeliveryClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ddbCopy.HideDropDown();
                if (string.IsNullOrEmpty(txtCOD_DOCU.Text))
                    throw new ArgumentException(_Message.MsgSelectDoc);
                if (lkeIND_ESTA.EditValue.ToString() != "AB")
                    throw new ArgumentException(string.Format("{0}{1}.", _Message.MsgNotCopy, lkeIND_ESTA.Text.ToLower()));
                var odoc = new BEDocument()
                {
                    COD_DOCU = Convert.ToInt32(txtCOD_DOCU.Text),
                    IND_ESTA = lkeIND_ESTA.EditValue.ToString(),
                    COD_SUCU = SESSION_COMP,
                    IND_TIPO_COMP = rdgIND_TIPO_COMP.EditValue.ToString(),
                    COD_SOCI_NEGO = Convert.ToInt32(bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption),
                    ALF_SOCI_NEGO = bteCOD_SOCI_NEGO.Text,
                    ALF_NUM_RUCC = txtALF_NUM_RUCC.Text,
                    ALF_DIRE_FISC = mmeALF_DIRE_FISC.Text.Trim(),
                    ALF_DIRE_ENTR = mmeALF_DIRE_ENTR.Text.Trim(),
                    COD_MONE = (int?)lkeCOD_MONE.EditValue,
                    NUM_TIPO_CAMB = (decimal?)txtNUM_TIPO_CAMB.EditValue,
                    COD_COND_PAGO = (int?)lkeCOD_COND_PAGO.EditValue,
                    COD_ALMA = (int?)lkeCOD_ALMA.EditValue,
                    FEC_REGI = (DateTime?)dteFEC_REGI.EditValue,
                    FEC_ENTR = (DateTime?)dteFEC_ENTR.EditValue,
                    FEC_DOCU = (DateTime?)dteFEC_DOCU.EditValue,
                    FEC_PAGO = (DateTime?)dteFEC_PAGO.EditValue,
                    ALF_COME = mmeALF_COME.Text.Trim(),
                    NUM_SUBB_TOTA = Convert.ToDecimal(txtNUM_SUBB_TOTA.EditValue),
                    NUM_DESC = Convert.ToDecimal(txtNUM_DESC.EditValue),
                    NUM_IGVV = Convert.ToDecimal(txtNUM_IGVV.EditValue),
                    NUM_TOTA = Convert.ToDecimal(txtNUM_TOTA.EditValue)
                };
                xfCreditNote.SgIns.docb = odoc;
                xfCreditNote.SgIns.MdiParent = MdiParent;
                xfCreditNote.SgIns.Activate();
                xfCreditNote.SgIns.FORM_SUBO = "bbiSupplierCreditNote";
                xfCreditNote.SgIns.Show();
                xfCreditNote.SgIns.BringToFront();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                    _Message.MsgInsCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void Get_Load()
        {
            stcControl.AppearanceReadOnly.BackColor = Color.FromArgb(255, 227, 239, 255);

            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            InitializeCopy();

            dteFEC_REGI.EditValue = DateTime.Now;
            dteFEC_DOCU.EditValue = DateTime.Now;
            dteFEC_ENTR.EditValue = DateTime.Now;            

            var obr = new BRPurchase();
            var olcp = obr.Get_PSGN_SPLS_SVMC_COND_PAGO(SESSION_COMP);
            var olmo = obr.Get_PSGN_SPLS_SVMC_MONE(SESSION_COMP);

            lkeCOD_COND_PAGO.Properties.DataSource = olcp;
            lkeCOD_COND_PAGO.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_COND_PAGO", "Condición de Pago", 20);
            lkeCOD_COND_PAGO.Properties.Columns.Add(lkci);
            lkeCOD_COND_PAGO.Properties.DisplayMember = "ALF_COND_PAGO";
            lkeCOD_COND_PAGO.Properties.ValueMember = "COD_COND_PAGO";

            lkeCOD_MONE.Properties.DataSource = olmo;
            lkeCOD_MONE.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MONE", "Moneda", 20);
            lkeCOD_MONE.Properties.Columns.Add(lkci);
            lkeCOD_MONE.Properties.DisplayMember = "ALF_MONE";
            lkeCOD_MONE.Properties.ValueMember = "COD_MONE";
            lkeCOD_MONE.ItemIndex = 0;

            var olstt = new List<BEStatus>();
            olstt.Add(new BEStatus() { COD_ESTA = "AB", ALF_ESTA = "Abierto" });
            olstt.Add(new BEStatus() { COD_ESTA = "CE", ALF_ESTA = "Cerrado" });
            olstt.Add(new BEStatus() { COD_ESTA = "AN", ALF_ESTA = "Anulado" });
            lkeIND_ESTA.Properties.DataSource = olstt;
            lkeIND_ESTA.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_ESTA", "Estado", 20);
            lkeIND_ESTA.Properties.Columns.Add(lkci);
            lkeIND_ESTA.Properties.DisplayMember = "ALF_ESTA";
            lkeIND_ESTA.Properties.ValueMember = "COD_ESTA";
            lkeIND_ESTA.ItemIndex = 0;

            var obral = new BRWarehouse();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);

            lkeCOD_ALMA.Properties.DataSource = olsal;
            lkeCOD_ALMA.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén", 20);
            lkeCOD_ALMA.Properties.Columns.Add(lkci);
            lkeCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            lkeCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            gdcLines.DataSource = new List<BEDocumentLines>();
            SetChangeMaskMoney(0);
            StateControls(true);
            if (docb != null)
                Set_DocumentBase();

        }
        private void Set_DocumentBase()
        {
            ClearControls();
            StateControls(false);

            rdgIND_TIPO_COMP.EditValue = docb.IND_TIPO_COMP;
            bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption = docb.COD_SOCI_NEGO.ToString();
            bteCOD_SOCI_NEGO.Text = docb.ALF_SOCI_NEGO;
            lkeCOD_COND_PAGO.EditValue = docb.COD_COND_PAGO;
            lkeCOD_ALMA.EditValue = docb.COD_ALMA;
            lkeCOD_MONE.EditValue = docb.COD_MONE;
            txtNUM_TIPO_CAMB.EditValue = docb.NUM_TIPO_CAMB;
            lkeIND_ESTA.EditValue = docb.IND_ESTA;
            dteFEC_REGI.EditValue = docb.FEC_REGI;
            dteFEC_ENTR.EditValue = docb.FEC_ENTR;
            dteFEC_DOCU.EditValue = docb.FEC_DOCU;
            dteFEC_PAGO.EditValue = docb.FEC_PAGO;
            txtALF_NUM_RUCC.Text = docb.ALF_NUM_RUCC;
            mmeALF_DIRE_FISC.Text = docb.ALF_DIRE_FISC;
            mmeALF_DIRE_ENTR.Text = docb.ALF_DIRE_ENTR;
            mmeALF_COME.Text = docb.ALF_COME;

            var obj = new BEDocument() { COD_DOCU = docb.COD_DOCU };
            var obr = new BRPurchase();
            var olst = obr.Get_PSCP_SPLS_SCPD_GUIA(obj);
            olst.ForEach(item => 
            {
                item.TIP_DOCU_BASE = 2;
                item.COD_DOCU_BASE = item.COD_DOCU;
                item.NUM_LINE_BASE = item.NUM_LINE;
                item.COD_ARTI_BASE = item.COD_ARTI;
            });

            gdcLines.DataSource = olst;
            gdvLines.RefreshData();

            txtNUM_SUBB_TOTA.EditValue = docb.NUM_SUBB_TOTA;
            txtNUM_DESC.EditValue = docb.NUM_DESC;
            txtNUM_IGVV.EditValue = docb.NUM_IGVV;
            txtNUM_TOTA.EditValue = docb.NUM_TOTA;

            var SIMB = (BESVMC_MONE)lkeCOD_MONE.GetSelectedDataRow();
            var molt = new BRNumLetter();
            lblTotalLetter.Text = molt.Convertir(docb.NUM_TOTA.ToString(), true, SIMB.ALF_MONE_SIMB);
        }
        private void xfInvoice_Load(object sender, EventArgs e)
        {
            Get_Load();            
        }
        private void lkeCOD_MONE_EditValueChanged(object sender, EventArgs e)
        {
            if (lkeCOD_MONE.ItemIndex == 1)
            {
                txtNUM_TIPO_CAMB.EditValue = null;
                txtNUM_TIPO_CAMB.Properties.ReadOnly = true;
            }
            else
            {
                var obr = new BRPurchase();
                var TIPO_CAMB = obr.Get_PSGN_SPLS_SVMC_TIPO_CAMB(SESSION_COMP, 1);
                txtNUM_TIPO_CAMB.EditValue = TIPO_CAMB;
                txtNUM_TIPO_CAMB.Properties.ReadOnly = (string.IsNullOrWhiteSpace(txtCOD_DOCU.Text)) ? false : true; ;
                txtNUM_TIPO_CAMB.Focus();
                txtNUM_TIPO_CAMB.SelectAll();
            }

            SetChangeMaskMoney(lkeCOD_MONE.ItemIndex);
        }
        private void SetChangeMaskMoney(int mone)
        {
            var omsk = new MaskProperties() 
            {
                Culture = new CultureInfo((mone == 1) ? "es-PE" : "en-US"),
                EditMask = "c2", 
                MaskType = MaskType.Numeric,                
                UseMaskAsDisplayFormat = true 
            };

            ritPrice.Mask.Assign(omsk);
            ritDiscount.Mask.Assign(omsk);
            ritAmount.Mask.Assign(omsk);

            txtNUM_SUBB_TOTA.Properties.Mask.Assign(omsk);
            txtNUM_DESC.Properties.Mask.Assign(omsk);
            txtNUM_IGVV.Properties.Mask.Assign(omsk);
            txtNUM_TOTA.Properties.Mask.Assign(omsk);

            decimal TIP_CAMB = 1;
            if (mone == 1)
            {
                if (txtNUM_TIPO_CAMB.EditValue == null)
                    TIP_CAMB = ((xfMain)MdiParent).SESSION_NUM_TIPO_CAMB_COMP;
            }

            var lines = (List<BEDocumentLines>)gdvLines.DataSource;
            if (lines == null) return;
            lines.ForEach(item => 
            {
                item.NUM_PREC_UNIT = Math.Round(item.NUM_PREC_UNIT_ORIG * TIP_CAMB, 2);
                item.NUM_DESC = Math.Round((item.NUM_PREC_UNIT * item.NUM_PORC_DESC) / 100, 2);
                item.NUM_PREC_DESC = item.NUM_PREC_UNIT - item.NUM_DESC;
                item.NUM_IMPO = item.NUM_CANT * item.NUM_PREC_DESC;
            });

            gdvLines.RefreshData();
            Set_Totals();
        }
        private void bteCOD_SOCI_NEGO_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oxfs = new xfSearchPerson(SESSION_COMP) { NUM_ACCI = 8 };
            if (oxfs.ShowDialog() == DialogResult.OK)
            {
                bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption = oxfs.oBe.COD_SOCI_NEGO.ToString();
                bteCOD_SOCI_NEGO.Text = oxfs.oBe.ALF_NOMB;
                mmeALF_DIRE_FISC.Text = oxfs.oBe.ALF_DIRE_FISC;
                lkeCOD_COND_PAGO.EditValue = oxfs.oBe.COD_COND_PAGO;
                txtALF_NUM_RUCC.Text = oxfs.oBe.ALF_NUME_IDEN;

                var row = (BESVMC_COND_PAGO)lkeCOD_COND_PAGO.GetSelectedDataRow();
                if (row != null)
                {
                    var dpag = DateTime.Now.AddDays(row.NUM_DIAS);
                    dteFEC_PAGO.EditValue = dpag;
                }
            }
        }

        private void lkeCOD_COND_PAGO_EditValueChanged(object sender, EventArgs e)
        {
            var row = (BESVMC_COND_PAGO)lkeCOD_COND_PAGO.GetSelectedDataRow();
            if (row != null)
            {
                var dpag = DateTime.Now.AddDays(row.NUM_DIAS);
                dteFEC_PAGO.EditValue = dpag;
            }
        }
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    gdvLines.CloseEditor();
                    gdvLines.RefreshData();
                    var olst = (List<BEDocumentLines>)gdvLines.DataSource;
                    var i = 1;
                    olst.ForEach(obej =>
                    {
                        var context = new ValidationContext(obej, null, null);
                        var errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(obej, context, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                                throw new ArgumentException(string.Format("{0}\nFila: {1}", result.ErrorMessage, i));
                        }
                        i++;
                    });

                    var obj = new BEDocumentLines() { COD_USUA_CREA = SESSION_USER };
                    olst.Add(obj);
                    gdvLines.RefreshData();
                    gdvLines.MoveLast();
                    gdvLines.FocusedColumn = gcALF_CODI_ARTI;
                    gdvLines.ShowEditor();
                }
                else
                {
                    gdvLines.DeleteRow(gdvLines.FocusedRowHandle);
                    gdvLines.RefreshData();
                }
                Set_Totals();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    _Message.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        private void gdcLines_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var index = ((NavigatorCustomButton)e.Button).Index;
            Set_Operation(index);
        }

        private void rpiArticle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oxf = new xfSearchArticle();
            if (oxf.ShowDialog() == DialogResult.OK)
            {
                var olst = (List<BEDocumentLines>)gdvLines.DataSource;
                var exist = olst.Exists(item => item.COD_ARTI == oxf.rowsel.COD_ARTI);
                if (!exist)
                {
                    decimal TIP_CAMB = 1;
                    if (lkeCOD_MONE.ItemIndex == 1)
                    {
                        if (txtNUM_TIPO_CAMB.EditValue == null)
                            TIP_CAMB = ((xfMain)MdiParent).SESSION_NUM_TIPO_CAMB_COMP;
                    }
                    var row = new BEDocumentLines()
                    {
                        COD_ARTI = oxf.rowsel.COD_ARTI,
                        ALF_CODI_ARTI = oxf.rowsel.ALF_CODI_ARTI,
                        ALF_ARTI = oxf.rowsel.ALF_ARTI,
                        NUM_CANT = 1,
                        NUM_PREC_UNIT_ORIG = oxf.rowsel.NUM_PREC,
                        NUM_PREC_UNIT = Math.Round(oxf.rowsel.NUM_PREC * TIP_CAMB, 2),
                        NUM_PORC_DESC = oxf.rowsel.NUM_DESC,
                        COD_USUA_CREA = SESSION_USER
                    };

                    row.NUM_DESC = Math.Round((row.NUM_PREC_UNIT * row.NUM_PORC_DESC) / 100, 2);
                    row.NUM_PREC_DESC = row.NUM_PREC_UNIT - row.NUM_DESC;
                    row.NUM_IMPO = row.NUM_CANT * row.NUM_PREC_DESC;

                    gdvLines.DeleteRow(gdvLines.FocusedRowHandle);
                    olst.Add(row);
                    gdvLines.RefreshData();
                    gdvLines.MoveLast();
                    gdvLines.FocusedColumn = gcNUM_CANT;
                    gdvLines.ShowEditor();

                    Set_Totals();
                }
                else
                {
                    XtraMessageBox.Show(_Message.MsgExistArticle, _Message.MsgInsCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void xfInvoice_Activated(object sender, EventArgs e)
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

        private void xfInvoice_Deactivate(object sender, EventArgs e)
        {
            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
                itemLink.Item.Visibility = BarItemVisibility.Never;
        }

        private void xfInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;

            ddbCopy.HideDropDown();
        }

        private void gdvLines_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                var gr = e.Info.Graphics;
                gr.PageUnit = GraphicsUnit.Pixel;
                var gridView = ((GridView)sender);
                var size = gr.MeasureString(gridView.RowCount.ToString(), e.Info.Appearance.Font);
                gridView.IndicatorWidth = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        private void Set_Totals()
        {
            var lines = (List<BEDocumentLines>)gdvLines.DataSource;
            var amount = lines.Sum(item => item.NUM_IMPO);
            var descue = Convert.ToDecimal(txtNUM_DESC.EditValue);
            var amodes = amount - descue;
            var igv = (rdgIND_TIPO_COMP.SelectedIndex == 1) ? Math.Round((amodes * 18) / 100, 2) : Convert.ToDecimal(0.00);
            var total = amodes + igv;

            txtNUM_SUBB_TOTA.EditValue = amount;
            txtNUM_IGVV.EditValue = igv;
            txtNUM_TOTA.EditValue = total;

            var SIMB = (BESVMC_MONE)lkeCOD_MONE.GetSelectedDataRow();
            var molt = new BRNumLetter();
            lblTotalLetter.Text = molt.Convertir(txtNUM_TOTA.EditValue.ToString(), true, SIMB.ALF_MONE_SIMB);
        }
        private void Set_TotalLine(BEDocumentLines row)
        {
            row.NUM_PREC_DESC = row.NUM_PREC_UNIT - row.NUM_DESC;
            row.NUM_IMPO = row.NUM_CANT * row.NUM_PREC_DESC;
            gdvLines.RefreshRow(gdvLines.FocusedRowHandle);
        }

        private void ritQuantity_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            var row = (BEDocumentLines)gdvLines.GetRow(gdvLines.FocusedRowHandle);
            row.NUM_CANT = Convert.ToDecimal(e.NewValue);            
            Set_TotalLine(row);
            Set_Totals();
        }

        private void ritPercent_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            var row = (BEDocumentLines)gdvLines.GetRow(gdvLines.FocusedRowHandle);
            row.NUM_PORC_DESC = Convert.ToDecimal(e.NewValue);
            row.NUM_DESC = Math.Round((row.NUM_PREC_UNIT * row.NUM_PORC_DESC) / 100, 2);
            Set_TotalLine(row);
            Set_Totals();
        }

        private void ritDiscount_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            var row = (BEDocumentLines)gdvLines.GetRow(gdvLines.FocusedRowHandle);
            row.NUM_DESC = Convert.ToDecimal(e.NewValue);
            row.NUM_PORC_DESC = Math.Round((100 * row.NUM_DESC) / row.NUM_PREC_UNIT, 2);
            Set_TotalLine(row);
            Set_Totals();
        }

        private void txtNUM_TIPO_CAMB_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            decimal TIP_CAMB = 1;
            if (lkeCOD_MONE.ItemIndex == 1)
            {
                if (Convert.ToDecimal(e.NewValue) != 0)
                    TIP_CAMB = Convert.ToDecimal(e.NewValue);
            }

            var lines = (List<BEDocumentLines>)gdvLines.DataSource;
            if (lines == null) return;
            lines.ForEach(item =>
            {
                item.NUM_PREC_UNIT = Math.Round(item.NUM_PREC_UNIT_ORIG / TIP_CAMB, 2);
                item.NUM_DESC = Math.Round((item.NUM_PREC_UNIT * item.NUM_PORC_DESC) / 100, 2);
                item.NUM_PREC_DESC = item.NUM_PREC_UNIT - item.NUM_DESC;
                item.NUM_IMPO = item.NUM_CANT * item.NUM_PREC_DESC;
            });

            gdvLines.RefreshData();
            Set_Totals();
        }

        private void txtNUM_DESC_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            var lines = (List<BEDocumentLines>)gdvLines.DataSource;
            var amount = lines.Sum(item => item.NUM_IMPO);
            var descue = Convert.ToDecimal(e.NewValue);
            var amodes = amount - descue;
            var igv = (rdgIND_TIPO_COMP.SelectedIndex == 1) ? Math.Round((amodes * 18) / 100, 2) : Convert.ToDecimal(0.00);
            var total = amodes + igv;

            txtNUM_SUBB_TOTA.EditValue = amount;
            txtNUM_IGVV.EditValue = igv;
            txtNUM_TOTA.EditValue = total;

            var SIMB = (BESVMC_MONE)lkeCOD_MONE.GetSelectedDataRow();
            var molt = new BRNumLetter();
            lblTotalLetter.Text = molt.Convertir(txtNUM_TOTA.EditValue.ToString(), true, SIMB.ALF_MONE_SIMB);
        }

        public void Set_Save()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                if (string.IsNullOrWhiteSpace(txtALF_NUM_SERI.Text))
                    throw new ArgumentException(_Message.MsgReqALF_NUM_SERI);
                if (string.IsNullOrWhiteSpace(txtALF_NUM_CORR.Text))
                    throw new ArgumentException(_Message.MsgReqALF_NUM_CORR);
                if (string.IsNullOrWhiteSpace(bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption))
                    throw new ArgumentException(_Message.MsgReqCOD_SOCI_NEGO);

                var odoc = new BEDocument()
                {
                    COD_DOCU = (!string.IsNullOrWhiteSpace(txtCOD_DOCU.Text)) ? Convert.ToInt32(txtCOD_DOCU.Text) : (int?)null,
                    ALF_NUM_SERI = txtALF_NUM_SERI.Text.Trim(),
                    ALF_NUM_CORR = txtALF_NUM_CORR.Text.Trim(),
                    IND_ESTA = lkeIND_ESTA.EditValue.ToString(),
                    COD_SUCU = SESSION_COMP,
                    IND_TIPO_COMP = rdgIND_TIPO_COMP.EditValue.ToString(),
                    COD_SOCI_NEGO = Convert.ToInt32(bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption),
                    ALF_SOCI_NEGO = bteCOD_SOCI_NEGO.Text,
                    ALF_NUM_RUCC = txtALF_NUM_RUCC.Text,
                    ALF_DIRE_FISC = mmeALF_DIRE_FISC.Text.Trim(),
                    ALF_DIRE_ENTR = mmeALF_DIRE_ENTR.Text.Trim(),
                    COD_MONE = (int?)lkeCOD_MONE.EditValue,
                    NUM_TIPO_CAMB = (decimal?)txtNUM_TIPO_CAMB.EditValue,
                    COD_COND_PAGO = (int?)lkeCOD_COND_PAGO.EditValue,
                    COD_ALMA = (int?)lkeCOD_ALMA.EditValue,
                    FEC_REGI = (DateTime?)dteFEC_REGI.EditValue,
                    FEC_ENTR = (DateTime?)dteFEC_ENTR.EditValue,
                    FEC_DOCU = (DateTime?)dteFEC_DOCU.EditValue,
                    FEC_PAGO = (DateTime?)dteFEC_PAGO.EditValue,
                    ALF_COME = mmeALF_COME.Text.Trim(),
                    NUM_SUBB_TOTA = Convert.ToDecimal(txtNUM_SUBB_TOTA.EditValue),
                    NUM_DESC = Convert.ToDecimal(txtNUM_DESC.EditValue),
                    NUM_IGVV = Convert.ToDecimal(txtNUM_IGVV.EditValue),
                    NUM_TOTA = Convert.ToDecimal(txtNUM_TOTA.EditValue),
                    COD_USUA_CREA = SESSION_USER,
                    COD_USUA_MODI = SESSION_USER,
                    IND_MNTN = (!string.IsNullOrWhiteSpace(txtCOD_DOCU.Text)) ? 2 : 1
                };

                var context = new ValidationContext(odoc, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(odoc, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                gdvLines.CloseEditor();
                gdvLines.RefreshData();
                var lines = (List<BEDocumentLines>)gdvLines.DataSource;
                if (lines.Count == 0)
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(_Message.MsgManyRows);
                }

                var i = 1;
                lines.ForEach(item =>
                {
                    context = new ValidationContext(item, null, null);
                    errors = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(item, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            msgIcon = MessageBoxIcon.Warning;
                            throw new ArgumentException(string.Format("{0}\nFila: {1}", result.ErrorMessage, i));
                        }
                    }
                    i++;
                });

                var obr = new BRPurchase();
                obr.Set_PSCP_SPMT_SCPC_OINV(odoc, lines);
                if (!string.IsNullOrWhiteSpace(odoc.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(odoc.MSG_MNTN);
                }
                txtCOD_DOCU.Text = odoc.COD_DOCU.ToString();
                gdvLines.RefreshData();
                StateControls(true);
                xfDelivery.SgIns.lkeIND_ESTA.EditValue = "CE";
                XtraMessageBox.Show(_Message.MsgSuccessfully, _Message.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    _Message.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    msgIcon);
            }
        }
        public void Edit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCOD_DOCU.Text))
                    throw new ArgumentException(_Message.MsgSelectDoc);
                if (lkeIND_ESTA.EditValue.ToString() != "AB")
                    throw new ArgumentException(_Message.MsgNotModyDocuSta + lkeIND_ESTA.Text);
                StateControls(false);
                bteCOD_SOCI_NEGO.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, 
                                    _Message.MsgInsCaption, 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
            }
        }

        private void Set_Invoice(BEDocument row)
        {
            ClearControls();
            txtCOD_DOCU.Text = row.COD_DOCU.ToString();
            rdgIND_TIPO_COMP.EditValue = row.IND_TIPO_COMP;
            bteCOD_SOCI_NEGO.Properties.Buttons[0].Caption = row.COD_SOCI_NEGO.ToString();
            bteCOD_SOCI_NEGO.Text = row.ALF_SOCI_NEGO;
            txtALF_NUM_SERI.Text = row.ALF_NUM_SERI;
            txtALF_NUM_CORR.Text = row.ALF_NUM_CORR;
            lkeCOD_COND_PAGO.EditValue = row.COD_COND_PAGO;
            lkeCOD_ALMA.EditValue = row.COD_ALMA;
            lkeCOD_MONE.EditValue = row.COD_MONE;
            txtNUM_TIPO_CAMB.EditValue = row.NUM_TIPO_CAMB;
            lkeIND_ESTA.EditValue = row.IND_ESTA;
            dteFEC_REGI.EditValue = row.FEC_REGI;
            dteFEC_ENTR.EditValue = row.FEC_ENTR;
            dteFEC_DOCU.EditValue = row.FEC_DOCU;
            dteFEC_PAGO.EditValue = row.FEC_PAGO;
            txtALF_NUM_RUCC.Text = row.ALF_NUM_RUCC;
            mmeALF_DIRE_FISC.Text = row.ALF_DIRE_FISC;
            mmeALF_DIRE_ENTR.Text = row.ALF_DIRE_ENTR;
            mmeALF_COME.Text = row.ALF_COME;

            var obj = new BEDocument() { COD_DOCU = row.COD_DOCU };
            var obr = new BRPurchase();
            var olst = obr.Get_PSCP_SPLS_SCPD_OINV(obj);

            gdcLines.DataSource = olst;
            gdvLines.RefreshData();

            txtNUM_SUBB_TOTA.EditValue = row.NUM_SUBB_TOTA;
            txtNUM_DESC.EditValue = row.NUM_DESC;
            txtNUM_IGVV.EditValue = row.NUM_IGVV;
            txtNUM_TOTA.EditValue = row.NUM_TOTA;

            var SIMB = (BESVMC_MONE)lkeCOD_MONE.GetSelectedDataRow();
            var molt = new BRNumLetter();
            lblTotalLetter.Text = molt.Convertir(row.NUM_TOTA.ToString(), true, SIMB.ALF_MONE_SIMB);

            StateControls(true);
            txtCOD_DOCU.Focus();
        }
        public void Set_Search()
        {
            var ofx = new xfInvoiceSearch() { SESSION_COMP = SESSION_COMP };
            if (ofx.ShowDialog() == DialogResult.OK)
                Set_Invoice(ofx.rowsel);
        }

        private void ritPrice_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue == null) return;
            if (string.IsNullOrWhiteSpace(e.NewValue.ToString())) e.NewValue = 0;
            var row = (BEDocumentLines)gdvLines.GetRow(gdvLines.FocusedRowHandle);
            row.NUM_PREC_UNIT = Convert.ToDecimal(e.NewValue);
            row.NUM_DESC = Math.Round((row.NUM_PREC_UNIT * row.NUM_PORC_DESC) / 100, 2);
            Set_TotalLine(row);
            Set_Totals();
        }

        private void rdgIND_TIPO_COMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Totals();
        }
        private void ddbCopy_Leave(object sender, EventArgs e)
        {
            ddbCopy.HideDropDown();
        }
    }
}