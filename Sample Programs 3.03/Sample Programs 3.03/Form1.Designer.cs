namespace Sample_Programs_3._03
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
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.radNext = new System.Windows.Forms.RadioButton();
            this.chkRush = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.radSecond = new System.Windows.Forms.RadioButton();
            this.rad3rd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(113, 39);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(153, 36);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 2;
            // 
            // radNext
            // 
            this.radNext.AutoSize = true;
            this.radNext.Location = new System.Drawing.Point(6, 54);
            this.radNext.Name = "radNext";
            this.radNext.Size = new System.Drawing.Size(84, 17);
            this.radNext.TabIndex = 3;
            this.radNext.TabStop = true;
            this.radNext.Text = "Next Day Air";
            this.radNext.UseVisualStyleBackColor = true;
            // 
            // chkRush
            // 
            this.chkRush.AutoSize = true;
            this.chkRush.Location = new System.Drawing.Point(6, 19);
            this.chkRush.Name = "chkRush";
            this.chkRush.Size = new System.Drawing.Size(70, 17);
            this.chkRush.TabIndex = 4;
            this.chkRush.Text = "Rush AM";
            this.chkRush.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(6, 70);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(109, 17);
            this.chkSaturday.TabIndex = 5;
            this.chkSaturday.Text = "Saturday Delivery";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(139, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // radSecond
            // 
            this.radSecond.AutoSize = true;
            this.radSecond.Location = new System.Drawing.Point(6, 31);
            this.radSecond.Name = "radSecond";
            this.radSecond.Size = new System.Drawing.Size(99, 17);
            this.radSecond.TabIndex = 7;
            this.radSecond.TabStop = true;
            this.radSecond.Text = "Second Day Air";
            this.radSecond.UseVisualStyleBackColor = true;
            // 
            // rad3rd
            // 
            this.rad3rd.AutoSize = true;
            this.rad3rd.Location = new System.Drawing.Point(108, 31);
            this.rad3rd.Name = "rad3rd";
            this.rad3rd.Size = new System.Drawing.Size(86, 17);
            this.rad3rd.TabIndex = 8;
            this.rad3rd.TabStop = true;
            this.rad3rd.Text = "Third Day Air";
            this.rad3rd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radSecond);
            this.groupBox1.Controls.Add(this.radNext);
            this.groupBox1.Controls.Add(this.rad3rd);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Grounded";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shipping Weight";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.chkInsurance);
            this.groupBox2.Controls.Add(this.chkRush);
            this.groupBox2.Controls.Add(this.chkSaturday);
            this.groupBox2.Controls.Add(this.lblValue);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Location = new System.Drawing.Point(11, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(128, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Signature Required";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(109, 19);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(73, 17);
            this.chkInsurance.TabIndex = 6;
            this.chkInsurance.Text = "Insurance";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(2, 240);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(164, 240);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(281, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "label2";
      
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 273);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWeight);
            this.Name = "Form1";
            this.Text = "Shipping Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton radNext;
        private System.Windows.Forms.CheckBox chkRush;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton radSecond;
        private System.Windows.Forms.RadioButton rad3rd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button3;
    }
}

