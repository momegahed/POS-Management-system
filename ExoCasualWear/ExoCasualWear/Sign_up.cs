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
    public partial class Sign_up : Form
    {
        private Controller controllerObj;

        public Sign_up()
        {
            InitializeComponent();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.CreateNormalAccount(TxtBx_username.Text, TxtBx_pass.Text,TxtBx_ID.Text);
            Main mainform = new Main();
            this.Hide();
            mainform.Show();


        }

       
    }
}
