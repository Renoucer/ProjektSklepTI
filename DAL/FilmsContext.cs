using Microsoft.EntityFrameworkCore;
using ProjektSklepTI.Models;
using System.Xml.Linq;

namespace ProjektSklepTI.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>() 
            {
    new Category { CategoryId=1, Name = "Action", Desc = "Movies full of dynamic scenes, chases, and intense action." },
    new Category { CategoryId=2, Name = "Comedy", Desc = "Movies focused on humor and light-hearted entertainment." },
    new Category { CategoryId=3, Name = "Drama", Desc = "Movies that focus on emotional depth and character conflict." },
    new Category { CategoryId=4, Name = "Horror", Desc = "Movies designed to evoke fear and suspense." },
    new Category { CategoryId=5, Name = "Science Fiction", Desc = "Movies that explore futuristic and technological themes." },
    new Category { CategoryId=6, Name = "Romance", Desc = "Movies centered around love stories and relationships." },
    new Category { CategoryId=7, Name = "Thriller", Desc = "Movies filled with suspense, tension, and unexpected twists." },
    new Category { CategoryId=8, Name = "Fantasy", Desc = "Movies set in magical or fantastical worlds." },
    new Category { CategoryId=9,  Name = "Documentary", Desc = "Movies documenting real-life events, people, or topics." },
    new Category { CategoryId=10, Name = "Animation", Desc = "Movies created using animation techniques, for both kids and adults." }
            };

            var films = new List<Film>() 
            {
    new Film {FilmId=1, Title = "Mad Max: Fury Road", Director = "George Miller", Desc = "In a post-apocalyptic wasteland, Max teams up with a warrior to escape a tyrannical warlord.", Price = 12.99m,  Poster="1.jpg", CategoryId = 1 },
    new Film {FilmId=2, Title = "John Wick", Director = "Chad Stahelski", Desc = "A retired hitman seeks revenge against the people who killed his dog.", Price = 14.99m,Poster="2.jpg", CategoryId = 1 },
    new Film {FilmId=3, Title = "Die Hard", Director = "John McTiernan", Desc = "A New York cop faces off against terrorists in a Los Angeles skyscraper.", Price = 9.99m,Poster="3.jpg", CategoryId = 1 },
    new Film {FilmId=4, Title = "The Dark Knight", Director = "Christopher Nolan", Desc = "Batman faces off against the Joker, a criminal mastermind bent on chaos.", Price = 13.99m,Poster="4.jpg", CategoryId = 1 },
    new Film {FilmId=5, Title = "Gladiator", Director = "Ridley Scott", Desc = "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family.", Price = 11.99m,Poster="5.jpg", CategoryId = 1 },
    new Film {FilmId=6, Title = "Superbad", Director = "Greg Mottola", Desc = "Two high school seniors try to make the most of their last days before graduation.", Price = 8.99m,Poster="6.jpg", CategoryId = 2 },
    new Film {FilmId=7, Title = "The Hangover", Director = "Todd Phillips", Desc = "Three friends wake up from a bachelor party with no memory of the previous night and must piece together the events.", Price = 10.99m,Poster="6.jpg", CategoryId = 2 },
    new Film {FilmId=8, Title = "Dumb and Dumber", Director = "Peter Farrelly", Desc = "Two dim-witted friends embark on a cross-country trip to return a suitcase full of money.", Price = 7.99m,Poster="8.jpg", CategoryId = 2 },
    new Film {FilmId=9, Title = "21 Jump Street", Director = "Phil Lord", Desc = "Two undercover cops are sent to a high school to bust a drug ring.", Price = 9.49m,Poster="9.jpg", CategoryId = 2 },
    new Film {FilmId=10, Title = "Anchorman", Director = "Adam McKay", Desc = "The chaos that follows when a new female anchor joins a 1970s news team.", Price = 8.49m,Poster="10.jpg", CategoryId = 2 },
    new Film {FilmId=11, Title = "The Shawshank Redemption", Director = "Frank Darabont", Desc = "Two imprisoned men bond over several years, finding solace and eventual redemption through acts of common decency.", Price = 12.49m,Poster="11.jpg", CategoryId = 3 },
    new Film {FilmId=12, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "The presidencies of Kennedy and Johnson, the Vietnam War, the civil rights movement, and other historical events unfold from the perspective of an Alabama man with an extraordinary life.", Price = 11.99m,Poster="12.jpg", CategoryId = 3 },
    new Film {FilmId=13, Title = "A Beautiful Mind", Director = "Ron Howard", Desc = "The story of mathematician John Nash, who struggles with schizophrenia and tries to make a name for himself while dealing with the disorder.", Price = 9.99m,Poster="13.jpg", CategoryId = 3 },
    new Film {FilmId=14, Title = "The Pursuit of Happyness", Director = "Gabriele Muccino", Desc = "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", Price = 10.49m,Poster="14.jpg", CategoryId = 3 },
    new Film {FilmId=15, Title = "Fight Club", Director = "David Fincher", Desc = "An insomniac office worker forms an underground fight club with a soap salesman, leading to unintended consequences.", Price = 9.79m,Poster="15.jpg", CategoryId = 3 },
    new Film {FilmId=16, Title = "The Conjuring", Director = "James Wan", Desc = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", Price = 10.99m,Poster="16.jpg", CategoryId = 4 },
    new Film {FilmId=17, Title = "A Nightmare on Elm Street", Director = "Wes Craven", Desc = "Several people are hunted by a man who uses their fear of the dark and sleep to murder them in their dreams.", Price = 9.49m,Poster="17.jpg", CategoryId = 4 },
    new Film {FilmId=18, Title = "The Exorcist", Director = "William Friedkin", Desc = "When a young girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her.", Price = 11.99m,Poster="18.jpg", CategoryId = 4 },
    new Film {FilmId=19, Title = "It", Director = "Andy Muschietti", Desc = "A group of misfit children band together to defeat a shape-shifting entity that terrorizes their town.", Price = 12.99m,Poster="19.jpg", CategoryId = 4 },
    new Film {FilmId=20, Title = "Hereditary", Director = "Ari Aster", Desc = "A grieving family is haunted after the death of their secretive grandmother.", Price = 13.49m,Poster="20.jpg", CategoryId = 4 },
    new Film {FilmId=21, Title = "Inception", Director = "Christopher Nolan", Desc = "A thief who enters the dreams of others to steal secrets from their subconscious is given the task of planting an idea into a target's subconscious.", Price = 14.99m,Poster="21.jpg", CategoryId = 5 },
    new Film {FilmId=22, Title = "Blade Runner", Director = "Ridley Scott", Desc = "A blade runner must pursue and terminate four replicants who stole a ship in space, and have returned to Earth to find their creator.", Price = 12.99m,Poster="22.jpg", CategoryId = 5 },
    new Film {FilmId=23, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Desc = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", Price = 13.49m,Poster="23.jpg", CategoryId = 5 },
    new Film {FilmId=24, Title = "Interstellar", Director = "Christopher Nolan", Desc = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", Price = 15.99m,Poster="24.jpg", CategoryId = 5 },
    new Film {FilmId=25, Title = "Star Wars: A New Hope", Director = "George Lucas", Desc = "A young farmer sets out to rescue a princess from an evil galactic empire with the help of a powerful force and a team of companions.", Price = 14.49m,Poster="25.jpg", CategoryId = 5 },

        };
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
