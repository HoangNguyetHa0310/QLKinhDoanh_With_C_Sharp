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
            // con = new SqlConnection();
            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\bài tập môn C#\bài tập về nhà\quanLyKinhDoanh\quanLyKinhDoanh\quanLyKinhDoanh.mdf;
             Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(connectString);
            
            
            // kiểm tra phươn thức kết nối 

            if (con.State != ConnectionState.Open)
            {
                // mở cổng 
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

        // phương thức thực thi câu lệnh ísnert  

        public static void RunSQL (string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = con; // keet noi 
            cmd.CommandText = sql;// cau lenhj sql
            try
            {
                cmd.ExecuteNonQuery(); // thuc th cau lengj sql 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose(); // giai phong bi nho
            cmd = null;
        }

        // ham kiem tra 
        public static bool CheckKey (string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;

            }else
            {
                return false;
            }
        }


     }
}
