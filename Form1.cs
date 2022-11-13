using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        private readonly object lengthinfeetTextBox;
        private readonly object lengthinffTextBox;

        public Form1()
        {
            InitializeComponent();
        }


        private void length_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double lengthinfeet;
            double lengthinff;
            lengthinfeet = double.Parse(lengthinfeetTextBox.Text);
            lengthinff = double.Parse(lengthinffTextBox.Text);
            lengthinff = lengthinfeet / 360;
            lengthinffTextBox.Text = lengthinff.ToString();
            //This is as far as I'm able to take this project. I'm not sure why the .Text error keeps showing up and I've tried several different
            //ways to troubleshoot this error
        }

        private void lengthinfeet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
