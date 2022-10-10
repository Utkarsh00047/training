using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _Context;

        public StudentController(StudentContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _Context.Students.ToList();
        }

        [HttpPost]
        
        public void PostStudents(Student stu)
        {
            _Context.Students.Add(stu);
            _Context.SaveChanges();
         
        }

        [HttpDelete("{id}")]

        public void deleteStudentsbyID(int id)
        {
            var stud = _Context.Students.Where(x=> x.Id == id).FirstOrDefault();
            _Context.Students.Remove(stud);
            _Context.SaveChanges();


        }

        [HttpPut("{id,stu}")]
        public void PutStudents(int id, Student stu)
        {
             var student = _Context.Students.Where(x => x.Id == id).FirstOrDefault();
            _Context.Entry(stu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _Context.SaveChanges();

        }
    }
}
