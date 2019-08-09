using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pin_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random randnum = new Random();

        private void btngenerate_Click(object sender, EventArgs e)
        {
            string lengthTemp = txtLength.Text; 
            string howmanyTemp = txtHowMany.Text;




            int length = Convert.ToInt32(lengthTemp); int howMany = Convert.ToInt32(howmanyTemp);


            for (int i = 0; i < howMany; i++)
            {
                int pin = getRand(length);
                lstOutput.Items.Add(pin.ToString());
            }
        }


        private int getRand(int length)
        {
            int pin = 0;
            int min = Convert.ToInt32(Math.Pow(10, length - 1));
            int max = Convert.ToInt32(Math.Pow(10, length));
            pin = randnum.Next(min, max);
            return pin;
        }

  






    }


}

