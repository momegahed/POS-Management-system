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
    public partial class Employees_List : Form
    {
        public Employees_List()
        {
            InitializeComponent();
            Controller c = new Controller();
            DataTable dt = c.Employees_List();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
