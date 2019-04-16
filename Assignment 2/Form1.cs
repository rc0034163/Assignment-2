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
                double R3 = 0.0;
                if (textBox3.Text == "0")
                    R3 = double.PositiveInfinity;
                else
                    R3 = Convert.ToDouble(textBox3.Text);
                double R4 = 0.0;
                if (textBox7.Text == "0")
                    R4 = double.PositiveInfinity;
                else
                     R4 = Convert.ToDouble(textBox7.Text);
                double R5 = 0.0;
                if (textBox8.Text == "0")
                    R5 = double.PositiveInfinity;
                else
                     R5 = Convert.ToDouble(textBox8.Text);
                // test the textbox to see if there is an infinity.
                double doubletotal = (R1 + R2 + R3 + R4 + R5);
                MessageBox.Show(doubletotal.ToString("0.00") + "ohms");
            }   // the answer is going to show up as a message box
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
                double R6 = Convert.ToDouble(textBox4.Text);
                double R7 = Convert.ToDouble(textBox5.Text);
                double R8 = 0.0;
                if (textBox6.Text == "0")
                    R8 = double.PositiveInfinity;
                else
                    R8 = Convert.ToDouble(textBox6.Text);
                 double R9 = 0.0;
                if (textBox9.Text == "0")
                    R9 = double.PositiveInfinity;
                else
                     R9 = Convert.ToDouble(textBox9.Text);
                double R10 = 0.0;
                if (textBox10.Text == "0")
                    R10 = double.PositiveInfinity;
                else
                     R10 = Convert.ToDouble(textBox10.Text);
                double doubletotal = 1.0 / (1.0 / R6 + 1.0 / R7 + 1.0 / R8 + 1.0 / R9 + 1.0 / R10);
                MessageBox.Show(doubletotal.ToString("0.00") + "ohms");
            }   // there is going to be a decimal and ohms at the end with this code
            catch
            {
                MessageBox.Show(" Error the input is incorrect");
            }   // the message is going to show if a letter has been put in 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
