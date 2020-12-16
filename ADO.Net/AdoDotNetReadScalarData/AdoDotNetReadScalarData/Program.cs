using static System.Console;
using System.Data.SqlClient;

namespace AdoDotNetReadScalarData
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString =
                @"Data Source=(localdb)\ProjectsV13;"
                + "Initial Catalog=Trinity;"
                + "Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "select count(*) from Students";
                var command = new SqlCommand(sql, connection);

                connection.Open();
                var studentCount = command.ExecuteScalar();
                WriteLine($"Student Count = {studentCount}");
            }
        }
    }
}
