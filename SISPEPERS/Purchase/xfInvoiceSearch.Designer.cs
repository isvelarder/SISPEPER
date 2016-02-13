namespace SISPEPERS
{
    partial class xfInvoiceSearch
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtALF_DOCU_REFE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkeIND_ESTA = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dteFEC_REGI_FINA = new DevExpress.XtraEditors.DateEdit();
            this.dteFEC_REGI_INIC = new DevExpress.XtraEditors.DateEdit();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtALF_SOCI_NEGO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gdcSearch = new DevExpress.XtraGrid.GridControl();
            this.gdvSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_DOCU_REFE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_REGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_SOCI_NEGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_TOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiAccept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_DOCU_REFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeIND_ESTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_FINA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_FINA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_INIC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_INIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SOCI_NEGO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtALF_DOCU_REFE
            // 
            this.txtALF_DOCU_REFE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtALF_DOCU_REFE.Location = new System.Drawing.Point(338, 10);
            this.txtALF_DOCU_REFE.Name = "txtALF_DOCU_REFE";
            this.txtALF_DOCU_REFE.Size = new System.Drawing.Size(145, 20);
            this.txtALF_DOCU_REFE.TabIndex = 4;
            this.txtALF_DOCU_REFE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParameter_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Registro:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.lkeIND_ESTA);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dteFEC_REGI_FINA);
            this.panelControl1.Controls.Add(this.dteFEC_REGI_INIC);
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.txtALF_SOCI_NEGO);
            this.panelControl1.Controls.Add(this.txtALF_DOCU_REFE);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(569, 59);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Proveedor:";
            // 
            // lkeIND_ESTA
            // 
            this.lkeIND_ESTA.Location = new System.Drawing.Point(338, 32);
            this.lkeIND_ESTA.Name = "lkeIND_ESTA";
            this.lkeIND_ESTA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lkeIND_ESTA.Properties.Appearance.Options.UseBackColor = true;
            this.lkeIND_ESTA.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lkeIND_ESTA.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lkeIND_ESTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Limpiar", null, null, true)});
            this.lkeIND_ESTA.Properties.NullText = "";
            this.lkeIND_ESTA.Properties.NullValuePrompt = "[Seleccionar]";
            this.lkeIND_ESTA.Properties.NullValuePromptShowForEmptyValue = true;
            this.lkeIND_ESTA.Size = new System.Drawing.Size(145, 20);
            this.lkeIND_ESTA.TabIndex = 8;
            this.lkeIND_ESTA.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkeIND_ESTA_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(295, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Estado:";
            // 
            // dteFEC_REGI_FINA
            // 
            this.dteFEC_REGI_FINA.EditValue = null;
            this.dteFEC_REGI_FINA.Location = new System.Drawing.Point(173, 10);
            this.dteFEC_REGI_FINA.Name = "dteFEC_REGI_FINA";
            this.dteFEC_REGI_FINA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI_FINA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI_FINA.Size = new System.Drawing.Size(95, 20);
            this.dteFEC_REGI_FINA.TabIndex = 2;
            // 
            // dteFEC_REGI_INIC
            // 
            this.dteFEC_REGI_INIC.EditValue = null;
            this.dteFEC_REGI_INIC.Location = new System.Drawing.Point(72, 10);
            this.dteFEC_REGI_INIC.Name = "dteFEC_REGI_INIC";
            this.dteFEC_REGI_INIC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI_INIC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI_INIC.Size = new System.Drawing.Size(95, 20);
            this.dteFEC_REGI_INIC.TabIndex = 1;
            // 
            // sbtSearch
            // 
            this.sbtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbtSearch.Location = new System.Drawing.Point(489, 8);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(75, 23);
            this.sbtSearch.TabIndex = 9;
            this.sbtSearch.Text = "&Buscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // txtALF_SOCI_NEGO
            // 
            this.txtALF_SOCI_NEGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtALF_SOCI_NEGO.Location = new System.Drawing.Point(72, 32);
            this.txtALF_SOCI_NEGO.Name = "txtALF_SOCI_NEGO";
            this.txtALF_SOCI_NEGO.Size = new System.Drawing.Size(196, 20);
            this.txtALF_SOCI_NEGO.TabIndex = 6;
            this.txtALF_SOCI_NEGO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParameter_KeyUp);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(274, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Documento:";
            // 
            // gdcSearch
            // 
            this.gdcSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcSearch.Location = new System.Drawing.Point(0, 59);
            this.gdcSearch.MainView = this.gdvSearch;
            this.gdcSearch.Name = "gdcSearch";
            this.gdcSearch.Size = new System.Drawing.Size(569, 289);
            this.gdcSearch.TabIndex = 1;
            this.gdcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSearch});
            // 
            // gdvSearch
            // 
            this.gdvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_DOCU_REFE,
            this.gcFEC_REGI,
            this.gcALF_SOCI_NEGO,
            this.gcNUM_TOTA});
            this.gdvSearch.GridControl = this.gdcSearch;
            this.gdvSearch.Name = "gdvSearch";
            this.gdvSearch.OptionsBehavior.Editable = false;
            this.gdvSearch.OptionsBehavior.ReadOnly = true;
            this.gdvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvSearch.OptionsView.ShowGroupPanel = false;
            this.gdvSearch.DoubleClick += new System.EventHandler(this.gdvSearch_DoubleClick);
            // 
            // gcALF_DOCU_REFE
            // 
            this.gcALF_DOCU_REFE.Caption = "Documento";
            this.gcALF_DOCU_REFE.FieldName = "ALF_DOCU_REFE";
            this.gcALF_DOCU_REFE.Name = "gcALF_DOCU_REFE";
            this.gcALF_DOCU_REFE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcALF_DOCU_REFE.Visible = true;
            this.gcALF_DOCU_REFE.VisibleIndex = 0;
            this.gcALF_DOCU_REFE.Width = 80;
            // 
            // gcFEC_REGI
            // 
            this.gcFEC_REGI.Caption = "Registro";
            this.gcFEC_REGI.FieldName = "FEC_REGI";
            this.gcFEC_REGI.Name = "gcFEC_REGI";
            this.gcFEC_REGI.Visible = true;
            this.gcFEC_REGI.VisibleIndex = 1;
            this.gcFEC_REGI.Width = 96;
            // 
            // gcALF_SOCI_NEGO
            // 
            this.gcALF_SOCI_NEGO.Caption = "Proveedor";
            this.gcALF_SOCI_NEGO.FieldName = "ALF_SOCI_NEGO";
            this.gcALF_SOCI_NEGO.Name = "gcALF_SOCI_NEGO";
            this.gcALF_SOCI_NEGO.Visible = true;
            this.gcALF_SOCI_NEGO.VisibleIndex = 2;
            this.gcALF_SOCI_NEGO.Width = 279;
            // 
            // gcNUM_TOTA
            // 
            this.gcNUM_TOTA.Caption = "Total";
            this.gcNUM_TOTA.FieldName = "NUM_TOTA";
            this.gcNUM_TOTA.Name = "gcNUM_TOTA";
            this.gcNUM_TOTA.Visible = true;
            this.gcNUM_TOTA.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAccept,
            this.bbiCancel});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiAccept, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiAccept
            // 
            this.bbiAccept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAccept.Caption = "Aceptar";
            this.bbiAccept.Glyph = global::SISPEPERS.Properties.Resources.accept;
            this.bbiAccept.Id = 0;
            this.bbiAccept.Name = "bbiAccept";
            this.bbiAccept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAccept_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Cancelar";
            this.bbiCancel.Glyph = global::SISPEPERS.Properties.Resources.cancel;
            this.bbiCancel.Id = 1;
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(569, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 348);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(569, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 348);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(569, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 348);
            // 
            // xfInvoiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 375);
            this.Controls.Add(this.gdcSearch);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfInvoiceSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Facturas de Proveedores";
            this.Load += new System.EventHandler(this.xfInvoiceSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_DOCU_REFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeIND_ESTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_FINA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_FINA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_INIC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI_INIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SOCI_NEGO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtALF_DOCU_REFE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraGrid.GridControl gdcSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DOCU_REFE;
        private DevExpress.XtraEditors.DateEdit dteFEC_REGI_FINA;
        private DevExpress.XtraEditors.DateEdit dteFEC_REGI_INIC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkeIND_ESTA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_REGI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_SOCI_NEGO;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraEditors.TextEdit txtALF_SOCI_NEGO;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_TOTA;
    }
}