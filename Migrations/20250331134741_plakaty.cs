using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektSklepTI.Migrations
{
    public partial class plakaty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Poster",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Poster",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "Poster",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "Poster",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "Poster",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "Poster",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7,
                column: "Poster",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8,
                column: "Poster",
                value: "8.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9,
                column: "Poster",
                value: "9.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10,
                column: "Poster",
                value: "10.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11,
                column: "Poster",
                value: "11.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12,
                column: "Poster",
                value: "12.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13,
                column: "Poster",
                value: "13.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14,
                column: "Poster",
                value: "14.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15,
                column: "Poster",
                value: "15.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16,
                column: "Poster",
                value: "16.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17,
                column: "Poster",
                value: "17.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18,
                column: "Poster",
                value: "18.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19,
                column: "Poster",
                value: "19.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20,
                column: "Poster",
                value: "20.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21,
                column: "Poster",
                value: "21.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22,
                column: "Poster",
                value: "22.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23,
                column: "Poster",
                value: "23.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 24,
                column: "Poster",
                value: "24.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 25,
                column: "Poster",
                value: "25.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Films");
        }
    }
}
