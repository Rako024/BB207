using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access
{
    internal class Student
    {
        private string _fullName;
        public String FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if(value == null)
                {
                    Console.WriteLine("FullName bos ola bilmez");
                }
                else
                {
                    _fullName = value;
                }
            }
        }
        public String GroupNo { get; set; }
        public double AvgPoint { get; set; }

        public Student(string fullname)
        {
            FullName = fullname;
        }

        public Student(string fullname, double avgPoint):this(fullname)
        {
            AvgPoint = avgPoint;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{FullName,-20} {AvgPoint,-9} {GroupNo,-15}");
        }
    }
}
