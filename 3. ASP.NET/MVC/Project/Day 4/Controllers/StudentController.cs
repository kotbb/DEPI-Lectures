using MVC_Project.Models;
using MVC_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();


        [HttpGet]
        public IActionResult ShowAll()
        {
            List<Student> students = studentBL.GetAll();
            return View("ShowAll", students);
        }

        [HttpGet]
        public IActionResult ShowDetails(int id)
        {
            Student student = studentBL.GetById(id);
            return View("ShowDetails", student);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new StudentFormViewModel
            {
                Student = new Student(),
                Departments = departmentBL.GetAll()
            };
            return View("Add", viewModel);

        }

        [HttpPost]
        public IActionResult SaveAdd(StudentFormViewModel viewModelStudent)
        {
            if (viewModelStudent.Student.Name != null &&
                viewModelStudent.Student.Age > 0 &&
                viewModelStudent.Student.DepartmentId > 0)
            {
                studentBL.Add(viewModelStudent.Student);
                return RedirectToAction(nameof(ShowAll));
            }
            viewModelStudent.Departments = departmentBL.GetAll();
            return View("Add", viewModelStudent);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = studentBL.GetById(id);
            if (student == null) return NotFound();

            var viewModel = new StudentFormViewModel
            {
                Student = student,
                Departments = departmentBL.GetAll()
            };
            return View("Edit", viewModel);

        }

        [HttpPost]
        public IActionResult SaveEdit(StudentFormViewModel viewModelStudent)
        {
            if (viewModelStudent.Student.Name != null &&
                viewModelStudent.Student.Age > 0 &&
                viewModelStudent.Student.DepartmentId > 0)
            {
                studentBL.Update(viewModelStudent.Student);
                return RedirectToAction(nameof(ShowAll));
            }
            viewModelStudent.Departments = departmentBL.GetAll();
            return View("Edit", viewModelStudent);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student student = studentBL.GetById(id);
            if (student == null) return NotFound();

            return View("Delete", student);

        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Student student = studentBL.GetById(id);
            if (student != null)
            {
                studentBL.Delete(student);
                return RedirectToAction(nameof(ShowAll));
            }

            return NotFound();

        }
    }
}
