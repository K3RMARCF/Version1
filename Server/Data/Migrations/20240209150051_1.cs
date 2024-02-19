using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracTest.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 23, 0, 51, 328, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateCreated", "DateUpdated", "DueDate", "IsCompleted", "TaskName", "UpdatedBy" },
                values: new object[] { 2, "User2", new DateTime(2024, 2, 9, 23, 0, 51, 328, DateTimeKind.Local).AddTicks(4347), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2028, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kenneth", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 22, 17, 44, 16, DateTimeKind.Local).AddTicks(9164));
        }
    }
}
