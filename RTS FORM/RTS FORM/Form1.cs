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
using Input = Microsoft.Xna.Framework.Input; // to provide shorthand to clear u
using System.Media;
namespace RTS_FORM
{


    public partial class Form1 : Form
    {

        GamePadState gamePadState; GamePadState previousState; PlayerIndex playerIndex = PlayerIndex.One;

        public int blue = 200; public int blue2 = 200; public int blue3 = 200; public int blue4 = 200; public int red1 = 200; public int red2 = 200; public int red3 = 200; public int red4 = 200;
       
        public bool boolB1 = true; public bool boolB2 = false; public bool boolB3 = false; public bool boolB4 = false;
        public bool boolB1A = true; public bool boolB2A = true ; public bool boolB3A = true ; public bool boolB4A = true ;

        public bool boolR1 = true; public bool boolR2 = false; public bool boolR3 = false; public bool boolR4 = false;
        public bool boolR1A = true; public bool boolR2A = true ; public bool boolR3A = true ; public bool boolR4A = true ;

        public int RedTanksMade = 1, BlueTanksMade = 1;

        public int[,] intArray = new int[20, 20] { { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 } };
        public int intRedTank = 1; public int intBlueTank = 1; public int intTime = 0; 

        public int intRedProgress = 0, intBlueProgress = 0;
        public int BlueAmount = 1, RedAmount = 1;
        static void Display(int[,] grid) { }
        public Form1()
        {InitializeComponent();  }

//Select Tanks Manually
        //Select Red Tanks
        private void label5_Click(object sender, EventArgs e) { btnRedTank1.Enabled = true; btnRedTank2.Enabled = true; btnRedTank3.Enabled = true; btnRedTank4.Enabled = true; btnRedDone.Enabled = true; }
        private void btnRedDone_Click(object sender, EventArgs e) { btnRedTank1.Enabled = false; btnRedTank2.Enabled = false; btnRedTank3.Enabled = false; btnRedTank4.Enabled = false; btnRedDone.Enabled = false; }
        //Select Blue Tanks
        private void lblControl2_Click(object sender, EventArgs e) { btnBlueTank1.Enabled = true; btnBlueTank2.Enabled = true; btnBlueTank3.Enabled = true; btnBlueTank4.Enabled = true; btnBlueDone.Enabled = true; }
        private void btnBlueDone_Click(object sender, EventArgs e) { btnBlueTank1.Enabled = false; btnBlueTank2.Enabled = false; btnBlueTank3.Enabled = false; btnBlueTank4.Enabled = false; btnBlueDone.Enabled = false; }

//Blue Shoot
        //Blue Tank 1 Shoot
        private void tmrBlue1Up_Tick(object sender, EventArgs e) { ptrBlueShoot1.Top -= 35; }
        private void tmrBlue1Down_Tick(object sender, EventArgs e) { ptrBlueShoot1.Top += 35; }
        private void tmrBlue1Right_Tick(object sender, EventArgs e) { ptrBlueShoot1.Left += 35; }
        private void tmrBlue1Left_Tick(object sender, EventArgs e) { ptrBlueShoot1.Left -= 35; }
       //Blue Tank 2 Shoot
        private void timer2_Tick(object sender, EventArgs e) { ptrRedShoot1.Top -= 35; }
        private void tmrRed1Left_Tick(object sender, EventArgs e) { ptrRedShoot1.Left -= 35; }
        private void tmrRed1Right_Tick(object sender, EventArgs e) { ptrRedShoot1.Left += 35; }
        private void tmrRed1Down_Tick(object sender, EventArgs e) { ptrRedShoot1.Top += 35; }

//Timer Start
        private void tmrTime_Tick(object sender, EventArgs e) { intTime++; lblTime.Text = intTime.ToString() + " seconds have elapsed"; }
        private void Form1_Load(object sender, EventArgs e) { SoundPlayer soundtrack = new SoundPlayer(@"C:\VS OVERFLOW\soundtrack.wav"); soundtrack.PlayLooping(); tmrTime.Start(); tmrCompute.Start(); tmrBlue1Shoot.Start(); tmrRedShoot1.Start(); tmrBuild.Start(); tmrBlueMove.Start(); tmrRedMove.Start(); }

//Collision 
        private void tmrCollideCheck_Tick(object sender, EventArgs e)
        {
            SoundPlayer boom = new SoundPlayer(@"C:\VS OVERFLOW\boom.wav");
// Red Tank Gets Shot
      //Tank 1
            if (ptrBlueShoot1.Bounds.IntersectsWith(ptrRed1.Bounds))
            { try { ptrRed1.BackColor = System.Drawing.Color.FromArgb(red1, 0, 0); red1 -= 25; }
                catch{
                    if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
                    ptrBlueShoot1.Visible = false; lblConsole.Text = "Console: Red Tank Died"; ptrRed1.Visible = false; boolR1 = false; boolR1A = false; boom.Play();
                }
            }
        //Tank 2
            if (ptrBlueShoot1.Bounds.IntersectsWith(ptrRed2.Bounds))
            {try { ptrRed2.BackColor = System.Drawing.Color.FromArgb(red2, 0, 0); red2 -= 25; }
                catch {
                    if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
                    ptrBlueShoot1.Visible = false; lblConsole.Text = "Console: Red Tank got shot"; ptrRed2.Visible = false; boolR2A = false; boolR2 = false; boom.Play();
                }
            }
       //Tank 3
            if (ptrBlueShoot1.Bounds.IntersectsWith(ptrRed3.Bounds))
            { try { ptrRed3.BackColor = System.Drawing.Color.FromArgb(red3, 0, 0); red3 -= 25; }
                catch
                { if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
                ptrBlueShoot1.Visible = false; lblConsole.Text = "Console: Red Tank got shot"; ptrRed3.Visible = false; boolR3 = false; boolR3A = false; boom.Play();
                }
            }
       //Tank 4
            if (ptrBlueShoot1.Bounds.IntersectsWith(ptrRed4.Bounds))
            { try { ptrRed4.BackColor = System.Drawing.Color.FromArgb(red4, 0, 0); red4 -= 25; }
                catch{
                    if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
                    ptrBlueShoot1.Visible = false; lblConsole.Text = "Console: Red Tank got shot"; ptrRed4.Visible = false; boolR4 = false; boolR4A = false; boom.Play();
                }
            }

//Blue Tank Gets Shot
        //Tank 1
            if (ptrRedShoot1.Bounds.IntersectsWith(ptrBlue1.Bounds))
            { ptrRedShoot1.Visible = false;
                try { ptrBlue1.BackColor = System.Drawing.Color.FromArgb(0, 0, blue); blue -= 25; }
                catch { boom.Play(); ptrBlue1.Enabled = false; boolB1A = false; boolB1 = false; ptrBlue1.Visible = false; lblConsole.Text = "Console: Blue Tank Died"; if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4)  BlueAmount = 3; }
            }
        //Tank 2
            if (ptrRedShoot1.Bounds.IntersectsWith(ptrBlue2.Bounds))
            {   ptrRedShoot1.Visible = false;
                try { ptrBlue2.BackColor = System.Drawing.Color.FromArgb(0, 0, blue2); blue2 -= 25; }
                catch { boom.Play(); ptrBlue2.Enabled = false; boolB2 = false; boolB2A = false; ptrBlue2.Visible = false; lblConsole.Text = "Console: Blue Tank Died"; if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4)  BlueAmount = 3; }
            }
        //Tank 3
            if (ptrRedShoot1.Bounds.IntersectsWith(ptrBlue3.Bounds))
            {   ptrRedShoot1.Visible = false;
                try { ptrBlue3.BackColor = System.Drawing.Color.FromArgb(0, 0, blue3); blue3 -= 25; }
                catch { boom.Play(); ptrBlue3.Enabled = false; boolB3 = false; boolB3A = false; ptrBlue3.Visible = false; lblConsole.Text = "Console: Blue Tank Died"; if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4)  BlueAmount = 3; }
            }
        //Tank 4
            if (ptrRedShoot1.Bounds.IntersectsWith(ptrBlue4.Bounds))
            {   ptrRedShoot1.Visible = false;
                try { ptrBlue4.BackColor = System.Drawing.Color.FromArgb(0, 0, blue4); blue4 -= 25; }
                catch { boom.Play(); ptrBlue4.Enabled = false; boolB4 = false; boolB4A = false; ptrBlue4.Visible = false; lblConsole.Text = "Console: Blue Tank Died"; if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4)  BlueAmount = 3; }
            }
 }

