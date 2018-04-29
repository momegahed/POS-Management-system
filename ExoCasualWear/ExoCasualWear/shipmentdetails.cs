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
        Controller c;
        public shipmentdetails()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.ShipmentProfile(itemidtextbox.Text);
            dataGridView1.Refresh();
        }
    }
}
