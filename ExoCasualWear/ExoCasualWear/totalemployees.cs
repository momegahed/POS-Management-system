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
    public partial class totalemployees : Form
    {
        public totalemployees()
        {
            InitializeComponent();
        }
        Controller c = new Controller();
        private void totals_Click(object sender, EventArgs e)
        {
          

            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            totals.Text = c.CalcEmp().ToString();
        }
    }
}
