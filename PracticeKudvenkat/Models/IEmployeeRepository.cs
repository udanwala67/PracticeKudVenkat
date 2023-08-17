namespace PracticeKudvenkat.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int EmployeeId);
        IEnumerable<Employee> GetAllEmployee();

    }
}
