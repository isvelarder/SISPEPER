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
    public partial class xfReferralGuideSearch : DevExpress.XtraEditors.XtraForm
    {
        private List<int> COD_GUIA;
        int COD_COMP;
        public List<BESVTC_COTI> oList;
        public xfReferralGuideSearch(List<int> PARAM,int COMP)
        {
            InitializeComponent();
            COD_GUIA = PARAM;
            COD_COMP = COMP;
            oList = new List<BESVTC_COTI>();
        }

        private void xfReferralGuideSearch_Load(object sender, EventArgs e)
        {
            var oBe = new BESVTC_COTI();
            var oBr = new BRSVTC_COTI();
            oBe.NUM_ACCI = 7;
            oBe.COD_TIPO_DOCU = 3;
            oBe.COD_COMP = COD_COMP;
            oBe.ALF_NUME_IDEN=COD_GUIA[0].ToString();
            oList = oBr.Get_SVPR_COTI_BUSC(oBe);
            oList.ForEach(obj => {
                if (COD_GUIA.Count(objI => objI == obj.COD_GREM) > 0)
                    obj.IND_MARC = true;
            });
            gdcReferralGuide.DataSource = oList;
        }

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gdvReferralGuide.CloseEditor();
            gdvReferralGuide.RefreshData();
            DialogResult = DialogResult.OK;
        }

        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}