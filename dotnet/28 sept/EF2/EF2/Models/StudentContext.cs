using Microsoft.EntityFrameworkCore;

namespace EF2.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext()
        {

        }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
