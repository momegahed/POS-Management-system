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
    public partial class ChangeUserType : Form
    {
        private Controller controllerObj;

        public ChangeUserType()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectUsername();
            comboBox_Username.DataSource = dt;
            comboBox_Username.DisplayMember = "username";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.ChangeUserType(comboBox_Username.Text, comboBox_Type.Text);
            this.Hide();
            ManageUsers ManageUsersForm = new ManageUsers();
            ManageUsersForm.Show();
        }
    }
}
