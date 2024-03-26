namespace PersonalCollection.Domain.Commons;
public class Auditable
{
    public long Id { get; set; }
    public DateTime CreatedAt {get; set;}
    public DateTime LastUpdatedAt { get; set;}
}
