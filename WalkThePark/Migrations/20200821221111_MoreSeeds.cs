using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class MoreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "AccessPrice", "Name", "State" },
                values: new object[,]
                {
                    { 7, 0, "John_Day_Fossil_Beds", "Oregon" },
                    { 8, 0, "Oregon_Dunes_National_Recreation_Area", "Oregon" },
                    { 9, 15, "Mount_Rainier_National_Park", "Washington" },
                    { 10, 15, "Yosemite_National_Park", "California" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "County", "Name", "State" },
                values: new object[,]
                {
                    { 7, "Marion", "Champoeg_State_Heritage_Area", "Oregon" },
                    { 8, "Clackamas", "Milo_McIver_State_Park", "Oregon" },
                    { 9, "Skamania", "Beacon_Rock_State_Park", "Washington" },
                    { 10, "Santa_Cruz", "Castle_Rock_State_Park", "California" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 10);
        }
    }
}
