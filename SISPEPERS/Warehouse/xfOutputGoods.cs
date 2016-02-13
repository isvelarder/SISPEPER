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
using BusinessRules.Security;
using BusinessEntities.Security;
using BusinessRules.Generics;

namespace SISPEPERS.Warehouse
{
    public partial class xfOutputGoods : XtraForm
    {
        public xfOutputGoods()
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
        private static xfOutputGoods mSgIns;
        public static xfOutputGoods SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfOutputGoods();
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
            var oBeM = new BEReason();
            oBeM.COD_COMP = SESSION_COMP;
            oBeM.COD_TIPO_MOTI = 2;
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

            var obj = new BEOutputGoodsDetail() { COD_USUA_CREA = SESSION_USER };
            var olst = new List<BEOutputGoodsDetail>();
            olst.Add(obj);
            gdcDetail.DataSource = olst;

        }
        private void xfOutputGoods_Load(object sender, EventArgs e)
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
        private void rpiArticle_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oxf = new xfSearchWarehouseArticle();
            oxf.rowsel.COD_ALMA = (int?)lkeCOD_ALMA.EditValue;
            if (oxf.ShowDialog() == DialogResult.OK)
            {
                var olst = (List<BEOutputGoodsDetail>)gdvDetail.DataSource;
                var exist = olst.Exists(item => item.COD_ARTI == oxf.rowsel.COD_ARTI);
                if (!exist)
                {
                    var row = new BEOutputGoodsDetail()
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
                    var olst = (List<BEOutputGoodsDetail>)gdvDetail.DataSource;
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

                    var obj = new BEOutputGoodsDetail() { COD_USUA_CREA = SESSION_USER };
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
                if (!string.IsNullOrWhiteSpace(txtCOD_ALMA_SALI.Text))
                {
                    msgIcon = MessageBoxIcon.Warning;
                    throw new ArgumentException(WhMessage.MsgNotModyRegis);
                }
                var obog = new BEOutputGoods() 
                { 
                    ALF_DOCU_REFE = txtALF_DOCU_REFE.Text.Trim(), 
                    FEC_SALI = (DateTime?)dteFEC_SALI.EditValue, 
                    FEC_REGI = (DateTime?)dteFEC_REGI.EditValue, 
                    COD_ALMA = (int?)lkeCOD_ALMA.EditValue, 
                    COD_SOCI_NEGO_RESP = (int?)lkeCOD_SOCI_NEGO_RESP.EditValue, 
                    COD_MOTI = (int?)lkeCOD_MOTI.EditValue, 
                    ALF_COME = memALF_COME.Text.Trim(),
                    COD_COMP = SESSION_COMP,
                    COD_USUA_CREA = SESSION_USER, 
                    COD_USUA_MODI = SESSION_USER 
                };

                var context = new ValidationContext(obog, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obog, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                gdvDetail.CloseEditor();
                gdvDetail.RefreshData();
                var olst = (List<BEOutputGoodsDetail>)gdvDetail.DataSource;
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

                var obr = new BROutputGoods();
                obr.Set_PSGN_SPMT_SVTC_ALMA_SALI(obog, olst);
                if (!string.IsNullOrWhiteSpace(obog.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(obog.MSG_MNTN);
                }
                txtCOD_ALMA_SALI.Text = obog.COD_ALMA_SALI.ToString();
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
            txtCOD_ALMA_SALI.Text = string.Empty;
            txtALF_DOCU_REFE.Text = string.Empty;
            dteFEC_SALI.EditValue = null;
            dteFEC_REGI.EditValue = null;
            lkeCOD_ALMA.EditValue = null;
            lkeCOD_SOCI_NEGO_RESP.EditValue = null;
            lkeCOD_MOTI.EditValue = null;
            memALF_COME.Text = string.Empty;

            gdcDetail.DataSource = new List<BEOutputGoodsDetail>();
        }
        private void StateControls(bool vState)
        {
            txtALF_DOCU_REFE.Properties.ReadOnly = vState;
            dteFEC_SALI.Properties.ReadOnly = vState;
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
        private void Set_OutputGoods(BEOutputGoods row)
        {
            ClearControls();
            txtCOD_ALMA_SALI.Text = row.COD_ALMA_SALI.ToString();
            txtALF_DOCU_REFE.Text = row.ALF_DOCU_REFE;
            dteFEC_SALI.EditValue = row.FEC_SALI;
            dteFEC_REGI.EditValue = row.FEC_REGI;
            lkeCOD_ALMA.EditValue = row.COD_ALMA;
            lkeCOD_SOCI_NEGO_RESP.EditValue = row.COD_SOCI_NEGO_RESP;
            lkeCOD_MOTI.EditValue = row.COD_MOTI;
            memALF_COME.Text = row.ALF_COME;

            var obog = new BEOutputGoods() { COD_ALMA_SALI = row.COD_ALMA_SALI };
            var obr = new BROutputGoods();
            var olst = obr.Get_PSGN_SPLS_SVTD_ALMA_SALI(obog);

            gdcDetail.DataSource = olst;
            gdvDetail.RefreshData();
        }
        public void Set_Search()
        {
            var ofx = new xfOutputGoodsSearch();
            if (ofx.ShowDialog() == DialogResult.OK)
                Set_OutputGoods(ofx.rowsel);
        }

        private void xfOutputGoods_Activated(object sender, EventArgs e)
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

        private void xfOutputGoods_Deactivate(object sender, EventArgs e)
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

        private void xfOutputGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
    }
}