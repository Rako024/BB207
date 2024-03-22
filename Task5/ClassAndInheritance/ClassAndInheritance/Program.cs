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
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyadini daxil et");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Yasini daxil et:");
                        byte.TryParse(Console.ReadLine(), out byte age);
                        Console.WriteLine("Department adini daxil et:");
                        string depName = Console.ReadLine();
                        Console.WriteLine("Maasini daxil et:");
                        int.TryParse(Console.ReadLine(), out int salary);
                        Employee employee = new Employee(name,surname,age,depName,salary);
                        department.AddEmployee(employee);
                        Console.WriteLine();
                        continue;
                        break;

                    case 2:
                        department.GetAllEmployees();
                        Console.WriteLine();
                        continue;
                        break;
                    case 3:
                        Console.WriteLine("Minimum maasi daxil et:");
                        int.TryParse(Console.ReadLine(), out int minSalary);
                        Console.WriteLine("\nMaximum maasi daxil et:");
                        int.TryParse(Console.ReadLine(),out int maxSalary);
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
    
        public void GetAllEmployees()
        {
            Console.WriteLine("ADI:         SOYADI:                   YASI:   MAASI:");
            for (int i = 0;i < Employees.Length;i++)
            {
                Console.WriteLine($"{Employees[i].Name,-12} {Employees[i].Surname,-25} {Employees[i].Age,-3}     {Employees[i].Salary,-5}$");
            }
        }

        public void GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            Console.WriteLine($" {minSalary} - {maxSalary} maas araliqindaki isciler:");
            Console.WriteLine("ADI:         SOYADI:                   YASI:   MAASI:");
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary<=maxSalary)
                Console.WriteLine($"{Employees[i].Name,-12} {Employees[i].Surname,-25} {Employees[i].Age,-3}     {Employees[i].Salary,-5}$");
            }
        }
    
    }
}
