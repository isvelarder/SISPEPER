namespace SISPEPERS.Sales
{
    partial class xfSearchInvoice
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiAccept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.deFEC_HAST = new DevExpress.XtraEditors.DateEdit();
            this.deFEC_DESD = new DevExpress.XtraEditors.DateEdit();
            this.txtALF_NUME_IDEN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcResult = new DevExpress.XtraGrid.GridControl();
            this.gdvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_NUME_SUNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_DOCU_INIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_DOCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_NUME_IDEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResult)).BeginInit();
            this.SuspendLayout();
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
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1010, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Size = new System.Drawing.Size(1010, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1010, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbSearch);
            this.panelControl1.Controls.Add(this.deFEC_HAST);
            this.panelControl1.Controls.Add(this.deFEC_DESD);
            this.panelControl1.Controls.Add(this.txtALF_NUME_IDEN);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1010, 34);
            this.panelControl1.TabIndex = 4;
            // 
            // sbSearch
            // 
            this.sbSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbSearch.Location = new System.Drawing.Point(534, 5);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(75, 23);
            this.sbSearch.TabIndex = 8;
            this.sbSearch.Text = "Buscar";
            this.sbSearch.Click += new System.EventHandler(this.sbSearch_Click);
            // 
            // deFEC_HAST
            // 
            this.deFEC_HAST.EditValue = null;
            this.deFEC_HAST.Location = new System.Drawing.Point(417, 6);
            this.deFEC_HAST.MenuManager = this.barManager1;
            this.deFEC_HAST.Name = "deFEC_HAST";
            this.deFEC_HAST.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_HAST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Size = new System.Drawing.Size(100, 22);
            this.deFEC_HAST.TabIndex = 7;
            // 
            // deFEC_DESD
            // 
            this.deFEC_DESD.EditValue = null;
            this.deFEC_DESD.Location = new System.Drawing.Point(268, 6);
            this.deFEC_DESD.MenuManager = this.barManager1;
            this.deFEC_DESD.Name = "deFEC_DESD";
            this.deFEC_DESD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_DESD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Size = new System.Drawing.Size(100, 22);
            this.deFEC_DESD.TabIndex = 6;
            // 
            // txtALF_NUME_IDEN
            // 
            this.txtALF_NUME_IDEN.Location = new System.Drawing.Point(73, 6);
            this.txtALF_NUME_IDEN.MenuManager = this.barManager1;
            this.txtALF_NUME_IDEN.Name = "txtALF_NUME_IDEN";
            this.txtALF_NUME_IDEN.Properties.ReadOnly = true;
            this.txtALF_NUME_IDEN.Size = new System.Drawing.Size(143, 22);
            this.txtALF_NUME_IDEN.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(374, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Hasta:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(222, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Desde:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "RUC/DNI:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcResult);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 63);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1010, 403);
            this.panelControl2.TabIndex = 5;
            // 
            // gdcResult
            // 
            this.gdcResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResult.Location = new System.Drawing.Point(2, 2);
            this.gdcResult.MainView = this.gdvResult;
            this.gdcResult.MenuManager = this.barManager1;
            this.gdcResult.Name = "gdcResult";
            this.gdcResult.Size = new System.Drawing.Size(1006, 399);
            this.gdcResult.TabIndex = 0;
            this.gdcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResult});
            // 
            // gdvResult
            // 
            this.gdvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_NUME_SUNA,
            this.gcCOD_DOCU_INIC,
            this.gcCOD_DOCU,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.gdvResult.GridControl = this.gdcResult;
            this.gdvResult.GroupPanelText = "Cotizaciones ingresadas";
            this.gdvResult.Name = "gdvResult";
            this.gdvResult.OptionsView.ColumnAutoWidth = false;
            this.gdvResult.DoubleClick += new System.EventHandler(this.gdvResult_DoubleClick);
            // 
            // gcALF_NUME_SUNA
            // 
            this.gcALF_NUME_SUNA.Caption = "DOCUMENTO";
            this.gcALF_NUME_SUNA.FieldName = "ALF_NUME_SUNA";
            this.gcALF_NUME_SUNA.Name = "gcALF_NUME_SUNA";
            this.gcALF_NUME_SUNA.OptionsColumn.AllowEdit = false;
            this.gcALF_NUME_SUNA.OptionsColumn.AllowFocus = false;
            this.gcALF_NUME_SUNA.OptionsColumn.ReadOnly = true;
            this.gcALF_NUME_SUNA.Visible = true;
            this.gcALF_NUME_SUNA.VisibleIndex = 0;
            this.gcALF_NUME_SUNA.Width = 120;
            // 
            // gcCOD_DOCU_INIC
            // 
            this.gcCOD_DOCU_INIC.Caption = "O. Venta";
            this.gcCOD_DOCU_INIC.FieldName = "COD_OVEN";
            this.gcCOD_DOCU_INIC.Name = "gcCOD_DOCU_INIC";
            this.gcCOD_DOCU_INIC.OptionsColumn.AllowEdit = false;
            this.gcCOD_DOCU_INIC.OptionsColumn.AllowFocus = false;
            this.gcCOD_DOCU_INIC.OptionsColumn.ReadOnly = true;
            this.gcCOD_DOCU_INIC.Visible = true;
            this.gcCOD_DOCU_INIC.VisibleIndex = 1;
            this.gcCOD_DOCU_INIC.Width = 80;
            // 
            // gcCOD_DOCU
            // 
            this.gcCOD_DOCU.Caption = "Cotización";
            this.gcCOD_DOCU.FieldName = "COD_COTI";
            this.gcCOD_DOCU.Name = "gcCOD_DOCU";
            this.gcCOD_DOCU.OptionsColumn.AllowEdit = false;
            this.gcCOD_DOCU.OptionsColumn.AllowFocus = false;
            this.gcCOD_DOCU.OptionsColumn.ReadOnly = true;
            this.gcCOD_DOCU.Visible = true;
            this.gcCOD_DOCU.VisibleIndex = 2;
            this.gcCOD_DOCU.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.FieldName = "FEC_DOCU";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Vencimiento";
            this.gridColumn5.FieldName = "FEC_VENC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cliente";
            this.gridColumn3.FieldName = "ALF_NOMB";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 350;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Total";
            this.gridColumn4.FieldName = "NUM_TOTA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Estado";
            this.gridColumn6.FieldName = "ALF_ESTA";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 90;
            // 
            // xfSearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 497);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfSearchInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Factura";
            this.Load += new System.EventHandler(this.xfSearchInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_NUME_IDEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResult;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit deFEC_HAST;
        private DevExpress.XtraEditors.DateEdit deFEC_DESD;
        private DevExpress.XtraEditors.TextEdit txtALF_NUME_IDEN;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_DOCU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_NUME_SUNA;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_DOCU_INIC;
    }
}