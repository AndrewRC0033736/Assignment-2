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

        private void Button2_Click(object sender, EventArgs e)
        {
            double R3, R4, Overall_R;
            try
            {
                R3 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show(textBox4.Text + " is not a number");
                R3 = 0.0;
            }
            try
            {
                R4 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show(textBox5.Text + " is not a number");
                R4 = 0.0;
            }

            Overall_R = 1.0 / (1.0 / R3 + 1.0 / R4);
            textBox6.Text = String.Empty;
            textBox6.AppendText(Overall_R.ToString() + "\n");
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double R5, R6, R7, Overall_R;
            try
            {
                R5 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show(textBox7.Text + " is not a number");
                R5 = 0.0;
            }
            try
            {
                R6 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show(textBox8.Text + " is not a number");
                R6 = 0.0;
            }
            try
            {
                R7 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show(textBox9.Text + " is not a number");
                R7 = 0.0;
            }
            Overall_R = R5 + R6 + R7;
            textBox10.Text = String.Empty;
            textBox10.AppendText(Overall_R.ToString() + "\n");
        }
    }
}
