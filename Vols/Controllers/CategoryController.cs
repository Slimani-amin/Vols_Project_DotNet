using Microsoft.AspNetCore.Mvc;
using Vols.Data;
using Vols.Models;

namespace Vols.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult ListeCategories()
        {
            List<Category> categoryList =  _db.Categories.ToList();
            return View(categoryList);
        }


        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj) {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("ListeCategories");
            }
            return View();
        }
    }
}
