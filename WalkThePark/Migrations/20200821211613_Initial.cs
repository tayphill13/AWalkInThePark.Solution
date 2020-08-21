using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    AccessPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "AccessPrice", "Name", "State" },
                values: new object[,]
                {
                    { 1, 30, "Crater_Lake_National_Park", "Oregon" },
                    { 2, 10, "Oregon_Caves_National_Park", "Oregon" },
                    { 3, 10, "Fort_Vancouver_National_Park", "Washington" },
                    { 4, 0, "San_Juan_National_Park", "Washington" },
                    { 5, 0, "Point_Reyes_National_Park", "California" },
                    { 6, 0, "Golden_Gate_National_Park", "California" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "County", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Coos", "Bandon_State_Natural_Area", "Oregon" },
                    { 2, "Linn", "Cascadia_State_Park", "Oregon" },
                    { 3, "Island", "Fort_Ebey_State_Park", "Washington" },
                    { 4, "Kittitas", "Ginkgo_Petrified_Forest", "Washington" },
                    { 5, "El_Dorado", "Emerald_Bay_State_Park", "California" },
                    { 6, "Humboldt", "Grizzly_Creek_Redwoods", "California" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");

            migrationBuilder.DropTable(
                name: "StateParks");
        }
    }
}
