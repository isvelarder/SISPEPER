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
using SISPEPERS.Security;
using BusinessEntities.Management;
using BusinessRules.Management;

namespace SISPEPERS
{
    public partial class xfMain : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm fra { get; set; }
        public string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string SESSION_IMPU { get; set; }
        public decimal SESSION_PORC_IMPU { get; set; }
        public decimal SESSION_NUM_TIPO_CAMB_COMP { get; set; }

        private static xfMain mSgIns;
        public static xfMain SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfMain();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfMain()
        {
            InitializeComponent();
        }

        private void xfMain_Load(object sender, EventArgs e)
        {
            barMenu.Visible = false;
            barTool.Visible = false;
            barStatus.Visible = false;

            var oForm = new xfLogin();

            DialogResult oResult = oForm.ShowDialog();

            if (oResult == DialogResult.OK)
            {
                barTool.Visible = true;
                barMenu.Visible = true;
                barStatus.Visible = true;

                beiUser.Caption = oForm.oBe.ALF_NOMB;
                SESSION_USER = oForm.oBe.COD_USUA;
                SESSION_PERF = oForm.oBe.COD_PERF;
                SESSION_COMP = oForm.oBe.COD_COMP;
                SESSION_IMPU = oForm.oBe.ALF_IMPU;
                SESSION_PORC_IMPU = oForm.oBe.NUM_PORC_IMPU;

                SgIns.SESSION_USER = oForm.oBe.COD_USUA;
                SgIns.SESSION_PERF = oForm.oBe.COD_PERF;
                SgIns.SESSION_COMP = oForm.oBe.COD_COMP;
                SgIns.SESSION_IMPU = oForm.oBe.ALF_IMPU;
                SgIns.SESSION_PORC_IMPU = oForm.oBe.NUM_PORC_IMPU;

                var oBeTC = new BESVMC_TIPO_CAMB();
                var oBrTC = new BRSVMC_TIPO_CAMB();

                oBeTC.COD_COMP = SESSION_COMP;
                oBeTC.NUM_ACCI = 5;
                var oListTC = oBrTC.Get_SVPR_TIPO_CAMB_LIST(oBeTC);
                SESSION_NUM_TIPO_CAMB_COMP = (oListTC.Count == 0) ? 1 : oListTC[0].NUM_TIPO_CAMB_COMP;

                var oBe = new BESVMD_ACCE();
                var oBr = new BRSVMD_ACCE();

                oBe.NUM_ACCI = 4;
                oBe.COD_PERF = SESSION_PERF;

                var oListOpti = oBr.Get_SVPR_ACCE_LIST(oBe);

                foreach (BarItemLink itemLink in bsiManagement.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiSales.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiShopping.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiWarehouse.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiQueryReports.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiGenerics.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarItemLink itemLink in bsiSecurity.ItemLinks)
                {
                    if (oListOpti.Count(obj => obj.ALF_NOMB.Equals(itemLink.Item.Name)) > 0)
                        itemLink.Item.Enabled = true;
                    else
                        itemLink.Item.Enabled = false;
                }
                foreach (BarButtonItemLink itemLink in barTool.ItemLinks)
                {
                    itemLink.Item.Visibility = BarItemVisibility.Never;
                }
            }
            else
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void bbiSecurityUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Seguridad.xfUsuario.SgIns.MdiParent = this;
            Seguridad.xfUsuario.SgIns.Activate();
            Seguridad.xfUsuario.SgIns.FORM_SUBO = "bbiSecurityUsers";
            Seguridad.xfUsuario.SgIns.Show();
            Seguridad.xfUsuario.SgIns.BringToFront();
        }

