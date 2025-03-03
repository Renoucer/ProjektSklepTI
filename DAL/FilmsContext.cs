using Microsoft.EntityFrameworkCore;
using ProjektSklepTI.Models;

namespace ProjektSklepTI.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions options) : base(options)
        {

        }
    }
}
