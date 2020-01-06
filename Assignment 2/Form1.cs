using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1, R2, Overall_R;
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show( textBox1.Text + " is not a number");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show( textBox2.Text + " is not a number");
                R2 = 0.0;
            }


            Overall_R = R1 + R2;
            textBox3.Text = String.Empty;
            textBox3.AppendText(Overall_R.ToString() + "\n");

        }
    }
}
