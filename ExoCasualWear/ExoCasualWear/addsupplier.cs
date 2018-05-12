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
    public partial class addsupplier : Form
    {
        public addsupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.AddSupplier(Int32.Parse(ID.Text),FName.Text,LName.Text,City.Text,Street.Text,State.Text,Phone.Text,Mail.Text);
        }

    }
}
