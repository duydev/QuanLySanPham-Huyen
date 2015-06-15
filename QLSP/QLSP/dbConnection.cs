using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


namespace QLSP
{
    class dbConnection
    {
        private SQLiteConnection conn;
        private SQLiteDataAdapter myAdapter;

        public dbConnection()
        {
            string dbConnectionString = @"Data Source=storage.s3db;Version=3;UTF8Encoding=True;";
            conn = new SQLiteConnection(dbConnectionString);
        }

        public SQLiteConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                conn.Open();
            return conn;
        }

        public DataTable executeSelectQuery(string query, SQLiteParameter[] sqlParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            myAdapter = new SQLiteDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = null;
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlParameters);
                cmd.ExecuteNonQuery();
                myAdapter.SelectCommand = cmd;
                myAdapter.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                return null;
            }
            return dt;
        }

        public bool executeInsertQuery(string query, SQLiteParameter[] sqlParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            myAdapter = new SQLiteDataAdapter();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlParameters);
                myAdapter.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("INSERT ERROR: " + e.Message);
                return false;
            }
            return true;
        }

        public bool executeUpdateQuery(string query, SQLiteParameter[] sqlParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            myAdapter = new SQLiteDataAdapter();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlParameters);
                myAdapter.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("UPDATE ERROR:" + e.Message);
                return false;
            }
            return true;
        }

        public bool excuteDeleteQuery(string query, SQLiteParameter[] sqlParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            myAdapter = new SQLiteDataAdapter();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlParameters);
                myAdapter.DeleteCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
