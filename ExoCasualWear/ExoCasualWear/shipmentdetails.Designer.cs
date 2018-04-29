namespace ExoCasualWear
{
    partial class shipmentdetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemidtextbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment ID";
            // 
            // itemidtextbox
            // 
            this.itemidtextbox.Location = new System.Drawing.Point(476, 108);
            this.itemidtextbox.Name = "itemidtextbox";
            this.itemidtextbox.Size = new System.Drawing.Size(337, 22);
            this.itemidtextbox.TabIndex = 1;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(476, 161);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(197, 78);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 209);
            this.dataGridView1.TabIndex = 3;
            // 
            // shipmentdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.itemidtextbox);
            this.Controls.Add(this.label1);
            this.Name = "shipmentdetails";
            this.Text = "shipmentdetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemidtextbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}