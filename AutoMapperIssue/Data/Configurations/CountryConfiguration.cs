using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoMapperIssue.Data.Configurations
{
  public class CountryConfiguration : ListItemConfiguration<Country>
  {
    public CountryConfiguration(EntityTypeBuilder<Country> builder)
    {
      builder.Property(t => t.Code).HasMaxLength(6).IsRequired();

      builder.HasOne(t => t.Region).WithMany().HasForeignKey(t => t.RegionId);
    }
  }
}
