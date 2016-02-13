using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using BusinessEntities.Purchase;
using BusinessRules.Purchase;
using DevExpress.XtraEditors.Controls;

namespace SISPEPERS.Purchase
{
    public partial class xfExpNationalization : XtraForm
    {
        public xfExpNationalization()
        {
            InitializeComponent();
        }
        public int SESSION_COMP { get; set; }
        public List<BEDocumentExpenses> olgn { get; set; }
        private void Set_Operation(int index)
        {
            try
            {
                if (index == 0)
                {
                    gdvExpens.CloseEditor();
                    gdvExpens.RefreshData();
                    var olst = (List<BEDocumentExpenses>)gdvExpens.DataSource;
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

                    var obj = new BEDocumentExpenses() { COD_USUA_CREA = xfMain.SgIns.SESSION_USER };
                    olst.Add(obj);
                    gdvExpens.RefreshData();
                    gdvExpens.MoveLast();
                    gdvExpens.FocusedColumn = gcNUM_DOCU;
                    gdvExpens.ShowEditor();
                }
                else
                {
                    gdvExpens.DeleteRow(gdvExpens.FocusedRowHandle);
                    gdvExpens.RefreshData();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    _Message.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }
        private void gdcLines_EmbeddedNavigator_ButtonClick_1(object sender, NavigatorButtonClickEventArgs e)
        {
            var index = ((NavigatorCustomButton)e.Button).Index;
            Set_Operation(index);
        }

        private void sbtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void sbtOk_Click(object sender, EventArgs e)
        {
            try
            {
                gdvExpens.CloseEditor();
                gdvExpens.RefreshData();
                var olst = (List<BEDocumentExpenses>)gdvExpens.DataSource;
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

                olgn = (List<BEDocumentExpenses>)gdvExpens.DataSource;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                          _Message.MsgInsCaption,
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
            }
        }

        private void xfExpNationalization_Load(object sender, EventArgs e)
        {
            var obr = new BRPurchase();
            var olst = obr.Get_PSCP_SPLS_SVMC_CNGN(SESSION_COMP);

            rilConcept.DataSource = olst;
            rilConcept.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_CONC_GANA", "Concepto", 20);
            rilConcept.Columns.Add(lkci);
            rilConcept.DisplayMember = "ALF_CONC_GANA";
            rilConcept.ValueMember = "COD_CONC_GANA";

            var olmo = obr.Get_PSGN_SPLS_SVMC_MONE(SESSION_COMP);

            rilCOD_MONE.DataSource = olmo;
            rilCOD_MONE.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MONE_SIMB", "Moneda", 20);
            rilCOD_MONE.Columns.Add(lkci);
            rilCOD_MONE.DisplayMember = "ALF_MONE_SIMB";
            rilCOD_MONE.ValueMember = "COD_MONE";


            if (olgn != null)
                gdcExpens.DataSource = olgn;
        }

        private void ribCOD_SOCI_NEGO_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oxfs = new xfSearchPerson(SESSION_COMP) { NUM_ACCI = 8 };
            if (oxfs.ShowDialog() == DialogResult.OK)
            {
                var row = (BEDocumentExpenses)gdvExpens.GetRow(gdvExpens.FocusedRowHandle);
                row.COD_SOCI_NEGO = oxfs.oBe.COD_SOCI_NEGO;
                row.ALF_NOMB_PROV = oxfs.oBe.ALF_NOMB;
                row.ALF_RUCC_PROV = oxfs.oBe.ALF_NUME_IDEN;

                gdvExpens.RefreshRow(gdvExpens.FocusedRowHandle);
            }
        }
    }
}