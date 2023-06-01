using System.ComponentModel.DataAnnotations;

namespace CopyBase.Data_Layer.DataModel.TestDb
{
    internal class Table1
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}