using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;  
using StoreForVideos.Models;

namespace StoreForVideos
{
    public partial class superstoreContext : DbContext
    {
        public DbSet<RentalRecordModel> RentalRecordModel {get; set;}//dont have to put it here
        public DbSet<GenreModel> GenreModel {get; set;}
        public DbSet<MovieModel> MovieModel { get; set; }
        public DbSet<CustomerModel> CustomerModel { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost;Database=superstore;Username=dev;Password=dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
