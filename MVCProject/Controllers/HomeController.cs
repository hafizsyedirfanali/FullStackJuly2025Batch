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

    public IActionResult Index()//Index Action and not function
    {
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

    public IActionResult Error()
    {
        return Ok("");
    }
}
