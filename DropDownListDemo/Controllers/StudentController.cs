using DropDownListDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownListDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _db;

        public StudentController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public IActionResult Create()
        {
            StudentVM student = new StudentVM()
            {
                student = new Student(),
                cityList = _db.StateSamples.ToList().Select(a=>new SelectListItem()
                {
                    Value = a.Name.ToString(),
                    Text = a.Name.ToString()
                })
            };

            return View(student);
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
