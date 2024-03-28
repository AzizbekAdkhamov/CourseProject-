using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Application.DTOs.User;
public class UserUpdatePassword
{
    [Required(ErrorMessage = "Email is required!")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Old password must not be null or empty ! ")]
    public string OldPassword { get; set; }
    [Required(ErrorMessage = "New password must not be null or empty !  ")]
    public string NewPassword { get; set; }
    [Required(ErrorMessage = "Confirm password must be same with new password ")]
    public string ConfirmPassword { get; set; }
}
