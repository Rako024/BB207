namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = { "salam", "resid", "yusif", "ruslan" };
            string[] str2 = { "resid", "yusif", "Arif","ruslan", "gulu","Anar" };
            ChechEqualsString(str1, str2);

            Console.WriteLine();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            ProductNumbers(nums);
            Console.WriteLine();
            StartCharacterA(str2);


            Console.WriteLine();
            int[] k = Fibonacci(5);
            foreach (int i in k)
            {
                Console.Write(i+" ");
            }
        }


        public static void ChechEqualsString(string[] str1, string[] str2) //task 1
        {
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        Console.WriteLine(str1[i]);
                    }
                }
            }
        }

        public static void ProductNumbers(int[] nums)   //task2
        {
            int product = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }
            Console.WriteLine(product);
        }

        public static void StartCharacterA(string[] strings)    //task3
        {
            for(int i = 0;i < strings.Length; i++)
            {
                if (strings[i][0] == 'A')
                {
                    Console.WriteLine(strings[i]);
                }
            }
        }

        public static int[] Fibonacci(int n)    //task 4
        {
            int[] nums = new int[n];
            int a = 0, b = 1, temp = 0;
            for(int i = 0; i < n; i++)
            {
                nums[i] = a;
                temp = a;
                a = b;
                b = temp + b;
            }
            return nums;
        }
    }
}
