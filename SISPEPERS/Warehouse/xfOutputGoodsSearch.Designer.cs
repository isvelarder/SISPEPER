namespace SISPEPERS
{
    partial class xfOutputGoodsSearch
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtALF_DOCU_REFE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkeCOD_MOTI = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkeCOD_ALMA = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dteFEC_REGI = new DevExpress.XtraEditors.DateEdit();
            this.dteFEC_SALI = new DevExpress.XtraEditors.DateEdit();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gdcSearch = new DevExpress.XtraGrid.GridControl();
            this.gdvSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_DOCU_REFE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_SALI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_REGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ALMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiAccept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_DOCU_REFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCOD_MOTI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCOD_ALMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_SALI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_SALI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtALF_DOCU_REFE
            // 
            this.txtALF_DOCU_REFE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtALF_DOCU_REFE.Location = new System.Drawing.Point(394, 12);
            this.txtALF_DOCU_REFE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtALF_DOCU_REFE.Name = "txtALF_DOCU_REFE";
            this.txtALF_DOCU_REFE.Size = new System.Drawing.Size(169, 22);
            this.txtALF_DOCU_REFE.TabIndex = 4;
            this.txtALF_DOCU_REFE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParameter_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lkeCOD_MOTI);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.lkeCOD_ALMA);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dteFEC_REGI);
            this.panelControl1.Controls.Add(this.dteFEC_SALI);
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.txtALF_DOCU_REFE);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(664, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // lkeCOD_MOTI
            // 
            this.lkeCOD_MOTI.Location = new System.Drawing.Point(72, 39);
            this.lkeCOD_MOTI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkeCOD_MOTI.Name = "lkeCOD_MOTI";
            this.lkeCOD_MOTI.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lkeCOD_MOTI.Properties.Appearance.Options.UseBackColor = true;
            this.lkeCOD_MOTI.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lkeCOD_MOTI.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lkeCOD_MOTI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Limpiar", null, null, true)});
            this.lkeCOD_MOTI.Properties.NullText = "";
            this.lkeCOD_MOTI.Properties.NullValuePrompt = "[Seleccionar]";
            this.lkeCOD_MOTI.Properties.NullValuePromptShowForEmptyValue = true;
            this.lkeCOD_MOTI.Size = new System.Drawing.Size(240, 22);
            this.lkeCOD_MOTI.TabIndex = 6;
            this.lkeCOD_MOTI.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkeCOD_MOTI_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 43);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Motivo:";
            // 
            // lkeCOD_ALMA
            // 
            this.lkeCOD_ALMA.Location = new System.Drawing.Point(394, 39);
            this.lkeCOD_ALMA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkeCOD_ALMA.Name = "lkeCOD_ALMA";
            this.lkeCOD_ALMA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lkeCOD_ALMA.Properties.Appearance.Options.UseBackColor = true;
            this.lkeCOD_ALMA.Properties.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.lkeCOD_ALMA.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lkeCOD_ALMA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Limpiar", null, null, true)});
            this.lkeCOD_ALMA.Properties.NullText = "";
            this.lkeCOD_ALMA.Properties.NullValuePrompt = "[Seleccionar]";
            this.lkeCOD_ALMA.Properties.NullValuePromptShowForEmptyValue = true;
            this.lkeCOD_ALMA.Size = new System.Drawing.Size(169, 22);
            this.lkeCOD_ALMA.TabIndex = 8;
            this.lkeCOD_ALMA.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lkeCOD_ALMA_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(320, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Almacén:";
            // 
            // dteFEC_REGI
            // 
            this.dteFEC_REGI.EditValue = null;
            this.dteFEC_REGI.Location = new System.Drawing.Point(196, 12);
            this.dteFEC_REGI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFEC_REGI.Name = "dteFEC_REGI";
            this.dteFEC_REGI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_REGI.Properties.NullValuePrompt = "Registro";
            this.dteFEC_REGI.Properties.NullValuePromptShowForEmptyValue = true;
            this.dteFEC_REGI.Size = new System.Drawing.Size(117, 22);
            this.dteFEC_REGI.TabIndex = 2;
            // 
            // dteFEC_SALI
            // 
            this.dteFEC_SALI.EditValue = null;
            this.dteFEC_SALI.Location = new System.Drawing.Point(72, 12);
            this.dteFEC_SALI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFEC_SALI.Name = "dteFEC_SALI";
            this.dteFEC_SALI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_SALI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_SALI.Properties.NullValuePrompt = "Salida";
            this.dteFEC_SALI.Properties.NullValuePromptShowForEmptyValue = true;
            this.dteFEC_SALI.Size = new System.Drawing.Size(117, 22);
            this.dteFEC_SALI.TabIndex = 1;
            // 
            // sbtSearch
            // 
            this.sbtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbtSearch.Location = new System.Drawing.Point(570, 10);
            this.sbtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(87, 28);
            this.sbtSearch.TabIndex = 9;
            this.sbtSearch.Text = "&Buscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(320, 16);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Documento:";
            // 
            // gdcSearch
            // 
            this.gdcSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcSearch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcSearch.Location = new System.Drawing.Point(0, 102);
            this.gdcSearch.MainView = this.gdvSearch;
            this.gdcSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcSearch.Name = "gdcSearch";
            this.gdcSearch.Size = new System.Drawing.Size(664, 329);
            this.gdcSearch.TabIndex = 1;
            this.gdcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSearch});
            // 
            // gdvSearch
            // 
            this.gdvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_DOCU_REFE,
            this.gcFEC_SALI,
            this.gcFEC_REGI,
            this.gcALF_ALMA});
            this.gdvSearch.GridControl = this.gdcSearch;
            this.gdvSearch.Name = "gdvSearch";
            this.gdvSearch.OptionsBehavior.Editable = false;
            this.gdvSearch.OptionsBehavior.ReadOnly = true;
            this.gdvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvSearch.OptionsView.ShowGroupPanel = false;
            this.gdvSearch.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcFEC_SALI, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // gcFEC_SALI
            // 
            this.gcFEC_SALI.Caption = "Salida";
            this.gcFEC_SALI.FieldName = "FEC_SALI";
            this.gcFEC_SALI.Name = "gcFEC_SALI";
            this.gcFEC_SALI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcFEC_SALI.Visible = true;
            this.gcFEC_SALI.VisibleIndex = 1;
            this.gcFEC_SALI.Width = 96;
            // 
            // gcFEC_REGI
            // 
            this.gcFEC_REGI.Caption = "Registro";
            this.gcFEC_REGI.FieldName = "FEC_REGI";
            this.gcFEC_REGI.Name = "gcFEC_REGI";
            this.gcFEC_REGI.Visible = true;
            this.gcFEC_REGI.VisibleIndex = 2;
            this.gcFEC_REGI.Width = 96;
            // 
            // gcALF_ALMA
            // 
            this.gcALF_ALMA.Caption = "Almacén";
            this.gcALF_ALMA.FieldName = "ALF_ALMA";
            this.gcALF_ALMA.Name = "gcALF_ALMA";
            this.gcALF_ALMA.Visible = true;
            this.gcALF_ALMA.VisibleIndex = 3;
            this.gcALF_ALMA.Width = 279;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(664, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 431);
            this.barDockControlBottom.Size = new System.Drawing.Size(664, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(664, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
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
            // xfOutputGoodsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.gdcSearch);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfOutputGoodsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Salidas de Mercancía";
            this.Load += new System.EventHandler(this.xfEntryGoodsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_DOCU_REFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCOD_MOTI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeCOD_ALMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_REGI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_SALI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_SALI.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_SALI;
        private DevExpress.XtraEditors.DateEdit dteFEC_REGI;
        private DevExpress.XtraEditors.DateEdit dteFEC_SALI;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkeCOD_ALMA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkeCOD_MOTI;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_REGI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ALMA;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
    }
}