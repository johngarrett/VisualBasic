using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Random_Number_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isUpper = 0;
            if (radUpper.Checked)
                isUpper = 1;

            char letter =  RadnomLetter.getRandomLetter(isUpper);
            MessageBox.Show(letter.ToString());

        }
        public static class RadnomLetter
        {

            static Random _randNum = new Random();
            public static char getRandomLetter(int isUpper)
            {
                int num1 = _randNum.Next(0, 26);
                if (isUpper == 0)
                {
                    char letter = (char)('a' + num1);
                    return letter;
                }
                else 
                {
                    char letter = (char)('A' + num1);
                    return letter; 
                }
              
            }
        }
    }
}
