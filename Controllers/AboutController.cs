using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WellaMvcProject.Models;

namespace WellaMvcProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}