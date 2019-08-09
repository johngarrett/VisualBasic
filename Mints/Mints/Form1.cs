//John Garrett
//Mr. Letts
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            int intMints = Convert.ToInt32(txtMints.Text);
   result =  intMints % 3;
   lblLeft.Text = result.ToString();

   int result2 = 0;
   result2 = intMints / 3;
   lblServings.Text = result2.ToString();
        }
    }
}
