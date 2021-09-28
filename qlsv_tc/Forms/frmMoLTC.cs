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
            this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLTC.Fill(this.DS.LOPTINCHI);
            
            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.Fill(this.DS.DANGKY);
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.

        }
        private void frmMoLTC_Load(object sender, EventArgs e)
        {
            loadInitializeData();
            // đoạn code liên kết giữa bds với combo box
            // lọc phân mảnh trước
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

            cboxKhoa.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnUndo.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            

            LTCGridControl.Enabled = false;
            gbMoLTC.Enabled = true;
            // thao tác chuẩn bị thêm
            bdsLTC.AddNew();
            
            // nếu thuộc nhóm khoa thì ko cho mở lớp tín chỉ thuộc khoa khác
            if (Program.mGroup.Equals(Program.role.KHOA.ToString(),StringComparison.Ordinal))
            {
                txtMaKhoa.ReadOnly = true;
            }else if(Program.mGroup.Equals(Program.role.PGV.ToString(), StringComparison.Ordinal))
            {
                txtMaKhoa.ReadOnly = false;
            }
            txtMaKhoa.Text = Ultils.GetMaKhoa();
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
                this.txtMaKhoa.Text = Ultils.GetMaKhoa();
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
    }
}