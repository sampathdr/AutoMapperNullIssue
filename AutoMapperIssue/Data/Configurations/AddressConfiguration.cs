using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Data.Configurations
{
  public class AddressConfiguration : IEntityTypeConfiguration<Address>
  {
    public void Configure(EntityTypeBuilder<Address> builder)
    {
      builder.HasKey(o => o.Id);
      builder.Property(t => t.Street).HasMaxLength(100);
      builder.Property(t => t.City).HasMaxLength(100);
      builder.Property(t => t.State).HasMaxLength(100);
      builder.Property(t => t.ZipCode).HasMaxLength(10);

      builder.HasOne(t => t.Country).WithMany().HasForeignKey(t => t.CountryId);
    }
  }
}
