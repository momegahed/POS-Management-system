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
    public partial class itemdetails : Form
    {
        Controller c = new Controller();
        public itemdetails()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.ItemProfile(Int64.Parse(itemidtextbox.Text));
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemidtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
