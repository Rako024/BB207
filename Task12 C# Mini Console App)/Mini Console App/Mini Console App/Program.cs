using Core.Enums;
using Core.Exceptions;
using Core.Extention;
using Core.Models;

namespace Mini_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
        MENU:
            try
            {
                Console.WriteLine("\n--------------------Menu------------------\n"+
                    "1.Classroom yarat\r\n" +
                    "2.Butun Sinifleri ekrana cixar\n" +
                    "3.Secilmis sinifdeki telebeleri ekrana cixart\r\n" +
                    "4.Secilmis sinifin menusuna kec\n" +
                    "5.Secilmis sinifi sil\n"+
                    "0.Proqramdan cix\n" +
                    "--------------------------------------\n");
                Console.Write("Seciminizi daixl etdin : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Istifade etdiyiniz ucun tefekkurler <3");
                        break;

                    case "1":
                    CLASSName:
                        Console.Write("Sinifin adini daxil et : ");
                        string className = Console.ReadLine();
                        if (!className.isClassroomNameValid())
                        {
                            Console.WriteLine("Sinif adini duzgun daxil et!");
                            goto CLASSName;
                        }
                    CLASSTYPE:
                        Console.WriteLine("Sinif Tipini secin:\n1.Backend\n2.Frontend\nSeciminizi daxil edin:");
                        string classType = Console.ReadLine();
                        StudentType studentType;
                        if (classType.Equals("1"))
                        {
                            studentType = StudentType.Backend;
                        }
                        else if (classType.Equals("2"))
                        {
                            studentType = StudentType.Frontend;
                        }
                        else
                        {
                            Console.WriteLine("Seciminizi dogru edin!");
                            goto CLASSTYPE;
                        }
                        Classroom classroom = new Classroom(className, studentType);
                        School.AddClassroom(classroom);
                        goto MENU;
                    case "2":
                        School.ShowClassrooms();
                        goto MENU;
                    case "3":
                        School.ShowClassrooms();
                    CLASSID1:
                        Console.Write("\nSecdiyiniz sinifin id'ni daxil edin : ");
                        int classId;
                        if (!int.TryParse(Console.ReadLine(), out classId))
                        {
                            Console.WriteLine("Idni duzgun qeyd edin!!!");
                            goto CLASSID1;
                        }
                        School.FindClassroomById(classId).ShowStudents();
                        goto MENU;
                    case "4":
                        School.ShowClassrooms();
                    CLASSID2:
                        Console.Write("\n Secdiyiniz sinifin id'ni daxil edin : ");
                        int classId1;
                        if (!int.TryParse(Console.ReadLine(), out classId1))
                        {
                            Console.WriteLine("Idni duzgun qeyd edin!!!");
                            goto CLASSID2;
                        }
                        SubMenu(School.FindClassroomById(classId1));
                        goto MENU;
                    case "5":
                        School.ShowClassrooms();
                    CLASSID3:
                        Console.Write("\n Secdiyiniz sinifin id'ni daxil edin : ");
                        int classId2;
                        if (!int.TryParse(Console.ReadLine(), out classId2))
                        {
                            Console.WriteLine("Idni duzgun qeyd edin!!!");
                            goto CLASSID3;
                        }
                        School.RemoveClassroom(classId2);
                        goto MENU;
                    default:
                        Console.WriteLine("Secimi dogru et!!!");
                        goto MENU;
                }
            }catch (StudentNotFoundException e) 
            {
                Console.WriteLine("ERROR: "+e.Message);
                goto MENU;
            }catch (ClassroomNotFoundException e) 
            {
                Console.WriteLine("ERROR: "+e.Message);
                goto MENU;
            }catch(Exception e)
            {
                Console.WriteLine("ERROR:"+ e.Message);
                goto MENU;
            }
        }

        public static void SubMenu(Classroom room)
        {
        SUBMENU:
            try
            {
                Console.WriteLine("\n---------------Menu-----------------\n"+
                    "1.Telebe Yarat.\n" +
                    "2.Sinifdeki telebelere ekrana cixar\n" +
                    "3.Telebe sil\n" +
                    "4.Telebeni edit et\n" +
                    "0.Ust menuya qayit\n" +
                    "----------------------------------\n"
                    );
                Console.Write("Seciminiz edin : ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Ust menuya yonlendirildiniz!");
                        return;
                    case "1":
                    STUDENTNAME:
                        Console.Write("Studdentin Adini daxil et : ");
                        string studentName = Console.ReadLine();
                        if (!studentName.IsNameOrSurnameValid())
                        {
                            Console.WriteLine("Studentin adini duzgun daxil edin!!!");
                            goto STUDENTNAME;
                        }
                    STUDENTSURNAME:
                        Console.Write("Studdentin Soyadini daxil et : ");
                        string studentSurname = Console.ReadLine();
                        if (!studentSurname.IsNameOrSurnameValid())
                        {
                            Console.WriteLine("Studentin soyadini duzgun daxil et!!!");
                            goto STUDENTSURNAME;
                        }

                        Student student = new Student(studentName, studentSurname);
                        room.AddStudent(student);
                        goto SUBMENU;
                    case "2":
                        room.ShowStudents();
                        goto SUBMENU;
                    case "3":
                        room.ShowStudents();
                    STUDENTID1:
                        Console.Write("Telebenin id sini daxil et : ");
                        if (!int.TryParse(Console.ReadLine(), out int studentId1))
                        {
                            Console.WriteLine("Id ni duzgun daxil edin!");
                            goto STUDENTID1;
                        }
                        room.DeleteById(studentId1);
                        goto SUBMENU;
                    case "4":
                        room.ShowStudents();
                    STUDENTID2:
                        Console.Write("Telebenin id sini daxil et : ");
                        if (!int.TryParse(Console.ReadLine(), out int studentId2))
                        {
                            Console.WriteLine("Id ni duzgun daxil edin!");
                            goto STUDENTID2;
                        }
                    STUDENTNAME1:
                        Console.Write("Studdentin Adini daxil et : ");
                        string studentName1 = Console.ReadLine();
                        if (!studentName1.IsNameOrSurnameValid())
                        {
                            Console.WriteLine("Studentin adini duzgun daxil edin!!!");
                            goto STUDENTNAME1;
                        }
                    STUDENTSURNAME1:
                        Console.Write("Studdentin Soyadini daxil et : ");
                        string studentSurname1 = Console.ReadLine();
                        if (!studentSurname1.IsNameOrSurnameValid())
                        {
                            Console.WriteLine("Studentin soyadini duzgun daxil et!!!");
                            goto STUDENTSURNAME1;
                        }

                        room.EditStudent(studentId2, studentName1, studentSurname1);
                        goto SUBMENU;
                    default:
                        Console.WriteLine("Secimiz dugun et!");
                        goto SUBMENU;
                }
            }
            catch (StudentNotFoundException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                goto SUBMENU;
            }
            catch (ClassroomNotFoundException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
                goto SUBMENU;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR:" + e.Message);
                goto SUBMENU;
            }
        }
    }
}
