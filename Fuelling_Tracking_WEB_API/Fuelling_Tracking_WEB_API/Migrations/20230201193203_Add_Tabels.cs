using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuellingTrackingWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FUEL_REQ",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUELSTATIONID = table.Column<int>(name: "FUEL_STATION_ID", type: "int", nullable: true),
                    FUELTYPE = table.Column<int>(name: "FUEL_TYPE", type: "int", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: true),
                    STATES = table.Column<int>(type: "int", nullable: true),
                    DATETIME = table.Column<DateTime>(name: "DATE_TIME", type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelReq", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FUEL_TYPE",
                columns: table => new
                {
                    FUEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUELTYPE = table.Column<string>(name: "FUEL_TYPE", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUEL_TYPE", x => x.FUEID);
                });

            migrationBuilder.CreateTable(
                name: "FULE_STATION",
                columns: table => new
                {
                    FUELSTATIONID = table.Column<int>(name: "FUEL_STATION_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUELSTATIONREGCODE = table.Column<string>(name: "FUEL_STATION_REG_CODE", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PROVITION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CITY = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ADDRESS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PETROLQUANTITY = table.Column<int>(name: "PETROL_QUANTITY", type: "int", nullable: false),
                    DIESELQUANTITY = table.Column<int>(name: "DIESEL_QUANTITY", type: "int", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FULE_STATION", x => x.FUELSTATIONID);
                });

            migrationBuilder.CreateTable(
                name: "VEHICAL_TYPE",
                columns: table => new
                {
                    VEHICALTYPEID = table.Column<int>(name: "VEHICAL_TYPE_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEHICALNAME = table.Column<string>(name: "VEHICAL_NAME", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FUELQUANTITY = table.Column<int>(type: "int", nullable: true),
                    FUELTYPEID = table.Column<int>(name: "FUEL_TYPE_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICAL_TYPE", x => x.VEHICALTYPEID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FUEL_REQ");

            migrationBuilder.DropTable(
                name: "FUEL_TYPE");

            migrationBuilder.DropTable(
                name: "FULE_STATION");

            migrationBuilder.DropTable(
                name: "VEHICAL_TYPE");
        }
    }
}
