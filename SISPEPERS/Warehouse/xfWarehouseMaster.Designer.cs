namespace SISPEPERS.Warehouse
{
    partial class xfWarehouseMaster
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
            this.meALF_DESC = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueCOD_SOCI_NEGO_ENCA = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCOD_ALMA = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_ALMA = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcWarehouse = new DevExpress.XtraGrid.GridControl();
            this.gdvWarehouse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_ALMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_NOMB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_SOCI_NEGO_ENCA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_ALMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_ALMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.meALF_DESC);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lueCOD_SOCI_NEGO_ENCA);
            this.panelControl1.Controls.Add(this.txtCOD_ALMA);
            this.panelControl1.Controls.Add(this.txtALF_ALMA);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1072, 202);
            this.panelControl1.TabIndex = 8;
            // 
            // meALF_DESC
            // 
            this.meALF_DESC.Location = new System.Drawing.Point(95, 102);
            this.meALF_DESC.Name = "meALF_DESC";
            this.meALF_DESC.Size = new System.Drawing.Size(621, 94);
            this.meALF_DESC.TabIndex = 7;
            this.meALF_DESC.UseOptimizedRendering = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Descripción:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Responsable:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(45, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 16);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Codigo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Almacén:";
            // 
            // lueCOD_SOCI_NEGO_ENCA
            // 
            this.lueCOD_SOCI_NEGO_ENCA.Location = new System.Drawing.Point(95, 73);
            this.lueCOD_SOCI_NEGO_ENCA.Name = "lueCOD_SOCI_NEGO_ENCA";
            this.lueCOD_SOCI_NEGO_ENCA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCOD_SOCI_NEGO_ENCA.Properties.NullText = "";
            this.lueCOD_SOCI_NEGO_ENCA.Properties.NullValuePrompt = "[Seleccionar]";
            this.lueCOD_SOCI_NEGO_ENCA.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueCOD_SOCI_NEGO_ENCA.Size = new System.Drawing.Size(621, 22);
            this.lueCOD_SOCI_NEGO_ENCA.TabIndex = 4;
            // 
            // txtCOD_ALMA
            // 
            this.txtCOD_ALMA.Location = new System.Drawing.Point(95, 17);
            this.txtCOD_ALMA.Name = "txtCOD_ALMA";
            this.txtCOD_ALMA.Properties.ReadOnly = true;
            this.txtCOD_ALMA.Size = new System.Drawing.Size(62, 22);
            this.txtCOD_ALMA.TabIndex = 1;
            // 
            // txtALF_ALMA
            // 
            this.txtALF_ALMA.Location = new System.Drawing.Point(95, 45);
            this.txtALF_ALMA.Name = "txtALF_ALMA";
            this.txtALF_ALMA.Size = new System.Drawing.Size(621, 22);
            this.txtALF_ALMA.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcWarehouse);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 202);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1072, 341);
            this.panelControl2.TabIndex = 9;
            // 
            // gdcWarehouse
            // 
            this.gdcWarehouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcWarehouse.Location = new System.Drawing.Point(2, 2);
            this.gdcWarehouse.MainView = this.gdvWarehouse;
            this.gdcWarehouse.Name = "gdcWarehouse";
            this.gdcWarehouse.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gdcWarehouse.Size = new System.Drawing.Size(1068, 337);
            this.gdcWarehouse.TabIndex = 0;
            this.gdcWarehouse.UseDisabledStatePainter = false;
            this.gdcWarehouse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvWarehouse});
            // 
            // gdvWarehouse
            // 
            this.gdvWarehouse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_ALMA,
            this.gcALF_NOMB,
            this.gcALF_DESC});
            this.gdvWarehouse.GridControl = this.gdcWarehouse;
            this.gdvWarehouse.GroupPanelText = "Almacenes registrados";
            this.gdvWarehouse.Name = "gdvWarehouse";
            this.gdvWarehouse.OptionsView.ColumnAutoWidth = false;
            this.gdvWarehouse.OptionsView.RowAutoHeight = true;
            this.gdvWarehouse.OptionsView.ShowFooter = true;
            this.gdvWarehouse.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvWarehouse_RowClick);
            this.gdvWarehouse.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvWarehouse_FocusedRowChanged);
            // 
            // gcALF_ALMA
            // 
            this.gcALF_ALMA.Caption = "Almacén";
            this.gcALF_ALMA.FieldName = "ALF_ALMA";
            this.gcALF_ALMA.Name = "gcALF_ALMA";
            this.gcALF_ALMA.OptionsColumn.AllowEdit = false;
            this.gcALF_ALMA.OptionsColumn.AllowFocus = false;
            this.gcALF_ALMA.OptionsColumn.ReadOnly = true;
            this.gcALF_ALMA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_ALMA.Visible = true;
            this.gcALF_ALMA.VisibleIndex = 0;
            this.gcALF_ALMA.Width = 350;
            // 
            // gcALF_NOMB
            // 
            this.gcALF_NOMB.Caption = "Responsable";
            this.gcALF_NOMB.FieldName = "ALF_NOMB";
            this.gcALF_NOMB.Name = "gcALF_NOMB";
            this.gcALF_NOMB.OptionsColumn.AllowEdit = false;
            this.gcALF_NOMB.OptionsColumn.AllowFocus = false;
            this.gcALF_NOMB.OptionsColumn.ReadOnly = true;
            this.gcALF_NOMB.Visible = true;
            this.gcALF_NOMB.VisibleIndex = 1;
            this.gcALF_NOMB.Width = 250;
            // 
            // gcALF_DESC
            // 
            this.gcALF_DESC.Caption = "Descripción";
            this.gcALF_DESC.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gcALF_DESC.FieldName = "ALF_DESC";
            this.gcALF_DESC.Name = "gcALF_DESC";
            this.gcALF_DESC.OptionsColumn.AllowEdit = false;
            this.gcALF_DESC.OptionsColumn.AllowFocus = false;
            this.gcALF_DESC.OptionsColumn.ReadOnly = true;
            this.gcALF_DESC.Visible = true;
            this.gcALF_DESC.VisibleIndex = 2;
            this.gcALF_DESC.Width = 350;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // xfWarehouseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 543);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfWarehouseMaster";
            this.Text = "Maestra de almacenes";
            this.Activated += new System.EventHandler(this.xfWarehouseMaster_Activated);
            this.Deactivate += new System.EventHandler(this.xfWarehouseMaster_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfWarehouseMaster_FormClosing);
            this.Load += new System.EventHandler(this.xfWarehouseMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_SOCI_NEGO_ENCA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_ALMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_ALMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueCOD_SOCI_NEGO_ENCA;
        private DevExpress.XtraEditors.TextEdit txtALF_ALMA;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ALMA;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_NOMB;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCOD_ALMA;
        private DevExpress.XtraEditors.MemoEdit meALF_DESC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}