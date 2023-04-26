using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildTrackerApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blockers",
                columns: new[] { "Id", "CreatedTime", "Description", "Priority", "Role", "ShortDescription", "StackStatus", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9919), "Unable to found package you are using", 1, 0, "Packege not supported", 1, "Error code" },
                    { 2, new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9927), "Testing fail due to logical error that the function return", 1, 0, "Testing fail", 4, "Test" }
                });

            migrationBuilder.InsertData(
                table: "Builds",
                columns: new[] { "Id", "CloseTask", "CreatedTime", "Description", "OpenTask", "Role", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9884), "new post request that send data to the list of build", 5, 0, "New post method", "Add new method" },
                    { 2, 2, new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9910), "new UI for customer to view number of sales ", 6, 3, "New UI for customer", "new UI" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "ProductRole", "Role", "Status", "Task" },
                values: new object[,]
                {
                    { 1, "johnd@harmonica.com", "John", "", "Deo", "Team Lead", "Product Manager", true, "Scrum Master" },
                    { 2, "pablos@harmonica.com", "Pablo", "", "Seun", "Agile Team", "Backend Engineer", true, "Web APIs" },
                    { 3, "cayoteb@harmonica.com", "Cayote", "", "Bola", "Agile Team", "Product Desginer", false, "Design UI & UX" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
