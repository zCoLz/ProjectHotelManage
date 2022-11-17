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
using BEL;
using Microsoft.Reporting.WinForms;

namespace ProjectDA
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            this.rpvThongKe.RefreshReport();
        }
        public SqlConnection conn = new SqlConnection(@"Data source=LAPTOP-NC0J59B5\SQLEXPRESS;Initial catalog=QLKS1;Integrated security=True");
        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select H.MAHOADON,P.MAPHG,N.HOTENNV,K.HOTENKH,L.TENLOAI, P.GIA, FORMAT(H.NGAYDK,'dd/MM/yyyy') as NGAYDK ,FORMAT(H.NGAYKT,'dd/MM/yyyy') as NGAYKT,IIF(DATEDIFF(Day,H.NGAYDK,H.NGAYKT) = 0 , 1 , DATEDIFF(Day,H.NGAYDK,H.NGAYKT)) as SONGAYO ,FORMAT(H.TONG,'N0') as TONG " +
                "from HOADON H, NHANVIEN N, LOAIPHONG L, KHACHHANG K, PHONG P " +
                "where P.MAPHG in (select MAPHG from PHONG where MAPHG like H.MAPHG) and N.HOTENNV in(select HOTENNV from NHANVIEN where MANV like H.MANV) and K.HOTENKH in (select HOTENKH from KHACHHANG where MAKH like H.MAKH) and L.TENLOAI in(select TENLOAI from LOAIPHONG where IDLOAI like P.LOAIPHG) " +
                "and H.NGAYKT is not null and H.NGAYKT >= H.NGAYDK " +
                "and H.TONG > 0", conn);
            SqlDataAdapter d = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            d.Fill(dt);

            rpvThongKe.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            rpvThongKe.LocalReport.ReportPath = @"C:\Users\TanLoc\source\repos\ProjectDA\ProjectDA\Report1.rdlc";
            rpvThongKe.LocalReport.DataSources.Add(source);
            rpvThongKe.RefreshReport();
        }
    }
}
