using Day2.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Day2.Models
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
    }
}
