using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Application.DTOs.User;
public class UserModify
{
    [MinLength(2), MaxLength(20)]
    public string FirstName { get; set; }
    [MinLength(2), MaxLength(20)]
    public string LastName { get; set; }
}
