﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double s1,s2;
        int op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    private void button15_Click(object sender, EventArgs e)
        {
            s2 = 0;
            switch (op)
            {
                case '+':
                    s2 = s1 + double.Parse(textBox1.Text);
                    textBox1.Text = s2.ToString();
                    break;

                case '-':
                    s2 = s1 - double.Parse(textBox1.Text);
                    textBox1.Text = s2.ToString();
                    break;

                case '/':
                    s2 = s1 /double.Parse(textBox1.Text);
                    textBox1.Text = s2.ToString();
                    break;

                case '*':
                    s2 = s1 * double.Parse(textBox1.Text);
                    textBox1.Text = s2.ToString();
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            textBox1.Focus();
            op = '+';
        }

        private void button9_Click(object sender, EventArgs e)
        {

            s1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            textBox1.Focus();
            op = '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {

            s1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            textBox1.Focus();
            op = '/';
        }

        private void button16_Click(object sender, EventArgs e)
        {

            s1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            textBox1.Focus();
            op = '*';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
