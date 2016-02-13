using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using BusinessEntities.Warehouse;
using BusinessRules.Warehouse;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.IO;
using DevExpress.XtraBars;
using BusinessEntities.Security;
using BusinessRules.Security;

namespace SISPEPERS.Warehouse
{
    public partial class xfArticle : XtraForm
    {
        private string SESSION_USER { get; set; }
        private int SESSION_COMP { get; set; }
        public int SESSION_PERF { get; set; }
        public string FORM_SUBO { get; set; }
        /// <summary>
        /// PARA DEFINIR UNA SOLA INSTANCIA
        /// </summary>
        private static xfArticle mSgIns;
        public static xfArticle SgIns
        {
            get
            {
                if (mSgIns == null || mSgIns.IsDisposed)
                    mSgIns = new xfArticle();
                return (mSgIns);
            }
            set
            {
                mSgIns = value;
            }
        }

        public xfArticle()
        {
            InitializeComponent();
        }
        private void Get_Load()
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            var obrt = new BRTypeArticle();
            var oltp = obrt.Get_PSGN_SPLS_SVMC_TIPO_ARTI(SESSION_COMP);
            lkeCOD_TIPO_ARTI.Properties.DataSource = oltp;
            lkeCOD_TIPO_ARTI.Properties.Columns.Clear();
            var lkci = new LookUpColumnInfo("ALF_TIPO_ARTI", "Tipos de Artículo", 20);
            lkeCOD_TIPO_ARTI.Properties.Columns.Add(lkci);
            lkeCOD_TIPO_ARTI.Properties.DisplayMember = "ALF_TIPO_ARTI";
            lkeCOD_TIPO_ARTI.Properties.ValueMember = "COD_TIPO_ARTI";

            var obrm = new BRModelArticle();
            var olmp = obrm.Get_PSGN_SPLS_SVMC_MODE_ARTI(SESSION_COMP);
            lkeCOD_MODE_ARTI.Properties.DataSource = olmp;
            lkeCOD_MODE_ARTI.Properties.Columns.Clear();
            lkci = new LookUpColumnInfo("ALF_MODE_ARTI", "Modelos de Artículo", 20);
            lkeCOD_MODE_ARTI.Properties.Columns.Add(lkci);
            lkeCOD_MODE_ARTI.Properties.DisplayMember = "ALF_MODE_ARTI";
            lkeCOD_MODE_ARTI.Properties.ValueMember = "COD_MODE_ARTI";

            StateControls(true);
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
        public void Set_Save()
        {
            MessageBoxIcon msgIcon = MessageBoxIcon.Warning;
            try
            {
                var obar = new BEArticle();
                if (!string.IsNullOrWhiteSpace(txtCOD_ARTI.Text))
                    obar.COD_ARTI = Convert.ToInt32(txtCOD_ARTI.Text);
                obar.ALF_CODI_ARTI = txtALF_CODI_ARTI.Text.Trim();
                obar.ALF_ARTI = txtALF_ARTI.Text.Trim();
                obar.ALF_DESC = mmeALF_DESC.Text.Trim();
                obar.COD_TIPO_ARTI = Convert.ToInt32(lkeCOD_TIPO_ARTI.EditValue);
                obar.COD_MODE_ARTI = Convert.ToInt32(lkeCOD_MODE_ARTI.EditValue);
                obar.NUM_STOC_MINI = Convert.ToInt32(txtNUM_STOC_MINI.Text);
                if (pteIMG_FOTO.Image != null)
                    obar.IMG_FOTO = ImageToByteArray(pteIMG_FOTO.Image);
                obar.IND_MNTN = 1;
                if (!string.IsNullOrWhiteSpace(txtCOD_ARTI.Text))
                    obar.IND_MNTN = 2;
                obar.COD_USUA_CREA = SESSION_USER;
                obar.COD_USUA_MODI = SESSION_USER;
                obar.COD_COMP = SESSION_COMP;

                var context = new ValidationContext(obar, null, null);
                var errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(obar, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        msgIcon = MessageBoxIcon.Warning;
                        throw new ArgumentException(result.ErrorMessage);
                    }
                }
                else
                {
                    var obr = new BRArticle();
                    obr.Set_PSWH_SPMT_SVMC_ARTI(obar);
                    if (!string.IsNullOrWhiteSpace(obar.MSG_MNTN))
                    {
                        msgIcon = MessageBoxIcon.Error;
                        throw new ArgumentException(obar.MSG_MNTN);
                    }
                    StateControls(true);
                    txtCOD_ARTI.Text = obar.COD_ARTI.ToString();
                    XtraMessageBox.Show(WhMessage.MsgSuccessfully, 
                                        WhMessage.MsgInsCaption,
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,
                                    WhMessage.MsgInsCaption,
                                    MessageBoxButtons.OK,
                                    msgIcon);
            }
        }

