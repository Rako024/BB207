using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Extention
{
    public static class Helper
    {

        public static bool IsNameOrSurnameValid(this string name)
        {
            if (!char.IsUpper(name[0]))
                return false;

            if (name.Split(' ').Length != 1 || name.Length < 3)
                return false;

            return true;
        }

        public static bool isClassroomNameValid(this string roomName)
        {
            if(Regex.IsMatch(roomName, @"^[A-Z]{2}\d{3}$"))
            {
                return true;
            }
            return false;
        }

    }
}
