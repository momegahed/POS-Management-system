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
    public partial class EditStore : Form
    {
       
        public EditStore(int IDe)
        {
            InitializeComponent();
            ID.Text = IDe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.editStore(Int32.Parse(ID.Text), Int16.Parse(OH.Text), City.Text, Street.Text, State.Text);
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
