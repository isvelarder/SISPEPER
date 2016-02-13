using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using DevExpress.XtraGrid.Views.Grid;

namespace SISPEPERS
{
    public partial class xfSearchWarehouseArticle : XtraForm
    {
        public xfSearchWarehouseArticle()
        {
            InitializeComponent();
            rowsel = new BEArticle();
        }

        public BEArticle rowsel { get; set; }
        private void Search()
        {
            try
            {
                var opar = new BEArticle();
                var sortindex = gdvSearch.SortedColumns[0].VisibleIndex;
                if (sortindex == 0)
                    opar.ALF_CODI_ARTI = txtParameter.Text.Trim();
                else
                    opar.ALF_ARTI = txtParameter.Text.Trim();
                opar.COD_COMP = xfMain.SgIns.SESSION_COMP;

                opar.COD_ALMA = rowsel.COD_ALMA;
                var obr = new BRArticle();
                var olst = obr.Get_PSGN_SPLS_SVMC_ARTI_ALMA(opar);

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

                rowsel = (BEArticle)gdvSearch.GetRow(gdvSearch.FocusedRowHandle);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void sbtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void sbtOk_Click(object sender, EventArgs e)
        {
            Get_RowSelecion();
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
    }
}