using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Example.Models.Data_Annotations
{
    //Add-Migration "Table Attribute Example"
    //Update-Database

    [Table("CustomerMaster")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
