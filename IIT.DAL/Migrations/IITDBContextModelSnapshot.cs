﻿// <auto-generated />
using System;
using IIT.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IIT.DAL.Migrations
{
    [DbContext(typeof(IITDBContext))]
    partial class IITDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IIT.DAL.Entities.Bookings.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<int>("BookingStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("BookingStatusId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Bookings.BookingStatus", b =>
                {
                    b.Property<int>("BookingStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingStatusId"), 1L, 1);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingStatusId");

                    b.ToTable("BookingsStatus");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.UserDetails", b =>
                {
                    b.Property<int>("UserDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserDetailsId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserDetailsId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTypeId"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"), 1L, 1);

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.WarehouseDetails", b =>
                {
                    b.Property<int>("WarehouseDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseDetailsId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.Property<int?>("WarehouseTypeId")
                        .HasColumnType("int");

                    b.HasKey("WarehouseDetailsId");

                    b.HasIndex("WarehouseId")
                        .IsUnique();

                    b.HasIndex("WarehouseTypeId");

                    b.ToTable("WarehouseDetails");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.WarehouseType", b =>
                {
                    b.Property<int>("WarehouseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseTypeId"), 1L, 1);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseTypeId");

                    b.ToTable("WarehouseTypes");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Bookings.Booking", b =>
                {
                    b.HasOne("IIT.DAL.Entities.Bookings.BookingStatus", "BookingStatus")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIT.DAL.Entities.Users.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIT.DAL.Entities.Warehouses.Warehouse", "Warehouse")
                        .WithMany("Bookings")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingStatus");

                    b.Navigation("User");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.User", b =>
                {
                    b.HasOne("IIT.DAL.Entities.Users.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.UserDetails", b =>
                {
                    b.HasOne("IIT.DAL.Entities.Users.User", "User")
                        .WithOne("UserDetails")
                        .HasForeignKey("IIT.DAL.Entities.Users.UserDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.WarehouseDetails", b =>
                {
                    b.HasOne("IIT.DAL.Entities.Warehouses.Warehouse", "Warehouse")
                        .WithOne("WarehouseDetails")
                        .HasForeignKey("IIT.DAL.Entities.Warehouses.WarehouseDetails", "WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIT.DAL.Entities.Warehouses.WarehouseType", "WarehouseType")
                        .WithMany("WarehouseDetails")
                        .HasForeignKey("WarehouseTypeId");

                    b.Navigation("Warehouse");

                    b.Navigation("WarehouseType");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Bookings.BookingStatus", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("UserDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("IIT.DAL.Entities.Users.UserType", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.Warehouse", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("WarehouseDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("IIT.DAL.Entities.Warehouses.WarehouseType", b =>
                {
                    b.Navigation("WarehouseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
