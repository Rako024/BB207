using Business.Servicies.Abstracts;
using Core.Models;
using Core.RepostoryAbstracts;
using Data.RepositoryConcreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Servicies.Concreters
{
    public class StudentService : IStudentService
    {
        IStudentRepository studentRepository = new StudentRepository();
        public void AddStudent(Student student)
        {
            studentRepository.Add(student);
            studentRepository.Commit();
        }

        public void DeleteStudent(int id)
        {
            Student student = studentRepository.Get(x=> x.Id == id);
            studentRepository.Delete(student);
            studentRepository.Commit();
        }

       

        public List<Student> GetAllStudents(Func<Student,bool>? func)
        {
            return studentRepository.GetAll(null);
        }

       

        public Student GetStudent(Func<Student,bool>? func=null)
        {
            return studentRepository.Get(func);
        }

        

        public void UpdateStudent(int id, Student student)
        {
            var oldStudent = studentRepository.Get(x=> x.Id == id);
            if (oldStudent == null) throw new NullReferenceException();
            oldStudent.Name = student.Name;
            studentRepository.Commit();
        }
    }
}
