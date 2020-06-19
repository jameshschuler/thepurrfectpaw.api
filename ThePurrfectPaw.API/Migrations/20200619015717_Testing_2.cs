using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class Testing_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Postings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Postings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 1,
                columns: new[] { "IsPublic", "PostDate" },
                values: new object[] { true, new DateTime(2020, 5, 12, 5, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Postings",
                columns: new[] { "PostingId", "Description", "IsPublic", "PostDate", "Title" },
                values: new object[] { 3, null, false, new DateTime(2020, 6, 18, 21, 57, 17, 621, DateTimeKind.Local).AddTicks(8347), "Testing Posting 3" });

            migrationBuilder.InsertData(
                table: "Postings",
                columns: new[] { "PostingId", "Description", "IsPublic", "PostDate", "Title" },
                values: new object[] { 2, null, true, new DateTime(2020, 6, 29, 12, 30, 33, 0, DateTimeKind.Unspecified), "Testing Posting 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Postings");
        }
    }
}
