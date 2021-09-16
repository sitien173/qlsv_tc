using qlsv_tc.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlsv_tc
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }


        public void HienThiMenu()
        {
            MANV.Text = "MÃ NV: " + Program.username;
            HOTEN.Text = "HỌ TÊN: " + Program.mHoten;
            NHOM.Text = "NHÓM: " + Program.mGroup;

            // phân quyền
            // dựa vào Program.mGroup để bật tắt các module cần thiết
            rb_danhmuc.Visible = true;
            rb_nghiepvu.Visible = true;
            // 
            rb_baocao.Visible = true;

            if(Program.mGroup == Program.role.SV.ToString())
            {
                btnTaoTaiKhoan.Enabled = false;
                rb_danhmuc.Visible = true;

                btnDangKyLTC.Enabled = true;

                rb_nghiepvu.Visible = false;
                rb_baocao.Visible = false;
            }
        }

        public void Dangxuat()
        {
            MANV.Text = "MÃ NV: ";
            HOTEN.Text = "HỌ TÊN: ";
            NHOM.Text = "NHÓM: ";


            Program.connstr = Program.rootConnstr;

           
            rb_danhmuc.Visible = false;
            rb_nghiepvu.Visible = false;
            rb_baocao.Visible = false;
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMoLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = CheckExists(typeof(frmMoLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmMoLTC f = new frmMoLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dangxuat();

            btnDangNhap_ItemClick(sender, e);
        }

    
        private void btnDangKyLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyLTC f = new frmDangKyLTC();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
