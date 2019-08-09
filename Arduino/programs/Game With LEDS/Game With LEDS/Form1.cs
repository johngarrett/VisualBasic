using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_With_LEDS
{
    public partial class Form1 : Form
    {
        int intColor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrCalc.Start();
            Arduino.Open();
        }

        private void tmrCalc_Tick(object sender, EventArgs e)
        {
            if (intColor == 1) //Green
            {
                try
                { Arduino.Write("1"); }
                catch (Exception) { MessageBox.Show("Green's not working..."); }
            }
            if (intColor == 2) //Yellow
            {
                try
                { Arduino.Write("2"); }
                catch (Exception) { MessageBox.Show("Yellow's not working..."); }
            }
            if (intColor == 3) //Red
            {
                try
                { Arduino.Write("3"); }
                catch (Exception) { MessageBox.Show("Red's not working..."); }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Arduino.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intColor = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intColor =2 ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intColor = 3;
        }
    }
}
