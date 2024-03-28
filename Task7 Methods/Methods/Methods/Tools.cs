using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Tools
    {

        public static string GetReBuildString(string text)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != ' ' && text[i + 1] == ' ')
                {
                    str.Append(text[i] + " ");
                }
                else if (text[i] != ' ')
                {
                    str.Append(text[i]);
                }
            }
            if (text[text.Length - 1] != ' ')
                str.Append(text[text.Length - 1]);

            return str.ToString();
        }
    }
}
