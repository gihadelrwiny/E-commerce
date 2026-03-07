using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommInfrastrure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catogery",
                columns: new[] { "id", "Description", "Name" },
                values: new object[] { 1, "Electronic devices and gadgets", "Electronics" });

            migrationBuilder.InsertData(
                table: "Producs",
                columns: new[] { "id", "CategoryId", "Description", "Name", "price" },
                values: new object[] { 1, 1, "Description for Product 1", "Product 1", 10.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producs",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catogery",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
