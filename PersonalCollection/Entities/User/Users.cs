using PersonalCollection.Domain.Commons;
using System.Security.Principal;

namespace PersonalCollection.Domain.Entities.User;
public class Users : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool IsBlocked { get; set; }

    public Roles Role { get; set; }

}
