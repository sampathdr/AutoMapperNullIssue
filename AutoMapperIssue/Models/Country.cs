namespace AutoMapperIssue.Models
{
  public class Country : ListItem
  {
    public int? RegionId { get; set; }
    public virtual LkupRegion Region { get; set; }
    public string Code { get; set; }
    public int SortOrder { get; set; }

    public Country() { }

    public Country(string name, string code, int sortOrder = 1000) : base(name)
    {
      Code = code;
      SortOrder = sortOrder;
    }
  }
}
