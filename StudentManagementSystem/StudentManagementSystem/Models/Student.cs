using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models;
public class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Student name is required")]
    public string StudentName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    [Required]
    public int CourseId { get; set; }

    public Department Department { get; set; }

    public Course Course { get; set; }
}