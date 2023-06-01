using CopyBase.Data_Layer.DataModel.EGT.mitDk;
using CopyBase.Data_Layer.DataModel.TestDb;
using Microsoft.EntityFrameworkCore;

namespace CopyBase.Data_Layer.DataModel
{
    internal class DataContextTestDb : DbContext
    {
        public DataContextTestDb(DbContextOptions options) : base(options)
        {

        }
        //Table objects
        public DbSet<Table1> Table1 { get; set; }
        public DbSet<Table2> Table2 { get; set; }
    }
}
