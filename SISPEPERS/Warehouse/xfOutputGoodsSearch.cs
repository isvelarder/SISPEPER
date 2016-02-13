using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace SISPEPERS
{
    public partial class xfOutputGoodsSearch : XtraForm
    {
        public xfOutputGoodsSearch()
        {
            InitializeComponent();
        }

        public BEOutputGoods rowsel { get; set; }
        private void Search()
        {
            try
            {
                var opar = new BEOutputGoods();
                opar.COD_ALMA = (int?)lkeCOD_ALMA.EditValue;
                opar.COD_MOTI = (int?)lkeCOD_MOTI.EditValue;
                opar.FEC_SALI = (DateTime?)dteFEC_SALI.EditValue;
                opar.FEC_REGI = (DateTime?)dteFEC_REGI.EditValue;
                opar.ALF_DOCU_REFE = txtALF_DOCU_REFE.Text;
                opar.COD_COMP = xfMain.SgIns.SESSION_COMP;

                var obr = new BROutputGoods();
                var olst = obr.Get_PSGN_SPLS_SVTC_ALMA_SALI(opar);

                gdcSearch.DataSource = olst;
                gdvSearch.MoveFirst();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, WhMessage.MsgInsCaption, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Get_RowSelecion()
        {
            try
            {
                if (gdvSearch.RowCount == 0)
                    throw new ArgumentException(WhMessage.MsgZeroRows);

                rowsel = (BEOutputGoods)gdvSearch.GetRow(gdvSearch.FocusedRowHandle);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Get_Load()
        {
            var obral = new BRWarehouse();
            var obrmo = new BRReason();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(xfMain.SgIns.SESSION_COMP);
            var olsmo = obrmo.Get_PSGN_SPLS_SVMC_MOTI(xfMain.SgIns.SESSION_COMP);

            lkeCOD_ALMA.Properties.DataSource = olsal;
            lkeCOD_ALMA.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_ALMA", "Almacén", 20);
            lkeCOD_ALMA.Properties.Columns.Add(lkci);
            lkeCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            lkeCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            lkeCOD_MOTI.Properties.DataSource = olsmo;
            lkeCOD_MOTI.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MOTI", "Motivo", 20);
            lkeCOD_MOTI.Properties.Columns.Add(lkci);
            lkeCOD_MOTI.Properties.DisplayMember = "ALF_MOTI";
            lkeCOD_MOTI.Properties.ValueMember = "COD_MOTI";
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void sbtCancel_Click(object sender, EventArgs e)
        {
            
        }
        private void sbtOk_Click(object sender, EventArgs e)
        {
            
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
        private void xfEntryGoodsSearch_Load(object sender, EventArgs e)
        {
            Get_Load();
        }
        private void lkeCOD_MOTI_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                lkeCOD_MOTI.EditValue = null;
        }
        private void lkeCOD_ALMA_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
                lkeCOD_ALMA.EditValue = null;
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