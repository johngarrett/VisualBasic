using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayTest");
            int[,] intArr = new int[,] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            string[,] friends = new string[2, 2] { { "John", "PRid" }, { "F", "DS" } };
                Console.WriteLine(friends);
            Console.ReadLine();
            Console.WriteLine(intArr.ToString());
            Console.ReadLine();

        }
    }
}
