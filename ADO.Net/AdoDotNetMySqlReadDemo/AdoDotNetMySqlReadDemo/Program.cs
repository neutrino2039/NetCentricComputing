using MySql.Data.MySqlClient;
using static System.Console;

namespace AdoDotNetMySqlReadDemo
{
    class Program
    {
        static void Main()
        {
            var connectionString =
                "Server = localhost;"
                + "Database = trinity;"
                + "Uid = root;"
                + "Pwd = ";
            using (var connection = new MySqlConnection(connectionString))
            {
                var sql = "select * from students";
                var command = new MySqlCommand(sql, connection);

                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    WriteLine($"Id = {reader["id"]}");
                    WriteLine($"First Name = {reader["first_name"]}");
                    WriteLine($"Last Name = {reader["last_name"]}");
                    WriteLine();
                }
            }
        }
    }
}
