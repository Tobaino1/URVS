﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URVS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            Reqblock myform = new Reqblock();
            this.Hide();
            myform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retrieval myform = new Retrieval();
            this.Hide();
            myform.Show();
        }
    }
}
