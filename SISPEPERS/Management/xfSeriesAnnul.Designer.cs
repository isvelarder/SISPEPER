namespace SISPEPERS.Management
{
    partial class xfSeriesAnnul
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lueCOD_TIPO_DOCU = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNUM_CORR = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_SERI = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcSeries = new DevExpress.XtraGrid.GridControl();
            this.gdvSeries = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_TIPO_DOCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_TIPO_DOCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_MONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_CORR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_TIPO_DOCU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNUM_CORR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SERI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lueCOD_TIPO_DOCU);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtNUM_CORR);
            this.panelControl1.Controls.Add(this.txtALF_SERI);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 108);
            this.panelControl1.TabIndex = 0;
            // 
            // lueCOD_TIPO_DOCU
            // 
            this.lueCOD_TIPO_DOCU.Location = new System.Drawing.Point(107, 17);
            this.lueCOD_TIPO_DOCU.Name = "lueCOD_TIPO_DOCU";
            this.lueCOD_TIPO_DOCU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCOD_TIPO_DOCU.Properties.NullText = "";
            this.lueCOD_TIPO_DOCU.Properties.NullValuePrompt = "[Seleccionar]";
            this.lueCOD_TIPO_DOCU.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueCOD_TIPO_DOCU.Size = new System.Drawing.Size(163, 22);
            this.lueCOD_TIPO_DOCU.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Correlativo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Documento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Serie:";
            // 
            // txtNUM_CORR
            // 
            this.txtNUM_CORR.Location = new System.Drawing.Point(107, 73);
            this.txtNUM_CORR.Name = "txtNUM_CORR";
            this.txtNUM_CORR.Size = new System.Drawing.Size(163, 22);
            this.txtNUM_CORR.TabIndex = 0;
            // 
            // txtALF_SERI
            // 
            this.txtALF_SERI.Location = new System.Drawing.Point(107, 45);
            this.txtALF_SERI.Name = "txtALF_SERI";
            this.txtALF_SERI.Size = new System.Drawing.Size(163, 22);
            this.txtALF_SERI.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcSeries);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 108);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1025, 531);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcSeries
            // 
            this.gdcSeries.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcSeries.Location = new System.Drawing.Point(2, 2);
            this.gdcSeries.MainView = this.gdvSeries;
            this.gdcSeries.Name = "gdcSeries";
            this.gdcSeries.Size = new System.Drawing.Size(1021, 527);
            this.gdcSeries.TabIndex = 0;
            this.gdcSeries.UseDisabledStatePainter = false;
            this.gdcSeries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSeries});
            // 
            // gdvSeries
            // 
            this.gdvSeries.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_TIPO_DOCU,
            this.gcCOD_TIPO_DOCU,
            this.gcALF_MONE,
            this.gcNUM_CORR});
            this.gdvSeries.GridControl = this.gdcSeries;
            this.gdvSeries.GroupPanelText = "Correlativos anulados";
            this.gdvSeries.Name = "gdvSeries";
            this.gdvSeries.OptionsView.ColumnAutoWidth = false;
            this.gdvSeries.OptionsView.ShowFooter = true;
            this.gdvSeries.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvBranch_RowClick);
            this.gdvSeries.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBranch_FocusedRowChanged);
            // 
            // gcALF_TIPO_DOCU
            // 
            this.gcALF_TIPO_DOCU.Caption = "Documento";
            this.gcALF_TIPO_DOCU.FieldName = "ALF_TIPO_DOCU";
            this.gcALF_TIPO_DOCU.Name = "gcALF_TIPO_DOCU";
            this.gcALF_TIPO_DOCU.OptionsColumn.AllowEdit = false;
            this.gcALF_TIPO_DOCU.OptionsColumn.AllowFocus = false;
            this.gcALF_TIPO_DOCU.OptionsColumn.ReadOnly = true;
            this.gcALF_TIPO_DOCU.Visible = true;
            this.gcALF_TIPO_DOCU.VisibleIndex = 0;
            this.gcALF_TIPO_DOCU.Width = 150;
            // 
            // gcCOD_TIPO_DOCU
            // 
            this.gcCOD_TIPO_DOCU.Caption = "COD_TIPO_DOCU";
            this.gcCOD_TIPO_DOCU.FieldName = "COD_TIPO_DOCU";
            this.gcCOD_TIPO_DOCU.Name = "gcCOD_TIPO_DOCU";
            this.gcCOD_TIPO_DOCU.Width = 150;
            // 
            // gcALF_MONE
            // 
            this.gcALF_MONE.Caption = "Serie";
            this.gcALF_MONE.FieldName = "ALF_SERI";
            this.gcALF_MONE.Name = "gcALF_MONE";
            this.gcALF_MONE.OptionsColumn.AllowEdit = false;
            this.gcALF_MONE.OptionsColumn.AllowFocus = false;
            this.gcALF_MONE.OptionsColumn.ReadOnly = true;
            this.gcALF_MONE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_MONE.Visible = true;
            this.gcALF_MONE.VisibleIndex = 1;
            this.gcALF_MONE.Width = 80;
            // 
            // gcNUM_CORR
            // 
            this.gcNUM_CORR.Caption = "Correlativo";
            this.gcNUM_CORR.FieldName = "NUM_CORR";
            this.gcNUM_CORR.Name = "gcNUM_CORR";
            this.gcNUM_CORR.OptionsColumn.AllowEdit = false;
            this.gcNUM_CORR.OptionsColumn.AllowFocus = false;
            this.gcNUM_CORR.OptionsColumn.ReadOnly = true;
            this.gcNUM_CORR.Visible = true;
            this.gcNUM_CORR.VisibleIndex = 2;
            this.gcNUM_CORR.Width = 100;
            // 
            // xfSeriesAnnul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfSeriesAnnul";
            this.Text = "Documentos anulados";
            this.Activated += new System.EventHandler(this.xfCurrency_Activated);
            this.Deactivate += new System.EventHandler(this.xfCurrency_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfCurrency_FormClosing);
            this.Load += new System.EventHandler(this.xfCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_TIPO_DOCU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNUM_CORR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SERI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtALF_SERI;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcSeries;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSeries;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_MONE;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_CORR;
        private DevExpress.XtraEditors.TextEdit txtNUM_CORR;
        private DevExpress.XtraEditors.LookUpEdit lueCOD_TIPO_DOCU;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_TIPO_DOCU;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_TIPO_DOCU;
    }
}