using EF_Example.Models;
using EF_Example.Models.Data_Annotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace EF_Example.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        //Add this in Context class for
        public DbSet<Customer> Customer { get; set; }
        //Table Attribute with Schema Example
        public DbSet<Table_Attribute_With_Schema_Exp> table_Attribute_With_Schema_Exps { get; set; }

    }
}
