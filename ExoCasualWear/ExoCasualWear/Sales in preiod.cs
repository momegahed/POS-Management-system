﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoCasualWear
{
    public partial class Sales_in_preiod : Form
    {
        public Sales_in_preiod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Controller c = new Controller();
             DataTable dt = c.ItemSold_Period(start.Text, end.Text);
             dataGridView1.DataSource = dt;
             dataGridView1.Refresh();
        }
    }
}
