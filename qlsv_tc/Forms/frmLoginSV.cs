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
    public partial class frmLoginSV : DevExpress.XtraEditors.XtraForm
    {
        public static string MASV;
        public static string PASSWORD;
        public static Boolean isClose = false;
        public frmLoginSV()
        {
            InitializeComponent();
            simpleButton1.DialogResult = DialogResult.OK;
            simpleButton1.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MASV = txtMASV.Text.Trim();
            PASSWORD = txtPassword.Text.Trim();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void frmLoginSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClose = true;
        }
    }
}