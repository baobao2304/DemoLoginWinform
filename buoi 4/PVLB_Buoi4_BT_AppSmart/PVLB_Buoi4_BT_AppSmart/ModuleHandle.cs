using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace PVLB_Buoi4_BT_AppSmart
{
    class ModuleHandle
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.ABC == string.Empty)
                return 1;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ABC);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;
            }
            catch { 
                return 2;
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap='"+pUser+"' and MatKhau = '"+pPass+"'",Properties.Settings.Default.ABC);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 1;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "0")
                return 2;
            return 0;
        }
        public DataTable getServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable getDatabaseName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source =" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + ""); 
            da.Fill(dt); 
            return dt;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.ABC = "Data Source=" + pServer + ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + ""; 
            Properties.Settings.Default.Save();
        }
    }
}
