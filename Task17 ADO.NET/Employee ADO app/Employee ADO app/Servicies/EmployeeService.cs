using Employee_ADO_app.Exceptions;
using Employee_ADO_app.Models;
using Employee_ADO_app.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ADO_app.Servicies
{
    internal class EmployeeService
    {
        EmployeeRepository employeeRepository;
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }

        public void CreateEmployee(Employee employee)
        {
            employeeRepository.CreateEpmloyee(employee);
        }

        public void UpdateEmployee(Employee employee, int id)
        {
            employeeRepository.UpdateEmployee(employee, id);
        }
        public void DeleteEmployee(int id)
        {
            if (CheckEmployeeId(id))
                employeeRepository.DeleteEmployee(id);
            else
                throw new NotFounIdException();   
        }

        public bool CheckEmployeeId(int id)
        {
            List<Employee> list =  employeeRepository.GetAll();

            foreach(Employee employee in list)
            {
                if (employee.Id == id)
                    return true;
            }
            return false;
        }

        public Employee GetEmployee(int id) 
        {
            return employeeRepository.GetEmployee(id);
        }

        public List<Employee> GetAll(Predicate<Employee>? predicate)
        {
            List<Employee> list = new List<Employee>();
            if (predicate == null)
            {
                return employeeRepository.GetAll();
            }

            foreach (Employee employee in employeeRepository.GetAll())
            {
                if (predicate(employee))
                {
                    list.Add(employee);
                }
            }
            return list;
        }



    }
}
