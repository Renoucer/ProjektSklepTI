using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSklepTI.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Movies full of dynamic scenes, chases, and intense action.", "Action" },
                    { 2, "Movies focused on humor and light-hearted entertainment.", "Comedy" },
                    { 3, "Movies that focus on emotional depth and character conflict.", "Drama" },
                    { 4, "Movies designed to evoke fear and suspense.", "Horror" },
                    { 5, "Movies that explore futuristic and technological themes.", "Science Fiction" },
                    { 6, "Movies centered around love stories and relationships.", "Romance" },
                    { 7, "Movies filled with suspense, tension, and unexpected twists.", "Thriller" },
                    { 8, "Movies set in magical or fantastical worlds.", "Fantasy" },
                    { 9, "Movies documenting real-life events, people, or topics.", "Documentary" },
                    { 10, "Movies created using animation techniques, for both kids and adults.", "Animation" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "In a post-apocalyptic wasteland, Max teams up with a warrior to escape a tyrannical warlord.", "George Miller", 12.99m, "Mad Max: Fury Road" },
                    { 2, 1, "A retired hitman seeks revenge against the people who killed his dog.", "Chad Stahelski", 14.99m, "John Wick" },
                    { 3, 1, "A New York cop faces off against terrorists in a Los Angeles skyscraper.", "John McTiernan", 9.99m, "Die Hard" },
                    { 4, 1, "Batman faces off against the Joker, a criminal mastermind bent on chaos.", "Christopher Nolan", 13.99m, "The Dark Knight" },
                    { 5, 1, "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family.", "Ridley Scott", 11.99m, "Gladiator" },
                    { 6, 2, "Two high school seniors try to make the most of their last days before graduation.", "Greg Mottola", 8.99m, "Superbad" },
                    { 7, 2, "Three friends wake up from a bachelor party with no memory of the previous night and must piece together the events.", "Todd Phillips", 10.99m, "The Hangover" },
                    { 8, 2, "Two dim-witted friends embark on a cross-country trip to return a suitcase full of money.", "Peter Farrelly", 7.99m, "Dumb and Dumber" },
                    { 9, 2, "Two undercover cops are sent to a high school to bust a drug ring.", "Phil Lord", 9.49m, "21 Jump Street" },
                    { 10, 2, "The chaos that follows when a new female anchor joins a 1970s news team.", "Adam McKay", 8.49m, "Anchorman" },
                    { 11, 3, "Two imprisoned men bond over several years, finding solace and eventual redemption through acts of common decency.", "Frank Darabont", 12.49m, "The Shawshank Redemption" },
                    { 12, 3, "The presidencies of Kennedy and Johnson, the Vietnam War, the civil rights movement, and other historical events unfold from the perspective of an Alabama man with an extraordinary life.", "Robert Zemeckis", 11.99m, "Forrest Gump" },
                    { 13, 3, "The story of mathematician John Nash, who struggles with schizophrenia and tries to make a name for himself while dealing with the disorder.", "Ron Howard", 9.99m, "A Beautiful Mind" },
                    { 14, 3, "A struggling salesman takes custody of his son as he's poised to begin a life-changing professional career.", "Gabriele Muccino", 10.49m, "The Pursuit of Happyness" },
                    { 15, 3, "An insomniac office worker forms an underground fight club with a soap salesman, leading to unintended consequences.", "David Fincher", 9.79m, "Fight Club" },
                    { 16, 4, "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", "James Wan", 10.99m, "The Conjuring" },
                    { 17, 4, "Several people are hunted by a man who uses their fear of the dark and sleep to murder them in their dreams.", "Wes Craven", 9.49m, "A Nightmare on Elm Street" },
                    { 18, 4, "When a young girl is possessed by a mysterious entity, her mother seeks the help of two priests to save her.", "William Friedkin", 11.99m, "The Exorcist" },
                    { 19, 4, "A group of misfit children band together to defeat a shape-shifting entity that terrorizes their town.", "Andy Muschietti", 12.99m, "It" },
                    { 20, 4, "A grieving family is haunted after the death of their secretive grandmother.", "Ari Aster", 13.49m, "Hereditary" },
                    { 21, 5, "A thief who enters the dreams of others to steal secrets from their subconscious is given the task of planting an idea into a target's subconscious.", "Christopher Nolan", 14.99m, "Inception" },
                    { 22, 5, "A blade runner must pursue and terminate four replicants who stole a ship in space, and have returned to Earth to find their creator.", "Ridley Scott", 12.99m, "Blade Runner" },
                    { 23, 5, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "Lana Wachowski, Lilly Wachowski", 13.49m, "The Matrix" },
                    { 24, 5, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", 15.99m, "Interstellar" },
                    { 25, 5, "A young farmer sets out to rescue a princess from an evil galactic empire with the help of a powerful force and a team of companions.", "George Lucas", 14.49m, "Star Wars: A New Hope" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
