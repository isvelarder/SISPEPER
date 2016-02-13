namespace SISPEPERS.Report
{
    partial class xfViewSalesOrder
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gdcResults = new DevExpress.XtraGrid.GridControl();
            this.gdvResults = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gdcResults01 = new DevExpress.XtraGrid.GridControl();
            this.gdvResults01 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults01)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(903, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Size = new System.Drawing.Size(903, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 615);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(903, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 615);
            // 
            // gdcResults
            // 
            this.gdcResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResults.Location = new System.Drawing.Point(2, 2);
            this.gdcResults.MainView = this.gdvResults;
            this.gdcResults.MenuManager = this.barManager1;
            this.gdcResults.Name = "gdcResults";
            this.gdcResults.Size = new System.Drawing.Size(899, 309);
            this.gdcResults.TabIndex = 4;
            this.gdcResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResults});
            // 
            // gdvResults
            // 
            this.gdvResults.GridControl = this.gdcResults;
            this.gdvResults.GroupPanelText = "Guias";
            this.gdvResults.Name = "gdvResults";
            this.gdvResults.OptionsView.ColumnAutoWidth = false;
            this.gdvResults.OptionsView.ShowFooter = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gdcResults);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 331);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(903, 313);
            this.panelControl1.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gdcResults01);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 29);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(903, 302);
            this.panelControl2.TabIndex = 10;
            // 
            // gdcResults01
            // 
            this.gdcResults01.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdcResults01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcResults01.Location = new System.Drawing.Point(2, 2);
            this.gdcResults01.MainView = this.gdvResults01;
            this.gdcResults01.MenuManager = this.barManager1;
            this.gdcResults01.Name = "gdcResults01";
            this.gdcResults01.Size = new System.Drawing.Size(899, 298);
            this.gdcResults01.TabIndex = 5;
            this.gdcResults01.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvResults01});
            // 
            // gdvResults01
            // 
            this.gdvResults01.GridControl = this.gdcResults01;
            this.gdvResults01.GroupPanelText = "Ordenes de venta";
            this.gdvResults01.Name = "gdvResults01";
            this.gdvResults01.OptionsView.ColumnAutoWidth = false;
            this.gdvResults01.OptionsView.ShowFooter = true;
            // 
            // xfViewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 667);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfViewSalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de venta aprobadas para facturar";
            this.Load += new System.EventHandler(this.xfViewSalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcResults01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvResults01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gdcResults;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResults;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gdcResults01;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvResults01;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}