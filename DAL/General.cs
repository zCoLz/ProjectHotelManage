using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class General
    {
        public SqlConnection conn = new SqlConnection(@"Data source=LAPTOP-NC0J59B5\SQLEXPRESS;Initial catalog=QLKS1;Integrated security=True");
        public string user_nhanvien = "";
    }
}

