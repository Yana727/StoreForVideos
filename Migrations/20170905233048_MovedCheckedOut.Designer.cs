﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StoreForVideos;
using System;

namespace StoreForVideos.Migrations
{
    [DbContext(typeof(superstoreContext))]
    [Migration("20170905233048_MovedCheckedOut")]
    partial class MovedCheckedOut
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("StoreForVideos.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName");

                    b.Property<int>("CustomerPhone");

                    b.HasKey("Id");

                    b.ToTable("CustomerModel");
                });

            modelBuilder.Entity("StoreForVideos.Models.GenreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreName");

                    b.HasKey("Id");

                    b.ToTable("GenreModel");
                });

            modelBuilder.Entity("StoreForVideos.Models.MovieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckedOut");

                    b.Property<int>("GenreID");

                    b.Property<string>("MovieDescription");

                    b.Property<string>("MovieName");

                    b.HasKey("Id");

                    b.ToTable("MovieModel");
                });

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