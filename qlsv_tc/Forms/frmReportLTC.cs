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
    public partial class frmReportLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmReportLTC()
        {
            InitializeComponent();
        }

        private void btnInLTC_Click(object sender, EventArgs e)
        {
            Xrpt_SP_GetDanhSachDkyLTC xrpt = new Xrpt_SP_GetDanhSachDkyLTC(cmbNienKhoa.Text, int.Parse(spHocKi.Text));
            xrpt.lbTiTle.Text = cboxKhoa.Text.ToUpper();
            xrpt.lbNienKhoaHocKy.Text = $"NIÊN KHÓA: {cmbNienKhoa.Text}  HỌC KỲ: {spHocKi.Text}";
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmReportLTC_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            Program.bds_dspm.Filter = "TENKHOA LIKE 'KHOA%'";
            Ultils.BindingDataToComBo(cboxKhoa, Program.bds_dspm.DataSource);

            this.nIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.nIENKHOATableAdapter.FillByNienKhoa(this.dS.NIENKHOA);

        }

    }
}