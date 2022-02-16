using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Horatiu_Muresan_MediiProiect.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    automatIdent = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    locatieDenumire = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LocAut",
                columns: table => new
                {
                    LocAutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdusID = table.Column<int>(nullable: false),
                    AutomatID = table.Column<int>(nullable: false),
                    LocatieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocAut", x => x.LocAutID);
                    table.ForeignKey(
                        name: "FK_LocAut_Automat_AutomatID",
                        column: x => x.AutomatID,
                        principalTable: "Automat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocAut_Locatie_LocatieID",
                        column: x => x.LocatieID,
                        principalTable: "Locatie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    produsNume = table.Column<string>(maxLength: 30, nullable: false),
                    produsDescriere = table.Column<string>(maxLength: 30, nullable: false),
                    produsData = table.Column<DateTime>(nullable: false),
                    produsExp = table.Column<DateTime>(nullable: false),
                    AutomatID = table.Column<int>(nullable: false),
                    LocatieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produs_Automat_AutomatID",
                        column: x => x.AutomatID,
                        principalTable: "Automat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produs_Locatie_LocatieID",
                        column: x => x.LocatieID,
                        principalTable: "Locatie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocAut_AutomatID",
                table: "LocAut",
                column: "AutomatID");

            migrationBuilder.CreateIndex(
                name: "IX_LocAut_LocatieID",
                table: "LocAut",
                column: "LocatieID");

            migrationBuilder.CreateIndex(
                name: "IX_Produs_AutomatID",
                table: "Produs",
                column: "AutomatID");

            migrationBuilder.CreateIndex(
                name: "IX_Produs_LocatieID",
                table: "Produs",
                column: "LocatieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocAut");

            migrationBuilder.DropTable(
                name: "Produs");

            migrationBuilder.DropTable(
                name: "Automat");

            migrationBuilder.DropTable(
                name: "Locatie");
        }
    }
}
