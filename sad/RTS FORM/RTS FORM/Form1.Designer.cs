namespace RTS_FORM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptrBlueShoot1 = new System.Windows.Forms.PictureBox();
            this.ptrRedShoot1 = new System.Windows.Forms.PictureBox();
            this.tmrBlue1Up = new System.Windows.Forms.Timer(this.components);
            this.tmrRed1Up = new System.Windows.Forms.Timer(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpUSSR = new System.Windows.Forms.GroupBox();
            this.btnRedTank4 = new System.Windows.Forms.Button();
            this.btnRedTank3 = new System.Windows.Forms.Button();
            this.btnRedTank2 = new System.Windows.Forms.Button();
            this.btnRedTank1 = new System.Windows.Forms.Button();
            this.btnRedDone = new System.Windows.Forms.Button();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblRedProgress = new System.Windows.Forms.Label();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.lblRedDestroyed = new System.Windows.Forms.Label();
            this.lblConsole = new System.Windows.Forms.Label();
            this.grpUSA = new System.Windows.Forms.GroupBox();
            this.btnBlueTank4 = new System.Windows.Forms.Button();
            this.btnBlueTank3 = new System.Windows.Forms.Button();
            this.btnBlueTank2 = new System.Windows.Forms.Button();
            this.btnBlueTank1 = new System.Windows.Forms.Button();
            this.btnBlueDone = new System.Windows.Forms.Button();
            this.lblControl2 = new System.Windows.Forms.Label();
            this.lblBlueInstruct = new System.Windows.Forms.Label();
            this.lblBlueDestroyed = new System.Windows.Forms.Label();
            this.lblBlueProgress = new System.Windows.Forms.Label();
            this.Water1 = new System.Windows.Forms.Panel();
            this.Water2 = new System.Windows.Forms.Panel();
            this.Water3 = new System.Windows.Forms.Panel();
            this.RedWarFactory = new System.Windows.Forms.PictureBox();
            this.BlueWarFactory = new System.Windows.Forms.PictureBox();
            this.ptrRed1 = new System.Windows.Forms.Label();
            this.ptrBlue1 = new System.Windows.Forms.Label();
            this.tmrBlue1Down = new System.Windows.Forms.Timer(this.components);
            this.tmrBlue1Left = new System.Windows.Forms.Timer(this.components);
            this.tmrBlue1Right = new System.Windows.Forms.Timer(this.components);
            this.tmrRed1Left = new System.Windows.Forms.Timer(this.components);
            this.tmrRed1Down = new System.Windows.Forms.Timer(this.components);
            this.tmrRed1Right = new System.Windows.Forms.Timer(this.components);
            this.tmrCollideCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrRedMove = new System.Windows.Forms.Timer(this.components);
            this.tmrBlueMove = new System.Windows.Forms.Timer(this.components);
            this.lblDown = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.ptrRed2 = new System.Windows.Forms.Label();
            this.ptrRedShoot2 = new System.Windows.Forms.PictureBox();
            this.ptrBlue2 = new System.Windows.Forms.Label();
            this.ptrBlueShoot2 = new System.Windows.Forms.PictureBox();
            this.ptrBlue3 = new System.Windows.Forms.Label();
            this.ptrRed3 = new System.Windows.Forms.Label();
            this.ptrRed4 = new System.Windows.Forms.Label();
            this.ptrBlue4 = new System.Windows.Forms.Label();
            this.tmrBuild = new System.Windows.Forms.Timer(this.components);
            this.tmrBlue1Shoot = new System.Windows.Forms.Timer(this.components);
            this.tmrRedShoot1 = new System.Windows.Forms.Timer(this.components);
            this.tmrCompute = new System.Windows.Forms.Timer(this.components);
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBlueShoot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRedShoot1)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpUSSR.SuspendLayout();
            this.grpUSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedWarFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueWarFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRedShoot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBlueShoot2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrBlueShoot1
            // 
            this.ptrBlueShoot1.Image = ((System.Drawing.Image)(resources.GetObject("ptrBlueShoot1.Image")));
            this.ptrBlueShoot1.Location = new System.Drawing.Point(-35, 250);
            this.ptrBlueShoot1.Name = "ptrBlueShoot1";
            this.ptrBlueShoot1.Size = new System.Drawing.Size(27, 27);
            this.ptrBlueShoot1.TabIndex = 2;
            this.ptrBlueShoot1.TabStop = false;
            this.ptrBlueShoot1.Visible = false;
            // 
            // ptrRedShoot1
            // 
            this.ptrRedShoot1.Image = ((System.Drawing.Image)(resources.GetObject("ptrRedShoot1.Image")));
            this.ptrRedShoot1.Location = new System.Drawing.Point(-35, 250);
            this.ptrRedShoot1.Name = "ptrRedShoot1";
            this.ptrRedShoot1.Size = new System.Drawing.Size(27, 27);
            this.ptrRedShoot1.TabIndex = 3;
            this.ptrRedShoot1.TabStop = false;
            this.ptrRedShoot1.Visible = false;
            // 
            // tmrBlue1Up
            // 
            this.tmrBlue1Up.Interval = 10;
            this.tmrBlue1Up.Tick += new System.EventHandler(this.tmrBlue1Up_Tick);
            // 
            // tmrRed1Up
            // 
            this.tmrRed1Up.Interval = 10;
            this.tmrRed1Up.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblTime);
            this.pnlRight.Controls.Add(this.grpUSSR);
            this.pnlRight.Controls.Add(this.lblConsole);
            this.pnlRight.Controls.Add(this.grpUSA);
            this.pnlRight.Location = new System.Drawing.Point(701, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(199, 794);
            this.pnlRight.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(5, 621);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(191, 35);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = " ";
            // 
            // grpUSSR
            // 
            this.grpUSSR.Controls.Add(this.btnRedTank4);
            this.grpUSSR.Controls.Add(this.btnRedTank3);
            this.grpUSSR.Controls.Add(this.btnRedTank2);
            this.grpUSSR.Controls.Add(this.btnRedTank1);
            this.grpUSSR.Controls.Add(this.btnRedDone);
            this.grpUSSR.Controls.Add(this.lblControl);
            this.grpUSSR.Controls.Add(this.lblRedProgress);
            this.grpUSSR.Controls.Add(this.lblInstruct);
            this.grpUSSR.Controls.Add(this.lblRedDestroyed);
            this.grpUSSR.Location = new System.Drawing.Point(0, 3);
            this.grpUSSR.Name = "grpUSSR";
            this.grpUSSR.Size = new System.Drawing.Size(200, 274);
            this.grpUSSR.TabIndex = 7;
            this.grpUSSR.TabStop = false;
            this.grpUSSR.Text = "USSR";
            // 
            // btnRedTank4
            // 
            this.btnRedTank4.Enabled = false;
            this.btnRedTank4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedTank4.Location = new System.Drawing.Point(105, 188);
            this.btnRedTank4.Name = "btnRedTank4";
            this.btnRedTank4.Size = new System.Drawing.Size(76, 41);
            this.btnRedTank4.TabIndex = 29;
            this.btnRedTank4.Text = "Tank 4\r\n [ B ]";
            this.btnRedTank4.UseVisualStyleBackColor = true;
            this.btnRedTank4.Click += new System.EventHandler(this.btnRedTank4_Click);
            // 
            // btnRedTank3
            // 
            this.btnRedTank3.Enabled = false;
            this.btnRedTank3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedTank3.Location = new System.Drawing.Point(15, 188);
            this.btnRedTank3.Name = "btnRedTank3";
            this.btnRedTank3.Size = new System.Drawing.Size(76, 41);
            this.btnRedTank3.TabIndex = 28;
            this.btnRedTank3.Text = "Tank 3\r\n[ A ]\r\n";
            this.btnRedTank3.UseVisualStyleBackColor = true;
            this.btnRedTank3.Click += new System.EventHandler(this.btnRedTank3_Click);
            // 
            // btnRedTank2
            // 
            this.btnRedTank2.Enabled = false;
            this.btnRedTank2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedTank2.Location = new System.Drawing.Point(105, 141);
            this.btnRedTank2.Name = "btnRedTank2";
            this.btnRedTank2.Size = new System.Drawing.Size(76, 41);
            this.btnRedTank2.TabIndex = 27;
            this.btnRedTank2.Text = "Tank 2\r\n[ X ]";
            this.btnRedTank2.UseVisualStyleBackColor = true;
            this.btnRedTank2.Click += new System.EventHandler(this.btnRedTank2_Click);
            // 
            // btnRedTank1
            // 
            this.btnRedTank1.Enabled = false;
            this.btnRedTank1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedTank1.Location = new System.Drawing.Point(15, 141);
            this.btnRedTank1.Name = "btnRedTank1";
            this.btnRedTank1.Size = new System.Drawing.Size(76, 41);
            this.btnRedTank1.TabIndex = 26;
            this.btnRedTank1.Text = "Tank 1 \r\n[ Y ]";
            this.btnRedTank1.UseVisualStyleBackColor = true;
            this.btnRedTank1.Click += new System.EventHandler(this.btnRedTank1_Click);
            // 
            // btnRedDone
            // 
            this.btnRedDone.Enabled = false;
            this.btnRedDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedDone.Location = new System.Drawing.Point(63, 236);
            this.btnRedDone.Name = "btnRedDone";
            this.btnRedDone.Size = new System.Drawing.Size(75, 23);
            this.btnRedDone.TabIndex = 9;
            this.btnRedDone.Text = "Done";
            this.btnRedDone.UseVisualStyleBackColor = true;
            this.btnRedDone.Click += new System.EventHandler(this.btnRedDone_Click);
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(6, 115);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(117, 13);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Select Tank To Control";
            this.lblControl.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRedProgress
            // 
            this.lblRedProgress.AutoSize = true;
            this.lblRedProgress.Location = new System.Drawing.Point(6, 83);
            this.lblRedProgress.Name = "lblRedProgress";
            this.lblRedProgress.Size = new System.Drawing.Size(109, 13);
            this.lblRedProgress.TabIndex = 3;
            this.lblRedProgress.Text = "Build Progress: 0/100";
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Location = new System.Drawing.Point(6, 56);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(172, 13);
            this.lblInstruct.TabIndex = 2;
            this.lblInstruct.Text = "Press L1 to Begin Tank Production";
            // 
            // lblRedDestroyed
            // 
            this.lblRedDestroyed.AutoSize = true;
            this.lblRedDestroyed.Location = new System.Drawing.Point(6, 29);
            this.lblRedDestroyed.Name = "lblRedDestroyed";
            this.lblRedDestroyed.Size = new System.Drawing.Size(91, 13);
            this.lblRedDestroyed.TabIndex = 1;
            this.lblRedDestroyed.Text = "Tanks Destroyed:";
            // 
            // lblConsole
            // 
            this.lblConsole.Location = new System.Drawing.Point(8, 572);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(191, 93);
            this.lblConsole.TabIndex = 11;
            this.lblConsole.Text = "Console:";
            // 
            // grpUSA
            // 
            this.grpUSA.Controls.Add(this.btnBlueTank4);
            this.grpUSA.Controls.Add(this.btnBlueTank3);
            this.grpUSA.Controls.Add(this.btnBlueTank2);
            this.grpUSA.Controls.Add(this.btnBlueTank1);
            this.grpUSA.Controls.Add(this.btnBlueDone);
            this.grpUSA.Controls.Add(this.lblControl2);
            this.grpUSA.Controls.Add(this.lblBlueInstruct);
            this.grpUSA.Controls.Add(this.lblBlueDestroyed);
            this.grpUSA.Controls.Add(this.lblBlueProgress);
            this.grpUSA.Location = new System.Drawing.Point(3, 283);
            this.grpUSA.Name = "grpUSA";
            this.grpUSA.Size = new System.Drawing.Size(197, 278);
            this.grpUSA.TabIndex = 8;
            this.grpUSA.TabStop = false;
            this.grpUSA.Text = "USA";
            // 
            // btnBlueTank4
            // 
            this.btnBlueTank4.Enabled = false;
            this.btnBlueTank4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTank4.Location = new System.Drawing.Point(106, 193);
            this.btnBlueTank4.Name = "btnBlueTank4";
            this.btnBlueTank4.Size = new System.Drawing.Size(76, 41);
            this.btnBlueTank4.TabIndex = 24;
            this.btnBlueTank4.Text = "Tank 4\r\n [ B ]";
            this.btnBlueTank4.UseVisualStyleBackColor = true;
            this.btnBlueTank4.Click += new System.EventHandler(this.btnBlueTank4_Click);
            // 
            // btnBlueTank3
            // 
            this.btnBlueTank3.Enabled = false;
            this.btnBlueTank3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTank3.Location = new System.Drawing.Point(13, 193);
            this.btnBlueTank3.Name = "btnBlueTank3";
            this.btnBlueTank3.Size = new System.Drawing.Size(76, 41);
            this.btnBlueTank3.TabIndex = 23;
            this.btnBlueTank3.Text = "Tank 3\r\n[ A ]\r\n";
            this.btnBlueTank3.UseVisualStyleBackColor = true;
            this.btnBlueTank3.Click += new System.EventHandler(this.btnBlueTank3_Click);
            // 
            // btnBlueTank2
            // 
            this.btnBlueTank2.Enabled = false;
            this.btnBlueTank2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTank2.Location = new System.Drawing.Point(106, 146);
            this.btnBlueTank2.Name = "btnBlueTank2";
            this.btnBlueTank2.Size = new System.Drawing.Size(76, 41);
            this.btnBlueTank2.TabIndex = 22;
            this.btnBlueTank2.Text = "Tank 2\r\n[ X ]";
            this.btnBlueTank2.UseVisualStyleBackColor = true;
            this.btnBlueTank2.Click += new System.EventHandler(this.btnBlueTank2_Click);
            // 
            // btnBlueTank1
            // 
            this.btnBlueTank1.Enabled = false;
            this.btnBlueTank1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueTank1.Location = new System.Drawing.Point(12, 146);
            this.btnBlueTank1.Name = "btnBlueTank1";
            this.btnBlueTank1.Size = new System.Drawing.Size(76, 41);
            this.btnBlueTank1.TabIndex = 21;
            this.btnBlueTank1.Text = "Tank 1 \r\n[ Y ]";
            this.btnBlueTank1.UseVisualStyleBackColor = true;
            this.btnBlueTank1.Click += new System.EventHandler(this.btnBlueTank1_Click);
            // 
            // btnBlueDone
            // 
            this.btnBlueDone.Enabled = false;
            this.btnBlueDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlueDone.Location = new System.Drawing.Point(60, 241);
            this.btnBlueDone.Name = "btnBlueDone";
            this.btnBlueDone.Size = new System.Drawing.Size(75, 23);
            this.btnBlueDone.TabIndex = 17;
            this.btnBlueDone.Text = "Done";
            this.btnBlueDone.UseVisualStyleBackColor = true;
            this.btnBlueDone.Click += new System.EventHandler(this.btnBlueDone_Click);
            // 
            // lblControl2
            // 
            this.lblControl2.AutoSize = true;
            this.lblControl2.Location = new System.Drawing.Point(9, 116);
            this.lblControl2.Name = "lblControl2";
            this.lblControl2.Size = new System.Drawing.Size(117, 13);
            this.lblControl2.TabIndex = 16;
            this.lblControl2.Text = "Select Tank To Control";
            this.lblControl2.Click += new System.EventHandler(this.lblControl2_Click);
            // 
            // lblBlueInstruct
            // 
            this.lblBlueInstruct.AutoSize = true;
            this.lblBlueInstruct.Location = new System.Drawing.Point(9, 57);
            this.lblBlueInstruct.Name = "lblBlueInstruct";
            this.lblBlueInstruct.Size = new System.Drawing.Size(172, 13);
            this.lblBlueInstruct.TabIndex = 14;
            this.lblBlueInstruct.Text = "Press L1 to Begin Tank Production";
            // 
            // lblBlueDestroyed
            // 
            this.lblBlueDestroyed.AutoSize = true;
            this.lblBlueDestroyed.Location = new System.Drawing.Point(9, 30);
            this.lblBlueDestroyed.Name = "lblBlueDestroyed";
            this.lblBlueDestroyed.Size = new System.Drawing.Size(91, 13);
            this.lblBlueDestroyed.TabIndex = 13;
            this.lblBlueDestroyed.Text = "Tanks Destroyed:";
            // 
            // lblBlueProgress
            // 
            this.lblBlueProgress.AutoSize = true;
            this.lblBlueProgress.Location = new System.Drawing.Point(9, 80);
            this.lblBlueProgress.Name = "lblBlueProgress";
            this.lblBlueProgress.Size = new System.Drawing.Size(109, 13);
            this.lblBlueProgress.TabIndex = 10;
            this.lblBlueProgress.Text = "Build Progress: 0/100";
            // 
            // Water1
            // 
            this.Water1.BackColor = System.Drawing.Color.Transparent;
            this.Water1.Location = new System.Drawing.Point(-28, 299);
            this.Water1.Name = "Water1";
            this.Water1.Size = new System.Drawing.Size(122, 179);
            this.Water1.TabIndex = 9;
            // 
            // Water2
            // 
            this.Water2.BackColor = System.Drawing.Color.Transparent;
            this.Water2.Location = new System.Drawing.Point(184, 299);
            this.Water2.Name = "Water2";
            this.Water2.Size = new System.Drawing.Size(196, 179);
            this.Water2.TabIndex = 10;
            // 
            // Water3
            // 
            this.Water3.BackColor = System.Drawing.Color.Transparent;
            this.Water3.Location = new System.Drawing.Point(469, 299);
            this.Water3.Name = "Water3";
            this.Water3.Size = new System.Drawing.Size(224, 179);
            this.Water3.TabIndex = 10;
            // 
            // RedWarFactory
            // 
            this.RedWarFactory.Image = ((System.Drawing.Image)(resources.GetObject("RedWarFactory.Image")));
            this.RedWarFactory.Location = new System.Drawing.Point(630, 0);
            this.RedWarFactory.Name = "RedWarFactory";
            this.RedWarFactory.Size = new System.Drawing.Size(70, 35);
            this.RedWarFactory.TabIndex = 11;
            this.RedWarFactory.TabStop = false;
            // 
            // BlueWarFactory
            // 
            this.BlueWarFactory.Image = ((System.Drawing.Image)(resources.GetObject("BlueWarFactory.Image")));
            this.BlueWarFactory.Location = new System.Drawing.Point(0, 630);
            this.BlueWarFactory.Name = "BlueWarFactory";
            this.BlueWarFactory.Size = new System.Drawing.Size(70, 35);
            this.BlueWarFactory.TabIndex = 12;
            this.BlueWarFactory.TabStop = false;
            // 
            // ptrRed1
            // 
            this.ptrRed1.BackColor = System.Drawing.Color.Red;
            this.ptrRed1.Location = new System.Drawing.Point(0, 0);
            this.ptrRed1.Name = "ptrRed1";
            this.ptrRed1.Size = new System.Drawing.Size(35, 35);
            this.ptrRed1.TabIndex = 13;
            this.ptrRed1.Text = "1";
            this.ptrRed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrBlue1
            // 
            this.ptrBlue1.BackColor = System.Drawing.Color.Blue;
            this.ptrBlue1.Location = new System.Drawing.Point(665, 630);
            this.ptrBlue1.Name = "ptrBlue1";
            this.ptrBlue1.Size = new System.Drawing.Size(35, 35);
            this.ptrBlue1.TabIndex = 14;
            this.ptrBlue1.Text = "1";
            this.ptrBlue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrBlue1Down
            // 
            this.tmrBlue1Down.Interval = 10;
            this.tmrBlue1Down.Tick += new System.EventHandler(this.tmrBlue1Down_Tick);
            // 
            // tmrBlue1Left
            // 
            this.tmrBlue1Left.Interval = 10;
            this.tmrBlue1Left.Tick += new System.EventHandler(this.tmrBlue1Left_Tick);
            // 
            // tmrBlue1Right
            // 
            this.tmrBlue1Right.Interval = 10;
            this.tmrBlue1Right.Tick += new System.EventHandler(this.tmrBlue1Right_Tick);
            // 
            // tmrRed1Left
            // 
            this.tmrRed1Left.Interval = 10;
            this.tmrRed1Left.Tick += new System.EventHandler(this.tmrRed1Left_Tick);
            // 
            // tmrRed1Down
            // 
            this.tmrRed1Down.Interval = 10;
            this.tmrRed1Down.Tick += new System.EventHandler(this.tmrRed1Down_Tick);
            // 
            // tmrRed1Right
            // 
            this.tmrRed1Right.Interval = 10;
            this.tmrRed1Right.Tick += new System.EventHandler(this.tmrRed1Right_Tick);
            // 
            // tmrCollideCheck
            // 
            this.tmrCollideCheck.Interval = 1;
            this.tmrCollideCheck.Tick += new System.EventHandler(this.tmrCollideCheck_Tick);
            // 
            // tmrRedMove
            // 
            this.tmrRedMove.Tick += new System.EventHandler(this.tmrRedMove_Tick);
            // 
            // tmrBlueMove
            // 
            this.tmrBlueMove.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // lblDown
            // 
            this.lblDown.BackColor = System.Drawing.Color.Transparent;
            this.lblDown.Location = new System.Drawing.Point(0, 668);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(700, 28);
            this.lblDown.TabIndex = 15;
            this.lblDown.Text = "Down";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeft
            // 
            this.lblLeft.Location = new System.Drawing.Point(-35, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(35, 665);
            this.lblLeft.TabIndex = 16;
            this.lblLeft.Text = "label1";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.Transparent;
            this.lblTop.Location = new System.Drawing.Point(0, -10);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(700, 10);
            this.lblTop.TabIndex = 17;
            this.lblTop.Text = "Top";
            // 
            // ptrRed2
            // 
            this.ptrRed2.BackColor = System.Drawing.Color.Red;
            this.ptrRed2.Location = new System.Drawing.Point(630, 0);
            this.ptrRed2.Name = "ptrRed2";
            this.ptrRed2.Size = new System.Drawing.Size(35, 35);
            this.ptrRed2.TabIndex = 18;
            this.ptrRed2.Text = "2";
            this.ptrRed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrRedShoot2
            // 
            this.ptrRedShoot2.Image = ((System.Drawing.Image)(resources.GetObject("ptrRedShoot2.Image")));
            this.ptrRedShoot2.Location = new System.Drawing.Point(-35, 250);
            this.ptrRedShoot2.Name = "ptrRedShoot2";
            this.ptrRedShoot2.Size = new System.Drawing.Size(27, 27);
            this.ptrRedShoot2.TabIndex = 19;
            this.ptrRedShoot2.TabStop = false;
            this.ptrRedShoot2.Visible = false;
            // 
            // ptrBlue2
            // 
            this.ptrBlue2.BackColor = System.Drawing.Color.Blue;
            this.ptrBlue2.Location = new System.Drawing.Point(0, 630);
            this.ptrBlue2.Name = "ptrBlue2";
            this.ptrBlue2.Size = new System.Drawing.Size(35, 35);
            this.ptrBlue2.TabIndex = 20;
            this.ptrBlue2.Text = "2";
            this.ptrBlue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrBlueShoot2
            // 
            this.ptrBlueShoot2.Image = ((System.Drawing.Image)(resources.GetObject("ptrBlueShoot2.Image")));
            this.ptrBlueShoot2.Location = new System.Drawing.Point(-35, 0);
            this.ptrBlueShoot2.Name = "ptrBlueShoot2";
            this.ptrBlueShoot2.Size = new System.Drawing.Size(27, 27);
            this.ptrBlueShoot2.TabIndex = 21;
            this.ptrBlueShoot2.TabStop = false;
            this.ptrBlueShoot2.Visible = false;
            // 
            // ptrBlue3
            // 
            this.ptrBlue3.BackColor = System.Drawing.Color.Blue;
            this.ptrBlue3.Location = new System.Drawing.Point(35, 630);
            this.ptrBlue3.Name = "ptrBlue3";
            this.ptrBlue3.Size = new System.Drawing.Size(35, 35);
            this.ptrBlue3.TabIndex = 22;
            this.ptrBlue3.Text = "3";
            this.ptrBlue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrRed3
            // 
            this.ptrRed3.BackColor = System.Drawing.Color.Red;
            this.ptrRed3.Location = new System.Drawing.Point(665, 0);
            this.ptrRed3.Name = "ptrRed3";
            this.ptrRed3.Size = new System.Drawing.Size(35, 35);
            this.ptrRed3.TabIndex = 23;
            this.ptrRed3.Text = "3";
            this.ptrRed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrRed4
            // 
            this.ptrRed4.BackColor = System.Drawing.Color.Red;
            this.ptrRed4.Location = new System.Drawing.Point(630, 0);
            this.ptrRed4.Name = "ptrRed4";
            this.ptrRed4.Size = new System.Drawing.Size(35, 35);
            this.ptrRed4.TabIndex = 24;
            this.ptrRed4.Text = "4";
            this.ptrRed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrBlue4
            // 
            this.ptrBlue4.BackColor = System.Drawing.Color.Blue;
            this.ptrBlue4.Location = new System.Drawing.Point(35, 630);
            this.ptrBlue4.Name = "ptrBlue4";
            this.ptrBlue4.Size = new System.Drawing.Size(35, 35);
            this.ptrBlue4.TabIndex = 25;
            this.ptrBlue4.Text = "4";
            this.ptrBlue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrBuild
            // 
            this.tmrBuild.Interval = 50;
            this.tmrBuild.Tick += new System.EventHandler(this.tmrBlueBuild_Tick);
            // 
            // tmrBlue1Shoot
            // 
            this.tmrBlue1Shoot.Interval = 250;
            this.tmrBlue1Shoot.Tick += new System.EventHandler(this.tmrBlue1Shoot_Tick);
            // 
            // tmrRedShoot1
            // 
            this.tmrRedShoot1.Interval = 250;
            this.tmrRedShoot1.Tick += new System.EventHandler(this.tmrRedShoot1_Tick);
            // 
            // tmrCompute
            // 
            this.tmrCompute.Interval = 1;
            this.tmrCompute.Tick += new System.EventHandler(this.tmrCompute_Tick);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 665);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.BlueWarFactory);
            this.Controls.Add(this.ptrBlueShoot2);
            this.Controls.Add(this.ptrBlue2);
            this.Controls.Add(this.ptrRedShoot2);
            this.Controls.Add(this.RedWarFactory);
            this.Controls.Add(this.ptrRed2);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.ptrRedShoot1);
            this.Controls.Add(this.ptrBlue1);
            this.Controls.Add(this.ptrBlueShoot1);
            this.Controls.Add(this.ptrRed1);
            this.Controls.Add(this.Water2);
            this.Controls.Add(this.Water3);
            this.Controls.Add(this.Water1);
            this.Controls.Add(this.ptrBlue3);
            this.Controls.Add(this.ptrRed3);
            this.Controls.Add(this.ptrRed4);
            this.Controls.Add(this.ptrBlue4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "US vs. USSR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBlueShoot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRedShoot1)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpUSSR.ResumeLayout(false);
            this.grpUSSR.PerformLayout();
            this.grpUSA.ResumeLayout(false);
            this.grpUSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedWarFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueWarFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRedShoot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBlueShoot2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrBlueShoot1;
        private System.Windows.Forms.PictureBox ptrRedShoot1;
        private System.Windows.Forms.Timer tmrBlue1Up;
        private System.Windows.Forms.Timer tmrRed1Up;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpUSA;
        private System.Windows.Forms.GroupBox grpUSSR;
        private System.Windows.Forms.Label lblRedProgress;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.Label lblRedDestroyed;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Panel Water1;
        private System.Windows.Forms.Panel Water2;
        private System.Windows.Forms.Panel Water3;
        private System.Windows.Forms.Button btnRedDone;
        private System.Windows.Forms.Label lblBlueProgress;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Button btnBlueDone;
        private System.Windows.Forms.Label lblControl2;
        private System.Windows.Forms.Label lblBlueInstruct;
        private System.Windows.Forms.Label lblBlueDestroyed;
        private System.Windows.Forms.PictureBox RedWarFactory;
        private System.Windows.Forms.PictureBox BlueWarFactory;
        private System.Windows.Forms.Label ptrRed1;
        private System.Windows.Forms.Label ptrBlue1;
        private System.Windows.Forms.Timer tmrBlue1Down;
        private System.Windows.Forms.Timer tmrBlue1Left;
        private System.Windows.Forms.Timer tmrBlue1Right;
        private System.Windows.Forms.Timer tmrRed1Left;
        private System.Windows.Forms.Timer tmrRed1Down;
        private System.Windows.Forms.Timer tmrRed1Right;
        private System.Windows.Forms.Timer tmrCollideCheck;
        private System.Windows.Forms.Timer tmrRedMove;
        private System.Windows.Forms.Timer tmrBlueMove;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnRedTank4;
        private System.Windows.Forms.Button btnRedTank3;
        private System.Windows.Forms.Button btnRedTank2;
        private System.Windows.Forms.Button btnRedTank1;
        private System.Windows.Forms.Label ptrRed2;
        private System.Windows.Forms.PictureBox ptrRedShoot2;
        private System.Windows.Forms.Button btnBlueTank1;
        private System.Windows.Forms.Button btnBlueTank4;
        private System.Windows.Forms.Button btnBlueTank3;
        private System.Windows.Forms.Button btnBlueTank2;
        private System.Windows.Forms.Label ptrBlue2;
        private System.Windows.Forms.PictureBox ptrBlueShoot2;
        private System.Windows.Forms.Label ptrBlue3;
        private System.Windows.Forms.Label ptrRed3;
        private System.Windows.Forms.Label ptrRed4;
        private System.Windows.Forms.Label ptrBlue4;
        private System.Windows.Forms.Timer tmrBuild;
        private System.Windows.Forms.Timer tmrBlue1Shoot;
        private System.Windows.Forms.Timer tmrRedShoot1;
        private System.Windows.Forms.Timer tmrCompute;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
    }
}

