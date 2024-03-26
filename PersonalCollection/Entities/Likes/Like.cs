using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.Likes;
public class Like : Auditable
{
    public int CollectionId { get; set; }
    public int UserId { get; set; }
}
