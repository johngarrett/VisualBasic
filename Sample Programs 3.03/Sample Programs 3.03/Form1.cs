using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample_Programs_3._03
{
    public partial class Form1 : Form
    {
        public Form1(string PersonsName)
  
        { InitializeComponent(); }

        private double shipWeightCalc()
        {
            double shipWeight = 0;
            try
            {
                shipWeight = Convert.ToDouble(txtWeight.Text);
                return shipWeight;
            }
            catch
            {
                MessageBox.Show("Enter a valid weight.");
                return 0;
            }
        }

        private double getShipCost(double shipWeight)
        {

            const double baseRATE = 6.7;
            double rate;

            if (shipWeight > 1)
                rate = (shipWeight * 0.49) + baseRATE;
            else
                rate = baseRATE;
            if (radNext.Checked)
                rate += 80;
            else if (radSecond.Checked)
                rate += 50;
            else if (rad3rd.Checked)
                rate += 30;
            return rate;
        }
        private double getInsuranceRate()
        {
            double insuranceCost = 0;
            double value = 0;

            if (chkInsurance.Checked)
            {
                try
                { value = Convert.ToDouble(txtValue.Text); }
                catch
                { MessageBox.Show("Insurance value must be a number"); }
                insuranceCost = Convert.ToInt32(value / 100) * 1.56;
            }
            return insuranceCost;
        }

        private void chkInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInsurance.Checked)
            { lblValue.Visible = true; txtValue.Visible = true; }
            else
            { lblValue.Visible = false; txtValue.Visible = false; }
        }

        private void radNext_CheckedChanged(object sender, EventArgs e)
        {
            if (radNext.Checked)
                chkRush.Enabled = true;
            else
            { chkRush.Enabled = false; chkRush.Checked = false; }
        }
        private double getOptionsCost()
        {
            double optionsCost = 0;
            if (chkSaturday.Checked)
                optionsCost += 35;
            if (chkRush.Checked)
                optionsCost += 30;
            return optionsCost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shipping Rates:" + "\n" + "Base Rate: 6.70" + "\n" + "Each Additional Pound: .49" + "\n" +
                "Upgrades:" + "\n\n" + "Next Day: $80, Second Day: $50, 3rd Day: $30" + "\n" + "Options" + "\n" +
                "Rush AM: $30, Saturday Delivery- $35" + "\n" + "Insurance: $1.56 per $100 of value");
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            AboutForm AboutForm = new AboutForm();
            AboutForm.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double shipWeight = shipWeightCalc();
            double shipCost = getShipCost(shipWeight);
            double insuranceCost = getInsuranceRate();
            double optionsCost = getOptionsCost();

            double fuelSurcharge = (shipCost * 0.0267) + 1.50;
            double total = shipCost + optionsCost + insuranceCost + fuelSurcharge;

            MessageBox.Show("Shipping Rate:" + "\n" + "Shipping Cost:" + shipCost.ToString("$##.00") + "\n" + "Options:" +
                optionsCost.ToString("$##.00") + "\n" + "Insurance: " + insuranceCost.ToString("$##.00")
              + "\n" + "Fuel Surcharge: " + fuelSurcharge.ToString("$##.00") + "\n" + "Total: " + total.ToString("$##.00"));
        }

        private void button2_Click(object sender, EventArgs e)
        { Application.Exit(); }

        public  void Form1_Load(object sender, EventArgs e)
        {
            
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            
        }        

    }
}
