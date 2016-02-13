using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using BusinessEntities.Purchase;
using BusinessRules.Purchase;

namespace SISPEPERS
{
    public partial class xfPurchaseOrderSearch : XtraForm
    {
        public xfPurchaseOrderSearch()
        {
            InitializeComponent();
        }
        public int SESSION_COMP { get; set; }
        public BEDocument rowsel { get; set; }
        private void Search()
        {
            try
            {
                var opar = new BEDocument();
                opar.ALF_SOCI_NEGO = txtALF_SOCI_NEGO.Text.Trim();
                opar.FEC_REGI_INIC = (DateTime?)dteFEC_REGI_INIC.EditValue;
                opar.FEC_REGI_FINA = (DateTime?)dteFEC_REGI_FINA.EditValue;
                opar.ALF_DOCU_REFE = txtALF_DOCU_REFE.Text;
                opar.IND_ESTA = (lkeIND_ESTA.EditValue != null) ? lkeIND_ESTA.EditValue.ToString() : null;
                opar.COD_SUCU = SESSION_COMP;

                var obr = new BRPurchase();
                var olst = obr.Get_PSCP_SPLS_SCPC_ORCO(opar);

                gdcSearch.DataSource = olst;
                gdvSearch.MoveFirst();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, _Message.MsgInsCaption, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Get_RowSelecion()
        {
            try
            {
                if (gdvSearch.RowCount == 0)
                    throw new ArgumentException(_Message.MsgZeroRows);

                rowsel = (BEDocument)gdvSearch.GetRow(gdvSearch.FocusedRowHandle);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, _Message.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Get_Load()
        {
            var olstt = new List<BEStatus>();
            olstt.Add(new BEStatus() { COD_ESTA = "AB", ALF_ESTA = "Abierto" });
            olstt.Add(new BEStatus() { COD_ESTA = "CE", ALF_ESTA = "Cerrado" });
            olstt.Add(new BEStatus() { COD_ESTA = "AN", ALF_ESTA = "Anulado" });
            lkeIND_ESTA.Properties.DataSource = olstt;
            lkeIND_ESTA.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_ESTA", "Estado", 20);
            lkeIND_ESTA.Properties.Columns.Add(lkci);
            lkeIND_ESTA.Properties.DisplayMember = "ALF_ESTA";
            lkeIND_ESTA.Properties.ValueMember = "COD_ESTA";
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void gdvSearch_DoubleClick(object sender, EventArgs e)
        {
            var view = (GridView)sender;
            var pt = view.GridControl.PointToClient(Control.MousePosition);
            var info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
                Get_RowSelecion();
        }
        private void txtParameter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
        private void xfPurchaseSearch_Load(object sender, EventArgs e)
        {
            Get_Load();
        }
        private void lkeIND_ESTA_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                lkeIND_ESTA.EditValue = null;
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Get_RowSelecion();
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}