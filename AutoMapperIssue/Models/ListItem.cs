using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Models
{
  public class ListItem : IListItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime? DeletedDate { get; set; }

    public ListItem()
    {
    }

    public ListItem(string name)
    {
      Name = name;
    }
  }
}
