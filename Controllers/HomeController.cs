using Microsoft.AspNetCore.Mvc;
using ProjektSklepTI.DAL;
using ProjektSklepTI.Models;
using System.Diagnostics;

namespace ProjektSklepTI.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FooterSites(string siteName) 
        { 
        return View(siteName, new List<Category>());
        }


    }
}