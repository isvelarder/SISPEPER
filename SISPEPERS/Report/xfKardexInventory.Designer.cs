namespace SISPEPERS.Report
{
    partial class xfKardexInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfKardexInventory));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dteFEC_OPER_FINA = new DevExpress.XtraEditors.DateEdit();
            this.dteFEC_OPER_INIC = new DevExpress.XtraEditors.DateEdit();
            this.ccbCOD_ALMA = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdcKardex = new DevExpress.XtraGrid.GridControl();
            this.gdvKardex = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_ALMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_CODI_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_STOC_REAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCAN_MOVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_STOC_FINA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_OPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_COST_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_COST_VALO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIND_OPER_STOC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_FINA.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_FINA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_INIC.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_INIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbCOD_ALMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.dteFEC_OPER_FINA);
            this.panelControl1.Controls.Add(this.dteFEC_OPER_INIC);
            this.panelControl1.Controls.Add(this.ccbCOD_ALMA);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(708, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // sbtSearch
            // 
            this.sbtSearch.Image = ((System.Drawing.Image)(resources.GetObject("sbtSearch.Image")));
            this.sbtSearch.Location = new System.Drawing.Point(532, 12);
            this.sbtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(87, 28);
            this.sbtSearch.TabIndex = 4;
            this.sbtSearch.Text = "&Buscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // dteFEC_OPER_FINA
            // 
            this.dteFEC_OPER_FINA.EditValue = null;
            this.dteFEC_OPER_FINA.Location = new System.Drawing.Point(408, 15);
            this.dteFEC_OPER_FINA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFEC_OPER_FINA.Name = "dteFEC_OPER_FINA";
            this.dteFEC_OPER_FINA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_OPER_FINA.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_OPER_FINA.Size = new System.Drawing.Size(117, 22);
            this.dteFEC_OPER_FINA.TabIndex = 3;
            // 
            // dteFEC_OPER_INIC
            // 
            this.dteFEC_OPER_INIC.EditValue = null;
            this.dteFEC_OPER_INIC.Location = new System.Drawing.Point(285, 15);
            this.dteFEC_OPER_INIC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dteFEC_OPER_INIC.Name = "dteFEC_OPER_INIC";
            this.dteFEC_OPER_INIC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_OPER_INIC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_OPER_INIC.Size = new System.Drawing.Size(117, 22);
            this.dteFEC_OPER_INIC.TabIndex = 2;
            // 
            // ccbCOD_ALMA
            // 
            this.ccbCOD_ALMA.Location = new System.Drawing.Point(72, 15);
            this.ccbCOD_ALMA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccbCOD_ALMA.Name = "ccbCOD_ALMA";
            this.ccbCOD_ALMA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbCOD_ALMA.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ccbCOD_ALMA.Size = new System.Drawing.Size(160, 22);
            this.ccbCOD_ALMA.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControl2.Location = new System.Drawing.Point(239, 18);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Fecha:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Almacén:";
            // 
            // gdcKardex
            // 
            this.gdcKardex.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcKardex.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcKardex.Location = new System.Drawing.Point(0, 52);
            this.gdcKardex.MainView = this.gdvKardex;
            this.gdcKardex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcKardex.Name = "gdcKardex";
            this.gdcKardex.Size = new System.Drawing.Size(708, 417);
            this.gdcKardex.TabIndex = 1;
            this.gdcKardex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvKardex});
            // 
            // gdvKardex
            // 
            this.gdvKardex.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_ALMA,
            this.gcALF_CODI_ARTI,
            this.gcALF_ARTI,
            this.gcNUM_STOC_REAL,
            this.gcCAN_MOVI,
            this.gcNUM_STOC_FINA,
            this.gcFEC_OPER,
            this.gcNUM_COST_UNIT,
            this.gcNUM_COST_VALO,
            this.gcIND_OPER_STOC});
            this.gdvKardex.GridControl = this.gdcKardex;
            this.gdvKardex.GroupPanelText = "Lista de Artículos";
            this.gdvKardex.Name = "gdvKardex";
            this.gdvKardex.OptionsBehavior.ReadOnly = true;
            this.gdvKardex.OptionsCustomization.AllowSort = false;
            this.gdvKardex.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gdvKardex.OptionsView.ShowAutoFilterRow = true;
            this.gdvKardex.OptionsView.ShowFooter = true;
            this.gdvKardex.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gdvKardex_RowCellStyle);
            // 
            // gcALF_ALMA
            // 
            this.gcALF_ALMA.Caption = "Almacén";
            this.gcALF_ALMA.FieldName = "ALF_ALMA";
            this.gcALF_ALMA.Name = "gcALF_ALMA";
            this.gcALF_ALMA.Visible = true;
            this.gcALF_ALMA.VisibleIndex = 0;
            // 
            // gcALF_CODI_ARTI
            // 
            this.gcALF_CODI_ARTI.Caption = "Código de Artículo";
            this.gcALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Name = "gcALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Visible = true;
            this.gcALF_CODI_ARTI.VisibleIndex = 1;
            // 
            // gcALF_ARTI
            // 
            this.gcALF_ARTI.Caption = "Artículo";
            this.gcALF_ARTI.FieldName = "ALF_ARTI";
            this.gcALF_ARTI.Name = "gcALF_ARTI";
            this.gcALF_ARTI.Visible = true;
            this.gcALF_ARTI.VisibleIndex = 2;
            // 
            // gcNUM_STOC_REAL
            // 
            this.gcNUM_STOC_REAL.Caption = "Stock Inicial";
            this.gcNUM_STOC_REAL.FieldName = "NUM_STOC_REAL";
            this.gcNUM_STOC_REAL.Name = "gcNUM_STOC_REAL";
            this.gcNUM_STOC_REAL.Visible = true;
            this.gcNUM_STOC_REAL.VisibleIndex = 3;
            // 
            // gcCAN_MOVI
            // 
            this.gcCAN_MOVI.Caption = "Movimiento";
            this.gcCAN_MOVI.FieldName = "CAN_MOVI";
            this.gcCAN_MOVI.Name = "gcCAN_MOVI";
            this.gcCAN_MOVI.Visible = true;
            this.gcCAN_MOVI.VisibleIndex = 4;
            // 
            // gcNUM_STOC_FINA
            // 
            this.gcNUM_STOC_FINA.Caption = "Stock Final";
            this.gcNUM_STOC_FINA.FieldName = "NUM_STOC_FINA";
            this.gcNUM_STOC_FINA.Name = "gcNUM_STOC_FINA";
            this.gcNUM_STOC_FINA.Visible = true;
            this.gcNUM_STOC_FINA.VisibleIndex = 5;
            // 
            // gcFEC_OPER
            // 
            this.gcFEC_OPER.Caption = "Fecha";
            this.gcFEC_OPER.FieldName = "FEC_OPER";
            this.gcFEC_OPER.Name = "gcFEC_OPER";
            this.gcFEC_OPER.Visible = true;
            this.gcFEC_OPER.VisibleIndex = 6;
            // 
            // gcNUM_COST_UNIT
            // 
            this.gcNUM_COST_UNIT.Caption = "Costo Unitario";
            this.gcNUM_COST_UNIT.DisplayFormat.FormatString = "n2";
            this.gcNUM_COST_UNIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_COST_UNIT.FieldName = "NUM_COST_UNIT";
            this.gcNUM_COST_UNIT.Name = "gcNUM_COST_UNIT";
            this.gcNUM_COST_UNIT.Visible = true;
            this.gcNUM_COST_UNIT.VisibleIndex = 7;
            // 
            // gcNUM_COST_VALO
            // 
            this.gcNUM_COST_VALO.Caption = "Costo Valorizado";
            this.gcNUM_COST_VALO.DisplayFormat.FormatString = "n2";
            this.gcNUM_COST_VALO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcNUM_COST_VALO.FieldName = "NUM_COST_VALO";
            this.gcNUM_COST_VALO.Name = "gcNUM_COST_VALO";
            this.gcNUM_COST_VALO.Visible = true;
            this.gcNUM_COST_VALO.VisibleIndex = 8;
            // 
            // gcIND_OPER_STOC
            // 
            this.gcIND_OPER_STOC.Caption = "Operación";
            this.gcIND_OPER_STOC.FieldName = "IND_OPER_STOC";
            this.gcIND_OPER_STOC.Name = "gcIND_OPER_STOC";
            this.gcIND_OPER_STOC.Visible = true;
            this.gcIND_OPER_STOC.VisibleIndex = 9;
            // 
            // xfKardexInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 469);
            this.Controls.Add(this.gdcKardex);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xfKardexInventory";
            this.Text = "Kardex de Almacén";
            this.Activated += new System.EventHandler(this.xfKardexInventory_Activated);
            this.Deactivate += new System.EventHandler(this.xfKardexInventory_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfKardexInventory_FormClosing);
            this.Load += new System.EventHandler(this.xfKardexInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_FINA.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_FINA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_INIC.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_OPER_INIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbCOD_ALMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraEditors.DateEdit dteFEC_OPER_FINA;
        private DevExpress.XtraEditors.DateEdit dteFEC_OPER_INIC;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbCOD_ALMA;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gdcKardex;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvKardex;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ALMA;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_CODI_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_STOC_REAL;
        private DevExpress.XtraGrid.Columns.GridColumn gcCAN_MOVI;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_STOC_FINA;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_OPER;
        private DevExpress.XtraGrid.Columns.GridColumn gcIND_OPER_STOC;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_COST_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_COST_VALO;
    }
}