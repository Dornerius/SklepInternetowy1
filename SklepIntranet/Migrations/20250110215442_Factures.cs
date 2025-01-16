using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepIntranet.Migrations
{
    /// <inheritdoc />
    public partial class Factures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    IdFacture = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrFacture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFacture = table.Column<DateOnly>(type: "date", nullable: false),
                    DateSale = table.Column<DateOnly>(type: "date", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientNdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientNdSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAdressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAdressStreetNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceNetto = table.Column<decimal>(type: "money", nullable: false),
                    PriceVAT = table.Column<decimal>(type: "money", nullable: false),
                    PriceBrutto = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => x.IdFacture);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factures");
        }
    }
}
