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
    public class DAL_KhachHang : General
    {
        DataTable dt = new DataTable();
        public DataTable DocDSKhachHang()
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select MAKH,HOTENKH,NGAYSINH,GIOITINH,DIACHI,PHONE,CMND,QUOCTICH FROM KHACHHANG ", conn);
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
        //Thêm Khách Hàng
        public bool themKhachHang(BEL_KhachHang kh)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "INSERT INTO KHACHHANG(MAKH,HOTENKH,NGAYSINH,GIOITINH,DIACHI,PHONE,CMND,QUOCTICH)" +
                    "VALUES ('" + kh.MaKH + "',N'" + kh.HoTenKH + "',N'" + kh.NgaySinh.ToString("yyyy/MM/dd") + "',N'" + kh.Sex + "',N'" +
                    kh.Address + "',N'" + kh.Phone + "',N'" + kh.Cmnd + "',N'" + kh.QuocTich + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql,conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ketQua = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return ketQua;

        }

        public bool updateKH(string MaKH, string hoTenKH, DateTime ngaySinh, string gioiTinh, string diaChi, string SĐT, string CMND, string QuocTich)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update KHACHHANG set HOTENKH = N'" + hoTenKH + "',GIOITINH =N'" + gioiTinh
                    + "',NGAYSINH = '" + ngaySinh.ToString("yyyy/MM/dd") + "',DIACHI =N'"
                    + diaChi + "',PHONE=N'" + SĐT + "',CMND=N'" + CMND + "',QUOCTICH =N'" + QuocTich + "'WHERE MAKH = '" + MaKH + "'";
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
        public bool deleteKH(string maKH)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "DELETE FROM KHACHHANG WHERE  MAKH='" + maKH + "'";
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
        //Tìm Kiếm Khách Hàng
        public DataTable TimKiem(string keyword)
        {
            dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select MAKH, HOTENKH, NGAYSINH, GIOITINH, DIACHI, PHONE,CMND,QUOCTICH from KHACHHANG WHERE MAKH LIKE '%" +
                keyword + "%' or HOTENKH LIKE '%" + keyword + "%'", conn);
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
        public string GetNameKH(string MaKH)
        {
            string name = "";
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select HOTENKH FROM KHACHHANG where MAKH = '"+MaKH+"'", conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if(dt.Rows.Count == 1)
                {
                    return dt.Rows[0].ItemArray[0].ToString();
                }
            }
            catch (Exception)
            {
                return name;
            }
            return name;
        }
    }
}
