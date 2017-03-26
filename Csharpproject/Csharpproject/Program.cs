using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Csharpproject
{
    class Program
    {

        static void Main(string[] args)
        {
            String emailname, pass;
            emailname = Console.ReadLine();
            pass = "insert into Anubhav (email) values('" + emailname + "');";
            Console.WriteLine(pass);
            CreateCommand(pass, "Data Source=ANUBHAV\\ANUBHAV;Initial Catalog=master;User ID=sa;Password=Anubh@v0162");

            testclass a = new testclass();
            Console.WriteLine(a.add(10, 34));
            // CreateCommand("select * from Anubhav", "Data Source=ANUBHAV\\ANUBHAV;User ID=sa;Password=Anubh@v0162");
        }

        private static void CreateCommand(string queryString,
    string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                Console.WriteLine("Connecting to the database...");
                try
                {
                    command.Connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        Console.WriteLine("Rows affecteds successfully");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine(reader.GetValue(i));
                                    Console.ReadKey();
                                }

                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Cannot write to the DB");
                }



            }
        }
    }
}
