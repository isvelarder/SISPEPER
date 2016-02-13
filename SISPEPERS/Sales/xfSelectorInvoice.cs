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
    public partial class xfSelectorInvoice : DevExpress.XtraEditors.XtraForm
    {
        public xfSelectorInvoice()
        {
            InitializeComponent();
        }

        private void sbDetail_Click(object sender, EventArgs e)
        {
            Sales.xfSalesInvoice.SgIns.Print();
        }

        private void sbClustered_Click(object sender, EventArgs e)
        {
            Sales.xfSalesInvoice.SgIns.PrintKit();
        }
    }
}