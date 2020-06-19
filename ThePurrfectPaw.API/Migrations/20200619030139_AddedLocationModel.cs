using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AddedLocationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Shelters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 13, nullable: false),
                    StateAbbreviation = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "State", "StateAbbreviation", "Zipcode" },
                values: new object[,]
                {
                    { 1, "Rochester", "US", "New York", "NY", "" },
                    { 2, "Buffalo", "US", "New York", "NY", "" },
                    { 3, "Albany", "US", "New York", "NY", "" }
                });

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 23, 1, 38, 828, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "ShelterId",
                keyValue: 1,
                column: "LocationId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Shelters_LocationId",
                table: "Shelters",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelters_Locations_LocationId",
                table: "Shelters",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelters_Locations_LocationId",
                table: "Shelters");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Shelters_LocationId",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Shelters");

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 22, 34, 2, 805, DateTimeKind.Local).AddTicks(1653));
        }
    }
}
