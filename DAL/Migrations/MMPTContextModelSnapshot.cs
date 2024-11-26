﻿// <auto-generated />
using System;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(MMPTContext))]
    partial class MMPTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entites.Coordinates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("Data.Entites.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VechicleId")
                        .HasColumnType("integer");

                    b.Property<int?>("VechicleId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VechicleId");

                    b.HasIndex("VechicleId1");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Data.Entites.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ScheduleId")
                        .HasColumnType("integer");

                    b.Property<int?>("ScheduleId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("ScheduleId1");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Data.Entites.RoutePoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CoordinateId")
                        .HasColumnType("integer");

                    b.Property<int?>("CoordinatesId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("VechicleId")
                        .HasColumnType("integer");

                    b.Property<int?>("VechicleId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CoordinateId");

                    b.HasIndex("CoordinatesId");

                    b.HasIndex("VechicleId");

                    b.HasIndex("VechicleId1");

                    b.ToTable("RoutePoints");
                });

            modelBuilder.Entity("Data.Entites.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Data.Entites.Vechicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CoordinatesId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("RouteId")
                        .HasColumnType("integer");

                    b.Property<int?>("RouteId1")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RouteId");

                    b.HasIndex("RouteId1");

                    b.ToTable("Vechicles");
                });

            modelBuilder.Entity("Data.Entites.Driver", b =>
                {
                    b.HasOne("Data.Entites.Vechicle", "Vechicle")
                        .WithMany()
                        .HasForeignKey("VechicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Vechicle", null)
                        .WithMany("Drivers")
                        .HasForeignKey("VechicleId1");

                    b.Navigation("Vechicle");
                });

            modelBuilder.Entity("Data.Entites.Route", b =>
                {
                    b.HasOne("Data.Entites.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Schedule", null)
                        .WithMany("Routes")
                        .HasForeignKey("ScheduleId1");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Data.Entites.RoutePoint", b =>
                {
                    b.HasOne("Data.Entites.Coordinates", "Coordinate")
                        .WithMany()
                        .HasForeignKey("CoordinateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Coordinates", null)
                        .WithMany("RoutePoints")
                        .HasForeignKey("CoordinatesId");

                    b.HasOne("Data.Entites.Vechicle", "Vechicle")
                        .WithMany()
                        .HasForeignKey("VechicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Vechicle", null)
                        .WithMany("History")
                        .HasForeignKey("VechicleId1");

                    b.Navigation("Coordinate");

                    b.Navigation("Vechicle");
                });

            modelBuilder.Entity("Data.Entites.Vechicle", b =>
                {
                    b.HasOne("Data.Entites.Coordinates", null)
                        .WithMany("Vechicles")
                        .HasForeignKey("CoordinatesId");

                    b.HasOne("Data.Entites.Coordinates", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entites.Route", null)
                        .WithMany("Vechicles")
                        .HasForeignKey("RouteId1");

                    b.Navigation("Location");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Data.Entites.Coordinates", b =>
                {
                    b.Navigation("RoutePoints");

                    b.Navigation("Vechicles");
                });

            modelBuilder.Entity("Data.Entites.Route", b =>
                {
                    b.Navigation("Vechicles");
                });

            modelBuilder.Entity("Data.Entites.Schedule", b =>
                {
                    b.Navigation("Routes");
                });

            modelBuilder.Entity("Data.Entites.Vechicle", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("History");
                });
#pragma warning restore 612, 618
        }
    }
}