using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AnimalUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Animals",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 4, null, "Benjamin", null });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Address", "City", "Country", "State", "StateAbbreviation", "Zipcode" },
                values: new object[] { 4, "99 Victor Rd", "Fairport", "US", "New York", "NY", "14450" });

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 23, 20, 24, 31, 889, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ShelterId", "Description", "Email", "LocationId", "Name", "PhoneNumber" },
                values: new object[] { 2, null, "", 4, "Lollypop Farm", "" });

            migrationBuilder.InsertData(
                table: "Postings",
                columns: new[] { "PostingId", "AnimalId", "Description", "IsPublic", "PostDate", "ShelterId", "Title" },
                values: new object[] { 4, 4, null, true, new DateTime(2020, 6, 20, 12, 30, 33, 0, DateTimeKind.Unspecified), 2, "Testing Posting 4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Animals");

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 23, 19, 45, 2, 718, DateTimeKind.Local).AddTicks(4459));
        }
    }
}
