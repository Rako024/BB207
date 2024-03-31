using System.Text.RegularExpressions;

namespace Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qrupun nomresini daxil edin : ");
            string no = Console.ReadLine();
            
            while (true)
            {
                if(Regex.IsMatch(no, @"^[A-Z]{2}\d{3}$"))
                {
                    break;
                }
                else
                {
                    Console.Write("\nQrupun nomresini duzgun daxil edin : ");
                    no = Console.ReadLine();
                }
            }

            Console.Write("\nTelebe sayinin limitini daxil edin : ");
            int studentLimit;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out studentLimit) && studentLimit >=0 && studentLimit <=20) 
                {
                    break;
                }
                else
                {
                    Console.Write("Telebe sayi limitini duzgun daxil edin : ");
                }
            }

            Group group = new Group(no,studentLimit);
            string s;
            do
            {
                Console.WriteLine("\n1. Telebe elave et\r\n2. Butun telebelere bax\r\n3. Telebeler uzre axtarıs et\r\n0. Proqrami bitir");
                Console.Write("Bir secim edin : ");
                s = Console.ReadLine();
                switch(s)
                {
                    case "0":
                        Console.WriteLine("Istifade etdiyiniz ucun tesekkurler");
                        break;
                    case "1":
                        Console.Write("Ad ve soyadi daxil et:");
                        string fullName;
                        while (true)
                        {
                            fullName = Console.ReadLine();
                            if (!string.IsNullOrEmpty(fullName) && Regex.IsMatch(fullName, @"^[A-Za-z\s]+$"))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Adi ve soyadi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        Console.Write("Ortalama Balini daxil et:");
                        double avgPoint;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out avgPoint))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ortalama bali duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }

                        Student student = new Student(fullName,avgPoint);
                        student.GroupNo = group.No;
                        if (group.AddStudent(student))
                        {
                            Console.WriteLine("Student grupa elave edildi");
                        }
                        else
                        {
                            Console.WriteLine("Grupun telebe limiti doldur. Buna gorede telebe elave etmek mumkun deyil");
                        }
                        continue;
                    case "2":
                        group.ShowAllStudents();
                        continue;
                    case "3":
                        Console.Write("Ad ve soyadi daxil et:");
                        string fullName1;
                        while (true)
                        {
                            fullName1 = Console.ReadLine();
                            if (!string.IsNullOrEmpty(fullName1) && Regex.IsMatch(fullName1, @"^[A-Za-z\s]+$"))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Adi ve soyadi duzgun daxil edin!\nYeniden cehd edin : ");
                            }
                        }
                        group.ShowFilteredStudents(fullName1);
                        continue;
                    default:
                        Console.WriteLine("Duzgun secim edin!!!");
                        continue;
                }
            } while (!s.Equals("0"));
        }
    }
}
