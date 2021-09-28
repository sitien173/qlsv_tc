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
    public partial class frmDongHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmDongHocPhi()
        {
            InitializeComponent();
        }

       
        private void initializeData()
        {
            this.tableAdapterHocPhi.Connection.ConnectionString = Program.connstr;
            this.tableAdapterHocPhi.Fill(this.dS3.HOCPHI);

            this.tableAdapterCTHP.Connection.ConnectionString = Program.connstr;
            this.tableAdapterCTHP.Fill(this.dS3.CT_DONGHOCPHI);
        }

        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {           
            this.initializeData();           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhi.AddNew();
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS3);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                string query = "EXEC SP_TimThongTinSinhVien @masv = '" + txtMaSV.Text + "'";

                if (Program.KetNoi() == -1)
                {
                    MessageBox.Show("Kết nối csdl thất bại. Vui lòng thử lại");
                    return;
                }

                SqlDataReader dataReader = Program.ExecSqlDataReader(query);

                // vì chỉ có 1 dòng nên đọc 1 dòng. Nếu trả kết quả nhiều dòng thì dùng vòng lặp
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    // HO
                    string ho = dataReader.GetString(0);
                    // TEN
                    string ten = dataReader.GetString(1);
                    // MALOP
                    string malop = dataReader.GetString(2);

                    txtHoTen.Text = ho + " " + ten;
                    txtMaLop.Text = malop;

                    // fill to gridview HocPhi
                    this.tableAdapterHocPhi.ClearBeforeFill = true;
                    this.tableAdapterHocPhi.FillByMaSV(this.dS3.HOCPHI, txtMaSV.Text);
                }
                else
                {
                    MessageBox.Show("Mã SV không tồn tại");
                    txtMaSV.Focus();
                    return;
                }


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}