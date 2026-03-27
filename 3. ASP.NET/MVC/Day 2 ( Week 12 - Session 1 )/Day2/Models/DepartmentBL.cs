using Day2.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Day2.Models
{
    public class DepartmentBL
    {
        SchoolDbContext context = new SchoolDbContext();

        public List<Department> GetAll()
        {
            return context.Departments.Include(d => d.Students).ToList();
        }

        public Department GetById(int id)
        {
            return context.Departments.Include(d => d.Students).FirstOrDefault(d => d.Id == id);
        }

        public void Add (Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }

    }
}
