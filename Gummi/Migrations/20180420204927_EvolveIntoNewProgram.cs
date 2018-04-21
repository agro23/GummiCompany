using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gummi.Migrations
{
    public partial class EvolveIntoNewProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Details = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Content = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    ExperienceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
                //name: "ExperiencePeople",
                //columns: table => new
                //{
                //    ExperiencePeopleId = table.Column<int>(nullable: false)
                //        .Annotation("MySql:ValueGeneratedOnAdd", true),
                //    ExperienceId = table.Column<int>(nullable: false),
                //    PersonId = table.Column<int>(nullable: false)
                //},
                //constraints: table =>
                //{
                //    table.PrimaryKey("PK_ExperiencePeople", x => x.ExperiencePeopleId);
                //    table.ForeignKey(
                //        name: "FK_ExperiencePeople_Experiences_ExperienceId",
                //        column: x => x.ExperienceId,
                //        principalTable: "Experiences",
                //        principalColumn: "ExperienceId",
                //        onDelete: ReferentialAction.Cascade);
                //    table.ForeignKey(
                //        name: "FK_ExperiencePeople_People_PersonId",
                //        column: x => x.PersonId,
                //        principalTable: "People",
                //        principalColumn: "PersonId",
                //        onDelete: ReferentialAction.Cascade);
                //});

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_LocationId",
                table: "Experiences",
                column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ExperiencePeople_ExperienceId",
            //    table: "ExperiencePeople",
            //    column: "ExperienceId");

            //migrationBuilder.CreateIndex(
                //name: "IX_ExperiencePeople_PersonId",
                //table: "ExperiencePeople",
                //column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_ExperienceId",
                table: "People",
                column: "ExperienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
                //name: "ExperiencePeople");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
