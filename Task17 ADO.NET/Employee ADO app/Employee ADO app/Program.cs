using Employee_ADO_app.Models;
using Employee_ADO_app.Servicies;

namespace Employee_ADO_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            Employee employee = new Employee()
            {
                Name = "Resul",
                Surname = "ISLAYIN",
                Salary = 1600
            };
            
            //employeeService.CreateEmployee(employee);
            employeeService.DeleteEmployee(7);

            foreach(Employee emp in employeeService.GetAll(null))
            {
                Console.WriteLine(emp);
            }
        }
    }
}
