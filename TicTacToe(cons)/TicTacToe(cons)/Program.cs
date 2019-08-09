using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe_cons_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1; string str2; string str3;
            string str4; string str5; string str6;
            string str7; string str8; string str9;
            string strInput; string strCurrent;
            str1 = "1"; str2 = "2"; str3 = "3";
            str4 = "4"; str5 = "5"; str6 = "6";
            str7 = "7"; str8 = "8"; str9 = "9";

            Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ ");
            strCurrent = "x";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "o";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "x";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7")
            {
                if (str7 == "7")
                {
                    str7 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
" │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ ");
                }
                else Console.WriteLine(" That place is already occpied");
            }
            if (strInput == "8") { if (str8 == "8") { str8 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "o";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "x";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "o";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "x";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;


            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "o";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "o"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "x";
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (strInput == "1") { if (str1 == "1") { str1 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "2") { if (str2 == "2") { str2 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "3") { if (str3 == "3") { str3 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "4") { if (str4 == "4") { str4 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "5") { if (str5 == "5") { str5 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "6") { if (str6 == "6") { str6 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "7") { if (str7 == "7") { str7 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 +
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "8") { if (str8 == "8") { str8 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            if (strInput == "9") { if (str9 == "9") { str9 = "x"; Console.WriteLine(str1 + " │ " + str2 + " │ " + str3 + " │ " + "\n" + "///////////" + "\n" + str4 + " │ " + str5 + 
                " │ " + str6 + " │ " + "\n" + "///////////" + "\n" + str7 + " │ " + str8 + " │ " + str9 + " │ "); } else Console.WriteLine(" That place is already occpied"); }
            strCurrent = "o";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It is player " + strCurrent + "'s turn, Pick a spot");
            Console.ForegroundColor = ConsoleColor.Gray;
            strInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (str1 != " " && str1 == str2 && str2 == str3)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str4 != " " && str4 == str5 && str5 == str6)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str7 != " " && str7 == str8 && str8 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str4 && str4 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str2 != " " && str2 == str5 && str5 == str8)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str6 && str6 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str1 != " " && str1 == str5 && str5 == str9)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
            if (str3 != " " && str3 == str5 && str5 == str7)
                Console.WriteLine("Player " + strCurrent + " Does not Win");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Game Over, if all the spots arent filled you're playing with a cheater" + "\n" +
                    "or you tried overplacing other players" + " \n" + "press any key to exit...");
                Console.ReadLine();
           
        }
    }
}