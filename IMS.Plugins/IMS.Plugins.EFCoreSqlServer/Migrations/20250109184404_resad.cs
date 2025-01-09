using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Plugins.EFCoreSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class resad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "InventoryName",
                value: "Profil");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "InventoryName",
                value: "Okovi");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "InventoryName",
                value: "Lim");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "InventoryName",
                value: "Sina");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductName",
                value: "Kapija");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductName",
                value: "Ograda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1,
                column: "InventoryName",
                value: "Bike Seat");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2,
                column: "InventoryName",
                value: "Bike Body");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 3,
                column: "InventoryName",
                value: "Bike Wheel");

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 4,
                column: "InventoryName",
                value: "Bike Pedal");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductName",
                value: "Bike");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductName",
                value: "Car");
        }
    }
}
