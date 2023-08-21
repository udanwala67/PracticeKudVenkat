using Microsoft.EntityFrameworkCore;

namespace PracticeKudvenkat.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 1,
               Name = "Sahil",
               DepartmentName = Dept.DotNet,
               Email = "Sahiludanwala6787@gmail.com",
           },

             new Employee
             {
                 EmployeeId = 2,
                 Name = "Suhani",
                 DepartmentName = Dept.HR,
                 Email = "Suhaniudanwala67@gmail.com",
             }
       );
        }
    }
}
