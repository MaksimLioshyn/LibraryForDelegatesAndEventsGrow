using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationForL2.Models;

namespace WebApplicationForL2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        public IActionResult Task2Delagates()
        {
            return View();
        }

        public IActionResult IncreaseImage()
        {
            return RedirectToAction("Task2Delagates");
        }

        public IActionResult DecreaseImage()
        {
            return RedirectToAction("Task2Delagates");
        }

        public IActionResult ShowImage()
        {
            return RedirectToAction("Task2Delagates");
        }

        public IActionResult ShowImage(string id)
        {
            return RedirectToAction("Task2Delagates");
        }
    }
}
