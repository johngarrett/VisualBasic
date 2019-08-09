using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial_Tes
{
    class Program
    {
        public static int fact1(int num1)
        {
            if (num1 == 0) //base case
                return (1);
            else
                return (num1 * fact1(num1 - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("asdf");
            int number1 = 0;
            number1 = int.Parse(Console.ReadLine());
            fact1(number1);
        }
        static void Call()
        {

            double i; double number; double fact;
            Console.WriteLine("Enter Number");
            number = int.Parse(Console.ReadLine());
            fact = number; 
            for (i = number - 1; i >= 1; i--)
            { fact = fact * i; }
            Console.WriteLine("Factoral of " + fact);
        }
     

    }
}
