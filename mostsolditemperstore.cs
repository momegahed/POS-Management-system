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
    public partial class mostsolditemperstore : Form
    {
        Controller c;
        public mostsolditemperstore()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.ItemProfile(itemidtextbox.Text);
        }
    }
}
