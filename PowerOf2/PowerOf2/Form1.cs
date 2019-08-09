using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerOf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double dblAnswer = 0; Double dblExpon = 0;
            for (dblExpon =1; dblExpon <11; dblExpon ++)
            {
                dblAnswer = Math.Pow(2, dblExpon);
                lblAnswer.Text += "2 to the " + dblExpon.ToString() + " power equals " + dblAnswer.ToString() + ".\n";
            }
        }
    }
}
