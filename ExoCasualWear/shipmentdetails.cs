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
    public partial class shipmentdetails : Form
    {
        Controller c=new Controller();
        public shipmentdetails()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = c.ShipmentProfile(Int32.Parse(itemidtextbox.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
