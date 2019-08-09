//John Garrett
//Period 4 Letts
//8/25/15


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double num1 = 6; double num2 = 3; double num3 = 2;
            double answer = num1 + num2 / num3;
            label1.Text = answer.ToString();  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double num1 = 6; double num2 = 3; double num3 = 2;
            double answer = (num1 + num2) / num3;
            label2.Text = answer.ToString();  
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double num1 = 9; double num2 = 2; double num3 = 5;
            double answer = num1 * num2 / num3;
            label3.Text = answer.ToString();  
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double num1 = 9.0; double num2 = 2; double num3 = 5;
            double answer = num1 * num2 / num3;
            label4.Text = answer.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            double num1 = 7; double num2 = 2;
            double answer = num1 / num2;
            label5.Text = answer.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double num1 = 7; double num2 = 2;
            double answer = num1 % num2;
            label6.Text = answer.ToString();
        }
    }
}
