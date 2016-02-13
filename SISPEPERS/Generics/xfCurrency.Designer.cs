namespace SISPEPERS.Generics
{
    partial class xfCurrency
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
            this.txtCOD_MONE = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_MONE = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcCurrency = new DevExpress.XtraGrid.GridControl();
            this.gdvCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_MONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtALF_MONE_SIMB = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MONE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MONE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MONE_SIMB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtCOD_MONE);
            this.panelControl1.Controls.Add(this.txtALF_MONE_SIMB);
            this.panelControl1.Controls.Add(this.txtALF_MONE);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 157);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Simbolo:";
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
            this.labelControl1.Location = new System.Drawing.Point(32, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Moneda:";
            // 
            // txtCOD_MONE
            // 
            this.txtCOD_MONE.Location = new System.Drawing.Point(88, 15);
            this.txtCOD_MONE.Name = "txtCOD_MONE";
            this.txtCOD_MONE.Properties.ReadOnly = true;
            this.txtCOD_MONE.Size = new System.Drawing.Size(65, 22);
            this.txtCOD_MONE.TabIndex = 0;
            // 
            // txtALF_MONE
            // 
            this.txtALF_MONE.Location = new System.Drawing.Point(88, 43);
            this.txtALF_MONE.Name = "txtALF_MONE";
            this.txtALF_MONE.Size = new System.Drawing.Size(163, 22);
            this.txtALF_MONE.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcCurrency);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 157);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1025, 482);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcCurrency
            // 
            this.gdcCurrency.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcCurrency.Location = new System.Drawing.Point(2, 2);
            this.gdcCurrency.MainView = this.gdvCurrency;
            this.gdcCurrency.Name = "gdcCurrency";
            this.gdcCurrency.Size = new System.Drawing.Size(1021, 478);
            this.gdcCurrency.TabIndex = 0;
            this.gdcCurrency.UseDisabledStatePainter = false;
            this.gdcCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCurrency});
            // 
            // gdvCurrency
            // 
            this.gdvCurrency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_MONE,
            this.gcALF_DESC});
            this.gdvCurrency.GridControl = this.gdcCurrency;
            this.gdvCurrency.GroupPanelText = "Sucursales";
            this.gdvCurrency.Name = "gdvCurrency";
            this.gdvCurrency.OptionsView.ColumnAutoWidth = false;
            this.gdvCurrency.OptionsView.ShowFooter = true;
            this.gdvCurrency.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvBranch_RowClick);
            this.gdvCurrency.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBranch_FocusedRowChanged);
            // 
            // gcALF_MONE
            // 
            this.gcALF_MONE.Caption = "Moneda";
            this.gcALF_MONE.FieldName = "ALF_MONE";
            this.gcALF_MONE.Name = "gcALF_MONE";
            this.gcALF_MONE.OptionsColumn.AllowEdit = false;
            this.gcALF_MONE.OptionsColumn.AllowFocus = false;
            this.gcALF_MONE.OptionsColumn.ReadOnly = true;
            this.gcALF_MONE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_MONE.Visible = true;
            this.gcALF_MONE.VisibleIndex = 0;
            this.gcALF_MONE.Width = 150;
            // 
            // gcALF_DESC
            // 
            this.gcALF_DESC.Caption = "Simbolo";
            this.gcALF_DESC.FieldName = "ALF_MONE_SIMB";
            this.gcALF_DESC.Name = "gcALF_DESC";
            this.gcALF_DESC.OptionsColumn.AllowEdit = false;
            this.gcALF_DESC.OptionsColumn.AllowFocus = false;
            this.gcALF_DESC.OptionsColumn.ReadOnly = true;
            this.gcALF_DESC.Visible = true;
            this.gcALF_DESC.VisibleIndex = 1;
            this.gcALF_DESC.Width = 80;
            // 
            // txtALF_MONE_SIMB
            // 
            this.txtALF_MONE_SIMB.Location = new System.Drawing.Point(88, 71);
            this.txtALF_MONE_SIMB.Name = "txtALF_MONE_SIMB";
            this.txtALF_MONE_SIMB.Size = new System.Drawing.Size(163, 22);
            this.txtALF_MONE_SIMB.TabIndex = 0;
            // 
            // xfCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfCurrency";
            this.Text = "Monedas";
            this.Activated += new System.EventHandler(this.xfCurrency_Activated);
            this.Deactivate += new System.EventHandler(this.xfCurrency_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfCurrency_FormClosing);
            this.Load += new System.EventHandler(this.xfCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MONE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MONE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MONE_SIMB.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtALF_MONE;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_MONE;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCOD_MONE;
        private DevExpress.XtraEditors.TextEdit txtALF_MONE_SIMB;
    }
}