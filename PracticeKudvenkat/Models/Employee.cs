using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticeKudvenkat.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name Feild Could Not Exceed the max characters")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [DisplayName("Department")]
        public Dept? DepartmentName { get; set; }
        public double Salary { get; set; }
    }
}
