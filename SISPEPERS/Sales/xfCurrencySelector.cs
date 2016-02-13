using System;
using BusinessEntities.Generics;
using BusinessRules.Generics;
using DevExpress.XtraEditors.Controls;

namespace SISPEPERS.Sales
{
    public partial class xfCurrencySelector : DevExpress.XtraEditors.XtraForm
    {
        private int SESSION_COMP;
        public xfCurrencySelector(int COD_COMP)
        {
            InitializeComponent();
            SESSION_COMP = COD_COMP;
        }

        private void xfCurrencySelector_Load(object sender, EventArgs e)
        {
            var oBeMo = new BESVMC_MONE();
            var oBrMo = new BRSVMC_MONE();

            oBeMo.NUM_ACCI = 4;
            oBeMo.COD_COMP = SESSION_COMP;
            var oListMo = oBrMo.Get_SVPR_MONE_LIST(oBeMo);

            lueCOD_MONE.Properties.DataSource = oListMo;
            lueCOD_MONE.Properties.Columns.Clear();
            lueCOD_MONE.Properties.Columns.Add(new LookUpColumnInfo("ALF_MONE", 100, "Moneda"));
            lueCOD_MONE.Properties.DisplayMember = "ALF_MONE";
            lueCOD_MONE.Properties.ValueMember = "COD_MONE";
        }
    }
}