using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PracticeKudvenkat.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context)
        {

            this.context = context;
        }

        public Employee Add(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int EmployeeId)
        {
            Employee employee = context.employees.Find(EmployeeId);
            if (employee != null)
            {
                context.employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.employees;
        }

        public Employee GetEmployee(int EmployeeId)
        {
            return (Employee)context.employees.FirstOrDefault(e => e.EmployeeId == EmployeeId);
            //   return context.employees.Find(EmployeeId);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
