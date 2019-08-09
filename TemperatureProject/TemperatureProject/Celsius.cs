using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureProject
{
    class Celsius
    {
        class celsius : Temperature
        {
            public celsius()
                : base() { }

            public celsius(double temp)
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
                if (T is celsius)
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


                MessageBox.Show(" There is a problem with the CompareTo for celsius");
                return -1;

            }
        }
    }
}
