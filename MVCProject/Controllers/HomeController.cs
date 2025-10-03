using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers;
/// <summary>
/// Dependency injection is a process of injecting the dependency in a class.
/// </summary>
public class HomeController : Controller
{
    //private readonly PrintServices _print;
    //public HomeController(PrintServices print)//dependency injection
    //{

    //}
    //Routing = localhost/home/index
    [Route("/home/index")]
    // [Route("/home/myhome")]
    [HttpGet]
    public IActionResult Index()//Index Action and not function
    {
        ViewBag.Experience = 10;//Age Experience is added to page dictionary with value 10
        ViewData["Name"] = "Irfan sir";
        //_print.PrintInNewLine("hello");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult About()
    {
        return View("Aboutt");
    }
    public IActionResult TempData1()
    {
        TempData["Date"] = DateTime.Now;
        return View();
    }
    public IActionResult TempData2()
    {
        return View();
    }
    public IActionResult TempData3()
    {
        return View();
    }
    [HttpGet]
    public IActionResult ModelBinding()
    {
        //Model means class object.
        //StudentModel model = new StudentModel();
        //model.Address = "Nagpur";
        //model.Age = 10;
        //model.Name = "abid";
        var model = new StudentModel
        {
            Address = "Nagpur",
            Age = 10,
            Name = "abid"
        };

        return View(model);
    }
    [HttpPost]
    public IActionResult ModelBinding(StudentModel model)
    {
        if (ModelState.IsValid)//backend validation
        {
            //save incoming data, or process
        }
        //handle invalid data
        return View(model);
    }
    [HttpGet]
    public IActionResult ModelBindingList()
    {
        List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel { Name = "Abid", Age = 10, Address = "Nagpur" },
            new StudentModel { Name = "Sara", Age = 11, Address = "Mumbai" },
            new StudentModel { Name = "Ravi", Age = 12, Address = "Delhi" },
            new StudentModel { Name = "Priya", Age = 10, Address = "Pune" },
            new StudentModel { Name = "Amit", Age = 13, Address = "Hyderabad" },
            new StudentModel { Name = "Neha", Age = 11, Address = "Chennai" },
            new StudentModel { Name = "Karan", Age = 12, Address = "Bangalore" },
            new StudentModel { Name = "Meena", Age = 10, Address = "Kolkata" },
            new StudentModel { Name = "Vikram", Age = 14, Address = "Ahmedabad" },
            new StudentModel { Name = "Anjali", Age = 13, Address = "Jaipur" }
        };
        return View(students);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ModelBindingList(List<StudentModel> students)
    {
        if (ModelState.IsValid)
        {
            //save in db
        }
        return View(students);
    }
    public IActionResult Error()
    {
        return Ok("");
    }
}
