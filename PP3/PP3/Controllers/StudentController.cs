using PP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult StudentView()
        {
            StudentMarks dal = new StudentMarks();
            List<Student> students = (List<Student>)dal.GetAllStudents();
            ViewData["students"] = students;
            return View(students);
        }
    }
}