using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetTrackerEntity.Migrations
{
    /// <inheritdoc />
    public partial class AddingFirstTestAsset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Brand", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[] { 1, "HP", "Elitebook", "Germany", 8423.0, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
