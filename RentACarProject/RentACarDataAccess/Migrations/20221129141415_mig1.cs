using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACarDataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    brandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.brandID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    carID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carPrice = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    doors = table.Column<int>(type: "int", nullable: false),
                    brandID = table.Column<int>(type: "int", nullable: false),
                    categoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.carID);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_brandID",
                        column: x => x.brandID,
                        principalTable: "Brands",
                        principalColumn: "brandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarsCategories",
                columns: table => new
                {
                    carID = table.Column<int>(type: "int", nullable: false),
                    categoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsCategories", x => new { x.carID, x.categoryID });
                    table.ForeignKey(
                        name: "FK_CarsCategories_Cars_carID",
                        column: x => x.carID,
                        principalTable: "Cars",
                        principalColumn: "carID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarsCategories_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_brandID",
                table: "Cars",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_CarsCategories_categoryID",
                table: "CarsCategories",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
