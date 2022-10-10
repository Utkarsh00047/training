using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentContext: DbContext 
    {
        public StudentContext()
        {

        }

        public StudentContext(DbContextOptions<StudentContext> options ): base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; } 
        

        
    }
}
