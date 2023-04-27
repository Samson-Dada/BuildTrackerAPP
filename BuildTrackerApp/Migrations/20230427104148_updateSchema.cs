using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildTrackerApp.Migrations
{
    public partial class updateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StackStatus",
                table: "Blockers",
                newName: "BlockerStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blockers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blockers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 27, 11, 41, 48, 69, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 27, 11, 41, 48, 69, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 27, 11, 41, 48, 69, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 27, 11, 41, 48, 69, DateTimeKind.Local).AddTicks(9246));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlockerStatus",
                table: "Blockers",
                newName: "StackStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blockers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blockers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Blockers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Builds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 26, 8, 4, 45, 745, DateTimeKind.Local).AddTicks(9910));
        }
    }
}
