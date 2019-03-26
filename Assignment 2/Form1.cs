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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double doubletotal = (R1 + R2 + R3);
                MessageBox.Show(doubletotal.ToString("0.00") + "ohms");
            }
            catch
            {
                MessageBox.Show(" Error the input is incorrect");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double R4 = Convert.ToDouble(textBox4.Text);
                double R5 = Convert.ToDouble(textBox5.Text);
                double R6 = Convert.ToDouble(textBox6.Text);
                double doubletotal = 1 / (1 / R4 + 1 / R5 + 1 / R6);
                MessageBox.Show(doubletotal.ToString("0.00") + "ohms");
            }
            catch
            {
                MessageBox.Show(" Error the input is incorrect");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
