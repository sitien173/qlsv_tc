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
    public partial class frmSinhVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            this.SVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SVTableAdapter.Fill(this.DS.SINHVIEN);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.DS.DANGKY);

            cboxKhoa.DataSource = Program.bds_dspm;
            cboxKhoa.DisplayMember = "TENKHOA";
            cboxKhoa.ValueMember = "TENSERVER";
            cboxKhoa.SelectedIndex = Program.mKhoa;
            // phân quyền

            //


        }
    }
}
