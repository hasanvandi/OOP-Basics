using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Book book1 = new Book("MasnaviManavi","Molana",999.9);



            book.PrintInfo();
            book1.PrintInfo();


            Console.ReadLine();

        }
    }
}
