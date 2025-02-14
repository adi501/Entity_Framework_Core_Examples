using EF_Example.Models;
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
       
    }
}
