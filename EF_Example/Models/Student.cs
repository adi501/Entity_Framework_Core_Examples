using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace EF_Example.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Course_Id { get; set; }
        [ForeignKey("Course_Id")]
        public Course Course { get; set; }
    }
}
