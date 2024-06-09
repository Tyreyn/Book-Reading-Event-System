using BookReadingEventSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Diagnostics;
using BookReadingEventSystemDTO.Operations;
using BookReadingEventSystemDTO.Data;
namespace BookReadingEventSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private UserOperations _userOperations;

        public HomeController(ILogger<HomeController> logger, BookReadingEventSystemContext bookReadingEventSystemContext)
        {
            _logger = logger;
            _userOperations = new UserOperations(bookReadingEventSystemContext);
        }

        public bool CheckLoginUser()
        {
            return true;
        }

        public IActionResult Index()
        {
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
    }
}
