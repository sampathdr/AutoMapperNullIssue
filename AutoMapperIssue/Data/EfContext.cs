using AutoMapperIssue.Data.Configurations;
using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperIssue.Data
{
  public class EfContext : DbContext, IDbContext
  {
    private readonly string _connectionString;

    public EfContext(DbContextOptions<EfContext> options) : base(options)
    {

    }
    public EfContext()
    {
      _connectionString = @"Data Source=DESKTOP-TGEDV7P\SQLEXPRESS;Initial Catalog=AutoMapperIssueDB;User ID=sa;Password=1qaz2wsx@; MultipleActiveResultSets=True";
    }
    public EfContext(string connectionString)
    {
      _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
      if (!string.IsNullOrEmpty(_connectionString))
      {
        optionsBuilder.UseSqlServer(_connectionString);
      }

      base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new CountryConfiguration(modelBuilder.Entity<Country>()));
      modelBuilder.ApplyConfiguration(new LkupNationalityConfiguration(modelBuilder.Entity<LkupNationality>()));
      modelBuilder.ApplyConfiguration(new ListItemConfiguration<LkupRegion>());
      modelBuilder.ApplyConfiguration(new AddressConfiguration());
    }

    public override int SaveChanges()
    {
      var added = this.ChangeTracker.Entries()
          .Where(x => x.State == EntityState.Added)
          .Select(x => x.Entity)
          .ToList();

      var modified = this.ChangeTracker.Entries()
          .Where(x => x.State == EntityState.Modified)
          .Select(x => x.Entity)
          .ToList();

      var deleted = this.ChangeTracker.Entries()
        .Where(x => x.State == EntityState.Deleted)
        .Select(x => x.Entity)
        .ToList();

      return base.SaveChanges();
    }

    public Task<int> SaveChangesAsync()
    {
      throw new System.NotImplementedException();
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<LkupRegion> LkupRegions { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<LkupNationality> LkupNationalities { get; set; }
  }
}
