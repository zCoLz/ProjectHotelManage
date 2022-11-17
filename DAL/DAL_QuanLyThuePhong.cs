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
     public class DAL_QuanLyThuePhong : General
    {
        DataTable dt = new DataTable();
        public DataTable DanhSachThuePhong()
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select MAHOADON,MANV,MAPHG,MAKH,NGAYDK,NGAYKT from HOADON where Display = 0", conn);
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
        public bool thuePhong( BEL_QuanLyThuePhong tp){

            bool ketQua = false;
            try {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = (" insert into HOADON(MANV,MAPHG,MAKH,NGAYDK,NGAYKT) Values" +
                    " ('" + tp.MaNV + "','" + tp.MaPHG + "','" + tp.MaKH + "','" + tp.Ngaydatphong.ToString("yyyy/MM/dd") + "','" +  tp.Ngaytraphong.ToString("yyyy/MM/dd")+"')");
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
            return ketQua;
        }
        public bool thuePhong_KoNgayKT(BEL_QuanLyThuePhong tp)
        {

            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = ("insert into HOADON(MANV,MAPHG,MAKH,NGAYDK,Display) Values" +
                    " ('" + tp.MaNV + "','" + tp.MaPHG + "','" + tp.MaKH + "','" + tp.Ngaydatphong.ToString("yyyy/MM/dd") + "','0')");
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
            return ketQua;
        }
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
            return ketQua;
        }
        public bool TraPhong(string maHĐ,DateTime NgayKT)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = ("update HOADON set  NGAYKT = '" + NgayKT.ToString("yyyy/MM/dd") + "' Where MAHOADON = '" + maHĐ + "'");
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
            return ketQua;
        }
        public bool SetRollQLThuePhong(string display, string roll)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update HOADON set  = '" + roll + "' where Display= '" + display + "'";
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
        public bool Settonghoadon(string mahoadon, double tong)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update HOADON set TONG = '" + tong.ToString("#.##") + "' where MAHOADON = '" + mahoadon + "'";
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
        public double gettonghoadon(string mahoadon)
        {
            double gia = 0;
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select TONG from HOADON Where MAHOADON = '" + mahoadon + "'", conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count == 1)
                {
                    gia = double.Parse(dt.Rows[0].ItemArray[0].ToString());
                    return gia;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public bool deleteThuePhong(string maHD)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "update HOADON set Display = '1' where MAHOADON = '"+maHD+"'";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    ketQua = true;
            }
            catch (Exception err)
            {
                ketQua = false;
            }
            finally
            {
                conn.Close();
            }
            return ketQua;
        }
    }
}

