using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Access
{
    internal class Group
    {
        public string No { get; set; }
        public Student[] Students = { };
        public int StudentLimit { get; set; }
        public Group(string no, int studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;
        }

        public bool AddStudent (Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                return true;
            }
            return false;
        }
        


        public void ShowAllStudents()
        {
            Console.WriteLine("ADI VE SOYADI:       AVGPOINT: GROUPNO:");
            foreach (var student in Students)
            {
                student.ShowInfo();
            }
        }

        public Student[] FindByFullName(string fullName)
        {
            Student[] students = { };
            foreach (var student in Students)
            {
                if (student.FullName.Equals(fullName))
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = student;
                }
            }
            return students;
        }

        public void ShowFilteredStudents(string fullName)
        {
            Student[] students = FindByFullName(fullName);
            Console.WriteLine("ADI VE SOYADI:       AVGPOINT: GROUPNO:");
            foreach (var student in students)
            {
                student.ShowInfo();
            }
        }

    }
}
