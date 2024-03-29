﻿// <auto-generated />
using System;
using FlightApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlightApplication.Migrations
{
    [DbContext(typeof(FlightTicketDbContext))]
    [Migration("20230717100242_UserId")]
    partial class UserId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FlightApplication.Models.FlightTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Class")
                        .HasColumnType("integer");

                    b.Property<int>("Destination")
                        .HasColumnType("integer");

                    b.Property<int>("From")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FromTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Meal")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("FlightTicket");
                });

            modelBuilder.Entity("FlightApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("FlightTicketId")
                        .HasColumnType("integer");

                    b.Property<int?>("FlightTicketId1")
                        .HasColumnType("integer");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FlightTicketId1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FlightApplication.Models.User", b =>
                {
                    b.HasOne("FlightApplication.Models.FlightTicket", "FlightTicket")
                        .WithMany()
                        .HasForeignKey("FlightTicketId1");

                    b.Navigation("FlightTicket");
                });
#pragma warning restore 612, 618
        }
    }
}