        private void StateControls(bool vState)
        {
            txtCOD_ARTI.Properties.ReadOnly = true;
            txtALF_CODI_ARTI.Properties.ReadOnly = vState;
            txtALF_ARTI.Properties.ReadOnly = vState;
            mmeALF_DESC.Properties.ReadOnly = vState;
            lkeCOD_TIPO_ARTI.Properties.ReadOnly = vState;
            lkeCOD_MODE_ARTI.Properties.ReadOnly = vState;
            txtNUM_STOC_MINI.Properties.ReadOnly = vState;
            pteIMG_FOTO.Properties.ReadOnly = vState;
        }

        private void ClearControls()
        {
            txtCOD_ARTI.Text = string.Empty;
            txtALF_CODI_ARTI.Text = string.Empty;
            txtALF_ARTI.Text = string.Empty;
            mmeALF_DESC.Text = string.Empty;
            lkeCOD_TIPO_ARTI.EditValue = null;
            lkeCOD_MODE_ARTI.EditValue = null;
            txtNUM_STOC_MINI.Text = "0";
            pteIMG_FOTO.Image = null;
        }

        public void Set_New()
        {
            ClearControls();
            StateControls(false);
            txtALF_CODI_ARTI.Focus();
        }

        public void Set_Edit()
        {
            //ClearControls();
            StateControls(false);
            txtALF_CODI_ARTI.Focus();
        }
        private void Set_Article(BEArticle arti)
        {
            ClearControls();
            txtCOD_ARTI.Text = Convert.ToString(arti.COD_ARTI);
            txtALF_CODI_ARTI.Text = arti.ALF_CODI_ARTI;
            txtALF_ARTI.Text = arti.ALF_ARTI;
            mmeALF_DESC.Text = arti.ALF_DESC;
            lkeCOD_TIPO_ARTI.EditValue = arti.COD_TIPO_ARTI;
            lkeCOD_MODE_ARTI.EditValue = arti.COD_MODE_ARTI;
            txtNUM_STOC_MINI.Text = Convert.ToString(arti.NUM_STOC_MINI);
            if (arti.IMG_FOTO != null)
                pteIMG_FOTO.Image = ByteArrayToImage(arti.IMG_FOTO);            
        }

        public void Undo()
        {
            ClearControls();
            StateControls(true);
        }

        public void Set_Search()
        {
            var ofx = new xfSearchArticle();
            if (ofx.ShowDialog() == DialogResult.OK)
                Set_Article(ofx.rowsel);
        }
        private void xfArticle_Load(object sender, EventArgs e)
        {
            SESSION_USER = ((xfMain)MdiParent).SESSION_USER;
            SESSION_PERF = ((xfMain)MdiParent).SESSION_PERF;
            SESSION_COMP = ((xfMain)MdiParent).SESSION_COMP;

            Get_Load();
        }
        private void xfArticle_Activated(object sender, EventArgs e)
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
        private void xfArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((xfMain)MdiParent).fra = null;

            SESSION_USER = null;
            SESSION_PERF = 0;
        }
        private void btelore_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                using (var osfl = new OpenFileDialog
                {
                    Title = WhMessage.MsgSelImage,
                    Filter = WhMessage.MsgFilImage,
                    ValidateNames = true
                })
                {
                    if (osfl.ShowDialog() != DialogResult.OK)
                        return;
                    pteIMG_FOTO.Image = Image.FromFile(osfl.FileName);
                } 
            }
            else
            {
                pteIMG_FOTO.Image = null;
            }
        }
        private void xfArticle_Deactivate(object sender, EventArgs e)
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