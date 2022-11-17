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
    public class DAL_DangNhap : General
    {
        DataTable dt = new DataTable();
        public DataTable FindNhanVienByUser(string user)
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select USERNAME, MANV, HOTENNV from NHANVIEN WHERE USERNAME = '" + user + "'", conn);
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
        public DataTable FindNhanVienByMa(string MaNV)
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select USERNAME, MANV, HOTENNV from NHANVIEN WHERE MANV = '" + MaNV + "'", conn);
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
        public bool checklogin(string user, string pass)
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN where USERNAME = '" + user + "' and PASS = '" + pass + "'", conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count == 1)
                {

                    return true;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
