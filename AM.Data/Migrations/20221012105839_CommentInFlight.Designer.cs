﻿// <auto-generated />
using System;
using AM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Data.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20221012105839_CommentInFlight")]
    partial class CommentInFlight
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AM.Core.Domain.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveArrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstimatedDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MyPlanePlaneId")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("MyPlanePlaneId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AM.Core.Domain.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassengerId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Passenger");
                });

            modelBuilder.Entity("AM.Core.Domain.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaneId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MyPlaneType")
                        .HasColumnType("int");

                    b.HasKey("PlaneId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.Property<int>("FlightsFlightId")
                        .HasColumnType("int");

                    b.Property<int>("PassengersPassengerId")
                        .HasColumnType("int");

                    b.HasKey("FlightsFlightId", "PassengersPassengerId");

                    b.HasIndex("PassengersPassengerId");

                    b.ToTable("FlightPassenger");
                });

            modelBuilder.Entity("AM.Core.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.Core.Domain.Passenger");

                    b.Property<DateTime>("EmployementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Staff");
                });

            modelBuilder.Entity("AM.Core.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.Core.Domain.Passenger");

                    b.Property<string>("HealthInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Traveller");
                });

            modelBuilder.Entity("AM.Core.Domain.Flight", b =>
                {
                    b.HasOne("AM.Core.Domain.Plane", "MyPlane")
                        .WithMany("Flights")
                        .HasForeignKey("MyPlanePlaneId");

                    b.Navigation("MyPlane");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.HasOne("AM.Core.Domain.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.Core.Domain.Passenger", null)
                        .WithMany()
                        .HasForeignKey("PassengersPassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.Core.Domain.Plane", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
