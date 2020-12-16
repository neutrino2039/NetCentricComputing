using static System.Console;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNetDataAdapterReadDemo
{
    class Program
    {
        static void Main()
        {
            var connectionString =
                @"Data Source=(localdb)\ProjectsV13;"
                + "Initial Catalog=Trinity;"
                + "Integrated Security=True;";
            var sql = "select * from Students";
            using (var adapter = new SqlDataAdapter(sql, connectionString))
            {
                var table = new DataTable();
                adapter.Fill(table);
                foreach(DataRow row in table.Rows)
                {
                    WriteLine($"Id = {row["Id"]}");
                    WriteLine($"First Name = {row["FirstName"]}");
                    WriteLine($"Last Name = {row["LastName"]}");
                    WriteLine();
                }
            }
        }
    }
}
