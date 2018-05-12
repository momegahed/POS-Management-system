using System;
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
    public partial class Customer_Profile : Form
    {
        public Customer_Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            DataTable dt = c.CustomerProfile(int.Parse(ID.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
