using System;
using System.Data.SqlClient;

namespace ToneLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DBConn newConn= new DBConn();
            string dataSource = @"DESKTOP-RF8B7LP\SQLEXPRESS";
            string database = "Library";
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder(@"Data Source=" + dataSource + ";Initial Catalog="
                     + database + ";Persist Security Info=True;Trusted_Connection=True;");
            //User ID = tzamba; Password = password

            SqlConnection conn  = new SqlConnection(connString.ConnectionString);

            string queryString = "INSERT INTO dbo.students (name, surname, gender, birthdate, class, point) VALUES ('jesse', 'powell', 'male','5/1/1983','Freshman', 8);";


            SqlCommand command = new SqlCommand(queryString, conn);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
           


        }

        public static string replace(string item, char delimiter, char selection)
        {

            char[] array = item.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == delimiter)
                {
                    array[i] = selection;
                }
            }

            string newItem = new string(array);

            return newItem;

        }
    }
}
