using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StoreForVideos.Migrations
{
    public partial class AddRentalRecordModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentalRecordModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CustomerID = table.Column<int>(type: "int4", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    MovieID = table.Column<int>(type: "int4", nullable: false),
                    RentalDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    RentalID = table.Column<int>(type: "int4", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalRecordModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalRecordModel");
        }
    }
}
