using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using BusinessEntities.Ubigeo;
using BusinessRules.Ubigeo;

namespace SISPEPERS.Management
{
    public partial class xfUbigeoDireccion : DevExpress.XtraEditors.XtraForm
    {
        int COD_COMP;
        public xfUbigeoDireccion(int COMP)
        {
            InitializeComponent();
            COD_COMP = COMP;
        }

        private void xfUbigeoDireccion_Load(object sender, EventArgs e)
        {
            BESVMC_PAIS oBePais = new BESVMC_PAIS();
            BRSVMC_PAIS oBrPais = new BRSVMC_PAIS();
            List<BESVMC_PAIS> oListPais = new List<BESVMC_PAIS>();
            oBePais.NUM_ACCI = 4;
            oBePais.COD_COMP = COD_COMP;
            oListPais = oBrPais.Get_SVPR_PAIS_LIST(oBePais);

            lueCOD_PAIS.Properties.DataSource = oListPais;
            lueCOD_PAIS.Properties.Columns.Clear();
            lueCOD_PAIS.Properties.Columns.Add(new LookUpColumnInfo("ALF_PAIS", 100, "Pais"));
            lueCOD_PAIS.Properties.DisplayMember = "ALF_PAIS";
            lueCOD_PAIS.Properties.ValueMember = "COD_PAIS";

        }
        private void cargarDepartamentos(int COD_PAIS)
        {
            BESVMC_DEPA oBeDepartamento = new BESVMC_DEPA();
            BRSVMC_DEPA oBrDepartamento = new BRSVMC_DEPA();
            List<BESVMC_DEPA> oListDepartamento = new List<BESVMC_DEPA>();
            oBeDepartamento.COD_PAIS = COD_PAIS;
            oBeDepartamento.NUM_ACCI = 5;
            oListDepartamento = oBrDepartamento.Get_SVPR_DEPA_LIST(oBeDepartamento);

            luePopCOD_DEPA.Properties.DataSource = oListDepartamento;
            luePopCOD_DEPA.Properties.Columns.Clear();
            luePopCOD_DEPA.Properties.Columns.Add(new LookUpColumnInfo("ALF_DEPA", 100, "Departamento"));
            luePopCOD_DEPA.Properties.DisplayMember = "ALF_DEPA";
            luePopCOD_DEPA.Properties.ValueMember = "COD_DEPA";
        }
        /// <summary>
        /// CARGAR PROVINCIAS EN FUNCION AL DEPARTAMENTO SELECCIONADO
        /// </summary>
        /// <param name="COD_DEPA"></param>
        /// <param name="selector"></param>
        private void cargarProvincias(string COD_DEPA)
        {
            BESVMC_PROV oBeProvinciaOrigen = new BESVMC_PROV();
            BRSVMC_PROV oBrProvinciaOrigen = new BRSVMC_PROV();
            List<BESVMC_PROV> oListProvinciaOrigen = new List<BESVMC_PROV>();
            oBeProvinciaOrigen.COD_DEPA = COD_DEPA;
            oBeProvinciaOrigen.NUM_ACCI = 5;
            oListProvinciaOrigen = oBrProvinciaOrigen.Get_SVPR_PROV_LIST(oBeProvinciaOrigen);

            luePopCOD_PROV.Properties.DataSource = oListProvinciaOrigen;
            luePopCOD_PROV.Properties.Columns.Clear();
            luePopCOD_PROV.Properties.Columns.Add(new LookUpColumnInfo("ALF_PROV", 100, "Provincia"));
            luePopCOD_PROV.Properties.DisplayMember = "ALF_PROV";
            luePopCOD_PROV.Properties.ValueMember = "COD_PROV";
            if (luePopCOD_PROV.EditValue != null)
                cargarDistritos(luePopCOD_PROV.EditValue.ToString(), COD_DEPA);
            else
                luePopCOD_DIST.Properties.DataSource = null;
        }
        /// <summary>
        /// CARGAR LOS DISTRITOS EN FUNCION A LA PROVINCIA QUE ESTA SELECCIONADA
        /// </summary>
        /// <param name="COD_PROV"></param>
        /// <param name="COD_DEPA"></param>
        /// <param name="selector"></param>
        private void cargarDistritos(string COD_PROV, string COD_DEPA)
        {
            BESVMC_DIST oBeDistritoOrigen = new BESVMC_DIST();
            BRSVMC_DIST oBrDistritoOrigen = new BRSVMC_DIST();
            List<BESVMC_DIST> oListDistritoOrigen = new List<BESVMC_DIST>();
            oBeDistritoOrigen.COD_PROV = COD_PROV;
            oBeDistritoOrigen.COD_DEPA = COD_DEPA;
            oBeDistritoOrigen.NUM_ACCI = 5;
            oListDistritoOrigen = oBrDistritoOrigen.Get_SVPR_DIST_LIST(oBeDistritoOrigen);

            luePopCOD_DIST.Properties.DataSource = oListDistritoOrigen;
            luePopCOD_DIST.Properties.Columns.Clear();
            luePopCOD_DIST.Properties.Columns.Add(new LookUpColumnInfo("ALF_DIST", 100, "Distrito"));
            luePopCOD_DIST.Properties.DisplayMember = "ALF_DIST";
            luePopCOD_DIST.Properties.ValueMember = "COD_DIST";
        }

        private void luePopCOD_DEPA_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit obj = (LookUpEdit)sender;
            cargarProvincias(obj.EditValue.ToString());
        }

        private void luePopCOD_PROV_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit obj = (LookUpEdit)sender;
            cargarDistritos(obj.EditValue.ToString(), luePopCOD_DEPA.EditValue.ToString());
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bbiAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void lueCOD_PAIS_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit obj = (LookUpEdit)sender;
            cargarDepartamentos(Convert.ToInt32(obj.EditValue));
        }
    }
}