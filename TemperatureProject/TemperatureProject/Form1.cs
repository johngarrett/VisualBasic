using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureProject
{
    public partial class Form1 : Form
    {
        Temperature temp1;
        Temperature temp2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Celcius")
                temp1 = new Celsius();
            else if (textBox1.Text == "Fahrenheit")
                temp1 = new Fahrenheit();



            if (textBox2.Text == "Celcius")
                temp2 = new celsius();
            else if (textBox2.Text == "Fahrenheit")
                temp2 = new Fahrenheit();


            try
            {
                double newTemp = Convert.ToDouble(textBox1.Text);
                temp1.temp = newTemp;
                double newTemp1 = Convert.ToDouble(textBox2.Text);
                temp2.temp = newTemp1;

            }
            catch
            {
                MessageBox.Show("You must enter a number for temperature and the right scales.");

            }

            int compare = 0;
            if (compare == 0)
                lblAnswers.Text = "The Temps are the same.";
            else if (compare < 0)
                lblAnswers.Text = "The first temp is cooler thant the second";
            else
                lblAnswers.Text = "The first temp is warmer than the second.";








        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
