using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
}
