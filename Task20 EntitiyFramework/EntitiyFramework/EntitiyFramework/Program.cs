using Business.Servicies.Abstracts;
using Business.Servicies.Concreters;
using Core.Models;

namespace EntitiyFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();
            Student student = new Student() {Name = "Nicat" };
            //studentService.AddStudent(student);
            Console.WriteLine(studentService.GetAllStudents(null)[0]);
        }
    }
}
