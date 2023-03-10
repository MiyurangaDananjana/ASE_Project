// <auto-generated />
using System;
using Fuelling_Tracking_WEB_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuellingTrackingWEBAPI.Migrations
{
    [DbContext(typeof(FuelingDbContext))]
    [Migration("20230201222737_Add customer tabele")]
    partial class Addcustomertabele
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fuelling_Tracking_WEB_API.Models.CustomerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ActiveDate")
                        .HasColumnType("date")
                        .HasColumnName("ACTIVE_DATE");

                    b.Property<int>("FuelId")
                        .HasColumnType("int")
                        .HasColumnName("FUEL_ID");

                    b.Property<int>("FuelStation")
                        .HasColumnType("int")
                        .HasColumnName("FUEL_STATION");

                    b.Property<string>("NicNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NIC_NUMBER");

                    b.Property<int?>("OtpCode")
                        .HasColumnType("int")
                        .HasColumnName("OTP_CODE");

                    b.Property<DateTime?>("OtpSendDate")
                        .HasColumnType("datetime")
                        .HasColumnName("OTP_SEND_DATE");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PHONE_NUMBER")
                        .IsFixedLength();

                    b.Property<int?>("States")
                        .HasColumnType("int")
                        .HasColumnName("STATES");

                    b.Property<string>("VehicalChassisNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("VEHICAL_CHASSIS_NUMBER");

                    b.Property<string>("VehicalRegNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("VEHICAL_REG_NUMBER");

                    b.HasKey("Id");

                    b.ToTable("CUSTOMER_DETAILS", (string)null);
                });

            modelBuilder.Entity("Fuelling_Tracking_WEB_API.Models.FuelReq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("DATE_TIME");

                    b.Property<int?>("FuelStationId")
                        .HasColumnType("int")
                        .HasColumnName("FUEL_STATION_ID");

                    b.Property<int?>("FuelType")
                        .HasColumnType("int")
                        .HasColumnName("FUEL_TYPE");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.Property<int?>("States")
                        .HasColumnType("int")
                        .HasColumnName("STATES");

                    b.HasKey("Id")
                        .HasName("PK_FuelReq");

                    b.ToTable("FUEL_REQ", (string)null);
                });

            modelBuilder.Entity("Fuelling_Tracking_WEB_API.Models.FuelType", b =>
                {
                    b.Property<int>("Fueid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FUEID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fueid"));

                    b.Property<string>("FuelType1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FUEL_TYPE");

                    b.HasKey("Fueid");

                    b.ToTable("FUEL_TYPE", (string)null);
                });

            modelBuilder.Entity("Fuelling_Tracking_WEB_API.Models.FuleStation", b =>
                {
                    b.Property<int>("FuelStationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FUEL_STATION_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuelStationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ADDRESS");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CITY");

                    b.Property<int>("DieselQuantity")
                        .HasColumnType("int")
                        .HasColumnName("DIESEL_QUANTITY");

                    b.Property<string>("FuelStationRegCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FUEL_STATION_REG_CODE");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PASSWORD");

                    b.Property<int>("PetrolQuantity")
                        .HasColumnType("int")
                        .HasColumnName("PETROL_QUANTITY");

                    b.Property<string>("Provition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PROVITION");

                    b.HasKey("FuelStationId");

                    b.ToTable("FULE_STATION", (string)null);
                });

            modelBuilder.Entity("Fuelling_Tracking_WEB_API.Models.VehicalType", b =>
                {
                    b.Property<int>("VehicalTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VEHICAL_TYPE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicalTypeId"));

                    b.Property<int?>("FuelTypeId")
                        .HasColumnType("int")
                        .HasColumnName("FUEL_TYPE_ID");

                    b.Property<int?>("Fuelquantity")
                        .HasColumnType("int")
                        .HasColumnName("FUELQUANTITY");

                    b.Property<string>("VehicalName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("VEHICAL_NAME");

                    b.HasKey("VehicalTypeId");

                    b.ToTable("VEHICAL_TYPE", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
