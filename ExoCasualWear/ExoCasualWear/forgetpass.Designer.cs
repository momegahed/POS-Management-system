namespace ExoCasualWear
{
    partial class forgetpass
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
            this.TxtBx_newpass = new System.Windows.Forms.TextBox();
            this.Btn_confirmpass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBx_username2 = new System.Windows.Forms.TextBox();
            this.TxtBx_Security = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a new password";
            // 
            // TxtBx_newpass
            // 
            this.TxtBx_newpass.Location = new System.Drawing.Point(349, 215);
            this.TxtBx_newpass.Name = "TxtBx_newpass";
            this.TxtBx_newpass.Size = new System.Drawing.Size(197, 22);
            this.TxtBx_newpass.TabIndex = 1;
            this.TxtBx_newpass.TextChanged += new System.EventHandler(this.TxtBx_newpass_TextChanged);
            // 
            // Btn_confirmpass
            // 
            this.Btn_confirmpass.Location = new System.Drawing.Point(258, 263);
            this.Btn_confirmpass.Name = "Btn_confirmpass";
            this.Btn_confirmpass.Size = new System.Drawing.Size(137, 31);
            this.Btn_confirmpass.TabIndex = 2;
            this.Btn_confirmpass.Text = "confirm";
            this.Btn_confirmpass.UseVisualStyleBackColor = true;
            this.Btn_confirmpass.Click += new System.EventHandler(this.Btn_confirmpass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "username";
            // 
            // TxtBx_username2
            // 
            this.TxtBx_username2.Location = new System.Drawing.Point(349, 60);
            this.TxtBx_username2.Name = "TxtBx_username2";
            this.TxtBx_username2.Size = new System.Drawing.Size(197, 22);
            this.TxtBx_username2.TabIndex = 4;
            this.TxtBx_username2.TextChanged += new System.EventHandler(this.TxtBx_username2_TextChanged);
            // 
            // TxtBx_Security
            // 
            this.TxtBx_Security.Location = new System.Drawing.Point(349, 130);
            this.TxtBx_Security.Name = "TxtBx_Security";
            this.TxtBx_Security.Size = new System.Drawing.Size(197, 22);
            this.TxtBx_Security.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "What is your favourite food ?";
            // 
            // forgetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBx_Security);
            this.Controls.Add(this.TxtBx_username2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_confirmpass);
            this.Controls.Add(this.TxtBx_newpass);
            this.Controls.Add(this.label1);
            this.Name = "forgetpass";
            this.Text = "forgetpass";
            this.Load += new System.EventHandler(this.forgetpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBx_newpass;
        private System.Windows.Forms.Button Btn_confirmpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBx_username2;
        private System.Windows.Forms.TextBox TxtBx_Security;
        private System.Windows.Forms.Label label3;
    }
}