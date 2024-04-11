using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class School
    {
        //siniflerin depolandigi array
        public static Classroom[] classrooms = { };
        //Sinifi olamayan telebelerin depolandini array
        public static Student[] TempStudents = { };


        //Classroom arayina sinif elave etme
        public static void AddClassroom(Classroom room)
        {
            Array.Resize(ref classrooms, classrooms.Length + 1);
            classrooms[^1] = room;  
        }


        //Classroom arrayindan id ye ugun sinifi silme
        public static void RemoveClassroom(int id) 
        {
            Classroom[] rooms = { };
            foreach (Classroom room in classrooms)
            {
                if(room.Id != id)
                {
                    Array.Resize(ref rooms, rooms.Length + 1);
                    rooms[^1] = room;
                }
                else
                {
                    StudentsAddToTempArray(room);
                }
                
            }
            if (rooms.Length == classrooms.Length)
                throw new ClassroomNotFoundException();

            classrooms = rooms;
        }

        public static void ShowTempStudents()
        {
            foreach(Student student in TempStudents)
            {
                Console.WriteLine(student);
            }
        }

        //TempStudent arrayindan telebe silme
        public static void RemoveStudentInTempStudents(int id) 
        {
            Student[] newTempStudents = { };
            foreach (Student student in TempStudents)
            {
                if(student.Id != id)
                {
                    Array.Resize(ref newTempStudents, newTempStudents.Length + 1);
                    newTempStudents[^1] = student;
                }
            }
            if(newTempStudents.Length == TempStudents.Length)
            {
                throw new StudentNotFoundException();
            }
            TempStudents = newTempStudents;
        }
        //Bos telebeni sinife menimsete ve temp arraydan silme
        public static void TempStudentAddToClass(int classId, int StudentId)
        {
            Student student1 = null;
            bool check = false;
            foreach (Student student in TempStudents)
            {
                if(student.Id == StudentId) 
                {
                    student1 = student;
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                throw new StudentNotFoundException();
            }
            foreach(Classroom classroom in classrooms)
            {
                if(classroom.Id == classId)
                {
                    Array.Resize(ref classroom.Students, classroom.Students.Length + 1);
                    classroom.Students[^1] = student1;
                    classroom.StudentCount = classroom.Students.Length;
                    RemoveStudentInTempStudents(student1.Id);
                    return;
                }
            }
            throw new ClassroomNotFoundException();
        }
        //telebeleri temparraya elave etme
        public static void StudentsAddToTempArray(Classroom classroom)
        {
            foreach (Student student in classroom.Students)
            {
                Array.Resize(ref TempStudents, TempStudents.Length + 1);
                TempStudents[^1] = student;
            }
        }

        //Id-ye uygun sinifi tapma
        public static Classroom FindClassroomById(int id)
        {
            foreach (Classroom room in classrooms)
            {
                if(room.Id == id)
                    return room;

            }
            throw new ClassroomNotFoundException();
        }

        public static void ShowClassrooms()
        {
            foreach(Classroom room in classrooms)
            {
                Console.WriteLine(room);
            }
        }
        //Sinifi update etme
        public static void EditClassroom(int classId, string name, StudentType studentType)
        {
            foreach(Classroom classroom in classrooms)
            {
                if(classroom.Id == classId)
                {
                    classroom.Name = name;
                    classroom.studentType = studentType;
                    classroom.StudentLimit = (int)studentType;
                }
            }
        }
    }
}
