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

namespace SISPEPERS.Sales
{
    public partial class xfSelectorCreditNote : DevExpress.XtraEditors.XtraForm
    {
        public xfSelectorCreditNote()
        {
            InitializeComponent();
        }

        private void sbDetail_Click(object sender, EventArgs e)
        {
            Sales.xfSalesCreditNote.SgIns.Print();
        }

        private void sbClustered_Click(object sender, EventArgs e)
        {
            Sales.xfSalesCreditNote.SgIns.PrintKit();
        }
    }
}