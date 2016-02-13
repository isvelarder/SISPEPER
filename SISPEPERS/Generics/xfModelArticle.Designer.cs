namespace SISPEPERS.Generics
{
    partial class xfModelArticle
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
            this.txtCOD_MODE_ARTI = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_MODE_ARTI = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcModelArticle = new DevExpress.XtraGrid.GridControl();
            this.gdvModelArticle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_TIPO_CONT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MODE_ARTI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MODE_ARTI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcModelArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvModelArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.meALF_DESC);
            this.panelControl1.Controls.Add(this.txtCOD_MODE_ARTI);
            this.panelControl1.Controls.Add(this.txtALF_MODE_ARTI);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1025, 157);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(77, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Codigo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Modelo de artículo:";
            // 
            // meALF_DESC
            // 
            this.meALF_DESC.Location = new System.Drawing.Point(127, 71);
            this.meALF_DESC.Name = "meALF_DESC";
            this.meALF_DESC.Size = new System.Drawing.Size(448, 69);
            this.meALF_DESC.TabIndex = 1;
            this.meALF_DESC.UseOptimizedRendering = true;
            // 
            // txtCOD_MODE_ARTI
            // 
            this.txtCOD_MODE_ARTI.Location = new System.Drawing.Point(127, 15);
            this.txtCOD_MODE_ARTI.Name = "txtCOD_MODE_ARTI";
            this.txtCOD_MODE_ARTI.Properties.ReadOnly = true;
            this.txtCOD_MODE_ARTI.Size = new System.Drawing.Size(65, 22);
            this.txtCOD_MODE_ARTI.TabIndex = 0;
            // 
            // txtALF_MODE_ARTI
            // 
            this.txtALF_MODE_ARTI.Location = new System.Drawing.Point(127, 43);
            this.txtALF_MODE_ARTI.Name = "txtALF_MODE_ARTI";
            this.txtALF_MODE_ARTI.Size = new System.Drawing.Size(448, 22);
            this.txtALF_MODE_ARTI.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcModelArticle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 157);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1025, 482);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcModelArticle
            // 
            this.gdcModelArticle.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcModelArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcModelArticle.Location = new System.Drawing.Point(2, 2);
            this.gdcModelArticle.MainView = this.gdvModelArticle;
            this.gdcModelArticle.Name = "gdcModelArticle";
            this.gdcModelArticle.Size = new System.Drawing.Size(1021, 478);
            this.gdcModelArticle.TabIndex = 0;
            this.gdcModelArticle.UseDisabledStatePainter = false;
            this.gdcModelArticle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvModelArticle});
            // 
            // gdvModelArticle
            // 
            this.gdvModelArticle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_TIPO_CONT,
            this.gcALF_DESC});
            this.gdvModelArticle.GridControl = this.gdcModelArticle;
            this.gdvModelArticle.GroupPanelText = "Modelo de articulo";
            this.gdvModelArticle.Name = "gdvModelArticle";
            this.gdvModelArticle.OptionsView.ColumnAutoWidth = false;
            this.gdvModelArticle.OptionsView.ShowFooter = true;
            this.gdvModelArticle.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvTypeContact_RowClick);
            this.gdvModelArticle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvTypeContact_FocusedRowChanged);
            // 
            // gcALF_TIPO_CONT
            // 
            this.gcALF_TIPO_CONT.Caption = "Modelo de artículo";
            this.gcALF_TIPO_CONT.FieldName = "ALF_MODE_ARTI";
            this.gcALF_TIPO_CONT.Name = "gcALF_TIPO_CONT";
            this.gcALF_TIPO_CONT.OptionsColumn.AllowEdit = false;
            this.gcALF_TIPO_CONT.OptionsColumn.AllowFocus = false;
            this.gcALF_TIPO_CONT.OptionsColumn.ReadOnly = true;
            this.gcALF_TIPO_CONT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_TIPO_CONT.Visible = true;
            this.gcALF_TIPO_CONT.VisibleIndex = 0;
            this.gcALF_TIPO_CONT.Width = 250;
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
            // xfModelArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 639);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfModelArticle";
            this.Text = "Modelo de artículo";
            this.Activated += new System.EventHandler(this.xfModelArticle_Activated);
            this.Deactivate += new System.EventHandler(this.xfModelArticle_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfModelArticle_FormClosing);
            this.Load += new System.EventHandler(this.xfModelArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_MODE_ARTI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_MODE_ARTI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcModelArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvModelArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit meALF_DESC;
        private DevExpress.XtraEditors.TextEdit txtALF_MODE_ARTI;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcModelArticle;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvModelArticle;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_TIPO_CONT;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCOD_MODE_ARTI;
    }
}