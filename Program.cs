﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Porter", "Jk Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
