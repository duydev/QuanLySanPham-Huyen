using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace QLSP.DAO
{

    class NguoiDungDAO
    {
        private dbConnection conn;
        public NguoiDungDAO()
        {
            conn = new dbConnection();
        }

        public DataTable layNguoiDung(string tendangnhap)
        {
            string query = @"SELECT * FROM nguoidung WHERE tendangnhap = @tendangnhap";
            SQLiteParameter[] sqlParamerters = new SQLiteParameter[1];
            sqlParamerters[0] = new SQLiteParameter("@tendangnhap", tendangnhap);
            return conn.executeSelectQuery(query, sqlParamerters);
        }
    }
}
