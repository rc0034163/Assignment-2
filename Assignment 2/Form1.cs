﻿using System;
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
            double R1 = Convert.ToDouble(textBox1.Text);
            double R2 = Convert.ToDouble(textBox2.Text);
            double R3 = Convert.ToDouble(textBox3.Text);
            double Messageboxshow = (R1 + R2 + R3);
            double decayconstant = 1 / Messageboxshow;
        }
    }
}
