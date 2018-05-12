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
    public partial class DeleteUser : Form
    {
        private Controller controllerObj;

        public DeleteUser()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectUsername();
            comboBox_Delete.DataSource = dt;
            comboBox_Delete.DisplayMember = "username";
        }

        private void Bt_DeleteUser_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();

            controllerObj.DeleteUser(comboBox_Delete.Text);
            this.Hide();
            ManageUsers ManageUsersForm = new ManageUsers();
            ManageUsersForm.Show();

        }

    }
}
