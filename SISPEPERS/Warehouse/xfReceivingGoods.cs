using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel.DataAnnotations;
using BusinessEntities.Security;
using DevExpress.XtraBars;
using BusinessRules.Security;
using BusinessRules.Generics;

namespace SISPEPERS.Warehouse
{
    public partial class xfReceivingGoods : XtraForm
    {
        public xfReceivingGoods()
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
        private static xfReceivingGoods mSgIns;
        public static xfReceivingGoods SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfReceivingGoods();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        public BETransferGoods obtg { get; set; }
        private void Get_Load()
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var obral = new BRWarehouse();
            var oBeM = new BEReason();
            oBeM.COD_COMP = SESSION_COMP;
            oBeM.COD_TIPO_MOTI = 4;
            oBeM.NUM_ACCI = 4;
            var obrmo = new BRSVMC_MOTI();

            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);
            var olsre = obral.Get_PSGN_SPLS_SVMC_SOCI_NEGO(SESSION_COMP);
            var olsmo = obrmo.Get_SVPR_MOTI_LIST(oBeM);

            lkeCOD_ALMA.Properties.DataSource = olsal;
            lkeCOD_ALMA.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén", 20);
            lkeCOD_ALMA.Properties.Columns.Add(lkci);
            lkeCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            lkeCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            lkeCOD_SOCI_NEGO_RESP.Properties.DataSource = olsre;
            lkeCOD_SOCI_NEGO_RESP.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_NOMB", "Responsable", 20);
            lkeCOD_SOCI_NEGO_RESP.Properties.Columns.Add(lkci);
            lkeCOD_SOCI_NEGO_RESP.Properties.DisplayMember = "ALF_NOMB";
            lkeCOD_SOCI_NEGO_RESP.Properties.ValueMember = "COD_SOCI_NEGO";

            lkeCOD_MOTI.Properties.DataSource = olsmo;
            lkeCOD_MOTI.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MOTI", "Motivo", 20);
            lkeCOD_MOTI.Properties.Columns.Add(lkci);
            lkeCOD_MOTI.Properties.DisplayMember = "ALF_MOTI";
            lkeCOD_MOTI.Properties.ValueMember = "COD_MOTI";

