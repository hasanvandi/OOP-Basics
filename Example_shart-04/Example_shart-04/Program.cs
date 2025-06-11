using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_shart_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Product product1 = new Product("book",158.3,3);

            Product product2 = new Product("Mose", -200, -3);


            Console.WriteLine($"Name:{product.Name}\nPrice:{product.Price}\nStock:{product.Stock}");

            Console.WriteLine($"Name:{product1.Name}\nPrice:{product1.Price}\nStock:{product1.Stock}");

            Console.WriteLine($"Name:{product2.Name}\nPrice:{product2.Price}\nStock:{product2.Stock}");





            Console.ReadLine();
        }
    }
}
