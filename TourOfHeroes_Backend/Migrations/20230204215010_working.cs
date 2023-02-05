using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourOfHeroesBackend.Migrations
{
    public partial class working : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { 1, "Spiderman" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { 2, "Superman" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { 3, "Ironman" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { -3, "hero3" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { -2, "hero2" });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[] { -1, "hero1" });
        }
    }
}
