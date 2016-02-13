namespace SISPEPERS.Warehouse
{
    partial class xfPriceList
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lsbPriceList = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rdgIND_TIPO_LIST = new DevExpress.XtraEditors.RadioGroup();
            this.txtCOD_LIST_PREC = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_LIST_PREC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdcDetail = new DevExpress.XtraGrid.GridControl();
            this.gdvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_CODI_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribALF_ARTI = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcALF_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_PREC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcNUM_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_MODE_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsbPriceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgIND_TIPO_LIST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_LIST_PREC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_LIST_PREC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribALF_ARTI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lsbPriceList);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gdcDetail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1541, 545);
            this.splitContainerControl1.SplitterPosition = 220;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lsbPriceList
            // 
            this.lsbPriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbPriceList.Location = new System.Drawing.Point(0, 105);
            this.lsbPriceList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbPriceList.Name = "lsbPriceList";
            this.lsbPriceList.Size = new System.Drawing.Size(220, 440);
            this.lsbPriceList.TabIndex = 1;
            this.lsbPriceList.SelectedIndexChanged += new System.EventHandler(this.lsbPriceList_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rdgIND_TIPO_LIST);
            this.panelControl1.Controls.Add(this.txtCOD_LIST_PREC);
            this.panelControl1.Controls.Add(this.txtALF_LIST_PREC);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(220, 105);
            this.panelControl1.TabIndex = 0;
            // 
            // rdgIND_TIPO_LIST
            // 
            this.rdgIND_TIPO_LIST.Location = new System.Drawing.Point(80, 65);
            this.rdgIND_TIPO_LIST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgIND_TIPO_LIST.Name = "rdgIND_TIPO_LIST";
            this.rdgIND_TIPO_LIST.Properties.Columns = 2;
            this.rdgIND_TIPO_LIST.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Ventas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Compras")});
            this.rdgIND_TIPO_LIST.Size = new System.Drawing.Size(170, 31);
            this.rdgIND_TIPO_LIST.TabIndex = 3;
            // 
            // txtCOD_LIST_PREC
            // 
            this.txtCOD_LIST_PREC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOD_LIST_PREC.Location = new System.Drawing.Point(80, 11);
            this.txtCOD_LIST_PREC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCOD_LIST_PREC.Name = "txtCOD_LIST_PREC";
            this.txtCOD_LIST_PREC.Properties.ReadOnly = true;
            this.txtCOD_LIST_PREC.Size = new System.Drawing.Size(170, 22);
            this.txtCOD_LIST_PREC.TabIndex = 2;
            // 
            // txtALF_LIST_PREC
            // 
            this.txtALF_LIST_PREC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtALF_LIST_PREC.Location = new System.Drawing.Point(80, 38);
            this.txtALF_LIST_PREC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtALF_LIST_PREC.Name = "txtALF_LIST_PREC";
            this.txtALF_LIST_PREC.Size = new System.Drawing.Size(170, 22);
            this.txtALF_LIST_PREC.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 73);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tipo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código:";
            // 
            // gdcDetail
            // 
            this.gdcDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcDetail.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gdcDetail.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gdcDetail.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(0, 6, "Adicionar"),
            new DevExpress.XtraEditors.NavigatorCustomButton(1, 7, "Quitar")});
            this.gdcDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gdcDetail.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gdcDetail.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gdcDetail_EmbeddedNavigator_ButtonClick);
            this.gdcDetail.Location = new System.Drawing.Point(0, 0);
            this.gdcDetail.MainView = this.gdvDetail;
            this.gdcDetail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gdcDetail.Name = "gdcDetail";
            this.gdcDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ribALF_ARTI,
            this.ritPrice});
            this.gdcDetail.Size = new System.Drawing.Size(1316, 545);
            this.gdcDetail.TabIndex = 1;
            this.gdcDetail.UseDisabledStatePainter = false;
            this.gdcDetail.UseEmbeddedNavigator = true;
            this.gdcDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetail});
            // 
            // gdvDetail
            // 
            this.gdvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_CODI_ARTI,
            this.gcALF_ARTI,
            this.gcALF_MODE_ARTI,
            this.gcNUM_PREC,
            this.gcNUM_DESC});
            this.gdvDetail.GridControl = this.gdcDetail;
            this.gdvDetail.GroupPanelText = "Arículos";
            this.gdvDetail.Name = "gdvDetail";
            this.gdvDetail.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gdvDetail.OptionsView.ShowAutoFilterRow = true;
            this.gdvDetail.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gdvDetail_RowCellStyle);
            this.gdvDetail.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gdvDetail_ShowingEditor);
            this.gdvDetail.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gdvDetail_CellValueChanging);
            // 
            // gcALF_CODI_ARTI
            // 
            this.gcALF_CODI_ARTI.Caption = "Código de Artículo";
            this.gcALF_CODI_ARTI.ColumnEdit = this.ribALF_ARTI;
            this.gcALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Name = "gcALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Visible = true;
            this.gcALF_CODI_ARTI.VisibleIndex = 0;
            this.gcALF_CODI_ARTI.Width = 232;
            // 
            // ribALF_ARTI
            // 
            this.ribALF_ARTI.AutoHeight = false;
            this.ribALF_ARTI.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Buscar Artículo", null, null, true)});
            this.ribALF_ARTI.Name = "ribALF_ARTI";
            this.ribALF_ARTI.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ribALF_ARTI.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ribALF_ARTI_ButtonClick);
            // 
            // gcALF_ARTI
            // 
            this.gcALF_ARTI.Caption = "Artículo";
            this.gcALF_ARTI.ColumnEdit = this.ribALF_ARTI;
            this.gcALF_ARTI.FieldName = "ALF_ARTI";
            this.gcALF_ARTI.Name = "gcALF_ARTI";
            this.gcALF_ARTI.Visible = true;
            this.gcALF_ARTI.VisibleIndex = 1;
            this.gcALF_ARTI.Width = 333;
            // 
            // gcNUM_PREC
            // 
            this.gcNUM_PREC.AppearanceCell.Options.UseTextOptions = true;
            this.gcNUM_PREC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcNUM_PREC.Caption = "Precio";
            this.gcNUM_PREC.ColumnEdit = this.ritPrice;
            this.gcNUM_PREC.FieldName = "NUM_PREC";
            this.gcNUM_PREC.Name = "gcNUM_PREC";
            this.gcNUM_PREC.Visible = true;
            this.gcNUM_PREC.VisibleIndex = 3;
            this.gcNUM_PREC.Width = 290;
            // 
            // ritPrice
            // 
            this.ritPrice.Appearance.Options.UseTextOptions = true;
            this.ritPrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ritPrice.AutoHeight = false;
            this.ritPrice.Mask.EditMask = "n2";
            this.ritPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ritPrice.Mask.UseMaskAsDisplayFormat = true;
            this.ritPrice.Name = "ritPrice";
            // 
            // gcNUM_DESC
            // 
            this.gcNUM_DESC.AppearanceCell.Options.UseTextOptions = true;
            this.gcNUM_DESC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcNUM_DESC.Caption = "Descuento";
            this.gcNUM_DESC.ColumnEdit = this.ritPrice;
            this.gcNUM_DESC.FieldName = "NUM_DESC";
            this.gcNUM_DESC.Name = "gcNUM_DESC";
            this.gcNUM_DESC.Visible = true;
            this.gcNUM_DESC.VisibleIndex = 4;
            this.gcNUM_DESC.Width = 293;
            // 
            // gcALF_MODE_ARTI
            // 
            this.gcALF_MODE_ARTI.Caption = "Línea";
            this.gcALF_MODE_ARTI.FieldName = "ALF_MODE_ARTI";
            this.gcALF_MODE_ARTI.Name = "gcALF_MODE_ARTI";
            this.gcALF_MODE_ARTI.Visible = true;
            this.gcALF_MODE_ARTI.VisibleIndex = 2;
            this.gcALF_MODE_ARTI.Width = 150;
            // 
            // xfPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 545);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xfPriceList";
            this.Text = "Lista de Precios";
            this.Activated += new System.EventHandler(this.xfPriceList_Activated);
            this.Deactivate += new System.EventHandler(this.xfPriceList_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfPriceList_FormClosing);
            this.Load += new System.EventHandler(this.xfPriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lsbPriceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgIND_TIPO_LIST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_LIST_PREC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_LIST_PREC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribALF_ARTI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ListBoxControl lsbPriceList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gdcDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCOD_LIST_PREC;
        private DevExpress.XtraEditors.TextEdit txtALF_LIST_PREC;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_CODI_ARTI;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ribALF_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_PREC;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_DESC;
        private DevExpress.XtraEditors.RadioGroup rdgIND_TIPO_LIST;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_MODE_ARTI;

    }
}