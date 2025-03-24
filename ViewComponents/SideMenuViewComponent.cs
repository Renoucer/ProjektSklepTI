using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklepTI.DAL;
using ProjektSklepTI.Models;
using System.Collections.Specialized;

namespace ProjektSklepTI.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        FilmsContext db;
        public SideMenuViewComponent( FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name == categoryName).FirstOrDefault();
            var films = new List<Film>();
            if (category != null)
            {
                films = category.Films.OrderBy(f=>f.Title).ToList();
            }

           return await Task.FromResult(View("_SideMenu", films));

        }
    }
}
