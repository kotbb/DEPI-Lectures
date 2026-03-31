using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModels
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; }

        [Display(Name = "Department")]
        public List<Department> Departments { get; set; }
    }
}
