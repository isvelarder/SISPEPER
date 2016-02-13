using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using BusinessRules.Warehouse;
using BusinessEntities.Security;
using BusinessRules.Security;
using DevExpress.XtraBars;
using System.Windows.Forms;
using BusinessRules.Report;
using BusinessEntities.Report;
using System.ComponentModel.DataAnnotations;
using BusinessEntities.Warehouse;
using System.Drawing;

namespace SISPEPERS.Report
{
    public partial class xfKardexInventory : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }
        public xfKardexInventory()
        {
            InitializeComponent();
        }
        private static xfKardexInventory mSgIns;
        public static xfKardexInventory SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfKardexInventory();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }
        private void xfKardexInventory_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var obral = new BRWarehouse();
            var olsal = obral.Get_PSGN_SPLS_SVMC_ALMA(SESSION_COMP);
            ccbCOD_ALMA.Properties.DataSource = olsal;
            ccbCOD_ALMA.Properties.DisplayMember = "ALF_ALMA";
            ccbCOD_ALMA.Properties.ValueMember = "COD_ALMA";

            gdcKardex.DataSource = new List<BEKardexInventory>();
        }
        private void xfKardexInventory_Activated(object sender, EventArgs e)
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

        private void xfKardexInventory_Deactivate(object sender, EventArgs e)
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
        private void xfKardexInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        private void Get_Search()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                var obj = new BEKardexInventory() { COD_COMP = SESSION_COMP };
                obj.COD_ALMA = (ccbCOD_ALMA.Properties.GetCheckedItems() == null) ? string.Empty : ccbCOD_ALMA.Properties.GetCheckedItems().ToString();
                if (!string.IsNullOrWhiteSpace(dteFEC_OPER_INIC.Text))
                {
                    obj.FEC_OPER_INIC = dteFEC_OPER_INIC.DateTime;
                    obj.FEC_OPER_FINA = dteFEC_OPER_FINA.DateTime;
                }

                var context = new ValidationContext(obj, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obj, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }

                var obr = new BRStockInventory();
                var olst = obr.Get_PSCP_SPLS_SVMD_ALMA_KARD(obj);
                gdcKardex.DataSource = olst;
                gdvKardex.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    msgIcon);
            }
        }
        private void sbtSearch_Click(object sender, EventArgs e)
        {
            Get_Search();
        }

        private void gdvKardex_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "NUM_STOC_REAL")
            {
                e.Appearance.ForeColor = Color.DarkGreen;
            }
            else if (e.Column.FieldName == "CAN_MOVI")
            {
                if (Convert.ToInt32(e.CellValue) < 0)
                {
                    e.Appearance.ForeColor = Color.Maroon;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Navy;
                }
            }
            else if (e.Column.FieldName == "NUM_STOC_FINA")
            {
                e.Appearance.ForeColor = Color.SaddleBrown;
            }
        }
        public void Set_Export()
        {
            try
            {
                var olst = (List<BEKardexInventory>)gdvKardex.DataSource;
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
                    gdvKardex.ExportToXlsx(oExp.FileName);
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