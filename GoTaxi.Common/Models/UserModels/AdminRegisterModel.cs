using System.ComponentModel.DataAnnotations;

namespace GoTaxi.Common.Models.UserModels;
public class AdminRegisterModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; }
    public string PhoneNumber { get; set; }
}
