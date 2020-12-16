using static System.Console;
using System.Data.SqlClient;

namespace AdoDotNetInsertData
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
                var sql = "insert into Teachers (FirstName, LastName) values ('Test', 'Test')";
                var command = new SqlCommand(sql, connection);

                connection.Open();
                int rowsInserted = command.ExecuteNonQuery();
                if (rowsInserted > 0)
                    WriteLine("Record inserted successfully.");
                else
                    WriteLine("Unable to insert record.");
            }
        }
    }
}
