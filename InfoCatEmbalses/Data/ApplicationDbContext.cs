using InfoCatEmbalses.Embalses;
using Microsoft.EntityFrameworkCore;
namespace InfoCatEmbalses.Data;

public class AppDbContext : DbContext
{
 public DbSet<Embalse> Embalses { get; set; }

 public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
 {
 }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  modelBuilder.Entity<Embalse>(entity =>
  {
   entity.Property(e => e.Estacio).IsRequired();
  });
 }
}