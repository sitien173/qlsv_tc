
namespace qlsv_tc.Forms
{
    partial class frmReportBangDiemMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.lookUpEditMH = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.dS1 = new qlsv_tc.DS1();
            this.txtNhom = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnInLTC = new DevExpress.XtraEditors.SimpleButton();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableAdapterMonHoc = new qlsv_tc.DS1TableAdapters.MONHOCTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.txtNienKhoa);
            this.groupBox1.Controls.Add(this.lookUpEditMH);
            this.groupBox1.Controls.Add(this.txtNhom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.btnInLTC);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(647, 403);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In Bảng Điểm Môn Học";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(252, 345);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 41);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Location = new System.Drawing.Point(148, 115);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(244, 30);
            this.txtNienKhoa.TabIndex = 23;
            this.txtNienKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNienKhoa_KeyPress);
            // 
            // lookUpEditMH
            // 
            this.lookUpEditMH.Location = new System.Drawing.Point(148, 243);
            this.lookUpEditMH.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditMH.Name = "lookUpEditMH";
            this.lookUpEditMH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditMH.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditMH.Properties.DataSource = this.bdsMonHoc;
            this.lookUpEditMH.Properties.DisplayMember = "TENMH";
            this.lookUpEditMH.Properties.NullText = "";
            this.lookUpEditMH.Properties.ValueMember = "MAMH";
            this.lookUpEditMH.Size = new System.Drawing.Size(460, 30);
            this.lookUpEditMH.TabIndex = 22;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS1;
            // 
            // dS1
            // 
            this.dS1.DataSetName = "DS1";
            this.dS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNhom
            // 
            this.txtNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Location = new System.Drawing.Point(147, 300);
            this.txtNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhom.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Size = new System.Drawing.Size(93, 28);
            this.txtNhom.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Môn Học";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(147, 50);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(460, 30);
            this.cmbKhoa.TabIndex = 11;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // btnInLTC
            // 
            this.btnInLTC.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInLTC.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInLTC.Appearance.Options.UseBackColor = true;
            this.btnInLTC.Appearance.Options.UseFont = true;
            this.btnInLTC.Location = new System.Drawing.Point(436, 345);
            this.btnInLTC.Margin = new System.Windows.Forms.Padding(4);
            this.btnInLTC.Name = "btnInLTC";
            this.btnInLTC.Size = new System.Drawing.Size(159, 41);
            this.btnInLTC.TabIndex = 14;
            this.btnInLTC.Text = "In Báo Cáo";
            this.btnInLTC.Click += new System.EventHandler(this.btnInLTC_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(147, 178);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Size = new System.Drawing.Size(93, 28);
            this.txtHocKy.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 53);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 25);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Học Kì";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Niên Khoá";
            // 
            // tableAdapterMonHoc
            // 
            this.tableAdapterMonHoc.ClearBeforeFill = true;
            // 
            // frmReportBangDiemMonHoc
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 473);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportBangDiemMonHoc";
            this.Text = "Báo Cáo Bảng Điểm Môn Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportBangDiemMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit txtNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.SimpleButton btnInLTC;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DS1 dS1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMH;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS1TableAdapters.MONHOCTableAdapter tableAdapterMonHoc;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}