        private void bbiSecurityProfiles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Seguridad.xfProfiles.SgIns.MdiParent = this;
            Seguridad.xfProfiles.SgIns.Activate();
            Seguridad.xfProfiles.SgIns.FORM_SUBO = "bbiSecurityProfiles";
            Seguridad.xfProfiles.SgIns.Show();
            Seguridad.xfProfiles.SgIns.BringToFront();
        }

        private void bbiSecurityCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Seguridad.xfCompany.SgIns.MdiParent = this;
            Seguridad.xfCompany.SgIns.Activate();
            Seguridad.xfCompany.SgIns.FORM_SUBO = "bbiSecurityCompany";
            Seguridad.xfCompany.SgIns.Show();
            Seguridad.xfCompany.SgIns.BringToFront();
        }

        private void bbiManagementBusinessPartner_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Management.xfBusinessPartner.SgIns.MdiParent = this;
            Management.xfBusinessPartner.SgIns.Activate();
            Management.xfBusinessPartner.SgIns.FORM_SUBO = "bbiManagementBusinessPartner";
            Management.xfBusinessPartner.SgIns.Show();
            Management.xfBusinessPartner.SgIns.BringToFront();
        }

        private void bbiMasterItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Warehouse.xfArticle.SgIns.MdiParent = this;
            Warehouse.xfArticle.SgIns.Activate();
            Warehouse.xfArticle.SgIns.FORM_SUBO = "bbiMasterItems";
            Warehouse.xfArticle.SgIns.Show();
            Warehouse.xfArticle.SgIns.BringToFront();
        }

        private void bbiQuote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var oBeTC = new BESVMC_TIPO_CAMB();
                var oBrTC = new BRSVMC_TIPO_CAMB();

                oBeTC.COD_COMP = SESSION_COMP;
                oBeTC.NUM_ACCI = 5;
                var oListTC = oBrTC.Get_SVPR_TIPO_CAMB_LIST(oBeTC);

                if (oListTC.Count == 0)
                    throw new ArgumentException("El tipo de cambio del dia no esta registrado");

                Sales.xfQuote.SgIns.MdiParent = this;
                Sales.xfQuote.SgIns.Activate();
                Sales.xfQuote.SgIns.FORM_SUBO = "bbiQuote";
                Sales.xfQuote.SgIns.Show();
                Sales.xfQuote.SgIns.BringToFront();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfProfiles"))
                Seguridad.xfProfiles.SgIns.New();
            else if (fra.Name.Equals("xfCompany"))
                Seguridad.xfCompany.SgIns.New();
            else if (fra.Name.Equals("xfPriceList"))
                Warehouse.xfPriceList.SgIns.New();
            else if (fra.Name.Equals("xfTypeBusinessPartner"))
                Generics.xfTypeBusinessPartner.SgIns.New();
            else if (fra.Name.Equals("xfTypeIdentification"))
                Generics.xfTypeIdentification.SgIns.New();
            else if (fra.Name.Equals("xfTypeContact"))
                Generics.xfTypeContact.SgIns.New();
            else if (fra.Name.Equals("xfCountry"))
                Generics.xfCountry.SgIns.New();
            else if (fra.Name.Equals("xfPaymentTerm"))
                Generics.xfPaymentTerm.SgIns.New();
            else if (fra.Name.Equals("xfBusinessPartner"))
                Management.xfBusinessPartner.SgIns.New();
            else if (fra.Name.Equals("xfUsuario"))
                Seguridad.xfUsuario.SgIns.New();
            else if (fra.Name.Equals("xfExchangeRate"))
                Management.xfExchangeRate.SgIns.New();
            else if (fra.Name.Equals("xfSeries"))
                Management.xfSeries.SgIns.New();
            else if (fra.Name.Equals("xfBranch"))
                Generics.xfBranch.SgIns.New();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.New();
            else if (fra.Name.Equals("xfArticle"))
                Warehouse.xfArticle.SgIns.Set_New();
            else if (fra.Name.Equals("xfWarehouseMaster"))
                Warehouse.xfWarehouseMaster.SgIns.New();
            else if (fra.Name.Equals("xfEntryGoods"))
                Warehouse.xfEntryGoods.SgIns.Set_New();
            else if (fra.Name.Equals("xfReasonEntry"))
                Generics.xfReasonEntry.SgIns.New();
            else if (fra.Name.Equals("xfReasonOutput"))
                Generics.xfReasonOutput.SgIns.New();
            else if (fra.Name.Equals("xfReasonTransfer"))
                Generics.xfReasonTransfer.SgIns.New();
            else if (fra.Name.Equals("xfReasonReceiving"))
                Generics.xfReasonReceiving.SgIns.New();
            else if (fra.Name.Equals("xfOutputGoods"))
                Warehouse.xfOutputGoods.SgIns.Set_New();
            else if (fra.Name.Equals("xfTransferGoods"))
                Warehouse.xfTransferGoods.SgIns.Set_New();
            else if (fra.Name.Equals("xfReceivingGoods"))
                Warehouse.xfReceivingGoods.SgIns.Set_New();
            else if (fra.Name.Equals("xfCurrency"))
                Generics.xfCurrency.SgIns.New();
            else if (fra.Name.Equals("xfPurchaseOrder"))
                Purchase.xfPurchaseOrder.SgIns.New();
            else if (fra.Name.Equals("xfDelivery"))
                Purchase.xfDelivery.SgIns.New();
            else if (fra.Name.Equals("xfInvoice"))
                Purchase.xfInvoice.SgIns.New();
            else if (fra.Name.Equals("xfCreditNote"))
                Purchase.xfCreditNote.SgIns.New();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.New();
            else if (fra.Name.Equals("xfModelArticle"))
                Generics.xfModelArticle.SgIns.New();
            else if (fra.Name.Equals("xfTypeArticle"))
                Generics.xfTypeArticle.SgIns.New();
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
                Sales.xfSalesCreditNoteFactoring.SgIns.New();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            else if (fra.Name.Equals("xfProfiles"))
                Seguridad.xfProfiles.SgIns.Edit();
            else if (fra.Name.Equals("xfCompany"))
                Seguridad.xfCompany.SgIns.Edit();
            else if (fra.Name.Equals("xfPriceList"))
                Warehouse.xfPriceList.SgIns.Edit();
            else if (fra.Name.Equals("xfTypeBusinessPartner"))
                Generics.xfTypeBusinessPartner.SgIns.Edit();
            else if (fra.Name.Equals("xfTypeIdentification"))
                Generics.xfTypeIdentification.SgIns.Edit();
            else if (fra.Name.Equals("xfTypeContact"))
                Generics.xfTypeContact.SgIns.Edit();
            else if (fra.Name.Equals("xfCountry"))
                Generics.xfCountry.SgIns.Edit();
            else if (fra.Name.Equals("xfPaymentTerm"))
                Generics.xfPaymentTerm.SgIns.Edit();
            else if (fra.Name.Equals("xfBusinessPartner"))
                Management.xfBusinessPartner.SgIns.Edit();
            else if (fra.Name.Equals("xfUsuario"))
                Seguridad.xfUsuario.SgIns.Edit();
            else if (fra.Name.Equals("xfExchangeRate"))
                Management.xfExchangeRate.SgIns.Edit();
            else if (fra.Name.Equals("xfSeries"))
                Management.xfSeries.SgIns.Edit();
            else if (fra.Name.Equals("xfBranch"))
                Generics.xfBranch.SgIns.Edit();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Edit();
            else if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.Edit();
            else if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.Edit();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.Edit();
            else if (fra.Name.Equals("xfArticle"))
                Warehouse.xfArticle.SgIns.Set_Edit();
            else if (fra.Name.Equals("xfWarehouseMaster"))
                Warehouse.xfWarehouseMaster.SgIns.Edit();
            else if (fra.Name.Equals("xfReasonEntry"))
                Generics.xfReasonEntry.SgIns.Edit();
            else if (fra.Name.Equals("xfReasonOutput"))
                Generics.xfReasonOutput.SgIns.Edit();
            else if (fra.Name.Equals("xfReasonTransfer"))
                Generics.xfReasonTransfer.SgIns.Edit();
            else if (fra.Name.Equals("xfReasonReceiving"))
                Generics.xfReasonReceiving.SgIns.Edit();
            else if (fra.Name.Equals("xfCurrency"))
                Generics.xfCurrency.SgIns.Edit();
            else if (fra.Name.Equals("xfPurchaseOrder")) 
                Purchase.xfPurchaseOrder.SgIns.Edit(); 
            else if (fra.Name.Equals("xfDelivery")) 
                Purchase.xfDelivery.SgIns.Edit(); 
            else if (fra.Name.Equals("xfInvoice")) 
                Purchase.xfInvoice.SgIns.Edit(); 
            else if (fra.Name.Equals("xfCreditNote")) 
                Purchase.xfCreditNote.SgIns.Edit();
            else if (fra.Name.Equals("xfModelArticle"))
                Generics.xfModelArticle.SgIns.Edit();
            else if (fra.Name.Equals("xfTypeArticle"))
                Generics.xfTypeArticle.SgIns.Edit();
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfProfiles"))
                Seguridad.xfProfiles.SgIns.Save();
            else if (fra.Name.Equals("xfCompany"))
                Seguridad.xfCompany.SgIns.Save();
            else if (fra.Name.Equals("xfPriceList"))
                Warehouse.xfPriceList.SgIns.Set_Save();
            else if (fra.Name.Equals("xfTypeBusinessPartner"))
                Generics.xfTypeBusinessPartner.SgIns.Save();
            else if (fra.Name.Equals("xfTypeIdentification"))
                Generics.xfTypeIdentification.SgIns.Save();
            else if (fra.Name.Equals("xfTypeContact"))
                Generics.xfTypeContact.SgIns.Save();
            else if (fra.Name.Equals("xfCountry"))
                Generics.xfCountry.SgIns.Save();
            else if (fra.Name.Equals("xfPaymentTerm"))
                Generics.xfPaymentTerm.SgIns.Save();
            else if (fra.Name.Equals("xfBusinessPartner"))
                Management.xfBusinessPartner.SgIns.Save();
            else if (fra.Name.Equals("xfUsuario"))
                Seguridad.xfUsuario.SgIns.Save();
            else if (fra.Name.Equals("xfExchangeRate"))
                Management.xfExchangeRate.SgIns.Save();
            else if (fra.Name.Equals("xfSeries"))
                Management.xfSeries.SgIns.Save();
            else if (fra.Name.Equals("xfBranch"))
                Generics.xfBranch.SgIns.Save();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Save();
            else if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.Save();
            else if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.Save();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.Save();
            else if (fra.Name.Equals("xfSalesCreditNote"))
                Sales.xfSalesCreditNote.SgIns.Save();
            else if (fra.Name.Equals("xfArticle"))
                Warehouse.xfArticle.SgIns.Set_Save();
            else if (fra.Name.Equals("xfWarehouseMaster"))
                Warehouse.xfWarehouseMaster.SgIns.Save();
            else if (fra.Name.Equals("xfEntryGoods"))
                Warehouse.xfEntryGoods.SgIns.Set_Save();
            else if (fra.Name.Equals("xfReasonEntry"))
                Generics.xfReasonEntry.SgIns.Save();
            else if (fra.Name.Equals("xfReasonOutput"))
                Generics.xfReasonOutput.SgIns.Save();
            else if (fra.Name.Equals("xfReasonTransfer"))
                Generics.xfReasonTransfer.SgIns.Save();
            else if (fra.Name.Equals("xfReasonReceiving"))
                Generics.xfReasonReceiving.SgIns.Save();
            else if (fra.Name.Equals("xfOutputGoods"))
                Warehouse.xfOutputGoods.SgIns.Set_Save();
            else if (fra.Name.Equals("xfTransferGoods"))
                Warehouse.xfTransferGoods.SgIns.Set_Save();
            else if (fra.Name.Equals("xfReceivingGoods"))
                Warehouse.xfReceivingGoods.SgIns.Set_Save();
            else if (fra.Name.Equals("xfCurrency"))
                Generics.xfCurrency.SgIns.Save();
            else if (fra.Name.Equals("xfPurchaseOrder")) 
                Purchase.xfPurchaseOrder.SgIns.Set_Save(); 
            else if (fra.Name.Equals("xfDelivery")) 
                Purchase.xfDelivery.SgIns.Set_Save(); 
            else if (fra.Name.Equals("xfInvoice")) 
                Purchase.xfInvoice.SgIns.Set_Save(); 
            else if (fra.Name.Equals("xfCreditNote")) 
                Purchase.xfCreditNote.SgIns.Set_Save();
            else if (fra.Name.Equals("xfModelArticle"))
                Generics.xfModelArticle.SgIns.Save();
            else if (fra.Name.Equals("xfTypeArticle"))
                Generics.xfTypeArticle.SgIns.Save();
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
                Sales.xfSalesCreditNoteFactoring.SgIns.Save();
        }

        private void bbiUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            else if (fra.Name.Equals("xfProfiles"))
                Seguridad.xfProfiles.SgIns.Undo();
            else if (fra.Name.Equals("xfCompany"))
                Seguridad.xfCompany.SgIns.Undo();
            else if (fra.Name.Equals("xfPriceList"))
                Warehouse.xfPriceList.SgIns.Undo();
            else if (fra.Name.Equals("xfTypeBusinessPartner"))
                Generics.xfTypeBusinessPartner.SgIns.Undo();
            else if (fra.Name.Equals("xfTypeIdentification"))
                Generics.xfTypeIdentification.SgIns.Undo();
            else if (fra.Name.Equals("xfTypeContact"))
                Generics.xfTypeContact.SgIns.Undo();
            else if (fra.Name.Equals("xfCountry"))
                Generics.xfCountry.SgIns.Undo();
            else if (fra.Name.Equals("xfPaymentTerm"))
                Generics.xfPaymentTerm.SgIns.Undo();
            else if (fra.Name.Equals("xfBusinessPartner"))
                Management.xfBusinessPartner.SgIns.Undo();
            else if (fra.Name.Equals("xfUsuario"))
                Seguridad.xfUsuario.SgIns.Undo();
            else if (fra.Name.Equals("xfExchangeRate"))
                Management.xfExchangeRate.SgIns.Undo();
            else if (fra.Name.Equals("xfSeries"))
                Management.xfSeries.SgIns.Undo();
            else if (fra.Name.Equals("xfBranch"))
                Generics.xfBranch.SgIns.Undo();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Undo();
            else if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.Undo();
            else if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.Undo();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.Undo();
            else if (fra.Name.Equals("xfSalesCreditNote"))
                Sales.xfSalesCreditNote.SgIns.Undo();
            else if (fra.Name.Equals("xfArticle"))
                Warehouse.xfArticle.SgIns.Undo();
            else if (fra.Name.Equals("xfWarehouseMaster"))
                Warehouse.xfWarehouseMaster.SgIns.Undo();
            else if (fra.Name.Equals("xfEntryGoods"))
                Warehouse.xfEntryGoods.SgIns.Undo();
            else if (fra.Name.Equals("xfReasonEntry"))
                Generics.xfReasonEntry.SgIns.Undo();
            else if (fra.Name.Equals("xfReasonOutput"))
                Generics.xfReasonOutput.SgIns.Undo();
            else if (fra.Name.Equals("xfReasonTransfer"))
                Generics.xfReasonTransfer.SgIns.Undo();
            else if (fra.Name.Equals("xfReasonReceiving"))
                Generics.xfReasonReceiving.SgIns.Undo();
            else if (fra.Name.Equals("xfOutputGoods"))
                Warehouse.xfOutputGoods.SgIns.Undo();
            //else if (fra.Name.Equals("xfTransferGoods"))
            //    Warehouse.xfTransferGoods.SgIns.Undo();
            else if (fra.Name.Equals("xfReceivingGoods"))
                Warehouse.xfReceivingGoods.SgIns.Undo();
            else if (fra.Name.Equals("xfCurrency"))
                Generics.xfCurrency.SgIns.Save();
            else if (fra.Name.Equals("xfPurchaseOrder")) 
                Purchase.xfPurchaseOrder.SgIns.Undo(); 
            else if (fra.Name.Equals("xfDelivery")) 
                Purchase.xfDelivery.SgIns.Undo(); 
            else if (fra.Name.Equals("xfInvoice")) 
                Purchase.xfInvoice.SgIns.Undo(); 
            else if (fra.Name.Equals("xfCreditNote")) 
                Purchase.xfCreditNote.SgIns.Undo();
            else if (fra.Name.Equals("xfModelArticle"))
                Generics.xfModelArticle.SgIns.Undo();
            else if (fra.Name.Equals("xfTypeArticle"))
                Generics.xfTypeArticle.SgIns.Undo();
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
                Sales.xfSalesCreditNoteFactoring.SgIns.Undo();
        }

        private void bbiTypeBusinessPartner_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfTypeBusinessPartner.SgIns.MdiParent = this;
            Generics.xfTypeBusinessPartner.SgIns.Activate();
            Generics.xfTypeBusinessPartner.SgIns.FORM_SUBO = "bbiTypeBusinessPartner";
            Generics.xfTypeBusinessPartner.SgIns.Show();
            Generics.xfTypeBusinessPartner.SgIns.BringToFront();
        }

        private void bbiTypeIdentification_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfTypeIdentification.SgIns.MdiParent = this;
            Generics.xfTypeIdentification.SgIns.Activate();
            Generics.xfTypeIdentification.SgIns.FORM_SUBO = "bbiTypeIdentification";
            Generics.xfTypeIdentification.SgIns.Show();
            Generics.xfTypeIdentification.SgIns.BringToFront();
        }

        private void bbiTypeContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfTypeContact.SgIns.MdiParent = this;
            Generics.xfTypeContact.SgIns.Activate();
            Generics.xfTypeContact.SgIns.FORM_SUBO = "bbiTypeContact";
            Generics.xfTypeContact.SgIns.Show();
            Generics.xfTypeContact.SgIns.BringToFront();
        }

        private void bbiPaymentTerm_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfPaymentTerm.SgIns.MdiParent = this;
            Generics.xfPaymentTerm.SgIns.Activate();
            Generics.xfPaymentTerm.SgIns.FORM_SUBO = "bbiPaymentTerm";
            Generics.xfPaymentTerm.SgIns.Show();
            Generics.xfPaymentTerm.SgIns.BringToFront();
        }

        private void bbiAddItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfBusinessPartner"))
            {
                if (Management.xfBusinessPartner.SgIns.gdcContacts.IsFocused)
                    Management.xfBusinessPartner.SgIns.AddItemContact();
                else if (Management.xfBusinessPartner.SgIns.gdcBranch.IsFocused)
                    Management.xfBusinessPartner.SgIns.AddItemBranch();
            }
            else if (fra.Name.Equals("xfQuote"))
            {
                if (Sales.xfQuote.SgIns.gdcGroups.IsFocused)
                    Sales.xfQuote.SgIns.AddGroup();
                else if (Sales.xfQuote.SgIns.gdcArticles.IsFocused)
                    Sales.xfQuote.SgIns.AddArticle();
            }
            else if (fra.Name.Equals("xfSalesOrder"))
            {
                if (Sales.xfSalesOrder.SgIns.gdcGroups.IsFocused)
                    Sales.xfSalesOrder.SgIns.AddGroup();
                else if (Sales.xfSalesOrder.SgIns.gdcArticles.IsFocused)
                    Sales.xfSalesOrder.SgIns.AddArticle();
            }
            else if (fra.Name.Equals("xfReferralGuide"))
            {
                if (Sales.xfReferralGuide.SgIns.gdcGroups.IsFocused)
                    Sales.xfReferralGuide.SgIns.AddGroup();
                else if (Sales.xfReferralGuide.SgIns.gdcArticles.IsFocused)
                    Sales.xfReferralGuide.SgIns.AddArticle();
            }
            else if (fra.Name.Equals("xfSalesInvoice"))
            {
                if (Sales.xfSalesInvoice.SgIns.gdcGroups.IsFocused)
                    Sales.xfSalesInvoice.SgIns.AddGroup();
                else if (Sales.xfSalesInvoice.SgIns.gdcArticles.IsFocused)
                    Sales.xfSalesInvoice.SgIns.AddArticle();
            }
            else if (fra.Name.Equals("xfSalesCreditNote"))
            {
                if (Sales.xfSalesCreditNote.SgIns.gdcArticlesCompleted.IsFocused)
                    Sales.xfSalesCreditNote.SgIns.AddArticle();
            }
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
            {
                if (Sales.xfSalesCreditNoteFactoring.SgIns.gdcInvoices.IsFocused)
                    Sales.xfSalesCreditNoteFactoring.SgIns.AddInvoice();
            }
        }

        private void bbiDeleteItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfBusinessPartner"))
            {
                if (Management.xfBusinessPartner.SgIns.gdcContacts.IsFocused)
                    Management.xfBusinessPartner.SgIns.RemoveItemContact();
                else if (Management.xfBusinessPartner.SgIns.gdcBranch.IsFocused)
                    Management.xfBusinessPartner.SgIns.RemoveItemBranch();
            }
            else if (fra.Name.Equals("xfQuote"))
            {
                if (Sales.xfQuote.SgIns.gdcArticles.IsFocused)
                    Sales.xfQuote.SgIns.RemoveArticle();
                else if (Sales.xfQuote.SgIns.gdcGroups.IsFocused)
                    Sales.xfQuote.SgIns.RemoveGroup();
            }
            else if (fra.Name.Equals("xfSalesOrder"))
            {
                if (Sales.xfSalesOrder.SgIns.gdcArticles.IsFocused)
                    Sales.xfSalesOrder.SgIns.RemoveArticle();
                else if (Sales.xfSalesOrder.SgIns.gdcGroups.IsFocused)
                    Sales.xfSalesOrder.SgIns.RemoveGroup();
            }
            else if (fra.Name.Equals("xfReferralGuide"))
            {
                if (Sales.xfReferralGuide.SgIns.gdcArticles.IsFocused)
                    Sales.xfReferralGuide.SgIns.RemoveArticle();
                else if (Sales.xfReferralGuide.SgIns.gdcGroups.IsFocused)
                    Sales.xfReferralGuide.SgIns.RemoveGroup();
            }
            else if (fra.Name.Equals("xfSalesInvoice"))
            {
                if (Sales.xfSalesInvoice.SgIns.gdcArticles.IsFocused)
                    Sales.xfSalesInvoice.SgIns.RemoveArticle();
                else if (Sales.xfSalesInvoice.SgIns.gdcGroups.IsFocused)
                    Sales.xfSalesInvoice.SgIns.RemoveGroup();
            }
            else if (fra.Name.Equals("xfSalesCreditNote"))
            {
                if (Sales.xfSalesCreditNote.SgIns.gdcArticlesCompleted.IsFocused)
                    Sales.xfSalesCreditNote.SgIns.RemoveArticle();
            }
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
            {
                if (Sales.xfSalesCreditNoteFactoring.SgIns.gdcInvoices.IsFocused)
                    Sales.xfSalesCreditNoteFactoring.SgIns.RemoveInvoice();
            }
        }

        private void bbiSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfBusinessPartner"))
                Management.xfBusinessPartner.SgIns.SearchSociNego();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.SearchQuote();
            else if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.SearchSalesOrder();
            else if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.SearchReferralGuide();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.SearchInvoice();
            else if (fra.Name.Equals("xfSalesCreditNote"))
                Sales.xfSalesCreditNote.SgIns.SearchSalesCreditNote();
            else if (fra.Name.Equals("xfSalesCreditNoteFactoring"))
                Sales.xfSalesCreditNoteFactoring.SgIns.SearchSalesCreditNote();
            else if (fra.Name.Equals("xfArticle"))
                Warehouse.xfArticle.SgIns.Set_Search();
            else if (fra.Name.Equals("xfEntryGoods"))
                Warehouse.xfEntryGoods.SgIns.Set_Search();
            else if (fra.Name.Equals("xfOutputGoods"))
                Warehouse.xfOutputGoods.SgIns.Set_Search();
            else if (fra.Name.Equals("xfTransferGoods"))
                Warehouse.xfTransferGoods.SgIns.Set_Search();
            else if (fra.Name.Equals("xfReceivingGoods"))
                Warehouse.xfReceivingGoods.SgIns.Set_Search();
            else if (fra.Name.Equals("xfPurchaseOrder")) 
                Purchase.xfPurchaseOrder.SgIns.Set_Search(); 
            else if (fra.Name.Equals("xfDelivery")) 
                Purchase.xfDelivery.SgIns.Set_Search(); 
            else if (fra.Name.Equals("xfInvoice")) 
                Purchase.xfInvoice.SgIns.Set_Search(); 
            else if (fra.Name.Equals("xfCreditNote")) 
                Purchase.xfCreditNote.SgIns.Set_Search();
        }

        private void bbiSecurityPasswordChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (var oForm = new xfPasswordChange())
                {
                    oForm.SESSION_COMP = SESSION_COMP;
                    oForm.SESSION_USER = SESSION_USER;
                    if (oForm.ShowDialog() == DialogResult.OK)
                    {
                        var oBer = new BESVMC_USUA();
                        var oBr = new BRSVMC_USUA();

                        oBer.NUM_ACCI = 5;
                        oBer.COD_USUA = SESSION_USER;
                        oBer.COD_USUA_CREA = SESSION_USER;
                        oBer.COD_USUA_MODI = SESSION_USER;
                        oBer.ALF_PASS = oForm.oBe.ALF_PASS;
                        oBr.Set_SVPR_USUA(oBer);
                        XtraMessageBox.Show("Operación realizada con exito!!!!","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bbiExchangeRate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Management.xfExchangeRate.SgIns.MdiParent = this;
            Management.xfExchangeRate.SgIns.Activate();
            Management.xfExchangeRate.SgIns.FORM_SUBO = "bbiExchangeRate";
            Management.xfExchangeRate.SgIns.Show();
            Management.xfExchangeRate.SgIns.BringToFront();
        }

        private void bbiBranches_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfBranch.SgIns.MdiParent = this;
            Generics.xfBranch.SgIns.Activate();
            Generics.xfBranch.SgIns.FORM_SUBO = "bbiBranches";
            Generics.xfBranch.SgIns.Show();
            Generics.xfBranch.SgIns.BringToFront();
        }

        private void bbiWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfWarehouseMaster.SgIns.MdiParent = this;
            Warehouse.xfWarehouseMaster.SgIns.Activate();
            Warehouse.xfWarehouseMaster.SgIns.FORM_SUBO = "bbiWarehouse";
            Warehouse.xfWarehouseMaster.SgIns.Show();
            Warehouse.xfWarehouseMaster.SgIns.BringToFront();
        }

        private void bbiEntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfEntryGoods.SgIns.MdiParent = this;
            Warehouse.xfEntryGoods.SgIns.Activate();
            Warehouse.xfEntryGoods.SgIns.FORM_SUBO = "bbiEntry";
            Warehouse.xfEntryGoods.SgIns.Show();
            Warehouse.xfEntryGoods.SgIns.BringToFront();

        }

        private void bbiReasonEntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfReasonEntry.SgIns.MdiParent = this;
            Generics.xfReasonEntry.SgIns.Activate();
            Generics.xfReasonEntry.SgIns.FORM_SUBO = "bbiReasonEntry";
            Generics.xfReasonEntry.SgIns.Show();
            Generics.xfReasonEntry.SgIns.BringToFront();
        }

        private void bbiReasonOutput_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfReasonOutput.SgIns.MdiParent = this;
            Generics.xfReasonOutput.SgIns.Activate();
            Generics.xfReasonOutput.SgIns.FORM_SUBO = "bbiReasonOutput";
            Generics.xfReasonOutput.SgIns.Show();
            Generics.xfReasonOutput.SgIns.BringToFront();
        }

        private void bbiReasonTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfReasonTransfer.SgIns.MdiParent = this;
            Generics.xfReasonTransfer.SgIns.Activate();
            Generics.xfReasonTransfer.SgIns.FORM_SUBO = "bbiReasonTransfer";
            Generics.xfReasonTransfer.SgIns.Show();
            Generics.xfReasonTransfer.SgIns.BringToFront();
        }

        private void bbiDepartures_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfOutputGoods.SgIns.MdiParent = this;
            Warehouse.xfOutputGoods.SgIns.Activate();
            Warehouse.xfOutputGoods.SgIns.FORM_SUBO = "bbiDepartures";
            Warehouse.xfOutputGoods.SgIns.Show();
            Warehouse.xfOutputGoods.SgIns.BringToFront();
        }

        private void bbiTransfers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfTransferGoods.SgIns.MdiParent = this;
            Warehouse.xfTransferGoods.SgIns.Activate();
            Warehouse.xfTransferGoods.SgIns.FORM_SUBO = "bbiTransfers";
            Warehouse.xfTransferGoods.SgIns.Show();
            Warehouse.xfTransferGoods.SgIns.BringToFront();
        }

        private void bbiReception_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfReceivingGoods.SgIns.MdiParent = this;
            Warehouse.xfReceivingGoods.SgIns.Activate();
            Warehouse.xfReceivingGoods.SgIns.FORM_SUBO = "bbiReception";
            Warehouse.xfReceivingGoods.SgIns.Show();
            Warehouse.xfReceivingGoods.SgIns.BringToFront();
        }

        private void bbiReasonReceiving_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfReasonReceiving.SgIns.MdiParent = this;
            Generics.xfReasonReceiving.SgIns.Activate();
            Generics.xfReasonReceiving.SgIns.FORM_SUBO = "bbiReasonReceiving";
            Generics.xfReasonReceiving.SgIns.Show();
            Generics.xfReasonReceiving.SgIns.BringToFront();
        }

        private void bbiArticleInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfStockInventory.SgIns.MdiParent = this;
            Report.xfStockInventory.SgIns.Activate();
            Report.xfStockInventory.SgIns.FORM_SUBO = "bbiArticleInventory";
            Report.xfStockInventory.SgIns.Show();
            Report.xfStockInventory.SgIns.BringToFront();
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfStockInventory"))
                Report.xfStockInventory.SgIns.Set_Export();
            else if (fra.Name.Equals("xfPurchaseOrder"))
                Purchase.xfPurchaseOrder.SgIns.Set_Export();
            else if (fra.Name.Equals("xfKardexInventory"))
                Report.xfKardexInventory.SgIns.Set_Export();
            else if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Set_Export();
            else if (fra.Name.Equals("xfQuoteIn"))
                Report.xfQuoteIn.SgIns.Export();
            else if (fra.Name.Equals("xfCustomerSales"))
                Report.xfCustomerSales.SgIns.Export();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Report.xfSalesInvoice.SgIns.Export();
            else if (fra.Name.Equals("xfApprovedInvoice"))
                Report.xfApprovedInvoice.SgIns.Export();
            else if (fra.Name.Equals("xfReferralPending"))
                Report.xfReferralPending.SgIns.Export();
            else if (fra.Name.Equals("xfCommittedArticles"))
                Report.xfCommittedArticles.SgIns.Export();
            else if (fra.Name.Equals("xfPurchase1"))
                Report.xfPurchase1.SgIns.Set_Export();
            else if (fra.Name.Equals("xfPurchase2"))
                Report.xfPurchase2.SgIns.Set_Export();
            else if (fra.Name.Equals("xfPurchase3"))
                Report.xfPurchase3.SgIns.Set_Export();
            else if (fra.Name.Equals("xfStockValued"))
                Report.xfStockValued.SgIns.Set_Export();
            else if (fra.Name.Equals("xfInvoicesRepo"))
                Report.xfInvoicesRepo.SgIns.Export();
            else if (fra.Name.Equals("xfSalesDelivery"))
                Report.xfSalesDelivery.SgIns.Export();
            else if (fra.Name.Equals("xfSalesQuote"))
                Report.xfSalesQuote.SgIns.Export();
            else if (fra.Name.Equals("xfCustomerSalesServiceNothing"))
                Report.xfCustomerSalesServiceNothing.SgIns.Export();
            else if (fra.Name.Equals("xfPurchase4"))
                Report.xfPurchase4.SgIns.Set_Export();
            else if (fra.Name.Equals("xfPriceList"))
                Warehouse.xfPriceList.SgIns.Set_Export();
        }

        private void bbiCurrency_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfCurrency.SgIns.MdiParent = this;
            Generics.xfCurrency.SgIns.Activate();
            Generics.xfCurrency.SgIns.FORM_SUBO = "bbiCurrency";
            Generics.xfCurrency.SgIns.Show();
            Generics.xfCurrency.SgIns.BringToFront();
        }

        private void bbiSalesOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sales.xfSalesOrder.SgIns.MdiParent = this;
            Sales.xfSalesOrder.SgIns.Activate();
            Sales.xfSalesOrder.SgIns.FORM_SUBO = "bbiSalesOrder";
            Sales.xfSalesOrder.SgIns.Show();
            Sales.xfSalesOrder.SgIns.BringToFront();
        }

        private void bbiAnnul_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Annul();
            else if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.Annul();
            else if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.Annul();
            else if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.Annul();
            else if (fra.Name.Equals("xfPurchaseOrder"))
                Purchase.xfPurchaseOrder.SgIns.Annul();
            else if (fra.Name.Equals("xfSalesCreditNote"))
                Sales.xfSalesCreditNote.SgIns.Annul();
        }

        private void bbiDuplicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Duplicate();
        }

        private void bbiApprove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfQuote"))
                Sales.xfQuote.SgIns.Approve();
        }

        private void bbiReferralGuide_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sales.xfReferralGuide.SgIns.MdiParent = this;
            Sales.xfReferralGuide.SgIns.Activate();
            Sales.xfReferralGuide.SgIns.FORM_SUBO = "bbiReferralGuide";
            Sales.xfReferralGuide.SgIns.Show();
            Sales.xfReferralGuide.SgIns.BringToFront();
        }

        private void bbiSalesDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sales.xfSalesInvoice.SgIns.MdiParent = this;
            Sales.xfSalesInvoice.SgIns.Activate();
            Sales.xfSalesInvoice.SgIns.FORM_SUBO = "bbiSalesDocument";
            Sales.xfSalesInvoice.SgIns.Show();
            Sales.xfSalesInvoice.SgIns.BringToFront();
        }

        private void bbiCreditNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sales.xfSalesCreditNote.SgIns.MdiParent = this;
            Sales.xfSalesCreditNote.SgIns.Activate();
            Sales.xfSalesCreditNote.SgIns.FORM_SUBO = "bbiCreditNote";
            Sales.xfSalesCreditNote.SgIns.Show();
            Sales.xfSalesCreditNote.SgIns.BringToFront();
        }

        private void bbiReferralGuideMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfSalesOrder"))
                Sales.xfSalesOrder.SgIns.GenerateReferralGuide();
        }

        private void bbiPurchaseOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Purchase.xfPurchaseOrder.SgIns.MdiParent = this;
            Purchase.xfPurchaseOrder.SgIns.Activate();
            Purchase.xfPurchaseOrder.SgIns.FORM_SUBO = "bbiPurchaseOrder";
            Purchase.xfPurchaseOrder.SgIns.Show();
            Purchase.xfPurchaseOrder.SgIns.BringToFront();
        }

        private void bbiPInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Purchase.xfInvoice.SgIns.MdiParent = this;
            Purchase.xfInvoice.SgIns.Activate();
            Purchase.xfInvoice.SgIns.FORM_SUBO = "bbiPInvoice";
            Purchase.xfInvoice.SgIns.Show();
            Purchase.xfInvoice.SgIns.BringToFront();
        }

        private void bbiInputItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            Purchase.xfDelivery.SgIns.MdiParent = this;
            Purchase.xfDelivery.SgIns.Activate();
            Purchase.xfDelivery.SgIns.FORM_SUBO = "bbiInputItems";
            Purchase.xfDelivery.SgIns.Show();
            Purchase.xfDelivery.SgIns.BringToFront();
        }

        private void bbiSupplierCreditNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            Purchase.xfCreditNote.SgIns.MdiParent = this;
            Purchase.xfCreditNote.SgIns.Activate();
            Purchase.xfCreditNote.SgIns.FORM_SUBO = "bbiSupplierCreditNote";
            Purchase.xfCreditNote.SgIns.Show();
            Purchase.xfCreditNote.SgIns.BringToFront();
        }

        private void bbiInvoiceMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.GenerateInvoice();
        }

        private void bbiCreditNoteMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.GenerateCreditNote();
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfReferralGuide"))
                Sales.xfReferralGuide.SgIns.Print();
            if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.ViewSelector();
            if (fra.Name.Equals("xfSalesCreditNote"))
                Sales.xfSalesCreditNote.SgIns.ViewSelector();
        }

        private void bbiKardexWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfKardexInventory.SgIns.MdiParent = this;
            Report.xfKardexInventory.SgIns.Activate();
            Report.xfKardexInventory.SgIns.FORM_SUBO = "bbiKardexWarehouse";
            Report.xfKardexInventory.SgIns.Show();
            Report.xfKardexInventory.SgIns.BringToFront();
        }

        private void bbiPriceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Warehouse.xfPriceList.SgIns.MdiParent = this;
            Warehouse.xfPriceList.SgIns.Activate();
            Warehouse.xfPriceList.SgIns.FORM_SUBO = "bbiPriceList";
            Warehouse.xfPriceList.SgIns.Show();
            Warehouse.xfPriceList.SgIns.BringToFront();
        }

        private void bbiCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfCountry.SgIns.MdiParent = this;
            Generics.xfCountry.SgIns.Activate();
            Generics.xfCountry.SgIns.FORM_SUBO = "bbiCountry";
            Generics.xfCountry.SgIns.Show();
            Generics.xfCountry.SgIns.BringToFront();
        }

        private void bbiSeriesCorrelative_ItemClick(object sender, ItemClickEventArgs e)
        {
            Management.xfSeries.SgIns.MdiParent = this;
            Management.xfSeries.SgIns.Activate();
            Management.xfSeries.SgIns.FORM_SUBO = "bbiSeriesCorrelative";
            Management.xfSeries.SgIns.Show();
            Management.xfSeries.SgIns.BringToFront();
        }

        private void bbiTypeArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfTypeArticle.SgIns.MdiParent = this;
            Generics.xfTypeArticle.SgIns.Activate();
            Generics.xfTypeArticle.SgIns.FORM_SUBO = "bbiTypeArticle";
            Generics.xfTypeArticle.SgIns.Show();
            Generics.xfTypeArticle.SgIns.BringToFront();
        }

        private void bbiModelArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generics.xfModelArticle.SgIns.MdiParent = this;
            Generics.xfModelArticle.SgIns.Activate();
            Generics.xfModelArticle.SgIns.FORM_SUBO = "bbiModelArticle";
            Generics.xfModelArticle.SgIns.Show();
            Generics.xfModelArticle.SgIns.BringToFront();
        }

        private void bbiExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bbQuoteIssued_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfQuoteIn.SgIns.MdiParent = this;
            Report.xfQuoteIn.SgIns.Activate();
            Report.xfQuoteIn.SgIns.FORM_SUBO = "bbQuoteIssued";
            Report.xfQuoteIn.SgIns.Show();
            Report.xfQuoteIn.SgIns.BringToFront();
        }

        private void bbiCustomerSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfCustomerSales.SgIns.MdiParent = this;
            Report.xfCustomerSales.SgIns.Activate();
            Report.xfCustomerSales.SgIns.FORM_SUBO = "bbiCustomerSales";
            Report.xfCustomerSales.SgIns.Show();
            Report.xfCustomerSales.SgIns.BringToFront();
        }

        private void bbiSalesInvoiceRepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfSalesInvoice.SgIns.MdiParent = this;
            Report.xfSalesInvoice.SgIns.Activate();
            Report.xfSalesInvoice.SgIns.FORM_SUBO = "bbiSalesInvoiceRepo";
            Report.xfSalesInvoice.SgIns.Show();
            Report.xfSalesInvoice.SgIns.BringToFront();
        }

        private void bbiApprovedInvoiceRepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfApprovedInvoice.SgIns.MdiParent = this;
            Report.xfApprovedInvoice.SgIns.Activate();
            Report.xfApprovedInvoice.SgIns.FORM_SUBO = "bbiApprovedInvoiceRepo";
            Report.xfApprovedInvoice.SgIns.Show();
            Report.xfApprovedInvoice.SgIns.BringToFront();
        }

        private void bbiQuotePenddingRepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfQuotePending.SgIns.MdiParent = this;
            Report.xfQuotePending.SgIns.Activate();
            Report.xfQuotePending.SgIns.FORM_SUBO = "bbiQuotePenddingRepo";
            Report.xfQuotePending.SgIns.Show();
            Report.xfQuotePending.SgIns.BringToFront();
        }

        private void bbiReferralPendingRepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfReferralPending.SgIns.MdiParent = this;
            Report.xfReferralPending.SgIns.Activate();
            Report.xfReferralPending.SgIns.FORM_SUBO = "bbiReferralPendingRepo";
            Report.xfReferralPending.SgIns.Show();
            Report.xfReferralPending.SgIns.BringToFront();
        }

        private void bbCommittedArticles_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfCommittedArticles.SgIns.MdiParent = this;
            Report.xfCommittedArticles.SgIns.Activate();
            Report.xfCommittedArticles.SgIns.FORM_SUBO = "bbCommittedArticles";
            Report.xfCommittedArticles.SgIns.Show();
            Report.xfCommittedArticles.SgIns.BringToFront();
        }

        private void bbiLocalPurchaseRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfPurchase1.SgIns.MdiParent = this;
            Report.xfPurchase1.SgIns.Activate();
            Report.xfPurchase1.SgIns.FORM_SUBO = "bbiLocalPurchaseRegister";
            Report.xfPurchase1.SgIns.Show();
            Report.xfPurchase1.SgIns.BringToFront();
        }

        private void bbiRegistrationImportedPurchases_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfPurchase2.SgIns.MdiParent = this;
            Report.xfPurchase2.SgIns.Activate();
            Report.xfPurchase2.SgIns.FORM_SUBO = "bbiRegistrationImportedPurchases";
            Report.xfPurchase2.SgIns.Show();
            Report.xfPurchase2.SgIns.BringToFront();
        }

        private void bbiItemsPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfPurchase3.SgIns.MdiParent = this;
            Report.xfPurchase3.SgIns.Activate();
            Report.xfPurchase3.SgIns.FORM_SUBO = "bbiItemsPurchase";
            Report.xfPurchase3.SgIns.Show();
            Report.xfPurchase3.SgIns.BringToFront();
        }

        private void bbiStockValued_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfStockValued.SgIns.MdiParent = this;
            Report.xfStockValued.SgIns.Activate();
            Report.xfStockValued.SgIns.FORM_SUBO = "bbiStockValued";
            Report.xfStockValued.SgIns.Show();
            Report.xfStockValued.SgIns.BringToFront();
        }

        private void bbiSalesRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfInvoicesRepo.SgIns.MdiParent = this;
            Report.xfInvoicesRepo.SgIns.Activate();
            Report.xfInvoicesRepo.SgIns.FORM_SUBO = "bbiSalesRegister";
            Report.xfInvoicesRepo.SgIns.Show();
            Report.xfInvoicesRepo.SgIns.BringToFront();
        }

        private void bbiQuoteRegisterRepo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfSalesQuote.SgIns.MdiParent = this;
            Report.xfSalesQuote.SgIns.Activate();
            Report.xfSalesQuote.SgIns.FORM_SUBO = "bbiQuoteRegisterRepo";
            Report.xfSalesQuote.SgIns.Show();
            Report.xfSalesQuote.SgIns.BringToFront();
        }

        private void bbiReferralRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfSalesDelivery.SgIns.MdiParent = this;
            Report.xfSalesDelivery.SgIns.Activate();
            Report.xfSalesDelivery.SgIns.FORM_SUBO = "bbiReferralRegister";
            Report.xfSalesDelivery.SgIns.Show();
            Report.xfSalesDelivery.SgIns.BringToFront();
        }

        private void bbiSalesOrderView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfSaleOrder.SgIns.MdiParent = this;
            Report.xfSaleOrder.SgIns.Activate();
            Report.xfSaleOrder.SgIns.FORM_SUBO = "bbiSalesOrderView";
            Report.xfSaleOrder.SgIns.Show();
            Report.xfSaleOrder.SgIns.BringToFront();
        }

        private void bbiCustomerSalesServiceNothing_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfCustomerSalesServiceNothing.SgIns.MdiParent = this;
            Report.xfCustomerSalesServiceNothing.SgIns.Activate();
            Report.xfCustomerSalesServiceNothing.SgIns.FORM_SUBO = "bbiCustomerSalesServiceNothing";
            Report.xfCustomerSalesServiceNothing.SgIns.Show();
            Report.xfCustomerSalesServiceNothing.SgIns.BringToFront();
        }

        private void bbiPurchase4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report.xfPurchase4.SgIns.MdiParent = this;
            Report.xfPurchase4.SgIns.Activate();
            Report.xfPurchase4.SgIns.FORM_SUBO = "bbiPurchase4";
            Report.xfPurchase4.SgIns.Show();
            Report.xfPurchase4.SgIns.BringToFront();
        }

        private void bbiLiquidateBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fra == null) return;
            if (fra.Name.Equals("xfSalesInvoice"))
                Sales.xfSalesInvoice.SgIns.LiquidateBill();
        }

        private void bbiCreditNoteFactoring_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sales.xfSalesCreditNoteFactoring.SgIns.MdiParent = this;
            Sales.xfSalesCreditNoteFactoring.SgIns.Activate();
            Sales.xfSalesCreditNoteFactoring.SgIns.FORM_SUBO = "bbiCreditNoteFactoring";
            Sales.xfSalesCreditNoteFactoring.SgIns.Show();
            Sales.xfSalesCreditNoteFactoring.SgIns.BringToFront();
        }
    }
}