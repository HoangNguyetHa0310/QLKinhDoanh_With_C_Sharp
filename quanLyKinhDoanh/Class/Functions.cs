using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanLyKinhDoanh.Class
{
    class Functions
    {
        public static SqlConnection con;
        // khoi tao phuong thuc connect 

        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.quanLyKinhDoanhConnectionString;
            // kiểm tra phươn thức kết nối 

            if (con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Kết nối thành công !");
            }
            else
            {
                MessageBox.Show("Kết nối không thành công ! ");
            }
        }
         //  Dừng việc kết nối 
         public static void Disconnect ()
         {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
         }

        // phuong thuc thực thi câu lênh 

        public static DataTable GetDataToTable (string sql) 
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql , con);
            dap.Fill(table);
            return table;
        }

    }
}
