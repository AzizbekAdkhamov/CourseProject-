using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.User;
public enum Permissions 
{
   CanRead,
   CanLike,
   CanComment,
   CanDelete,
   CanBlock,
   CanUnblock,
   CanUpdate,
   CanCreate,
   AddAdmin
}
