using Microsoft.AspNetCore.Mvc;
using MSIdentity.Data;
using MSIdentity.Data.Entities;
using MSIdentity.Models;
namespace MSIdentity.Controllers
{
    public class MagazineController(ApplicationDbContext dbContext) : Controller
    {
        [HttpGet]
        public IActionResult Magazines(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            if (categoryId == 0)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Select Category" });
            }
            var magazines = dbContext.Magazines.Where(s => s.CategoryId == categoryId).ToList();
            return View(magazines);
        }
        [HttpGet]
        public IActionResult Create(int categoryId)
        {
            if (categoryId == 0)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Select Category" });
            }
            ViewBag.CategoryId = categoryId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Magazine magazine)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(magazine);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Magazines), new { categoryId = magazine.CategoryId });
            }
            return View(magazine);
        }
        [HttpGet]
        public IActionResult Update(int magazineId)
        {
            var magazine = dbContext.Magazines.Find(magazineId);
            if(magazine is null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "No record found" });
            }
            ViewBag.CategoryId = magazine.CategoryId;
            return View(magazine);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Magazine magazine){
            if (ModelState.IsValid)
            {
                dbContext.Update(magazine);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Magazines), new { CategoryId = magazine.CategoryId });
            }
            return View(magazine);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int magazineId)
        {
            var magazine = dbContext.Magazines.Find(magazineId);
            if( magazine is null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "No record found" });

            }
            var CategoryId = magazine.CategoryId;
            dbContext.Remove(magazine);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Magazines), new { CategoryId });
        }
    }
}
