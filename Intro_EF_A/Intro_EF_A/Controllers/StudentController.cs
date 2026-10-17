using Intro_EF_A.EF;
using Intro_EF_A.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro_EF_A.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(double cgpa)
        {
            var students = _context.student.Where(s=>s.cgpa>=cgpa).ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            var student = _context.student.FirstOrDefault(s => s.id == id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        public IActionResult Delete(int id)
        {
            var student = _context.student.FirstOrDefault(s => s.id == id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }


        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.student.Add(student);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, Student student)
        {
            if (ModelState.IsValid)
            {
                var std = _context.student.FirstOrDefault(s => s.id == id);
                if(std == null)
                {
                    return NotFound();
                }
                std.name = student.name;
                std.department = student.department;
                std.cgpa = student.cgpa;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var student = _context.student.FirstOrDefault(s => s.id == id);
            if(student == null)
            {
                return NotFound();
            }
            _context.student.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("index");

            //return View();
        }

    }
}
