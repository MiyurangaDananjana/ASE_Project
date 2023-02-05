using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuellingTrackingWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStaockTb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "CUSTOMER_DETAILS",
                type: "varchar(12)",
                unicode: false,
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.CreateTable(
                name: "FUEL_STATION_STOCK",
                columns: table => new
                {
                    FSSID = table.Column<int>(name: "F_S_S_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FSID = table.Column<int>(name: "F_S_ID", type: "int", nullable: false),
                    FTID = table.Column<int>(name: "F_T_ID", type: "int", nullable: false),
                    MAINSTOCK = table.Column<int>(name: "MAIN_STOCK", type: "int", nullable: false),
                    AVAILABLESTOCK = table.Column<int>(name: "AVAILABLE_STOCK", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUEL_STATION_STOCK", x => x.FSSID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FUEL_STATION_STOCK");

            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "CUSTOMER_DETAILS",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldUnicode: false,
                oldMaxLength: 12);
        }
    }
}
