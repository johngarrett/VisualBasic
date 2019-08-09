using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace Temperature_Comparisons
{
    class Celcius : Temperature
    {
        public Celcius()
            : base() { }

        public Celcius(double temp)
            : base(temp)
        {
            this.temp = temp;
        }

        public override double GetConversion()
        {
            double newTemp = 0;
            newTemp = temp * 9 / 5 + 32;
            return newTemp;

        }

        public override int CompareTo(Temperature T)
        {
            if (T is Celcius)
            {
                if (this.temp == T.temp)
                    return 0;
                else if (this.temp < T.temp)
                    return -1;
                else
                    return 1;
            }

            if (T is Fahrenheit)
            {
                if (this.temp == Math.Round(T.GetConversion(), 0))
                    return 0;
                else if (this.temp < Math.Round(T.GetConversion(), 0))
                    return -1;
                else
                    return 1;
            }
            MessageBox.Show("The CompareTo method for Celcius is not working!");
            return -1;
        }
    }
}
