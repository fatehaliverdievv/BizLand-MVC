using bizland.DAL;
using bizland.Models;
using Microsoft.AspNetCore.Mvc;

namespace bizland.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class EmployeeController : Controller
    {
        readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
                return View(_context.Employees.ToList());
        }
        public IActionResult Delete(int id)
        {
                Employee employee = _context.Employees.Find(id);
                if (employee is null) return NotFound();
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string fullname, string position, string imgurl, string Testimonial)
        {
                if (!ModelState.IsValid) return View();
                _context.Employees.Add(new Employee { FullName = fullname, ImgUrl = imgurl, Position = position, Testimonial = Testimonial });
                _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
                Employee employee= _context.Employees.Find(id);
                if (employee is null) return NotFound();
                if (id is null || id ==0) BadRequest();
                return View();
        }
        [HttpPost]
        public IActionResult Update(int? id, Employee employee)
        {
                if (!ModelState.IsValid) return View();
                if (id is null || id!=employee.Id) BadRequest();
                Employee existedemployee = _context.Employees.Find(id);
                if (existedemployee is null) return NotFound();
                existedemployee.FullName = employee.FullName;
                existedemployee.Position=employee.Position;
                existedemployee.ImgUrl = employee.ImgUrl;
                existedemployee.Testimonial = employee.Testimonial;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
        }
        }
    }

