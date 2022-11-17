using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;

namespace DAL
{
    public class DAL_Loai:General
    {
        DataTable dt = new DataTable();
        public DataTable DocDanhSachLoai()
        {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from  LOAIPHONG", conn);
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    return dt;
                }
                catch (Exception)
                {

                    throw;
                }
        }
    }
}
