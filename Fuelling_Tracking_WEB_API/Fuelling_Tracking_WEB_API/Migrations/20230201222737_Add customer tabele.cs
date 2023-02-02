using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuellingTrackingWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class Addcustomertabele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CUSTOMER_DETAILS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NICNUMBER = table.Column<string>(name: "NIC_NUMBER", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PHONENUMBER = table.Column<string>(name: "PHONE_NUMBER", type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    VEHICALREGNUMBER = table.Column<string>(name: "VEHICAL_REG_NUMBER", type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    VEHICALCHASSISNUMBER = table.Column<string>(name: "VEHICAL_CHASSIS_NUMBER", type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    OTPCODE = table.Column<int>(name: "OTP_CODE", type: "int", nullable: true),
                    OTPSENDDATE = table.Column<DateTime>(name: "OTP_SEND_DATE", type: "datetime", nullable: true),
                    FUELID = table.Column<int>(name: "FUEL_ID", type: "int", nullable: false),
                    FUELSTATION = table.Column<int>(name: "FUEL_STATION", type: "int", nullable: false),
                    STATES = table.Column<int>(type: "int", nullable: true),
                    ACTIVEDATE = table.Column<DateTime>(name: "ACTIVE_DATE", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER_DETAILS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CUSTOMER_DETAILS");
        }
    }
}
