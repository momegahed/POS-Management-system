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
    public partial class ManageUsers : Form
    {
        Controller controllerObj;

        public ManageUsers()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectUser();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

       
        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser AddUserForm = new AddUser();
            AddUserForm.Show();
        }

        private void Btn_DeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser DeleteUserForm = new DeleteUser();
            DeleteUserForm.Show();
        }

        private void Btn_ChangePriv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserType ChangeUserTypeForm = new ChangeUserType();
            ChangeUserTypeForm.Show();
        }

    }
}
