
using PracticeKudvenkat.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticeKudvenkat.ViewModels
{
    public class EmployeeCreateViewModel
    {


        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name Feild Could Not Exceed the max characters")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Department")]
        public Dept? DepartmentName { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
