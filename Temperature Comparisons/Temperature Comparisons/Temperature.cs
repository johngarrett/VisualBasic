using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Temperature_Comparisons
{
    abstract class Temperature:IComparable<Temperature>
    {
        public double temp { get; set; }

        public Temperature()
        {
            temp = 0;
        }

        public Temperature(double t)
        {
            temp = t; 
        }

        abstract public double GetConversion();

        abstract public int CompareTo(Temperature T);


    }
}
