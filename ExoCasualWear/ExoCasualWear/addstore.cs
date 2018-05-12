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
    public partial class addstore : Form
    {
        public addstore()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.AddStore(Int32.Parse(ID.Text), Int16.Parse(OH.Text), City.Text, Street.Text, State.Text);
            this.Close();
        }


    }
}
