using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Servicies.Abstracts
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void DeleteStudent(int id);
        void UpdateStudent(int id,Student student);
        Student GetStudent(Func<Student,bool>? func);
        List<Student> GetAllStudents(Func<Student,bool>? func);
    }
}
