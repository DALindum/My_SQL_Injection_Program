using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Inject_Project
{
    public class Person
    {
        public void getAllPersons()
        {
            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    String sql = "SELECT FirstName, LastName, Age, Email FROM dbo.Person";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}, {1}, {2}, {3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void searchFirstName(string firstName)
        {
            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    String query = $"SELECT '{firstName}', LastName, Age, Email FROM dbo.Person";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
