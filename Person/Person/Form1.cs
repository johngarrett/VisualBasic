using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Age = 15;
            person.Name = "John";
            lblAge.Text += person.Age.ToString ();
            lblName.Text += person.Name;



         
        }
  
        class Person {
            private string myName = "N/A";
            private int myAge = 0;
            public string Name
            {
                get
                {
                    return myName;
                }
                set
                {
                    myName = value;
                }
            }
                public int Age
                {
                    get{
                        return myAge;

                    }
                    set
                    {
                        myAge = value;
                    }

                }
        
            }
        }

    }

