using Employee_ADO_app.DataBase;
using Employee_ADO_app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ADO_app.Repositories
{
    internal class EmployeeRepository
    {
        AppDbContext appDbContext;
        public EmployeeRepository()
        {
            appDbContext = new AppDbContext();
        }
        public void CreateEpmloyee(Employee employee)
        {
            string command = $"insert into Employees values('{employee.Name}','{employee.Surname}',{employee.Salary})";
            appDbContext.NonQuery(command) ;
        }

        public List<Employee> GetAll()
        {
            string query = "select * from Employees";
            DataTable dt = appDbContext.Query(query);
            List<Employee> list = new List<Employee>();
            foreach (DataRow emp in dt.Rows)
            {
                list.Add(new Employee()
                {
                    Id = (int)emp[0],
                    Name = (string)emp[1],
                    Surname = (string)emp[2],
                    Salary = (decimal)emp[3]
                });
            }
            return list;
        }

        public Employee GetEmployee(int id)
        {
            string query = $"select * from Employees where Id = {id}";
            DataTable dt = appDbContext.Query(query);
            DataRow dr = dt.Rows[0];
            Employee emp = new Employee() 
            {
                Id= (int)dr[0],
                Name = (string)dr[1],
                Surname = (string)dr[2],
                Salary = (decimal)dr[3]
            };
            return emp;
        }

        public void DeleteEmployee(int id)
        {
            string command = $"delete from Employees where Id = {id}";
            appDbContext.NonQuery(command) ;
        }
        public void UpdateEmployee(Employee emp,int id)
        {
            string commnad = $"update Employees set Name = '{emp.Name}', Surname = '{emp.Surname}', Salary = {emp.Salary} where Id = {id}";
            appDbContext.NonQuery(commnad);
        }
    }
}
