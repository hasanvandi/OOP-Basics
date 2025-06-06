using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_02
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 10;
            person.Age = -10;
            Console.WriteLine(person.Age);

            Console.ReadLine();
        }
    }
}
