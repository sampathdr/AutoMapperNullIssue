namespace AutoMapperIssue.Models
{
  public class LkupNationality : ListItem
  {
    public int? RegionId { get; set; }
    public virtual LkupRegion Region { get; set; }
    public string Language { get; set; }
    public int SortOrder { get; set; }

    public LkupNationality()
    {
    }

    public LkupNationality(string name, int sortOrder = 1000)
      : base(name)
    {
      SortOrder = sortOrder;
    }
  }
}
