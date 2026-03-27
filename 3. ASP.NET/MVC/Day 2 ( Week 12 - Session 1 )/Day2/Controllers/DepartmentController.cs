using Day2.Models;
using Day2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();

        [HttpGet]
        public IActionResult ShowAll()
        {
            List<Department> departments = departmentBL.GetAll();
            return View("ShowAll",departments);
        }

        [HttpGet]
        public IActionResult ShowDetails(int id)
        {
            Department department = departmentBL.GetById(id);
            return View("ShowDetails", department);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add", new Department());
        }

        [HttpPost]
        public IActionResult SaveAdd(Department deptSent)
        {
            if(deptSent.Name != null && deptSent.MgrName != null)
            {
                departmentBL.Add(deptSent);
                return Redirect(nameof(ShowAll));
            }
            return View("Add", deptSent);
        }

        [HttpGet]
        public IActionResult ShowDetailsVM(int id) 
        {
            Department department = departmentBL.GetById(id);
            List<string> studentNames = department.Students
                                                   .Where(s => s.Age > 25)
                                                   .Select(s => s.Name)
                                                   .ToList();
            var vm = new DepartmentWithExtraInfoViewModel();
            vm.DeptName = department.Name;
            vm.StudentNames = studentNames;
            vm.DeptState = studentNames?.Count > 50 ? "Main" : "Branch";

            return View("ShowDetailsVM", vm);
        }
    }
}
