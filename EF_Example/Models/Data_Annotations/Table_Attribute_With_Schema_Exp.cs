using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Example.Models.Data_Annotations
{
    //Add-Migration "Table Attribute with Schema Example"
    //Update-Database
    [Table("TableName",Schema ="User")]
    public class Table_Attribute_With_Schema_Exp
    {
            public int Id { get; set; }
            public string Name { get; set; }
    }
}
