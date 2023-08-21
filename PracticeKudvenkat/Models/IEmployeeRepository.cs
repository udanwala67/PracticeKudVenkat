namespace PracticeKudvenkat.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int EmployeeId);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int EmployeeId);

    }
}
