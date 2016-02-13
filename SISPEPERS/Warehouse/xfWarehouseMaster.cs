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
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using BusinessEntities.Management;
using BusinessRules.Management;

namespace SISPEPERS.Warehouse
{
    public partial class xfWarehouseMaster : DevExpress.XtraEditors.XtraForm
    {
        private string SESSION_USER { get; set; }
        public int SESSION_PERF { get; set; }
        public int SESSION_COMP { get; set; }
        public string FORM_SUBO { get; set; }

        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfWarehouseMaster mSgIns;
        public static xfWarehouseMaster SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfWarehouseMaster();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfWarehouseMaster()
        {
            InitializeComponent();
        }

        private void xfWarehouseMaster_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var oBe = new BESVMC_SOCI_NEGO();
            var oBr = new BRSVMC_SOCI_NEGO();

            oBe.NUM_ACCI = 7;
            oBe.COD_COMP = SESSION_COMP;
            var oList = oBr.Get_SVPR_SOCI_NEGO_LIST(oBe);

            lueCOD_SOCI_NEGO_ENCA.Properties.DataSource = oList;
            lueCOD_SOCI_NEGO_ENCA.Properties.Columns.Clear();
            lueCOD_SOCI_NEGO_ENCA.Properties.Columns.Add(new LookUpColumnInfo("ALF_NOMB", 100, "Empleados"));
            lueCOD_SOCI_NEGO_ENCA.Properties.DisplayMember = "ALF_NOMB";
            lueCOD_SOCI_NEGO_ENCA.Properties.ValueMember = "COD_SOCI_NEGO";

            var oBeU = new BEWarehouse();
            var oBrU = new BRWarehouse();

            oBeU.COD_COMP = SESSION_COMP;
            oBeU.NUM_ACCI = 4;

            var oListWarehouse = oBrU.Get_SVPR_ALMA_LIST(oBeU);

            gdcWarehouse.DataSource = oListWarehouse;

            StateControl(true);
        }

        private void xfWarehouseMaster_Activated(object sender, EventArgs e)
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

        private void xfWarehouseMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;
        }

        private void xfWarehouseMaster_Deactivate(object sender, EventArgs e)
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

        private void gdvWarehouse_RowClick(object sender, RowClickEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.RowHandle >= 0)
                {
                    var oBe = (BEWarehouse)gdvWarehouse.GetRow(e.RowHandle);
                    txtCOD_ALMA.Text = oBe.COD_ALMA.ToString();
                    txtALF_ALMA.Text = oBe.ALF_ALMA;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    lueCOD_SOCI_NEGO_ENCA.EditValue = oBe.COD_SOCI_NEGO_ENCA;
                }
            }
        }

        private void gdvWarehouse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView Grid = (GridView)sender;

            if (Grid.RowCount > 0)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    var oBe = (BEWarehouse)gdvWarehouse.GetRow(e.FocusedRowHandle);
                    txtCOD_ALMA.Text = oBe.COD_ALMA.ToString();
                    txtALF_ALMA.Text = oBe.ALF_ALMA;
                    meALF_DESC.Text = oBe.ALF_DESC;
                    lueCOD_SOCI_NEGO_ENCA.EditValue = oBe.COD_SOCI_NEGO_ENCA;
                }
            }
        }

        private void ClearControl()
        {
            txtCOD_ALMA.Text = "";
            txtALF_ALMA.Text = "";
            meALF_DESC.Text = "";
            lueCOD_SOCI_NEGO_ENCA.EditValue = null;
        }

        private void StateControl(bool vState)
        {
            txtALF_ALMA.Properties.ReadOnly = vState;
            meALF_DESC.Properties.ReadOnly = vState;
            lueCOD_SOCI_NEGO_ENCA.Properties.ReadOnly = vState;
            gdcWarehouse.Enabled = vState;
        }

        public void New()
        {
            ClearControl();
            StateControl(false);
            txtALF_ALMA.Focus();
        }

        public void Edit()
        {
            StateControl(false);
            txtALF_ALMA.Focus();
        }

        public void Undo()
        {
            ClearControl();
            StateControl(true);
        }

        public void Save()
        {
            try
            {
                if (string.IsNullOrEmpty(txtALF_ALMA.Text))
                    throw new ArgumentException("Ingrese el nombre para el almacén");
                if (lueCOD_SOCI_NEGO_ENCA.EditValue == null)
                    throw new ArgumentException("Seleccione el encargado");

                var oBe = new BEWarehouse();
                var oBr = new BRWarehouse();

                if (!string.IsNullOrEmpty(txtCOD_ALMA.Text))
                {
                    oBe.NUM_ACCI = 2;
                    oBe.COD_ALMA = Convert.ToInt32(txtCOD_ALMA.Text);
                }
                else
                {
                    oBe.NUM_ACCI = 1;
                }
                
                oBe.ALF_ALMA = txtALF_ALMA.Text;
                oBe.ALF_DESC = meALF_DESC.Text;
                oBe.COD_SOCI_NEGO_ENCA = Convert.ToInt32(lueCOD_SOCI_NEGO_ENCA.EditValue);
                oBe.COD_COMP = SESSION_COMP;
                oBe.COD_USUA_CREA = SESSION_USER;
                oBe.COD_USUA_MODI = SESSION_USER;

                oBr.Set_SVPR_ALMA(oBe);

                var oBeU = new BEWarehouse();
                var oBrU = new BRWarehouse();

                oBeU.COD_COMP = SESSION_COMP;
                oBeU.NUM_ACCI = 4;

                var oListWarehouse = oBrU.Get_SVPR_ALMA_LIST(oBeU);

                gdcWarehouse.DataSource = oListWarehouse;

                StateControl(true);

                XtraMessageBox.Show("Operacion realizada con exito!!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}