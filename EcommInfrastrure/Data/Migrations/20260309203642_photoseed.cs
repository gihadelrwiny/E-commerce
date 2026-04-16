using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommInfrastrure.Data.Migrations
{
    /// <inheritdoc />
    public partial class photoseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "id", "imagename", "productid" },
                values: new object[] { 1, "photo1", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
