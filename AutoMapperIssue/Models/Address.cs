namespace AutoMapperIssue.Models
{
  public class Address : IEntity
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int? CountryId { get; set; }
    public string ZipCode { get; set; }
    public int Id { get; set; }

    public virtual Country Country { get; set; }
  }
}
