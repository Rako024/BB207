// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task 1");
Console.WriteLine();
#region task 1
int n = 155;
int product = 1;
while(n > 0)
{
    product *= n % 10;
    n -= n % 10;
    n /=10;
}
Console.WriteLine(product);
Console.WriteLine();
#endregion
Console.WriteLine("Task 2");
Console.WriteLine();
#region task2
int a = 11  ;
bool t = false;
if (a == 1 || a == 0)
{
    Console.WriteLine("Eded sade ve ya murekkeb deyil");
}
else
{
    for (int i = 2; i * i <= a; i++)
    {
        if (a % i == 0)
        {
            t = true;
            break;
        }
    }

    if (t)
    {
        Console.WriteLine("Eded Sade deyil");
    }
    else
    {
        Console.WriteLine("Eded sadedir");
    }
}
Console.WriteLine();
#endregion
Console.WriteLine("Task 3");
Console.WriteLine();
#region task3

int k = -10 ;
int fak = 1;

if (k == 0)
{
    Console.WriteLine(1);
}else if (k < 0)
{
    Console.WriteLine("Neqativ ededin faktoriali olmur!!!");
}
else
{
    for (int i = 1; i <= k; i++)
    {
        fak *= i;
    }

    Console.WriteLine(fak);
}
Console.WriteLine();
#endregion

Console.WriteLine("Task 4");
Console.WriteLine();
#region task4
int c = 1211;
int copy1 = c,copy2 = 0;
while(copy1 > 0)
{
    
    copy2 = copy2 + copy1 % 10;
    if (copy1 > 9)
    {
        copy2 *= 10;
    }
    copy1 /= 10;

}

if (c == copy2)
{
    Console.WriteLine("Eded polindromdur");
}
else
{
    Console.WriteLine("Eded polindrom deyil");
}

Console.WriteLine();
#endregion
