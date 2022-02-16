using Microsoft.EntityFrameworkCore.Migrations;

namespace Horatiu_Muresan_MediiProiect.Migrations
{
    public partial class Oras1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "locatieOras",
                table: "Locatie",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "locatieOras",
                table: "Locatie");
        }
    }
}
