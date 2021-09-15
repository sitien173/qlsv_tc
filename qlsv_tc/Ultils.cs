using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv_tc
{
    class Ultils
    {
        public static string GetMaKhoa()
        {
            DataTable dt = new DataTable();
            BindingSource bds = new BindingSource();
            dt = Program.ExecSqlQuery("SELECT MAKHOA FROM KHOA");
            bds.DataSource = dt;
            return ((DataRowView)bds[0])["MAKHOA"].ToString();
        }
        public static void BindingDataToComBo(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "TENKHOA";
            combo.ValueMember = "TENSERVER";

           
            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            combo.SelectedIndex = Program.mKhoa;
        }
        // hỗ trợ trong combobox chọn chi nhánh
        public static void ComboboxHelper(ComboBox cmb)
        {
            // bắt lỗi khi giá trị của selectedvalue = "sysem.data.datarowview"  ==> lỗi hay gặp của combobox winform
            if (cmb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            // gán server đã chọn vào biến toàn cục.
            Program.servername = cmb.SelectedValue.ToString();
            Console.WriteLine("Servername : " + Program.servername);

            // đoạn code hỗ trợ chuyển chi nhánh
            // ở chi nhánh A qua B thì dùng RemoteLogin,
            if (cmb.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            { // ở B về lại A dùng login ban đầu
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mPasswordDN;
            }
        }
    }
}
