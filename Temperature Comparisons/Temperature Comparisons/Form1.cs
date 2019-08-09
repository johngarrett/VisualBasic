using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature_Comparisons
{
    public partial class Form1 : Form
    {

        Temperature temp1;
        Temperature temp2;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblTempCompare_Click(object sender, EventArgs e)
        {

        }

        private void btnCompareTemps_Click(object sender, EventArgs e)
        {
            //creating the right type of temp for either Celcius or Fahrenheit scale
            if (comboBox1.Text == "Celcius")
                temp1 = new Celcius();
            else if (comboBox1.Text == "Fahrenheit")
                temp1 = new Fahrenheit();

            //creating the right type of temp for either Celcius or Fahrenheit scale
            if (comboBox2.Text == "Celcius")
                temp2 = new Celcius();
            else if (comboBox2.Text == "Fahrenheit")
                temp2 = new Fahrenheit();

            //assigning value to either a Fahrenheit or a Celcius temp field
            try
            {
                double newTemp = Convert.ToDouble(txtTemp1.Text);
                temp1.temp = newTemp;
                double newTemp1 = Convert.ToDouble(txtTemp2.Text);
                temp2.temp = newTemp1;

            }
            catch
            {
                MessageBox.Show("You must enter a number for temperature and select the right scales.");
            }

            int compare = 0;
            compare = temp1.CompareTo(temp2);
            
            if (compare == 0)
                lblTempCompare.Text = "The temperatures are equal.";
            else if (compare < 0)
                lblTempCompare.Text = "The first temperature is cooler than the second.";
            else
                lblTempCompare.Text = "The first temperature is warmer than the second.";       
            }
    }
}
