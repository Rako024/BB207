using System.Text;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ShowReBuildString("         Salam,    dunya    necesen? salamatciliqdimi   hayyy? deqiq???     ");
            //Console.WriteLine(CheckString("Salam1"));
            //Console.WriteLine(FirsWord("  salam sdfsdfsdfsdf   "));

            //Console.WriteLine(CheckWordCountAndUpperChar("  Asdas    Adadas  "));

            //int[] arr = { 1, 2, 3, 4, 5 };
            //AddItem(ref arr, 12);
            //foreach (int i in arr)
            //{
            //    Console.Write(i+" ");
            //}

        }


        public static void ShowReBuildString(string text)//1
        {
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < text.Length-1; i++)
            {
                if (text[i]!=' '&& text[i+1]==' ')
                {
                    str.Append( text[i]+" ");
                }else if(text[i] != ' ')
                {
                    str.Append( text[i]);
                }
            }
            if (text[text.Length-1]!=' ')
                str.Append( text[text.Length-1]);
            
            Console.WriteLine(str.ToString());
        }



        public static bool CheckString(string text)//2
        {
            bool digitCheck = false;
            foreach(char c in text)
            {
                if(c>=48 && c<=57 ) 
                {
                    digitCheck = true;
                    break;
                }
            }
            bool upperCheck = false;
            foreach (char c in text)
            {
                if (c >= 65 && c <= 90)
                {
                    upperCheck = true;
                    break;
                }
            }

            bool lowerCheck = false;
            foreach (char c in text)
            {
                if (c >= 97 && c <= 122)
                {
                    lowerCheck = true;
                    break;
                }
            }

            return (digitCheck && upperCheck) && lowerCheck;
        }

        public static string FirsWord(string text)//3
        {
            StringBuilder str = new StringBuilder();
            text += " ";
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i + 1] == ' ')
                {
                    str.Append( text[i]);
                    break;
                }
                else if (text[i] != ' ')
                {
                    str.Append(text[i]);
                }
            }
            return str.ToString();
        }

        public static bool CheckWordCountAndUpperChar(string text)//4
        {
            text += " ";
            string str = Tools.GetReBuildString(text);
            int count = 0;
            foreach(char c in str)
            {
                if(c == ' ')
                {
                    count++;
                }
            }
            if(count != 2)
            {
                return false;
            }
            else
            {
                if (!(str[0]>=65 && str[0]<=90))
                    return false;
                for(int i = 1; i<str.Length-1; i++) 
                {
                    if (str[i] == ' ' && str[i + 1] != ' ')
                    {
                        if (str[i + 1] >= 65 && str[i + 1] <= 90)
                            return true;
                        else
                            return false;
                    }
                    
                }
                
                return false;
            }
        }

        public static void AddItem(ref int[] arr, int item)//5
        {
            int[] newArr = new int[arr.Length+1];
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length-1] = item;
            arr = newArr;
        }
    }
}
