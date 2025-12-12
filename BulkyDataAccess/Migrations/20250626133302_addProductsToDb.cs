using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBookDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Andrew Hunt & David Thomas", "Classic book on software engineering and best practices.", "978-0201616224", 59.990000000000002, 54.990000000000002, 44.990000000000002, 49.990000000000002, "The Pragmatic Programmer" },
                    { 2, "Martin Fowler", "Improving the design of existing code.", "978-0134757599", 69.989999999999995, 64.989999999999995, 54.990000000000002, 59.990000000000002, "Refactoring" },
                    { 3, "Kyle Simpson", "A deep dive into JavaScript for serious learners.", "978-1091210090", 45.0, 40.0, 34.0, 37.0, "You Don't Know JS Yet" },
                    { 4, "Thomas H. Cormen", "Comprehensive textbook on algorithms.", "978-0262033848", 89.989999999999995, 79.989999999999995, 69.989999999999995, 74.989999999999995, "Introduction to Algorithms" },
                    { 5, "Robert C. Martin", "A guide to building maintainable and scalable software systems.", "978-0134494166", 65.0, 58.0, 50.0, 55.0, "Clean Architecture" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
