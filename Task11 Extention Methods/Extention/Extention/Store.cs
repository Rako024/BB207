using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal class Store
    {
        private static int _id;
        public int Id { get; }
        Product[] Products = { };

        public Store()
        {
            Id = ++_id;
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length +1 );
            Products[Products.Length - 1] = product;
        }
        public void RemoveProductByNo(int no) 
        {
            bool check = false;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    check = true;
                    Products[i] = null;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine(no + " - Nolu product yoxdur!");
            }
            else
            {
                int temp = 0;
                Product[] pr = new Product[Products.Length - 1];
                for (int i = 0; i<Products.Length;i++)
                {
                    if (Products[i] != null)
                    {
                        pr[temp] = Products[i];
                        temp++;
                    }
                }
                Products = pr;
            }
        }

        public Product GetProduct(int no)
        {
            foreach (Product p in Products)
            {
                if (p.No == no)
                {
                    return p;
                }
            }
            Console.WriteLine(no+" - Nolu product tapilmadi!");
            return null;
        }

        public Product[] FilterProductsByType(string type)
        {
            Product[] pr = { };
            foreach (Product p in Products)
            {
                if(p.Type.Equals(type)) 
                {
                    Array.Resize(ref pr, pr.Length + 1);
                    pr[pr.Length - 1] = p;
                }
            }
            if (pr.Length == 0)
                Console.WriteLine("Siyahida mehsul yoxdur");
            return pr;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] pr = { };
            foreach (Product p in Products)
            {
                if (p.Name.Equals(name))
                {
                    Array.Resize(ref pr, pr.Length + 1);
                    pr[pr.Length - 1] = p;
                }
            }
            if(pr.Length == 0)
                Console.WriteLine("Siyahida mehsul yoxdur");
            return pr;
        }

        public bool Sale(int no, Person person)
        {
           Product product =  GetProduct(no);
            if (product == null)
            {
                Console.WriteLine(no+" - Nolu product yoxdur!");
                return false;
            }
            if (person.Cash < product.Price)
            {
                Console.WriteLine("Personun yeterince pulu yoxdur!");
                return false;
            }
            if(product.Count> 0)
            product.Count--;
            else
            {
                Console.WriteLine("Mehsul Stokda yoxdur :( ");
                return false;
            }
            person.Cash-=product.Price;
            return true;
        }
    }
}
