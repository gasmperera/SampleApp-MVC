using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolDBContext _db;

        public StudentsController(SchoolDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var students = _db.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Students students)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(students);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(students);
        }

        public async Task<IActionResult> Details(int id=0)
        {
            if(id > 0)
            {
                var student = await _db.Students.FindAsync(id);
                return View(student);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id=0)
        {
            if (id > 0)
            {
                var student = await _db.Students.FindAsync(id);
                return View(student);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Students students)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(students);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(students);
        }
    }
}
