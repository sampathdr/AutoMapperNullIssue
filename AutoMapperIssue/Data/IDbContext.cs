using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading.Tasks;

namespace AutoMapperIssue.Data
{
  public interface IDbContext : IDisposable
  {
    DbSet<T> Set<T>() where T : class;
    EntityEntry<T> Entry<T>(T entity) where T : class;
    int SaveChanges();
    Task<int> SaveChangesAsync();
  }
}