            var olst = new List<BEReceivingGoodsDetail>();
            gdcDetail.DataSource = olst;

        }
        private void xfEntryGoods_Load(object sender, EventArgs e)
        {
            Get_Load();
            StateControls(true);
        }
        private void lkeCOD_ALMA_EditValueChanged(object sender, EventArgs e)
        {
            var row = (BEWarehouse)lkeCOD_ALMA.GetSelectedDataRow();
            if (row != null)
                lkeCOD_SOCI_NEGO_RESP.EditValue = row.COD_SOCI_NEGO_ENCA;
        }
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    var oxf = new xfTransferReceivingGoodsSearch();
                    if (oxf.ShowDialog() == DialogResult.OK)
                    {
                        obtg = oxf.rowsel;
                        var obr = new BRTransferGoods();
                        var oltg = obr.Get_PSGN_SPLS_SVTD_ALMA_TRAN_RECE(obtg);
                        var olrg = new List<BEReceivingGoodsDetail>();
                        var obrg = new BEReceivingGoodsDetail();
                        oltg.ForEach(item => 
                        {
                            obrg = new BEReceivingGoodsDetail();
                            obrg.COD_ALMA_TRAN = item.COD_ALMA_TRAN;
                            obrg.COD_ARTI = item.COD_ARTI;
                            obrg.ALF_CODI_ARTI = item.ALF_CODI_ARTI;
                            obrg.ALF_ARTI = item.ALF_ARTI;
                            obrg.NUM_CANT = item.NUM_CANT;
                            obrg.NUM_CANT_MALO = item.NUM_CANT_MALO;
                            obrg.COD_USUA_CREA = SESSION_USER;
                            olrg.Add(obrg);
                        });
                        gdcDetail.DataSource = olrg;
                        gdvDetail.RefreshData();
                        ((List<BEWarehouse>)lkeCOD_ALMA.Properties.DataSource).RemoveAll(item => item.COD_ALMA == obtg.COD_ALMA);
                    }
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
                if (!string.IsNullOrWhiteSpace(txtCOD_ALMA_RECE.Text))
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(WhMessage.MsgNotModyRegis);
                }
                var obrg = new BEReceivingGoods() 
                { 
                    COD_ALMA_TRAN = obtg.COD_ALMA_TRAN,
                    ALF_DOCU_REFE = txtALF_DOCU_REFE.Text.Trim(), 
                    FEC_RECE = (DateTime?)dteFEC_RECE.EditValue, 
                    FEC_REGI = (DateTime?)dteFEC_REGI.EditValue, 
                    COD_ALMA = (int?)lkeCOD_ALMA.EditValue, 
                    COD_SOCI_NEGO_RESP = (int?)lkeCOD_SOCI_NEGO_RESP.EditValue, 
                    COD_MOTI = (int?)lkeCOD_MOTI.EditValue, 
                    ALF_COME = memALF_COME.Text.Trim(), 
                    COD_USUA_CREA = SESSION_USER, 
                    COD_USUA_MODI = SESSION_USER,
                    COD_COMP = SESSION_COMP
                };

                var context = new ValidationContext(obrg, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obrg, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                gdvDetail.CloseEditor();
                gdvDetail.RefreshData();
                var olst = (List<BEReceivingGoodsDetail>)gdvDetail.DataSource;
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

                var obr = new BRReceivingGoods();
                obr.Set_PSGN_SPMT_SVTC_ALMA_RECE(obrg, olst);
                if (!string.IsNullOrWhiteSpace(obrg.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(obrg.MSG_MNTN);
                }
                txtCOD_ALMA_RECE.Text = obrg.COD_ALMA_RECE.ToString();
                gdvDetail.RefreshData();
                StateControls(true);
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
            txtCOD_ALMA_RECE.Text = string.Empty;
            txtALF_DOCU_REFE.Text = string.Empty;
            dteFEC_RECE.EditValue = null;
            dteFEC_REGI.EditValue = null;
            lkeCOD_ALMA.EditValue = null;
            lkeCOD_SOCI_NEGO_RESP.EditValue = null;
            lkeCOD_MOTI.EditValue = null;
            memALF_COME.Text = string.Empty;

            gdcDetail.DataSource = new List<BEReceivingGoodsDetail>();
        }
        private void StateControls(bool vState)
        {
            txtALF_DOCU_REFE.Properties.ReadOnly = vState;
            dteFEC_RECE.Properties.ReadOnly = vState;
            dteFEC_REGI.Properties.ReadOnly = vState;
            lkeCOD_ALMA.Properties.ReadOnly = vState;
            lkeCOD_SOCI_NEGO_RESP.Properties.ReadOnly = vState;
            lkeCOD_MOTI.Properties.ReadOnly = vState;
            memALF_COME.Properties.ReadOnly = vState;

            gdcDetail.Enabled = !vState;
        }
        public void Undo()
        {
            ClearControls();
            StateControls(true);
        }
        public void Set_New()
        {
            ClearControls();
            StateControls(false);
            txtALF_DOCU_REFE.Focus();
        }
        private void Set_ReceivingGoods(BEReceivingGoods row)
        {
            ClearControls();
            txtCOD_ALMA_RECE.Text = row.COD_ALMA_RECE.ToString();
            txtALF_DOCU_REFE.Text = row.ALF_DOCU_REFE;
            dteFEC_RECE.EditValue = row.FEC_RECE;
            dteFEC_REGI.EditValue = row.FEC_REGI;
            lkeCOD_ALMA.EditValue = row.COD_ALMA;
            lkeCOD_SOCI_NEGO_RESP.EditValue = row.COD_SOCI_NEGO_RESP;
            lkeCOD_MOTI.EditValue = row.COD_MOTI;
            memALF_COME.Text = row.ALF_COME;

            var obrg = new BEReceivingGoods() { COD_ALMA_RECE = row.COD_ALMA_RECE };
            var obr = new BRReceivingGoods();
            var olst = obr.Get_PSGN_SPLS_SVTD_ALMA_RECE(obrg);

            gdcDetail.DataSource = olst;
            gdvDetail.RefreshData();
        }
        public void Set_Search()
        {
            var ofx = new xfReceivingGoodsSearch();
            if (ofx.ShowDialog() == DialogResult.OK)
                Set_ReceivingGoods(ofx.rowsel);
        }

        private void xfReceivingGoods_Activated(object sender, EventArgs e)
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

        private void xfReceivingGoods_Deactivate(object sender, EventArgs e)
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

        private void xfReceivingGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
    }
}