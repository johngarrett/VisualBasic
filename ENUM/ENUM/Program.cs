using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENUM
{
    class Program
    {
        enum chores : byte { Clean_Room =1 , Trash, Dishes, Cut_the_Grass, Tend_to_Pets, Launndry };
        enum week : byte { mon = 1, tues, wed, thurs, fri, sat };
        static void Main(string[] args)
        {
            int a = (int)chores.Clean_Room;  int b = (int)chores.Trash; int c = (int)chores.Dishes;
            int d = (int)chores.Cut_the_Grass; int e = (int)chores.Tend_to_Pets;int f = (int)chores.Launndry;

            int a1 = (int)week.mon; int b1 = (int)week.tues;int c1 = (int)week.wed; 
            int d1 = (int)week.thurs;  int e1 = (int)week.fri;int f1 = (int)week.sat;
            Console.WriteLine("Mon = {0}", a1);
            Console.WriteLine("Tues = {0}", b1);
            Console.WriteLine("Wed = {0}", c1);
            Console.WriteLine("Thurs = {0}", d1);
            Console.WriteLine("Fri = {0}", e1);
            Console.WriteLine("Sat = {0}", f1);
            Console.WriteLine(""); 
            Console.WriteLine("Clean_Room = {0}", a);
            Console.WriteLine("Trash = {0}", b);
            Console.WriteLine("Dishes = {0}", c);
            Console.WriteLine("Cut the grass = {0}", d);
            Console.WriteLine("tend to pest = {0}", e);
            Console.WriteLine("laundry = {0}", f);
            Console.ReadLine();
        }
        
    }
}
