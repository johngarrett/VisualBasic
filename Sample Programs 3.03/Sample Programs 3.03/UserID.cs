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
                public partial class UserID : Form
                {
                    public UserID()
                    {
                        InitializeComponent();
                    }
                    public int date; public int month; public double year; public int error = 0; public double ID; public string ID1;
                    private void button1_Click(object sender, EventArgs e)
                    {
                        try { date = Convert.ToInt32(cmbDate.Text); }

                        catch { MessageBox.Show("Please Enter a Date"); error = 1; }
                        if (cmbMonth.Text == "January")
                         month = 01;
                        if (cmbMonth.Text == "February")
                            month = 02;
                        if (cmbMonth.Text == "March")
                            month = 03;
                        if (cmbMonth.Text == "April")
                            month = 04;
                        if (cmbMonth.Text == "May")
                            month = 05;
                        if (cmbMonth.Text == "June")
                            month = 06;
                        if (cmbMonth.Text == "July")
                            month = 07;
                        if (cmbMonth.Text == "August")
                            month = 08;
                        if (cmbMonth.Text == "September")
                            month = 09;
                        if (cmbMonth.Text == "October")
                            month = 10;
                        if (cmbMonth.Text == "November")
                            month = 11;
                        if (cmbMonth.Text == "December")
                            month = 12;
                        if (month == 0)
           
            
                        {error = 1; MessageBox.Show("Please enter a month"); }

                        try { year = Convert.ToInt32(cmbYear.Text); }
                        catch { MessageBox.Show("Please enter a valid Year"); error = 1; }
  
                        ID  = Math.Round(year / 27);
                        ID1 = date.ToString() + month.ToString() + ID.ToString();
        
                        if (error == 0)
                        {MessageBox.Show("Your ID is" + "\n" + date.ToString() + month.ToString() + ID.ToString());
                            Form1 form = new Form1(ID1 );
                            form.Show();
                            this.Hide();
                        }
                    }
                }

            }
