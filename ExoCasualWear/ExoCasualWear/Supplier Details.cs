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
    public partial class Supplier_Details : Form
    {
        Controller c = new Controller();

        public Supplier_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Supplier_Details(Int32.Parse(ID.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }


    }
}
