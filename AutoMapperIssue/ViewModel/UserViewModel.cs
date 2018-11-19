
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.ViewModel
{
  public class UserViewModel
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public NationalityViewModel Nationality { get; set; }
    public AddressViewModel RegAddress { get; set; }
    public AddressViewModel MailAddress { get; set; }
    public RegionViewModel Region { get; set; }
  }
}
