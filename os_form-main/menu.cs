﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_form
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game game = new Game ();
            game.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator calculator = new calculator();
            calculator.Show();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = Convert.ToString(DateTime.Now);
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {

        }
    }
}