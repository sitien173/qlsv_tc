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
    public partial class DkyLTC : DevExpress.XtraEditors.XtraForm
    {
        public DkyLTC()
        {
            InitializeComponent();
        }

        private void initDataDsLTC(string nienkhoa,int hocky)
        {
           
        }

        private void DkyLTC_Load(object sender, EventArgs e)
        {          
            this.ActiveControl = txtMaSv;
            pnBody.Visible = false;
            panelNienKhoaHocKi.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSv.Text))
            {
                MessageBox.Show("Mã Sinh Viên Không Được Để Trống");
                return;
            }
            else
            {
                string query = "EXEC SP_TimThongTinSinhVien @masv = '" + txtMaSv.Text + "'";
                if (Program.KetNoi() != 1)
                {
                    MessageBox.Show("Kết nối tới csdl thất bại");
                    return;
                }
                else
                {
                    System.Data.SqlClient.SqlDataReader dataReader = Program.ExecSqlDataReader(query);
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

                        txtHo.Text = ho;
                        txtTen.Text = ten;
                        txtMaLop.Text = malop;
                        panelNienKhoaHocKi.Visible = true;
                        pnBody.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Mã SV Không Tồn Tại");
                        panelNienKhoaHocKi.Visible = false;
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
            if (string.IsNullOrWhiteSpace(txtNienKhoa.Text))
            {
                MessageBox.Show("Niên Khoá Không Được Để Trống");
                return;
            }else if(Convert.ToInt32(spHocKi.Text) < 1 || Convert.ToInt32(spHocKi.Text) > 3)
            {
                MessageBox.Show("Học Kỳ Trong Khoảng 1 - 3");
                return;
            }
            this.initDataDsLTC(txtNienKhoa.Text.Trim(), Convert.ToInt32(spHocKi.Text));
            pnBody.Visible = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
        }

    }
}