using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRN232.LMS.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 4,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 8,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 11,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 14,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 24,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 41,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 42,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 65,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 66,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 174,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 175,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 176,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 177,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 202,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 203,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 208,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 209,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 210,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 211,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 213,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 214,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 217,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 218,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 238,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 239,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 273,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 274,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 307,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 308,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 312,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 313,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 319,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 320,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 325,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 326,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 330,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 331,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 382,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 383,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 393,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 394,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 404,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 405,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 406,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 431,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 432,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 433,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 434,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 438,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 439,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 446,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 447,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 451,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 452,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 494,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 495,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 496,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 497,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 498,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 499,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 500,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "$2a$11$N9qo8uLOickgx2ZMRZoMyeIjZAgcfl7p92ldGxad68LJZdL17lhWy", "Admin", "admin" },
                    { 2, "$2a$11$N9qo8uLOickgx2ZMRZoMyeIjZAgcfl7p92ldGxad68LJZdL17lhWy", "User", "user1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 1,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 2,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 3,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 4,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 5,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 6,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 7,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 8,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 9,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 10,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 11,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 12,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 13,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 14,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 15,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 16,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 17,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 18,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 19,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 20,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 21,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 22,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 23,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 24,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 25,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 26,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 27,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 28,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 29,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 30,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 31,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 32,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 33,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 34,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 35,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 36,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 37,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 38,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 39,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 40,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 41,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 42,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 43,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 44,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 45,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 46,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 47,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 48,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 49,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 50,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 51,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 52,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 53,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 54,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 55,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 56,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 57,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 58,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 59,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 60,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 61,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 62,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 63,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 64,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 65,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 66,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 67,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 68,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 69,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 70,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 71,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 72,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 73,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 74,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 75,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 76,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 77,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 78,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 79,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 80,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 81,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 82,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 83,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 84,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 85,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 86,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 87,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 88,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 89,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 90,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 91,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 92,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 93,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 94,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 95,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 96,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 97,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 98,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 99,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 100,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 101,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 102,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 103,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 104,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 105,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 106,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 107,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 108,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 109,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 110,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 111,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 112,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 113,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 114,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 115,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 116,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 117,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 118,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 119,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 120,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 121,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 122,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 123,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 124,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 125,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 126,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 127,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 128,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 129,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 130,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 131,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 132,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 133,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 134,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 135,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 136,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 137,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 138,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 139,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 140,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 141,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 142,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 143,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 144,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 145,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 146,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 147,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 148,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 149,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 150,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 151,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 152,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 153,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 154,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 155,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 156,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 157,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 158,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 159,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 160,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 161,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 162,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 163,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 164,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 165,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 166,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 167,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 168,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 169,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 170,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 171,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 172,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 173,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 174,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 175,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 176,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 177,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 178,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 179,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 180,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 181,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 182,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 183,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 184,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 185,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 186,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 187,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 188,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 189,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 190,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 191,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 192,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 193,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 194,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 195,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 196,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 197,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 198,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 199,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 200,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 201,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 202,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 203,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 204,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 205,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 206,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 207,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 208,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 209,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 210,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 211,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 212,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 213,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 214,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 215,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 216,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 217,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 218,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 219,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 220,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 221,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 222,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 223,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 224,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 225,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 226,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 227,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 228,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 229,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 230,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 231,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 232,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 233,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 234,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 235,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 236,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 237,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 238,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 239,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 240,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 241,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 242,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 243,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 244,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 245,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 246,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 247,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 248,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 249,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 250,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 251,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 252,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 253,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 254,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 255,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 256,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 257,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 258,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 259,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 260,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 261,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 262,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 263,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 264,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 265,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 266,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 267,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 268,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 269,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 270,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 271,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 272,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 273,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 274,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 275,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 276,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 277,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 278,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 279,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 280,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 281,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 282,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 283,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 284,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 285,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 286,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 287,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 288,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 289,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 290,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 291,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 292,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 293,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 294,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 295,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 296,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 297,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 298,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 299,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 300,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 301,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 302,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 303,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 304,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 305,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 306,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 307,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 308,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 309,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 310,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 311,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 312,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 313,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 314,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 315,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 316,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 317,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 318,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 319,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 320,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 321,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 322,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 323,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 324,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 325,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 326,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 327,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 328,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 329,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 330,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 331,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 332,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 333,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 334,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 335,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 336,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 337,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 338,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 339,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 340,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 341,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 342,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 343,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 344,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 345,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 346,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 347,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 348,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 349,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 350,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 351,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 352,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 353,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 354,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 355,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 356,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 357,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 358,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 359,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 360,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 361,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 362,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 363,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 364,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 365,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 366,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 367,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 368,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 369,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 370,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 371,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 372,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 373,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 374,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 375,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 376,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 377,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 378,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 379,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 380,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 381,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 382,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 383,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 384,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 385,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 386,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 387,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 388,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 389,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 390,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 391,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 392,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 393,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 394,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 395,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 396,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 397,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 398,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 399,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 400,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 401,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 402,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 403,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 404,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 405,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 406,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 407,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 408,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 409,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 410,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 411,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 412,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 413,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 414,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 415,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 416,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 417,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 418,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 419,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 420,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 421,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 422,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 423,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 424,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 425,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 426,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 427,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 428,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 429,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 430,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 431,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 432,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 433,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 434,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 435,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 436,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 437,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 438,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 439,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 440,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 441,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 442,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 443,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 444,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 445,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 446,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 447,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 448,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 449,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 450,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 451,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 452,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 453,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 454,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 455,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 456,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 457,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 458,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 459,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 460,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 461,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 462,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 463,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 464,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 465,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 466,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 467,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 468,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 469,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 470,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 471,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 472,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 473,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 474,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 475,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 476,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 477,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 478,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 479,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 480,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 481,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 482,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 483,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 484,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 485,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 486,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 487,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 488,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 489,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 490,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 491,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 492,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 493,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 494,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 495,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 496,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 497,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 498,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 499,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 500,
                columns: new[] { "EnrollDate", "Status" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" });
        }
    }
}
