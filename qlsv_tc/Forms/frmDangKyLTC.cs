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
        private static int countRowChange = 0; // nếu có sự thay đổi dòng thì bật nút ghi 
        public frmDangKyLTC()
        {
            InitializeComponent();
        }
        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            pnThongTinSV.Enabled = false;
            pnThongTinLTC.Visible = false;
            pnRight.Visible = false;

            // auto focus textbox
            this.ActiveControl = txtMaSv;
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
                        pnThongTinLTC.Visible = true;
                    }else
                    {
                        MessageBox.Show("Mã SV Không Tồn Tại");
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
            string sql = "EXEC SP_GetDanhSachDkyLTC " +
                "@nienkhoa = '" + txtNienKhoa.Text + "'," +
                "@hocki = " + spHocKi.Text + "";


            dataTableDKLTC = Program.ExecSqlQuery(sql);

            // thêm 1 cột checkbox đăng ký

            DataColumn colDangKy = new DataColumn("DANGKY");
            colDangKy.DataType = System.Type.GetType("System.Boolean");
            colDangKy.DefaultValue = false;
            dataTableDKLTC.Columns.Add(colDangKy);

            dataGridViewDKLTC.DataSource = dataTableDKLTC;

            dataGridViewDKLTC.Columns["MALTC"].Visible = false;
            dataGridViewDKLTC.Columns["MAGV"].Visible = false;

            dataGridViewDKLTC.Columns["DANGKY"].HeaderText = "ĐĂNG KÝ";
            dataGridViewDKLTC.Columns["DANGKY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dataTableDKLTC.PrimaryKey = new DataColumn[] { dataTableDKLTC.Columns["MALTC"] };

            // Nếu tìm thấy cùng lớp tín chỉ đã đki trước đó của sinh viên thì đánh dấu vào checkbox DANGKY
            for (int i = 0; i < dataGridViewDKLTC.Rows.Count; i++)
            {
                DataRow dataRow = dataTableDADK.Rows.Find(dataGridViewDKLTC.Rows[i].Cells["MALTC"].Value);
                if (dataRow != null)
                    dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = true;       
            }
        }

        private void loadDataGridViewDADK(DataGridView dataGridview)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }
            string sql = "EXEC SP_GetDanhSachDkyLTCSV " +
                         "@masv = '" + txtMaSv.Text + "'," +
                         "@nienkhoa = '" + txtNienKhoa.Text + "'," +
                         "@hocki = " + spHocKi.Text + "";
               

            dataTableDADK = Program.ExecSqlQuery(sql);
            dataGridViewDADK.DataSource = dataTableDADK;
            dataGridViewDADK.Columns["MALTC"].Visible = false;
            dataGridViewDADK.Columns["MAGV"].Visible = false;

            dataTableDADK.PrimaryKey = new DataColumn[] { dataTableDADK.Columns["MALTC"] };

            // lưu lại số dòng hiện tại vào biến để kiểm tra sự thay đổi 
            countRowChange = dataTableDADK.Rows.Count;

            // loại bỏ focus vào dòng đầu tiên khi load xong
            if (countRowChange > 0)
            {
                dataGridViewDADK.ClearSelection();
                dataGridViewDADK.CurrentCell = null;  
            }
            btnLuuDangKy.Enabled = btnXoa.Enabled = false;
        }

        private void btnTimLTC_Click_1(object sender, EventArgs e)
        {
            if (Program.KetNoi() != 1)
            {
                MessageBox.Show("Kết nối tới csdl thất bại");
                return;
            }

            this.loadDataGridViewDADK(dataGridViewDADK);
            this.loadDataGridViewDSMH(dataGridViewDKLTC);

            if (dataGridViewDKLTC.RowCount > 0)
            {
                dataGridViewDKLTC.Visible = true;
                pnRight.Visible = true;
            }
        }

        private void btnLuuDangKy_Click(object sender, EventArgs e)
        {

        }

      
        private void autoEnableButton()
        {
            // loại bỏ focus vào dòng đầu tiên
            dataGridViewDADK.ClearSelection();
            dataGridViewDADK.CurrentCell = null;

            int count = dataTableDADK.Rows.Count;
            if ( count != countRowChange)
            {
                btnLuuDangKy.Enabled = true;
                if (count == 0) btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(dataTableDADK.Rows.Count > 0)
            {
                string MALTC = dataGridViewDADK.CurrentRow.Cells["MALTC"].Value.ToString();
                // xoá khỏi hàng danh sách đăng ký môn
                deleteAndUpdateDataGridView(dataTableDADK, dataGridViewDADK, MALTC);

                // bỏ check đăng kí ở bảng danh sách môn học
                int length = dataGridViewDKLTC.Rows.Count;
                for (int i = 0; i < length; i++)
                    if (dataGridViewDKLTC.Rows[i].Cells["MALTC"].Value.ToString().Equals(MALTC))
                        dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = false;
            }
           
        }

        private void DeleteDuplicatedDataGridViewDK(string MAMH,string MAGV,int NHOM)
        {
            for (int i = 0; i < dataGridViewDADK.Rows.Count; i++)
            {
                // nếu cùng môn học cùng giáo viên dạy mà khác nhóm thì chỉ cho đăng kí 1 nhóm
                if (dataGridViewDADK.Rows[i].Cells["MAMH"].Value.Equals(MAMH) &&
                    dataGridViewDADK.Rows[i].Cells["MAGV"].Value.Equals(MAGV) &&
                    !Convert.ToInt32(dataGridViewDADK.Rows[i].Cells["NHOM"].Value).Equals(NHOM))
                {
                    // đã tồn tại môn này trong bảng danh sách đăng ký => xoá
                    deleteAndUpdateDataGridView(dataTableDADK, dataGridViewDADK, dataGridViewDADK.Rows[i].Cells["MALTC"].Value.ToString());
                }
            }
                
                   
            // bỏ checkbox đăng kí các nhóm còn lại
            for (int i = 0; i < dataTableDKLTC.Rows.Count; i++)
            {
                if (dataGridViewDKLTC.Rows[i].Cells["MAMH"].Value.Equals(MAMH) &&
                    dataGridViewDKLTC.Rows[i].Cells["MAGV"].Value.Equals(MAGV) &&
                    !Convert.ToInt32(dataGridViewDKLTC.Rows[i].Cells["NHOM"].Value).Equals(NHOM))
                    dataGridViewDKLTC.Rows[i].Cells["DANGKY"].Value = false;
            }
        }

        private void deleteAndUpdateDataGridView(DataTable dataTable,DataGridView dataGridView,string MALTC)
        {
            DataRow foundRows = dataTable.Rows.Find(MALTC);
            dataTable.Rows.Remove(foundRows);
            dataTable.AcceptChanges();
            dataGridView.DataSource = dataTable;

            this.autoEnableButton();
        }

        private void addNewRowToDataGridViewDaDK(object []RowValues)
        {
            try
            {
                dataTableDADK.Rows.Add(RowValues);
                dataTableDADK.AcceptChanges();
                dataGridViewDADK.DataSource = dataTableDADK;
            }
            catch (System.Data.ConstraintException e)
            {
                // thêm vào trùng khoá thì ko cho thêm
            }
            this.autoEnableButton();
        }
        private void dataGridViewDKLTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridViewDKLTC.Columns[e.ColumnIndex].Name == "DANGKY" )
            {
                // set dữ liệu cho cột đăng ký
                dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(Boolean)dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                // nếu bấm checkbox đăng ký và bảng danh sách đăng ký chưa có môn này thì thêm vào
                if ((Boolean)dataGridViewDKLTC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    string MAMH = dataGridViewDKLTC.Rows[e.RowIndex].Cells["MAMH"].Value.ToString();
                    string MAGV = dataGridViewDKLTC.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
                    int NHOM = Convert.ToInt32(dataGridViewDKLTC.Rows[e.RowIndex].Cells["NHOM"].Value);
                    DeleteDuplicatedDataGridViewDK(MAMH, MAGV, NHOM);

                    object[] RowValues = new object[dataGridViewDKLTC.Columns.Count - 2];
                    // không lấy 2 cột cuối cùng của bảng danh sách môn học
                    for (int i = 0; i < dataGridViewDKLTC.Columns.Count - 2; i++)
                        RowValues[i] = dataGridViewDKLTC.Rows[e.RowIndex].Cells[i].Value;
                    // thêm dòng mới vào bảng danh sách đăng ký 
                    addNewRowToDataGridViewDaDK(RowValues);
                }
                else 
                    deleteAndUpdateDataGridView(dataTableDADK, dataGridViewDADK, dataGridViewDKLTC.Rows[e.RowIndex].Cells["MALTC"].Value.ToString());

            }
        }

        private void dataGridViewDADK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void txtMaSv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtMaSv.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sv");
                    return;
                }
                this.btnTimKiem.PerformClick();
            }
        }
    }

}