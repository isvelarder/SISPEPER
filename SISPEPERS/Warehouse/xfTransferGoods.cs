using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;

namespace SISPEPERS.Warehouse
{
    public partial class xfTransferGoods : XtraForm
    {
        public xfTransferGoods()
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
        private static xfTransferGoods mSgIns;
        public static xfTransferGoods SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfTransferGoods();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void Get_Load()
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var obral = new BRWarehouse();
            var obrmo = new BRReason();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);
            var olsre = obral.Get_PSGN_SPLS_SVMC_SOCI_NEGO(SESSION_COMP);
            var olsmo = obrmo.Get_PSGN_SPLS_SVMC_MOTI(SESSION_COMP);

            lkeCOD_ALMA.Properties.DataSource = olsal;
            lkeCOD_ALMA.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén Origen", 20);
            lkeCOD_ALMA.Properties.Columns.Add(lkci);
            lkeCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            lkeCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            lkeCOD_SOCI_NEGO_RESP.Properties.DataSource = olsre;
            lkeCOD_SOCI_NEGO_RESP.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_NOMB", "Responsable", 20);
            lkeCOD_SOCI_NEGO_RESP.Properties.Columns.Add(lkci);
            lkeCOD_SOCI_NEGO_RESP.Properties.DisplayMember = "ALF_NOMB";
            lkeCOD_SOCI_NEGO_RESP.Properties.ValueMember = "COD_SOCI_NEGO";

            lkeCOD_ALMA_DEST.Properties.DataSource = olsal;
            lkeCOD_ALMA_DEST.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén Destino", 20);
            lkeCOD_ALMA_DEST.Properties.Columns.Add(lkci);
            lkeCOD_ALMA_DEST.Properties.DisplayMember = "ALF_ALMA";
            lkeCOD_ALMA_DEST.Properties.ValueMember = "COD_ALMA";

            lkeCOD_SOCI_NEGO_RESP_DEST.Properties.DataSource = olsre;
            lkeCOD_SOCI_NEGO_RESP_DEST.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_NOMB", "Responsable", 20);
            lkeCOD_SOCI_NEGO_RESP_DEST.Properties.Columns.Add(lkci);
            lkeCOD_SOCI_NEGO_RESP_DEST.Properties.DisplayMember = "ALF_NOMB";
            lkeCOD_SOCI_NEGO_RESP_DEST.Properties.ValueMember = "COD_SOCI_NEGO";

            lkeCOD_MOTI.Properties.DataSource = olsmo;
            lkeCOD_MOTI.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MOTI", "Motivo", 20);
            lkeCOD_MOTI.Properties.Columns.Add(lkci);
            lkeCOD_MOTI.Properties.DisplayMember = "ALF_MOTI";
            lkeCOD_MOTI.Properties.ValueMember = "COD_MOTI";

