using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.ViewModel
{
  public class AddressViewModel
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public CountryViewModel Country { get; set; }
    public string ZipCode { get; set; }
    public int Id { get; set; }
  }
}
