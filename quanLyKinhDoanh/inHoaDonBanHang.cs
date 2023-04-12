using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using quanLyKinhDoanh.Class;


namespace quanLyKinhDoanh
{
    public partial class inHoaDonBanHang : Form
    {
        SqlConnection con;
        DataTable tblCTHDB;

        public inHoaDonBanHang()
        {
            InitializeComponent();
        }

        public inHoaDonBanHang(int HoaDonBan)
        {

            InitializeComponent();
            quanLyKinhDoanh.tblChiTietHDBanDataTable b = new quanLyKinhDoanh.tblChiTietHDBanDataTable();
            quanLyKinhDoanhTableAdapters.tblChiTietHDBanTableAdapter a = new quanLyKinhDoanhTableAdapters.tblChiTietHDBanTableAdapter();
            b.Reset();
            a.Fill(b);




            RPHoaDonBan rp = new RPHoaDonBan();
            rp.SetDataSource((DataTable)b);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();

        }



        private void inHoaDonBanHang_Load(object sender, EventArgs e)
        {
            /*
            DataTable dta = new DataTable();
            con conn = new con();
            string sql;
            sql = "SELECT * from tblChiTietHDBan";
            tblCTHDB = Functions.GetDataToTable(sql);
            inHoaDonBanHang rp = new inHoaDonBanHang();
            
            */
            
        }
    }
}
