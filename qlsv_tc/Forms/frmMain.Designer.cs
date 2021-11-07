
namespace qlsv_tc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapNhapXuatNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDsDongHPLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDiemSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiemSV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rb_quantri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rb_hocphi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rb_baocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnSinhVien,
            this.btnLapNhapXuatNV,
            this.btnInDSLTC,
            this.btnPhieuNV,
            this.btnMoLTC,
            this.btnDangKyLTC,
            this.btnHocPhi,
            this.btnDsDongHPLop,
            this.btnBangDiemMonHoc,
            this.btnPhieuDiemSinhVien,
            this.btnBangDiemTongKet,
            this.btnMonHoc,
            this.btnLop,
            this.btnDiemSV});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rb_quantri,
            this.rb_baocao});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 231);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 2;
            this.btnDangNhap.ImageOptions.Image = global::qlsv_tc.Properties.Resources.signin;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tải khoản";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 3;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 4;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Enabled = false;
            this.btnSinhVien.Id = 6;
            this.btnSinhVien.ImageOptions.Image = global::qlsv_tc.Properties.Resources.sinhvien;
            this.btnSinhVien.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources.sinhvien;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnLapNhapXuatNV
            // 
            this.btnLapNhapXuatNV.Caption = "DSSV Đăng Ký LTC";
            this.btnLapNhapXuatNV.Id = 7;
            this.btnLapNhapXuatNV.Name = "btnLapNhapXuatNV";
            this.btnLapNhapXuatNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapNhapXuatNV_ItemClick);
            // 
            // btnInDSLTC
            // 
            this.btnInDSLTC.Caption = "Danh Sách LTC";
            this.btnInDSLTC.Id = 8;
            this.btnInDSLTC.Name = "btnInDSLTC";
            this.btnInDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSLTC_ItemClick);
            // 
            // btnPhieuNV
            // 
            this.btnPhieuNV.Caption = "Phiếu các NV lập trong năm";
            this.btnPhieuNV.Id = 9;
            this.btnPhieuNV.Name = "btnPhieuNV";
            // 
            // btnMoLTC
            // 
            this.btnMoLTC.Caption = "Mở LTC";
            this.btnMoLTC.Enabled = false;
            this.btnMoLTC.Id = 10;
            this.btnMoLTC.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources._1066146;
            this.btnMoLTC.Name = "btnMoLTC";
            this.btnMoLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoLTC_ItemClick);
            // 
            // btnDangKyLTC
            // 
            this.btnDangKyLTC.Caption = "Đăng Ký LTC";
            this.btnDangKyLTC.Enabled = false;
            this.btnDangKyLTC.Id = 12;
            this.btnDangKyLTC.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources._942748;
            this.btnDangKyLTC.Name = "btnDangKyLTC";
            this.btnDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyLTC_ItemClick);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Caption = "Học Phí";
            this.btnHocPhi.Enabled = false;
            this.btnHocPhi.Id = 13;
            this.btnHocPhi.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources.hocphi;
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhi_ItemClick);
            // 
            // btnDsDongHPLop
            // 
            this.btnDsDongHPLop.Caption = "DS Đóng HP của Lớp";
            this.btnDsDongHPLop.Id = 15;
            this.btnDsDongHPLop.Name = "btnDsDongHPLop";
            this.btnDsDongHPLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDsDongHPLop_ItemClick);
            // 
            // btnBangDiemMonHoc
            // 
            this.btnBangDiemMonHoc.Caption = "Bảng Điểm Môn Học";
            this.btnBangDiemMonHoc.Id = 16;
            this.btnBangDiemMonHoc.Name = "btnBangDiemMonHoc";
            this.btnBangDiemMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemMonHoc_ItemClick);
            // 
            // btnPhieuDiemSinhVien
            // 
            this.btnPhieuDiemSinhVien.Caption = "Phiếu Điểm Sinh Viên";
            this.btnPhieuDiemSinhVien.Id = 17;
            this.btnPhieuDiemSinhVien.Name = "btnPhieuDiemSinhVien";
            this.btnPhieuDiemSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDiemSinhVien_ItemClick);
            // 
            // btnBangDiemTongKet
            // 
            this.btnBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết";
            this.btnBangDiemTongKet.Id = 18;
            this.btnBangDiemTongKet.Name = "btnBangDiemTongKet";
            this.btnBangDiemTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiemTongKet_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Enabled = false;
            this.btnMonHoc.Id = 19;
            this.btnMonHoc.ImageOptions.Image = global::qlsv_tc.Properties.Resources._1116589;
            this.btnMonHoc.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources._1116589;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Enabled = false;
            this.btnLop.Id = 22;
            this.btnLop.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources._3442161;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnDiemSV
            // 
            this.btnDiemSV.Caption = "Nhập Điểm";
            this.btnDiemSV.Id = 23;
            this.btnDiemSV.ImageOptions.Image = global::qlsv_tc.Properties.Resources._1310388;
            this.btnDiemSV.ImageOptions.LargeImage = global::qlsv_tc.Properties.Resources._1310388;
            this.btnDiemSV.Name = "btnDiemSV";
            this.btnDiemSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiemSV_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rb_quantri
            // 
            this.rb_quantri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10,
            this.ribbonPageGroup12,
            this.ribbonPageGroup11,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.rb_hocphi});
            this.rb_quantri.Name = "rb_quantri";
            this.rb_quantri.Text = "Quản trị";
            this.rb_quantri.Visible = false;
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ImageOptions.Image = global::qlsv_tc.Properties.Resources._1116589;
            this.ribbonPageGroup10.ItemLinks.Add(this.btnMonHoc, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSinhVien, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnMoLTC, true);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDangKyLTC, true);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // rb_hocphi
            // 
            this.rb_hocphi.ItemLinks.Add(this.btnHocPhi, true);
            this.rb_hocphi.Name = "rb_hocphi";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnDiemSV);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // rb_baocao
            // 
            this.rb_baocao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup3,
            this.ribbonPageGroup9});
            this.rb_baocao.Name = "rb_baocao";
            this.rb_baocao.Text = "Báo cáo";
            this.rb_baocao.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnInDSLTC, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLapNhapXuatNV, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnBangDiemMonHoc);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnPhieuDiemSinhVien);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangDiemTongKet, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDsDongHPLop);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1137, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(64, 25);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(69, 25);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(68, 25);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnLapNhapXuatNV;
        private DevExpress.XtraBars.BarButtonItem btnInDSLTC;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage rb_quantri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rb_baocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnMoLTC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem btnHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rb_hocphi;
        private DevExpress.XtraBars.BarButtonItem btnDsDongHPLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDiemSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnBangDiemTongKet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnDiemSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}

