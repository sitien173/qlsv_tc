
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnThongTinSV = new DevExpress.XtraEditors.PanelControl();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnThongTinLTC = new DevExpress.XtraEditors.PanelControl();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dataGridViewDADK = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewDKLTC = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbNhapNKHK = new System.Windows.Forms.GroupBox();
            this.spHocKi = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.btnTimLTC = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dS = new qlsv_tc.DS();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinSV)).BeginInit();
            this.pnThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnThongTinLTC)).BeginInit();
            this.pnThongTinLTC.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDADK)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDKLTC)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbNhapNKHK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
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
            this.txtMaSv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSv_KeyPress);
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
            // pnRight
            // 
            this.pnRight.Controls.Add(this.dataGridViewDADK);
            this.pnRight.Controls.Add(this.panel2);
            this.pnRight.Controls.Add(this.dataGridViewDKLTC);
            this.pnRight.Controls.Add(this.panel3);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(456, 2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(1334, 552);
            this.pnRight.TabIndex = 6;
            // 
            // dataGridViewDADK
            // 
            this.dataGridViewDADK.AllowUserToAddRows = false;
            this.dataGridViewDADK.AllowUserToDeleteRows = false;
            this.dataGridViewDADK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDADK.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDADK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDADK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDADK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDADK.EnableHeadersVisualStyles = false;
            this.dataGridViewDADK.Location = new System.Drawing.Point(0, 343);
            this.dataGridViewDADK.Name = "dataGridViewDADK";
            this.dataGridViewDADK.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDADK.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDADK.RowHeadersWidth = 62;
            this.dataGridViewDADK.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDADK.RowTemplate.Height = 28;
            this.dataGridViewDADK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDADK.Size = new System.Drawing.Size(1334, 209);
            this.dataGridViewDADK.TabIndex = 8;
            this.dataGridViewDADK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDADK_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLuuDangKy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 49);
            this.panel2.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(1133, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH MÔN HỌC ĐÃ ĐĂNG KÝ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuuDangKy
            // 
            this.btnLuuDangKy.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuuDangKy.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDangKy.Appearance.Options.UseBackColor = true;
            this.btnLuuDangKy.Appearance.Options.UseFont = true;
            this.btnLuuDangKy.Location = new System.Drawing.Point(919, 6);
            this.btnLuuDangKy.Name = "btnLuuDangKy";
            this.btnLuuDangKy.Size = new System.Drawing.Size(185, 37);
            this.btnLuuDangKy.TabIndex = 2;
            this.btnLuuDangKy.Text = "Lưu Đăng Ký";
            this.btnLuuDangKy.Click += new System.EventHandler(this.btnLuuDangKy_Click);
            // 
            // dataGridViewDKLTC
            // 
            this.dataGridViewDKLTC.AllowUserToAddRows = false;
            this.dataGridViewDKLTC.AllowUserToDeleteRows = false;
            this.dataGridViewDKLTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDKLTC.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDKLTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDKLTC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDKLTC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDKLTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDKLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewDKLTC.EnableHeadersVisualStyles = false;
            this.dataGridViewDKLTC.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewDKLTC.MultiSelect = false;
            this.dataGridViewDKLTC.Name = "dataGridViewDKLTC";
            this.dataGridViewDKLTC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDKLTC.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDKLTC.RowHeadersWidth = 62;
            this.dataGridViewDKLTC.RowTemplate.Height = 28;
            this.dataGridViewDKLTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDKLTC.Size = new System.Drawing.Size(1334, 234);
            this.dataGridViewDKLTC.TabIndex = 6;
            this.dataGridViewDKLTC.Visible = false;
            this.dataGridViewDKLTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDKLTC_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1334, 60);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH MÔN HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.grbNhapNKHK.Size = new System.Drawing.Size(393, 277);
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
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDADK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDKLTC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbNhapNKHK.ResumeLayout(false);
            this.grbNhapNKHK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHocKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewDKLTC;
        private System.Windows.Forms.DataGridView dataGridViewDADK;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnLuuDangKy;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}