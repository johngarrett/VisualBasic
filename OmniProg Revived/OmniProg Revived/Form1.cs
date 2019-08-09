using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
namespace OmniProg_Revived
{
    public partial class OmniProg : Form
    {
        public int flash = 0;
        public OmniProg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { AboutBox1 abt = new AboutBox1(); abt.Show(); }

        private void btn5_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0"); var psi = new
            ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true; psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
timer.Interval =75; timer.Enabled = false; timer.Start();
int messagesNum = 1;int oldMessagesNum = 0;

if( messagesNum > oldMessagesNum)
  timer.Tick += new EventHandler( timer_Tick );
else
  timer.Tick -= timer_Tick; }
       public  void timer_Tick(object sender, EventArgs e)
        {
       

            if (this.BackColor == Color.Yellow)
                this.BackColor = Color.Red;
           
            else
                this.BackColor = Color.Yellow;
           
        }
    
    }
}
