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
    public class DAL_Phong: General
    {
        DataTable dt = new DataTable();
        public DataTable DocDanhSachPhong()
        {
            if (ConnectionState.Closed ==conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select P.MAPHG,T.TENTTRANG, L.TENLOAI, FORMAT(P.GIA,'N0') as GIA, P.ROLL" +
                " from PHONG P, TINHTRANG T, LOAIPHONG L where T.TENTTRANG in (select TENTTRANG from TINHTRANG where IDTTRANG like P.TTRANG)" +
                " and L.TENLOAI in (select TENLOAI from LOAIPHONG where IDLOAI like P.LOAIPHG) and P.ROLL >= 0 order by MAPHG", conn);
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
        public DataTable DocDanhSachPhong_rong()
        {
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select P.MAPHG,T.TENTTRANG, L.TENLOAI, P.GIA, P.ROLL" +
                " from PHONG P, TINHTRANG T, LOAIPHONG L where T.TENTTRANG in (select TENTTRANG from TINHTRANG where IDTTRANG like P.TTRANG)" +
                " and L.TENLOAI in (select TENLOAI from LOAIPHONG where IDLOAI like P.LOAIPHG) and P.ROLL = 0 AND P.TTRANG = 1 order by MAPHG", conn);
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
        public bool themPhong(BEL_Phong p)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                {
                    conn.Open();
                }
                string sql = "INSERT INTO PHONG(MAPHG,LOAIPHG,TTRANG,GIA) VALUES " +
                    "('" + p.MaPhong + "',N'" + p.LoaiPhong + "','" + p.TinhTrang + "',N'" + p.Gia + "')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery()>0)
                {
                    ketQua = true;
                }
            }
            catch (Exception)
            {
            }
            return ketQua;
        }
        public bool updatePhong(string maPhong, string loaiPhong, string tinhTrang, string gia)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update PHONG set LOAIPHG =N'" + loaiPhong
                    + "',TTRANG =N'"+ tinhTrang + "',GIA = '" + gia + "'WHERE MAPHG = '" + maPhong + "'";
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
        public bool SetRollPhong(string maPhong, string roll)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update PHONG set ROLL = '"+roll+"' where MAPHG = '"+maPhong+"'";
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
        public bool deletePhong(string maPHG)
        {
            bool ketQua = false;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                string sql = "Update PHONG set ROLL = '-1' where MAPHG LIKE '"+ maPHG + "'";
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
        public DataTable TimKiem(string keyword)
        {
            dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            //SqlCommand cmd = new SqlCommand("select MAPHG, LOAIPHG,TTRANG,GIA,ROLL from PHONG WHERE MAPHG LIKE '%" +
            //    keyword + "%' or LOAIPHG LIKE '%" + keyword + "%'", conn);
            SqlCommand cmd = new SqlCommand("select P.MAPHG,T.TENTTRANG, L.TENLOAI, P.GIA, P.ROLL" +
               " from PHONG P, TINHTRANG T, LOAIPHONG L where T.TENTTRANG in (select TENTTRANG from TINHTRANG where IDTTRANG like P.TTRANG)" +
               " and L.TENLOAI in (select TENLOAI from LOAIPHONG where IDLOAI like P.LOAIPHG) and P.ROLL >= 0 and P.MAPHG in (select MAPHG from PHONG WHERE MAPHG LIKE '%" +
                keyword + "%' or LOAIPHG LIKE '%" + keyword + "%') order by MAPHG ", conn);
            Console.WriteLine(cmd);
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
        public double getGia_Phong(string maPHG)
        {
            double gia = 0;
            if (ConnectionState.Closed == conn.State)
                conn.Open();
            SqlCommand cmd = new SqlCommand("select GIA from PHONG Where MAPHG = '" + maPHG + "'", conn);
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

    }


}
