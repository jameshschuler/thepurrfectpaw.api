using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AddedLocationModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 23, 9, 39, 709, DateTimeKind.Local).AddTicks(305));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 23, 4, 39, 449, DateTimeKind.Local).AddTicks(3744));
        }
    }
}
