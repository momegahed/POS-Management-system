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
    public partial class forgetpass : Form

    {
        private Controller controllerObj;

        public forgetpass()
        {
            InitializeComponent();
        }

        private void Btn_confirmpass_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.ChangePassword(TxtBx_username2.Text,TxtBx_newpass.Text, TxtBx_Security.Text);
        }

        private void forgetpass_Load(object sender, EventArgs e)
        {

        }

        private void TxtBx_username2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBx_newpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
