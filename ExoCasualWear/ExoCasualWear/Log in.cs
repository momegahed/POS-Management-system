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

    public enum Privileges
    {
        Shop_Owner = 1,
        Manager = 2,
        Sales_Assistant = 3

    }

    public partial class Login : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj;
        public Login()
        {
            InitializeComponent();
        }



        private void Btn_Login_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int privlg = controllerObj.CheckPassword(TxtBx_username.Text, TextBx_pass.Text);
            if (privlg > 0)
            {
                //Login successful
                _loggedin = true;
                MessageBox.Show(" CORRECT !");

                this.Hide();
                Main mainform = new Main();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }


        private void Btn_pass_Click(object sender, EventArgs e)
        {
            forgetpass newpass = new forgetpass();
            this.Hide();
            newpass.Show();
        }

        private void TextBx_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
 }