//Select Tanks With Buttons
        //Select Red Tank
        private void btnRedTank1_Click(object sender, EventArgs e) { if (boolR1 == true) { intRedTank = 1; ptrRed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }}
        private void btnRedTank2_Click(object sender, EventArgs e) { if (boolR2 == true) { intRedTank = 2; ptrRed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }}
        private void btnRedTank3_Click(object sender, EventArgs e) { if (boolR3 == true) { intRedTank = 3; ptrRed3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }}
        private void btnRedTank4_Click(object sender, EventArgs e) { if (boolR4 == true) { intRedTank = 4; ptrRed4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }}
        //Select Blue Tank
        private void btnBlueTank1_Click(object sender, EventArgs e) { if (boolB1 == true) {intBlueTank = 1; ptrBlue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;}}
        private void btnBlueTank2_Click(object sender, EventArgs e) { if (boolB2 == true) {intBlueTank = 2; ptrBlue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;}}
        private void btnBlueTank3_Click(object sender, EventArgs e) { if (boolB3 == true) {intBlueTank = 3; ptrBlue3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;}}
        private void btnBlueTank4_Click(object sender, EventArgs e) { if (boolB4 == true) { intBlueTank = 4; ptrBlue4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;}}

//Red Move (Controller 1)
        private void tmrRedMove_Tick(object sender, EventArgs e)
        {GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
            tmrCollideCheck.Start();
            Display(intArray);
            if (RedAmount < 0) RedAmount = 0;
            if (BlueAmount < 0) BlueAmount = 0;
       
//Red Tank 1
            if (intRedTank == 1 & boolR1 == true)
            {
                int redx1 = ptrRed1.Location.X; int redy1 = ptrRed1.Location.Y;
                if (Controller1.DPad.Right == Input.ButtonState.Pressed) redx1 += 35;
                else if (Controller1.DPad.Left == Input.ButtonState.Pressed) redx1 -= 35;
                else if (Controller1.DPad.Up == Input.ButtonState.Pressed) redy1 -= 35;
                else if (Controller1.DPad.Down == Input.ButtonState.Pressed) redy1 += 35;
                ptrRed1.Location = new System.Drawing.Point(redx1, redy1);

            }
     //Red Tank 2
            if (intRedTank == 2 & boolR2 == true)
            { int redx2 = ptrRed2.Location.X; int redy2 = ptrRed2.Location.Y;
                if (Controller1.DPad.Right == Input.ButtonState.Pressed) redx2 += 35;
                else if (Controller1.DPad.Left == Input.ButtonState.Pressed) redx2 -= 35;
                else if (Controller1.DPad.Up == Input.ButtonState.Pressed) redy2 -= 35;
                else if (Controller1.DPad.Down == Input.ButtonState.Pressed) redy2 += 35;
                ptrRed2.Location = new System.Drawing.Point(redx2, redy2);}
//Red Tank 3
            if (intRedTank == 3 & boolR3 == true)
            {
             int redx3 = ptrRed3.Location.X; int redy3 = ptrRed3.Location.Y;
                if (Controller1.DPad.Right == Input.ButtonState.Pressed) redx3 += 35;
                else if (Controller1.DPad.Left == Input.ButtonState.Pressed) redx3 -= 35;
                else if (Controller1.DPad.Up == Input.ButtonState.Pressed) redy3 -= 35;
                else if (Controller1.DPad.Down == Input.ButtonState.Pressed) redy3 += 35;
                ptrRed3.Location = new System.Drawing.Point(redx3, redy3); }
      //Red Tank 4
            if (intRedTank == 4 & boolR4 == true)
            {
                int redx4 = ptrRed4.Location.X; int redy4 = ptrRed4.Location.Y;
                if (Controller1.DPad.Right == Input.ButtonState.Pressed) redx4 += 35;
                else if (Controller1.DPad.Left == Input.ButtonState.Pressed) redx4 -= 35;
                else if (Controller1.DPad.Up == Input.ButtonState.Pressed) redy4 -= 35;
                else if (Controller1.DPad.Down == Input.ButtonState.Pressed) redy4 += 35;
                ptrRed4.Location = new System.Drawing.Point(redx4, redy4);
            }
  //Red Tank 1 Intersecting...
            //Right Wall
            if (ptrRed1.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrRed1.Left -= 35;
            //Left Wall
            if (ptrRed1.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrRed1.Left += 35;
            //Bottom
            if (ptrRed1.Bounds.IntersectsWith(lblDown.Bounds))
                ptrRed1.Top -= 35;
            //Top
            if (ptrRed1.Bounds.IntersectsWith(lblTop.Bounds))
                ptrRed1.Top += 35;
            //Water
            if (ptrRed1.Bounds.IntersectsWith(Water1.Bounds) || ptrRed1.Bounds.IntersectsWith(Water2.Bounds) || ptrRed1.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrRed1.Enabled = false; ptrRed1.Visible = false;
                lblConsole.Text = "Console: Red Tank Drown"; boolR1 = false; boolR1A = false;
                if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
            }
       //Red Tank 2 Intersecting...
            //Right Wall
            if (ptrRed2.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrRed2.Left -= 35;
            //Left Wall
            if (ptrRed2.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrRed2.Left += 35;
            //Bottom
            if (ptrRed2.Bounds.IntersectsWith(lblDown.Bounds))
                ptrRed2.Top -= 35;
            //Top
            if (ptrRed2.Bounds.IntersectsWith(lblTop.Bounds))
                ptrRed2.Top += 35;
            //Water
            if (ptrRed2.Bounds.IntersectsWith(Water1.Bounds) || ptrRed2.Bounds.IntersectsWith(Water2.Bounds) || ptrRed2.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrRed2.Enabled = false; ptrRed2.Visible = false;
                lblConsole.Text = "Console: Red Tank Drown"; boolR2 = false; boolR2A = false;
                if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
            }
        //Red Tank 3
            //Right Wall
            if (ptrRed3.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrRed3.Left -= 35;
            //Left Wall
            if (ptrRed3.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrRed3.Left += 35;
            //Bottom
            if (ptrRed3.Bounds.IntersectsWith(lblDown.Bounds))
                ptrRed3.Top -= 35;
            //Top
            if (ptrRed3.Bounds.IntersectsWith(lblTop.Bounds))
                ptrRed3.Top += 35;
            //Water
            if (ptrRed3.Bounds.IntersectsWith(Water1.Bounds) || ptrRed3.Bounds.IntersectsWith(Water2.Bounds) || ptrRed3.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrRed3.Enabled = false; ptrRed3.Visible = false;
                lblConsole.Text = "Console: Red Tank Drown"; boolR3 = false; boolR3A = false;
                if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
            }
       //Red Tank 4
            //Right Wall
            if (ptrRed4.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrRed4.Left -= 35;
            //Left Wall
            if (ptrRed4.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrRed4.Left += 35;
            //Bottom
            if (ptrRed4.Bounds.IntersectsWith(lblDown.Bounds))
                ptrRed4.Top -= 35;
            //Top
            if (ptrRed4.Bounds.IntersectsWith(lblTop.Bounds))
                ptrRed4.Top += 35;
            //Water
            if (ptrRed4.Bounds.IntersectsWith(Water1.Bounds) || ptrRed4.Bounds.IntersectsWith(Water2.Bounds) || ptrRed4.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrRed4.Enabled = false; ptrRed3.Visible = false;
                lblConsole.Text = "Console: Red Tank Drown"; boolR4 = false; boolR4A = false;
                if (RedAmount == 1) RedAmount = 0; if (RedAmount == 2) RedAmount = 1; if (RedAmount == 3) RedAmount = 2; if (RedAmount == 4) RedAmount = 3;
            }

        }
 //Move BLUE
        private void timer11_Tick(object sender, EventArgs e)
        {
           
            GamePadState Controller2 = GamePad.GetState(PlayerIndex.Two);
                  tmrCollideCheck.Start();
            Display(intArray);
            if (RedAmount < 0) RedAmount = 0;
            if (BlueAmount < 0) BlueAmount = 0;
         
            this.previousState = this.gamePadState;
          
            //Blue Tank 1
            if (intBlueTank == 1 & boolB1 == true)
            {
                int bluex1 = ptrBlue1.Location.X; int bluey1 = ptrBlue1.Location.Y;

                if (Controller2.DPad.Right == Input.ButtonState.Pressed) bluex1  += 35;
                else if (Controller2.DPad.Left == Input.ButtonState.Pressed) bluex1 -= 35;
                else if (Controller2.DPad.Up == Input.ButtonState.Pressed) bluey1 -= 35;
                else if (Controller2.DPad.Down == Input.ButtonState.Pressed) bluey1 += 35;
               
                ptrBlue1.Location = new System.Drawing.Point(bluex1 , bluey1 );
            }
            //Blue Tank 2
            if (intBlueTank == 2 & boolB2 == true)
            {
                int bluex2 = ptrBlue2.Location.X; int bluey2 = ptrBlue2.Location.Y;

                if (Controller2.DPad.Right == Input.ButtonState.Pressed) bluex2 += 35;
                else if (Controller2.DPad.Left == Input.ButtonState.Pressed) bluex2 -= 35;
                else if (Controller2.DPad.Up == Input.ButtonState.Pressed) bluey2 -= 35;
                else if (Controller2.DPad.Down == Input.ButtonState.Pressed) bluey2 += 35;

                ptrBlue2.Location = new System.Drawing.Point(bluex2, bluey2);
            }
            //Blue Tank 3
            if (intBlueTank == 3 & boolB3 == true)
            {
                int bluex3 = ptrBlue3.Location.X; int bluey3 = ptrBlue3.Location.Y;

                if (Controller2.DPad.Right == Input.ButtonState.Pressed) bluex3 += 35;
                else if (Controller2.DPad.Left == Input.ButtonState.Pressed) bluex3 -= 35;
                else if (Controller2.DPad.Up == Input.ButtonState.Pressed) bluey3 -= 35;
                else if (Controller2.DPad.Down == Input.ButtonState.Pressed) bluey3 += 35;

                ptrBlue3.Location = new System.Drawing.Point(bluex3, bluey3);
            }
            //Blue Tank 4
            if (intBlueTank == 4 & boolB4 == true)
            {
                int bluex4 = ptrBlue4.Location.X; int bluey4 = ptrBlue4.Location.Y;

                if (Controller2.DPad.Right == Input.ButtonState.Pressed) bluex4 += 35;
                else if (Controller2.DPad.Left == Input.ButtonState.Pressed) bluex4 -= 35;
                else if (Controller2.DPad.Up == Input.ButtonState.Pressed) bluey4 -= 35;
                else if (Controller2.DPad.Down == Input.ButtonState.Pressed) bluey4 += 35;
                ptrBlue4.Location = new System.Drawing.Point(bluex4, bluey4);
            }
        //Blue Tank 1
            //Right Wall
            if (ptrBlue1.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrBlue1.Left -= 35;
            //Left Wall
            if (ptrBlue1.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrBlue1.Left += 35;
            //Bottom
            if (ptrBlue1.Bounds.IntersectsWith(lblDown.Bounds))
                ptrBlue1.Top -= 35;
            //Top
            if (ptrBlue1.Bounds.IntersectsWith(lblTop.Bounds))
                ptrBlue1.Top += 35;
            //Water
            if (ptrBlue1.Bounds.IntersectsWith(Water1.Bounds) || ptrBlue1.Bounds.IntersectsWith(Water2.Bounds) || ptrBlue1.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrBlue1.Enabled = false; ptrBlue1.Visible = false;
                lblConsole.Text = "Console: Blue Tank Drown"; boolB1 = false; boolB1A = false;
                if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4) { BlueAmount = 3; }
            }
        //Blue Tank 2
            //Right Wall
            if (ptrBlue2.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrBlue2.Left -= 35;
            //Left Wall
            if (ptrBlue2.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrBlue2.Left += 35;
            //Bottom
            if (ptrBlue2.Bounds.IntersectsWith(lblDown.Bounds))
                ptrBlue2.Top -= 35;
            //Top
            if (ptrBlue2.Bounds.IntersectsWith(lblTop.Bounds))
                ptrBlue2.Top += 35;
            //Water
            if (ptrBlue2.Bounds.IntersectsWith(Water1.Bounds) || ptrBlue2.Bounds.IntersectsWith(Water2.Bounds) || ptrBlue2.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrBlue2.Enabled = false; ptrBlue2.Visible = false;
                lblConsole.Text = "Console: Blue Tank Drown"; boolB2 = false; boolB2A = false;
                if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4) { BlueAmount = 3; }
            }
            //Blue Tank 3
            //Right Wall
            if (ptrBlue3.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrBlue3.Left -= 35;
            //Left Wall
            if (ptrBlue3.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrBlue3.Left += 35;
            //Bottom
            if (ptrBlue3.Bounds.IntersectsWith(lblDown.Bounds))
                ptrBlue3.Top -= 35;
            //Top
            if (ptrBlue3.Bounds.IntersectsWith(lblTop.Bounds))
                ptrBlue3.Top += 35;
            //Water
            if (ptrBlue3.Bounds.IntersectsWith(Water1.Bounds) || ptrBlue3.Bounds.IntersectsWith(Water2.Bounds) || ptrBlue3.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrBlue3.Enabled = false; ptrBlue3.Visible = false;
                lblConsole.Text = "Console: Blue Tank Drown"; boolB3 = false; boolB3A = false;
                if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4) { BlueAmount = 3; }
            }
        //Blue Tank 4
            //Right Wall
            if (ptrBlue4.Bounds.IntersectsWith(pnlRight.Bounds))
                ptrBlue4.Left -= 35;
            //Left Wall
            if (ptrBlue4.Bounds.IntersectsWith(lblLeft.Bounds))
                ptrBlue4.Left += 35;
            //Bottom
            if (ptrBlue4.Bounds.IntersectsWith(lblDown.Bounds))
                ptrBlue4.Top -= 35;
            //Top
            if (ptrBlue4.Bounds.IntersectsWith(lblTop.Bounds))
                ptrBlue4.Top += 35;
            //Water
            if (ptrBlue4.Bounds.IntersectsWith(Water1.Bounds) || ptrBlue4.Bounds.IntersectsWith(Water2.Bounds) || ptrBlue4.Bounds.IntersectsWith(Water3.Bounds))
            {
                ptrBlue4.Enabled = false; ptrBlue4.Visible = false;
                lblConsole.Text = "Console: Blue Tank Drown"; boolB4 = false; boolB4A = false;
                if (BlueAmount == 1) BlueAmount = 0; if (BlueAmount == 2) BlueAmount = 1; if (BlueAmount == 3) BlueAmount = 2; if (BlueAmount == 4) { BlueAmount = 3; }
            }
        }

        private void tmrBlueBuild_Tick(object sender, EventArgs e)
        {
            GamePadState Controller2 = GamePad.GetState(PlayerIndex.Two);
            if (Controller2.Buttons.LeftShoulder == Input.ButtonState.Pressed)
            {
                intBlueProgress++;
                lblBlueProgress.Text = "Build Progress: " + intBlueProgress.ToString() + " /100";
            }
            GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
            if (Controller1.Buttons.LeftShoulder == Input.ButtonState.Pressed)
            {
                intRedProgress++;
                lblRedProgress.Text = "Build Progress: " + intRedProgress.ToString() + " /100";
            }
        }

        private void tmrBlue1Shoot_Tick(object sender, EventArgs e)
        {
            GamePadState Controller2 = GamePad.GetState(PlayerIndex.Two);
            SoundPlayer simpleSound = new SoundPlayer(@"C:\VS OVERFLOW\shoot.wav");
        //Tank 1
            if (intBlueTank == 1 & boolB1 == true)
            {
                
                //Up
                if (Controller2.ThumbSticks.Right.Y > 0f)
                {ptrBlueShoot1.Location = ptrBlue1.Location; ptrBlueShoot1.Visible = true; tmrBlue1Up.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false;
                    simpleSound.Play();
                }
                //Left
                if (Controller2.ThumbSticks.Right.X < 0f)
                {ptrBlueShoot1.Location = ptrBlue1.Location; ptrBlueShoot1.Visible = true; tmrBlue1Left.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Up.Enabled = false;
                     simpleSound.Play();
                }
                //Down
                if (Controller2.ThumbSticks.Right.Y < 0f)
                {ptrBlueShoot1.Location = ptrBlue1.Location; ptrBlueShoot1.Visible = true; tmrBlue1Down.Start();
                    tmrBlue1Up.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false;
                    simpleSound.Play();
                }
                //Right
                if (Controller2.ThumbSticks.Right.X > 0f)
                { ptrBlueShoot1.Location = ptrBlue1.Location; ptrBlueShoot1.Visible = true; tmrBlue1Right.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Up.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
               
            }
     //Tank 2
            if (intBlueTank == 2 & boolB2 == true) { 
                //Up
                if (Controller2.ThumbSticks.Right.Y > 0f)
                { ptrBlueShoot1.Location = ptrBlue2.Location; ptrBlueShoot1.Visible = true; tmrBlue1Up.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Left
                if (Controller2.ThumbSticks.Right.X < 0f)
                {   ptrBlueShoot1.Location = ptrBlue2.Location; ptrBlueShoot1.Visible = true; tmrBlue1Left.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Up.Enabled = false; simpleSound.Play();
                }
                //Down
                if (Controller2.ThumbSticks.Right.Y < 0f)
                { ptrBlueShoot1.Location = ptrBlue2.Location; ptrBlueShoot1.Visible = true; tmrBlue1Down.Start();
                tmrBlue1Up.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Right
                if (Controller2.ThumbSticks.Right.X > 0f)
                { ptrBlueShoot1.Location = ptrBlue2.Location; ptrBlueShoot1.Visible = true; tmrBlue1Right.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Up.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
            }
     //Tank 3
            if (intBlueTank == 3 & boolB3 == true) {
                //Up
                if (Controller2.ThumbSticks.Right.Y > 0f)
                {  ptrBlueShoot1.Location = ptrBlue3.Location; ptrBlueShoot1.Visible = true; tmrBlue1Up.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Left
                if (Controller2.ThumbSticks.Right.X < 0f)
                { ptrBlueShoot1.Location = ptrBlue3.Location; ptrBlueShoot1.Visible = true; tmrBlue1Left.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Up.Enabled = false; simpleSound.Play();
                }
                //Down
                if (Controller2.ThumbSticks.Right.Y < 0f)
                {   ptrBlueShoot1.Location = ptrBlue3.Location; ptrBlueShoot1.Visible = true; tmrBlue1Down.Start();
                tmrBlue1Up.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Right
                if (Controller2.ThumbSticks.Right.X > 0f)
                { ptrBlueShoot1.Location = ptrBlue3.Location; ptrBlueShoot1.Visible = true; tmrBlue1Right.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Up.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
            }
    //Tank 4
            if (intBlueTank == 4 & boolB4 == true) {
                //Up
                if (Controller2.ThumbSticks.Right.Y > 0f)
                {ptrBlueShoot1.Location = ptrBlue4.Location; ptrBlueShoot1.Visible = true; tmrBlue1Up.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Left
                if (Controller2.ThumbSticks.Right.X < 0f)
                {  ptrBlueShoot1.Location = ptrBlue4.Location; ptrBlueShoot1.Visible = true; tmrBlue1Left.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Up.Enabled = false; simpleSound.Play();
                }
                //Down
                if (Controller2.ThumbSticks.Right.Y < 0f)
                {  ptrBlueShoot1.Location = ptrBlue4.Location; ptrBlueShoot1.Visible = true; tmrBlue1Down.Start();
                tmrBlue1Up.Enabled = false; tmrBlue1Right.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
                //Right
                if (Controller2.ThumbSticks.Right.X > 0f)
                {ptrBlueShoot1.Location = ptrBlue4.Location; ptrBlueShoot1.Visible = true; tmrBlue1Right.Start();
                tmrBlue1Down.Enabled = false; tmrBlue1Up.Enabled = false; tmrBlue1Left.Enabled = false; simpleSound.Play();
                }
            }
        }

      
//Red Shoot
        private void tmrRedShoot1_Tick(object sender, EventArgs e)
        {
            SoundPlayer simpleSound2 = new SoundPlayer(@"C:\VS OVERFLOW\shoot.wav");
            if (intRedTank == 1 && boolR1 == true)
            {
                GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
                if (Controller1.ThumbSticks.Right.Y > 0f)
                {
                    ptrRedShoot1.Location = ptrRed1.Location; ptrRedShoot1.Visible = true; tmrRed1Up.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X < 0f)
                {
                    ptrRedShoot1.Location = ptrRed1.Location; ptrRedShoot1.Visible = true; tmrRed1Left.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Up.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.Y < 0f)
                {
                    ptrRedShoot1.Location = ptrRed1.Location; ptrRedShoot1.Visible = true; tmrRed1Down.Start();
                    tmrRed1Up.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X > 0f)
                {
                    ptrRedShoot1.Location = ptrRed1.Location; ptrRedShoot1.Visible = true; tmrRed1Right.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Up.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
            }
            if (intRedTank == 2 && boolR2 == true)
            {
                GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
                if (Controller1.ThumbSticks.Right.Y > 0f)
                {
                    ptrRedShoot1.Location = ptrRed2.Location; ptrRedShoot1.Visible = true; tmrRed1Up.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X < 0f)
                {
                    ptrRedShoot1.Location = ptrRed2.Location; ptrRedShoot1.Visible = true; tmrRed1Left.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Up.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.Y < 0f)
                {
                    ptrRedShoot1.Location = ptrRed2.Location; ptrRedShoot1.Visible = true; tmrRed1Down.Start();
                    tmrRed1Up.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X > 0f)
                {                    ptrRedShoot1.Location = ptrRed2.Location; ptrRedShoot1.Visible = true; tmrRed1Right.Start();
                tmrRed1Down.Enabled = false; tmrRed1Up.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
            }
           
            if (intRedTank == 3 && boolR3 == true)
            {
                GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
                if (Controller1.ThumbSticks.Right.Y > 0f)
                {
                    ptrRedShoot1.Location = ptrRed3.Location; ptrRedShoot1.Visible = true; tmrRed1Up.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X < 0f)
                {
                    ptrRedShoot1.Location = ptrRed3.Location; ptrRedShoot1.Visible = true; tmrRed1Left.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Up.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.Y < 0f)
                {
                    ptrRedShoot1.Location = ptrRed3.Location; ptrRedShoot1.Visible = true; tmrRed1Down.Start();
                    tmrRed1Up.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X > 0f)
                {
                    ptrRedShoot1.Location = ptrRed3.Location; ptrRedShoot1.Visible = true; tmrRed1Right.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Up.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
            } if (intRedTank == 4 && boolR4 == true)
            {
                GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
                if (Controller1.ThumbSticks.Right.Y > 0f)
                {
                    ptrRedShoot1.Location = ptrRed4.Location; ptrRedShoot1.Visible = true; tmrRed1Up.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X < 0f)
                {
                    ptrRedShoot1.Location = ptrRed4.Location; ptrRedShoot1.Visible = true; tmrRed1Left.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Up.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.Y < 0f)
                {
                    ptrRedShoot1.Location = ptrRed4.Location; ptrRedShoot1.Visible = true; tmrRed1Down.Start();
                    tmrRed1Up.Enabled = false; tmrRed1Right.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
                if (Controller1.ThumbSticks.Right.X > 0f)
                {
                    ptrRedShoot1.Location = ptrRed4.Location; ptrRedShoot1.Visible = true; tmrRed1Right.Start();
                    tmrRed1Down.Enabled = false; tmrRed1Up.Enabled = false; tmrRed1Left.Enabled = false; simpleSound2.Play();
                }
            }
        }

        private void tmrCompute_Tick(object sender, EventArgs e)
        {
            GamePadState Controller2 = GamePad.GetState(PlayerIndex.Two);
            if (Controller2.Buttons.Y == Input.ButtonState.Pressed) { btnBlueTank1.Enabled = true; btnBlueTank1.PerformClick(); btnBlueTank1.Enabled = false; }
            if (Controller2.Buttons.X == Input.ButtonState.Pressed) { btnBlueTank2.Enabled = true; btnBlueTank2.PerformClick(); btnBlueTank2.Enabled = false; }
            if (Controller2.Buttons.A == Input.ButtonState.Pressed) { btnBlueTank3.Enabled = true; btnBlueTank3.PerformClick(); btnBlueTank3.Enabled = false; }
            if (Controller2.Buttons.B == Input.ButtonState.Pressed) { btnBlueTank4.Enabled = true; btnBlueTank4.PerformClick(); btnBlueTank4.Enabled = false; }
            GamePadState Controller1 = GamePad.GetState(PlayerIndex.One);
            if (Controller1.Buttons.Y == Input.ButtonState.Pressed) { btnRedTank1.Enabled = true; btnRedTank1.PerformClick(); btnRedTank1.Enabled = false; }
            if (Controller1.Buttons.X == Input.ButtonState.Pressed) { btnRedTank2.Enabled = true; btnRedTank2.PerformClick(); btnRedTank2.Enabled = false; }
            if (Controller1.Buttons.A == Input.ButtonState.Pressed) { btnRedTank3.Enabled = true; btnRedTank3.PerformClick(); btnRedTank3.Enabled = false; }
            if (Controller1.Buttons.B == Input.ButtonState.Pressed) { btnRedTank4.Enabled = true; btnRedTank4.PerformClick(); btnRedTank4.Enabled = false; }

            if (intRedProgress == 100)
            {
                if (RedTanksMade == 1) { ptrRed2.Top += 35; boolR2 = true; red2 = 225;  intRedProgress = 0; RedTanksMade++; }
                if (RedTanksMade == 2 & intRedProgress == 100) { ptrRed3.Top += 35; red3 = 225; boolR3 = true; intRedProgress = 0; RedTanksMade++; }
                if (RedTanksMade == 3 & intRedProgress == 100) { ptrRed4.Left -= 35; red4 = 225; boolR4 = true; intRedProgress = 0; RedTanksMade++; lblRedProgress.Visible = false; } intRedProgress = 0;
            }

            if (intBlueProgress == 100)
            {
                if (BlueTanksMade == 1) { ptrBlue2.Top -= 35; boolB2 = true; blue2 = 225;  intBlueProgress = 0; BlueTanksMade = 2; }
                if (BlueTanksMade == 2 & intBlueProgress == 100) { ptrBlue3.Top -= 35; blue3 = 225; boolB3 = true; intBlueProgress = 0; BlueTanksMade = 3; }
                if (BlueTanksMade == 3 & intBlueProgress == 100) { ptrBlue4.Left += 35; blue4 = 225; boolB4 = true; intBlueProgress = 0; BlueTanksMade = 4; lblBlueProgress.Visible = false; } intBlueProgress = 0;
            }
            double dblTime = intTime / 60;


            if (boolR1A == false & boolR2A == false & boolR3A == false & boolR4A == false)
            {
                MessageBox.Show("Blue Team Won in " + dblTime.ToString() + " minutes.");
            }

            if (boolB1A == false & boolB2A == false & boolB3A == false & boolB4A == false)
            {
                MessageBox.Show("Red Team Won in " + dblTime.ToString() + " minutes.");
            }

            List<string> playerName = new List<string>();

         
        }
    }

}