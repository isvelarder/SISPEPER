namespace SISPEPERS.Report
{
    partial class xfPurchase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfPurchase2));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteFEC_HAST = new DevExpress.XtraEditors.DateEdit();
            this.dteFEC_DESD = new DevExpress.XtraEditors.DateEdit();
            this.gdcReport = new DevExpress.XtraGrid.GridControl();
            this.gdvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_HAST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_HAST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_DESD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_DESD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dteFEC_HAST);
            this.panelControl1.Controls.Add(this.dteFEC_DESD);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(556, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // sbtSearch
            // 
            this.sbtSearch.Image = ((System.Drawing.Image)(resources.GetObject("sbtSearch.Image")));
            this.sbtSearch.Location = new System.Drawing.Point(321, 9);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(75, 23);
            this.sbtSearch.TabIndex = 3;
            this.sbtSearch.Text = "&Buscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha Documento:";
            // 
            // dteFEC_HAST
            // 
            this.dteFEC_HAST.EditValue = null;
            this.dteFEC_HAST.Location = new System.Drawing.Point(214, 11);
            this.dteFEC_HAST.Name = "dteFEC_HAST";
            this.dteFEC_HAST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_HAST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_HAST.Size = new System.Drawing.Size(100, 20);
            this.dteFEC_HAST.TabIndex = 2;
            this.dteFEC_HAST.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dteFEC_DESD_KeyUp);
            // 
            // dteFEC_DESD
            // 
            this.dteFEC_DESD.EditValue = null;
            this.dteFEC_DESD.Location = new System.Drawing.Point(108, 11);
            this.dteFEC_DESD.Name = "dteFEC_DESD";
            this.dteFEC_DESD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_DESD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFEC_DESD.Size = new System.Drawing.Size(100, 20);
            this.dteFEC_DESD.TabIndex = 1;
            this.dteFEC_DESD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dteFEC_DESD_KeyUp);
            // 
            // gdcReport
            // 
            this.gdcReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcReport.Location = new System.Drawing.Point(0, 41);
            this.gdcReport.MainView = this.gdvReport;
            this.gdcReport.Name = "gdcReport";
            this.gdcReport.Size = new System.Drawing.Size(556, 354);
            this.gdcReport.TabIndex = 1;
            this.gdcReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvReport});
            // 
            // gdvReport
            // 
            this.gdvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gdvReport.GridControl = this.gdcReport;
            this.gdvReport.Name = "gdvReport";
            this.gdvReport.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Documento";
            this.gridColumn1.FieldName = "FEC_DOCU";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nro. Documento";
            this.gridColumn2.FieldName = "ALF_NUME_DOCU";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ruc Proveedor";
            this.gridColumn3.FieldName = "ALF_NUM_RUCC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Proveedor";
            this.gridColumn4.FieldName = "ALF_SOCI_NEGO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Código Artículo";
            this.gridColumn5.FieldName = "ALF_CODI_ARTI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Artículo";
            this.gridColumn6.FieldName = "ALF_ARTI";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Importe";
            this.gridColumn7.FieldName = "NUM_IMPO";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // xfPurchase2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 395);
            this.Controls.Add(this.gdcReport);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfPurchase2";
            this.Text = "Registro de Compras Importadas ";
            this.Activated += new System.EventHandler(this.xfPurchase1_Activated);
            this.Deactivate += new System.EventHandler(this.xfPurchase1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfPurchase1_FormClosing);
            this.Load += new System.EventHandler(this.xfPurchase1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_HAST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_HAST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_DESD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFEC_DESD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dteFEC_HAST;
        private DevExpress.XtraEditors.DateEdit dteFEC_DESD;
        private DevExpress.XtraGrid.GridControl gdcReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}