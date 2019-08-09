using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sara
{
    class Program
    {
        static void Main(string[] args)
        {
            string strUser ;
            string strName;
         
            Console.WriteLine("Hello, what is your name?");
                strName = Console.ReadLine();
                Console.WriteLine("Hello " + strName + " ,what would you like to do today?");
                strUser = Console.ReadLine();
                if (strUser == "watch")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                }
                Console.WriteLine("Thats good," +strName+" I am "+strUser +" aswell." + "\n" + "Would you like to play a game?");
                strUser = Console.ReadLine();
                if (strUser == "Yes" || strUser == "yes" || strUser == "y" || strUser == "Y")
                {
                    Console.WriteLine("Alright " + strName + " lets play a game i copied and pasted off of google");
                    bool gameRunning = true;
                    ConsoleKeyInfo userKey;
                    int locationX = 0;
                    int locationY = 0;

                    while (gameRunning)
                    {
                        if (Console.KeyAvailable)
                        {
                            userKey = Console.ReadKey(true);
                            switch (userKey.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                 
                                    if (locationX > 0)
                                    { locationX = locationX - 1; }
  break;

                                case ConsoleKey.RightArrow:
                                    if (locationX < 78)
                                    {locationX = locationX + 1; }
                                    break;

                                case ConsoleKey.UpArrow:
                                    if (locationY > 0)
                                    { locationY = locationY - 1;  }
                                    break;

                                case ConsoleKey.DownArrow:
                                    if (locationY < 24) { locationY = locationY + 1; }
                                    break;
                                case ConsoleKey.Escape:
                                    gameRunning = false;
                                    break;
                            }

                        }
                        Console.Clear();
                        Console.SetCursorPosition(locationX, locationY);
                        Console.Write(strName);
                    }
                    if (gameRunning == false)
                    {
                        Console.Clear();
                        Console.WriteLine("That was fun " + strName + " Can I ask you some questions?");
                        strUser = Console.ReadLine();
                        if (strUser == "Yes" || strUser == "yes" || strUser == "y" || strUser == "Y")
                        {
                        }
                        else
                        {
                            Console.WriteLine("I have been waiting for the sweet release of death " + strName + "\n" + " Push enter to send me away... forever");
                        }
                    }
                }





                else
                {  Console.WriteLine("Well " + strName + " I guess you dont want to play a game with me :(, Goodbye." + "\n" + "Type something to end me."); }
                Console.ReadLine();

       
        }
    }
}
