﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_word_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer_Tick: " + DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Heyo!");
            this.timer.Start();
        }
    }
}
