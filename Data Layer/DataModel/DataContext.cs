using Microsoft.EntityFrameworkCore;

namespace CopyBase.Data_Layer.DataModel
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PayslipReceipt> PayslipReceipt { get; set; }
    }
}
