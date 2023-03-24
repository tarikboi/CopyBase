using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBase.Data_Layer
{
    internal class DatabaseManager
    {
        public static void CloneDatabase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";
            string databaseName = "NewDatabaseName3";
            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
            
            string newRestore =
                $"RESTORE DATABASE {databaseName} FROM DISK = 'C:\\ClonedDatabases\\Clone.bak' WITH " +
                $"MOVE 'MitDK' TO 'C:\\ClonedDatabases\\newclonefiles\\file.mdf', " +
                $"MOVE 'MitDK_log' TO 'C:\\ClonedDatabases\\newclonefiles\\\\file2.ldf', " +
                $"REPLACE, RECOVERY, STATS = 5;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{databaseName}' created successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating database '{databaseName}': {ex.Message}");
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(newRestore, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
