using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourOfHeroesBackend.Migrations
{
    public partial class update_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroId", "Name" },
                values: new object[,]
                {
                    { 4, "Electra" },
                    { 5, "Catwoman" },
                    { 6, "Thor" },
                    { 7, "Hulk" },
                    { 8, "Robin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "HeroId",
                keyValue: 8);
        }
    }
}
