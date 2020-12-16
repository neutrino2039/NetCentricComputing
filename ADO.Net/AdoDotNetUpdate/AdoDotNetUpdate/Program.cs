using static System.Console;
using System.Data.SqlClient;

namespace AdoDotNetUpdate
{
    class Program
    {
        static void Main()
        {
            var connectionString =
                @"Data Source=(localdb)\ProjectsV13;"
                + "Initial Catalog=Trinity;"
                + "Integrated Security=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "update Teachers set FirstName = 'Test (edited)', LastName = 'Test (edited 2)' where Id = 3";
                var command = new SqlCommand(sql, connection);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    WriteLine("Record updated successfully.");
                else
                    WriteLine("Unable to update record.");
            }
        }
    }
}
