using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gummi.Migrations
{
    public partial class AddUserToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Locations",
            //    columns: table => new
            //    {
            //        LocationId = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGeneratedOnAdd", true),
            //        Details = table.Column<string>(nullable: true),
            //        Place = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Locations", x => x.LocationId);
            //    });

            //migrationBuilder.CreateTable(
                //name: "Products",
                //columns: table => new
                //{
                //    ProductId = table.Column<int>(nullable: false)
                //        .Annotation("MySql:ValueGeneratedOnAdd", true),
                //    Cost = table.Column<int>(nullable: false),
                //    Description = table.Column<string>(nullable: true),
                //    Name = table.Column<string>(nullable: true)
                //},
                //constraints: table =>
                //{
                //    table.PrimaryKey("PK_Products", x => x.ProductId);
                //});

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            //migrationBuilder.CreateTable(
            //    name: "Experiences",
            //    columns: table => new
            //    {
            //        ExperienceId = table.Column<int>(nullable: false)
            //            .Annotation("MySql:ValueGeneratedOnAdd", true),
            //        Content = table.Column<string>(nullable: true),
            //        LocationId = table.Column<int>(nullable: false),
            //        Title = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
            //        table.ForeignKey(
            //            name: "FK_Experiences_Locations_LocationId",
            //            column: x => x.LocationId,
            //            principalTable: "Locations",
            //            principalColumn: "LocationId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
                //name: "Reviews",
                //columns: table => new
                //{
                //    ReviewId = table.Column<int>(nullable: false)
                //        .Annotation("MySql:ValueGeneratedOnAdd", true),
                //    Author = table.Column<string>(nullable: true),
                //    Content = table.Column<string>(nullable: true),
                //    ProductId = table.Column<int>(nullable: true),
                //    Rating = table.Column<int>(nullable: false),
                //    UserId = table.Column<int>(nullable: true)
                //},
                //constraints: table =>
                //{
                //    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                //    table.ForeignKey(
                //        name: "FK_Reviews_Products_ProductId",
                //        column: x => x.ProductId,
                //        principalTable: "Products",
                //        principalColumn: "ProductId",
                //        onDelete: ReferentialAction.Restrict);
                //    table.ForeignKey(
                //        name: "FK_Reviews_Users_UserId",
                //        column: x => x.UserId,
                //        principalTable: "Users",
                //        principalColumn: "UserId",
                //        onDelete: ReferentialAction.Restrict);
                //});

            //migrationBuilder.CreateIndex(
                //name: "IX_Experiences_LocationId",
                //table: "Experiences",
                //column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
