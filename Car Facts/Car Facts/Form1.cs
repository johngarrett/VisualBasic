using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Facts
{
    public partial class carFacts : Form
    {
        public carFacts()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            carInfo carinfo = new carInfo();
            carinfo.Cost = 27450;
            carinfo.Damage = "No";
            carinfo.Mileage = 67000;
            carinfo.wDamage = "No";
            carinfo.Owners = 1;
           label6.Text = Convert.ToString(carinfo.Cost) ;
           label7.Text = carinfo.Damage;
           label8.Text = Convert.ToString(carinfo.Mileage ) ;
           label9.Text = Convert.ToString(carinfo.wDamage) ;
           label10.Text = Convert.ToString(carinfo.Owners);


        }
    }
 
}
