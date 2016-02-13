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
using DevExpress.XtraBars;
using BusinessRules.Security;
using BusinessEntities.Warehouse;
using System.ComponentModel.DataAnnotations;
using BusinessRules.Warehouse;
using BusinessEntities.Purchase;

namespace SISPEPERS.Warehouse
{
    public partial class xfPriceList : XtraForm
    {
        public xfPriceList()
        {
            InitializeComponent();
        }

        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }

        private static xfPriceList mSgIns;
        public static xfPriceList SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfPriceList();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void ClearControls()
        {
            txtALF_LIST_PREC.Text = string.Empty;
            txtCOD_LIST_PREC.Text = string.Empty;
            rdgIND_TIPO_LIST.SelectedIndex = -1;
            lsbPriceList.SelectedIndex = -1;
            gdcDetail.DataSource = new List<BEPriceListDetail>();
        }
        private void StateControls(bool vState)
        {
            txtALF_LIST_PREC.Properties.ReadOnly = vState;
            rdgIND_TIPO_LIST.Properties.ReadOnly = vState;
            gdcDetail.Enabled = !vState;
        }
        private void xfPriceList_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            ClearControls();
            StateControls(true);

            var obr = new BRArticle();
            var olpl = obr.Get_PSCP_SPLS_SVMC_LIST_PREC(SESSION_COMP);
            lsbPriceList.DataSource = olpl;
            lsbPriceList.DisplayMember = "ALF_LIST_PREC";
            lsbPriceList.ValueMember = "COD_LIST_PREC";
            lsbPriceList.SelectedIndex = -1;
            lsbPriceList.UnSelectAll();

