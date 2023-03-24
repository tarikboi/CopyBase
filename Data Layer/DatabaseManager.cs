using CopyBase.Data_Layer.DataModel;
using Microsoft.EntityFrameworkCore;

namespace CopyBase.Data_Layer
{
    internal class DatabaseManager
    {
        public static void CloneDatabase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test4;Integrated Security=True;";
            
            // Step 2: Create an instance of the DataContext class with the appropriate DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(connectionString);

            using var dbContext = new DataContext(optionsBuilder.Options);

            // Step 3: Call the DbContext.Database.EnsureCreated() method to create the database schema if it does not already exist
            dbContext.Database.EnsureCreated();


            // Step 4: Use the DbContext instance to add, modify, or delete data in the database as required
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
            dbContext.SaveChanges();

            // Step 5: Dispose of the DbContext instance when you are done using it
            dbContext.Dispose();
        }
    }
}
