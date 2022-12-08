using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetTrackerEntity.Migrations
{
    /// <inheritdoc />
    public partial class AddingAllTestAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Brand", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 2, "iPhone", "11", "Germany", 3990.0, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 3, "Lenovo", "Yoga 730", "USA", 9835.0, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop" },
                    { 4, "Samsung", "20", "Sweden", 6245.0, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 5, "HP", "Elitebook", "Sweden", 9588.0, new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 6, "Asus", "W234", "USA", 10200.0, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop" },
                    { 7, "iPhone", "8", "Germany", 1970.0, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 8, "Acer", "Aspire", "USA", 6030.0, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 9, "Motorola", "Razr", "Sweden", 970.0, new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
