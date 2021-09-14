
namespace qlsv_tc.Forms
{
    partial class frmMoLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoLTC));
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new qlsv_tc.DS();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterLTC = new qlsv_tc.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new qlsv_tc.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nIENKHOATextBox = new System.Windows.Forms.TextBox();
            this.hOCKYSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHTextBox = new System.Windows.Forms.TextBox();
            this.nHOMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAGVTextBox = new System.Windows.Forms.TextBox();
            this.mAKHOATextBox = new System.Windows.Forms.TextBox();
            this.sOSVTOITHIEUSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hUYLOPCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterDK = new qlsv_tc.DSTableAdapters.DANGKYTableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSVTOITHIEUSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 3;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 6;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 7;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1777, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 784);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1777, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 729);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1777, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 729);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.DS;
            // 
            // tableAdapterLTC
            // 
            this.tableAdapterLTC.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.tableAdapterDK;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.tableAdapterLTC;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = qlsv_tc.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.bdsLTC;
            this.lOPTINCHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 55);
            this.lOPTINCHIGridControl.MainView = this.gridView1;
            this.lOPTINCHIGridControl.MenuManager = this.barManager1;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1777, 220);
            this.lOPTINCHIGridControl.TabIndex = 5;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.lOPTINCHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 30;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 112;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 112;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 112;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 30;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 112;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 112;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 30;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 112;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 30;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 112;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 30;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 112;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(hUYLOPLabel);
            this.panelControl1.Controls.Add(this.hUYLOPCheckEdit);
            this.panelControl1.Controls.Add(sOSVTOITHIEULabel);
            this.panelControl1.Controls.Add(this.sOSVTOITHIEUSpinEdit);
            this.panelControl1.Controls.Add(mAKHOALabel);
            this.panelControl1.Controls.Add(this.mAKHOATextBox);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.mAGVTextBox);
            this.panelControl1.Controls.Add(nHOMLabel);
            this.panelControl1.Controls.Add(this.nHOMSpinEdit);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.mAMHTextBox);
            this.panelControl1.Controls.Add(hOCKYLabel);
            this.panelControl1.Controls.Add(this.hOCKYSpinEdit);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Controls.Add(this.nIENKHOATextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 275);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1777, 509);
            this.panelControl1.TabIndex = 6;
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(104, 32);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(95, 19);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // nIENKHOATextBox
            // 
            this.nIENKHOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "NIENKHOA", true));
            this.nIENKHOATextBox.Location = new System.Drawing.Point(243, 24);
            this.nIENKHOATextBox.Name = "nIENKHOATextBox";
            this.nIENKHOATextBox.Size = new System.Drawing.Size(201, 27);
            this.nIENKHOATextBox.TabIndex = 3;
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(104, 79);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(67, 19);
            hOCKYLabel.TabIndex = 4;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCKYSpinEdit
            // 
            this.hOCKYSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HOCKY", true));
            this.hOCKYSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hOCKYSpinEdit.Location = new System.Drawing.Point(243, 70);
            this.hOCKYSpinEdit.MenuManager = this.barManager1;
            this.hOCKYSpinEdit.Name = "hOCKYSpinEdit";
            this.hOCKYSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hOCKYSpinEdit.Size = new System.Drawing.Size(93, 28);
            this.hOCKYSpinEdit.TabIndex = 5;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(104, 120);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(61, 19);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "MAMH:";
            // 
            // mAMHTextBox
            // 
            this.mAMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAMH", true));
            this.mAMHTextBox.Location = new System.Drawing.Point(243, 112);
            this.mAMHTextBox.Name = "mAMHTextBox";
            this.mAMHTextBox.Size = new System.Drawing.Size(201, 27);
            this.mAMHTextBox.TabIndex = 7;
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(537, 32);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(61, 19);
            nHOMLabel.TabIndex = 8;
            nHOMLabel.Text = "NHOM:";
            // 
            // nHOMSpinEdit
            // 
            this.nHOMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.nHOMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nHOMSpinEdit.Location = new System.Drawing.Point(644, 28);
            this.nHOMSpinEdit.MenuManager = this.barManager1;
            this.nHOMSpinEdit.Name = "nHOMSpinEdit";
            this.nHOMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nHOMSpinEdit.Size = new System.Drawing.Size(100, 28);
            this.nHOMSpinEdit.TabIndex = 9;
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(537, 79);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(59, 19);
            mAGVLabel.TabIndex = 10;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAGVTextBox
            // 
            this.mAGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAGV", true));
            this.mAGVTextBox.Location = new System.Drawing.Point(644, 71);
            this.mAGVTextBox.Name = "mAGVTextBox";
            this.mAGVTextBox.Size = new System.Drawing.Size(181, 27);
            this.mAGVTextBox.TabIndex = 11;
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(537, 120);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(81, 19);
            mAKHOALabel.TabIndex = 12;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // mAKHOATextBox
            // 
            this.mAKHOATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAKHOA", true));
            this.mAKHOATextBox.Location = new System.Drawing.Point(644, 112);
            this.mAKHOATextBox.Name = "mAKHOATextBox";
            this.mAKHOATextBox.Size = new System.Drawing.Size(181, 27);
            this.mAKHOATextBox.TabIndex = 13;
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(888, 27);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(130, 19);
            sOSVTOITHIEULabel.TabIndex = 14;
            sOSVTOITHIEULabel.Text = "SOSVTOITHIEU:";
            // 
            // sOSVTOITHIEUSpinEdit
            // 
            this.sOSVTOITHIEUSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "SOSVTOITHIEU", true));
            this.sOSVTOITHIEUSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOSVTOITHIEUSpinEdit.Location = new System.Drawing.Point(1060, 18);
            this.sOSVTOITHIEUSpinEdit.MenuManager = this.barManager1;
            this.sOSVTOITHIEUSpinEdit.Name = "sOSVTOITHIEUSpinEdit";
            this.sOSVTOITHIEUSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOSVTOITHIEUSpinEdit.Size = new System.Drawing.Size(95, 28);
            this.sOSVTOITHIEUSpinEdit.TabIndex = 15;
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(888, 79);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(76, 19);
            hUYLOPLabel.TabIndex = 16;
            hUYLOPLabel.Text = "HUYLOP:";
            // 
            // hUYLOPCheckEdit
            // 
            this.hUYLOPCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HUYLOP", true));
            this.hUYLOPCheckEdit.Location = new System.Drawing.Point(1060, 74);
            this.hUYLOPCheckEdit.MenuManager = this.barManager1;
            this.hUYLOPCheckEdit.Name = "hUYLOPCheckEdit";
            this.hUYLOPCheckEdit.Properties.Caption = "";
            this.hUYLOPCheckEdit.Size = new System.Drawing.Size(112, 29);
            this.hUYLOPCheckEdit.TabIndex = 17;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDK.DataSource = this.bdsLTC;
            // 
            // tableAdapterDK
            // 
            this.tableAdapterDK.ClearBeforeFill = true;
            // 
            // frmMoLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 804);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMoLTC";
            this.Text = "frmMoLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMoLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSVTOITHIEUSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource bdsLTC;
        private DS DS;
        private DSTableAdapters.LOPTINCHITableAdapter tableAdapterLTC;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraEditors.CheckEdit hUYLOPCheckEdit;
        private DevExpress.XtraEditors.SpinEdit sOSVTOITHIEUSpinEdit;
        private System.Windows.Forms.TextBox mAKHOATextBox;
        private System.Windows.Forms.TextBox mAGVTextBox;
        private DevExpress.XtraEditors.SpinEdit nHOMSpinEdit;
        private System.Windows.Forms.TextBox mAMHTextBox;
        private DevExpress.XtraEditors.SpinEdit hOCKYSpinEdit;
        private System.Windows.Forms.TextBox nIENKHOATextBox;
        private DSTableAdapters.DANGKYTableAdapter tableAdapterDK;
        private System.Windows.Forms.BindingSource bdsDK;
    }
}