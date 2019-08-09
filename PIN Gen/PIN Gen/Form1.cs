using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIN_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random randNum = new Random();
        static string strLetter;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string lengthTemp = txtLength.Text; string howmanyTemp = txtHowMany.Text;
            try
            {
                int length = Convert.ToInt32(lengthTemp); int howMany = Convert.ToInt32(howmanyTemp);
                for (int i = 0; i < length; i++) {

                    int num1 = randNum.Next(0, 26);
                    int intLength = strLetter.Length;
                    char letter = (char)('a' + num1);

                    strLetter += letter.ToString(); }
                for (int u = 0; u < howMany; u++)
                {
                    lstOutput.Items.Add(strLetter);
                    strLetter = string.Empty;
                }
            }
            catch{ MessageBox.Show("Please re-enter your amount in a correct format");}
        }
        }
    }
    

