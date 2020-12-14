using System.Data.SqlClient;
using static System.Console;

namespace AdoDotNetReadDemo
{
    class Program
    {
        static void Main()
        {
            var connectionString =
                @"Data Source=.;"
                + "Initial Catalog=Trinity;"
                + "Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "select * from Students";
                var command = new SqlCommand(sql, connection);

                connection.Open();
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    WriteLine($"Id = {reader["Id"]}");
                    WriteLine($"First Name = {reader["FirstName"]}");
                    WriteLine($"Last Name = {reader["LastName"]}");
                    WriteLine();
                }
            }
        }
    }
}
