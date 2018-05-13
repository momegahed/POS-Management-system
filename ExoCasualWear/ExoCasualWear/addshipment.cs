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
    public partial class addshipment : Form
    {
        int i;
        int ShipmentID,SUBID;
        DataTable dt;
        Controller c = new Controller();
        DataTable shipmentinfo = new DataTable();
        public addshipment()
        {
            InitializeComponent();
        }

        

        private void addshipment_Load(object sender, EventArgs e)
        {
            ShipmentID = c.Shipment_AG() + 1;
            sid.Text = ShipmentID.ToString();

           dt = c.Store_Details(); 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "St_Street";
            
           comboBox1.ValueMember = "Store#";
            dataGridView1.DataSource = shipmentinfo;
           // dataGridView1.Refresh()
            // TODO: This line of code loads data into the 'exoDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.exoDataSet1.Supplier);
            // TODO: This line of code loads data into the 'exoDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.exoDataSet1.Supplier);
            shipmentinfo.Columns.Add("ItemNo");
            shipmentinfo.Columns.Add("Store ID");
            shipmentinfo.Columns.Add("Quantity");

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            try
            {
               dt = c.getItem(Int64.Parse(itemnotextbox.Text));
            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR");
                dt = null;
            }
            if (dt != null)
            {
                if (quantitytextbox.Text != "")
                {
                    DataRow dr = shipmentinfo.NewRow();
                    dr[0] = itemnotextbox.Text;
                    dr[1] = comboBox1.SelectedValue;
                    dr[2] = quantitytextbox.Text;
                    shipmentinfo.Rows.Add(dr);
                    itemnotextbox.Text = "";
                    quantitytextbox.Text = "";
                }
                else { MessageBox.Show("Please enter Quantity");
                return;                
                }
            }
            else
            {
                MessageBox.Show("This item doesn't exist");
                itemnotextbox.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (shipmentinfo.Rows.Count > 0)
            {

                c.CreateNewShip(ShipmentID,SUBID);
                foreach (DataRow row in shipmentinfo.Rows)
                {
                    Int64 Itemno = Int64.Parse(row["ItemNo"].ToString());

                    int storeid = Int32.Parse(row["Store ID"].ToString());
                    int Quantity = Int32.Parse(row["Quantity"].ToString());
                    c.fillship(Itemno , storeid ,ShipmentID, Quantity);
                   


                }
                MessageBox.Show("Shipment added successfully");

                this.Close();
            }
            else { MessageBox.Show("Please add Items first", "Error"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = this.dataGridView2.CurrentRow.Index;
            SUBID = Int32.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
        }
    }
}
