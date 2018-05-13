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
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.InsertItems(Int64.Parse(itemno.Text), itemdescription.Text, ItemDetailedDiscription.Text,double.Parse(price.Text), category.Text, "");
        }

        private void additem_Load(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
