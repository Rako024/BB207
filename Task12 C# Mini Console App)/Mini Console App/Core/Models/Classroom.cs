using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {
        private static int _id;
        public int Id { get; }
        Student[] students;
        public string Name { get; set; }
        public StudentType studentType;
        public int StudentLimit;
        public int StudentCount = 0;

        public Classroom(string name, StudentType type) 
        {
            Id = ++_id;
            students  = new Student[] { };
            Name = name;
            studentType = type;
           
            StudentLimit =(int) studentType;
            
        }

        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[^1] = student;
                StudentCount = students.Length;
            }
            else
            {
                Console.WriteLine("Student Limit is full");
            }
        }
        public Student FindById(int id)
        {
            foreach (Student student in students)
            {
                if(student.Id == id) return student;
            }
           throw new StudentNotFoundException();
        }

        public void DeleteById(int id)
        {
            Student[] newStudents = new Student[] { };
            foreach(Student student in students)
            {
                if(student.Id != id)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[^1] = student;
                }
            }
            if(newStudents.Length == students.Length)
            {
                throw new StudentNotFoundException();
            }
            students = newStudents;
        }

        public void ShowStudents()
        {
            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public bool EditStudent(int id,string newName, string newSurname)
        {
            foreach(var student in students)
            {
                if(student.Id == id)
                {
                    student.Name = newName;
                    student.Surname = newSurname;
                    return true;
                }
            }
            throw new StudentNotFoundException();
        }

        public override string ToString()
        {
            return $"Id = {Id}; Name = {Name}; Type = {studentType}; StudentLimit = {StudentLimit}; StudentCount = {StudentCount}";
        }
    }
}
