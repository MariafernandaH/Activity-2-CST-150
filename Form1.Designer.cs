namespace Activity_2
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lengthinfeet = new System.Windows.Forms.TextBox();
            this.lengthinff = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "How Many Football Fields?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Length in feet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "football field(s)";
            // 
            // lengthinfeet
            // 
            this.lengthinfeet.Location = new System.Drawing.Point(525, 125);
            this.lengthinfeet.Name = "lengthinfeet";
            this.lengthinfeet.Size = new System.Drawing.Size(254, 26);
            this.lengthinfeet.TabIndex = 3;
            this.lengthinfeet.TextChanged += new System.EventHandler(this.lengthinfeet_TextChanged);
            // 
            // lengthinff
            // 
            this.lengthinff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lengthinff.Location = new System.Drawing.Point(527, 206);
            this.lengthinff.Name = "lengthinff";
            this.lengthinff.ReadOnly = true;
            this.lengthinff.Size = new System.Drawing.Size(251, 26);
            this.lengthinff.TabIndex = 4;
            this.lengthinff.TextChanged += new System.EventHandler(this.calculate_Click);
            // 
            // calculate
            // 
            this.calculate.AutoSize = true;
            this.calculate.Location = new System.Drawing.Point(525, 321);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(254, 38);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1464, 623);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.lengthinff);
            this.Controls.Add(this.lengthinfeet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lengthinfeet;
        private System.Windows.Forms.TextBox lengthinff;
        private System.Windows.Forms.Button calculate;
    }
}
