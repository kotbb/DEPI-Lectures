using MVC_Project.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Models
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
