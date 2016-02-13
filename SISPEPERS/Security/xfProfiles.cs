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
using BusinessEntities.Security;
using BusinessRules.Security;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraBars;

namespace SISPEPERS.Seguridad
{
    public partial class xfProfiles : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }
        public List<BESVMC_OPCI> oListOpci;
        public List<BESVMC_BUTT> oListButt;

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfProfiles mSgIns;
        public static xfProfiles SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfProfiles();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }


        public xfProfiles()
        {
            InitializeComponent();
            oListOpci = new List<BESVMC_OPCI>();
        }

        private void xfProfiles_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            ControlState(true);

            var oBe = new BESVMC_PERF();
            var oBr = new BRSVMC_PERF();

            var oBeMm = new BESVMC_MAIN_MENU();
            var oBrMm = new BRSVMC_MAIN();

            oBe.NUM_ACCI = 4;
            oBe.COD_COMP = SESSION_COMP;
            var oList = oBr.Get_SVPR_PERF_LIST(oBe);
            gdcProfile.DataSource = oList;           
            
            oBeMm.NUM_ACCI = 4;
            var oListMm = oBrMm.Get_SVPR_MAIN_LIST(oBeMm);
            gdcMain.DataSource = oListMm;
        }

        private void xfProfiles_Activated(object sender, EventArgs e)
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

        private void xfProfiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
            SESSION_USER = null;
            SESSION_PERF = 0;
        }

        private void gdvMain_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_MAIN_MENU)Grid.GetRow(e.RowHandle);
                    gdvOptions.ActiveFilter.Add(gdvOptions.Columns["COD_MAIN"],
                        new ColumnFilterInfo(String.Format("[COD_MAIN] = {0} ", oBe.COD_MAIN), ""));

                    gdvButtons.ActiveFilter.Add(gdvButtons.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", 0), ""));
                }
            }
        }

        private void gdvMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_MAIN_MENU)Grid.GetRow(e.FocusedRowHandle);
                    gdvOptions.ActiveFilter.Add(gdvOptions.Columns["COD_MAIN"],
                        new ColumnFilterInfo(String.Format("[COD_MAIN] = {0} ", oBe.COD_MAIN), ""));

                    gdvButtons.ActiveFilter.Add(gdvButtons.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", 0), ""));
                }
            }
        }

        private void gdvOptions_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_OPCI)Grid.GetRow(e.RowHandle);
                    gdvButtons.ActiveFilter.Add(gdvOptions.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", oBe.COD_OPCI), ""));
                }
            }
        }

        private void gdvOptions_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_OPCI)Grid.GetRow(e.FocusedRowHandle);
                    gdvButtons.ActiveFilter.Add(gdvOptions.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", oBe.COD_OPCI), ""));
                }
            }
        }

        public void ControlState(bool vState)
        {
            txtALF_PERF.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            gcIND_MARC.OptionsColumn.ReadOnly = vState;
            gcbIND_MARC.OptionsColumn.ReadOnly = vState;
        }

        public void Edit()
        {
            ControlState(false);
            txtALF_PERF.Focus();
        }

        public void Undo()
        {
            ClearControls();
            var oBeProf = new BESVMC_PERF();
            var oBrProf = new BRSVMC_PERF();

            oBeProf.NUM_ACCI = 4;
            oBeProf.COD_COMP = SESSION_COMP;
            var oList = oBrProf.Get_SVPR_PERF_LIST(oBeProf);
            gdcProfile.DataSource = oList;
            ControlState(true);
        }

        public void ClearControls()
        {
            txtCOD_PERF.Text = "";
            txtALF_PERF.Text = "";
            meALF_DESC.Text = "";

            var oBeOpci = new BESVMC_OPCI();
            var oBrOpci = new BRSVMC_OPCI();

            var oBeButt = new BESVMC_BUTT();
            var oBrButt = new BRSVMC_BUTT();

            oListOpci.ForEach(obj => {
                obj.IND_MARC = false;
            });
            gdcOptions.DataSource = oListOpci;

            oListButt.ForEach(obj => {
                obj.IND_MARC = false;
            });
            gdcButtons.DataSource = oListButt;
        }

        public void New()
        {
            ControlState(false);
            ClearControls();
            txtALF_PERF.Focus();
        }

        public void Save()
        {
            try
            {
                gdvOptions.CloseEditor();
                gdvOptions.RefreshData();

                gdvButtons.CloseEditor();
                gdvButtons.RefreshData();

                var oBe = new BESVMC_PERF();
                var oBr = new BRSVMC_PERF();

                if (string.IsNullOrEmpty(txtCOD_PERF.Text))
                {
                    oBe.NUM_ACCI = 1;
                }
                else
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_PERF = int.Parse(txtCOD_PERF.Text);
                }

                oBe.ALF_PERF = txtALF_PERF.Text;
                oBe.ALF_DESC = meALF_DESC.Text;

                oBe.OBJ_ACCE.LST_OPCI = oListOpci;
                oBe.OBJ_ACCE.LST_OPCI_BUTT = oListButt;

                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;

                if (XtraMessageBox.Show("Esta seguro de que desea guardar los datos del perfil?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oBr.Set_SVPR_PERF(oBe);

                    txtCOD_PERF.Text = oBe.COD_PERF.ToString();

                    var oBeOpci = new BESVMC_OPCI();
                    var oBrOpci = new BRSVMC_OPCI();

                    var oBeButt = new BESVMC_BUTT();
                    var oBrButt = new BRSVMC_BUTT();

                    oBeOpci.NUM_ACCI = 4;
                    oBeOpci.COD_PERF = oBe.COD_PERF;

                    oListOpci = oBrOpci.Get_SVPR_OPCI_LIST(oBeOpci);
                    gdcOptions.DataSource = oListOpci;
                    gdvOptions.ActiveFilter.Add(gdvOptions.Columns["COD_MAIN"],
                        new ColumnFilterInfo(String.Format("[COD_MAIN] = {0} ", 0), ""));

                    oBeButt.NUM_ACCI = 4;
                    oBeButt.COD_PERF = oBe.COD_PERF;

                    oListButt = oBrButt.Get_SVPR_BUTT_LIST(oBeButt);
                    gdcButtons.DataSource = oListButt;
                    gdvButtons.ActiveFilter.Add(gdvButtons.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", 0), ""));

                    var oBeProf = new BESVMC_PERF();
                    var oBrProf = new BRSVMC_PERF();

                    oBeProf.NUM_ACCI = 4;
                    oBeProf.COD_COMP = SESSION_COMP;
                    var oList = oBrProf.Get_SVPR_PERF_LIST(oBeProf);
                    gdcProfile.DataSource = oList;
                    ControlState(true);
                    XtraMessageBox.Show("Operacion realizada con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gdvProfile_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BESVMC_PERF)gdvProfile.GetRow(e.RowHandle);
                    txtCOD_PERF.Text = oBe.COD_PERF.ToString();
                    txtALF_PERF.Text = oBe.ALF_PERF;
                    meALF_DESC.Text = oBe.ALF_DESC;

                    var oBeOpci = new BESVMC_OPCI();
                    var oBrOpci = new BRSVMC_OPCI();

                    var oBeButt = new BESVMC_BUTT();
                    var oBrButt = new BRSVMC_BUTT();

                    oBeOpci.NUM_ACCI = 4;
                    oBeOpci.COD_PERF = oBe.COD_PERF;

                    oListOpci = oBrOpci.Get_SVPR_OPCI_LIST(oBeOpci);
                    gdcOptions.DataSource = oListOpci;
                    gdvOptions.ActiveFilter.Add(gdvOptions.Columns["COD_MAIN"],
                        new ColumnFilterInfo(String.Format("[COD_MAIN] = {0} ", 0), ""));

                    oBeButt.NUM_ACCI = 4;
                    oBeButt.COD_PERF = oBe.COD_PERF;

                    oListButt = oBrButt.Get_SVPR_BUTT_LIST(oBeButt);
                    gdcButtons.DataSource = oListButt;
                    gdvButtons.ActiveFilter.Add(gdvButtons.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", 0), ""));

                }
            }
        }

        private void gdvProfile_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BESVMC_PERF)gdvProfile.GetRow(e.FocusedRowHandle);
                    txtCOD_PERF.Text = oBe.COD_PERF == 0 ? "" : oBe.COD_PERF.ToString();
                    txtALF_PERF.Text = oBe.ALF_PERF;
                    meALF_DESC.Text = oBe.ALF_DESC;

                    var oBeOpci = new BESVMC_OPCI();
                    var oBrOpci = new BRSVMC_OPCI();

                    var oBeButt = new BESVMC_BUTT();
                    var oBrButt = new BRSVMC_BUTT();

                    oBeOpci.NUM_ACCI = 4;
                    oBeOpci.COD_PERF = oBe.COD_PERF;

                    oListOpci = oBrOpci.Get_SVPR_OPCI_LIST(oBeOpci);
                    gdcOptions.DataSource = oListOpci;
                    gdvOptions.ActiveFilter.Add(gdvOptions.Columns["COD_MAIN"],
                        new ColumnFilterInfo(String.Format("[COD_MAIN] = {0} ", 0), ""));

                    oBeButt.NUM_ACCI = 4;
                    oBeButt.COD_PERF = oBe.COD_PERF;

                    oListButt = oBrButt.Get_SVPR_BUTT_LIST(oBeButt);
                    gdcButtons.DataSource = oListButt;
                    gdvButtons.ActiveFilter.Add(gdvButtons.Columns["COD_OPCI"],
                        new ColumnFilterInfo(String.Format("[COD_OPCI] = {0}", 0), ""));

                }
            }
        }

        private void xfProfiles_Deactivate(object sender, EventArgs e)
        {
            var oBeAcce = new BESVMD_ACCE();
            var oBrAcce = new BRSVMD_ACCE();
            oBeAcce.NUM_ACCI = 5;
            oBeAcce.ALF_NOMB = FORM_SUBO;
            oBeAcce.COD_PERF = SESSION_PERF;
            var oListBotones = oBrAcce.Get_SVPR_ACCE_LIST(oBeAcce);

            foreach (BarButtonItemLink itemLink in ((xfMain)MdiParent).barTool.ItemLinks)
            {
                itemLink.Item.Visibility = BarItemVisibility.Never;
            }
        }
    }
}