﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc.Forms
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private static int _position = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS1);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            error.ClearErrors();

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            pnMonHoc.Enabled = false;
            MonHocGridControl.Enabled = true;

            // TODO : Role Action
            if (Program.mGroup == Program.role.PGV.ToString())// PGV
            {
                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = true;

                btnThem.Enabled
                   = btnXoa.Enabled
                   = btnHieuChinh.Enabled
                   = btnUndo.Enabled
                   = btnGhi.Enabled
                   = true;
            }
            else if (Program.mGroup == Program.role.KHOA.ToString()) // KHOA
            {
                cboxKhoa.Visible = false;

                btnThem.Enabled
                   = btnXoa.Enabled
                   = btnHieuChinh.Enabled
                   = btnUndo.Enabled
                   = btnGhi.Enabled
                   = true;

                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void cboxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO : Chuyển Bộ Phận

            Ultils.ComboboxHelper(this.cboxKhoa);

            // kết nối database với dữ liệu ở đoạn code trên và fill dữ liệu, nếu như có lỗi thì
            // thoát.
            if (Program.KetNoi() == 0)
            {
                XtraMessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadInitializeData();
            }
        }

        private void loadInitializeData()
        {
            dS1.EnforceConstraints = false;
            this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLTC.Fill(this.dS1.LOPTINCHI);
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.dS1.MONHOC);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;


            MonHocGridControl.Enabled = false;
            pnMonHoc.Enabled = true;

            bdsMonHoc.AddNew();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: Display To handle
            MonHocGridControl.Enabled = false;
            pnMonHoc.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = true;

            btnThem.Enabled
                = btnXoa.Enabled
                = btnHieuChinh.Enabled
                = btnUndo.Enabled
                = btnReload.Enabled = false;
            cboxKhoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLtc.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học vì đã có LTC.", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa môn này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMonHoc.RemoveCurrent();
                    this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
                    int check = this.tableAdapterMonHoc.Update(this.dS1.MONHOC);
                    if (check > 0) XtraMessageBox.Show("Xoá Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa môn học.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.tableAdapterMonHoc.Fill(this.dS1.MONHOC);
                    return;

                }
            }
            if (bdsMonHoc.Count == 0) btnXoa.Enabled = btnHieuChinh.Enabled = btnHuy.Enabled = false;


            btnReload.Enabled = true;
            pnMonHoc.Enabled = false;

            if (_position > 0)
            {
                bdsMonHoc.Position = _position;
            }
        }

        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfo()
        {
            error.ClearErrors();

            // TODO : Check khoảng trống ở textField
            if (txtMAMH.Text.Trim().Equals(""))
            {
                this.error.SetError(txtMAMH, "MAMH không được để trống !");
                return false;
            }
            if (txtTENMH.Text.Trim().Equals(""))
            {
                this.error.SetError(txtTENMH, "TENMH không được để trống !");
                return false;
            }
            if (spSOTIETLT.Value < 0)
            {
                this.error.SetError(spSOTIETLT, "SOTIET_LT lớn hơn hoặc bằng 0!");
                return false;
            }else if(spSOTIETTH.Value < 0)
            {
                this.error.SetError(spSOTIETTH, "SOTIET_TH lớn hơn hoặc bằng 0!");
                return false;
            }else
            {
                int sum = Convert.ToInt32(spSOTIETLT.Value) + Convert.ToInt32(spSOTIETTH.Value);
                if(sum % 15 != 0)
                {
                    this.error.SetError(spSOTIETLT, "SOTIET_LT & SOTIET_TH phải là bội số của 15 !");
                    this.error.SetError(spSOTIETTH, "SOTIET_LT & SOTIET_TH phải là bội số của 15 !");
                    return false;
                }
            }
            return checkExistMonHoc(txtMAMH.Text.Trim());
        }

        private bool checkExistMonHoc(string mamh)
        {
            // check exist MONHOC
            string query = "DECLARE @return_value INT \n" +
                $"EXEC @return_value=[dbo].[SP_CheckExistMonHoc] @MAMH=N'{mamh}' " +
                "SELECT 'Return Value'=@return_value;";
            int result = Ultils.CheckDataHelper(query);
            if (result > 0) // exist
            {
                XtraMessageBox.Show($"Đã Tồn Tại Môn Học Có MAMH {mamh}");
                this.error.SetError(txtMAMH, "Đã Tồn Tại MAMH");
                return false;
            }
            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.ValidateInfo();
            if (check)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        btnThem.Enabled
                        = btnXoa.Enabled
                        = btnHieuChinh.Enabled
                        = btnUndo.Enabled
                        = btnReload.Enabled = true;

                        MonHocGridControl.Enabled = true;
                        pnMonHoc.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

                        this.bdsMonHoc.EndEdit();
                        this.bdsMonHoc.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        int check1 = this.tableAdapterMonHoc.Update(this.dS1.MONHOC);
                        if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
                        XtraMessageBox.Show($"Ghi Thành Công {check1} row updated");

                    }
                    catch (Exception ex)
                    {
                        bdsMonHoc.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();

            // load lại cả form...
            frmMonHoc_Load(sender, e);
            if (_position > 0)
            {
                bdsMonHoc.Position = _position;
            }
            if (Program.mGroup.Equals(Program.role.PGV.ToString())) cboxKhoa.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnMonHoc.Enabled)
            {

                String notifi = " Dữ liệu chưa lưu vào Database. \n Bạn có chắc muốn thoát !";


                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }
    }
}