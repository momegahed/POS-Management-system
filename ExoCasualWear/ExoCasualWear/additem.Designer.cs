namespace ExoCasualWear
{
    partial class additem
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
            this.itemno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemdescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.additembutton = new System.Windows.Forms.Button();
            this.ItemDetailedDiscription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemno
            // 
            this.itemno.Location = new System.Drawing.Point(198, 187);
            this.itemno.Name = "itemno";
            this.itemno.Size = new System.Drawing.Size(282, 22);
            this.itemno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Description (Name)";
            // 
            // itemdescription
            // 
            this.itemdescription.Location = new System.Drawing.Point(198, 225);
            this.itemdescription.Multiline = true;
            this.itemdescription.Name = "itemdescription";
            this.itemdescription.Size = new System.Drawing.Size(282, 56);
            this.itemdescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(595, 187);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(158, 22);
            this.price.TabIndex = 4;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(595, 257);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(158, 24);
            this.category.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // additembutton
            // 
            this.additembutton.Location = new System.Drawing.Point(325, 401);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(155, 67);
            this.additembutton.TabIndex = 8;
            this.additembutton.Text = "Add Item";
            this.additembutton.UseVisualStyleBackColor = true;
            this.additembutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemDetailedDiscription
            // 
            this.ItemDetailedDiscription.Location = new System.Drawing.Point(198, 319);
            this.ItemDetailedDiscription.Multiline = true;
            this.ItemDetailedDiscription.Name = "ItemDetailedDiscription";
            this.ItemDetailedDiscription.Size = new System.Drawing.Size(555, 56);
            this.ItemDetailedDiscription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Detailed Description";
            // 
            // additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 589);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemDetailedDiscription);
            this.Controls.Add(this.additembutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemdescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemno);
            this.Name = "additem";
            this.Text = " ";
            this.Load += new System.EventHandler(this.additem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button additembutton;
        private System.Windows.Forms.TextBox ItemDetailedDiscription;
        private System.Windows.Forms.Label label5;
    }
}