using PersonalCollection.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Domain.Entities.Users;
public class User : Auditable
{
    [MinLength(2), MaxLength(20)]
    public string FirstName { get; set; }
    [MinLength(2), MaxLength(20)]
    public string LastName { get; set; }
    public string Email { get; set; }
    [MinLength(8)]
    public string Password { get; set; }
    public bool IsBlocked { get; set; } = false;

}
