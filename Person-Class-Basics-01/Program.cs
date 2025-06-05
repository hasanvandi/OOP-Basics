using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class_Basics_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "mahdi";
            p.LastName = "Hasanvandi";
            p.Age = 28;
            Console.WriteLine(p.GetFullName());

            Console.ReadLine();
        }
    }
}
