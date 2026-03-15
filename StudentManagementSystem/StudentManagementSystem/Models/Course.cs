using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentManagementSystem.Models;
public class Course
{
    public int CourseId { get; set; }

    [Required(ErrorMessage = "Course name is required")]
    public string CourseName { get; set; }

    [Required(ErrorMessage = "Duration is required")]
    public string Duration { get; set; }

    [Required(ErrorMessage = "Fees are required")]
    [Range(100, 100000, ErrorMessage = "Fees must be between 100 and 100000")]
    public decimal Fees { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
}