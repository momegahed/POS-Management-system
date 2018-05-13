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
    

    public partial class Offer : Form
    {
        Controller controllerObj;

        public Offer()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.Offer();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_ChangeOffer_Click(object sender, EventArgs e)
        {
            ChangeOffer choff = new ChangeOffer();
            choff.Show();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.Offer();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Btn_AddOffer_Click(object sender, EventArgs e)
        {
            AddOffer addof = new AddOffer();
            addof.Show();
        }
    }
}
