using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Application.DTOs.User;
public class UserResponse
{
    public int Id { get; set; }
    [DisplayName("FirstName")]
    public string FirstName { get; set; }
    [DisplayName("LastName")]
    public string LastName { get; set; }
    public string Email { get; set; }
}
