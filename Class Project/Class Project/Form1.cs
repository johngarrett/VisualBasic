using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Class_Project
{
     public partial class Form1 : Form
    {
    class Student
    {
        private string firstName;
        private string lastName;
        private string id;
        private double gpa;
        private string stuClass;

        public Student()
        {
            firstName = " "; 
            lastName = " ";
            id = " ";
            gpa = 0;
            stuClass = " ";
        }
        public Student(string fn, string ln, string ID, double GPA, string sClass)
        {
            firstName = fn;
            lastName = ln;
            id = ID;
            gpa = GPA;
            stuClass = sClass;
        }
        public Student(string ID)
        {  id = ID;  }
        public string toString()
        {
            return "Student Name: \r\n" + firstName + " " + lastName + "\r\nID:\t " + " " + id + "\r\ngpa:\t " + gpa + "\r\nClass:\t " + stuClass;
        }
    }
    struct Schedule
    {
        private string block1; private string block2; private string block3; private string block4;
        public Schedule(string bl1, string bl2, string bl3, string bl4)
        {
            block1 = bl1;
            block2 = bl2;
            block3 = bl3;
            block4 = bl4;
        }
        public string toString()
        {
            return "Block 1:\t" + block1 + "\r\nBlock 2\t " + block2 + "\r\nBlock3: \t " + block3 + "\r\nBlock4: \t " + block4 ;
        }
    }
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        Student stu1 = new Student("John", "Garrett", "9394216", 4.25, "Sophomore");
            label1.Text = stu1.toString();
            Schedule stu1Schedule = new Schedule("AP Psych", "Math 3 Honors", "Art 1", "Computer Prog 2 Honors");
            label2.Text = stu1Schedule.toString ();
 
        }

    }

}
