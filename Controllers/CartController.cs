using Microsoft.AspNetCore.Mvc;
using ProjektSklepTI.DAL;
using ProjektSklepTI.Infrastructure;

namespace ProjektSklepTI.Controllers
{
    public class CartController : Controller
    {

        FilmsContext db;
        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total=CartManager.GetCartValue(HttpContext.Session);
            return View();
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, db, filmId);
            return RedirectToAction("Index");
        }
    }
}
