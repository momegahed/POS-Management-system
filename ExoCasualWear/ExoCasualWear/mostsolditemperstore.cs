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
    public partial class mostsolditemperstore : Form
    {
        Controller c= new Controller ();
        public mostsolditemperstore()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c.itemNotsold(itemidtextbox.Text);
            dataGridView2.Refresh();
            dataGridView1.DataSource = c.MostSoldItemPerStore();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = c.MostSoldItemPerStore();
            dataGridView1.Refresh();
        }
    }
}
