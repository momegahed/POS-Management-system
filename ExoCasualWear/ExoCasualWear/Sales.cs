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
    public partial class Sales : Form
    {
        int i;
        Int64 RID; // receipt ID
        Controller c = new Controller();
        DataTable buffer = new DataTable();
        double totalPrice = 0.0, totalDiscount = 0.0, netPrice = 0.0;
        DataTable dt = new DataTable();
         
        public Sales()
        {
            InitializeComponent();
            this.dataGridView1.Columns[0].ValueType = typeof(Int32);
            this.dataGridView1.Columns[1].ValueType = typeof(String);
            this.dataGridView1.Columns[2].ValueType = typeof(Int32);
            this.dataGridView1.Columns[3].ValueType = typeof(Int32);
            this.dataGridView1.Columns[4].ValueType = typeof(Int32);

;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;  // Disable autogeneration of columns


            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name);

                col.DataPropertyName = col.Name;
            }
            buffer = dt;
            buffer =c.getItem(1);
            buffer.Rows.Clear();


            RID = c.Receipt_AG() + 1;
            invoicenumber.Text = RID.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    
        private void plusbutton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                i = dataGridView1.CurrentRow.Index;
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    int amount = (Int32)dataGridView1.Rows[i].Cells[3].Value;


                    dataGridView1.Rows[i].Cells[3].Value = amount + 1;
                }
            }
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            
            if (this.dataGridView1.Rows.Count > 0)
            {
                i = this.dataGridView1.CurrentRow.Index;

                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    int amount = (Int32)dataGridView1.Rows[i].Cells[3].Value;
                    if (amount > 1)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = amount - 1;

                    }
                    else if (amount == 1) { dataGridView1.Rows.RemoveAt(i); }

                }
                else if (dataGridView1.Rows.Count > 1) { dataGridView1.Rows.RemoveAt(i); }
            }

        }
  



        private void barcodeentrytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeentrytextbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows) {

                    if (barcodeentrytextbox.Text == row.Cells[0].Value.ToString()) {
                        
                        int amount = (Int32) row.Cells[3].Value;

                        row.Cells[3].Value = amount + 1;
                        barcodeentrytextbox.Text = "";
                        return;
                    
                    }

                
                
                
                }



                try
                {
                    dt = c.getItem(Int64.Parse(barcodeentrytextbox.Text));
                }
                catch (Exception ee) { MessageBox.Show("ERROR");
                dt = null;
                }
                    if (dt != null)
                    {
                        buffer.Rows.Add(dt.Rows[0].ItemArray);
                        barcodeentrytextbox.Text = "";

                    }
                    else { 
                      MessageBox.Show("This item doesn't exist");
                    barcodeentrytextbox.Text = "";
                    }
                    dataGridView1.DataSource = buffer;
                    dataGridView1.Refresh();
              //  

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            totalPrice = 0.0; totalDiscount = 0.0; netPrice = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int amount = (Int32)row.Cells[3].Value;
                Double price = Double.Parse(row.Cells[2].Value.ToString());
                Double discount = Double.Parse(row.Cells[4].Value.ToString());



                totalPrice += price * amount;
                totalDiscount += price * amount * discount;
            }

            netPrice = totalPrice - totalDiscount;
            this.netprice.Text = netPrice.ToString();
            this.totalprice.Text = totalPrice.ToString();
            this.totaldiscount.Text = totalDiscount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void totalprice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            totalPrice = 0.0; totalDiscount = 0.0; netPrice = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int amount = (Int32)row.Cells[3].Value;
                Double price = Double.Parse(row.Cells[2].Value.ToString());
                Double discount = Double.Parse(row.Cells[4].Value.ToString());



                totalPrice += price * amount;
                totalDiscount += price * amount * discount;
            }

            netPrice = totalPrice - totalDiscount;
            this.netprice.Text = netPrice.ToString();
            this.totalprice.Text = totalPrice.ToString();
            this.totaldiscount.Text = totalDiscount.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalPrice = 0.0; totalDiscount = 0.0; netPrice = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int amount = (Int32)row.Cells[3].Value;
                Double price = Double.Parse(row.Cells[2].Value.ToString());
                Double discount = Double.Parse(row.Cells[4].Value.ToString());



                totalPrice += price * amount;
                totalDiscount += price * amount * discount;
            }

            netPrice = totalPrice - totalDiscount;
            this.netprice.Text = netPrice.ToString();
            this.totalprice.Text = totalPrice.ToString();
            this.totaldiscount.Text = totalDiscount.ToString();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {

            if (buffer.Rows.Count > 0)
            {

                c.CreateNewReceipt(RID, totalPrice, totalDiscount, 1, 1);
                foreach (DataRow row in buffer.Rows)
                {
                    Int64 Itemno = Int64.Parse(row["itemnumber"].ToString());

                    Double descount = Double.Parse(row["discount"].ToString());
                    int Quantity = Int32.Parse(row["Quantity"].ToString());
                    c.fillR(RID, 1, Itemno, row["price"].ToString(), descount, Quantity);



                }

                c.printR(Int32.Parse(RID.ToString()));
                this.Close();

            }
            else { MessageBox.Show("Please add Items first", "Error"); }
        }


    }
}
