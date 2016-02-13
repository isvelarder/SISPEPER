using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraGrid.Views.Grid;

namespace SISPEPERS.Warehouse
{
    public partial class xfModelArticle : XtraForm
    {
        public xfModelArticle()
        {
            InitializeComponent();
        }
        private void Get_Load()
        {
            var obr = new BRModelArticle();
            var olst = obr.Get_PSGN_SPLS_SVMC_MODE_ARTI(xfMain.SgIns.SESSION_COMP);
            if (olst.Count == 0)
            {
                var obj = new BEModelArticle() { IND_MNTN = 1, COD_USUA_CREA = xfMain.SgIns.SESSION_USER };
                olst.Add(obj);
            }
            gdcGeneric.DataSource = olst;

            BeginInvoke(new MethodInvoker(() =>
            {
                gdvGeneric.MoveLast();
                gdvGeneric.FocusedColumn = gdvGeneric.VisibleColumns[1];
                gdvGeneric.ShowEditor();
            }));
        }        
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    gdvGeneric.CloseEditor();
                    gdvGeneric.RefreshData();
                    var olst = (List<BEModelArticle>)gdvGeneric.DataSource;
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

                    var obj = new BEModelArticle() { IND_MNTN = 1, COD_USUA_CREA = xfMain.SgIns.SESSION_USER };
                    olst.Add(obj);
                    gdvGeneric.RefreshData();
                    gdvGeneric.MoveLast();
                    gdvGeneric.FocusedColumn = gcALF_MODE_ARTI;
                    gdvGeneric.ShowEditor();
                }
                else if (index == 1)
                {
                    var row = (BEModelArticle)gdvGeneric.GetRow(gdvGeneric.FocusedRowHandle);
                    if (row.IND_MNTN != 0 &&
                        row.IND_MNTN != 3)
                    {
                        gdvGeneric.DeleteRow(gdvGeneric.FocusedRowHandle);
                    }
                    else
                    {
                        row.COD_USUA_MODI = xfMain.SgIns.SESSION_USER;
                        row.IND_MNTN = 3;
                    }
                    gdvGeneric.RefreshData();
                }
                else
                {
                    gdvGeneric.CloseEditor();
                    gdvGeneric.RefreshData();
                    if (gdvGeneric.RowCount == 0) return;
                    using (var osfl = new SaveFileDialog
                    {
                        Title = WhMessage.MsgSelFile,
                        Filter = WhMessage.MsgFilExport,
                        ValidateNames = true
                    })
                    {
                        if (osfl.ShowDialog() != DialogResult.OK)
                            return;
                        gdvGeneric.ExportToXlsx(osfl.FileName);
                        if (XtraMessageBox.Show(WhMessage.MsgConExport, WhMessage.MsgInsCaption,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            System.Diagnostics.Process.Start(osfl.FileName);
                    } 
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
        private void Set_Save()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                gdvGeneric.CloseEditor();
                gdvGeneric.RefreshData();
                var olst = (List<BEModelArticle>)gdvGeneric.DataSource;
                var i = 1;
                olst.ForEach(item =>
                {
                    var context = new ValidationContext(item, null, null);
                    var errors = new List<ValidationResult>();
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

                var obr = new BRModelArticle();
                var obej = new BEModelArticle();
                obr.Set_PSGN_SPMT_SVMC_MODE_ARTI(obej, olst);
                if (!string.IsNullOrWhiteSpace(obej.MSG_MNTN))
                {
                    msgIcon = MessageBoxIcon.Error;
                    throw new ArgumentException(obej.MSG_MNTN);
                }

                olst.RemoveAll(item => item.IND_MNTN == 3);
                olst.ForEach(item => item.IND_MNTN = 0);
                gdvGeneric.RefreshData();
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

        private void xfTypeArticle_Load(object sender, EventArgs e)
        {
            Get_Load();
        }
        private void gdcGeneric_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var index = ((NavigatorCustomButton)e.Button).Index;
            Set_Operation(index);
        }
        private void gdvGeneric_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            var obej = (BEModelArticle)gdvGeneric.GetRow(e.RowHandle);
            if (obej.IND_MNTN == 3)
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                e.Appearance.BackColor = Color.LightGray;
                e.Appearance.ForeColor = Color.Gray;
            }
        }
        private void sbtSave_Click(object sender, EventArgs e)
        {
            Set_Save();
        }
        private void sbtClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void gdvGeneric_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
                e.Info.ImageIndex = -1;
            }
        }
        private void gdvGeneric_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var obej = (BEModelArticle)gdvGeneric.GetRow(e.RowHandle);
            if (obej.IND_MNTN != 1)
                obej.IND_MNTN = 2;
        }
    }
}