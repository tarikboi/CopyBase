using CopyBase.Data_Layer.DataModel.EGT.mitDk;
using CopyBase.Data_Layer.DataModel.TestDb;
using Microsoft.EntityFrameworkCore;

namespace CopyBase.Data_Layer.DataModel
{
    internal class DataContextEGTmitdk : DbContext
    {
        public DataContextEGTmitdk(DbContextOptions options) : base(options)
        {

        }

        //TableObjects
        public DbSet<PayslipReceipt> PayslipReceipt { get; set; }
        public DbSet<EGTTransmission> EGTTransmission { get; set; }
    }
}
