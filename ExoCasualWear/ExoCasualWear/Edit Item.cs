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
    public partial class Edit_Item : Form
    {
        public Edit_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller c = new Controller();
            c.Edit_Item(Int64.Parse(ID.Text), Des.Text, DetDes.Text,double.Parse(P.Text), Cat.Text, B.Text, Int32.Parse(Off.Text));
            this.Close();
        }
        

    }
}
