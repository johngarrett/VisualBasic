using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTS_FORM
{
    class Vehicle
    {
        private int Fuel = 0;
        private int Health = 0;
        private int damage = 0;

        public int FuelAmount
        {
            get
            {return Fuel;}

            set
            {Fuel = value;}

 }

        public int VehicleHealth
        {
            get
            { return Health;}
            set
            {  Health = value; }
        }

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
    }
}
