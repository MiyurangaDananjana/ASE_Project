using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuellingTrackingWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QR_CODE",
                table: "CUSTOMER_DETAILS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "USE_QUANTITY",
                table: "CUSTOMER_DETAILS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WEEKLY_QUANTITY",
                table: "CUSTOMER_DETAILS",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QR_CODE",
                table: "CUSTOMER_DETAILS");

            migrationBuilder.DropColumn(
                name: "USE_QUANTITY",
                table: "CUSTOMER_DETAILS");

            migrationBuilder.DropColumn(
                name: "WEEKLY_QUANTITY",
                table: "CUSTOMER_DETAILS");
        }
    }
}
