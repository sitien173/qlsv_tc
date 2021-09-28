using DevExpress.XtraEditors;
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
    public partial class frmMoLTC : DevExpress.XtraEditors.XtraForm
    {
        private int _position = 0;
        private string _flagOption; // true = add ; false = update ; default of boolean = false
        private string _oldMaLTC = "";
        private string _oldTenLTC = "";
        public frmMoLTC()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void loadInitializeData()
        {

            DS.EnforceConstraints = false;
            this.tableAdapterMH.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMH.Fill(this.DS.MONHOC);

            this.tableAdapterGV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterGV.Fill(this.DS.GIANGVIEN);

            this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLTC.Fill(this.DS.LOPTINCHI);
           
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.Fill(this.DS.DANGKY);
        }
        private void frmMoLTC_Load(object sender, EventArgs e)
        {
           
            loadInitializeData();
            
            err.Clear();

            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            gbMoLTC.Enabled = false;
            LTCGridControl.Enabled = true;

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

                lblTenKhoa.Text = ((DataRowView)Program.bds_dspm[Program.mKhoa])["TENKHOA"].ToString();
                cboxKhoa.SelectedIndex = Program.mKhoa;

            }
           btnGhi.Enabled = btnHuy.Enabled =  false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            _flagOption = "ADD";//  Add action
            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            

            LTCGridControl.Enabled = false;
            gbMoLTC.Enabled = true;

            // thao tác chuẩn bị thêm
            bdsLTC.AddNew();

            // mặc định là false
            cbHuyLop.Checked = false;
           
            int count = this.DS.LOPTINCHI.Rows.Count;
            txtNienKhoa.Text = this.DS.LOPTINCHI.Rows[count - 1].Field<string>("NIENKHOA");
              
            txtMaKhoa.Text = Ultils.GetMaKhoa();
            txtMaKhoa.ReadOnly = true;

            
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

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            bdsLTC.CancelEdit();
            
            // load lại cả form...
            frmMoLTC_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMoLTC_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mAGVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        // ====================== SUPPORT VALIDATION ====================== //
        private bool ValidateInfo()
        {
            err.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtNienKhoa.Text.Trim().Equals(""))
            {
                this.err.SetError(txtNienKhoa, "Niên Khoá không được để trống !");
                return false;
            }
            if (cmbMAGV.Text.Equals(""))
            {
                this.err.SetError(cmbMAGV, "Vui lòng chọn MAGV !");
                return false;
            }
            if (txtHocKi.Text.Equals(""))
            {
                this.err.SetError(txtHocKi, "Vui lòng chọn HOCKY !");
                return false;
            }
            if (cmbMAMH.Text.Equals(""))
            {
                this.err.SetError(cmbMAMH, "Vui lòng chọn MAMH !");
                return false;
            }
            if (txtSOSVTOITHIEU.Text.Equals(""))
            {
                this.err.SetError(txtSOSVTOITHIEU, "Vui lòng chọn SOSVTOITHIEU !");
                return false;
            }

            if (txtNhom.Text.Equals(""))
            {
                this.err.SetError(txtNhom, "Vui lòng chọn NHOM !");
                return false;
            }
           
            

            if (_flagOption == "ADD")
            {
                // TODO : Check xem đã có lớp tc nào tồn tại chưa

                string query = "DECLARE	@MALTC int\n" +
                    "EXEC SP_checkExistMHLTC\n" +
                    $"@NIENKHOA = '{txtNienKhoa.Text.Trim()}'," +
                    $"@HOCKY = {txtHocKi.Text}," +
                    $"@MAMH = '{cmbMAMH.SelectedValue.ToString()}'," +
                    $"@NHOM = {txtNhom.Text}," +
                    $"@MAGV = '{cmbMAGV.SelectedValue.ToString()}'," +
                    $"@MALTC = @MALTC OUTPUT\n" +
                    "SELECT	@MALTC as N'MALTC'";
                int result = Ultils.CheckDataHelper(query);
                if (result == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                    return false;
    
                }
                else if(result > 0)
                {
                    // Đã Tồn tại lớp set vị trị vào dòng đang trùng trên lưới
                    if (XtraMessageBox.Show("Đã Tồn Tại Trong CSDL !\nBạn có muốn hiểu chỉnh lớp cũ không", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnHuy.PerformClick();
                        bdsLTC.Position = bdsLTC.Find("MALTC", result);
                        
                    }
                    return false;
                }
                   
            }

            if (_flagOption == "UPDATE")
            {
               
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

                        LTCGridControl.Enabled = true;

                        this.bdsLTC.EndEdit();
                        this.bdsLTC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                        this.tableAdapterLTC.Update(this.DS.LOPTINCHI);
                    }
                    catch (Exception ex)
                    {
                        bdsLTC.RemoveCurrent();
                        XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
        }
    }
}