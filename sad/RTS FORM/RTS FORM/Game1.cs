using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace RTS_FORM
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        GraphicsDeviceManager graphics;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            // Allow the game to exit.
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back ==
                ButtonState.Pressed)
                this.Exit();

            UpdateInput();

            base.Update(gameTime);
        }

        float vibrationAmount = 0.0f;

        void UpdateInput()
        {
            // Get the current gamepad state.
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            // Process input only if connected and button A is pressed.
            if (currentState.IsConnected && currentState.Buttons.A ==
                ButtonState.Pressed)
            {
                // Button A is currently being pressed; add vibration.
                vibrationAmount =
                    MathHelper.Clamp(vibrationAmount + 0.03f, 0.0f, 1.0f);
                GamePad.SetVibration(PlayerIndex.One,
                    vibrationAmount, vibrationAmount);
            }
            else
            {
                // Button A is not being pressed; subtract some vibration.
                vibrationAmount =
                    MathHelper.Clamp(vibrationAmount - 0.05f, 0.0f, 1.0f);
                GamePad.SetVibration(PlayerIndex.One,
                    vibrationAmount, vibrationAmount);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }

    }
}
