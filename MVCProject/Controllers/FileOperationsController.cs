using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class FileOperationsController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public FileOperationsController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FileSave(IFormFile file)
        {
            var folderPath = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot", "Uploads");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var fileName = Guid.NewGuid() + "_resume.pdf";
            var filePath = Path.Combine(folderPath, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult DownloadFile(string fileName)
        {
            var folderPath = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot", "Uploads");
            var filePath = Path.Combine(folderPath, fileName);
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath); // Replace with actual file path or data source
            string mimeType = "application/pdf";

            return File(fileBytes, mimeType, fileName);
        }
    }
}
