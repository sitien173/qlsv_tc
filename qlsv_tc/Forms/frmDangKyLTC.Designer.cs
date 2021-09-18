
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
            this.pnThongTinSV = new DevExpress.XtraEditors.PanelControl();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnThongTinLTC = new DevExpress.XtraEditors.PanelControl();
            this.grbNhapNKHK = new System.Windows.Forms.GroupBox();
            this.spHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.btnTimLTC = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.drvDangKyLTC = new System.Windows.Forms.DataGridView();
            this.dgrvThongTinDangKy = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHON = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HOTENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinSV)).BeginInit();
            this.pnThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinLTC)).BeginInit();
            this.pnThongTinLTC.SuspendLayout();
            this.grbNhapNKHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvDangKyLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvThongTinDangKy)).BeginInit();
            this.panel3.SuspendLayout();
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
            // pnThongTinSV
            // 
            this.pnThongTinSV.Controls.Add(this.txtTen);
            this.pnThongTinSV.Controls.Add(this.label4);
            this.pnThongTinSV.Controls.Add(this.txtMaLop);
            this.pnThongTinSV.Controls.Add(this.label6);
            this.pnThongTinSV.Controls.Add(this.txtHo);
            this.pnThongTinSV.Controls.Add(this.label5);
            this.pnThongTinSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinSV.Location = new System.Drawing.Point(0, 58);
            this.pnThongTinSV.Name = "pnThongTinSV";
            this.pnThongTinSV.Size = new System.Drawing.Size(1792, 100);
            this.pnThongTinSV.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(351, 41);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(234, 30);
            this.txtHo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Họ";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(1211, 41);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(234, 30);
            this.txtMaLop.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1101, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Lớp";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(771, 40);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(234, 30);
            this.txtTen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên";
            // 
            // pnThongTinLTC
            // 
            this.pnThongTinLTC.Controls.Add(this.pnRight);
            this.pnThongTinLTC.Controls.Add(this.panel1);
            this.pnThongTinLTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTinLTC.Location = new System.Drawing.Point(0, 158);
            this.pnThongTinLTC.Name = "pnThongTinLTC";
            this.pnThongTinLTC.Size = new System.Drawing.Size(1792, 556);
            this.pnThongTinLTC.TabIndex = 4;
            // 
            // grbNhapNKHK
            // 
            this.grbNhapNKHK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhapNKHK.AutoSize = true;
            this.grbNhapNKHK.Controls.Add(this.spHocKi);
            this.grbNhapNKHK.Controls.Add(this.txtNienKhoa);
            this.grbNhapNKHK.Controls.Add(this.btnTimLTC);
            this.grbNhapNKHK.Controls.Add(this.label7);
            this.grbNhapNKHK.Controls.Add(this.label8);
            this.grbNhapNKHK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapNKHK.Location = new System.Drawing.Point(32, 137);
            this.grbNhapNKHK.Name = "grbNhapNKHK";
            this.grbNhapNKHK.Size = new System.Drawing.Size(393, 303);
            this.grbNhapNKHK.TabIndex = 1;
            this.grbNhapNKHK.TabStop = false;
            this.grbNhapNKHK.Text = "Tìm Kiếm Lớp Tín Chỉ";
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
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(131, 38);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(183, 30);
            this.txtNienKhoa.TabIndex = 4;
            // 
            // btnTimLTC
            // 
            this.btnTimLTC.Location = new System.Drawing.Point(257, 102);
            this.btnTimLTC.Name = "btnTimLTC";
            this.btnTimLTC.Size = new System.Drawing.Size(130, 34);
            this.btnTimLTC.TabIndex = 2;
            this.btnTimLTC.Text = "Tìm Lớp";
            this.btnTimLTC.Click += new System.EventHandler(this.btnTimLTC_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Học Kì";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Niên Khoá";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbNhapNKHK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 552);
            this.panel1.TabIndex = 5;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.panel3);
            this.pnRight.Controls.Add(this.dgrvThongTinDangKy);
            this.pnRight.Controls.Add(this.drvDangKyLTC);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(456, 2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(1334, 552);
            this.pnRight.TabIndex = 6;
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
            this.drvDangKyLTC.Location = new System.Drawing.Point(0, 0);
            this.drvDangKyLTC.Name = "drvDangKyLTC";
            this.drvDangKyLTC.RowHeadersWidth = 62;
            this.drvDangKyLTC.RowTemplate.Height = 28;
            this.drvDangKyLTC.Size = new System.Drawing.Size(1334, 227);
            this.drvDangKyLTC.TabIndex = 4;
            this.drvDangKyLTC.Visible = false;
            // 
            // dgrvThongTinDangKy
            // 
            this.dgrvThongTinDangKy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrvThongTinDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvThongTinDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMH,
            this.CON,
            this.CHON,
            this.HOTENGV,
            this.TENMH,
            this.NHOM});
            this.dgrvThongTinDangKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrvThongTinDangKy.Location = new System.Drawing.Point(0, 282);
            this.dgrvThongTinDangKy.Name = "dgrvThongTinDangKy";
            this.dgrvThongTinDangKy.RowHeadersWidth = 62;
            this.dgrvThongTinDangKy.RowTemplate.Height = 28;
            this.dgrvThongTinDangKy.Size = new System.Drawing.Size(1334, 270);
            this.dgrvThongTinDangKy.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 55);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh Sách Môn Học Đăng Ký";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1062, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 34);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Ghi";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(1201, 14);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(112, 34);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Xoá";
            // 
            // MAMH
            // 
            this.MAMH.HeaderText = "Mã Môn Học";
            this.MAMH.MinimumWidth = 8;
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            this.MAMH.Width = 150;
            // 
            // CON
            // 
            this.CON.HeaderText = "Còn";
            this.CON.MinimumWidth = 8;
            this.CON.Name = "CON";
            this.CON.ReadOnly = true;
            this.CON.Width = 150;
            // 
            // CHON
            // 
            this.CHON.HeaderText = "Chọn";
            this.CHON.MinimumWidth = 8;
            this.CHON.Name = "CHON";
            this.CHON.Width = 150;
            // 
            // HOTENGV
            // 
            this.HOTENGV.HeaderText = "Giảng Viên";
            this.HOTENGV.MinimumWidth = 8;
            this.HOTENGV.Name = "HOTENGV";
            this.HOTENGV.ReadOnly = true;
            this.HOTENGV.Width = 150;
            // 
            // TENMH
            // 
            this.TENMH.HeaderText = "Tên MH";
            this.TENMH.MinimumWidth = 8;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            this.TENMH.Width = 150;
            // 
            // NHOM
            // 
            this.NHOM.HeaderText = "Nhóm";
            this.NHOM.MinimumWidth = 8;
            this.NHOM.Name = "NHOM";
            this.NHOM.ReadOnly = true;
            this.NHOM.Width = 150;
            // 
            // frmDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 714);
            this.Controls.Add(this.pnThongTinLTC);
            this.Controls.Add(this.pnThongTinSV);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKyLTC";
            this.Text = "frmDangKyLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinSV)).EndInit();
            this.pnThongTinSV.ResumeLayout(false);
            this.pnThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinLTC)).EndInit();
            this.pnThongTinLTC.ResumeLayout(false);
            this.grbNhapNKHK.ResumeLayout(false);
            this.grbNhapNKHK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvDangKyLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvThongTinDangKy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl pnThongTinSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.PanelControl pnThongTinLTC;
        private System.Windows.Forms.GroupBox grbNhapNKHK;
        private DevExpress.XtraEditors.SpinEdit spHocKi;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private DevExpress.XtraEditors.SimpleButton btnTimLTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.DataGridView dgrvThongTinDangKy;
        private System.Windows.Forms.DataGridView drvDangKyLTC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CON;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHON;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHOM;
    }
}