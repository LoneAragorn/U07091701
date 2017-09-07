using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftA
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList products = new ArrayList();
            products.Add(new Product() { Name = "Röd Groda", Price = 3.50 });
            products.Add(new Product() { Name = "Grön Groda", Price = 37.30 });
            products.Add(new Product() { Name = "Blå Groda", Price = 220 });
            products.Add(new Product() { Name = "Lila Groda", Price = 666 });
            products.Add(new Product() { Name = "Gul groda", Price = 112567 });
            
            Console.WriteLine("Det finns "+products.Count+" produkter i listan.");
            Console.WriteLine();

            for (int i = 0; i <products.Count-1; i++)
            {
                Product p = (Product)products[i];
                Console.Write(p.Name + "|");
            }
            Product q = (Product)products[products.Count - 1];
            Console.Write(q.Name);
            Console.WriteLine();
        }
    }
}
