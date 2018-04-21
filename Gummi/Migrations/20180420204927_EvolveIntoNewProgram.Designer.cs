﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Gummi.Models;

namespace Gummi.Migrations
{
    [DbContext(typeof(GummiDbContext))]
    [Migration("20180420204927_EvolveIntoNewProgram")]
    partial class EvolveIntoNewProgram
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Gummi.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("LocationId");

                    b.Property<string>("Title");

                    b.HasKey("ExperienceId");

                    b.HasIndex("LocationId");

                    b.ToTable("Experiences");
                });

            //modelBuilder.Entity("Gummi.Models.ExperiencePeople", b =>
                //{
                //    b.Property<int>("ExperiencePeopleId")
                //        .ValueGeneratedOnAdd();

                //    b.Property<int>("ExperienceId");

                //    b.Property<int>("PersonId");

                //    b.HasKey("ExperiencePeopleId");

                //    b.HasIndex("ExperienceId");

                //    b.HasIndex("PersonId");

                //    b.ToTable("ExperiencePeople");
                //});

            modelBuilder.Entity("Gummi.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Details");

                    b.Property<string>("Place");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Gummi.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.HasIndex("ExperienceId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Gummi.Models.Experience", b =>
                {
                    b.HasOne("Gummi.Models.Location", "Location")
                        .WithMany("Experiences")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            //modelBuilder.Entity("Gummi.Models.ExperiencePeople", b =>
                //{
                //    b.HasOne("Gummi.Models.Experience", "Experience")
                //        .WithMany()
                //        .HasForeignKey("ExperienceId")
                //        .OnDelete(DeleteBehavior.Cascade);

                //    b.HasOne("Gummi.Models.Person", "Person")
                //        .WithMany()
                //        .HasForeignKey("PersonId")
                //        .OnDelete(DeleteBehavior.Cascade);
                //});

            modelBuilder.Entity("Gummi.Models.Person", b =>
                {
                    b.HasOne("Gummi.Models.Experience")
                        .WithMany("People")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
