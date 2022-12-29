using bizland.DAL;
using bizland.Models;
using Microsoft.AspNetCore.Mvc;

namespace bizland.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class FeaturedServiceController : Controller
    {
        readonly AppDbContext _context;
        public FeaturedServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.FeaturedService.ToList());
        }
        public IActionResult Delete(int id)
        {
            FeaturedService featured = _context.FeaturedService.Find(id);
            if (featured is null) return NotFound();
            _context.FeaturedService.Remove(featured);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, string Description, string IconUrl)
        {
            if (!ModelState.IsValid) return View();
            _context.FeaturedService.Add(new FeaturedService { Name = name, Description = Description, IconUrl = IconUrl});
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            FeaturedService featuredService = _context.FeaturedService.Find(id);
            if (featuredService is null) return NotFound();
            if (id is null || id == 0) BadRequest();
            return View();
        }
        [HttpPost]
        public IActionResult Update(int? id, FeaturedService service)
        {
            if (!ModelState.IsValid) return View();
            if (id is null || id != service.Id) BadRequest();
            FeaturedService exsitedservice = _context.FeaturedService.Find(id);
            if (exsitedservice is null) return NotFound();
            exsitedservice.Name = service.Name;
            exsitedservice.Description = service.Description;
            exsitedservice.IconUrl = service.IconUrl;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
