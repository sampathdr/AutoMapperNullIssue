using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Data.Configurations
{
  public class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.Property(t => t.Id);
      builder.Property(t => t.Email).HasMaxLength(254).IsRequired();
      builder.Property(t => t.FirstName).HasMaxLength(50).IsRequired();
      builder.Property(t => t.LastName).HasMaxLength(50).IsRequired();
      builder.Property(t => t.NationalityId).IsRequired();

      builder.HasOne(t => t.Nationality).WithMany().HasForeignKey(t => t.NationalityId);
      builder.HasOne(t => t.RegAddress).WithMany().HasForeignKey(t => t.RegAddressId);
      builder.HasOne(t => t.MailAddress).WithMany().HasForeignKey(t => t.MailAddressId);
    }
  }
}
