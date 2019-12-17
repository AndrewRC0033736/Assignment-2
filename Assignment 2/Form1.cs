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
                MessageBox.Show( R1 + " is not a number");
            }

            try
            {
                R2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show( R2 + " is not a number");
            }

            R1 = double.Parse(textBox1.Text);
            R2 = double.Parse(textBox2.Text);
            Overall_R = R1 + R2;
            textBox3.AppendText(Overall_R.ToString() + "\n");

        }
    }
}
