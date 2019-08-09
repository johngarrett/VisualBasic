using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoyStick_Test
{
    public partial class Form1 : Form
    {
        static string indata;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            Arduino.Open(); tmrCalc.Start();
        }
        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
             indata = sp.ReadExisting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Top += 1;
            lbl2.Top += 1;
            lbl3.Top += 1;
            lbl4.Top += 1;
            lbl5.Top += 1;
            lbl6.Top += 1;
            lbl7.Top += 1;
            if (lblTest.Bounds.IntersectsWith(lbl1.Bounds)) { MessageBox.Show("Game Over"); Reset();  }
            if (lblTest.Bounds.IntersectsWith(lbl2.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lbl3.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lbl4.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lbl5.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lbl6.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lbl7.Bounds)) { MessageBox.Show("Game Over"); Reset(); }
            if (lblTest.Bounds.IntersectsWith(lblEnd.Bounds)) { MessageBox.Show("Level 1 Pass"); } 
            //Nothing
            try { int m = Int32.Parse(indata); if (m >= 379364 && m <= 383269) { lblTest.Text = "Null"; } }   catch { }
            //Left
            try { int m = Int32.Parse(indata); if (m >= 0363 && m <= 0366) { lblTest.Text = "Left"; lblTest.Left -= 10; } }
            catch { }
            //Right
            try { int m = Int32.Parse(indata); if (m >= 400000 && m <= 735367) { lblTest.Text = "Right"; lblTest.Left += 10; } }
            catch { }
            //Up
            try { int m = Int32.Parse(indata); if (m >= 3790 && m <= 3832) { lblTest.Text = "Up"; lblTest.Top -= 5; } }
            catch { }
          //Downj    try { double  m = Convert.ToDouble(indata); if (m >= 379730 && m <= 382735) { lblTest.Text = "Down"; lblTest.Top += 1; } }catch { }
           
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
   
        }
        public void Reset()
        {
            Application.Exit();
        }
    }
}
