﻿// <auto-generated />
using FireScan.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FireScan.Migrations
{
    [DbContext(typeof(SqLiteDbContext))]
    [Migration("20200103183334_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("FireScan.Event", b =>
                {
                    b.Property<int>("PrimaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<int>("Comments")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IconUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Timestamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<int>("Uid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrimaryId");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
