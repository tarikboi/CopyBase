using System.ComponentModel.DataAnnotations;

namespace CopyBase.Data_Layer.DataModel.TestDb
{
    internal class Table2
    {
        [Key]
        public int OrderId { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
    }
}