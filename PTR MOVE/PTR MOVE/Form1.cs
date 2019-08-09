using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using Input = Microsoft.Xna.Framework.Input; // to provide shorthand to clear up ambiguities

namespace PTR_MOVE
{
    public partial class Form1 : Form
    {

        //To keep track of the current and previous state of the gamepad
        /// <summary>
        /// The current state of the controller
        /// </summary>
        GamePadState gamePadState;
        /// <summary>
        /// The previous state of the controller
        /// </summary>
        GamePadState previousState;

        /// <summary>
        /// Keeps track of the current controller
        /// </summary>
        PlayerIndex playerIndex = PlayerIndex.One;

        /// <summary>
        /// Counter for limiting the time for which the vibration motors are on.
        /// </summary>
        int vibrationCountdown = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
           
        }


        private void UpdateControllerState()
        {
            //Get the new gamepad state and save the old state.
            this.previousState = this.gamePadState;
            this.gamePadState = GamePad.GetState(PlayerIndex.One);
            //If the controller is not connected, let the user know
           
            //I personally prefer to only update the buttons if their state has been changed. 
            if (!this.gamePadState.Buttons.Equals(this.previousState.Buttons))
            {
                if (gamePadState.Buttons.A == Input.ButtonState.Pressed)
                    label1.Top += 1;
                if (gamePadState.Buttons.B == Input.ButtonState.Pressed)
                    label1.Left += 1;
                if(gamePadState.Buttons.X == Input.ButtonState.Pressed)
                    label1.Left -= 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.UpdateControllerState();z
        }


    }
}
