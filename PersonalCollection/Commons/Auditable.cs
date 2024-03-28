namespace PersonalCollection.Domain.Commons;
public class Auditable : BaseEntity<int>
{
    public DateTime CreatedAt {get; set;}
    public DateTime? LastUpdatedAt { get; set;}
}
