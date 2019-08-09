using System; using System.Collections.Generic; using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Windows.Forms;
namespace Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

         private void button1_Click(object sender, EventArgs e)
         {
             student stu1 = new student();
             try
             {stu1.name = txtName.Text;
                 stu1.GPA = Convert.ToDouble(txtGPA.Text);
                 label1.Text += "Student Name: " + stu1.name + "\nStudent GPA: " + stu1.GPA.ToString() + "\r\n";
         }
             catch (ArgumentException)
             { MessageBox.Show("Enter a GPA that is greater than 0 and less than 4"); }
             catch (FormatException)
             { MessageBox.Show("You entered a string, please type in arabic numbers"); }
         }
    }
}
