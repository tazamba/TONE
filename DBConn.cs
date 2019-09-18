﻿using System;
using System.Data.SqlClient;

namespace ToneLab1
{
    class DBConn
    {

       private static string dataSource = @"DESKTOP-RF8B7LP\SQLEXPRESS";
       private static string database = "Library";

       private string connString = @"Data Source=" + dataSource + ";Initial Catalog="
                    + database + ";Persist Security Info=True;";

        public SqlConnection conn;

        public DBConn()
        {
            this.conn = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");

            }catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }

        public void close()
        {
            conn.Close();
        }
    }
}
