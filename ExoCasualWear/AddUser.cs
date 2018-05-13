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
    public partial class AddUser : Form
    {
        private Controller controllerObj;

        public AddUser()
        {
            InitializeComponent();
        }

     

        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.AddUser(TxtBx_username.Text, TxtBx_password.Text, TxtBx_ID.Text, comboBox_Type.Text,TxtBx_Security.Text);
            this.Hide();
            ManageUsers ManageUsersForm= new ManageUsers();
            ManageUsersForm.Show();

        }

        

       

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
