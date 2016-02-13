namespace SISPEPERS.Report
{
    partial class xfQuotePending
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
            this.sbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.deFEC_HAST = new DevExpress.XtraEditors.DateEdit();
            this.deFEC_DESD = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcResults = new DevExpress.XtraGrid.GridControl();
            this.gdvResults = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1243, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // sbSearch
            // 
            this.sbSearch.Image = global::SISPEPERS.Properties.Resources.eye;
            this.sbSearch.Location = new System.Drawing.Point(308, 11);
            this.sbSearch.Name = "sbSearch";
            this.sbSearch.Size = new System.Drawing.Size(75, 23);
            this.sbSearch.TabIndex = 7;
            this.sbSearch.Text = "Buscar";
            this.sbSearch.Click += new System.EventHandler(this.sbSearch_Click);
            // 
            // deFEC_HAST
            // 
            this.deFEC_HAST.EditValue = null;
            this.deFEC_HAST.Location = new System.Drawing.Point(202, 12);
            this.deFEC_HAST.Name = "deFEC_HAST";
            this.deFEC_HAST.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_HAST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_HAST.Size = new System.Drawing.Size(100, 22);
            this.deFEC_HAST.TabIndex = 5;
            // 
            // deFEC_DESD
            // 
            this.deFEC_DESD.EditValue = null;
            this.deFEC_DESD.Location = new System.Drawing.Point(53, 12);
            this.deFEC_DESD.Name = "deFEC_DESD";
            this.deFEC_DESD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deFEC_DESD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFEC_DESD.Size = new System.Drawing.Size(100, 22);
            this.deFEC_DESD.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(159, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Desde:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcResults);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1243, 635);
            this.panelControl2.TabIndex = 1;
            // 
            // gdcResults
            // 
            this.gdcResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResults.Location = new System.Drawing.Point(2, 2);
            this.gdcResults.MainView = this.gdvResults;
            this.gdcResults.Name = "gdcResults";
            this.gdcResults.Size = new System.Drawing.Size(1239, 631);
            this.gdcResults.TabIndex = 0;
            this.gdcResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResults});
            // 
            // gdvResults
            // 
            this.gdvResults.GridControl = this.gdcResults;
            this.gdvResults.GroupPanelText = "Registros encontrados";
            this.gdvResults.Name = "gdvResults";
            this.gdvResults.OptionsView.ColumnAutoWidth = false;
            this.gdvResults.OptionsView.ShowFooter = true;
            // 
            // xfQuotePending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 680);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "xfQuotePending";
            this.Text = "Cotizaciones pendientes de aprobación";
            this.Activated += new System.EventHandler(this.xfQuotePending_Activated);
            this.Deactivate += new System.EventHandler(this.xfQuotePending_Deactivate);
            this.Load += new System.EventHandler(this.xfQuotePending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_HAST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFEC_DESD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResults;
        private DevExpress.XtraEditors.SimpleButton sbSearch;
        private DevExpress.XtraEditors.DateEdit deFEC_HAST;
        private DevExpress.XtraEditors.DateEdit deFEC_DESD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}