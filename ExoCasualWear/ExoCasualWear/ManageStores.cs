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
        int IDe;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
             IDe = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
             ID.Text = IDe.ToString();
        }


    }
}
