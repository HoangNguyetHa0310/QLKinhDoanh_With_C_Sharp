using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanLyKinhDoanh.Class;


namespace quanLyKinhDoanh
{
    public partial class frmDangNhap : Form
    {
        public static SqlConnection con;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
private void btnLogin_Click_1(object sender, EventArgs e)
{
   string tk = txtUser.Text;
   string mk = txtPass.Text;
   string sql = "SELECT * FROM quanLyKinhDoanh WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";
   SqlCommand cmd = new SqlCommand(sql, con);
   SqlDataReader dta = cmd.ExecuteReader();
   if (dta.Read() == true)
   {
       MessageBox.Show("Đăng Nhập Thành Công ! ","Thông Báo ",MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
   else
   {
       MessageBox.Show("Đăng Nhập Thất Bại ! ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
}

*/



    }
}
