using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_03
{
    public class Book
    {
      private string _title;
      private string _author;
      private double _price;


        public Book()
        {
            _title = "defult";
            _author = "defult";
            _price = 0;
        }

        public Book(string title,string author,double price)
        {
            this._title = title;
            this._author = author;
            this._price = price;
        }

        /// <summary>
        /// نمایش اطلاعات
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Title:{_title}");
            Console.WriteLine($"Title:{_author}");
            Console.WriteLine($"Title:{_price}");

        }
    }
}
