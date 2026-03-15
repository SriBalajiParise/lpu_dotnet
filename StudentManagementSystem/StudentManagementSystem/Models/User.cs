using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models;
public class User
{
    public int UserId { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 6)]
    public string Password { get; set; }

    [Required]
    public string Role { get; set; }
}