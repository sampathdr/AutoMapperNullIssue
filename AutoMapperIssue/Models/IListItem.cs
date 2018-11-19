using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Models
{
  public interface IListItem : IEntity
  {
    string Name { get; set; }
    DateTime? DeletedDate { get; set; }
  }
}
