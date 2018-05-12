namespace ExoCasualWear
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeentrytextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.plusbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totaldiscount = new System.Windows.Forms.Label();
            this.netprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemnumber,
            this.ItemDescription,
            this.price,
            this.Quantity,
            this.discount});
            this.dataGridView1.Location = new System.Drawing.Point(102, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 594);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // itemnumber
            // 
            this.itemnumber.HeaderText = "ItemNo";
            this.itemnumber.Name = "itemnumber";
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Name";
            this.ItemDescription.Name = "ItemDescription";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // barcodeentrytextbox
            // 
            this.barcodeentrytextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.barcodeentrytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeentrytextbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.barcodeentrytextbox.Location = new System.Drawing.Point(929, 196);
            this.barcodeentrytextbox.Name = "barcodeentrytextbox";
            this.barcodeentrytextbox.Size = new System.Drawing.Size(378, 45);
            this.barcodeentrytextbox.TabIndex = 1;
            this.barcodeentrytextbox.TextChanged += new System.EventHandler(this.barcodeentrytextbox_TextChanged);
            this.barcodeentrytextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeentrytextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printbutton
            // 
            this.printbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.print;
            this.printbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.printbutton.Location = new System.Drawing.Point(12, 348);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 70);
            this.printbutton.TabIndex = 5;
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // minusbutton
            // 
            this.minusbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.minus;
            this.minusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusbutton.Location = new System.Drawing.Point(12, 262);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(75, 70);
            this.minusbutton.TabIndex = 4;
            this.minusbutton.UseVisualStyleBackColor = true;
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // plusbutton
            // 
            this.plusbutton.BackgroundImage = global::ExoCasualWear.Properties.Resources.plus;
            this.plusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusbutton.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plusbutton.Location = new System.Drawing.Point(12, 173);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(75, 70);
            this.plusbutton.TabIndex = 3;
            this.plusbutton.UseVisualStyleBackColor = true;
            this.plusbutton.Click += new System.EventHandler(this.plusbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Price";
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.Location = new System.Drawing.Point(1069, 420);
            this.totalprice.MinimumSize = new System.Drawing.Size(180, 0);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(180, 39);
            this.totalprice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(828, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(828, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Net Price";
            // 
            // totaldiscount
            // 
            this.totaldiscount.AutoSize = true;
            this.totaldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldiscount.Location = new System.Drawing.Point(1069, 485);
            this.totaldiscount.MinimumSize = new System.Drawing.Size(180, 0);
            this.totaldiscount.Name = "totaldiscount";
            this.totaldiscount.Size = new System.Drawing.Size(180, 39);
            this.totaldiscount.TabIndex = 12;
            this.totaldiscount.Click += new System.EventHandler(this.label3_Click);
            // 
            // netprice
            // 
            this.netprice.AutoSize = true;
            this.netprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netprice.Location = new System.Drawing.Point(1069, 556);
            this.netprice.MinimumSize = new System.Drawing.Size(180, 0);
            this.netprice.Name = "netprice";
            this.netprice.Size = new System.Drawing.Size(180, 39);
            this.netprice.TabIndex = 13;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 779);
            this.Controls.Add(this.netprice);
            this.Controls.Add(this.totaldiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.minusbutton);
            this.Controls.Add(this.plusbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeentrytextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox barcodeentrytextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totaldiscount;
        private System.Windows.Forms.Label netprice;
    }
}