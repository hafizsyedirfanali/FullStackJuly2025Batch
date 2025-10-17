using Microsoft.AspNetCore.Mvc;
using MSIdentity.Data;
using MSIdentity.Data.Entities;
using MSIdentity.Models;

namespace MSIdentity.Controllers;

public class BookController(ApplicationDbContext dbContext) : Controller
{

    [HttpGet]
    public IActionResult Books(int categoryId)//get parent id as input parameter
    {
        ViewBag.CategoryId = categoryId;
        if (categoryId == 0)
        {
            return View("Error", new ErrorViewModel { ErrorMessage = "Select Category" });
        }
        //converted List<Book> to List<BookDTO>
        var books = dbContext.Books
            .Where(s => s.CategoryId == categoryId)
            .Select(s => new BookDTO { CategoryId = s.CategoryId, Description = s.Description, Id = s.Id, IsActive = s.IsActive, Title = s.Title})
            .ToList();
        return View(books);
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
    public IActionResult Create(BookDTO book)
    {
        if (ModelState.IsValid)
        {
            //save in database
            var bookEntity = new Book
            {
                Title = book.Title,
                IsActive = book.IsActive,
                Id = book.Id,
                Description = book.Description,
                CategoryId = book.CategoryId
            };
            dbContext.Books.Add(bookEntity);
            //dbContext.Add(book);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Books), new { categoryId = book.CategoryId });
        }
        return View(book);
    }

    [HttpGet]
    public IActionResult Update(int bookId)
    {
        //fetch from db
        var book = dbContext.Books.Find(bookId);
        if (book is null)
        {
            return View("Error", new ErrorViewModel { ErrorMessage = "No record found" });
        }
        ViewBag.CategoryId = book.CategoryId;
        var bookDTO = new BookDTO
        {
            Id = book.Id,
            CategoryId= book.CategoryId,
            Description= book.Description,
            IsActive= book.IsActive,
            Title = book.Title
        };
        return View(bookDTO);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Update(BookDTO book)
    {
        if (ModelState.IsValid)
        {
            //save in db.
            var bookEntity = new Book
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                IsActive = book.IsActive,
                CategoryId = book.CategoryId,
            };
            dbContext.Books.Update(bookEntity);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Books), new { categoryId = book.CategoryId });
        }
        return View(book);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int bookId)
    {
        var book = dbContext.Books.Find(bookId);
        if(book is null)
        {
            return View("Error", new ErrorViewModel { ErrorMessage = "No record found"});
        }
        var categoryId = book.CategoryId;
        dbContext.Remove(book);
        dbContext.SaveChanges();
        //return RedirectToAction(nameof(Books), new { categoryId = categoryId });
        return RedirectToAction(nameof(Books), new { categoryId });
    }
}
