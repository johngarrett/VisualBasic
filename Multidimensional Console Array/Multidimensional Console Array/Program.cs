using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Mr. Letts
//int[,] intArr= new int[ , ] {{9, 99}, {3, 33}, {5, 55}};for (int r = 0; r < intArr.GetLength(0); r++) { 	for (int c = 0; c < intArr.GetLength(1); c++)	{     		Statements;	}}

//John Garrett
//12/1

namespace Multidimensional_Console_Array
{
    class Program
    {
        static  void Display(double[,] grid)
        {
            grid[0, 0] = 1.2; grid[0, 1] = 5.7; grid[0, 2] = 9.4; grid[0, 3] = 3.3;
            grid[1, 0] = 7.5; grid[1, 1] = 3.2; grid[1, 2] = 6.7; grid[1, 3] = 8.1;
            grid[2, 0] = 6.1; grid[2, 1] = 2.5; grid[2, 2] = 4.7; grid[2, 3] = 8.2;
            Console.WriteLine("|" + grid[0, 0].ToString() + "|" + grid[0, 1].ToString() + "|" + grid[0, 2].ToString() + "|" + grid[0, 3].ToString() + "|");
            Console.WriteLine("-----------------");
            Console.WriteLine("|" + grid[1, 0].ToString() + "|" + grid[1, 1].ToString() + "|" + grid[1, 2].ToString() + "|" + grid[1, 3].ToString() + "|");
            Console.WriteLine("-----------------");
            Console.WriteLine("|" + grid[2, 0].ToString() + "|" + grid[2, 1].ToString() + "|" + grid[2, 2].ToString() + "|" + grid[2, 3].ToString() + "|");
            Console.WriteLine("-----------------");
        }
        static void Add(double[,] grid)
        {//assigning that array the same values instead of using the old array due to the instructions
            grid[0, 0] = 1.2; grid[0, 1] = 5.7; grid[0, 2] = 9.4; grid[0, 3] = 3.3;
            grid[1, 0] = 7.5; grid[1, 1] = 3.2; grid[1, 2] = 6.7; grid[1, 3] = 8.1;
            grid[2, 0] = 6.1; grid[2, 1] = 2.5; grid[2, 2] = 4.7; grid[2, 3] = 8.2;
            grid[0, 0]++; grid[0, 1]++; grid[0, 2]++; grid[0, 3]++;
            grid[1, 0]++; grid[1, 1]++; grid[1, 2]++; grid[1, 3]++;
            grid[2, 0]++; grid[2, 1]++; grid[2, 2]++; grid[2, 3]++;
            Console.WriteLine("|" + grid[0, 0].ToString() + "|" + grid[0, 1].ToString() + "|" + grid[0, 2].ToString() + "|" + grid[0, 3].ToString() + "|");
            Console.WriteLine("-----------------");
            Console.WriteLine("|" + grid[1, 0].ToString() + "|" + grid[1, 1].ToString() + "|" + grid[1, 2].ToString() + "|" + grid[1, 3].ToString() + "|");
            Console.WriteLine("-----------------");
            Console.WriteLine("|" + grid[2, 0].ToString() + "|" + grid[2, 1].ToString() + "|" + grid[2, 2].ToString() + "|" + grid[2, 3].ToString() + "|");
            Console.WriteLine("-----------------");
            Console.ReadLine();
        }
        static   void Main(string[] args)
        {
            double[,] dblGrid = new double[3, 4]; //{{row1column 1, column 2, column 3,column 4}},{row2collum 1, column 2, column 3, column 4}{row3collum 1, column 2, column 3,column 4}}
            Display(dblGrid );       
            Console.WriteLine("Hit Enter to add 1 to all values");
            Console.ReadLine();
            //Creating a new array for no reason but to follow the instructions
            double[,] newdblGrid = new double[3, 4];
            Add(newdblGrid );
       
        }
        
      }
}
