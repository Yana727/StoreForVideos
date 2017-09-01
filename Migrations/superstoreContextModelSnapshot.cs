﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using StoreForVideos;
using System;

namespace StoreForVideos.Migrations
{
    [DbContext(typeof(superstoreContext))]
    partial class superstoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("StoreForVideos.RentalRecordModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerID");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("MovieID");

                    b.Property<DateTime>("RentalDate");

                    b.Property<int>("RentalID");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("Id");

                    b.ToTable("RentalRecordModel");
                });
#pragma warning restore 612, 618
        }
    }
}