﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTrack.Data;

namespace TimeTrack.Migrations
{
    [DbContext(typeof(TimeTrackerContext))]
    partial class TimeTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("TimeTrack.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName");

                    b.Property<string>("Location");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("TimeTrack.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("ProjectName");

                    b.Property<int>("ProjectType");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TimeTrack.Models.Project", b =>
                {
                    b.HasOne("TimeTrack.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
