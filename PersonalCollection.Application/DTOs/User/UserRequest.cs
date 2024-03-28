using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Application.DTOs.User;
public class UserRequest
{
    [MinLength(2), MaxLength(20)]  
    public string FirstName { get; set; }
    [MinLength(2), MaxLength(20)]
    public string LastName { get; set; }
    public string Email { get; set; }
    [MinLength(8)]
    public string password { get;set; }
}

