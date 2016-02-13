namespace SISPEPERS.Generics
{
    partial class xfBranch
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.meALF_DESC = new DevExpress.XtraEditors.MemoEdit();
            this.txtCOD_SUCU = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_SUCU = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcBranch = new DevExpress.XtraGrid.GridControl();
            this.gdvBranch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_SUCU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_SUCU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SUCU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.meALF_DESC);
            this.panelControl1.Controls.Add(this.txtCOD_SUCU);
            this.panelControl1.Controls.Add(this.txtALF_SUCU);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 157);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Codigo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Sucursal:";
            // 
            // meALF_DESC
            // 
            this.meALF_DESC.Location = new System.Drawing.Point(88, 71);
            this.meALF_DESC.Name = "meALF_DESC";
            this.meALF_DESC.Size = new System.Drawing.Size(448, 69);
            this.meALF_DESC.TabIndex = 1;
            this.meALF_DESC.UseOptimizedRendering = true;
            // 
            // txtCOD_SUCU
            // 
            this.txtCOD_SUCU.Location = new System.Drawing.Point(88, 15);
            this.txtCOD_SUCU.Name = "txtCOD_SUCU";
            this.txtCOD_SUCU.Properties.ReadOnly = true;
            this.txtCOD_SUCU.Size = new System.Drawing.Size(65, 22);
            this.txtCOD_SUCU.TabIndex = 0;
            // 
            // txtALF_SUCU
            // 
            this.txtALF_SUCU.Location = new System.Drawing.Point(88, 43);
            this.txtALF_SUCU.Name = "txtALF_SUCU";
            this.txtALF_SUCU.Size = new System.Drawing.Size(448, 22);
            this.txtALF_SUCU.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcBranch);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 157);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1025, 482);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcBranch
            // 
            this.gdcBranch.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcBranch.Location = new System.Drawing.Point(2, 2);
            this.gdcBranch.MainView = this.gdvBranch;
            this.gdcBranch.Name = "gdcBranch";
            this.gdcBranch.Size = new System.Drawing.Size(1021, 478);
            this.gdcBranch.TabIndex = 0;
            this.gdcBranch.UseDisabledStatePainter = false;
            this.gdcBranch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBranch});
            // 
            // gdvBranch
            // 
            this.gdvBranch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_SUCU,
            this.gcALF_DESC});
            this.gdvBranch.GridControl = this.gdcBranch;
            this.gdvBranch.GroupPanelText = "Sucursales";
            this.gdvBranch.Name = "gdvBranch";
            this.gdvBranch.OptionsView.ColumnAutoWidth = false;
            this.gdvBranch.OptionsView.ShowFooter = true;
            this.gdvBranch.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvBranch_RowClick);
            this.gdvBranch.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBranch_FocusedRowChanged);
            // 
            // gcALF_SUCU
            // 
            this.gcALF_SUCU.Caption = "Sucursal";
            this.gcALF_SUCU.FieldName = "ALF_SUCU";
            this.gcALF_SUCU.Name = "gcALF_SUCU";
            this.gcALF_SUCU.OptionsColumn.AllowEdit = false;
            this.gcALF_SUCU.OptionsColumn.AllowFocus = false;
            this.gcALF_SUCU.OptionsColumn.ReadOnly = true;
            this.gcALF_SUCU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_SUCU.Visible = true;
            this.gcALF_SUCU.VisibleIndex = 0;
            this.gcALF_SUCU.Width = 250;
            // 
            // gcALF_DESC
            // 
            this.gcALF_DESC.Caption = "Descripción";
            this.gcALF_DESC.FieldName = "ALF_DESC";
            this.gcALF_DESC.Name = "gcALF_DESC";
            this.gcALF_DESC.OptionsColumn.AllowEdit = false;
            this.gcALF_DESC.OptionsColumn.AllowFocus = false;
            this.gcALF_DESC.OptionsColumn.ReadOnly = true;
            this.gcALF_DESC.Visible = true;
            this.gcALF_DESC.VisibleIndex = 1;
            this.gcALF_DESC.Width = 400;
            // 
            // xfBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfBranch";
            this.Text = "Sucursales";
            this.Activated += new System.EventHandler(this.xfBranch_Activated);
            this.Deactivate += new System.EventHandler(this.xfBranch_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfBranch_FormClosing);
            this.Load += new System.EventHandler(this.xfBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_SUCU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_SUCU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit meALF_DESC;
        private DevExpress.XtraEditors.TextEdit txtALF_SUCU;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBranch;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_SUCU;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCOD_SUCU;
    }
}