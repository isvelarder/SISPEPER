namespace SISPEPERS.Warehouse
{
    partial class xfWarehouse
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
            this.sbtSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbtClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gdcGeneric = new DevExpress.XtraGrid.GridControl();
            this.gdvGeneric = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCOD_ALMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ALMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_SOCI_NEGO_ENCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilCOD_SOCI_NEGO_ENCA = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcGeneric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGeneric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilCOD_SOCI_NEGO_ENCA)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtSave
            // 
            this.sbtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtSave.Location = new System.Drawing.Point(474, 8);
            this.sbtSave.Name = "sbtSave";
            this.sbtSave.Size = new System.Drawing.Size(75, 23);
            this.sbtSave.TabIndex = 0;
            this.sbtSave.Text = "&Guardar";
            this.sbtSave.Click += new System.EventHandler(this.sbtSave_Click);
            // 
            // sbtClose
            // 
            this.sbtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtClose.Location = new System.Drawing.Point(556, 8);
            this.sbtClose.Name = "sbtClose";
            this.sbtClose.Size = new System.Drawing.Size(75, 23);
            this.sbtClose.TabIndex = 1;
            this.sbtClose.Text = "&Cerrar";
            this.sbtClose.Click += new System.EventHandler(this.sbtClose_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtClose);
            this.panelControl1.Controls.Add(this.sbtSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 341);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(636, 38);
            this.panelControl1.TabIndex = 1;
            // 
            // gdcGeneric
            // 
            this.gdcGeneric.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcGeneric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gdcGeneric.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(0, 6, "Adicionar"),
            new DevExpress.XtraEditors.NavigatorCustomButton(1, 7, "Quitar"),
            new DevExpress.XtraEditors.NavigatorCustomButton(2, 11, "Exportar")});
            this.gdcGeneric.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gdcGeneric.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gdcGeneric_EmbeddedNavigator_ButtonClick);
            this.gdcGeneric.Location = new System.Drawing.Point(0, 0);
            this.gdcGeneric.MainView = this.gdvGeneric;
            this.gdcGeneric.Name = "gdcGeneric";
            this.gdcGeneric.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilCOD_SOCI_NEGO_ENCA});
            this.gdcGeneric.Size = new System.Drawing.Size(636, 341);
            this.gdcGeneric.TabIndex = 0;
            this.gdcGeneric.UseEmbeddedNavigator = true;
            this.gdcGeneric.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvGeneric});
            // 
            // gdvGeneric
            // 
            this.gdvGeneric.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCOD_ALMA,
            this.gcALF_ALMA,
            this.gcALF_DESC,
            this.gcCOD_SOCI_NEGO_ENCA});
            this.gdvGeneric.GridControl = this.gdcGeneric;
            this.gdvGeneric.IndicatorWidth = 30;
            this.gdvGeneric.Name = "gdvGeneric";
            this.gdvGeneric.OptionsView.ShowGroupPanel = false;
            this.gdvGeneric.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gdvGeneric_CustomDrawRowIndicator);
            this.gdvGeneric.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gdvGeneric_RowCellStyle);
            this.gdvGeneric.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gdvGeneric_CellValueChanging);
            // 
            // gcCOD_ALMA
            // 
            this.gcCOD_ALMA.Caption = "Código";
            this.gcCOD_ALMA.FieldName = "COD_ALMA";
            this.gcCOD_ALMA.Name = "gcCOD_ALMA";
            this.gcCOD_ALMA.OptionsColumn.AllowEdit = false;
            this.gcCOD_ALMA.OptionsColumn.ReadOnly = true;
            this.gcCOD_ALMA.OptionsEditForm.StartNewRow = true;
            this.gcCOD_ALMA.Visible = true;
            this.gcCOD_ALMA.VisibleIndex = 0;
            this.gcCOD_ALMA.Width = 73;
            // 
            // gcALF_ALMA
            // 
            this.gcALF_ALMA.Caption = "Almacén";
            this.gcALF_ALMA.FieldName = "ALF_ALMA";
            this.gcALF_ALMA.Name = "gcALF_ALMA";
            this.gcALF_ALMA.Visible = true;
            this.gcALF_ALMA.VisibleIndex = 1;
            this.gcALF_ALMA.Width = 200;
            // 
            // gcALF_DESC
            // 
            this.gcALF_DESC.Caption = "Descripción";
            this.gcALF_DESC.FieldName = "ALF_DESC";
            this.gcALF_DESC.Name = "gcALF_DESC";
            this.gcALF_DESC.Visible = true;
            this.gcALF_DESC.VisibleIndex = 2;
            this.gcALF_DESC.Width = 150;
            // 
            // gcCOD_SOCI_NEGO_ENCA
            // 
            this.gcCOD_SOCI_NEGO_ENCA.Caption = "Encargado";
            this.gcCOD_SOCI_NEGO_ENCA.ColumnEdit = this.rilCOD_SOCI_NEGO_ENCA;
            this.gcCOD_SOCI_NEGO_ENCA.FieldName = "COD_SOCI_NEGO_ENCA";
            this.gcCOD_SOCI_NEGO_ENCA.Name = "gcCOD_SOCI_NEGO_ENCA";
            this.gcCOD_SOCI_NEGO_ENCA.Visible = true;
            this.gcCOD_SOCI_NEGO_ENCA.VisibleIndex = 3;
            this.gcCOD_SOCI_NEGO_ENCA.Width = 181;
            // 
            // rilCOD_SOCI_NEGO_ENCA
            // 
            this.rilCOD_SOCI_NEGO_ENCA.AutoHeight = false;
            this.rilCOD_SOCI_NEGO_ENCA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilCOD_SOCI_NEGO_ENCA.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.rilCOD_SOCI_NEGO_ENCA.Name = "rilCOD_SOCI_NEGO_ENCA";
            this.rilCOD_SOCI_NEGO_ENCA.NullText = "";
            // 
            // xfWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 379);
            this.Controls.Add(this.gdcGeneric);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacenes";
            this.Load += new System.EventHandler(this.xfTypeArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcGeneric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGeneric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilCOD_SOCI_NEGO_ENCA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtSave;
        private DevExpress.XtraEditors.SimpleButton sbtClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gdcGeneric;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvGeneric;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_ALMA;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ALMA;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_SOCI_NEGO_ENCA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilCOD_SOCI_NEGO_ENCA;

    }
}