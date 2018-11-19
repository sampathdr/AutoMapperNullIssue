namespace AutoMapperIssue.Models
{
  public class User : IEntity
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int NationalityId { get; set; }
    public int? RegAddressId { get; set; }
    public int? MailAddressId { get; set; }

    public virtual LkupNationality Nationality { get; set; }
    public virtual Address RegAddress { get; set; }
    public virtual Address MailAddress { get; set; }
  }
}
