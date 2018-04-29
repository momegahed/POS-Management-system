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
    public partial class memberdetails : Form
    {
        Controller c;
        public memberdetails()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.MemberProfile(itemidtextbox.Text);
            dataGridView1.Refresh();
        }
    }
}
