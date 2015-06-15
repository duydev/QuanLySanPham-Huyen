using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace QLSP.DAO
{
    class SanPhamDAO
    {
        private dbConnection conn;

        public SanPhamDAO()
        {
            conn = new dbConnection();
        }

        public DataTable laySanPham()
        {
            string query = "SELECT * FROM sanpham ORDER BY TenDanhMuc ASC, TenThuongHieu ASC, TenSanPham ASC";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[0];
            return conn.executeSelectQuery(query,sqlParameters);
        }

        public DataTable layDanhMuc()
        {
            string query = "SELECT DISTINCT TenDanhMuc FROM sanpham ORDER BY TenDanhMuc";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable layThuongHieu()
        {
            string query = "SELECT DISTINCT TenThuongHieu FROM sanpham ORDER BY TenThuongHieu";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }


        public DataTable timSanPham(string tensp, string danhmuc = "", string thuonghieu = "")
        {
            string query = @"SELECT * FROM sanpham WHERE TenSanPham LIKE '%" + tensp + "%'";
            if(danhmuc.Length > 0)
                query += @" AND TenDanhMuc IN (" + danhmuc + ")";
            if(thuonghieu.Length > 0)
                query += @" AND TenThuongHieu IN (" + thuonghieu + ")" ;
            query += @" ORDER BY TenDanhMuc ASC, TenThuongHieu ASC, TenSanPham ASC";
            SQLiteParameter[] sqlParamters = new SQLiteParameter[0];
            Console.WriteLine(query);
            return conn.executeSelectQuery(query, sqlParamters); 
        }

        public bool themSanPham(string tensp, string tendm, string tenth, int si10, int si20, int le)
        {
            string query = "INSERT INTO sanpham(TenSanPham, TenDanhMuc, TenThuongHieu, Si10, Si20, Le) VALUES (@tensp, @tendm, @tenth, @Si10, @Si20, @Le)";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[6];
            sqlParameters[0] = new SQLiteParameter("@tensp", tensp);
            sqlParameters[1] = new SQLiteParameter("@tendm", tendm);
            sqlParameters[2] = new SQLiteParameter("@tenth", tenth);
            sqlParameters[3] = new SQLiteParameter("@si10", si10);
            sqlParameters[4] = new SQLiteParameter("@si20", si20);
            sqlParameters[5] = new SQLiteParameter("@le", le);
            return conn.executeInsertQuery(query, sqlParameters);
        }

        public bool xoaSanPham()
        {
            string query = "DELETE FROM sanpham";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[0];
            return conn.excuteDeleteQuery(query, sqlParameters);
        }
        
        public bool xoaSanPham(string tensp)
        {
            string query = "DELETE FROM sanpham WHERE TenSanPham = @tensp";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[1];
            sqlParameters[0] = new SQLiteParameter("@tensp", tensp);
            return conn.excuteDeleteQuery(query, sqlParameters);
        }

        public bool suaSanPham(string tenspcu, string tenspmoi, string tendm, string tenth, int si10, int si20, int le)
        {
            string query = "UPDATE sanpham SET TenSanPham = @tenspmoi, TenDanhMuc = @tendm, TenThuongHieu = @tenth, Si10 = @Si10, Si20 = @Si20, Le = @Le WHERE TenSanPham = @tenspcu";
            SQLiteParameter[] sqlParameters = new SQLiteParameter[7];
            sqlParameters[0] = new SQLiteParameter("@tenspmoi", tenspmoi);
            sqlParameters[1] = new SQLiteParameter("@tendm", tendm);
            sqlParameters[2] = new SQLiteParameter("@tenth", tenth);
            sqlParameters[3] = new SQLiteParameter("@si10", si10);
            sqlParameters[4] = new SQLiteParameter("@si20", si20);
            sqlParameters[5] = new SQLiteParameter("@le", le);
            sqlParameters[6] = new SQLiteParameter("@tenspcu", tenspcu);
            return conn.executeUpdateQuery(query, sqlParameters);
        }
     

     


    }
}
