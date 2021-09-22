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
        private static DataTable dataTableDKLTC = new DataTable();
        private static DataTable dataTableDADK = new DataTable();
        private List<string> MALTCDADK; // tạo mảng để lưu khoá LTC để khi bấm đăng ký thì kiểm tra đã tồn tại hay chưa trc khi thêm vào bảng danh sách đăng ký
        public frmDangKyLTC()
        {
            InitializeComponent();
        }
        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            pnThongTinSV.Enabled = false;
            pnThongTinLTC.Visible = false;
            pnRight.Visible = false;
            this.loadDataGridViewDADK(dataGridViewDADK);
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
                string sql = "select HO,TEN,MALOP from SINHVIEN where MASV = '" + txtMaSv.Text + "'";
                if (Program.KetNoi() != 1)
                {
                    MessageBox.Show("Kết nối tới csdl thất bại");
                    return;
                }
                else
                {
                    System.Data.SqlClient.SqlDataReader datareader = Program.ExecSqlDataReader(sql);
                    // vì chỉ có 1 dòng nên đọc 1 dòng. Nếu trả kết quả nhiều dòng thì dùng vòng lặp
                    datareader.Read();
                    if (datareader.HasRows)
                    {

                        txtHo.Text = datareader.GetString(0);
                        txtTen.Text = datareader.GetString(1);
                        txtMaLop.Text = datareader.GetString(2);
                        pnThongTinLTC.Visible = true;
                        btnLuuDangKy.Enabled = btnXoa.Enabled = false;
                    }

                }
            }
        }

        private void loadDataGridViewDSMH(DataGridView dataGridView)
        {

            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }
            string sql = "SELECT LTC.MALTC,LTC.MAMH, \n" +
                         " MH.TENMH, \n" +
                         " LTC.NHOM, \n" +
                         " (GV.HO + ' ' + GV.TEN) AS GV,\n" +
                         " (LTC.SOSVTOITHIEU - COUNT(DK.MASV)) AS CON\n" +
                         " FROM dbo.LOPTINCHI AS LTC\n" +
                         " LEFT JOIN dbo.MONHOC MH ON MH.MAMH = LTC.MAMH\n" +
                         " LEFT JOIN dbo.GIANGVIEN GV ON GV.MAGV = LTC.MAGV\n" +
                         " LEFT JOIN dbo.DANGKY DK ON DK.MALTC = LTC.MALTC\n" +
                         " LEFT JOIN dbo.SINHVIEN SV ON SV.MASV = DK.MASV\n" +
                         " WHERE LTC.HUYLOP = 0 AND (LTC.NIENKHOA = '" + txtNienKhoa.Text + "' AND LTC.HOCKY = " + spHocKi.Text + ")\n" +
                         " GROUP BY  LTC.MALTC,LTC.SOSVTOITHIEU,LTC.MAMH,LTC.NHOM,GV.HO,GV.TEN,MH.TENMH;\n";


            dataTableDKLTC = Program.ExecSqlQuery(sql);

            // thêm 1 cột checkbox đăng ký

            DataColumn colDangKy = new DataColumn("DANGKY");
            colDangKy.DataType = System.Type.GetType("System.Boolean");
            colDangKy.DefaultValue = false;
            dataTableDKLTC.Columns.Add(colDangKy);

            dataGridViewDKLTC.DataSource = dataTableDKLTC;

            dataGridViewDKLTC.Columns["MALTC"].Visible = false;

            dataGridViewDKLTC.Columns["DANGKY"].HeaderText = "ĐĂNG KÝ";
            dataGridViewDKLTC.Columns["DANGKY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            int length = dataGridViewDKLTC.Rows.Count;

            for (int i = 0; i < length - 1; i++)
                if (MALTCDADK.IndexOf(dataGridViewDKLTC.Rows[i].Cells["MALTC"].Value.ToString()) != -1)
                    dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = true;

        }

        private void loadDataGridViewDADK(DataGridView dataGridview)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }
            string sql = "SELECT LTC.MALTC,LTC.MAMH, \n" +
                         " MH.TENMH, \n" +
                         " LTC.NHOM, \n" +
                         " (GV.HO + ' ' + GV.TEN) AS GV\n" +
                         " FROM dbo.LOPTINCHI AS LTC\n" +
                         " LEFT JOIN dbo.MONHOC MH ON MH.MAMH = LTC.MAMH\n" +
                         " LEFT JOIN dbo.GIANGVIEN GV ON GV.MAGV = LTC.MAGV\n" +
                         " LEFT JOIN dbo.DANGKY DK ON DK.MALTC = LTC.MALTC\n" +
                         " LEFT JOIN dbo.SINHVIEN SV ON SV.MASV = DK.MASV\n" +
                         " WHERE (SV.MASV = '" + txtMaSv.Text + "' AND DK.HUYDANGKY = 0) AND (LTC.NIENKHOA = '" + txtNienKhoa.Text + "' AND LTC.HOCKY = " + spHocKi.Text + ")" +
                         " GROUP BY  LTC.MALTC,LTC.MAMH,LTC.NHOM,GV.HO,GV.TEN,MH.TENMH;\n";

            dataTableDADK = Program.ExecSqlQuery(sql);
            dataGridViewDADK.DataSource = dataTableDADK;
            dataGridViewDADK.Columns["MALTC"].Visible = false;

            MALTCDADK = new List<string>();
            for (int i = 0; i < dataTableDADK.Rows.Count; i++)
                MALTCDADK.Add(dataGridViewDADK.Rows[i].Cells["MALTC"].Value.ToString());
        }

        private void btnTimLTC_Click_1(object sender, EventArgs e)
        {


            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }

            this.loadDataGridViewDSMH(dataGridViewDKLTC);
            this.loadDataGridViewDADK(dataGridViewDADK);

            if (dataGridViewDKLTC.RowCount > 0)
            {
                dataGridViewDKLTC.Visible = true;
                pnRight.Visible = true;
            }
        }

        private void btnLuuDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MALTC = dataGridViewDADK.CurrentRow.Cells["MALTC"].Value.ToString();
            int index = MALTCDADK.IndexOf(MALTC);
            if (index != -1)
            {
                dataTableDADK.Rows[index].Delete();
                dataTableDADK.AcceptChanges();
                dataGridViewDADK.DataSource = dataTableDADK;


                int length = dataGridViewDKLTC.Rows.Count;

                for (int i = 0; i < length; i++)
                    if (dataGridViewDKLTC.Rows[i].Cells["MALTC"].Value.ToString().Equals(MALTC))
                        dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = false;

                // xoa khoa MALTC
                MALTCDADK.Remove(MALTC);
            }

        }

        private int posDuplicated(string MAMH,int nhom)
        {
            int pos = -1;
            int length = dataGridViewDADK.Rows.Count;
            for (int i = 0; i < length; i++)
                if (dataGridViewDADK.Rows[i].Cells["MAMH"].Value.Equals(MAMH) && !Convert.ToInt32(dataGridViewDADK.Rows[i].Cells["NHOM"].Value).Equals(nhom))
                    pos = i;

            length = dataTableDKLTC.Rows.Count;
            // bỏ checkbox đăng kí các nhóm còn lại
            for (int i = 0; i < length; i++)
            {
                if (dataGridViewDKLTC.Rows[i].Cells["MAMH"].Value.Equals(MAMH) && !Convert.ToInt32(dataGridViewDKLTC.Rows[i].Cells["NHOM"].Value).Equals(nhom))
                    dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = false;
            }

            return pos;
        }

        private void deleteAndUpdateDataGridViewDaDK(int index)
        {
            // xoá key MALTC trong mảng chứa key ltc
            MALTCDADK.Remove(dataGridViewDADK.Rows[index].Cells["MALTC"].Value.ToString());

            dataTableDADK.Rows[index].Delete();
            dataTableDADK.AcceptChanges();
            dataGridViewDADK.DataSource = dataTableDADK;
        }

        private void addNewRowToDataGridViewDaDK(object []RowValues)
        {
            dataTableDADK.Rows.Add(RowValues);
            dataTableDADK.AcceptChanges();
            dataGridViewDADK.DataSource = dataTableDADK;
        }
        private void dataGridViewDKLTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridViewDKLTC.Columns[e.ColumnIndex].Name == "DANGKY" )
            {
                // set dữ liệu cho cột đăng ký
                dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(Boolean)dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // kiểm tra xem LTC hiện tại đã có trong bảng danh sách đã đăng ký hay chưa
                

                // nếu bấm checkbox đăng ký và bảng danh sách đăng ký chưa có môn này thì thêm vào
                if ((Boolean)dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    Boolean checkExist = MALTCDADK.Contains(dataGridViewDKLTC.Rows[e.RowIndex].Cells["MALTC"].Value.ToString());

                    if (!checkExist)
                    {

                        // kiểm tra xem đã có môn này nhóm khác chưa
                       int pos = this.posDuplicated(dataGridViewDKLTC.Rows[e.RowIndex].Cells["MAMH"].Value.ToString(), Convert.ToInt32(dataGridViewDKLTC.Rows[e.RowIndex].Cells["NHOM"].Value));

                        // đã tồn tại môn này trong bảng danh sách đăng ký => xoá
                        if (pos != -1)
                            deleteAndUpdateDataGridViewDaDK(pos);

                        object[] RowValues = new object[dataGridViewDKLTC.Columns.Count - 2];

                        // không lấy 2 cột cuối cùng của bảng danh sách môn học
                        for (int i = 0; i < dataGridViewDKLTC.Columns.Count - 2; i++)
                            RowValues[i] = dataGridViewDKLTC.Rows[e.RowIndex].Cells[i].Value;

                        // nếu chưa có khoá LTC trong bảng đã đang kí LTC thì thêm vào
                        if (!checkExist) MALTCDADK.Add(RowValues[0].ToString());

                        // thêm dòng mới vào bảng danh sách đăng ký
                        addNewRowToDataGridViewDaDK(RowValues);

                    }
                    
                }
                else
                {
                    int index = MALTCDADK.IndexOf(dataGridViewDKLTC.Rows[e.RowIndex].Cells["MALTC"].Value.ToString());
                    if(index != -1)
                    {
                        dataTableDADK.Rows[index].Delete();
                        dataTableDADK.AcceptChanges();

                        dataGridViewDADK.DataSource = dataTableDADK;
                        // xoa khoa MALTC
                        MALTCDADK.Remove(dataGridViewDKLTC.Rows[e.RowIndex].Cells["MALTC"].Value.ToString());
                    }
                }

            }
        }

        private void dataGridViewDADK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuDangKy.Enabled = btnXoa.Enabled = true;
        }
    }

}