using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_02
{
    public class Person
    {
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("Age Can,t be negative");
                }
                _age = value;
            }
        }
    }
}
