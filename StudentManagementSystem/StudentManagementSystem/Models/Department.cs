using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models;
public class Department
{
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "Department name is required")]
    public string DepartmentName { get; set; }

    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
}