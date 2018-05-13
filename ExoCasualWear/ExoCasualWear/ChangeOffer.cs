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
    public partial class ChangeOffer : Form
    {
        private Controller controllerObj;

        public ChangeOffer()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectItemNumber();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ItemNO#";
        }


        private void Btn_ChOffer_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.ChangeOffer(Int64.Parse(comboBox1.Text), float.Parse(textBox1.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
