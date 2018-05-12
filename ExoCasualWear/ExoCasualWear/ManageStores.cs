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
    public partial class ManageStores : Form
    {
        public ManageStores()
        {
            InitializeComponent();
            Controller c = new Controller();
            DataTable dt = c.Store_Details();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            addstore ads = new addstore();
            ads.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
        }

    }
}
