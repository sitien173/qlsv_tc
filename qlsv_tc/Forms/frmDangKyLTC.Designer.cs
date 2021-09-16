
namespace qlsv_tc.Forms
{
    partial class frmDangKyLTC
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
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drvThongTInSV = new System.Windows.Forms.DataGridView();
            this.pnTimKiemLTC = new DevExpress.XtraEditors.PanelControl();
            this.grbNhapNKHK = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimLTC = new DevExpress.XtraEditors.SimpleButton();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.spHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.drvDangKyLTC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvThongTInSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTimKiemLTC)).BeginInit();
            this.pnTimKiemLTC.SuspendLayout();
            this.grbNhapNKHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvDangKyLTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Controls.Add(this.txtMaSv);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1792, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Location = new System.Drawing.Point(930, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSv
            // 
            this.txtMaSv.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSv.Location = new System.Drawing.Point(674, 12);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(250, 33);
            this.txtMaSv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Sinh Viên";
            // 
            // drvThongTInSV
            // 
            this.drvThongTInSV.AllowUserToAddRows = false;
            this.drvThongTInSV.AllowUserToDeleteRows = false;
            this.drvThongTInSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvThongTInSV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.drvThongTInSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drvThongTInSV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.drvThongTInSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvThongTInSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.drvThongTInSV.Location = new System.Drawing.Point(0, 58);
            this.drvThongTInSV.Name = "drvThongTInSV";
            this.drvThongTInSV.ReadOnly = true;
            this.drvThongTInSV.RowHeadersWidth = 62;
            this.drvThongTInSV.RowTemplate.Height = 28;
            this.drvThongTInSV.Size = new System.Drawing.Size(1792, 67);
            this.drvThongTInSV.TabIndex = 1;
            this.drvThongTInSV.Visible = false;
            // 
            // pnTimKiemLTC
            // 
            this.pnTimKiemLTC.Controls.Add(this.grbNhapNKHK);
            this.pnTimKiemLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimKiemLTC.Location = new System.Drawing.Point(0, 125);
            this.pnTimKiemLTC.Name = "pnTimKiemLTC";
            this.pnTimKiemLTC.Size = new System.Drawing.Size(1792, 211);
            this.pnTimKiemLTC.TabIndex = 2;
            this.pnTimKiemLTC.Visible = false;
            // 
            // grbNhapNKHK
            // 
            this.grbNhapNKHK.Controls.Add(this.spHocKi);
            this.grbNhapNKHK.Controls.Add(this.txtNienKhoa);
            this.grbNhapNKHK.Controls.Add(this.btnTimLTC);
            this.grbNhapNKHK.Controls.Add(this.label3);
            this.grbNhapNKHK.Controls.Add(this.label2);
            this.grbNhapNKHK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapNKHK.Location = new System.Drawing.Point(640, 29);
            this.grbNhapNKHK.Name = "grbNhapNKHK";
            this.grbNhapNKHK.Size = new System.Drawing.Size(415, 159);
            this.grbNhapNKHK.TabIndex = 0;
            this.grbNhapNKHK.TabStop = false;
            this.grbNhapNKHK.Text = "Tìm Kiếm Lớp Tín Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Niên Khoá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học Kì";
            // 
            // btnTimLTC
            // 
            this.btnTimLTC.Location = new System.Drawing.Point(257, 102);
            this.btnTimLTC.Name = "btnTimLTC";
            this.btnTimLTC.Size = new System.Drawing.Size(130, 34);
            this.btnTimLTC.TabIndex = 2;
            this.btnTimLTC.Text = "Tìm Lớp";
            this.btnTimLTC.Click += new System.EventHandler(this.btnTimLTC_Click);
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(131, 38);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(183, 30);
            this.txtNienKhoa.TabIndex = 4;
            // 
            // spHocKi
            // 
            this.spHocKi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spHocKi.Location = new System.Drawing.Point(131, 80);
            this.spHocKi.Name = "spHocKi";
            this.spHocKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHocKi.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spHocKi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spHocKi.Size = new System.Drawing.Size(76, 28);
            this.spHocKi.TabIndex = 5;
            // 
            // drvDangKyLTC
            // 
            this.drvDangKyLTC.AllowUserToAddRows = false;
            this.drvDangKyLTC.AllowUserToDeleteRows = false;
            this.drvDangKyLTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvDangKyLTC.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.drvDangKyLTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drvDangKyLTC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.drvDangKyLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvDangKyLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.drvDangKyLTC.Location = new System.Drawing.Point(0, 336);
            this.drvDangKyLTC.Name = "drvDangKyLTC";
            this.drvDangKyLTC.RowHeadersWidth = 62;
            this.drvDangKyLTC.RowTemplate.Height = 28;
            this.drvDangKyLTC.Size = new System.Drawing.Size(1792, 150);
            this.drvDangKyLTC.TabIndex = 3;
            this.drvDangKyLTC.Visible = false;
            // 
            // frmDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 714);
            this.Controls.Add(this.drvDangKyLTC);
            this.Controls.Add(this.pnTimKiemLTC);
            this.Controls.Add(this.drvThongTInSV);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKyLTC";
            this.Text = "frmDangKyLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvThongTInSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTimKiemLTC)).EndInit();
            this.pnTimKiemLTC.ResumeLayout(false);
            this.grbNhapNKHK.ResumeLayout(false);
            this.grbNhapNKHK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvDangKyLTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView drvThongTInSV;
        private DevExpress.XtraEditors.PanelControl pnTimKiemLTC;
        private System.Windows.Forms.GroupBox grbNhapNKHK;
        private DevExpress.XtraEditors.SpinEdit spHocKi;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private DevExpress.XtraEditors.SimpleButton btnTimLTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView drvDangKyLTC;
    }
}