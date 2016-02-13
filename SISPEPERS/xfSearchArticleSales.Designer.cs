namespace SISPEPERS
{
    partial class xfSearchArticleSales
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtALF_CODI = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_REFE = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcResults = new DevExpress.XtraGrid.GridControl();
            this.gdvResults = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_CODI_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_TIPO_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_CODI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_REFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(868, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Size = new System.Drawing.Size(868, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(868, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sbSearch);
            this.panelControl1.Controls.Add(this.txtALF_CODI);
            this.panelControl1.Controls.Add(this.txtALF_REFE);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(868, 94);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Codigo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Referencia:";
            // 
            // sbSearch
            // 
            this.sbSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbSearch.Location = new System.Drawing.Point(781, 18);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(75, 23);
            this.sbSearch.TabIndex = 2;
            this.sbSearch.Text = "Buscar";
            this.sbSearch.Click += new System.EventHandler(this.sbSearch_Click);
            // 
            // txtALF_CODI
            // 
            this.txtALF_CODI.Location = new System.Drawing.Point(99, 47);
            this.txtALF_CODI.MenuManager = this.barManager1;
            this.txtALF_CODI.Name = "txtALF_CODI";
            this.txtALF_CODI.Size = new System.Drawing.Size(157, 22);
            this.txtALF_CODI.TabIndex = 1;
            // 
            // txtALF_REFE
            // 
            this.txtALF_REFE.Location = new System.Drawing.Point(99, 19);
            this.txtALF_REFE.MenuManager = this.barManager1;
            this.txtALF_REFE.Name = "txtALF_REFE";
            this.txtALF_REFE.Size = new System.Drawing.Size(676, 22);
            this.txtALF_REFE.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcResults);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 123);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(868, 372);
            this.panelControl2.TabIndex = 5;
            // 
            // gdcResults
            // 
            this.gdcResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResults.Location = new System.Drawing.Point(2, 2);
            this.gdcResults.MainView = this.gdvResults;
            this.gdcResults.MenuManager = this.barManager1;
            this.gdcResults.Name = "gdcResults";
            this.gdcResults.Size = new System.Drawing.Size(864, 368);
            this.gdcResults.TabIndex = 0;
            this.gdcResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResults});
            // 
            // gdvResults
            // 
            this.gdvResults.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_CODI_ARTI,
            this.gcALF_ARTI,
            this.gcALF_TIPO_ARTI});
            this.gdvResults.GridControl = this.gdcResults;
            this.gdvResults.GroupPanelText = "Resultados";
            this.gdvResults.Name = "gdvResults";
            this.gdvResults.OptionsView.ColumnAutoWidth = false;
            this.gdvResults.OptionsView.ShowFooter = true;
            this.gdvResults.DoubleClick += new System.EventHandler(this.gdvResults_DoubleClick);
            // 
            // gcALF_CODI_ARTI
            // 
            this.gcALF_CODI_ARTI.Caption = "Codigo";
            this.gcALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Name = "gcALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.OptionsColumn.AllowEdit = false;
            this.gcALF_CODI_ARTI.OptionsColumn.AllowFocus = false;
            this.gcALF_CODI_ARTI.OptionsColumn.ReadOnly = true;
            this.gcALF_CODI_ARTI.Visible = true;
            this.gcALF_CODI_ARTI.VisibleIndex = 0;
            this.gcALF_CODI_ARTI.Width = 100;
            // 
            // gcALF_ARTI
            // 
            this.gcALF_ARTI.Caption = "Articulo";
            this.gcALF_ARTI.FieldName = "ALF_ARTI";
            this.gcALF_ARTI.Name = "gcALF_ARTI";
            this.gcALF_ARTI.OptionsColumn.AllowEdit = false;
            this.gcALF_ARTI.OptionsColumn.AllowFocus = false;
            this.gcALF_ARTI.OptionsColumn.ReadOnly = true;
            this.gcALF_ARTI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_ARTI.Visible = true;
            this.gcALF_ARTI.VisibleIndex = 1;
            this.gcALF_ARTI.Width = 400;
            // 
            // gcALF_TIPO_ARTI
            // 
            this.gcALF_TIPO_ARTI.Caption = "Tipo";
            this.gcALF_TIPO_ARTI.FieldName = "ALF_TIPO_ARTI";
            this.gcALF_TIPO_ARTI.Name = "gcALF_TIPO_ARTI";
            this.gcALF_TIPO_ARTI.OptionsColumn.AllowEdit = false;
            this.gcALF_TIPO_ARTI.OptionsColumn.AllowFocus = false;
            this.gcALF_TIPO_ARTI.OptionsColumn.ReadOnly = true;
            this.gcALF_TIPO_ARTI.Visible = true;
            this.gcALF_TIPO_ARTI.VisibleIndex = 2;
            this.gcALF_TIPO_ARTI.Width = 200;
            // 
            // xfSearchArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfSearchArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar articulo";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_CODI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_REFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gdcResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResults;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraEditors.TextEdit txtALF_CODI;
        private DevExpress.XtraEditors.TextEdit txtALF_REFE;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_TIPO_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_CODI_ARTI;
    }
}