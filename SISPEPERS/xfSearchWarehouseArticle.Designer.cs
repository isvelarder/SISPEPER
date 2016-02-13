namespace SISPEPERS
{
    partial class xfSearchWarehouseArticle
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
            this.txtParameter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sbtCancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtOk = new DevExpress.XtraEditors.SimpleButton();
            this.gdcSearch = new DevExpress.XtraGrid.GridControl();
            this.gdvSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_CODI_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_ARTI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtParameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParameter
            // 
            this.txtParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParameter.Location = new System.Drawing.Point(65, 10);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(363, 20);
            this.txtParameter.TabIndex = 1;
            this.txtParameter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParameter_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Parametro:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtSearch);
            this.panelControl1.Controls.Add(this.txtParameter);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(514, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // sbtSearch
            // 
            this.sbtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtSearch.Location = new System.Drawing.Point(434, 8);
            this.sbtSearch.Name = "sbtSearch";
            this.sbtSearch.Size = new System.Drawing.Size(75, 23);
            this.sbtSearch.TabIndex = 2;
            this.sbtSearch.Text = "&Buscar";
            this.sbtSearch.Click += new System.EventHandler(this.sbtSearch_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.sbtCancel);
            this.panelControl2.Controls.Add(this.sbtOk);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 305);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(514, 39);
            this.panelControl2.TabIndex = 2;
            // 
            // sbtCancel
            // 
            this.sbtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtCancel.Location = new System.Drawing.Point(434, 8);
            this.sbtCancel.Name = "sbtCancel";
            this.sbtCancel.Size = new System.Drawing.Size(75, 23);
            this.sbtCancel.TabIndex = 1;
            this.sbtCancel.Text = "&Cancelar";
            this.sbtCancel.Click += new System.EventHandler(this.sbtCancel_Click);
            // 
            // sbtOk
            // 
            this.sbtOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtOk.Location = new System.Drawing.Point(353, 8);
            this.sbtOk.Name = "sbtOk";
            this.sbtOk.Size = new System.Drawing.Size(75, 23);
            this.sbtOk.TabIndex = 0;
            this.sbtOk.Text = "&OK";
            this.sbtOk.Click += new System.EventHandler(this.sbtOk_Click);
            // 
            // gdcSearch
            // 
            this.gdcSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcSearch.Location = new System.Drawing.Point(0, 39);
            this.gdcSearch.MainView = this.gdvSearch;
            this.gdcSearch.Name = "gdcSearch";
            this.gdcSearch.Size = new System.Drawing.Size(514, 266);
            this.gdcSearch.TabIndex = 1;
            this.gdcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSearch});
            // 
            // gdvSearch
            // 
            this.gdvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_CODI_ARTI,
            this.gcALF_ARTI});
            this.gdvSearch.GridControl = this.gdcSearch;
            this.gdvSearch.Name = "gdvSearch";
            this.gdvSearch.OptionsBehavior.ReadOnly = true;
            this.gdvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvSearch.OptionsView.ShowGroupPanel = false;
            this.gdvSearch.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcALF_ARTI, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gdvSearch.DoubleClick += new System.EventHandler(this.gdvSearch_DoubleClick);
            // 
            // gcALF_CODI_ARTI
            // 
            this.gcALF_CODI_ARTI.Caption = "Código";
            this.gcALF_CODI_ARTI.FieldName = "ALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.Name = "gcALF_CODI_ARTI";
            this.gcALF_CODI_ARTI.OptionsColumn.AllowEdit = false;
            this.gcALF_CODI_ARTI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcALF_CODI_ARTI.Visible = true;
            this.gcALF_CODI_ARTI.VisibleIndex = 0;
            this.gcALF_CODI_ARTI.Width = 100;
            // 
            // gcALF_ARTI
            // 
            this.gcALF_ARTI.Caption = "Artículo";
            this.gcALF_ARTI.FieldName = "ALF_ARTI";
            this.gcALF_ARTI.Name = "gcALF_ARTI";
            this.gcALF_ARTI.OptionsColumn.AllowEdit = false;
            this.gcALF_ARTI.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gcALF_ARTI.Visible = true;
            this.gcALF_ARTI.VisibleIndex = 1;
            this.gcALF_ARTI.Width = 396;
            // 
            // xfSearchArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 344);
            this.Controls.Add(this.gdcSearch);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfSearchArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.txtParameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtParameter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtCancel;
        private DevExpress.XtraEditors.SimpleButton sbtOk;
        private DevExpress.XtraGrid.GridControl gdcSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_CODI_ARTI;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_ARTI;
    }
}