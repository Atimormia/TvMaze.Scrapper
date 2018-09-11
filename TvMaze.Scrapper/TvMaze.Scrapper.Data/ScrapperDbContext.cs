using System;
using Microsoft.EntityFrameworkCore;
using TvMaze.Scrapper.Data.Entities;

namespace TvMaze.Scrapper.Data
{
    public class ScrapperDbContext: DbContext
    {
        public ScrapperDbContext(DbContextOptions<ScrapperDbContext> options) : base(options)
        {
        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Cast> Casts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>().ToTable("Shows");
            modelBuilder.Entity<Cast>().ToTable("Casts");
        }
    }
}