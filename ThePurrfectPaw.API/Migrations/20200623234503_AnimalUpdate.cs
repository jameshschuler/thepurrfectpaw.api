using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AnimalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Shelters",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Shelters",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Postings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Locations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Berry", null },
                    { 2, "Bernard", null },
                    { 3, "Peanut", null }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "Address",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "Address",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "Address",
                value: "");

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 1,
                column: "AnimalId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 2,
                column: "AnimalId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                columns: new[] { "AnimalId", "PostDate" },
                values: new object[] { 3, new DateTime(2020, 6, 23, 19, 45, 2, 718, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.CreateIndex(
                name: "IX_Postings_AnimalId",
                table: "Postings",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postings_Animals_AnimalId",
                table: "Postings",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "AnimalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postings_Animals_AnimalId",
                table: "Postings");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Postings_AnimalId",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 23, 9, 39, 709, DateTimeKind.Local).AddTicks(305));
        }
    }
}
