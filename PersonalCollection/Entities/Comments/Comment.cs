using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.Comments;
public class Comment : Auditable
{
    public int CollectionId { get; set; }
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public string CommentText { get; set; }
}
