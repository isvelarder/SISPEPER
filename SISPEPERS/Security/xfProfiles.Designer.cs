namespace SISPEPERS.Seguridad
{
    partial class xfProfiles
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gdcProfile = new DevExpress.XtraGrid.GridControl();
            this.gdvProfile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_PERF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.meALF_DESC = new DevExpress.XtraEditors.MemoEdit();
            this.txtCOD_PERF = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_PERF = new DevExpress.XtraEditors.TextEdit();
            this.gdcMain = new DevExpress.XtraGrid.GridControl();
            this.gdvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_DESC_MAIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gdcOptions = new DevExpress.XtraGrid.GridControl();
            this.gdvOptions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcALF_OPCI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIND_MARC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcButtons = new DevExpress.XtraGrid.GridControl();
            this.gdvButtons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcIMG_BUTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcALF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcbIND_MARC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_PERF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PERF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl4);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1230, 575);
            this.splitContainerControl1.SplitterPosition = 242;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gdcProfile);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1230, 242);
            this.splitContainerControl2.SplitterPosition = 424;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gdcProfile
            // 
            this.gdcProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcProfile.Location = new System.Drawing.Point(0, 0);
            this.gdcProfile.MainView = this.gdvProfile;
            this.gdcProfile.Name = "gdcProfile";
            this.gdcProfile.Size = new System.Drawing.Size(424, 242);
            this.gdcProfile.TabIndex = 0;
            this.gdcProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvProfile});
            // 
            // gdvProfile
            // 
            this.gdvProfile.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_PERF});
            this.gdvProfile.GridControl = this.gdcProfile;
            this.gdvProfile.GroupPanelText = "Perfiles registrados";
            this.gdvProfile.Name = "gdvProfile";
            this.gdvProfile.OptionsView.ShowFooter = true;
            this.gdvProfile.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvProfile_RowClick);
            this.gdvProfile.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvProfile_FocusedRowChanged);
            // 
            // gcALF_PERF
            // 
            this.gcALF_PERF.Caption = "Perfil";
            this.gcALF_PERF.FieldName = "ALF_PERF";
            this.gcALF_PERF.Name = "gcALF_PERF";
            this.gcALF_PERF.OptionsColumn.AllowEdit = false;
            this.gcALF_PERF.OptionsColumn.AllowFocus = false;
            this.gcALF_PERF.OptionsColumn.ReadOnly = true;
            this.gcALF_PERF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_PERF.Visible = true;
            this.gcALF_PERF.VisibleIndex = 0;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl3.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl3.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl3.Panel1.Controls.Add(this.meALF_DESC);
            this.splitContainerControl3.Panel1.Controls.Add(this.txtCOD_PERF);
            this.splitContainerControl3.Panel1.Controls.Add(this.txtALF_PERF);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.gdcMain);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(801, 242);
            this.splitContainerControl3.SplitterPosition = 390;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Resumen";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Codigo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Perfil:";
            // 
            // meALF_DESC
            // 
            this.meALF_DESC.Location = new System.Drawing.Point(16, 88);
            this.meALF_DESC.Name = "meALF_DESC";
            this.meALF_DESC.Size = new System.Drawing.Size(361, 133);
            this.meALF_DESC.TabIndex = 1;
            this.meALF_DESC.UseOptimizedRendering = true;
            // 
            // txtCOD_PERF
            // 
            this.txtCOD_PERF.Location = new System.Drawing.Point(66, 12);
            this.txtCOD_PERF.Name = "txtCOD_PERF";
            this.txtCOD_PERF.Properties.ReadOnly = true;
            this.txtCOD_PERF.Size = new System.Drawing.Size(66, 22);
            this.txtCOD_PERF.TabIndex = 0;
            // 
            // txtALF_PERF
            // 
            this.txtALF_PERF.Location = new System.Drawing.Point(66, 38);
            this.txtALF_PERF.Name = "txtALF_PERF";
            this.txtALF_PERF.Size = new System.Drawing.Size(311, 22);
            this.txtALF_PERF.TabIndex = 0;
            // 
            // gdcMain
            // 
            this.gdcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcMain.Location = new System.Drawing.Point(0, 0);
            this.gdcMain.MainView = this.gdvMain;
            this.gdcMain.Name = "gdcMain";
            this.gdcMain.Size = new System.Drawing.Size(406, 242);
            this.gdcMain.TabIndex = 0;
            this.gdcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMain});
            // 
            // gdvMain
            // 
            this.gdvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_DESC_MAIN});
            this.gdvMain.GridControl = this.gdcMain;
            this.gdvMain.GroupPanelText = "Opciones principales";
            this.gdvMain.Name = "gdvMain";
            this.gdvMain.OptionsView.ShowFooter = true;
            this.gdvMain.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvMain_RowClick);
            this.gdvMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvMain_FocusedRowChanged);
            // 
            // gcALF_DESC_MAIN
            // 
            this.gcALF_DESC_MAIN.Caption = "Módulos principales";
            this.gcALF_DESC_MAIN.FieldName = "ALF_DESC";
            this.gcALF_DESC_MAIN.Name = "gcALF_DESC_MAIN";
            this.gcALF_DESC_MAIN.OptionsColumn.AllowEdit = false;
            this.gcALF_DESC_MAIN.OptionsColumn.AllowFocus = false;
            this.gcALF_DESC_MAIN.OptionsColumn.ReadOnly = true;
            this.gcALF_DESC_MAIN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_DESC_MAIN.Visible = true;
            this.gcALF_DESC_MAIN.VisibleIndex = 0;
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.Controls.Add(this.gdcOptions);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.Controls.Add(this.gdcButtons);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(1230, 328);
            this.splitContainerControl4.SplitterPosition = 612;
            this.splitContainerControl4.TabIndex = 0;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // gdcOptions
            // 
            this.gdcOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcOptions.Location = new System.Drawing.Point(0, 0);
            this.gdcOptions.MainView = this.gdvOptions;
            this.gdcOptions.Name = "gdcOptions";
            this.gdcOptions.Size = new System.Drawing.Size(612, 328);
            this.gdcOptions.TabIndex = 0;
            this.gdcOptions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvOptions});
            // 
            // gdvOptions
            // 
            this.gdvOptions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcALF_OPCI,
            this.gcIND_MARC});
            this.gdvOptions.GridControl = this.gdcOptions;
            this.gdvOptions.GroupPanelText = "Opciones disponibles";
            this.gdvOptions.Name = "gdvOptions";
            this.gdvOptions.OptionsView.ColumnAutoWidth = false;
            this.gdvOptions.OptionsView.ShowFooter = true;
            this.gdvOptions.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gdvOptions_RowClick);
            this.gdvOptions.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvOptions_FocusedRowChanged);
            // 
            // gcALF_OPCI
            // 
            this.gcALF_OPCI.Caption = "Opción";
            this.gcALF_OPCI.FieldName = "ALF_DESC";
            this.gcALF_OPCI.Name = "gcALF_OPCI";
            this.gcALF_OPCI.OptionsColumn.AllowEdit = false;
            this.gcALF_OPCI.OptionsColumn.AllowFocus = false;
            this.gcALF_OPCI.OptionsColumn.ReadOnly = true;
            this.gcALF_OPCI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcALF_OPCI.Visible = true;
            this.gcALF_OPCI.VisibleIndex = 0;
            this.gcALF_OPCI.Width = 300;
            // 
            // gcIND_MARC
            // 
            this.gcIND_MARC.Caption = "Activa";
            this.gcIND_MARC.FieldName = "IND_MARC";
            this.gcIND_MARC.Name = "gcIND_MARC";
            this.gcIND_MARC.Visible = true;
            this.gcIND_MARC.VisibleIndex = 1;
            this.gcIND_MARC.Width = 60;
            // 
            // gdcButtons
            // 
            this.gdcButtons.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcButtons.Location = new System.Drawing.Point(0, 0);
            this.gdcButtons.MainView = this.gdvButtons;
            this.gdcButtons.Name = "gdcButtons";
            this.gdcButtons.Size = new System.Drawing.Size(613, 328);
            this.gdcButtons.TabIndex = 0;
            this.gdcButtons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvButtons});
            // 
            // gdvButtons
            // 
            this.gdvButtons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcIMG_BUTT,
            this.gcALF_DESC,
            this.gcbIND_MARC});
            this.gdvButtons.GridControl = this.gdcButtons;
            this.gdvButtons.GroupPanelText = "Botones disponibles";
            this.gdvButtons.Name = "gdvButtons";
            this.gdvButtons.OptionsView.ColumnAutoWidth = false;
            this.gdvButtons.OptionsView.ShowFooter = true;
            // 
            // gcIMG_BUTT
            // 
            this.gcIMG_BUTT.Caption = "Boton";
            this.gcIMG_BUTT.FieldName = "IMG_BUTT";
            this.gcIMG_BUTT.Name = "gcIMG_BUTT";
            this.gcIMG_BUTT.OptionsColumn.AllowEdit = false;
            this.gcIMG_BUTT.OptionsColumn.AllowFocus = false;
            this.gcIMG_BUTT.OptionsColumn.ReadOnly = true;
            this.gcIMG_BUTT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.gcIMG_BUTT.Width = 50;
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
            this.gcALF_DESC.VisibleIndex = 0;
            this.gcALF_DESC.Width = 150;
            // 
            // gcbIND_MARC
            // 
            this.gcbIND_MARC.Caption = "Activo";
            this.gcbIND_MARC.FieldName = "IND_MARC";
            this.gcbIND_MARC.Name = "gcbIND_MARC";
            this.gcbIND_MARC.Visible = true;
            this.gcbIND_MARC.VisibleIndex = 1;
            this.gcbIND_MARC.Width = 70;
            // 
            // xfProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 575);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "xfProfiles";
            this.Text = "Perfiles";
            this.Activated += new System.EventHandler(this.xfProfiles_Activated);
            this.Deactivate += new System.EventHandler(this.xfProfiles_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfProfiles_FormClosing);
            this.Load += new System.EventHandler(this.xfProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meALF_DESC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCOD_PERF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PERF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvButtons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gdcProfile;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvProfile;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraGrid.GridControl gdcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvMain;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
        private DevExpress.XtraGrid.GridControl gdcOptions;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvOptions;
        private DevExpress.XtraGrid.GridControl gdcButtons;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvButtons;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit meALF_DESC;
        private DevExpress.XtraEditors.TextEdit txtALF_PERF;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_PERF;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC_MAIN;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_OPCI;
        private DevExpress.XtraGrid.Columns.GridColumn gcIND_MARC;
        private DevExpress.XtraGrid.Columns.GridColumn gcIMG_BUTT;
        private DevExpress.XtraGrid.Columns.GridColumn gcALF_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn gcbIND_MARC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCOD_PERF;
    }
}