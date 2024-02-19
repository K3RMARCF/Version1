using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracTest.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateCreated", "DateUpdated", "DueDate", "IsCompleted", "TaskName", "UpdatedBy" },
                values: new object[] { 1, "User1", new DateTime(2024, 2, 9, 22, 17, 44, 16, DateTimeKind.Local).AddTicks(9164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "JAMAL", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "tasks");
        }
    }
}