            gdcDetail.DataSource = new List<BEPriceListDetail>();
        }
        private void xfPriceList_Activated(object sender, EventArgs e)
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

        private void xfPriceList_Deactivate(object sender, EventArgs e)
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

        private void xfPriceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    gdvDetail.CloseEditor();
                    gdvDetail.RefreshData();
                    var olst = (List<BEPriceListDetail>)gdvDetail.DataSource;
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

                    var obj = new BEPriceListDetail() { COD_USUA_CREA = SESSION_USER, IND_MNTN = 1 };
                    olst.Add(obj);
                    gdvDetail.RefreshData();
                    gdvDetail.MoveLast();
                    gdvDetail.FocusedColumn = gcALF_CODI_ARTI;
                    gdvDetail.ShowEditor();
                }
                else
                {
                    var row = (BEPriceListDetail)gdvDetail.GetRow(gdvDetail.FocusedRowHandle);
                    if (row.IND_MNTN != 1)
                        row.IND_MNTN = 3;
                    else
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

        private void lsbPriceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = (BEPriceList)lsbPriceList.GetItem(lsbPriceList.SelectedIndex);
            if (row == null) return;
            txtCOD_LIST_PREC.Text = row.COD_LIST_PREC.ToString();
            txtALF_LIST_PREC.Text = row.ALF_LIST_PREC;
            rdgIND_TIPO_LIST.EditValue = row.IND_TIPO_LIST;

            var obr = new BRArticle();
            var olst = obr.Get_PSCP_SPLS_SVMD_LIST_PREC(row.COD_LIST_PREC);
            gdcDetail.DataSource = olst;
        }
        public void New()
        {
            ClearControls();
            StateControls(false);
            txtALF_LIST_PREC.Focus();
        }
        public void Edit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCOD_LIST_PREC.Text))
                    throw new ArgumentException("Seleccionar un registro para realizar está opeación.");

                StateControls(false);
                txtALF_LIST_PREC.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    _Message.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void ribALF_ARTI_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oxf = new xfSearchArticle();
            if (oxf.ShowDialog() == DialogResult.OK)
            {
                var olst = (List<BEPriceListDetail>)gdvDetail.DataSource;
                var exist = olst.Exists(item => item.COD_ARTI == oxf.rowsel.COD_ARTI);
                if (!exist)
                {
                    var row = new BEPriceListDetail()
                    {
                        COD_ARTI = oxf.rowsel.COD_ARTI,
                        ALF_CODI_ARTI = oxf.rowsel.ALF_CODI_ARTI,
                        ALF_ARTI = oxf.rowsel.ALF_ARTI,
                        COD_USUA_CREA = SESSION_USER,
                        IND_MNTN = 1
                    };

                    gdvDetail.DeleteRow(gdvDetail.FocusedRowHandle);
                    olst.Add(row);
                    gdvDetail.RefreshData();
                    gdvDetail.MoveLast();
                    gdvDetail.FocusedColumn = gcNUM_PREC;
                    gdvDetail.ShowEditor();
                }
                else
                {
                    XtraMessageBox.Show(_Message.MsgExistArticle, _Message.MsgInsCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void gdvDetail_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = (BEPriceListDetail)gdvDetail.GetRow(e.RowHandle);
            if (row != null)
            {
                if (row.IND_MNTN == 0)
                {
                    row.IND_MNTN = 2;
                    gdvDetail.RefreshRow(e.RowHandle);
                }
            }
        }

        private void gdvDetail_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var row = (BEPriceListDetail)gdvDetail.GetRow(e.RowHandle);
            if (row != null)
            {
                if (row.IND_MNTN == 3)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                    e.Appearance.ForeColor = Color.LightGray;
                }
            }
        }

        public void Undo()
        {
            ClearControls();
            StateControls(true);
        }
        public void Set_Save()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                var obpc = new BEPriceList()
                {
                    COD_LIST_PREC = (string.IsNullOrWhiteSpace(txtCOD_LIST_PREC.Text)) ? 0 : Convert.ToInt32(txtCOD_LIST_PREC.Text),
                    ALF_LIST_PREC = txtALF_LIST_PREC.Text.Trim(),
                    IND_TIPO_LIST = (int?)rdgIND_TIPO_LIST.EditValue,
                    COD_COMP = SESSION_COMP,
                    COD_USUA_CREA = SESSION_USER,
                    COD_USUA_MODI = SESSION_USER,
                    IND_MNTN = (string.IsNullOrWhiteSpace(txtCOD_LIST_PREC.Text)) ? 1 : 2
                };

                var context = new ValidationContext(obpc, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obpc, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                gdvDetail.CloseEditor();
                gdvDetail.RefreshData();
                var olst = (List<BEPriceListDetail>)gdvDetail.DataSource;
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

                var obr = new BRArticle();
                obr.Set_PSCP_SPMT_SVMC_LIST_PREC(obpc, olst);
                if (!string.IsNullOrWhiteSpace(obpc.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(obpc.MSG_MNTN);
                }
                txtCOD_LIST_PREC.Text = obpc.COD_LIST_PREC.ToString();
                olst.RemoveAll(item => item.IND_MNTN == 3);
                olst.ForEach(item => { item.IND_MNTN = 0; });
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

        private void gdvDetail_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gdvDetail.FocusedColumn.FieldName == "ALF_CODI_ARTI"
                || gdvDetail.FocusedColumn.FieldName == "ALF_ARTI")
            {
                var row = (BEPriceListDetail)gdvDetail.GetRow(gdvDetail.FocusedRowHandle);
                ribALF_ARTI.Buttons[0].Enabled = (row.IND_MNTN == 1) ? true : false;
            }
        }
        public void Set_Export()
        {
            try
            {
                var olst = (List<BEPriceListDetail>)gdvDetail.DataSource;
                if (olst.Count == 0) return;
                using (var oExp = new SaveFileDialog
                {
                    Title = WhMessage.MsgSelFile,
                    Filter = WhMessage.MsgFilExport,
                    ValidateNames = true
                })
                {
                    if (oExp.ShowDialog() != DialogResult.OK)
                        return;
                    gdvDetail.ExportToXlsx(oExp.FileName);
                    if (XtraMessageBox.Show(WhMessage.MsgConExport, WhMessage.MsgInsCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(oExp.FileName);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}