namespace Temperature_Comparisons
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFirstTemp = new System.Windows.Forms.Label();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.lblScale1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.lblScale2 = new System.Windows.Forms.Label();
            this.lblTempCompare = new System.Windows.Forms.Label();
            this.btnCompareTemps = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(282, 96);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Enter two temperatures in the textboxes below, then select the scale of the tempe" +
                "rature. When you are ready to compare the temperatures, click the button below.";
            // 
            // lblFirstTemp
            // 
            this.lblFirstTemp.Location = new System.Drawing.Point(12, 91);
            this.lblFirstTemp.Name = "lblFirstTemp";
            this.lblFirstTemp.Size = new System.Drawing.Size(156, 35);
            this.lblFirstTemp.TabIndex = 1;
            this.lblFirstTemp.Text = "Enter 1st temperature";
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(173, 91);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(120, 20);
            this.txtTemp1.TabIndex = 2;
            // 
            // lblScale1
            // 
            this.lblScale1.Location = new System.Drawing.Point(12, 126);
            this.lblScale1.Name = "lblScale1";
            this.lblScale1.Size = new System.Drawing.Size(104, 23);
            this.lblScale1.TabIndex = 4;
            this.lblScale1.Text = "Select Scale";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter 2nd temperature";
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(172, 180);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(120, 20);
            this.txtTemp2.TabIndex = 6;
            // 
            // lblScale2
            // 
            this.lblScale2.Location = new System.Drawing.Point(12, 218);
            this.lblScale2.Name = "lblScale2";
            this.lblScale2.Size = new System.Drawing.Size(104, 23);
            this.lblScale2.TabIndex = 7;
            this.lblScale2.Text = "Select Scale";
            // 
            // lblTempCompare
            // 
            this.lblTempCompare.Location = new System.Drawing.Point(12, 264);
            this.lblTempCompare.Name = "lblTempCompare";
            this.lblTempCompare.Size = new System.Drawing.Size(280, 42);
            this.lblTempCompare.TabIndex = 9;
            this.lblTempCompare.Click += new System.EventHandler(this.lblTempCompare_Click);
            // 
            // btnCompareTemps
            // 
            this.btnCompareTemps.Location = new System.Drawing.Point(40, 324);
            this.btnCompareTemps.Name = "btnCompareTemps";
            this.btnCompareTemps.Size = new System.Drawing.Size(194, 40);
            this.btnCompareTemps.TabIndex = 10;
            this.btnCompareTemps.Text = "Compare Temperatures";
            this.btnCompareTemps.UseVisualStyleBackColor = true;
            this.btnCompareTemps.Click += new System.EventHandler(this.btnCompareTemps_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celcius"});
            this.comboBox1.Location = new System.Drawing.Point(172, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celcius"});
            this.comboBox2.Location = new System.Drawing.Point(172, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 374);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCompareTemps);
            this.Controls.Add(this.lblTempCompare);
            this.Controls.Add(this.lblScale2);
            this.Controls.Add(this.txtTemp2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScale1);
            this.Controls.Add(this.txtTemp1);
            this.Controls.Add(this.lblFirstTemp);
            this.Controls.Add(this.lblDescription);
            this.Name = "Form1";
            this.Text = "Form1";
    
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFirstTemp;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.Label lblScale1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.Label lblScale2;
        private System.Windows.Forms.Label lblTempCompare;
        private System.Windows.Forms.Button btnCompareTemps;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

