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
    public partial class Item_List : Form
    {
        public Item_List()
        {
            InitializeComponent();
            Controller c = new Controller();
            DataTable dt = c.Items_List();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Item ei = new Edit_Item();
            ei.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            DataTable dt = c.Items_List();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
