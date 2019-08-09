using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace AvgGrade
{
    public partial class Form1 : Form
    { public Form1() {InitializeComponent(); }
         private void btnCalc_Click(object sender, EventArgs e)
        {
            string strGrade; double dblAmount = 0; double dblGrade = 0;
            do 
            {
                dblAmount++;
                strGrade = Microsoft.VisualBasic.Interaction.InputBox("Enter your grade in numerical formal type avg to average your grade");
                if (strGrade != "avg" && strGrade != "stop")
              {
                    try
                  {      dblGrade += Convert.ToDouble (strGrade);
                        label1.Text += "Grade entered:" + strGrade + "%" + "\n"; }
                    catch
                  { MessageBox.Show("please enter your grade into numerical form"); }

             }
                if (strGrade == "avg")
             {
                    double dblAverage;
                    dblAverage = (dblGrade / dblAmount);
                    MessageBox.Show(" Your Average is " + dblAverage.ToString());
             }
                }
           while (strGrade != "avg");
      }
         private void Form1_Load(object sender, EventArgs e) { this.AutoSize = true; this.AutoSizeMode = AutoSizeMode.GrowOnly; }
    }
}
