namespace ExoCasualWear
{
    partial class Sign_up
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
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBx_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(155, 104);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(195, 22);
            this.TxtBx_username.TabIndex = 12;
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBx_pass.Location = new System.Drawing.Point(155, 170);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(195, 22);
            this.TxtBx_pass.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 17);
            this.label.TabIndex = 8;
            this.label.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // Btn_signup
            // 
            this.Btn_signup.Location = new System.Drawing.Point(178, 235);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(134, 60);
            this.Btn_signup.TabIndex = 10;
            this.Btn_signup.Text = "&Sign up";
            this.Btn_signup.UseVisualStyleBackColor = true;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // TxtBx_ID
            // 
            this.TxtBx_ID.Location = new System.Drawing.Point(155, 52);
            this.TxtBx_ID.Name = "TxtBx_ID";
            this.TxtBx_ID.Size = new System.Drawing.Size(195, 22);
            this.TxtBx_ID.TabIndex = 14;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 345);
            this.Controls.Add(this.TxtBx_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.TxtBx_username);
            this.Name = "Sign_up";
            this.Text = "Sign_up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBx_ID;
    }
}