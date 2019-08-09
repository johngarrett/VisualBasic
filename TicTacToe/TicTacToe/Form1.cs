using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {

        public TicTacToe()
        {
            InitializeComponent();
        }

        int intCounter = 0;
        public void button_Click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
        
            btnClicked.Enabled = false;
            btnClicked.Text = lblCurrentPlayer.Text;
            intCounter++;
            if (intCounter == 1)
                lblCurrentPlayer.Text = "X";
            else if (intCounter == 2)
                lblCurrentPlayer.Text = "O";
            else if (intCounter == 3)
                lblCurrentPlayer.Text = "X";
            else if (intCounter == 4)
                lblCurrentPlayer.Text = "O";
            else if (intCounter == 5)
                lblCurrentPlayer.Text = "X";
            else if (intCounter == 6)
                lblCurrentPlayer.Text = "O";
            else if (intCounter == 7)
                lblCurrentPlayer.Text = "X";
            else if (intCounter == 8)
                lblCurrentPlayer.Text = "X";
            else if (intCounter == 9)
                lblCurrentPlayer.Text = "O";
        }
        
        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }
        public void WinnerCheck()
        {
            if ( btn2.Text = btn1.Text && btn3.Text == btn2.Text)

        }

    }
}
      


