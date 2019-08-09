using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management; 


namespace CPU_Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementClass processClass = new ManagementClass(@"root\WMI:MSAcpi_ThermalZoneTemperature");

            foreach (ManagementObject service in processClass.GetInstances())
            {

                MessageBox.Show("CPU Temperature: " + service.GetPropertyValue("CurrentTemperature"));

            }
        }
    }
}
