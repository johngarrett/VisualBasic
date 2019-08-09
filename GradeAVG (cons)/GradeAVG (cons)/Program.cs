using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeAVG__cons_
{
    class Program
    {
        static void Main(string[] args)
        {
              double dblAverage;
            double dblAmount = 1;
            double dblGrade = 0;
            Console.WriteLine("enter a grade, type stop to finish");
            string strEntered;
               strEntered = Console.ReadLine();
               try { dblGrade += Convert.ToDouble(strEntered); }
               catch  {   Console.WriteLine("dumb");  }
               
            while (strEntered != "stop")
            {
                Console.WriteLine("enter a grade, type stop to finish");
                strEntered = Console.ReadLine();
                dblAmount++;
                try
                {
                    dblGrade += Convert.ToDouble(strEntered);
                }
                catch
                {
                    Console.WriteLine("dumb");
                }
          
            }
            if (strEntered == "stop")
            {
                  dblAverage = (dblGrade / (dblAmount-1));
            Console.WriteLine(" Your Average is " + dblAverage.ToString());
            Console.ReadLine();
                }
            }
 
            
          
        }
    }

