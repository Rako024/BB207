namespace Extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Store store = new Store();

MENU:
            Console.WriteLine("-----------MENU-----------\n" +
                "1. Mehsul elave et\r\n" +
                "2. Mehsul sil\r\n" +
                "3. Mehsula bax\r\n" +
                "4. Type'a gore mehsullara bax\r\n" +
                "5. Ada gore mehsullara bax\r\n" +
                "0. Proqramdan cix\n" +
                "-------------------------");
            Console.Write("Seciminizi daxil edin : ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "0":
                    Console.WriteLine("Istifade etdiyiniz ucun tesekkurler!");
                    break;
                case "1":
AD:
                    Console.Write("Mehsulun adini daxil edin : ");
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Mehsulun adini duzgun daxil edin!!!\n");
                        goto AD;
                    }
QIYMET:
                    Console.Write("\nMehsulun qiymetini daxil edin : ");
                    if(!int.TryParse(Console.ReadLine(), out int price))
                    {
                        Console.WriteLine("Mehsulun qiymetini duzgun daxil edin!!!\n");
                        goto QIYMET;
                    }
TIP:
                    Console.Write("Mehsulun tipini daxil edin : ");
                    string type = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(type))
                    {
                        Console.WriteLine("Mehsulun Tipini duzgun daxil edin!!!\n");
                        goto TIP;
                    }

SAY:
                    Console.Write("\nMehsulun sayini daxil edin : ");
                    if (!int.TryParse(Console.ReadLine(), out int count))
                    {
                        Console.WriteLine("Mehsulun sayini duzgun daxil edin!!!\n");
                        goto SAY;
                    }
                    Product product = new Product(name, price, type, count);
                    store.AddProduct(product);
                    goto MENU;
                case "2":
NO1:
                    Console.Write("\nSilmek stediyiniz mehsulun No-nu daxil edin : ");
                    if (!int.TryParse(Console.ReadLine(), out int no))
                    {
                        Console.WriteLine("Mehsulun NO-nu duzgun daxil edin!!!\n");
                        goto NO1;
                    }
                    store.RemoveProductByNo(no);
                    goto MENU;
                case "3":
NO2:
                    Console.Write("Baxmaq istediyini mehsulun No-nu daxil edin : ");
                    if (!int.TryParse(Console.ReadLine(), out int no2))
                    {
                        Console.WriteLine("Mehsulun NO-nu duzgun daxil edin!!!\n");
                        goto NO2;
                    }
                    if(store.GetProduct(no2)!=null)
                    Console.WriteLine( store.GetProduct(no2).ToString());
                    goto MENU;
                case "4":
TIP1:
                    Console.Write("TYPE daxil edin : ");
                    string type1 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(type1))
                    {
                        Console.WriteLine("Mehsulun Tipini duzgun daxil edin!!!\n");
                        goto TIP1;
                    }
                    foreach(var item in store.FilterProductsByType(type1))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    goto MENU;
                case "5":
AD2:
                    Console.Write("mehsulun adini daxil edin : ");
                    string name1 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name1))
                    {
                        Console.WriteLine("Mehsulun Adini duzgun daxil edin!!!\n");
                        goto AD2;
                    }
                    foreach (var item in store.FilterProductsByName(name1))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    goto MENU;
                default:
                    Console.WriteLine("Duzgun secim edin!!!\n");
                    goto MENU;
            }
        }
    }
}
