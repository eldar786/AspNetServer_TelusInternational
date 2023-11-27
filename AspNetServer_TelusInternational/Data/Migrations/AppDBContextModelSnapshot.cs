﻿// <auto-generated />
using AspNetServer_TelusInternational.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetServer_TelusInternational.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("AspNetServer_TelusInternational.Data.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AHT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ATT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Handled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Offered")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Queue_Group_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("ServiceLevel")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 1,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 1",
                            ServiceLevel = 1
                        },
                        new
                        {
                            PostId = 2,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 2,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 2",
                            ServiceLevel = 2
                        },
                        new
                        {
                            PostId = 3,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 3,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 3",
                            ServiceLevel = 3
                        },
                        new
                        {
                            PostId = 4,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 4,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 4",
                            ServiceLevel = 4
                        },
                        new
                        {
                            PostId = 5,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 5,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 5",
                            ServiceLevel = 5
                        },
                        new
                        {
                            PostId = 6,
                            AHT = "00:00:00",
                            ATT = "00:00:00",
                            Handled = 6,
                            Offered = 0,
                            Queue_Group_Name = "Queue group name 6",
                            ServiceLevel = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}