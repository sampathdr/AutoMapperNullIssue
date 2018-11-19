using AutoMapperIssue.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Data.Configurations
{
  public class LkupNationalityConfiguration : ListItemConfiguration<LkupNationality>
  {
    public LkupNationalityConfiguration(EntityTypeBuilder<LkupNationality> builder)
    {
      builder.Property(p => p.Language).HasMaxLength(15);
    }
  }
}
