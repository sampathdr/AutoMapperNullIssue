using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.ViewModel
{
  public class CountryViewModel
  {
    public RegionViewModel Region { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int SortOrder { get; set; }
  }
}
