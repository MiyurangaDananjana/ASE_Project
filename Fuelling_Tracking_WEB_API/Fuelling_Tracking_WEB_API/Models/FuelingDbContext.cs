using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fuelling_Tracking_WEB_API.Models;

public partial class FuelingDbContext : DbContext
{
    public FuelingDbContext()
    {
    }

    public FuelingDbContext(DbContextOptions<FuelingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FuelReq> FuelReqs { get; set; }

    public virtual DbSet<FuelType> FuelTypes { get; set; }

    public virtual DbSet<FuleStation> FuleStations { get; set; }

    public virtual DbSet<VehicalType> VehicalTypes { get; set; }

    public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

    public virtual DbSet<FuelStationStock> FuelStationStocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EKOD5FK;Database=FUELING_DB;Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
       
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FuelReq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FuelReq");

            entity.ToTable("FUEL_REQ");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME");
            entity.Property(e => e.FuelStationId).HasColumnName("FUEL_STATION_ID");
            entity.Property(e => e.FuelType).HasColumnName("FUEL_TYPE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.States).HasColumnName("STATES");
        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.HasKey(e => e.Fueid);

            entity.ToTable("FUEL_TYPE");

            entity.Property(e => e.Fueid).HasColumnName("FUEID");
            entity.Property(e => e.FuelType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUEL_TYPE");
        });

        modelBuilder.Entity<FuleStation>(entity =>
        {
            entity.HasKey(e => e.FuelStationId);

            entity.ToTable("FULE_STATION");

            entity.Property(e => e.FuelStationId).HasColumnName("FUEL_STATION_ID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.DieselQuantity).HasColumnName("DIESEL_QUANTITY");
            entity.Property(e => e.FuelStationRegCode)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FUEL_STATION_REG_CODE");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PetrolQuantity).HasColumnName("PETROL_QUANTITY");
            entity.Property(e => e.Provition)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVITION");
        });
        modelBuilder.Entity<VehicalType>(entity =>
        {
            entity.ToTable("VEHICAL_TYPE");

            entity.Property(e => e.VehicalTypeId).HasColumnName("VEHICAL_TYPE_ID");
            entity.Property(e => e.FuelTypeId).HasColumnName("FUEL_TYPE_ID");
            entity.Property(e => e.Fuelquantity).HasColumnName("FUELQUANTITY");
            entity.Property(e => e.VehicalName)
                .HasMaxLength(50)
                .HasColumnName("VEHICAL_NAME");
        });

        modelBuilder.Entity<CustomerDetail>(entity =>
        {
            entity.ToTable("CUSTOMER_DETAILS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveDate)
                .HasColumnType("date")
                .HasColumnName("ACTIVE_DATE");
            entity.Property(e => e.FuelId).HasColumnName("FUEL_ID");
            entity.Property(e => e.FuelStation).HasColumnName("FUEL_STATION");
            entity.Property(e => e.NicNumber)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIC_NUMBER");

            entity.Property(e => e.OtpCode).HasColumnName("OTP_CODE");
            entity.Property(e => e.OtpSendDate)
                .HasColumnType("datetime")
                .HasColumnName("OTP_SEND_DATE");

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");

            entity.Property(e => e.States).HasColumnName("STATES");


            entity.Property(e => e.VehicalChassisNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VEHICAL_CHASSIS_NUMBER");

            entity.Property(e => e.VehicalRegNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VEHICAL_REG_NUMBER");
            entity.Property(e => e.QrCode)
                .HasMaxLength(10)
                .HasColumnName("QR_CODE");
            entity.Property(e => e.UseQuantity).HasColumnName("USE_QUANTITY");
            entity.Property(e => e.WeeklyQuantity).HasColumnName("WEEKLY_QUANTITY");
        });

        modelBuilder.Entity<FuelStationStock>(entity =>
        {
            entity.HasKey(e => e.FSSId);

            entity.ToTable("FUEL_STATION_STOCK");

            entity.Property(e => e.FSSId).HasColumnName("F_S_S_ID");
            entity.Property(e => e.AvailableStock).HasColumnName("AVAILABLE_STOCK");
            entity.Property(e => e.FSId).HasColumnName("F_S_ID");
            entity.Property(e => e.FTId).HasColumnName("F_T_ID");
            entity.Property(e => e.MainStock).HasColumnName("MAIN_STOCK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
