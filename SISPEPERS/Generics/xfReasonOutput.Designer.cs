namespace SISPEPERS.Generics
{
    partial class xfReasonOutput
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCOD_MOTI = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_MOTI = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcReason = new DevExpress.XtraGrid.GridControl();
            this.gdvReason = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_MOTI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MOTI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MOTI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReason)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtCOD_MOTI);
            this.panelControl1.Controls.Add(this.txtALF_MOTI);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 79);
            this.panelControl1.TabIndex = 0;
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
            this.labelControl1.Location = new System.Drawing.Point(40, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Motivo:";
            // 
            // txtCOD_MOTI
            // 
            this.txtCOD_MOTI.Location = new System.Drawing.Point(88, 15);
            this.txtCOD_MOTI.Name = "txtCOD_MOTI";
            this.txtCOD_MOTI.Properties.ReadOnly = true;
            this.txtCOD_MOTI.Size = new System.Drawing.Size(65, 22);
            this.txtCOD_MOTI.TabIndex = 0;
            // 
            // txtALF_MOTI
            // 
            this.txtALF_MOTI.Location = new System.Drawing.Point(88, 43);
            this.txtALF_MOTI.Name = "txtALF_MOTI";
            this.txtALF_MOTI.Size = new System.Drawing.Size(448, 22);
            this.txtALF_MOTI.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcReason);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 79);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1025, 560);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcReason
            // 
            this.gdcReason.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcReason.Location = new System.Drawing.Point(2, 2);
            this.gdcReason.MainView = this.gdvReason;
            this.gdcReason.Name = "gdcReason";
            this.gdcReason.Size = new System.Drawing.Size(1021, 556);
            this.gdcReason.TabIndex = 0;
            this.gdcReason.UseDisabledStatePainter = false;
            this.gdcReason.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvReason});
            // 
            // gdvReason
            // 
            this.gdvReason.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_MOTI});
            this.gdvReason.GridControl = this.gdcReason;
            this.gdvReason.GroupPanelText = "Motivos de entrada";
            this.gdvReason.Name = "gdvReason";
            this.gdvReason.OptionsView.ColumnAutoWidth = false;
            this.gdvReason.OptionsView.ShowFooter = true;
            this.gdvReason.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvBranch_RowClick);
            this.gdvReason.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBranch_FocusedRowChanged);
            // 
            // gcALF_MOTI
            // 
            this.gcALF_MOTI.Caption = "Motivo";
            this.gcALF_MOTI.FieldName = "ALF_MOTI";
            this.gcALF_MOTI.Name = "gcALF_MOTI";
            this.gcALF_MOTI.OptionsColumn.AllowEdit = false;
            this.gcALF_MOTI.OptionsColumn.AllowFocus = false;
            this.gcALF_MOTI.OptionsColumn.ReadOnly = true;
            this.gcALF_MOTI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_MOTI.Visible = true;
            this.gcALF_MOTI.VisibleIndex = 0;
            this.gcALF_MOTI.Width = 250;
            // 
            // xfReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfReasonOutput";
            this.Text = "Motivos de salida para almacén";
            this.Activated += new System.EventHandler(this.xfReasonOutput_Activated);
            this.Deactivate += new System.EventHandler(this.xfReasonOutput_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfReasonOutput_FormClosing);
            this.Load += new System.EventHandler(this.xfReasonOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MOTI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MOTI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtALF_MOTI;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcReason;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReason;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_MOTI;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCOD_MOTI;
    }
}