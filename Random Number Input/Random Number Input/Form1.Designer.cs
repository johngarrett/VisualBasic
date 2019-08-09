namespace Random_Number_Input
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
            this.radUpper = new System.Windows.Forms.RadioButton();
            this.radLower = new System.Windows.Forms.RadioButton();
            this.btnRand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radUpper
            // 
            this.radUpper.AutoSize = true;
            this.radUpper.Location = new System.Drawing.Point(12, 66);
            this.radUpper.Name = "radUpper";
            this.radUpper.Size = new System.Drawing.Size(85, 17);
            this.radUpper.TabIndex = 0;
            this.radUpper.TabStop = true;
            this.radUpper.Text = "radioButton1";
            this.radUpper.UseVisualStyleBackColor = true;
            // 
            // radLower
            // 
            this.radLower.AutoSize = true;
            this.radLower.Location = new System.Drawing.Point(143, 66);
            this.radLower.Name = "radLower";
            this.radLower.Size = new System.Drawing.Size(85, 17);
            this.radLower.TabIndex = 1;
            this.radLower.TabStop = true;
            this.radLower.Text = "radioButton2";
            this.radLower.UseVisualStyleBackColor = true;
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(77, 111);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(75, 23);
            this.btnRand.TabIndex = 2;
            this.btnRand.Text = "button1";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.radLower);
            this.Controls.Add(this.radUpper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUpper;
        private System.Windows.Forms.RadioButton radLower;
        private System.Windows.Forms.Button btnRand;
    }
}

