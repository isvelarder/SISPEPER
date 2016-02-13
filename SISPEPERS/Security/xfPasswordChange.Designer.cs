namespace SISPEPERS.Security
{
    partial class xfPasswordChange
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
            this.bbiAccept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtALF_PASS_ACTU = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_PASS = new DevExpress.XtraEditors.TextEdit();
            this.txtALF_PASS_REPE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS_ACTU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS_REPE.Properties)).BeginInit();
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
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAccept,
            this.bbiCancel});
            this.barManager1.MaxItemId = 2;
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
            this.bar1.OptionsBar.RotateWhenVertical = false;
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
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiAccept, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiAccept
            // 
            this.bbiAccept.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAccept.Caption = "Aceptar";
            this.bbiAccept.Glyph = global::SISPEPERS.Properties.Resources.accept;
            this.bbiAccept.Id = 0;
            this.bbiAccept.Name = "bbiAccept";
            this.bbiAccept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAccept_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Cancelar";
            this.bbiCancel.Glyph = global::SISPEPERS.Properties.Resources.cancel;
            this.bbiCancel.Id = 1;
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(351, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 134);
            this.barDockControlBottom.Size = new System.Drawing.Size(351, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 105);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(351, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 105);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Contraseña anterior:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Contraseña nueva:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Repetir contraseña:";
            // 
            // txtALF_PASS_ACTU
            // 
            this.txtALF_PASS_ACTU.Location = new System.Drawing.Point(142, 46);
            this.txtALF_PASS_ACTU.MenuManager = this.barManager1;
            this.txtALF_PASS_ACTU.Name = "txtALF_PASS_ACTU";
            this.txtALF_PASS_ACTU.Properties.PasswordChar = '•';
            this.txtALF_PASS_ACTU.Size = new System.Drawing.Size(193, 22);
            this.txtALF_PASS_ACTU.TabIndex = 10;
            // 
            // txtALF_PASS
            // 
            this.txtALF_PASS.Location = new System.Drawing.Point(142, 74);
            this.txtALF_PASS.Name = "txtALF_PASS";
            this.txtALF_PASS.Properties.PasswordChar = '•';
            this.txtALF_PASS.Size = new System.Drawing.Size(193, 22);
            this.txtALF_PASS.TabIndex = 11;
            // 
            // txtALF_PASS_REPE
            // 
            this.txtALF_PASS_REPE.Location = new System.Drawing.Point(142, 102);
            this.txtALF_PASS_REPE.Name = "txtALF_PASS_REPE";
            this.txtALF_PASS_REPE.Properties.PasswordChar = '•';
            this.txtALF_PASS_REPE.Size = new System.Drawing.Size(193, 22);
            this.txtALF_PASS_REPE.TabIndex = 12;
            // 
            // xfPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 165);
            this.Controls.Add(this.txtALF_PASS_REPE);
            this.Controls.Add(this.txtALF_PASS);
            this.Controls.Add(this.txtALF_PASS_ACTU);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfPasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.Activated += new System.EventHandler(this.xfPasswordChange_Activated);
            this.Load += new System.EventHandler(this.xfPasswordChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS_ACTU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtALF_PASS_REPE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAccept;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraEditors.TextEdit txtALF_PASS_REPE;
        private DevExpress.XtraEditors.TextEdit txtALF_PASS;
        private DevExpress.XtraEditors.TextEdit txtALF_PASS_ACTU;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}