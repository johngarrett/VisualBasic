using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Facts
{
    class carInfo
    {

        private double cost;
        private string damage;
        private string type;
        private int mileage;
        private string wdamage;
        private int owners;
        public void Car()
        {
            damage = "";
            cost = 0;
            type = "";
            mileage = 0;
            wdamage = "";
            owners = 1;

        }
        public void Car(string damage, double cost, string type, int mileage, string wdamage, int owners)
        {
            this.damage = damage;
            this.cost = cost;
            this.type = type;
            this.mileage = mileage ;
            this.wdamage = wdamage;
            this.owners = owners;



        }
   
        public string Damage
        {
            get
            { return damage;}
            set
            { damage = value; }
        }
        public string wDamage
        {
            get
            { return wdamage; }
            set
            { wdamage = value; }
        }
        public double Cost
        {
            get
            { return cost; }
            set
            { cost = value; }
        }
        public string Type
        {
            get
            { return type; }
            set
            { type = value; }
        }
        public int Mileage
        {
            get
            { return mileage; }
            set
            { mileage = value; }
        }
        public int Owners
        {
            get
            { return owners; }
            set
            { owners  = value; }
        }
    }
}