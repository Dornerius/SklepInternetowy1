using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepIntranet.Migrations
{
    /// <inheritdoc />
    public partial class PageNewsProtuctProductType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    IdNews = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.IdNews);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    IdPage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkTitle = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Pozition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.IdPage);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdOfProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeOfProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfProduct = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IdOfProduct);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    IdProductType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductTypeSubName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.IdProductType);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
