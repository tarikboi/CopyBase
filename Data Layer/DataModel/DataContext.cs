using Microsoft.EntityFrameworkCore;

namespace CopyBase.Data_Layer.DataModel
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //EGT.mitDk database
        public DbSet<PayslipReceipt> PayslipReceipt { get; set; }
        public DbSet<EGTTransmission> EGTTransmission { get; set; }


        //MLE Core database

    }
}
