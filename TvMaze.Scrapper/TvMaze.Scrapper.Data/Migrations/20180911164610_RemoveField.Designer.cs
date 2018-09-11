using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TvMaze.Scrapper.Data;

namespace TvMaze.Scrapper.Data.Migrations
{
    [DbContext(typeof(ScrapperDbContext))]
    [Migration("20180911164610_RemoveField")]
    partial class RemoveField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("TvMaze.Scrapper.Data.Entities.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDay");

                    b.Property<string>("Name");

                    b.Property<int?>("ShowId");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("TvMaze.Scrapper.Data.Entities.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("TvMaze.Scrapper.Data.Entities.Cast", b =>
                {
                    b.HasOne("TvMaze.Scrapper.Data.Entities.Show")
                        .WithMany("Casts")
                        .HasForeignKey("ShowId");
                });
        }
    }
}
