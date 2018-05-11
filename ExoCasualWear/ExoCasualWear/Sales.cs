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
        Controller c = new Controller();
        DataTable buffer = new DataTable();

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    
        private void plusbutton_Click(object sender, EventArgs e)
        {
           i = dataGridView1.CurrentRow.Index;
           if (dataGridView1.Rows[i].Cells[3].Value != null)
           {
               int amount = (Int32)dataGridView1.Rows[i].Cells[3].Value;


               dataGridView1.Rows[i].Cells[3].Value = amount + 1;
           }
        }

        private void minusbutton_Click(object sender, EventArgs e)
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
            else if(dataGridView1.Rows.Count > 1) { dataGridView1.Rows.RemoveAt(i); }
        }

  



        private void barcodeentrytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void barcodeentrytextbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

             /*     DataTable itemdata = c.ItemProfile(Int64.Parse(barcodeentrytextbox.Text));
                //buffer.Rows.Add(itemdata.Rows[0].ItemArray);
                   dataGridView1.
                 dataGridView1.Refresh();
                   barcodeentrytextbox.Text = ";"*/
              
                
                dt = c.getItem(Int64.Parse(barcodeentrytextbox.Text));
            

                buffer.Rows.Add(dt.Rows[0].ItemArray);
                dataGridView1.DataSource = buffer;

            }
        }
    }
}
