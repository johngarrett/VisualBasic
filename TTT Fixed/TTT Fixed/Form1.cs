using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
namespace TTT_Fixed
{
    public partial class Form1 : Form
    {
        Random rdnPlayer = new Random();
        string player1 = string.Empty; string player2 = string.Empty; int games = 0;
        int xWins = 0; int oWins = 0; int gameCounter = 0;
        public Form1(string player1, string player2, int games)
        {
            InitializeComponent();
            this.player1 = player1; this.player2 = player2; this.games = games;
        }
        int intMoves = 1;
        public void button_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }
        public void WinnerCheck()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
            }
            if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
                if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
                {
                    MessageBox.Show("Player " + lblCurrentPlayer.Text + " does not Win");
                    if (lblCurrentPlayer.Text == player1) { oWins++; GameManage(xWins, oWins); } else { xWins++; GameManage(xWins, oWins); };
                }
                else if (intMoves > 9)
                {
                    MessageBox.Show("Tie");
                    clear();
                }
            }
        }
        private void clear()
        {
            btn1.Enabled = true; btn2.Enabled = true; btn3.Enabled = true;
            btn4.Enabled = true; btn5.Enabled = true; btn6.Enabled = true;
            btn7.Enabled = true; btn8.Enabled = true; btn9.Enabled = true;
            btn1.Text = "1"; btn2.Text = "2"; btn3.Text = "3";
            btn4.Text = "4"; btn5.Text = "5"; btn6.Text = "6";
            btn7.Text = "7"; btn8.Text = "8"; btn9.Text = "9";
            btn1.ForeColor = System.Drawing.Color.Black; btn4.ForeColor = System.Drawing.Color.Black; btn7.ForeColor = System.Drawing.Color.Black;
            btn2.ForeColor = System.Drawing.Color.Black; btn5.ForeColor = System.Drawing.Color.Black; btn8.ForeColor = System.Drawing.Color.Black;
            btn3.ForeColor = System.Drawing.Color.Black; btn6.ForeColor = System.Drawing.Color.Black; btn9.ForeColor = System.Drawing.Color.Black;
            btn1.BackgroundImage = null; btn2.BackgroundImage = null; btn3.BackgroundImage = null; btn4.BackgroundImage = null; btn5.BackgroundImage = null;
            btn6.BackgroundImage = null; btn7.BackgroundImage = null; btn8.BackgroundImage = null; btn9.BackgroundImage = null;
        }
        private void Form1_Load(object sender, EventArgs f)
        {
            int player = rdnPlayer.Next(0, 2);
            if (player == 0)
            {
                lblCurrentPlayer.Text = player1;
            }
            else if (player == 1)
            { lblCurrentPlayer.Text = player2; }
        }

 
        private void GameManage(int xWins, int oWins)
        {
            gameCounter++;
            lblXwins.Text = xWins.ToString();
            lblOwins.Text = oWins.ToString();
            if (gameCounter == games)
            {
                if (xWins > oWins)
                {
                    MessageBox.Show(player1 + "has won the match " + xWins.ToString() + " games to " + oWins.ToString() + " .");

                }
                else if (oWins > xWins)
                {
                    MessageBox.Show(player2 + "has won the match " + oWins.ToString() + " games to " + xWins.ToString() + " .");

                }
                else if (xWins == oWins)
                {
                    MessageBox.Show("this game is a drawl, each player won " + xWins.ToString() + " times");
                }
                lblXwins.Text = "0"; lblOwins.Text = "0";
                Form form2 = new Form2(); form2.Show(); this.Hide();


            }
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            end();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            end();
        }
        private void end()
        { clear(); xWins = 0; oWins = 0; lblOwins.Text = "0"; lblXwins.Text = "0"; }

        private void btn1_Click(object sender, EventArgs e)
        {
             intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            intMoves++;
            Button button = (Button)sender;
            button.Enabled = false;
            if (lblCurrentPlayer.Text == player1)
                button.Text = player1;
            else
                button.Text = player2;
            if (lblCurrentPlayer.Text == player2)
                lblCurrentPlayer.Text = player1;
            else
                lblCurrentPlayer.Text = player2;
            WinnerCheck();
            if (button.Text == player1)
                button.ForeColor = System.Drawing.Color.Red;
            else if (button.Text == player2)
                button.ForeColor = System.Drawing.Color.Blue;
        }

    }
}
