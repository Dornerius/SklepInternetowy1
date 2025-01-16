using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepIntranet.Migrations
{
    /// <inheritdoc />
    public partial class Client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientIdNumber = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
