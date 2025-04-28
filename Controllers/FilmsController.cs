using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklepTI.DAL;
using Microsoft.AspNetCore.Mvc;
using ProjektSklepTI.Models;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
namespace ProjektSklepTI.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;

        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
        }

        public IActionResult ProductList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c=>c.Name == categoryName).Single();

            var films=category.Films.ToList();



            return View(films);
        }

        public IActionResult Details(int filmId) 
        {
            db.Categories.Find(db.Films.Find(filmId).CategoryId);
            var film=  db.Films.Find(filmId);
            return View(film);
        }
        [HttpGet]
        public IActionResult AddFilm()
        {
            AddViewModel model = new AddViewModel();
            model.AllCategories = db.Categories.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddFilm(AddViewModel model)
        {
            var posterFolderPath = Path.Combine(webHost.WebRootPath, "posters");
            var uniquePosterName = model.Poster.FileName + "_" + Guid.NewGuid() + Path.GetExtension(model.Poster.FileName);
            var filePath = Path.Combine(posterFolderPath, uniquePosterName);
            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));
            model.NewFilm.Poster = uniquePosterName;
            db.Films.Add(model.NewFilm);
            db.SaveChanges();
            return RedirectToAction("AddFilm");
        }
        public IActionResult Images()
        {
            var films = db.Films.ToList();
            return View(films);
        }

        public IActionResult Search(string tekst)
        {
            var filmy = from f in db.Films select f;
            ViewBag.Frza = tekst;
            if (!String.IsNullOrEmpty(tekst))
            {
                filmy=filmy.Where(f => f.Title.ToUpper().Contains(tekst.ToUpper()));
                return View(filmy.ToList());
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult EditFilm(int id)
        {
           var film = db.Films.Find(id);
           return View(film);

        }
        [HttpPost]
        public IActionResult EditFilm(Film film)
        {
            var filmDB = db.Films.Find(film.FilmId);
            if (filmDB != null)
            {
                filmDB.Title = film.Title;
                filmDB.Director = film.Director;
                filmDB.Price = film.Price;
                filmDB.Desc = film.Desc;

                db.Entry(filmDB).State=EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Details", new {filmId=filmDB.FilmId});

        }

    }
}
