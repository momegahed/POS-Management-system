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
    public partial class addshipment : Form
    {

        Controller c = new Controller();

        public addshipment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addshipment_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Store_Details(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "St_Street";
         //   comboBox1.ValueMember = "SupplierID#";
           // dataGridView1.DataSource = bs;
           // dataGridView1.Refresh();
            // TODO: This line of code loads data into the 'exoDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.exoDataSet1.Supplier);
            // TODO: This line of code loads data into the 'exoDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.exoDataSet1.Supplier);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
