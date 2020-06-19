using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class AddedShelterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShelterId",
                table: "Postings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    ShelterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.ShelterId);
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ShelterId", "Description", "Name" },
                values: new object[] { 1, null, "Verona Street Animal Society" });

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 1,
                column: "ShelterId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 2,
                columns: new[] { "PostDate", "ShelterId" },
                values: new object[] { new DateTime(2020, 6, 5, 12, 30, 33, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                columns: new[] { "PostDate", "ShelterId" },
                values: new object[] { new DateTime(2020, 6, 18, 22, 34, 2, 805, DateTimeKind.Local).AddTicks(1653), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Postings_ShelterId",
                table: "Postings",
                column: "ShelterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postings_Shelters_ShelterId",
                table: "Postings",
                column: "ShelterId",
                principalTable: "Shelters",
                principalColumn: "ShelterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postings_Shelters_ShelterId",
                table: "Postings");

            migrationBuilder.DropTable(
                name: "Shelters");

            migrationBuilder.DropIndex(
                name: "IX_Postings_ShelterId",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "ShelterId",
                table: "Postings");

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2020, 6, 29, 12, 30, 33, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postings",
                keyColumn: "PostingId",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2020, 6, 18, 21, 57, 17, 621, DateTimeKind.Local).AddTicks(8347));
        }
    }
}
