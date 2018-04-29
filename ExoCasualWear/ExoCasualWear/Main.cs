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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salesbutton_Click(object sender, EventArgs e)
        {
            Sales f = new Sales();
            f.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additem ai = new additem();
            ai.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addemployee ae = new addemployee();
            ae.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addcustomer ac = new addcustomer();
            ac.Show();
        }

        private void totalSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalsales ts = new totalsales();
            ts.Show();
        }

        private void totalEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalemployees te = new totalemployees();
            te.Show();
        }

        private void itemsFrequencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostsolditemperstore ms = new mostsolditemperstore();
            ms.Show();
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemdetails id = new itemdetails();
            id.Show();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberdetails md = new memberdetails();
            md.Show();
        }

        private void shipmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shipmentdetails sd = new shipmentdetails();

            sd.Show();
        }
    }
}
