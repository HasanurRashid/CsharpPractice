using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class StudentDbContext : DbContext
    {
        private readonly string _connectionString;
        public StudentDbContext()
        {
            _connectionString = "Server=MAAQ-HP;Database=CsharpDB;User Id=sa;Password=M@@q_786;TrustServerCertificate=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
