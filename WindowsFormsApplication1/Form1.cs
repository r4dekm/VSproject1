﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                Console.Out.WriteLine("no name provided");
            }
            else
            {
                Console.Out.WriteLine(this.textBox1.Text + " has signed in");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
            Application.Exit();
        }
    }
}
