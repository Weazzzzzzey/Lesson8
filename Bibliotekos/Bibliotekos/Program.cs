using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace Bibliotekos
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga = new Book();
            knyga.Name = "Black-Hawk";
            knyga.ID = "0001";
            

            Console.WriteLine(knyga.LocalID);

            Console.ReadLine();
        }
    }
}
