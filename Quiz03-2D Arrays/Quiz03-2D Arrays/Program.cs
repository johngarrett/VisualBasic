using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//John Garrett
//Forth Period
namespace Quiz03_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] FirstArray = new int[5, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            PrintArray(FirstArray);
            Console.ReadLine();
            AdjustedArray(FirstArray);
        }
        static void PrintArray(int[,] FirstArray)
        {
            for (int r = 0; r < FirstArray.GetLength(0); r++)
            {
                for (int c = 0; c < FirstArray.GetLength(1); c++)
                {
                    Console.WriteLine(FirstArray[r, c]);

                }
            }
        }
        static void AdjustedArray(int[,] FirstArray)
        {
            int[,] SecondArray = new int[5, 2];
            for (int r = 0; r < SecondArray.GetLength(0); r++)
            {
                for (int c = 0; c < SecondArray.GetLength(1); c++)
                {
                    SecondArray[r, c] = FirstArray[r, c] * 2;
                    Console.WriteLine(SecondArray[r, c].ToString());
                }
            }
        }
    }
}
