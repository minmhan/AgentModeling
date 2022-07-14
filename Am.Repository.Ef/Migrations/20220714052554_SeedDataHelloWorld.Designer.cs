﻿// <auto-generated />
using System;
using Am.Repository.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Am.Repository.Ef.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220714052554_SeedDataHelloWorld")]
    partial class SeedDataHelloWorld
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Am.Infrastructure.Entities.HelloWorld", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("HelloWorld");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "minmhan",
                            CreatedDate = new DateTime(2022, 7, 14, 5, 25, 54, 171, DateTimeKind.Utc).AddTicks(8419),
                            IsActive = true,
                            Message = "Hello World Message",
                            UpdatedBy = "minmhan",
                            UpdatedDate = new DateTime(2022, 7, 14, 5, 25, 54, 171, DateTimeKind.Utc).AddTicks(8420)
                        });
                });

            modelBuilder.Entity("Am.Infrastructure.Entities.WeatherForecast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Summary")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("integer");

                    b.Property<int>("TemperatureF")
                        .HasColumnType("integer");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecast");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedBy = "minmhan",
                            CreatedDate = new DateTime(2022, 7, 14, 5, 25, 54, 171, DateTimeKind.Utc).AddTicks(8296),
                            Date = new DateTime(2022, 7, 14, 5, 25, 54, 171, DateTimeKind.Utc).AddTicks(8294),
                            IsActive = true,
                            Summary = "Dummy Data",
                            TemperatureC = 32,
                            TemperatureF = 98,
                            UpdatedBy = "minmhan",
                            UpdatedDate = new DateTime(2022, 7, 14, 5, 25, 54, 171, DateTimeKind.Utc).AddTicks(8297)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
