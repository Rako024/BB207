namespace Class_and_Encaplusation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book(12.5, 5, 1, "Sefiller", "Drama");
            Book book2 = new Book(15.5, 12, 2, "Dune", "Fantastik");
            Book book3 = new Book(20, 27, 3, "Nilde olum", "Dedektiv");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            string flag;
            do
            {
                Console.WriteLine("\n1.Kitab Elave et." +
                    "\n2.Butun kitablari goster." +
                    "\n3.Janra gore kitablari axtar." +
                    "\n4.Qiymet araligina gore kirablari axtar." +
                    "\n0.programdan cix.");
                Console.Write("\nSecminizi daxil edin : ");
                flag = Console.ReadLine();
                Console.WriteLine();
                switch (flag)
                {
                    case "0":
                        break;
                    case "1":
                        Console.Write("Kitabin adini daxil et : ");
                        string bookName = Console.ReadLine();
                        while (true)
                        {
                            if (!string.IsNullOrEmpty(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin adini duzgun daxil edin!" +
                                    "\nKitabi adini daxil et : ");
                                bookName = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine("Kitabin qiymetini daxil et : ");
                        string priceStr = Console.ReadLine();
                        double price;
                        while (true)
                        {
                            if(double.TryParse(priceStr,out price))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin qiymetini duzgun daxil edin!" +
                                    "\nKitabi qiymetini daxil et : ");
                                priceStr = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine("Kitabin sayini daxil et : ");
                        string countStr = Console.ReadLine();
                        int count;
                        while (true)
                        {
                            if (int.TryParse(countStr, out count))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin sayini duzgun daxil edin!" +
                                    "\nKitabi sayini daxil et : ");
                                countStr = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine("Kitabin nomresini daxil et : ");
                        string noStr = Console.ReadLine();
                        int no;
                        while (true)
                        {
                            if (int.TryParse(noStr, out no))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin nomresini duzgun daxil edin!" +
                                    "\nKitabi nomresini daxil et : ");
                                noStr = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        Console.Write("Kitabin janrini daxil et : ");
                        string bookGenre = Console.ReadLine();
                        while (true)
                        {
                            if (!string.IsNullOrEmpty(bookGenre))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin janrini duzgun daxil edin!" +
                                    "\nKitabi janrini daxil et : ");
                                bookGenre = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        library.AddBook(new Book(price,count,no,bookName,bookGenre));
                        continue;
                    case "2":
                        library.ShowAllBooks();
                        continue;
                    case "3":
                        Console.Write("Kitabin janrini daxil et : ");
                        string bookGenre1 = Console.ReadLine();
                        while (true)
                        {
                            if (!string.IsNullOrEmpty(bookGenre1))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin janrini duzgun daxil edin!" +
                                    "\nKitabi janrini daxil et : ");
                                bookGenre1 = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        library.ShowFilteredBooks(library.GetFilteredBooks(bookGenre1));
                        continue;
                    case "4":
                        Console.WriteLine("Kitabin minimum qiymetini daxil et : ");
                        string minPriceStr = Console.ReadLine();
                        int minPrice;
                        while (true)
                        {
                            if (int.TryParse(minPriceStr, out minPrice))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin minimum qiymetini duzgun daxil edin!" +
                                    "\nKitabi minumum qiymetini daxil et : ");
                                minPriceStr = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine("Kitabin maxsimum qiymetini daxil et : ");
                        string maxPriceStr = Console.ReadLine();
                        int maxPrice;
                        while (true)
                        {
                            if (int.TryParse(maxPriceStr, out maxPrice))
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Xahis edirik Kitabin maxsimum qiymetini duzgun daxil edin!" +
                                    "\nKitabi maxsimum qiymetini daxil et : ");
                                maxPriceStr = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                        library.ShowFilteredBooks(library.GetFilteredBooks(minPrice, maxPrice));
                        continue;
                    default:
                        Console.WriteLine("\nXahis edirik duzgun secim edin!!!\n");
                        continue;
                }
               
            } while (!flag.Equals("0"));
        }
    }
}
