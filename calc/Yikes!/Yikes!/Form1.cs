﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yikes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rnd_Click2(object sender, EventArgs e)
        {
            CalculateTwoArg cal2 = new CalculateTwoArg();
            double currnum1 = Convert.ToDouble(textBox1.Text), currnum2 = Convert.ToDouble(textBox2.Text), endres;
            endres = cal2.Calculate(sender, currnum1, currnum2);
            label1.Text = Convert.ToString(endres);
        }

        private void rnd_Click1(object sender, EventArgs e)
        {
            CalculateOneArg cal1 = new CalculateOneArg();
            double currnum = Convert.ToDouble(textBox1.Text), endres;
            endres = cal1.Calculate(sender, currnum);
            label1.Text = Convert.ToString(endres);
        }
    }
}
