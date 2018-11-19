using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoMapperIssue.Data.Configurations
{
  public class ListItemConfiguration<T> : IEntityTypeConfiguration<T> where T : ListItem
  {
    public void Configure(EntityTypeBuilder<T> builder)
    {
      builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
      builder.Property(t => t.DeletedDate).HasColumnType("date");
    }
  }
}
