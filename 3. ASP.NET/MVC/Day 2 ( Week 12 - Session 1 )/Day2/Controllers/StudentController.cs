using Day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();


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
    }
}
