using Microsoft.AspNetCore.Mvc;
using MSIdentity.Data;
using MSIdentity.Data.Entities;
using MSIdentity.Models;
namespace MSIdentity.Controllers
{
    public class NewsPaperController(ApplicationDbContext dbContext) : Controller
    {
        [HttpGet]
        public IActionResult NewsPapers(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            if (categoryId == 0)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "Select Category" });
            }
            var newsPapers = dbContext.NewsPapers.Where(s => s.CategoryId == categoryId).ToList();
            return View(newsPapers);
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
        public IActionResult Create(NewsPaper newsPaper)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newsPaper);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(NewsPapers), new { categoryId = newsPaper.CategoryId });
            }
            return View(newsPaper);
        }
        [HttpGet]
        public IActionResult Update(int newsPaperId)
        {
            var newsPaper = dbContext.NewsPapers.Find(newsPaperId);
            if(newsPaper is null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "No record found" });
            }
            ViewBag.CategoryId = newsPaper.CategoryId;
            return View(newsPaper);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(NewsPaper newsPaper){
            if (ModelState.IsValid)
            {
                dbContext.Update(newsPaper);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(NewsPapers), new { CategoryId = newsPaper.CategoryId });
            }
            return View(newsPaper);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int newsPaperId)
        {
            var newsPaper = dbContext.NewsPapers.Find(newsPaperId);
            if( newsPaper is null)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "No record found" });

            }
            var CategoryId = newsPaper.CategoryId;
            dbContext.Remove(newsPaper);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(NewsPapers), new { CategoryId });
        }
    }
}
