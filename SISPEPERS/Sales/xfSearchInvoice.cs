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
using BusinessEntities.Sales;
using BusinessRules.Sales;

namespace SISPEPERS.Sales
{
    public partial class xfSearchInvoice : DevExpress.XtraEditors.XtraForm
    {
        public BESVTC_COTI oBe;
        private int SESSION_COMP;
        private string ALF_NUME_IDEN;
        private int COD_MONE;

        public xfSearchInvoice(int COD_TIPO_DOCU, int COMP,string NUME_IDEN,int COD_MONE_PARA)
        {
            InitializeComponent();
            oBe = new BESVTC_COTI();
            oBe.COD_TIPO_DOCU = COD_TIPO_DOCU;
            SESSION_COMP = COMP;
            ALF_NUME_IDEN = NUME_IDEN;
            COD_MONE = COD_MONE_PARA;
        }

        private void sbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var oBr = new BRSVTC_COTI();
                oBe.ALF_NUME_IDEN = txtALF_NUME_IDEN.Text;
                oBe.FEC_DESD = deFEC_DESD.DateTime;
                oBe.FEC_HAST = deFEC_HAST.DateTime;
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_MONE = COD_MONE;
                oBe.NUM_ACCI = 11;

                var oList = oBr.Get_SVPR_COTI_BUSC(oBe);

                gdcResult.DataSource = oList;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void xfSearchInvoice_Load(object sender, EventArgs e)
        {
            if (oBe.COD_TIPO_DOCU == 1)
            {
                gdvResult.GroupPanelText = "Cotizaciones registradas";
                this.Text = "Buscar cotización";
            }
            else if (oBe.COD_TIPO_DOCU == 2)
            {
                gdvResult.GroupPanelText = "Ordenes de venta registradas";
                this.Text = "Buscar orden de venta";
            }
            else if (oBe.COD_TIPO_DOCU == 3)
            {
                gdvResult.GroupPanelText = "Guia de venta registradas";
                this.Text = "Buscar guia de remisión";
                gcCOD_DOCU.Caption = "Guia";
            }
            else if (oBe.COD_TIPO_DOCU == 4)
            {
                gdvResult.GroupPanelText = "Documento de venta registrados";
                this.Text = "Buscar documento de venta";
                gcCOD_DOCU_INIC.Caption = "Guia";
                gcCOD_DOCU.Caption = "Factura";
            }
            else if (oBe.COD_TIPO_DOCU == 5)
            {
                gdvResult.GroupPanelText = "Notas de crédito registradas";
                this.Text = "Buscar nota de crédito";
            }
            deFEC_DESD.DateTime = DateTime.Today;
            deFEC_HAST.DateTime = DateTime.Today;
            txtALF_NUME_IDEN.Text = ALF_NUME_IDEN;
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Accept();
        }

        private void Accept()
        {
            if (gdvResult.RowCount > 0)
            {
                if (gdvResult.FocusedRowHandle >= 0)
                {
                    oBe = (BESVTC_COTI)gdvResult.GetRow(gdvResult.FocusedRowHandle);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void gdvResult_DoubleClick(object sender, EventArgs e)
        {
            Accept();
        }
    }
}