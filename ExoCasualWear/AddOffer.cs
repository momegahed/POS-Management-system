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
    public partial class AddOffer : Form
    {
        Controller controllerObj;

        public AddOffer()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt2 = controllerObj.SelectOfferItem();
            ComboBox_Item.DataSource = dt2;
            ComboBox_Item.DisplayMember = "Item_discription";

            DataTable dt = controllerObj.SelectOfferBrand();
            ComboBox_Brand.DataSource = dt;
            ComboBox_Brand.DisplayMember = "Brand";
        }

        private void Btn_ShowPrice_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt3 = controllerObj.Price(ComboBox_Item.Text, ComboBox_Brand.Text);
            dataGridView1.DataSource = dt3;
            dataGridView1.Refresh();
        }

        private void ComboBox_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_AddOffer_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            controllerObj.AddOffer(float.Parse(Txt_Bx_Offer.Text), dateTimePickerStart.Text,dateTimePickerEnd.Text, int.Parse(TxtBx_ID.Text), ComboBox_Item.Text,ComboBox_Brand.Text);
            MessageBox.Show("The offer has been added");
        }
    }
}
