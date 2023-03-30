using CopyBase.Data_Layer.DataModel;
using CopyBase.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CopyBase.Data_Layer
{
    internal class DatabaseManager
    {
        public static void CloneDatabase(string databaseToClone, string clonedDbName, string clonedDbDirectory, string connectionString)
        {
            //Create an instance of the DataContext class with the appropriate DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(connectionString);
            using var dbContext = new DataContext(optionsBuilder.Options);

            //Call EnsureCreated() method to create the database schema
            dbContext.Database.EnsureCreated();

            //Use DBContext to seed data
            switch (databaseToClone)
            {
                case "EGT.mitDk":
                    SeedDataEGTmitdk(dbContext);
                    break;
                case "Salary":
                    //SeedDataSalary(dbContext);
                    break;
            }

            //Save changes
            dbContext.SaveChanges();

            ClonedDatabase cd = new ClonedDatabase(databaseToClone, clonedDbName, clonedDbDirectory, connectionString);

        }

        public static void DeleteClonedDatabase()
        {
            using var dbContext = new DbContext(new DbContextOptionsBuilder().UseSqlServer(ClonedDatabase.ConnectionString).Options);

            // Close all existing connections to the database and drop
            dbContext.Database.ExecuteSqlRaw($@"ALTER DATABASE [{ClonedDatabase.ClonedDatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            dbContext.Database.EnsureDeleted();

            ClonedDatabase.Deactivate();
        }
        
        public static void ResetClonedDatabase()
        {
            string databaseToClone = ClonedDatabase.DatabaseToClone;
            string clonedDbName = ClonedDatabase.ClonedDatabaseName;
            string clonedDbDirectory = ClonedDatabase.ClonedDatabaseDirectory;
            string connectionString = ClonedDatabase.ConnectionString;
            
            DeleteClonedDatabase();
            CloneDatabase(databaseToClone,clonedDbName,clonedDbDirectory,connectionString);
        }

        public static void SeedDataEGTmitdk(DataContext dbContext)
        {
            var EGTTransmissions = new List<EGTTransmission>
            {
                new EGTTransmission
                {
                    TransmissionGUID = Guid.NewGuid().ToString(), HostFileName = "S0M5.ZDM1D0.M5PRA100.M5FTMIDK", SentFileName = Guid.NewGuid() + ".tar.lzma", HostTimeStamp = DateTime.Now,
                    MitDkMailbox = "MitDk", ExportedPayslips = 3, ImportedConversionReceipts = 3, ImportedBusinessReceipts = 3, ReceiptWarnings = 1,
                    MissingBusinessReceipts = 0, FailedPayslips = 2, OKPayslips = 1, TechnicalReceiptStatus = "RECEIVED", TechnicalReceiptUpdateTimeStamp = DateTime.Now,
                    ConversionFileStatus = "RECEIVED", ConversionFileUpdateTimeStamp = DateTime.Now, AlertSent = true
                },
                new EGTTransmission
                {
                    TransmissionGUID = Guid.NewGuid().ToString(), HostFileName = "S0M5.ZDM1D0.M5PRA100.M5FTMIBA", SentFileName = Guid.NewGuid() + ".tar.lzma", HostTimeStamp = DateTime.Now,
                    MitDkMailbox = "MitBasic", ExportedPayslips = 3, ImportedConversionReceipts = 3, ImportedBusinessReceipts = 3, ReceiptWarnings = 0,
                    MissingBusinessReceipts = 0, FailedPayslips = 0, OKPayslips = 3, TechnicalReceiptStatus = "RECEIVED", TechnicalReceiptUpdateTimeStamp = DateTime.Now,
                    ConversionFileStatus = "conversion2", ConversionFileUpdateTimeStamp = DateTime.Now, AlertSent = false
                },
            };

            var payslipReceipts = new List<PayslipReceipt>
            {
                new PayslipReceipt
                {
                    EGTTransmissionId = 1, MessageId = "100001000001000000000000100", ServiceAgencyId = 100001, EmployerId = 1, EmployeeId = 100, MessageUUID = Guid.NewGuid().ToString(),
                    ErrorCode = "Error Code 1", ErrorMessage = "X is put in incorrectly", ReceiptStatus = "NOT_ALLOWED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                },
                new PayslipReceipt
                {
                    EGTTransmissionId = 1, MessageId = "100001000001000000000000101", ServiceAgencyId = 100001, EmployerId = 1, EmployeeId = 101, MessageUUID = Guid.NewGuid().ToString(),
                    WarningCode = "Warning Code 1", WarningMessage = "X is put in incorrectly put that's ok", ReceiptStatus = "COMPLETED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                },
                new PayslipReceipt
                {
                    EGTTransmissionId = 1, MessageId = "100001000002000000000000102", ServiceAgencyId = 100001, EmployerId = 2, EmployeeId = 102, MessageUUID = Guid.NewGuid().ToString(),
                    ErrorCode = "Error Code 2", ErrorMessage = "Y is done incorrectly", ReceiptStatus = "NOT_ALLOWED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                },
                new PayslipReceipt
                {
                    EGTTransmissionId = 2, MessageId = "100002000003000000000000200", ServiceAgencyId = 100001, EmployerId = 3, EmployeeId = 200, MessageUUID = Guid.NewGuid().ToString(),
                    ReceiptStatus = "COMPLETED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                },
                new PayslipReceipt
                {
                    EGTTransmissionId = 2, MessageId = "100002000003000000000000201", ServiceAgencyId = 100002, EmployerId = 3, EmployeeId = 201, MessageUUID = Guid.NewGuid().ToString(),
                    ReceiptStatus = "COMPLETED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                },
                new PayslipReceipt
                {
                    EGTTransmissionId = 2, MessageId = "100002000003000000000000202", ServiceAgencyId = 100002, EmployerId = 3, EmployeeId = 202, MessageUUID = Guid.NewGuid().ToString(),
                    ReceiptStatus = "COMPLETED",
                    CreationTimeStamp = DateTime.Now, ConversionReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(1), TechnicalReceiptUpdateTimeStamp = DateTime.Now.AddMinutes(2)
                }

            };

            dbContext.EGTTransmission.AddRange(EGTTransmissions);
            dbContext.PayslipReceipt.AddRange(payslipReceipts);
        }
    }
}
