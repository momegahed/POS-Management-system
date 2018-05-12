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
    public partial class Login_or_Sign_up : Form
    {

        public Login_or_Sign_up()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Sign_up sign = new Sign_up();
            this.Hide();
            sign.Show();
        }
    }
}
