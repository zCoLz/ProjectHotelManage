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
    public class DAL_NhanVien : General
    {
        DataTable dt = new DataTable();
        public DataTable DocDSNhanVien()
        {

            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select MANV, HOTENNV, NGAYSINH, GIOITINH, DIACHI, PHONE,USERNAME ,PASS from NHANVIEN", conn);
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
        public bool themNhanVien(BEL_NhanVien nv)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "INSERT INTO NHANVIEN(MANV, HOTENNV,GIOITINH,NGAYSINH,  DIACHI, PHONE , USERNAME, PASS)" +
                    " values('" + nv.Id + "',N'" + nv.Name + "',N'" + nv.Sex + "',N'" + nv.DateBirth.ToString("yyyy/MM/dd") +
                    "',N'" + nv.Address + "',N'" + nv.Phone + "',N'" + nv.User + "',N'" + nv.Pass + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ketQua = true;
                }
            }
            catch (Exception)
            {
            }
            return ketQua;
        }
        public bool updateNV(string MaNV, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string SĐT, string User, string Pass)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update NHANVIEN set HOTENNV = N'" + hoTen + "',GIOITINH =N'" + gioiTinh
                    + "',NGAYSINH = '" + ngaySinh.ToString("yyyy/MM/dd") + "',DIACHI =N'"
                    + diaChi + "',PHONE=N'" + SĐT + "',USERNAME=N'" + User + "',PASS =N'" + Pass + "'WHERE MANV = '" + MaNV + "'";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ketQua = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return ketQua;
        }
        public bool deleteNV(string maNV)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "DELETE FROM NHANVIEN WHERE  MANV='" + maNV + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    ketQua = true;
            }
            catch (Exception err)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ketQua;
        }
        public DataTable TimKiem(string keyword)
        {
            dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select MANV, HOTENNV, NGAYSINH, GIOITINH, DIACHI, PHONE,USERNAME,PASS from NHANVIEN WHERE MANV LIKE '%" +
                keyword + "%' or HOTENNV LIKE '%" + keyword + "%'", conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

    }
}
