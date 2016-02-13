namespace SISPEPERS.Management
{
    partial class xfUbigeoDireccion
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
            this.luePopCOD_DEPA = new DevExpress.XtraEditors.LookUpEdit();
            this.luePopCOD_PROV = new DevExpress.XtraEditors.LookUpEdit();
            this.luePopCOD_DIST = new DevExpress.XtraEditors.LookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiAceptar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lueCOD_PAIS = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_DEPA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_PROV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_DIST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_PAIS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // luePopCOD_DEPA
            // 
            this.luePopCOD_DEPA.Location = new System.Drawing.Point(14, 99);
            this.luePopCOD_DEPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luePopCOD_DEPA.Name = "luePopCOD_DEPA";
            this.luePopCOD_DEPA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePopCOD_DEPA.Properties.NullText = "[Seleccionar]";
            this.luePopCOD_DEPA.Size = new System.Drawing.Size(265, 22);
            this.luePopCOD_DEPA.TabIndex = 1;
            this.luePopCOD_DEPA.EditValueChanged += new System.EventHandler(this.luePopCOD_DEPA_EditValueChanged);
            // 
            // luePopCOD_PROV
            // 
            this.luePopCOD_PROV.Location = new System.Drawing.Point(286, 99);
            this.luePopCOD_PROV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luePopCOD_PROV.Name = "luePopCOD_PROV";
            this.luePopCOD_PROV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePopCOD_PROV.Properties.NullText = "[Seleccionar]";
            this.luePopCOD_PROV.Size = new System.Drawing.Size(265, 22);
            this.luePopCOD_PROV.TabIndex = 2;
            this.luePopCOD_PROV.EditValueChanged += new System.EventHandler(this.luePopCOD_PROV_EditValueChanged);
            // 
            // luePopCOD_DIST
            // 
            this.luePopCOD_DIST.Location = new System.Drawing.Point(558, 99);
            this.luePopCOD_DIST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luePopCOD_DIST.Name = "luePopCOD_DIST";
            this.luePopCOD_DIST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePopCOD_DIST.Properties.NullText = "[Seleccionar]";
            this.luePopCOD_DIST.Size = new System.Drawing.Size(265, 22);
            this.luePopCOD_DIST.TabIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAceptar,
            this.bbiCancelar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiAceptar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiAceptar
            // 
            this.bbiAceptar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAceptar.Caption = "Aceptar";
            this.bbiAceptar.Glyph = global::SISPEPERS.Properties.Resources.accept;
            this.bbiAceptar.Id = 0;
            this.bbiAceptar.Name = "bbiAceptar";
            this.bbiAceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAceptar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Glyph = global::SISPEPERS.Properties.Resources.cancel;
            this.bbiCancelar.Id = 1;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(834, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 138);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(834, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 118);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(834, 20);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 118);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 78);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Departamento";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(286, 78);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Provincia";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(558, 78);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Distrito";
            // 
            // lueCOD_PAIS
            // 
            this.lueCOD_PAIS.Location = new System.Drawing.Point(14, 49);
            this.lueCOD_PAIS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lueCOD_PAIS.Name = "lueCOD_PAIS";
            this.lueCOD_PAIS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCOD_PAIS.Properties.NullText = "[Seleccionar]";
            this.lueCOD_PAIS.Size = new System.Drawing.Size(265, 22);
            this.lueCOD_PAIS.TabIndex = 0;
            this.lueCOD_PAIS.EditValueChanged += new System.EventHandler(this.lueCOD_PAIS_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 28);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Pais";
            // 
            // xfUbigeoDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 169);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.luePopCOD_DIST);
            this.Controls.Add(this.luePopCOD_PROV);
            this.Controls.Add(this.lueCOD_PAIS);
            this.Controls.Add(this.luePopCOD_DEPA);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Caramel";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfUbigeoDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especificar ubigeo";
            this.Load += new System.EventHandler(this.xfUbigeoDireccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_DEPA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_PROV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePopCOD_DIST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCOD_PAIS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAceptar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit luePopCOD_DEPA;
        public DevExpress.XtraEditors.LookUpEdit luePopCOD_PROV;
        public DevExpress.XtraEditors.LookUpEdit luePopCOD_DIST;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LookUpEdit lueCOD_PAIS;
    }
}