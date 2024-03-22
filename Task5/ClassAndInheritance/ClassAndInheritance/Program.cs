using System.Text.RegularExpressions;

namespace ClassAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Department department = new Department();
            do
            {
                
                Console.WriteLine("1.Employee elave et.\n2.Butun iscilere bax.\n3.Maas araligina gore iscileri axtaris et.\n0.Programi bitir");
                Console.Write("Seciminizi daxil edin = ");
                int.TryParse(Console.ReadLine(), out  f);

                Console.WriteLine();
                switch (f)
                {   
                    case 0:
                        Console.WriteLine("Istifade etdiyiniz ucun tesekkur edirik");
                        break;
                    case 1:
                        Console.WriteLine("Adini daxil et:");
                        string name ;
                        while (true)
                        {
                            name = Console.ReadLine();
                            if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-z]+$"))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Adi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        
                        Console.WriteLine("Soyadini daxil et:");
                        string surname;
                        while (true)
                        {
                            surname = Console.ReadLine();
                            if (!string.IsNullOrEmpty(surname) && Regex.IsMatch(surname, @"^[a-zA-z]+$"))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Soyadi duzgun daxil edin!\nYeniden cehd edin :");
                            }
                        }
                        Console.WriteLine("Yasini daxil et:");
                        byte age;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) && byte.TryParse(input, out age))
                            {
                               break ;
                            }
                            else
                            {
                                Console.WriteLine("Yasi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        Console.WriteLine("Department adini daxil et:");
                        string depName;
                        while (true)
                        {
                            depName = Console.ReadLine();
                            if (!string.IsNullOrEmpty(surname))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Department adini duzgun daxil edin!\nYeniden cehd edin :");
                            }
                        }
                        Console.WriteLine("Maasini daxil et:");
                        int salary;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out salary))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Maasi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        Employee employee = new Employee(name,surname,age,depName,salary);
                        department.AddEmployee(employee);
                        Console.WriteLine();
                        continue;
                        break;

                    case 2:
                        department.ShowEmployeeInfo();
                        Console.WriteLine();
                        continue;
                        break;
                    case 3:
                        Console.WriteLine("Minimum maasi daxil et:");
                        int minSalary;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out minSalary) && minSalary>=0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Minimum maasi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        Console.WriteLine("\nMaximum maasi daxil et:");
                        int maxSalary;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out maxSalary) && maxSalary>=minSalary)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Maximum maasi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        Console.WriteLine();
                        department.GetAllEmployeesBySalary(minSalary, maxSalary);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Xahis edirik duzgun secim edesizin!");
                        continue;
                        break;
                }
                Console.WriteLine();
            } while (f != 0);
            Console.ReadLine();
        }
    }


    public class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;

        public Employee(string name, string surname, byte age, string depname, int salary) 
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = depname;
            Salary = salary;
        }
    }


    public class Department 
    {
        public Employee[] Employees = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            
            Array.Resize(ref Employees,Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
    
        public string GetAllEmployees()
        {
            string result = "";
            
            for (int i = 0;i < Employees.Length;i++)
            {
                result+= $"{Employees[i].Name,-12} {Employees[i].Surname,-25} {Employees[i].Age,-3}   {Employees[i].DepartmentName,-20}     {Employees[i].Salary,-5}$\n";
            }
            return result;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("ADI:         SOYADI:                   YASI: DEPARTMENT ADI:          MAASI:");
            Console.WriteLine(GetAllEmployees());
        }

        public string GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            string result = "";
            Console.WriteLine($" {minSalary} - {maxSalary} maas araliqindaki isciler:");
            Console.WriteLine("ADI:         SOYADI:                   YASI: DEPARTMENT ADI:          MAASI:");
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                {
                    result += $"{Employees[i].Name,-12} {Employees[i].Surname,-25} {Employees[i].Age,-3}   {Employees[i].DepartmentName,-20}     {Employees[i].Salary,-5}$\n";
                }
            }
            Console.WriteLine(result);
            return result;
        }
    
    }
}
