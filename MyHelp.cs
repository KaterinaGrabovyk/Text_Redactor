﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1
{
    public partial class MyHelp : Form
    {
        public MyHelp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("cmd", "/c start https://github.com/KaterinaGrabovyk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
