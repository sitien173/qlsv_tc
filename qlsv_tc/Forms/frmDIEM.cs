using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc.Forms
{
    public partial class frmDIEM : DevExpress.XtraEditors.XtraForm
    {
        public frmDIEM()
        {
            InitializeComponent();
        }

        private void frmDIEM_Load(object sender, EventArgs e)
        {
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);
            loadInitializeData();
            // TODO : Role Action
            if (Program.mGroup == Program.role.PGV.ToString())// PGV
            {
                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = true;

                btnGhi.Enabled = true;
            }
            else if (Program.mGroup == Program.role.KHOA.ToString()) // KHOA
            {
                cboxKhoa.Visible = false;
                btnGhi.Enabled = true;

                cboxKhoa.Visible = true;
                cboxKhoa.Enabled = false;
            }
            btnGhi.Enabled = false;
        }
        private void loadInitializeData()
        {
            dS1.EnforceConstraints = false;
            this.tableAdapterMonHoc.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMonHoc.Fill(this.dS1.MONHOC);
            DiemGridControl.Enabled = false;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            string nienkhoa = txtNienKhoa.Text.Trim();
            int hocky = (int)spinEditHocKi.Value;
            int nhom = (int)spinEditNhom.Value;
            string mamh = lookUpMonHoc.Text.Equals("") ? "" : lookUpMonHoc.GetColumnValue("MAMH").ToString();

            if (nienkhoa.Equals(""))
            {
                XtraMessageBox.Show("Niên khóa không được để trống");
                return;
            }
            if(hocky < 1 || hocky > 3)
            {
                XtraMessageBox.Show("Học kỳ phải lớn hơn 1 và nhỏ hơn 3");
                return;
            }
            if(nhom < 1)
            {
                XtraMessageBox.Show("Nhóm phải lớn hơn 0");
                return;
            }
            if (mamh.Equals(""))
            {
                XtraMessageBox.Show("Mã môn học không được để trống");
                return;
            }
            // fill data
            this.tableAdapterDIEMSV.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDIEMSV.Fill(this.dS1.GetDanhSachDiemSV, nienkhoa, hocky, mamh, nhom);
            DiemGridControl.Enabled = true;
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.Validate();
                    this.bdsDIEMSV.EndEdit();
                    this.bdsDIEMSV.ResetCurrentItem();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MALTC", typeof(int));
                    dt.Columns.Add("MASV", typeof(string));
                    dt.Columns.Add("DIEM_CC", typeof(int));
                    dt.Columns.Add("DIEM_GK", typeof(float));
                    dt.Columns.Add("DIEM_CK", typeof(float));
                    dt.Columns.Add("HUYDANGKY", typeof(bool));

                   
                    for (int i=0; i < dS1.GetDanhSachDiemSV.Rows.Count; i++)
                    {
                        dt.Rows.Add(dS1.GetDanhSachDiemSV.Rows[i]["MALTC"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["MASV"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_CC"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_GK"], 
                            dS1.GetDanhSachDiemSV.Rows[i]["DIEM_CK"], false);
                    }
                    SqlParameter param = new SqlParameter();
                    param.SqlDbType = SqlDbType.Structured;
                    param.TypeName = "dbo.DANGKYType";
                    param.Value = dt;
                    param.ParameterName = "DIEMTHI";

                    SqlCommand sqlCommand = new SqlCommand("SP_Update_Diem", Program.conn);
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(param);
                    sqlCommand.ExecuteNonQuery();
                    XtraMessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGhi.Enabled = false;
                }
                catch (Exception ex)
                {
                    bdsDIEMSV.RemoveCurrent();
                    XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled)
            {
                if (XtraMessageBox.Show("Thoát mà không lưu", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }else
            {
                this.Close();
            }
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled)
            {
                if (XtraMessageBox.Show("Bạn chưa lưu. Bạn có muốn lưu trước khi làm mới không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    btnGhi.PerformClick();
                }
                btnBatDau.PerformClick();
            }
        }
    }
}