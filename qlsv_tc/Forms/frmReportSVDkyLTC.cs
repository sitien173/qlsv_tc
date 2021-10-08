using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmReportSVDkyLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmReportSVDkyLTC()
        {
            InitializeComponent();
        }
       
        private void frmReportSVDkyLTC_Load(object sender, EventArgs e)
        {
            this.dS1.EnforceConstraints = false;
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cmbKhoa, Program.bds_dspm.DataSource);

            this.tableAdapterNienKhoa.Connection.ConnectionString = Program.connstr;
            this.tableAdapterNienKhoa.FillByNienKhoa(this.dS1.NIENKHOA);

            this.tableAdapterMH.Connection.ConnectionString = Program.connstr;
            this.tableAdapterMH.Fill(this.dS1.MONHOC);

        }

        private void btnInLTC_Click(object sender, EventArgs e)
        {
           
            if (cmbNienKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn niên khóa");
                return;
            }
            if (cmbKhoa.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa");
                return;
            }
            if (cmbMH.Text.Equals(""))
            {
                XtraMessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            // nien khoa hoc ky mamh nhom
            XrptSinhVienDkyLTC xrpt = new XrptSinhVienDkyLTC(cmbNienKhoa.Text, int.Parse(txtHocKy.Text), cmbMH.SelectedValue.ToString(), int.Parse(txtNhom.Text));
            xrpt.lbKhoa.Text = cmbKhoa.Text.ToUpper();
            xrpt.lbNienKhoa.Text = $"Niên Khóa: {cmbNienKhoa.Text}";
            xrpt.lbHocKy.Text = $"Học Kỳ: {txtHocKy.Text}";
            xrpt.lbMonHoc.Text = $"Môn Học: {cmbMH.Text}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();
        }
    }
}