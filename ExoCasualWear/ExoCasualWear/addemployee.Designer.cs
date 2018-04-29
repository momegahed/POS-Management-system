namespace ExoCasualWear
{
    partial class addemployee
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
            this.addemployeebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(145, 187);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(116, 22);
            this.fname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addemployeebutton
            // 
            this.addemployeebutton.Location = new System.Drawing.Point(325, 401);
            this.addemployeebutton.Name = "addemployeebutton";
            this.addemployeebutton.Size = new System.Drawing.Size(155, 67);
            this.addemployeebutton.TabIndex = 8;
            this.addemployeebutton.Text = "Add Employee";
            this.addemployeebutton.UseVisualStyleBackColor = true;
            this.addemployeebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(385, 187);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(116, 22);
            this.lname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(145, 245);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(116, 22);
            this.id.TabIndex = 11;
            this.id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(385, 248);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(262, 114);
            this.address.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Supervisor ID";
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(145, 302);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(116, 22);
            this.sid.TabIndex = 15;
            // 
            // addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.addemployeebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Name = "addemployee";
            this.Text = " ";
            this.Load += new System.EventHandler(this.addemployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addemployeebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sid;
    }
}