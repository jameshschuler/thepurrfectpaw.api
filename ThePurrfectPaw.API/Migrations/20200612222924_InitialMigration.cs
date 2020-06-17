using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePurrfectPaw.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "State" },
                values: new object[] { 1, "Rochester", "New York" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "State" },
                values: new object[] { 2, "Buffalo", "New York" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "State" },
                values: new object[] { 3, "Albany", "New York" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "FirstName", "LastName", "LocationId" },
                values: new object[] { 1, "Berry", null, 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "FirstName", "LastName", "LocationId" },
                values: new object[] { 2, "Bernard", null, 1 });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "FirstName", "LastName", "LocationId" },
                values: new object[] { 3, "Peanut", null, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_LocationId",
                table: "Animals",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
