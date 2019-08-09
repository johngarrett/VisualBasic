using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {

        static void Main(string[] args)

        {
          
                string firstName = "";
                string lastName = "";
                Console.WriteLine("Name: " + firstName + " " + lastName);
               do
            {
                Console.WriteLine("Please enter a new first name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Please enter a new Last name:");
                lastName  = Console.ReadLine();

                Console.WriteLine("New name: " + firstName + " " + lastName);

                Console.ReadLine();

            }
            while (1 + 1 == 2);
        }
    }
}
