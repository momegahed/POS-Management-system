namespace ExoCasualWear
{
    partial class addcustomer
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
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addcustomerbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(97, 87);
            this.fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(88, 20);
            this.fname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addcustomerbutton
            // 
            this.addcustomerbutton.Location = new System.Drawing.Point(147, 206);
            this.addcustomerbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addcustomerbutton.Name = "addcustomerbutton";
            this.addcustomerbutton.Size = new System.Drawing.Size(116, 54);
            this.addcustomerbutton.TabIndex = 8;
            this.addcustomerbutton.Text = "Add Customer";
            this.addcustomerbutton.UseVisualStyleBackColor = true;
            this.addcustomerbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(277, 87);
            this.lname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(88, 20);
            this.lname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(97, 134);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(88, 20);
            this.phonenumber.TabIndex = 11;
            this.phonenumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Subscription ID";
            // 
            // subid
            // 
            this.subid.Location = new System.Drawing.Point(276, 134);
            this.subid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subid.Name = "subid";
            this.subid.Size = new System.Drawing.Size(88, 20);
            this.subid.TabIndex = 15;
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.addcustomerbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addcustomer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.addcustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addcustomerbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subid;
    }
}