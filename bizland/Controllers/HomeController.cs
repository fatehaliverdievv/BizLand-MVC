using bizland.DAL;
using bizland.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bizland.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
                List<Employee> employee = _context.Employees.ToList();
                List<FeaturedService> services= _context.FeaturedService.ToList();
            ViewBag.Service = services;
            return View(employee);
        }
    }
}