namespace JoyStick_Test
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
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.tmrCalc = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Arduino
            // 
            this.Arduino.BaudRate = 115200;
            this.Arduino.PortName = "COM3";
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTest.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(425, 291);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(40, 40);
            this.lblTest.TabIndex = 0;
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // tmrCalc
            // 
            this.tmrCalc.Interval = 1;
            this.tmrCalc.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.DarkRed;
            this.lbl1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(-4, -579);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(371, 157);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.DarkRed;
            this.lbl2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(500, -579);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(503, 157);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.DarkRed;
            this.lbl3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(88, -762);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(371, 157);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "3";
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.DarkRed;
            this.lbl4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(530, -839);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(371, 157);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "4";
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.DarkRed;
            this.lbl5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(26, -361);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(371, 157);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "5";
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.DarkRed;
            this.lbl7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(511, -225);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(371, 157);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "7";
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.DarkRed;
            this.lbl6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(-5, -72);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(371, 157);
            this.lbl6.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.ForestGreen;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnd.Location = new System.Drawing.Point(13, -1110);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(875, 87);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "LEVEL 1 END";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 326);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTest);
            this.Name = "Form1";
            this.Text = "Game Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Timer tmrCalc;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblEnd;
    }
}