            var obj = new BETransferGoodsDetail() { COD_USUA_CREA = SESSION_USER };
            var olst = new List<BETransferGoodsDetail>();
            olst.Add(obj);
            gdcDetail.DataSource = olst;

        }
        private void xfEntryGoods_Load(object sender, EventArgs e)
        {
            Get_Load();
        }
        private void lkeCOD_ALMA_EditValueChanged(object sender, EventArgs e)
        {
            var row = (BEWarehouse)lkeCOD_ALMA.GetSelectedDataRow();
            if (row != null)
                lkeCOD_SOCI_NEGO_RESP.EditValue = row.COD_SOCI_NEGO_ENCA;
        }
        private void rpiArticle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oxf = new xfSearchWarehouseArticle();
            oxf.rowsel.COD_ALMA = (int?)lkeCOD_ALMA.EditValue;
            if (oxf.ShowDialog() == DialogResult.OK)
            {                
                var olst = (List<BETransferGoodsDetail>)gdvDetail.DataSource;
                var exist = olst.Exists(item => item.COD_ARTI == oxf.rowsel.COD_ARTI);
                if (!exist)
                {
                    var row = new BETransferGoodsDetail()
                    {
                        COD_ARTI = oxf.rowsel.COD_ARTI,
                        ALF_CODI_ARTI = oxf.rowsel.ALF_CODI_ARTI,
                        ALF_ARTI = oxf.rowsel.ALF_ARTI,
                        NUM_CANT = 1,
                        COD_ALMA = oxf.rowsel.COD_ALMA,
                        COD_USUA_CREA = SESSION_USER
                    };

                    gdvDetail.DeleteRow(gdvDetail.FocusedRowHandle);
                    olst.Add(row);
                    gdvDetail.RefreshData();
                    gdvDetail.MoveLast();
                    gdvDetail.FocusedColumn = gcNUM_CANT;
                    gdvDetail.ShowEditor();
                }
                else
                {
                    XtraMessageBox.Show(WhMessage.MsgExistArticle, WhMessage.MsgInsCaption, 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    gdvDetail.CloseEditor();
                    gdvDetail.RefreshData();
                    var olst = (List<BETransferGoodsDetail>)gdvDetail.DataSource;
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

                    var obj = new BETransferGoodsDetail() { COD_USUA_CREA = SESSION_USER };
                    olst.Add(obj);
                    gdvDetail.RefreshData();
                    gdvDetail.MoveLast();
                    gdvDetail.FocusedColumn = gcALF_CODI_ARTI;
                    gdvDetail.ShowEditor();
                }
                else
                {
                    gdvDetail.DeleteRow(gdvDetail.FocusedRowHandle);
                    gdvDetail.RefreshData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        private void gdcDetail_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var index = ((NavigatorCustomButton)e.Button).Index;
            Set_Operation(index);
        }
        public void Set_Save()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCOD_ALMA_TRAN.Text))
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(WhMessage.MsgNotModyRegis);
                }
                var obtg = new BETransferGoods()
                {
                    ALF_DOCU_REFE = txtALF_DOCU_REFE.Text.Trim(),
                    FEC_TRAN = (DateTime?)dteFEC_TRAN.EditValue,
                    FEC_REGI = (DateTime?)dteFEC_REGI.EditValue,
                    COD_MOTI = (int?)lkeCOD_MOTI.EditValue,
                    COD_ALMA = (int?)lkeCOD_ALMA.EditValue,
                    COD_SOCI_NEGO_RESP = (int?)lkeCOD_SOCI_NEGO_RESP.EditValue,
                    COD_ALMA_DEST = (int?)lkeCOD_ALMA_DEST.EditValue,
                    COD_SOCI_NEGO_RESP_DEST = (int?)lkeCOD_SOCI_NEGO_RESP_DEST.EditValue,
                    ALF_COME = memALF_COME.Text.Trim(),
                    COD_USUA_CREA = SESSION_USER,
                    COD_USUA_MODI = SESSION_USER,
                    COD_COMP = SESSION_COMP
                };

                var context = new ValidationContext(obtg, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obtg, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                gdvDetail.CloseEditor();
                gdvDetail.RefreshData();
                var olst = (List<BETransferGoodsDetail>)gdvDetail.DataSource;
                if (olst.Count == 0)
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(WhMessage.MsgManyRows);
                }

                var i = 1;
                olst.ForEach(item =>
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

                var manywh = olst.Select(item => item.COD_ALMA).Distinct().Count();
                if (manywh > 1)
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(WhMessage.MsgManyWhArt);
                }

                var obr = new BRTransferGoods();
                obr.Set_PSGN_SPMT_SVTC_ALMA_TRAN(obtg, olst);
                if (!string.IsNullOrWhiteSpace(obtg.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(obtg.MSG_MNTN);
                }
                txtCOD_ALMA_TRAN.Text = obtg.COD_ALMA_TRAN.ToString();
                gdvDetail.RefreshData();
                XtraMessageBox.Show(WhMessage.MsgSuccessfully, WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    msgIcon);
            }
        }
        private void ClearControls()
        {
            txtCOD_ALMA_TRAN.Text = string.Empty;
            txtALF_DOCU_REFE.Text = string.Empty;
            dteFEC_TRAN.EditValue = null;
            dteFEC_REGI.EditValue = null;
            lkeCOD_ALMA.EditValue = null;
            lkeCOD_SOCI_NEGO_RESP.EditValue = null;
            lkeCOD_ALMA_DEST.EditValue = null;
            lkeCOD_SOCI_NEGO_RESP_DEST.EditValue = null;
            lkeCOD_MOTI.EditValue = null;
            memALF_COME.Text = string.Empty;
            gdcDetail.DataSource = new List<BETransferGoodsDetail>();
        }
        public void Set_New()
        {
            ClearControls();
            txtALF_DOCU_REFE.Focus();
        }
        private void Set_TransferGoods(BETransferGoods row)
        {
            ClearControls();
            txtCOD_ALMA_TRAN.Text = row.COD_ALMA_TRAN.ToString();
            txtALF_DOCU_REFE.Text = row.ALF_DOCU_REFE;
            dteFEC_TRAN.EditValue = row.FEC_TRAN;
            dteFEC_REGI.EditValue = row.FEC_REGI;
            lkeCOD_ALMA.EditValue = row.COD_ALMA;
            lkeCOD_SOCI_NEGO_RESP.EditValue = row.COD_SOCI_NEGO_RESP;
            lkeCOD_ALMA_DEST.EditValue = row.COD_ALMA_DEST;
            lkeCOD_SOCI_NEGO_RESP_DEST.EditValue = row.COD_SOCI_NEGO_RESP_DEST;
            lkeCOD_MOTI.EditValue = row.COD_MOTI;
            memALF_COME.Text = row.ALF_COME;

            var obtg = new BETransferGoods() { COD_ALMA_TRAN = row.COD_ALMA_TRAN };
            var obr = new BRTransferGoods();
            var olst = obr.Get_PSGN_SPLS_SVTD_ALMA_TRAN(obtg);

            gdcDetail.DataSource = olst;
            gdvDetail.RefreshData();
        }
        public void Set_Search()
        {
            var ofx = new xfTransferGoodsSearch();
            if (ofx.ShowDialog() == DialogResult.OK)
                Set_TransferGoods(ofx.rowsel);
        }

        private void xfTransferGoods_Activated(object sender, EventArgs e)
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

        private void xfTransferGoods_Deactivate(object sender, EventArgs e)
        {
            var oBeAcce = new BESVMD_ACCE();
            oBeAcce.NUM_ACCI = 5;
            oBeAcce.ALF_NOMB = FORM_SUBO;
            oBeAcce.COD_PERF = SESSION_PERF;
            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            {
                itemLink.Item.Visibility = BarItemVisibility.Never;
            }
        }

        private void xfTransferGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        private void lkeCOD_ALMA_DEST_EditValueChanged(object sender, EventArgs e)
        {
            var row = (BEWarehouse)lkeCOD_ALMA_DEST.GetSelectedDataRow();
            if (row != null)
                lkeCOD_SOCI_NEGO_RESP_DEST.EditValue = row.COD_SOCI_NEGO_ENCA;
        }
    }
}