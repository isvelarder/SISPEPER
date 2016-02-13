namespace SISPEPERS.Report
{
    partial class xfStockValued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfStockValued));
            this.gdcReport = new DevExpress.XtraGrid.GridControl();
            this.gdvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_CODI_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_STOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_COST_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_COST_VALO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_VENT_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_VENT_VALO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ccbCOD_ALMA = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbCOD_ALMA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcReport
            // 
            this.gdcReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcReport.Location = new System.Drawing.Point(0, 42);
            this.gdcReport.MainView = this.gdvReport;
            this.gdcReport.Name = "gdcReport";
            this.gdcReport.Size = new System.Drawing.Size(607, 339);
            this.gdcReport.TabIndex = 1;
            this.gdcReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvReport});
            // 
            // gdvReport
            // 
            this.gdvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_CODI_ARTI,
            this.gcALF_ARTI,
            this.gcNUM_STOC,
            this.gcNUM_COST_UNIT,
            this.gcNUM_COST_VALO,
            this.gcNUM_VENT_UNIT,
            this.gcNUM_VENT_VALO});
            this.gdvReport.GridControl = this.gdcReport;
            this.gdvReport.GroupPanelText = "Lista de Artículos";
            this.gdvReport.Name = "gdvReport";
            this.gdvReport.OptionsBehavior.ReadOnly = true;
            this.gdvReport.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gdvReport.OptionsView.ShowFooter = true;
            this.gdvReport.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gdvKardex_RowCellStyle);
            // 
            // gcALF_CODI_ARTI
            // 
            this.gcALF_CODI_ARTI.Caption = "Código de Artículo";
            this.gcALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Name = "gcALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_CODI_ARTI.Visible = true;
            this.gcALF_CODI_ARTI.VisibleIndex = 0;
            // 
            // gcALF_ARTI
            // 
            this.gcALF_ARTI.Caption = "Descripción Artículo";
            this.gcALF_ARTI.FieldName = "ALF_ARTI";
            this.gcALF_ARTI.Name = "gcALF_ARTI";
            this.gcALF_ARTI.Visible = true;
            this.gcALF_ARTI.VisibleIndex = 1;
            // 
            // gcNUM_STOC
            // 
            this.gcNUM_STOC.Caption = "Stock";
            this.gcNUM_STOC.FieldName = "NUM_STOC";
            this.gcNUM_STOC.Name = "gcNUM_STOC";
            this.gcNUM_STOC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gcNUM_STOC.Visible = true;
            this.gcNUM_STOC.VisibleIndex = 2;
            // 
            // gcNUM_COST_UNIT
            // 
            this.gcNUM_COST_UNIT.Caption = "Precio Costo Unitario";
            this.gcNUM_COST_UNIT.DisplayFormat.FormatString = "n2";
            this.gcNUM_COST_UNIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_COST_UNIT.FieldName = "NUM_COST_UNIT";
            this.gcNUM_COST_UNIT.Name = "gcNUM_COST_UNIT";
            this.gcNUM_COST_UNIT.Visible = true;
            this.gcNUM_COST_UNIT.VisibleIndex = 3;
            // 
            // gcNUM_COST_VALO
            // 
            this.gcNUM_COST_VALO.Caption = "Precio Costo Valorizado";
            this.gcNUM_COST_VALO.DisplayFormat.FormatString = "n2";
            this.gcNUM_COST_VALO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_COST_VALO.FieldName = "NUM_COST_VALO";
            this.gcNUM_COST_VALO.Name = "gcNUM_COST_VALO";
            this.gcNUM_COST_VALO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NUM_COST_VALO", "{0:n2}")});
            this.gcNUM_COST_VALO.Visible = true;
            this.gcNUM_COST_VALO.VisibleIndex = 4;
            // 
            // gcNUM_VENT_UNIT
            // 
            this.gcNUM_VENT_UNIT.Caption = "Precio Venta Unitario";
            this.gcNUM_VENT_UNIT.DisplayFormat.FormatString = "n2";
            this.gcNUM_VENT_UNIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_VENT_UNIT.FieldName = "NUM_VENT_UNIT";
            this.gcNUM_VENT_UNIT.Name = "gcNUM_VENT_UNIT";
            this.gcNUM_VENT_UNIT.Visible = true;
            this.gcNUM_VENT_UNIT.VisibleIndex = 5;
            // 
            // gcNUM_VENT_VALO
            // 
            this.gcNUM_VENT_VALO.Caption = "Precio Venta Valorizado";
            this.gcNUM_VENT_VALO.DisplayFormat.FormatString = "n2";
            this.gcNUM_VENT_VALO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_VENT_VALO.FieldName = "NUM_VENT_VALO";
            this.gcNUM_VENT_VALO.Name = "gcNUM_VENT_VALO";
            this.gcNUM_VENT_VALO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NUM_VENT_VALO", "{0:n2}")});
            this.gcNUM_VENT_VALO.Visible = true;
            this.gcNUM_VENT_VALO.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ccbCOD_ALMA);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(607, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // ccbCOD_ALMA
            // 
            this.ccbCOD_ALMA.Location = new System.Drawing.Point(56, 12);
            this.ccbCOD_ALMA.Name = "ccbCOD_ALMA";
            this.ccbCOD_ALMA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbCOD_ALMA.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ccbCOD_ALMA.Size = new System.Drawing.Size(218, 20);
            this.ccbCOD_ALMA.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Almacén:";
            // 
            // sbtSearch
            // 
            this.sbtSearch.Image = ((System.Drawing.Image)(resources.GetObject("sbtSearch.Image")));
            this.sbtSearch.Location = new System.Drawing.Point(280, 10);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(75, 23);
            this.sbtSearch.TabIndex = 2;
            this.sbtSearch.Text = "&Refrescar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // xfStockValued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 381);
            this.Controls.Add(this.gdcReport);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfStockValued";
            this.Text = "Stock Valorizado";
            this.Activated += new System.EventHandler(this.xfStockValued_Activated);
            this.Deactivate += new System.EventHandler(this.xfStockValued_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfStockValued_FormClosing);
            this.Load += new System.EventHandler(this.xfStockValued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbCOD_ALMA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReport;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_CODI_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_STOC;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_COST_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_COST_VALO;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_VENT_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_VENT_VALO;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbCOD_ALMA;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}