using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSIdentity.Data;
using MSIdentity.Data.Entities;
using MSIdentity.Models;


namespace MSIdentity.Controllers
{
    [Authorize]
    public class CategoryController(ApplicationDbContext dbContext) : Controller
    {

        [HttpGet]
        public IActionResult Categories()
        {
            //get list of categories from database
            //var list = database...
            var list = dbContext.Categories.ToList();//Gives IQuerable type of list
           // var list = new List<Category>();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category model)
        {
            
            if (ModelState.IsValid)
            {
                //Add in database
                dbContext.Add(model);//it informs change tracker to add the entity
                dbContext.SaveChanges();//it asks the change tracker? what to do?
                return RedirectToAction(nameof(Categories));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if(id == 0)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = "ID not received" });
            }
            //Get record of id from database in a model
            //var model = database....
            var model = dbContext.Categories.Find(id);//use when finding using PK
            //var model1 = dbContext.Categories.FirstOrDefault(s => s.Id == id);
            //var model2 = dbContext.Categories.Where(s => s.Id == id).FirstOrDefault();
            //var model = new Category { Id = id, Name = "dummy", Description = "dummy" };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                //update in database
                dbContext.Update(model);//tells the change tracker to note the changes
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Categories));
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            //var record = database...
            var record = dbContext.Categories.Find(id);
            //var record = new Category();
            if(record is not null)
            {
                //delete from database
                dbContext.Remove(record);//tells the change tracker to note this change 
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Categories));
            }
            return View("Error", new ErrorViewModel { ErrorMessage = "Failed to delete record. Record not found"});
        }
    }
}
