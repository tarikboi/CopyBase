using CopyBase.Data_Layer.DataModel;
using Microsoft.EntityFrameworkCore;
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
            // Step 1: Install the required NuGet packages for Entity Framework Core and SQLite database provider

            // Step 2: Create an instance of the DataContext class with the appropriate DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlite("Data Source=mydatabase.db");
            using var dbContext = new DataContext(optionsBuilder.Options);

            // Step 3: Call the DbContext.Database.EnsureCreated() method to create the database schema if it does not already exist
            dbContext.Database.EnsureCreated();

            // Step 4: Use the DbContext instance to add, modify, or delete data in the database as required
            var payslipReceipt = new PayslipReceipt { EGTTransmissionId = 123, MessageId = "ABC" };
            dbContext.PayslipReceipt.Add(payslipReceipt);
            dbContext.SaveChanges();

            // Step 5: Dispose of the DbContext instance when you are done using it
            dbContext.Dispose();
        }
    }
}
