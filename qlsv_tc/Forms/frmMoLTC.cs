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

        private void frmMoLTC_Load(object sender, EventArgs e)
        {

            this.tableAdapterLTC.Connection.ConnectionString = Program.connstr;
            this.tableAdapterLTC.Fill(this.DS.LOPTINCHI);

            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            this.tableAdapterDK.Connection.ConnectionString = Program.connstr;
            this.tableAdapterDK.Fill(this.DS.DANGKY);
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
        }
    }
}