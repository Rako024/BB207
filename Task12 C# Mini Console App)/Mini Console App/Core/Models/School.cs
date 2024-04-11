using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class School
    {
        public static Classroom[] classrooms = { };
        //public static Classroom[] TempClassRoom = { };

        public static void AddClassroom(Classroom room)
        {
            Array.Resize(ref classrooms, classrooms.Length + 1);
            classrooms[^1] = room;  
        }

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
                
            }
            if (rooms.Length == classrooms.Length)
                throw new ClassroomNotFoundException();

            classrooms = rooms;
        }

        //public static void StudentsAddToTempArray(Classroom classroom)
        //{
        //    foreach(var student in classroom.students)
        //    Array.Resize(ref TempClassRoom, TempClassRoom.Length + 1);
        //    TempClassRoom[^1] = 
        //}

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
    }
}
