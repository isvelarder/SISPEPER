namespace SISPEPERS.Report
{
    partial class xfQuoteIn
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcResults = new DevExpress.XtraGrid.GridControl();
            this.gdvResults = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCOD_COTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_COTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_VENC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_NOMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_SUCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_EJEC_COME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_PROY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_MONE_SIMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNUM_SUBT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOD_OVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_OVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFEC_ENTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ESTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deFEC_DESD = new DevExpress.XtraEditors.DateEdit();
            this.deFEC_HAST = new DevExpress.XtraEditors.DateEdit();
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbSearch);
            this.panelControl1.Controls.Add(this.deFEC_HAST);
            this.panelControl1.Controls.Add(this.deFEC_DESD);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1720, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcResults);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1720, 559);
            this.panelControl2.TabIndex = 2;
            // 
            // gdcResults
            // 
            this.gdcResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResults.Location = new System.Drawing.Point(2, 2);
            this.gdcResults.MainView = this.gdvResults;
            this.gdcResults.Name = "gdcResults";
            this.gdcResults.Size = new System.Drawing.Size(1716, 555);
            this.gdcResults.TabIndex = 0;
            this.gdcResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResults});
            // 
            // gdvResults
            // 
            this.gdvResults.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCOD_COTI,
            this.gcFEC_COTI,
            this.gcFEC_VENC,
            this.gcALF_NOMB,
            this.gcALF_SUCU,
            this.gcALF_EJEC_COME,
            this.gcALF_PROY,
            this.gcALF_MONE_SIMB,
            this.gcNUM_SUBT,
            this.gcCOD_OVEN,
            this.gcFEC_OVEN,
            this.gcFEC_ENTR,
            this.gcALF_ESTA});
            this.gdvResults.GridControl = this.gdcResults;
            this.gdvResults.GroupPanelText = "Cotizaciones ingresadas";
            this.gdvResults.Name = "gdvResults";
            this.gdvResults.OptionsView.ColumnAutoWidth = false;
            this.gdvResults.OptionsView.ShowFooter = true;
            // 
            // gcCOD_COTI
            // 
            this.gcCOD_COTI.Caption = "Cotización";
            this.gcCOD_COTI.FieldName = "COD_COTI";
            this.gcCOD_COTI.Name = "gcCOD_COTI";
            this.gcCOD_COTI.OptionsColumn.AllowEdit = false;
            this.gcCOD_COTI.OptionsColumn.AllowFocus = false;
            this.gcCOD_COTI.OptionsColumn.ReadOnly = true;
            this.gcCOD_COTI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcCOD_COTI.Visible = true;
            this.gcCOD_COTI.VisibleIndex = 0;
            this.gcCOD_COTI.Width = 80;
            // 
            // gcFEC_COTI
            // 
            this.gcFEC_COTI.Caption = "Fecha";
            this.gcFEC_COTI.FieldName = "FEC_COTI";
            this.gcFEC_COTI.Name = "gcFEC_COTI";
            this.gcFEC_COTI.OptionsColumn.AllowEdit = false;
            this.gcFEC_COTI.OptionsColumn.AllowFocus = false;
            this.gcFEC_COTI.OptionsColumn.ReadOnly = true;
            this.gcFEC_COTI.Visible = true;
            this.gcFEC_COTI.VisibleIndex = 1;
            this.gcFEC_COTI.Width = 90;
            // 
            // gcFEC_VENC
            // 
            this.gcFEC_VENC.Caption = "Vencimiento";
            this.gcFEC_VENC.FieldName = "FEC_VENC";
            this.gcFEC_VENC.Name = "gcFEC_VENC";
            this.gcFEC_VENC.OptionsColumn.AllowEdit = false;
            this.gcFEC_VENC.OptionsColumn.AllowFocus = false;
            this.gcFEC_VENC.OptionsColumn.ReadOnly = true;
            this.gcFEC_VENC.Visible = true;
            this.gcFEC_VENC.VisibleIndex = 2;
            this.gcFEC_VENC.Width = 90;
            // 
            // gcALF_NOMB
            // 
            this.gcALF_NOMB.Caption = "Cliente";
            this.gcALF_NOMB.FieldName = "ALF_NOMB";
            this.gcALF_NOMB.Name = "gcALF_NOMB";
            this.gcALF_NOMB.OptionsColumn.AllowEdit = false;
            this.gcALF_NOMB.OptionsColumn.AllowFocus = false;
            this.gcALF_NOMB.OptionsColumn.ReadOnly = true;
            this.gcALF_NOMB.Visible = true;
            this.gcALF_NOMB.VisibleIndex = 3;
            this.gcALF_NOMB.Width = 250;
            // 
            // gcALF_SUCU
            // 
            this.gcALF_SUCU.Caption = "Sucursal";
            this.gcALF_SUCU.FieldName = "ALF_SUCU";
            this.gcALF_SUCU.Name = "gcALF_SUCU";
            this.gcALF_SUCU.OptionsColumn.AllowEdit = false;
            this.gcALF_SUCU.OptionsColumn.AllowFocus = false;
            this.gcALF_SUCU.OptionsColumn.ReadOnly = true;
            this.gcALF_SUCU.Visible = true;
            this.gcALF_SUCU.VisibleIndex = 4;
            this.gcALF_SUCU.Width = 250;
            // 
            // gcALF_EJEC_COME
            // 
            this.gcALF_EJEC_COME.Caption = "Ejecutivo comercial";
            this.gcALF_EJEC_COME.FieldName = "ALF_EJEC_COME";
            this.gcALF_EJEC_COME.Name = "gcALF_EJEC_COME";
            this.gcALF_EJEC_COME.OptionsColumn.AllowEdit = false;
            this.gcALF_EJEC_COME.OptionsColumn.AllowFocus = false;
            this.gcALF_EJEC_COME.OptionsColumn.ReadOnly = true;
            this.gcALF_EJEC_COME.Visible = true;
            this.gcALF_EJEC_COME.VisibleIndex = 5;
            this.gcALF_EJEC_COME.Width = 250;
            // 
            // gcALF_PROY
            // 
            this.gcALF_PROY.Caption = "Proyecto";
            this.gcALF_PROY.FieldName = "ALF_PROY";
            this.gcALF_PROY.Name = "gcALF_PROY";
            this.gcALF_PROY.OptionsColumn.AllowEdit = false;
            this.gcALF_PROY.OptionsColumn.AllowFocus = false;
            this.gcALF_PROY.OptionsColumn.ReadOnly = true;
            this.gcALF_PROY.Visible = true;
            this.gcALF_PROY.VisibleIndex = 6;
            this.gcALF_PROY.Width = 150;
            // 
            // gcALF_MONE_SIMB
            // 
            this.gcALF_MONE_SIMB.Caption = "Moneda";
            this.gcALF_MONE_SIMB.FieldName = "ALF_MONE_SIMB";
            this.gcALF_MONE_SIMB.Name = "gcALF_MONE_SIMB";
            this.gcALF_MONE_SIMB.OptionsColumn.AllowEdit = false;
            this.gcALF_MONE_SIMB.OptionsColumn.AllowFocus = false;
            this.gcALF_MONE_SIMB.OptionsColumn.ReadOnly = true;
            this.gcALF_MONE_SIMB.Visible = true;
            this.gcALF_MONE_SIMB.VisibleIndex = 7;
            this.gcALF_MONE_SIMB.Width = 60;
            // 
            // gcNUM_SUBT
            // 
            this.gcNUM_SUBT.Caption = "Monto (Sin IGV)";
            this.gcNUM_SUBT.FieldName = "NUM_SUBT";
            this.gcNUM_SUBT.Name = "gcNUM_SUBT";
            this.gcNUM_SUBT.OptionsColumn.AllowEdit = false;
            this.gcNUM_SUBT.OptionsColumn.AllowFocus = false;
            this.gcNUM_SUBT.OptionsColumn.ReadOnly = true;
            this.gcNUM_SUBT.Visible = true;
            this.gcNUM_SUBT.VisibleIndex = 8;
            this.gcNUM_SUBT.Width = 100;
            // 
            // gcCOD_OVEN
            // 
            this.gcCOD_OVEN.Caption = "Orden venta";
            this.gcCOD_OVEN.FieldName = "COD_OVEN";
            this.gcCOD_OVEN.Name = "gcCOD_OVEN";
            this.gcCOD_OVEN.OptionsColumn.AllowEdit = false;
            this.gcCOD_OVEN.OptionsColumn.AllowFocus = false;
            this.gcCOD_OVEN.OptionsColumn.ReadOnly = true;
            this.gcCOD_OVEN.Visible = true;
            this.gcCOD_OVEN.VisibleIndex = 9;
            this.gcCOD_OVEN.Width = 100;
            // 
            // gcFEC_OVEN
            // 
            this.gcFEC_OVEN.Caption = "Fecha";
            this.gcFEC_OVEN.FieldName = "FEC_OVEN";
            this.gcFEC_OVEN.Name = "gcFEC_OVEN";
            this.gcFEC_OVEN.OptionsColumn.AllowEdit = false;
            this.gcFEC_OVEN.OptionsColumn.AllowFocus = false;
            this.gcFEC_OVEN.OptionsColumn.ReadOnly = true;
            this.gcFEC_OVEN.Visible = true;
            this.gcFEC_OVEN.VisibleIndex = 10;
            this.gcFEC_OVEN.Width = 90;
            // 
            // gcFEC_ENTR
            // 
            this.gcFEC_ENTR.Caption = "Entrega";
            this.gcFEC_ENTR.FieldName = "FEC_ENTR";
            this.gcFEC_ENTR.Name = "gcFEC_ENTR";
            this.gcFEC_ENTR.OptionsColumn.AllowEdit = false;
            this.gcFEC_ENTR.OptionsColumn.AllowFocus = false;
            this.gcFEC_ENTR.OptionsColumn.ReadOnly = true;
            this.gcFEC_ENTR.Visible = true;
            this.gcFEC_ENTR.VisibleIndex = 11;
            this.gcFEC_ENTR.Width = 90;
            // 
            // gcALF_ESTA
            // 
            this.gcALF_ESTA.Caption = "Estado";
            this.gcALF_ESTA.FieldName = "ALF_ESTA";
            this.gcALF_ESTA.Name = "gcALF_ESTA";
            this.gcALF_ESTA.OptionsColumn.AllowEdit = false;
            this.gcALF_ESTA.OptionsColumn.AllowFocus = false;
            this.gcALF_ESTA.OptionsColumn.ReadOnly = true;
            this.gcALF_ESTA.Visible = true;
            this.gcALF_ESTA.VisibleIndex = 12;
            this.gcALF_ESTA.Width = 150;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Desde:";
            // 
            // deFEC_DESD
            // 
            this.deFEC_DESD.EditValue = null;
            this.deFEC_DESD.Location = new System.Drawing.Point(59, 10);
            this.deFEC_DESD.Name = "deFEC_DESD";
            this.deFEC_DESD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_DESD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Size = new System.Drawing.Size(100, 22);
            this.deFEC_DESD.TabIndex = 1;
            // 
            // deFEC_HAST
            // 
            this.deFEC_HAST.EditValue = null;
            this.deFEC_HAST.Location = new System.Drawing.Point(208, 10);
            this.deFEC_HAST.Name = "deFEC_HAST";
            this.deFEC_HAST.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_HAST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Size = new System.Drawing.Size(100, 22);
            this.deFEC_HAST.TabIndex = 1;
            // 
            // sbSearch
            // 
            this.sbSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbSearch.Location = new System.Drawing.Point(314, 9);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(75, 23);
            this.sbSearch.TabIndex = 2;
            this.sbSearch.Text = "Buscar";
            this.sbSearch.Click += new System.EventHandler(this.sbSearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(165, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Hasta:";
            // 
            // xfQuoteIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 604);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfQuoteIn";
            this.Text = "Cotizaciones ingresadas por ejecutivo comercial";
            this.Activated += new System.EventHandler(this.xfQuoteIn_Activated);
            this.Deactivate += new System.EventHandler(this.xfQuoteIn_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfQuoteIn_FormClosing);
            this.Load += new System.EventHandler(this.xfQuoteIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResults;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_COTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_COTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_VENC;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_NOMB;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_EJEC_COME;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_MONE_SIMB;
        private DevExpress.XtraGrid.Columns.GridColumn gcNUM_SUBT;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOD_OVEN;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_OVEN;
        private DevExpress.XtraGrid.Columns.GridColumn gcFEC_ENTR;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_SUCU;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ESTA;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_PROY;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraEditors.DateEdit deFEC_HAST;
        private DevExpress.XtraEditors.DateEdit deFEC_DESD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}