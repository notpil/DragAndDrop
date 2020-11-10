using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DragAndDropTraning.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace DragAndDropTraning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _environment;
        private string test = "";

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            ViewData["result"] = test;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            try
            {
                var uploadedFile = String.Empty;
                if (file.Length > 0)
                {
                    //string folderRoot = Path.Combine(_environment.ContentRootPath, "Uploads");
                    //string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    //filePath = Path.Combine(folderRoot, filePath);
                    
                     using (var sr = new StreamReader(file.OpenReadStream())) {
                        while (sr.Peek() >= 0) {
                            uploadedFile += sr.ReadLine() + "\n";
                        }
                    }
                    HttpContext.Session.SetString("UploadedFile", uploadedFile);
                }
                test = uploadedFile;
                return Ok(new { success = true, message = "File uploaded" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = "Error file failed to upload" });
            }
        }


    }
}
