﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResults.Text = txtResults.Text + "2";

        }
    }
}
