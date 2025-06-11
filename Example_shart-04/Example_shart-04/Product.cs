using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Example_shart_04
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _stock;



        public string Name { get { return _name; } set { _name = value; } }

        public double Price
        {
            get
            {
              return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter a right amount");
                    _price = 0;

                }
                else
                {
                    _price = value;

                }
            }

        }

        public int Stock 
        {
            get 
            { 
                return _stock;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter a right amount");
                    _stock = 0;
                }
                else
                {
                    _stock = value;
                }
            }
        }


        public Product()
        {
           Name = "Name";
           Price = 0;
           Stock = 0;
        }


        public Product(string name, double price, int stock)
        {
           Name = name;
           Price = price;
           Stock = stock;
        }

    }
}
