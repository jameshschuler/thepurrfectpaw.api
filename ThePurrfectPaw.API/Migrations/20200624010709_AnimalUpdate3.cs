using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AnimalUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 23, 21, 7, 9, 302, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 4,
                column: "Title",
                value: "Test Run 123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 23, 20, 24, 31, 889, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 4,
                column: "Title",
                value: "Testing Posting 4");
        }
    }
}
