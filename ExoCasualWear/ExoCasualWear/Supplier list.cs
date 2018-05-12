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
    public partial class Supplier_list : Form
    {
        public Supplier_list()
        {
            InitializeComponent();
            Controller c = new Controller();
            DataTable dt = c.getSups();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
