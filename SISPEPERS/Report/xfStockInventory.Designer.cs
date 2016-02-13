namespace SISPEPERS.Report
{
    partial class xfStockInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfStockInventory));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.pgcStock = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pgfALF_ARTI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfALF_ALMA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfNUM_STOC_REAL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfNUM_STOC_MALO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfNUM_DISP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfNUM_MALO_DISP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pgfALF_CODI_ARTI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbeParameter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgcStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeParameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtRefresh);
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.txtValue);
            this.panelControl1.Controls.Add(this.cbeParameter);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // sbtRefresh
            // 
            this.sbtRefresh.Image = ((System.Drawing.Image)(resources.GetObject("sbtRefresh.Image")));
            this.sbtRefresh.Location = new System.Drawing.Point(524, 13);
            this.sbtRefresh.Name = "sbtRefresh";
            this.sbtRefresh.Size = new System.Drawing.Size(75, 23);
            this.sbtRefresh.TabIndex = 4;
            this.sbtRefresh.Text = "&Refrescar";
            this.sbtRefresh.Click += new System.EventHandler(this.sbtRefresh_Click);
            // 
            // pgcStock
            // 
            this.pgcStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgcStock.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pgfALF_ARTI,
            this.pgfALF_ALMA,
            this.pgfNUM_STOC_REAL,
            this.pgfNUM_STOC_MALO,
            this.pgfNUM_DISP,
            this.pgfNUM_MALO_DISP,
            this.pgfALF_CODI_ARTI});
            this.pgcStock.Location = new System.Drawing.Point(0, 48);
            this.pgcStock.Name = "pgcStock";
            this.pgcStock.OptionsView.ShowDataHeaders = false;
            this.pgcStock.OptionsView.ShowFilterHeaders = false;
            this.pgcStock.Size = new System.Drawing.Size(633, 384);
            this.pgcStock.TabIndex = 1;
            // 
            // pgfALF_ARTI
            // 
            this.pgfALF_ARTI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pgfALF_ARTI.AreaIndex = 1;
            this.pgfALF_ARTI.Caption = "Artículo";
            this.pgfALF_ARTI.FieldName = "ALF_ARTI";
            this.pgfALF_ARTI.Name = "pgfALF_ARTI";
            // 
            // pgfALF_ALMA
            // 
            this.pgfALF_ALMA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pgfALF_ALMA.AreaIndex = 0;
            this.pgfALF_ALMA.Caption = "Almacén";
            this.pgfALF_ALMA.FieldName = "ALF_ALMA";
            this.pgfALF_ALMA.Name = "pgfALF_ALMA";
            // 
            // pgfNUM_STOC_REAL
            // 
            this.pgfNUM_STOC_REAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfNUM_STOC_REAL.AreaIndex = 0;
            this.pgfNUM_STOC_REAL.Caption = "Stock";
            this.pgfNUM_STOC_REAL.FieldName = "NUM_STOC_REAL";
            this.pgfNUM_STOC_REAL.Name = "pgfNUM_STOC_REAL";
            // 
            // pgfNUM_STOC_MALO
            // 
            this.pgfNUM_STOC_MALO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfNUM_STOC_MALO.AreaIndex = 1;
            this.pgfNUM_STOC_MALO.Caption = "Stock Malo";
            this.pgfNUM_STOC_MALO.FieldName = "NUM_STOC_MALO";
            this.pgfNUM_STOC_MALO.Name = "pgfNUM_STOC_MALO";
            // 
            // pgfNUM_DISP
            // 
            this.pgfNUM_DISP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfNUM_DISP.AreaIndex = 2;
            this.pgfNUM_DISP.Caption = "Stock Disponible";
            this.pgfNUM_DISP.FieldName = "NUM_DISP";
            this.pgfNUM_DISP.Name = "pgfNUM_DISP";
            // 
            // pgfNUM_MALO_DISP
            // 
            this.pgfNUM_MALO_DISP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pgfNUM_MALO_DISP.AreaIndex = 3;
            this.pgfNUM_MALO_DISP.Caption = "Disponible Malo";
            this.pgfNUM_MALO_DISP.FieldName = "NUM_MALO_DISP";
            this.pgfNUM_MALO_DISP.Name = "pgfNUM_MALO_DISP";
            // 
            // pgfALF_CODI_ARTI
            // 
            this.pgfALF_CODI_ARTI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pgfALF_CODI_ARTI.AreaIndex = 0;
            this.pgfALF_CODI_ARTI.Caption = "Código";
            this.pgfALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.pgfALF_CODI_ARTI.Name = "pgfALF_CODI_ARTI";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Parametro:";
            // 
            // cbeParameter
            // 
            this.cbeParameter.EditValue = "Nombre Artículo";
            this.cbeParameter.Location = new System.Drawing.Point(72, 15);
            this.cbeParameter.Name = "cbeParameter";
            this.cbeParameter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeParameter.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.cbeParameter.Properties.Items.AddRange(new object[] {
            "Nombre Artículo",
            "Código Artículo",
            "Almacén"});
            this.cbeParameter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeParameter.Size = new System.Drawing.Size(116, 20);
            this.cbeParameter.TabIndex = 1;
            this.cbeParameter.SelectedIndexChanged += new System.EventHandler(this.cbeParameter_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(194, 15);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(248, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyUp);
            // 
            // sbtSearch
            // 
            this.sbtSearch.Image = ((System.Drawing.Image)(resources.GetObject("sbtSearch.Image")));
            this.sbtSearch.Location = new System.Drawing.Point(448, 13);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(70, 23);
            this.sbtSearch.TabIndex = 3;
            this.sbtSearch.Text = "&Búscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // xfStockInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 432);
            this.Controls.Add(this.pgcStock);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfStockInventory";
            this.Text = "Inventario de Stocks";
            this.Activated += new System.EventHandler(this.xfStockInventory_Activated);
            this.Deactivate += new System.EventHandler(this.xfStockInventory_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfStockInventory_FormClosing);
            this.Load += new System.EventHandler(this.xfStockInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgcStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeParameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtRefresh;
        private DevExpress.XtraPivotGrid.PivotGridControl pgcStock;
        private DevExpress.XtraPivotGrid.PivotGridField pgfALF_ARTI;
        private DevExpress.XtraPivotGrid.PivotGridField pgfALF_ALMA;
        private DevExpress.XtraPivotGrid.PivotGridField pgfNUM_STOC_REAL;
        private DevExpress.XtraPivotGrid.PivotGridField pgfNUM_STOC_MALO;
        private DevExpress.XtraPivotGrid.PivotGridField pgfNUM_DISP;
        private DevExpress.XtraPivotGrid.PivotGridField pgfNUM_MALO_DISP;
        private DevExpress.XtraPivotGrid.PivotGridField pgfALF_CODI_ARTI;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.ComboBoxEdit cbeParameter;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}