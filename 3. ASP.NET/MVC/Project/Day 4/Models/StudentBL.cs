using MVC_Project.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Models
{
    public class StudentBL
    {
        SchoolDbContext context = new SchoolDbContext();
        public List<Student> GetAll()
        {
            return context.Students.Include(s => s.Department).ToList();
        }

        public Student GetById(int id)
        {
            return context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Update(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }

        public void Delete(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
