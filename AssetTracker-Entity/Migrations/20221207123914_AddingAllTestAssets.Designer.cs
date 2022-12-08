﻿// <auto-generated />
using System;
using AssetTracker_Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetTrackerEntity.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221207123914_AddingAllTestAssets")]
    partial class AddingAllTestAssets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssetTracker_Entity.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "HP",
                            Model = "Elitebook",
                            Office = "Germany",
                            Price = 8423.0,
                            PurchaseDate = new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "iPhone",
                            Model = "11",
                            Office = "Germany",
                            Price = 3990.0,
                            PurchaseDate = new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Lenovo",
                            Model = "Yoga 730",
                            Office = "USA",
                            Price = 9835.0,
                            PurchaseDate = new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Samsung",
                            Model = "20",
                            Office = "Sweden",
                            Price = 6245.0,
                            PurchaseDate = new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "HP",
                            Model = "Elitebook",
                            Office = "Sweden",
                            Price = 9588.0,
                            PurchaseDate = new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Asus",
                            Model = "W234",
                            Office = "USA",
                            Price = 10200.0,
                            PurchaseDate = new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "iPhone",
                            Model = "8",
                            Office = "Germany",
                            Price = 1970.0,
                            PurchaseDate = new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Acer",
                            Model = "Aspire",
                            Office = "USA",
                            Price = 6030.0,
                            PurchaseDate = new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Motorola",
                            Model = "Razr",
                            Office = "Sweden",
                            Price = 970.0,
                            PurchaseDate = new DateTime(2020, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Phone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
