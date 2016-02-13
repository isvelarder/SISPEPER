namespace SISPEPERS.Purchase
{
    partial class xfExpNationalization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtOk = new DevExpress.XtraEditors.SimpleButton();
            this.gdcExpens = new DevExpress.XtraGrid.GridControl();
            this.gdvExpens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNUM_DOCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_DOCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_CONC_GANA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilConcept = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcALF_NOMB_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribCOD_SOCI_NEGO = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcALF_RUCC_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_MONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilCOD_MONE = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcNUM_MONT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcExpens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvExpens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilConcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCOD_SOCI_NEGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilCOD_MONE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtCancel);
            this.panelControl1.Controls.Add(this.sbtOk);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 340);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(791, 35);
            this.panelControl1.TabIndex = 3;
            // 
            // sbtCancel
            // 
            this.sbtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtCancel.Location = new System.Drawing.Point(704, 6);
            this.sbtCancel.Name = "sbtCancel";
            this.sbtCancel.Size = new System.Drawing.Size(75, 23);
            this.sbtCancel.TabIndex = 1;
            this.sbtCancel.Text = "&Cancelar";
            this.sbtCancel.Click += new System.EventHandler(this.sbtCancel_Click);
            // 
            // sbtOk
            // 
            this.sbtOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtOk.Location = new System.Drawing.Point(623, 6);
            this.sbtOk.Name = "sbtOk";
            this.sbtOk.Size = new System.Drawing.Size(75, 23);
            this.sbtOk.TabIndex = 0;
            this.sbtOk.Text = "&OK";
            this.sbtOk.Click += new System.EventHandler(this.sbtOk_Click);
            // 
            // gdcExpens
            // 
            this.gdcExpens.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcExpens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcExpens.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gdcExpens.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gdcExpens.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(0, 6, "Adicionar"),
            new DevExpress.XtraEditors.NavigatorCustomButton(1, 7, "Quitar")});
            this.gdcExpens.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gdcExpens.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gdcLines_EmbeddedNavigator_ButtonClick_1);
            this.gdcExpens.Location = new System.Drawing.Point(0, 0);
            this.gdcExpens.MainView = this.gdvExpens;
            this.gdcExpens.Name = "gdcExpens";
            this.gdcExpens.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ritAmount,
            this.rilConcept,
            this.rilCOD_MONE,
            this.ribCOD_SOCI_NEGO});
            this.gdcExpens.Size = new System.Drawing.Size(791, 340);
            this.gdcExpens.TabIndex = 4;
            this.gdcExpens.UseDisabledStatePainter = false;
            this.gdcExpens.UseEmbeddedNavigator = true;
            this.gdcExpens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvExpens});
            // 
            // gdvExpens
            // 
            this.gdvExpens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNUM_DOCU,
            this.gcFEC_DOCU,
            this.gcCOD_CONC_GANA,
            this.gcALF_NOMB_PROV,
            this.gcALF_RUCC_PROV,
            this.gcCOD_MONE,
            this.gcNUM_MONT});
            this.gdvExpens.GridControl = this.gdcExpens;
            this.gdvExpens.GroupPanelText = "Gastos";
            this.gdvExpens.Name = "gdvExpens";
            this.gdvExpens.OptionsCustomization.AllowColumnMoving = false;
            this.gdvExpens.OptionsCustomization.AllowFilter = false;
            this.gdvExpens.OptionsCustomization.AllowQuickHideColumns = false;
            this.gdvExpens.OptionsCustomization.AllowSort = false;
            this.gdvExpens.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gdvExpens.OptionsView.ShowFooter = true;
            // 
            // gcNUM_DOCU
            // 
            this.gcNUM_DOCU.Caption = "Nro. Documento";
            this.gcNUM_DOCU.FieldName = "NUM_DOCU";
            this.gcNUM_DOCU.Name = "gcNUM_DOCU";
            this.gcNUM_DOCU.Visible = true;
            this.gcNUM_DOCU.VisibleIndex = 0;
            this.gcNUM_DOCU.Width = 86;
            // 
            // gcFEC_DOCU
            // 
            this.gcFEC_DOCU.Caption = "Fecha";
            this.gcFEC_DOCU.FieldName = "FEC_DOCU";
            this.gcFEC_DOCU.Name = "gcFEC_DOCU";
            this.gcFEC_DOCU.Visible = true;
            this.gcFEC_DOCU.VisibleIndex = 1;
            this.gcFEC_DOCU.Width = 72;
            // 
            // gcCOD_CONC_GANA
            // 
            this.gcCOD_CONC_GANA.Caption = "Concepto";
            this.gcCOD_CONC_GANA.ColumnEdit = this.rilConcept;
            this.gcCOD_CONC_GANA.FieldName = "COD_CONC_GANA";
            this.gcCOD_CONC_GANA.Name = "gcCOD_CONC_GANA";
            this.gcCOD_CONC_GANA.Visible = true;
            this.gcCOD_CONC_GANA.VisibleIndex = 2;
            this.gcCOD_CONC_GANA.Width = 140;
            // 
            // rilConcept
            // 
            this.rilConcept.AutoHeight = false;
            this.rilConcept.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilConcept.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.rilConcept.Name = "rilConcept";
            // 
            // gcALF_NOMB_PROV
            // 
            this.gcALF_NOMB_PROV.Caption = "Proveedor";
            this.gcALF_NOMB_PROV.ColumnEdit = this.ribCOD_SOCI_NEGO;
            this.gcALF_NOMB_PROV.FieldName = "ALF_NOMB_PROV";
            this.gcALF_NOMB_PROV.Name = "gcALF_NOMB_PROV";
            this.gcALF_NOMB_PROV.Visible = true;
            this.gcALF_NOMB_PROV.VisibleIndex = 3;
            this.gcALF_NOMB_PROV.Width = 226;
            // 
            // ribCOD_SOCI_NEGO
            // 
            this.ribCOD_SOCI_NEGO.AutoHeight = false;
            this.ribCOD_SOCI_NEGO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Buscar Proveedor", null, null, true)});
            this.ribCOD_SOCI_NEGO.Name = "ribCOD_SOCI_NEGO";
            this.ribCOD_SOCI_NEGO.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribCOD_SOCI_NEGO_ButtonClick);
            // 
            // gcALF_RUCC_PROV
            // 
            this.gcALF_RUCC_PROV.Caption = "RUC";
            this.gcALF_RUCC_PROV.FieldName = "ALF_RUCC_PROV";
            this.gcALF_RUCC_PROV.Name = "gcALF_RUCC_PROV";
            this.gcALF_RUCC_PROV.Visible = true;
            this.gcALF_RUCC_PROV.VisibleIndex = 4;
            this.gcALF_RUCC_PROV.Width = 77;
            // 
            // gcCOD_MONE
            // 
            this.gcCOD_MONE.Caption = "Moneda";
            this.gcCOD_MONE.ColumnEdit = this.rilCOD_MONE;
            this.gcCOD_MONE.FieldName = "COD_MONE";
            this.gcCOD_MONE.Name = "gcCOD_MONE";
            this.gcCOD_MONE.Visible = true;
            this.gcCOD_MONE.VisibleIndex = 5;
            this.gcCOD_MONE.Width = 73;
            // 
            // rilCOD_MONE
            // 
            this.rilCOD_MONE.AutoHeight = false;
            this.rilCOD_MONE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilCOD_MONE.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.rilCOD_MONE.Name = "rilCOD_MONE";
            // 
            // gcNUM_MONT
            // 
            this.gcNUM_MONT.AppearanceCell.Options.UseTextOptions = true;
            this.gcNUM_MONT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcNUM_MONT.Caption = "Importe S/IGV";
            this.gcNUM_MONT.ColumnEdit = this.ritAmount;
            this.gcNUM_MONT.FieldName = "NUM_MONT";
            this.gcNUM_MONT.Name = "gcNUM_MONT";
            this.gcNUM_MONT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NUM_MONT", "{0:n2}")});
            this.gcNUM_MONT.Visible = true;
            this.gcNUM_MONT.VisibleIndex = 6;
            this.gcNUM_MONT.Width = 94;
            // 
            // ritAmount
            // 
            this.ritAmount.Appearance.Options.UseTextOptions = true;
            this.ritAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ritAmount.AutoHeight = false;
            this.ritAmount.Mask.EditMask = "n2";
            this.ritAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ritAmount.Mask.UseMaskAsDisplayFormat = true;
            this.ritAmount.Name = "ritAmount";
            // 
            // xfExpNationalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 375);
            this.Controls.Add(this.gdcExpens);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfExpNationalization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos de Nacionalización";
            this.Load += new System.EventHandler(this.xfExpNationalization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcExpens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvExpens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilConcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCOD_SOCI_NEGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilCOD_MONE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtCancel;
        private DevExpress.XtraEditors.SimpleButton sbtOk;
        private DevExpress.XtraGrid.GridControl gdcExpens;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvExpens;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_DOCU;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_DOCU;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_NOMB_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_RUCC_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_MONT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_CONC_GANA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilConcept;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_MONE;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilCOD_MONE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribCOD_SOCI_NEGO;

    }
}