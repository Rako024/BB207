namespace Rashids_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine(list.Count+" "+list.Capacity);
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count+" "+list.Capacity);
            RashidsList<int> ints = new RashidsList<int>();
            ints.Add(0);
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Rashid's List Cout = {ints.Count} Capacity = {ints.Capacity}");
            
            ints.Inset(12, 2);
            ints.Inset(12, 4);
            ints.Sort();
            Console.WriteLine($"Rashid's List Cout = {ints.Count} Capacity = {ints.Capacity}");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("index of = "+ints.IndexOf(12)+" lastindexof = "+ints.LastIndexOf(12));
        }
    }
}
