using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string player1, player2, gamesTemp;
            int games = 0;
            player1 = txtPlayer1.Text; player2 = txtPlayer2.Text; gamesTemp = txtGames.Text;
            try
            {
                games = Convert.ToInt32(gamesTemp);
            }
            catch { MessageBox.Show("ErrpR"); }
            Form tttgame = new Form1(player1 , player2, games );
            tttgame.Show();
            this.Hide();

        }
    }
}
