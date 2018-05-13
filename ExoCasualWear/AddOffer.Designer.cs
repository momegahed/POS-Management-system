namespace ExoCasualWear
{
    partial class AddOffer
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
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_ShowPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Bx_Offer = new System.Windows.Forms.TextBox();
            this.Btn_AddOffer = new System.Windows.Forms.Button();
            this.ComboBox_Item = new System.Windows.Forms.ComboBox();
            this.ComboBox_Brand = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBx_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Discription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // Btn_ShowPrice
            // 
            this.Btn_ShowPrice.Location = new System.Drawing.Point(418, 200);
            this.Btn_ShowPrice.Name = "Btn_ShowPrice";
            this.Btn_ShowPrice.Size = new System.Drawing.Size(270, 69);
            this.Btn_ShowPrice.TabIndex = 5;
            this.Btn_ShowPrice.Text = "Show Price";
            this.Btn_ShowPrice.UseVisualStyleBackColor = true;
            this.Btn_ShowPrice.Click += new System.EventHandler(this.Btn_ShowPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Offer";
            // 
            // Txt_Bx_Offer
            // 
            this.Txt_Bx_Offer.Location = new System.Drawing.Point(55, 551);
            this.Txt_Bx_Offer.Name = "Txt_Bx_Offer";
            this.Txt_Bx_Offer.Size = new System.Drawing.Size(111, 22);
            this.Txt_Bx_Offer.TabIndex = 7;
            // 
            // Btn_AddOffer
            // 
            this.Btn_AddOffer.Location = new System.Drawing.Point(418, 665);
            this.Btn_AddOffer.Name = "Btn_AddOffer";
            this.Btn_AddOffer.Size = new System.Drawing.Size(270, 69);
            this.Btn_AddOffer.TabIndex = 8;
            this.Btn_AddOffer.Text = "Add Offer";
            this.Btn_AddOffer.UseVisualStyleBackColor = true;
            this.Btn_AddOffer.Click += new System.EventHandler(this.Btn_AddOffer_Click);
            // 
            // ComboBox_Item
            // 
            this.ComboBox_Item.FormattingEnabled = true;
            this.ComboBox_Item.Location = new System.Drawing.Point(55, 110);
            this.ComboBox_Item.Name = "ComboBox_Item";
            this.ComboBox_Item.Size = new System.Drawing.Size(260, 24);
            this.ComboBox_Item.TabIndex = 9;
            // 
            // ComboBox_Brand
            // 
            this.ComboBox_Brand.FormattingEnabled = true;
            this.ComboBox_Brand.Location = new System.Drawing.Point(731, 110);
            this.ComboBox_Brand.Name = "ComboBox_Brand";
            this.ComboBox_Brand.Size = new System.Drawing.Size(260, 24);
            this.ComboBox_Brand.TabIndex = 11;
            this.ComboBox_Brand.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Brand_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(270, 46);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Offer Start Date\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Offer End Date\r\n";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(533, 547);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(94, 22);
            this.dateTimePickerStart.TabIndex = 17;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(882, 547);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(104, 22);
            this.dateTimePickerEnd.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Offer ID";
            // 
            // TxtBx_ID
            // 
            this.TxtBx_ID.Location = new System.Drawing.Point(261, 549);
            this.TxtBx_ID.Name = "TxtBx_ID";
            this.TxtBx_ID.Size = new System.Drawing.Size(111, 22);
            this.TxtBx_ID.TabIndex = 20;
            // 
            // AddOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 769);
            this.Controls.Add(this.TxtBx_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBox_Brand);
            this.Controls.Add(this.ComboBox_Item);
            this.Controls.Add(this.Btn_AddOffer);
            this.Controls.Add(this.Txt_Bx_Offer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_ShowPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOffer";
            this.Text = "AddOffer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_ShowPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Bx_Offer;
        private System.Windows.Forms.Button Btn_AddOffer;
        private System.Windows.Forms.ComboBox ComboBox_Item;
        private System.Windows.Forms.ComboBox ComboBox_Brand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBx_ID;
    }
}