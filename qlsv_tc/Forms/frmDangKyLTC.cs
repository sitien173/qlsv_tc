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
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyLTC()
        {
            InitializeComponent();
        }

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            drvThongTInSV.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSv.Text)) {
                MessageBox.Show("Mã Sinh Viên Không Được Để Trống");
                return;
            }else
            {
                string sql = "select MASV,HO,TEN,MALOP from SINHVIEN where MASV = '" + txtMaSv.Text + "'";
                if(Program.KetNoi() != 1)
                {
                    MessageBox.Show("Kết nối tới csdl thất bại");
                    return;
                }else
                {
                    DataTable dt = Program.ExecSqlQuery(sql);

                    drvThongTInSV.DataSource = dt; //đổ dữ liệu vào datagridview

                    // nếu mã sv tồn tại
                    if(drvThongTInSV.Rows.Count > 0)
                    {
                        drvThongTInSV.Visible = true;
                        pnTimKiemLTC.Visible = true;
                    }
                }
            }
        }

        private void btnTimLTC_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }

            // sau này viết SP
            string sql = "SELECT LTC.MAMH,TENMH,LTC.NHOM,HOTEN = HO +' '+ TEN,LTC.SOSVTOITHIEU \n" +
                "FROM dbo.LOPTINCHI AS LTC \n" +
                "LEFT JOIN dbo.MONHOC ON MONHOC.MAMH = LTC.MAMH \n" +
                "LEFT JOIN dbo.GIANGVIEN ON GIANGVIEN.MAGV = LTC.MAGV \n" +
                "WHERE(LTC.NIENKHOA = '"+txtNienKhoa.Text+"' AND LTC.HOCKY = "+ spHocKi.Value +") AND LTC.HUYLOP = 0";
            DataTable dt = Program.ExecSqlQuery(sql);

            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Đăng Ký";
            dgvcCheckBox.Name = "DANGKY";


            drvDangKyLTC.DataSource = dt; //đổ dữ liệu vào datagridview

            // thêm cột checkbox để dangky
            drvDangKyLTC.Columns.Add(dgvcCheckBox);
            drvDangKyLTC.Columns["DANGKY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            
            if (drvDangKyLTC.RowCount > 0)
            {
                // tắt hiệu chỉnh các cột ngoại trừ cột checkbox đăng ký thì cho phép hiệu chỉnh
                for (int i = 0; i < drvDangKyLTC.Columns.Count - 1; i++)
                {
                    drvDangKyLTC.Columns[i].ReadOnly = true;
                }
                drvDangKyLTC.Visible = true;
            }
        }
    }

}