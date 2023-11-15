using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorPiano.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Details1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Details1",
                columns: new[] { "Id", "Description", "ImageUrl", "LessonDetails", "Name" },
                values: new object[] { 1, "I am a classically trained musician who has been teaching for over 6 years. I teach casual learners and for ABRSM exams. Styles include classical, contemporary, blues/jazz.", "https://lh3.googleusercontent.com/p/AF1QipP-QQbhWJCGSqHx_Ov9sb0UI33q7gTd-guRmVct=s680-w680-h510", "All ages from 6 to retirement are welcome. Teaching rate: £32.00 per hour Current teaching days in Great Dunmow: Wednesday, Thursday Current availability in Great Dunmow: Thursday 3:30pm-4:00pm and 4:00pm-4:30pm. I can also accommodate fortnightly lessons, please contact for availability. Current teaching days in Bishop Stortford: Monday, Tuesday, Friday, Saturday Current availability in Bishop Stortford: Please contact", "Becky" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A single half hour lesson", "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 20.99m, "One Lesson" },
                    { 2, "Two half hour lessons", "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 30.99m, "Two Lessons" },
                    { 3, "Three half hour lessons", "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 35.99m, "Three Lessons" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details1");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
