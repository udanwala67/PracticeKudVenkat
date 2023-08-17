using System.ComponentModel.DataAnnotations;

namespace PracticeKudvenkat.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Dept DepartmentName { get; set; }
        public double Salary { get; set; }
    }
}
