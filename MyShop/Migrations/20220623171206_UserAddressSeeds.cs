using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Migrations
{
    public partial class UserAddressSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name" },
                values: new object[,]
                {
                    { 1, "someemail1@gmail.com", "Kowalski", "Marcin" },
                    { 2, "someemail2@gmail.com", "Nowak", "Anna" },
                    { 3, "someemail3@gmail.com", "Wybicki", "Tomasz" },
                    { 4, "someemail4@gmail.com", "Nadgórski", "Marek" }
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "City", "Country", "PostalCode", "Street", "UserID" },
                values: new object[,]
                {
                    { 1, "Katowice", "Poland", "40-800", "Długa", 1 },
                    { 2, "Chorzów", "Poland", "42-900", "Krótka", 2 },
                    { 3, "Siemianowice Śląskie", "Poland", "43-900", "Szeroka", 3 },
                    { 4, "Katowice", "Poland", "44-880", "Wąska", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
