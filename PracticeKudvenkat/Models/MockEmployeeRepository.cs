using System.Collections.Generic;

namespace PracticeKudvenkat.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>();
            {
                new Employee() { EmployeeId = 1, Name = "Mary", DepartmentName = Dept.HR, Description = "New", Salary = 20000 };
                new Employee() { EmployeeId = 2, Name = "Sahil", DepartmentName = Dept.DotNet, Description = "Trainee", Salary = 5500 };
                new Employee() { EmployeeId = 3, Name = "Aman", DepartmentName = Dept.PayRoll, Description = "Trainee", Salary = 5500 };
            };

        }
        public Employee GetEmployee(int EmployeeId)
        {
            return _employeeList.FirstOrDefault(e => e.EmployeeId == EmployeeId);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

    }
}
