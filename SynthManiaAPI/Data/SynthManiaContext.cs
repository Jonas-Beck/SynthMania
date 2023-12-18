using Microsoft.EntityFrameworkCore;
using SynthManiaAPI.Data.Configurations;
using SynthManiaAPI.Models;

namespace SynthManiaAPI.Data;

public class SynthManiaContext : DbContext
{
    
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SynthMania;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
    }
}